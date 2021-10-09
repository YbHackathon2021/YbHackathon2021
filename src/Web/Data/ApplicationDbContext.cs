using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net.Mime;
using YbHackathon.Solutioneers.Web.Models;
using static YbHackathon.Solutioneers.Web.Models.Enum;

namespace YbHackathon.Solutioneers.Web.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> InternalUsers { get; set; }
        public DbSet<UserChallenge> UserChallenges { get; set; }
        public DbSet<Tip> Tips { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Guid GuidImageCoats = new Guid("1AC5D7B1-7DAA-41D8-AAF9-AF0E1E48AE21");
            Guid GuidImageLavendel = new Guid("66E754E5-F1C5-49C4-BA80-58791913295E");
            Guid GuidImageRecycling = new Guid("6B437DCE-8B39-4C84-B2A8-1D9D401E517F");
            Guid GuidImageSolar = new Guid("6E93C6B8-FB4A-4E51-97D1-D842B8ECA69D");
            Guid GuidImageBike = new Guid("78B97670-B8C3-4603-BB83-36E0C86964A7");
            Guid GuidImageHeating = new Guid("5F942D9E-4A2D-4545-A7C5-5AA46B2B33E3");
            Guid GuidImagePumpkins = new Guid("3D093AB9-B086-44C4-B8E7-06D56DF8F395");
            Guid GuidChallenge01 = new Guid("6B2FF22E-F3D4-4BE8-867B-4532F8F285B0");
            Guid GuidChallenge02 = new Guid("6762DCB9-72C8-40C7-B4B5-EE26D5DDBD9A");
            Guid GuidChallenge03 = new Guid("78DA4EB4-F62D-4DBE-B28F-6C87332F54D4");
            Guid GuidChallenge04 = new Guid("4B248D48-72EF-4C7D-BC3C-32D2EAA757B9");
            Guid GuidChallenge05 = new Guid("945C79AE-B98D-4004-B446-D48F8EE0F252");

            base.OnModelCreating(builder);
            System.Drawing.ImageConverter _imageConverter = new System.Drawing.ImageConverter();

            System.Drawing.Image imageCoats = System.Drawing.Image.FromFile("Resources/Coats.png");
            System.Drawing.Image imageLavendel = System.Drawing.Image.FromFile("Resources/Lavendel.png");
            System.Drawing.Image imageRecycling = System.Drawing.Image.FromFile("Resources/Recycling.png");
            System.Drawing.Image imageSolar = System.Drawing.Image.FromFile("Resources/Solar.png");
            System.Drawing.Image ImageBike = System.Drawing.Image.FromFile("Resources/Bike.png");
            System.Drawing.Image ImageHeating = System.Drawing.Image.FromFile("Resources/Heating.png");
            System.Drawing.Image ImagePumpkins = System.Drawing.Image.FromFile("Resources/Pumpkins.png");

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageCoats,
                    Data = (byte[])_imageConverter.ConvertTo(imageCoats, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageLavendel,
                    Data = (byte[])_imageConverter.ConvertTo(imageLavendel, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageRecycling,
                    Data = (byte[])_imageConverter.ConvertTo(imageRecycling, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageSolar,
                    Data = (byte[])_imageConverter.ConvertTo(imageSolar, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageBike,
                    Data = (byte[])_imageConverter.ConvertTo(ImageBike, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImageHeating,
                    Data = (byte[])_imageConverter.ConvertTo(ImageHeating, typeof(byte[]))
                }
            );

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = GuidImagePumpkins,
                    Data = (byte[])_imageConverter.ConvertTo(ImagePumpkins, typeof(byte[]))
                }
            );

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge01,
                    Title = "Already heard about secondhand stores?",
                    Description = "Buying Seconhand clothes saves resources. Human and ecological resources. I claim that secondhand clothing is the most sustainable way to buy clothes, because no new resources are consumed. Offer for sale clothes that are already in circulation. It is important not to fall into a consumption frenzy because it is secondhand anyway. Only what really pleases and is needed, but above all also gives pleasure, should be bought.",
                    Topic = Topic.Stuff,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2023, 10, 20),
                    ImageId = GuidImageCoats
                }
            );

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge02,
                    Title = "Producing your own energy is cool",
                    Description = "Solar systems, so-called photovoltaic systems, for the roof bring with them numerous advantages and disadvantages. On the one hand, users get free electricity and contribute to environmental protection; on the other hand, they have to accept expensive acquisition costs and a fluctuating yield. In terms of wear and tear, the advantages and disadvantages balance each other out. This article presents in detail the various arguments in favor and against the purchase of solar panels for the roof.",
                    Topic = Topic.Home,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2023, 01, 20),
                    ImageId = GuidImageSolar
                }
            );

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge03,
                    Title = "Bike to work - for your health and for our planet",
                    Description = "Switzerland-wide campaigns such as Bike to Work or Bike Wednesday are designed to encourage the Swiss to get around more by bike. At the beginning of June, more than 70,000 participants had already covered more than six and a half million kilometers by bicycle as part of Bike to Work. This has saved a good 900 tons of CO2 equivalents. Anyone who cycles to work every Wednesday and covers at least three kilometers can enter the distance traveled on the Bike Wednesday website and win vouchers or non-cash prizes.",
                    Topic = Topic.Travel,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2023, 03, 20),
                    ImageId = GuidImageBike
                }
            );

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge04,
                    Title = "Turn down your heating and save money",
                    Description = "Even though the feeling of warmth is always subjective, there are nevertheless guidelines for the optimum room temperature of any room. If you reduce the temperature by one degree in winter, you can save up to six percent on heating costs at the end of the year. This not only relieves the burden on your wallet, but also on the environment. For a family of four, this means that around 350 kg of carbon dioxide is not released into the air each year.",
                    Topic = Topic.Home,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2023, 06, 20),
                    ImageId = GuidImageHeating
                }
            );

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge05,
                    Title = "Pumpkins - regionally produced and currently seasonal",
                    Description = "As soon as the first leaves fall from the trees, you can see them shining from afar in the vegetable displays: Pumpkins in bright orange, yellow and green. But the pumpkin is not only a colorful highlight on the plate, but also a real soul food in the fall and therefore hard to imagine the cold months without the kitchen.Whether as a creamy pumpkin soup, spicy pumpkin pie, spread, quiche or as a side dish to risotto, pasta and Co. - the pumpkin is a true all - rounder!",
                    Topic = Topic.Food,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2022, 05, 20),
                    ImageId = GuidImagePumpkins
                }
            );
        }
    }
}
