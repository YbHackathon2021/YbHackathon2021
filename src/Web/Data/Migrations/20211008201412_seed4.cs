using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YbHackathon.Solutioneers.Web.Data.Migrations
{
    public partial class seed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalUsers_AspNetUsers_ApplicationUserId",
                table: "InternalUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Images_ImageId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Images_LogoId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_InternalUsers_UserId",
                table: "UserChallenges");

            migrationBuilder.DropIndex(
                name: "IX_InternalUsers_ApplicationUserId",
                table: "InternalUsers");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserChallenges",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ChallengeId",
                table: "UserChallenges",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LogoId",
                table: "Suppliers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Offers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "InternalUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Images_ImageId",
                table: "Offers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Images_LogoId",
                table: "Suppliers",
                column: "LogoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_InternalUsers_UserId",
                table: "UserChallenges",
                column: "UserId",
                principalTable: "InternalUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Images_ImageId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Images_LogoId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_InternalUsers_UserId",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserChallenges",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChallengeId",
                table: "UserChallenges",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "LogoId",
                table: "Suppliers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Offers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "InternalUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternalUsers_ApplicationUserId",
                table: "InternalUsers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalUsers_AspNetUsers_ApplicationUserId",
                table: "InternalUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Images_ImageId",
                table: "Offers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Images_LogoId",
                table: "Suppliers",
                column: "LogoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_InternalUsers_UserId",
                table: "UserChallenges",
                column: "UserId",
                principalTable: "InternalUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
