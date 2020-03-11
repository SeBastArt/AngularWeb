using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audit_WeatherForecast",
                columns: table => new
                {
                    Audit_WeatherForecastId = table.Column<Guid>(nullable: false),
                    WeatherForecastId = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    AuditUser = table.Column<Guid>(nullable: false),
                    AuditDate = table.Column<DateTime>(nullable: false),
                    AuditAction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit_WeatherForecast", x => x.Audit_WeatherForecastId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    WeatherForecastId = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.WeatherForecastId);
                    table.ForeignKey(
                        name: "FK_WeatherForecast_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("21a56184-0170-4d04-9280-0a57729a62d5"), "Yvette", "Marquardt", new byte[] { 187, 8, 62, 31, 109, 23, 231, 120, 220, 222, 102, 28, 199, 220, 180, 42, 35, 243, 63, 45, 161, 155, 19, 169, 230, 163, 248, 141, 109, 44, 240, 189, 44, 136, 53, 89, 148, 250, 225, 95, 244, 231, 24, 39, 51, 185, 230, 54, 23, 48, 104, 84, 188, 99, 164, 206, 230, 16, 21, 38, 141, 199, 9, 77 }, new byte[] { 39, 241, 206, 221, 77, 230, 37, 254, 141, 35, 127, 234, 59, 30, 60, 191, 186, 46, 222, 64, 121, 239, 211, 122, 28, 124, 122, 150, 206, 39, 1, 242, 250, 19, 183, 56, 133, 99, 178, 101, 233, 60, 70, 223, 43, 33, 77, 50, 230, 141, 230, 69, 157, 125, 70, 142, 5, 43, 44, 183, 246, 29, 109, 54, 184, 220, 108, 230, 215, 191, 222, 229, 81, 202, 190, 178, 15, 216, 153, 165, 85, 55, 241, 254, 228, 149, 223, 158, 55, 170, 220, 134, 139, 104, 51, 228, 148, 162, 141, 74, 177, 187, 171, 76, 155, 13, 33, 226, 83, 131, 91, 165, 35, 41, 146, 145, 17, 29, 251, 72, 68, 192, 43, 17, 160, 130, 136, 188 }, "Admin", "Nigel" },
                    { new Guid("c3099f2d-6dcb-4608-9b35-4270abc2dff7"), "Joelle", "Bergstrom", new byte[] { 187, 8, 62, 31, 109, 23, 231, 120, 220, 222, 102, 28, 199, 220, 180, 42, 35, 243, 63, 45, 161, 155, 19, 169, 230, 163, 248, 141, 109, 44, 240, 189, 44, 136, 53, 89, 148, 250, 225, 95, 244, 231, 24, 39, 51, 185, 230, 54, 23, 48, 104, 84, 188, 99, 164, 206, 230, 16, 21, 38, 141, 199, 9, 77 }, new byte[] { 39, 241, 206, 221, 77, 230, 37, 254, 141, 35, 127, 234, 59, 30, 60, 191, 186, 46, 222, 64, 121, 239, 211, 122, 28, 124, 122, 150, 206, 39, 1, 242, 250, 19, 183, 56, 133, 99, 178, 101, 233, 60, 70, 223, 43, 33, 77, 50, 230, 141, 230, 69, 157, 125, 70, 142, 5, 43, 44, 183, 246, 29, 109, 54, 184, 220, 108, 230, 215, 191, 222, 229, 81, 202, 190, 178, 15, 216, 153, 165, 85, 55, 241, 254, 228, 149, 223, 158, 55, 170, 220, 134, 139, 104, 51, 228, 148, 162, 141, 74, 177, 187, 171, 76, 155, 13, 33, 226, 83, 131, 91, 165, 35, 41, 146, 145, 17, 29, 251, 72, 68, 192, 43, 17, 160, 130, 136, 188 }, "Admin", "Travis" },
                    { new Guid("730b0202-2cf5-4b95-aa0e-6f7a0c662f12"), "Madisyn", "McCullough", new byte[] { 187, 8, 62, 31, 109, 23, 231, 120, 220, 222, 102, 28, 199, 220, 180, 42, 35, 243, 63, 45, 161, 155, 19, 169, 230, 163, 248, 141, 109, 44, 240, 189, 44, 136, 53, 89, 148, 250, 225, 95, 244, 231, 24, 39, 51, 185, 230, 54, 23, 48, 104, 84, 188, 99, 164, 206, 230, 16, 21, 38, 141, 199, 9, 77 }, new byte[] { 39, 241, 206, 221, 77, 230, 37, 254, 141, 35, 127, 234, 59, 30, 60, 191, 186, 46, 222, 64, 121, 239, 211, 122, 28, 124, 122, 150, 206, 39, 1, 242, 250, 19, 183, 56, 133, 99, 178, 101, 233, 60, 70, 223, 43, 33, 77, 50, 230, 141, 230, 69, 157, 125, 70, 142, 5, 43, 44, 183, 246, 29, 109, 54, 184, 220, 108, 230, 215, 191, 222, 229, 81, 202, 190, 178, 15, 216, 153, 165, 85, 55, 241, 254, 228, 149, 223, 158, 55, 170, 220, 134, 139, 104, 51, 228, 148, 162, 141, 74, 177, 187, 171, 76, 155, 13, 33, 226, 83, 131, 91, 165, 35, 41, 146, 145, 17, 29, 251, 72, 68, 192, 43, 17, 160, 130, 136, 188 }, "Admin", "Coralie" },
                    { new Guid("e534fafd-6223-4deb-99e3-c15960a84ac8"), "Donna", "Leannon", new byte[] { 187, 8, 62, 31, 109, 23, 231, 120, 220, 222, 102, 28, 199, 220, 180, 42, 35, 243, 63, 45, 161, 155, 19, 169, 230, 163, 248, 141, 109, 44, 240, 189, 44, 136, 53, 89, 148, 250, 225, 95, 244, 231, 24, 39, 51, 185, 230, 54, 23, 48, 104, 84, 188, 99, 164, 206, 230, 16, 21, 38, 141, 199, 9, 77 }, new byte[] { 39, 241, 206, 221, 77, 230, 37, 254, 141, 35, 127, 234, 59, 30, 60, 191, 186, 46, 222, 64, 121, 239, 211, 122, 28, 124, 122, 150, 206, 39, 1, 242, 250, 19, 183, 56, 133, 99, 178, 101, 233, 60, 70, 223, 43, 33, 77, 50, 230, 141, 230, 69, 157, 125, 70, 142, 5, 43, 44, 183, 246, 29, 109, 54, 184, 220, 108, 230, 215, 191, 222, 229, 81, 202, 190, 178, 15, 216, 153, 165, 85, 55, 241, 254, 228, 149, 223, 158, 55, 170, 220, 134, 139, 104, 51, 228, 148, 162, 141, 74, 177, 187, 171, 76, 155, 13, 33, 226, 83, 131, 91, 165, 35, 41, 146, 145, 17, 29, 251, 72, 68, 192, 43, 17, 160, 130, 136, 188 }, "Admin", "Yesenia" },
                    { new Guid("8c677d99-1c3c-4552-9497-2ddc5a826b6e"), "Sebastian", "Schüler", new byte[] { 187, 8, 62, 31, 109, 23, 231, 120, 220, 222, 102, 28, 199, 220, 180, 42, 35, 243, 63, 45, 161, 155, 19, 169, 230, 163, 248, 141, 109, 44, 240, 189, 44, 136, 53, 89, 148, 250, 225, 95, 244, 231, 24, 39, 51, 185, 230, 54, 23, 48, 104, 84, 188, 99, 164, 206, 230, 16, 21, 38, 141, 199, 9, 77 }, new byte[] { 39, 241, 206, 221, 77, 230, 37, 254, 141, 35, 127, 234, 59, 30, 60, 191, 186, 46, 222, 64, 121, 239, 211, 122, 28, 124, 122, 150, 206, 39, 1, 242, 250, 19, 183, 56, 133, 99, 178, 101, 233, 60, 70, 223, 43, 33, 77, 50, 230, 141, 230, 69, 157, 125, 70, 142, 5, 43, 44, 183, 246, 29, 109, 54, 184, 220, 108, 230, 215, 191, 222, 229, 81, 202, 190, 178, 15, 216, 153, 165, 85, 55, 241, 254, 228, 149, 223, 158, 55, 170, 220, 134, 139, 104, 51, 228, 148, 162, 141, 74, 177, 187, 171, 76, 155, 13, 33, 226, 83, 131, 91, 165, 35, 41, 146, 145, 17, 29, 251, 72, 68, 192, 43, 17, 160, 130, 136, 188 }, "Admin", "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_UserId",
                table: "WeatherForecast",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit_WeatherForecast");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
