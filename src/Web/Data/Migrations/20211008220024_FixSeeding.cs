using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YbHackathon.Solutioneers.Web.Data.Migrations
{
    public partial class FixSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("3b248d48-72ef-4c7d-bc3c-32d2eaa757b9"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("5762dcb9-72c8-40c7-b4b5-ee26d5ddbd9a"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("5b2ff22e-f3d4-4be8-867b-4532f8f285b0"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("68da4eb4-f62d-4dbe-b28f-6c87332f54d4"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("845c79ae-b98d-4004-b446-d48f8ee0f252"));

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "Description", "ImageId", "OpenFrom", "OpenTo", "PointsToEarn", "Title", "Topic" },
                values: new object[,]
                {
                    { new Guid("6b2ff22e-f3d4-4be8-867b-4532f8f285b0"), "Buying Seconhand clothes saves resources. Human and ecological resources. I claim that secondhand clothing is the most sustainable way to buy clothes, because no new resources are consumed. Offer for sale clothes that are already in circulation. It is important not to fall into a consumption frenzy because it is secondhand anyway. Only what really pleases and is needed, but above all also gives pleasure, should be bought.", new Guid("1ac5d7b1-7daa-41d8-aaf9-af0e1e48ae21"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Already heard about secondhand stores?", 3 },
                    { new Guid("6762dcb9-72c8-40c7-b4b5-ee26d5ddbd9a"), "Solar systems, so-called photovoltaic systems, for the roof bring with them numerous advantages and disadvantages. On the one hand, users get free electricity and contribute to environmental protection; on the other hand, they have to accept expensive acquisition costs and a fluctuating yield. In terms of wear and tear, the advantages and disadvantages balance each other out. This article presents in detail the various arguments in favor and against the purchase of solar panels for the roof.", new Guid("6e93c6b8-fb4a-4e51-97d1-d842b8eca69d"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Producing your own energy is cool", 1 },
                    { new Guid("78da4eb4-f62d-4dbe-b28f-6c87332f54d4"), "Switzerland-wide campaigns such as Bike to Work or Bike Wednesday are designed to encourage the Swiss to get around more by bike. At the beginning of June, more than 70,000 participants had already covered more than six and a half million kilometers by bicycle as part of Bike to Work. This has saved a good 900 tons of CO2 equivalents. Anyone who cycles to work every Wednesday and covers at least three kilometers can enter the distance traveled on the Bike Wednesday website and win vouchers or non-cash prizes.", new Guid("78b97670-b8c3-4603-bb83-36e0c86964a7"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Bike to work - for your health and for our planet", 2 },
                    { new Guid("4b248d48-72ef-4c7d-bc3c-32d2eaa757b9"), "Even though the feeling of warmth is always subjective, there are nevertheless guidelines for the optimum room temperature of any room. If you reduce the temperature by one degree in winter, you can save up to six percent on heating costs at the end of the year. This not only relieves the burden on your wallet, but also on the environment. For a family of four, this means that around 350 kg of carbon dioxide is not released into the air each year.", new Guid("5f942d9e-4a2d-4545-a7c5-5aa46b2b33e3"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Turn down your heating and save money", 1 },
                    { new Guid("945c79ae-b98d-4004-b446-d48f8ee0f252"), "As soon as the first leaves fall from the trees, you can see them shining from afar in the vegetable displays: Pumpkins in bright orange, yellow and green. But the pumpkin is not only a colorful highlight on the plate, but also a real soul food in the fall and therefore hard to imagine the cold months without the kitchen.Whether as a creamy pumpkin soup, spicy pumpkin pie, spread, quiche or as a side dish to risotto, pasta and Co. - the pumpkin is a true all - rounder!", new Guid("3d093ab9-b086-44c4-b8e7-06d56df8f395"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pumpkins - regionally produced and currently seasonal", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("4b248d48-72ef-4c7d-bc3c-32d2eaa757b9"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("6762dcb9-72c8-40c7-b4b5-ee26d5ddbd9a"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("6b2ff22e-f3d4-4be8-867b-4532f8f285b0"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("78da4eb4-f62d-4dbe-b28f-6c87332f54d4"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("945c79ae-b98d-4004-b446-d48f8ee0f252"));

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "Description", "ImageId", "OpenFrom", "OpenTo", "PointsToEarn", "Title", "Topic" },
                values: new object[,]
                {
                    { new Guid("5b2ff22e-f3d4-4be8-867b-4532f8f285b0"), "Buying Seconhand clothes saves resources. Human and ecological resources. I claim that secondhand clothing is the most sustainable way to buy clothes, because no new resources are consumed. Offer for sale clothes that are already in circulation. It is important not to fall into a consumption frenzy because it is secondhand anyway. Only what really pleases and is needed, but above all also gives pleasure, should be bought.", new Guid("1ac5d7b1-7daa-41d8-aaf9-af0e1e48ae21"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Already heard about secondhand stores?", 3 },
                    { new Guid("5762dcb9-72c8-40c7-b4b5-ee26d5ddbd9a"), "Solar systems, so-called photovoltaic systems, for the roof bring with them numerous advantages and disadvantages. On the one hand, users get free electricity and contribute to environmental protection; on the other hand, they have to accept expensive acquisition costs and a fluctuating yield. In terms of wear and tear, the advantages and disadvantages balance each other out. This article presents in detail the various arguments in favor and against the purchase of solar panels for the roof.", new Guid("6e93c6b8-fb4a-4e51-97d1-d842b8eca69d"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Producing your own energy is cool", 1 },
                    { new Guid("68da4eb4-f62d-4dbe-b28f-6c87332f54d4"), "Switzerland-wide campaigns such as Bike to Work or Bike Wednesday are designed to encourage the Swiss to get around more by bike. At the beginning of June, more than 70,000 participants had already covered more than six and a half million kilometers by bicycle as part of Bike to Work. This has saved a good 900 tons of CO2 equivalents. Anyone who cycles to work every Wednesday and covers at least three kilometers can enter the distance traveled on the Bike Wednesday website and win vouchers or non-cash prizes.", new Guid("78b97670-b8c3-4603-bb83-36e0c86964a7"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Bike to work - for your health and for our planet", 1 },
                    { new Guid("3b248d48-72ef-4c7d-bc3c-32d2eaa757b9"), "Even though the feeling of warmth is always subjective, there are nevertheless guidelines for the optimum room temperature of any room. If you reduce the temperature by one degree in winter, you can save up to six percent on heating costs at the end of the year. This not only relieves the burden on your wallet, but also on the environment. For a family of four, this means that around 350 kg of carbon dioxide is not released into the air each year.", new Guid("5f942d9e-4a2d-4545-a7c5-5aa46b2b33e3"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Turn down your heating and save money", 1 },
                    { new Guid("845c79ae-b98d-4004-b446-d48f8ee0f252"), "As soon as the first leaves fall from the trees, you can see them shining from afar in the vegetable displays: Pumpkins in bright orange, yellow and green. But the pumpkin is not only a colorful highlight on the plate, but also a real soul food in the fall and therefore hard to imagine the cold months without the kitchen.Whether as a creamy pumpkin soup, spicy pumpkin pie, spread, quiche or as a side dish to risotto, pasta and Co. - the pumpkin is a true all - rounder!", new Guid("3d093ab9-b086-44c4-b8e7-06d56df8f395"), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pumpkins - regionally produced and currently seasonal", 1 }
                });
        }
    }
}
