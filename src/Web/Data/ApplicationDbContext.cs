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
            Guid Guid001 = new Guid("1AC5D7B1-7DAA-41D8-AAF9-AF0E1E48AE21");
            Guid Guid002 = new Guid("13D38292-8358-4681-864E-C0915B961BD7");

            base.OnModelCreating(builder);
            System.Drawing.ImageConverter _imageConverter = new System.Drawing.ImageConverter();

            System.Drawing.Image imageCoatd = System.Drawing.Image.FromFile("Resources/Coats.png");

            builder.Entity<Image>().HasData(
                new Image
                {
                    Id = Guid001,
                    Data = (byte[])_imageConverter.ConvertTo(imageCoatd, typeof(byte[]))
                }
            );


            builder.Entity<Challenge>().HasData(
                new Challenge
                {
                    Id = Guid002,
                    Title = "1st Challende",
                    Description = "Text, text, text, text, text, text, text",
                    Topic = Topic.Food,
                    PointsToEarn = 3,
                    OpenFrom = new DateTime(2021, 10, 1),
                    OpenTo = new DateTime(2021, 10, 20),
                    ImageId = Guid001
                }
            );
        }
    }
}
