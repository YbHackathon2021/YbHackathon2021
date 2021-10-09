import datetime
import logging
#from Scraper.livesustainability.spiders.nachhaltigleben import NachhaltiglebenSpider

#from scrapy.crawler import CrawlerProcess

import subprocess


import azure.functions as func


def main(mytimer: func.TimerRequest) -> None:
    utc_timestamp = datetime.datetime.utcnow().replace(
        tzinfo=datetime.timezone.utc).isoformat()
 
    #process = CrawlerProcess()
    #process.crawl(NachhaltiglebenSpider)
    #process.start()

    scrapy_command = 'scrapy crawl nachhaltigleben'

    process = subprocess.Popen(scrapy_command, shell=True)

    if mytimer.past_due:
        logging.info('The timer is past due!')

    logging.info('Python timer trigger function ran at %s', utc_timestamp)
