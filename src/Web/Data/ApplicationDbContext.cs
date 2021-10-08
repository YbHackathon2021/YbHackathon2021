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
            //Guid Guid005 = new Guid("D00A60F5-41DA-4E46-A222-86F373959AB8");
            Guid GuidChallenge01 = new Guid("930FE3AA-EE36-427C-A819-00EAD0E4ACCF");
            Guid GuidChallenge02 = new Guid("615DA515-3F0D-4CC0-A9DF-E7A9C880C023");

            base.OnModelCreating(builder);
            System.Drawing.ImageConverter _imageConverter = new System.Drawing.ImageConverter();

            System.Drawing.Image imageCoats = System.Drawing.Image.FromFile("Resources/Coats.png");
            System.Drawing.Image imageLavendel = System.Drawing.Image.FromFile("Resources/Lavendel.png");
            System.Drawing.Image imageRecycling = System.Drawing.Image.FromFile("Resources/Recycling.png");
            System.Drawing.Image imageSolar = System.Drawing.Image.FromFile("Resources/Solar.png");

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

            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = GuidChallenge01,
                    Title = "Already heard about secondhand stores?",
                    Description = "Buying Seconhand clothes saves resources. Human and ecological resources. I claim that secondhand clothing is the most sustainable way to buy clothes, because no new resources are consumed. Offer for sale clothes that are already in circulation. It is important not to fall into a consumption frenzy because it is secondhand anyway. Only what really pleases and is needed, but above all also gives pleasure, should be bought.",
                    Topic = Topic.Stuff,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2021, 10, 20),
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
                    OpenTo = new DateTime(2021, 10, 20),
                    ImageId = GuidImageSolar
                }
            );
        }
    }
}
