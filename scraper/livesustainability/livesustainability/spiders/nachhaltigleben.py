import scrapy
import json
import pyodbc
import uuid

class NachhaltiglebenSpider(scrapy.Spider):
    name = 'nachhaltigleben'
    allowed_domains = ['nachhaltigleben.ch']
    start_urls = [
        'https://www.nachhaltigleben.ch/food/1',
        'https://www.nachhaltigleben.ch/wohnen/1',
        'https://www.nachhaltigleben.ch/mobilitaet/1',
        'https://www.nachhaltigleben.ch/mode/1',
        'https://www.nachhaltigleben.ch/energie/1',
    ]

    topic_dict = {
        "food": 0,
        "wohnen": 1,
        "mobilitaet": 2,
        "mode": 3,
        "energie": 1
    }

    server = 'livesustainability.database.windows.net'
    database = 'livesustainability'
    username = '{username}'
    password = '{password}'
    driver = '{SQL Server}'

    def __init__(self):
        self.cnxn = pyodbc.connect('DRIVER='+self.driver+';PORT=1433;SERVER='+self.server+';PORT=1433;DATABASE='+self.database+';UID='+self.username+';PWD='+ self.password)
        self.cursor = self.cnxn.cursor()

    def parse(self, response):
        links = response.css('div#category-list ul li a::attr(href)').getall()

        for link in links:
            yield response.follow(link, callback=self.parseTip)

        next_page_url = response.css('a.button.button-next::attr(href)').get()
        if next_page_url is not None:
            self.log('INFO: discovered next_page_url: %s' % next_page_url) # debug comment
            yield response.follow(next_page_url, callback=self.parse)

    def parseTip(self, response):
        baseUrl = "https://www.nachhaltigleben.ch"
        tip_url = response.url
        tip_title = response.css('div#content-article-title h1::text').get()
        tip_teaser = response.css('div#content-article-intro p::text').get()
        tip_image_url = response.css('div#content-article-mainimage img::attr(src)').get()
        key = response.url.split('/')[3]

        if key in self.topic_dict and tip_image_url != None and tip_teaser != None:
            if baseUrl not in tip_image_url:
                tip_image_url = baseUrl + tip_image_url

            tip_topic = self.topic_dict[key]

            self.cursor.execute(f"insert into Tips(Id, Url, Title, Teaser, ImageUrl, Topic) values ('{uuid.uuid4()}','{tip_url}', '{tip_title}', '{tip_teaser}', '{tip_image_url}', {tip_topic})")
            self.cnxn.commit()