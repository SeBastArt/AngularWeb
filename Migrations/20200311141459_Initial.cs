using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_country",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    iso_3cc = table.Column<string>(type: "varchar(3)", nullable: true),
                    iso_2cc = table.Column<string>(type: "varchar(2)", nullable: true),
                    iso_numerical = table.Column<int>(nullable: false),
                    economic_area = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_type = table.Column<int>(nullable: false),
                    address_text_document_script = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_delivery_script = table.Column<string>(type: "varchar(max)", nullable: true),
                    address_text_invoice_script = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Audit_WeatherForecast",
                columns: table => new
                {
                    Audit_WeatherForecastId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherForecastId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    AuditUser = table.Column<long>(nullable: false),
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    WeatherForecastId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    summar_y = table.Column<string>(type: "varchar(100)", nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.WeatherForecastId);
                    table.ForeignKey(
                        name: "FK_WeatherForecast_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { 1L, "Yvette", "Marquardt", new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 }, "Admin", "Nigel" },
                    { 2L, "Joelle", "Bergstrom", new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 }, "Admin", "Travis" },
                    { 3L, "Madisyn", "McCullough", new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 }, "Admin", "Coralie" },
                    { 4L, "Donna", "Leannon", new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 }, "Admin", "Yesenia" },
                    { 5L, "Sebastian", "Schüler", new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 }, "Admin", "user" }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "WeatherForecastId", "created", "created_by", "Date", "modified", "modified_by", "summar_y", "TemperatureC", "UserId" },
                values: new object[,]
                {
                    { 3L, new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(8277), 1L, new DateTime(2020, 7, 30, 17, 59, 55, 820, DateTimeKind.Local).AddTicks(8597), new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(8292), 5L, "orchid", 5, 1L },
                    { 69L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2011), 2L, new DateTime(2021, 1, 7, 15, 41, 5, 99, DateTimeKind.Local).AddTicks(2588), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2015), 3L, "Corporate", -14, 4L },
                    { 64L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1686), 2L, new DateTime(2020, 6, 30, 4, 52, 53, 692, DateTimeKind.Local).AddTicks(2534), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1690), 2L, "input", 1, 4L },
                    { 62L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1580), 2L, new DateTime(2020, 8, 22, 18, 17, 8, 654, DateTimeKind.Local).AddTicks(1851), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1584), 2L, "cultivate", -12, 4L },
                    { 59L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1420), 1L, new DateTime(2020, 10, 2, 17, 1, 41, 511, DateTimeKind.Local).AddTicks(4722), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1423), 1L, "scale", -15, 4L },
                    { 54L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1028), 2L, new DateTime(2020, 5, 24, 16, 28, 19, 553, DateTimeKind.Local).AddTicks(9546), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1031), 5L, "Internal", 11, 4L },
                    { 41L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(5667), 2L, new DateTime(2021, 1, 6, 23, 56, 33, 219, DateTimeKind.Local).AddTicks(5051), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(5671), 4L, "Metal", -1, 4L },
                    { 39L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4644), 4L, new DateTime(2021, 2, 21, 12, 57, 13, 488, DateTimeKind.Local).AddTicks(7991), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4648), 4L, "calculating", 9, 4L },
                    { 36L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4463), 1L, new DateTime(2020, 10, 7, 21, 41, 18, 200, DateTimeKind.Local).AddTicks(1127), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4466), 1L, "Mobility", 4, 4L },
                    { 24L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8749), 2L, new DateTime(2020, 9, 27, 21, 43, 13, 909, DateTimeKind.Local).AddTicks(4314), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8755), 3L, "backing up", -13, 4L },
                    { 17L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6457), 4L, new DateTime(2020, 4, 18, 11, 1, 45, 278, DateTimeKind.Local).AddTicks(2473), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6461), 5L, "open-source", -9, 4L },
                    { 16L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6362), 3L, new DateTime(2020, 12, 6, 21, 2, 56, 890, DateTimeKind.Local).AddTicks(3218), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6367), 4L, "Planner", 14, 4L },
                    { 15L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4464), 1L, new DateTime(2020, 4, 8, 2, 17, 48, 711, DateTimeKind.Local).AddTicks(6733), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4467), 1L, "national", -9, 4L },
                    { 1L, new DateTime(2020, 3, 11, 14, 14, 58, 735, DateTimeKind.Utc).AddTicks(1688), 4L, new DateTime(2020, 12, 22, 7, 26, 12, 228, DateTimeKind.Local).AddTicks(4887), new DateTime(2020, 3, 11, 14, 14, 58, 735, DateTimeKind.Utc).AddTicks(4433), 4L, "Danish Krone", 15, 4L },
                    { 97L, new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(411), 5L, new DateTime(2021, 2, 9, 19, 35, 36, 610, DateTimeKind.Local).AddTicks(7423), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(416), 4L, "Cayman Islands", 13, 3L },
                    { 95L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8466), 5L, new DateTime(2021, 1, 25, 4, 41, 40, 722, DateTimeKind.Local).AddTicks(2095), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8470), 4L, "web-enabled", -12, 3L },
                    { 94L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8216), 1L, new DateTime(2021, 2, 16, 12, 29, 46, 765, DateTimeKind.Local).AddTicks(4322), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8219), 4L, "Centralized", 11, 3L },
                    { 89L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7917), 1L, new DateTime(2020, 11, 14, 18, 2, 50, 139, DateTimeKind.Local).AddTicks(9417), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7920), 5L, "District", -13, 3L },
                    { 87L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7808), 4L, new DateTime(2020, 10, 6, 16, 2, 11, 310, DateTimeKind.Local).AddTicks(6739), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7812), 5L, "world-class", 15, 3L },
                    { 83L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3735), 1L, new DateTime(2020, 11, 27, 8, 52, 0, 748, DateTimeKind.Local).AddTicks(2205), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3738), 1L, "open-source", 12, 3L },
                    { 78L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3468), 5L, new DateTime(2020, 12, 29, 7, 38, 51, 874, DateTimeKind.Local).AddTicks(291), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3473), 1L, "wireless", -14, 3L },
                    { 77L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3388), 1L, new DateTime(2021, 1, 10, 14, 12, 59, 940, DateTimeKind.Local).AddTicks(9329), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3393), 2L, "Square", 7, 3L },
                    { 71L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2139), 2L, new DateTime(2021, 2, 16, 11, 52, 26, 465, DateTimeKind.Local).AddTicks(5688), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2142), 4L, "connecting", 4, 4L },
                    { 73L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2240), 1L, new DateTime(2020, 12, 1, 4, 47, 42, 918, DateTimeKind.Local).AddTicks(5770), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2244), 5L, "scale", 6, 3L },
                    { 72L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2190), 5L, new DateTime(2020, 10, 1, 21, 27, 3, 191, DateTimeKind.Local).AddTicks(3204), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2194), 5L, "Gorgeous", -2, 4L },
                    { 76L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2490), 1L, new DateTime(2020, 7, 16, 0, 52, 6, 489, DateTimeKind.Local).AddTicks(7802), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2494), 4L, "Officer", 7, 4L },
                    { 96L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8527), 1L, new DateTime(2020, 4, 25, 14, 21, 58, 145, DateTimeKind.Local).AddTicks(5312), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8530), 4L, "Credit Card Account", -12, 5L },
                    { 81L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3633), 1L, new DateTime(2021, 1, 6, 23, 49, 34, 327, DateTimeKind.Local).AddTicks(9876), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3637), 5L, "Maine", -3, 5L },
                    { 66L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1846), 1L, new DateTime(2020, 8, 27, 20, 34, 8, 471, DateTimeKind.Local).AddTicks(2280), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1850), 5L, "Lead", 4, 5L },
                    { 65L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1792), 5L, new DateTime(2020, 6, 11, 6, 29, 46, 683, DateTimeKind.Local).AddTicks(7903), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1796), 4L, "Movies & Clothing", -3, 5L },
                    { 63L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1635), 1L, new DateTime(2020, 7, 21, 5, 48, 13, 86, DateTimeKind.Local).AddTicks(5566), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1638), 4L, "Advanced", 14, 5L },
                    { 55L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1195), 2L, new DateTime(2020, 3, 18, 9, 38, 15, 535, DateTimeKind.Local).AddTicks(2811), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1199), 4L, "Guarani", -6, 5L },
                    { 52L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(922), 2L, new DateTime(2020, 9, 5, 13, 14, 14, 61, DateTimeKind.Local).AddTicks(5621), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(925), 4L, "Brand", 0, 5L },
                    { 44L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6236), 3L, new DateTime(2020, 5, 6, 4, 42, 48, 302, DateTimeKind.Local).AddTicks(5154), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6239), 5L, "Tunisian Dinar", -3, 5L },
                    { 42L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6071), 5L, new DateTime(2020, 7, 17, 4, 35, 57, 831, DateTimeKind.Local).AddTicks(2178), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6075), 5L, "Baby, Beauty & Games", -4, 5L },
                    { 40L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4801), 5L, new DateTime(2020, 8, 11, 14, 47, 45, 573, DateTimeKind.Local).AddTicks(6657), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4805), 2L, "auxiliary", -10, 5L },
                    { 33L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4255), 5L, new DateTime(2020, 3, 24, 3, 15, 7, 589, DateTimeKind.Local).AddTicks(9892), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4260), 5L, "Principal", 3, 5L },
                    { 28L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9051), 3L, new DateTime(2020, 8, 23, 15, 45, 25, 100, DateTimeKind.Local).AddTicks(9382), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9055), 1L, "Self-enabling", 10, 5L },
                    { 26L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8940), 3L, new DateTime(2020, 5, 22, 7, 42, 44, 71, DateTimeKind.Local).AddTicks(5583), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8944), 5L, "Practical Metal Hat", -12, 5L },
                    { 22L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4548), 2L, new DateTime(2021, 1, 1, 19, 14, 37, 740, DateTimeKind.Local).AddTicks(2326), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4552), 4L, "Technician", 3, 5L },
                    { 20L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(2033), 2L, new DateTime(2020, 11, 29, 17, 2, 20, 222, DateTimeKind.Local).AddTicks(6163), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(2039), 4L, "Kids, Electronics & Movies", 5, 5L },
                    { 11L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(1613), 1L, new DateTime(2020, 3, 12, 5, 28, 51, 377, DateTimeKind.Local).AddTicks(8009), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(1620), 1L, "Handmade Plastic Towels", -7, 5L },
                    { 5L, new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(5708), 2L, new DateTime(2021, 2, 20, 11, 7, 3, 133, DateTimeKind.Local).AddTicks(1881), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(5717), 3L, "sexy", -14, 5L },
                    { 93L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8164), 3L, new DateTime(2020, 7, 31, 10, 16, 45, 786, DateTimeKind.Local).AddTicks(9866), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8168), 3L, "Latvian Lats", -6, 4L },
                    { 88L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7860), 5L, new DateTime(2021, 1, 22, 7, 7, 57, 761, DateTimeKind.Local).AddTicks(884), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7864), 2L, "Triple-buffered", 10, 4L },
                    { 86L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7751), 1L, new DateTime(2020, 9, 28, 15, 28, 54, 486, DateTimeKind.Local).AddTicks(2938), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7755), 5L, "Walks", 8, 4L },
                    { 82L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3684), 3L, new DateTime(2020, 5, 29, 15, 2, 45, 377, DateTimeKind.Local).AddTicks(8816), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3687), 2L, "AI", 8, 4L },
                    { 74L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2293), 5L, new DateTime(2020, 5, 31, 0, 39, 41, 451, DateTimeKind.Local).AddTicks(6366), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2296), 5L, "olive", 4, 4L },
                    { 68L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1960), 1L, new DateTime(2020, 9, 29, 15, 25, 23, 507, DateTimeKind.Local).AddTicks(2975), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1963), 5L, "real-time", 2, 3L },
                    { 61L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1528), 3L, new DateTime(2020, 7, 21, 17, 9, 50, 384, DateTimeKind.Local).AddTicks(1485), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1532), 2L, "SMS", -14, 3L },
                    { 58L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1362), 3L, new DateTime(2021, 3, 11, 13, 16, 59, 954, DateTimeKind.Local).AddTicks(9330), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1365), 4L, "index", 14, 3L },
                    { 27L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8996), 2L, new DateTime(2020, 7, 7, 17, 18, 41, 935, DateTimeKind.Local).AddTicks(9570), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9000), 3L, "1080p", 10, 2L },
                    { 14L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4407), 3L, new DateTime(2021, 2, 23, 0, 1, 25, 663, DateTimeKind.Local).AddTicks(2307), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4411), 3L, "Customer-focused", -8, 2L },
                    { 12L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4232), 2L, new DateTime(2020, 3, 26, 12, 40, 12, 274, DateTimeKind.Local).AddTicks(1876), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4238), 1L, "Assurance", 10, 2L },
                    { 10L, new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(7023), 4L, new DateTime(2020, 5, 19, 11, 20, 48, 760, DateTimeKind.Local).AddTicks(4533), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(7030), 5L, "hard drive", 15, 2L },
                    { 7L, new DateTime(2020, 3, 11, 14, 14, 58, 738, DateTimeKind.Utc).AddTicks(3165), 4L, new DateTime(2020, 4, 13, 3, 18, 19, 845, DateTimeKind.Local).AddTicks(7492), new DateTime(2020, 3, 11, 14, 14, 58, 738, DateTimeKind.Utc).AddTicks(3171), 3L, "Fully-configurable", -3, 2L },
                    { 4L, new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(1468), 3L, new DateTime(2020, 5, 31, 10, 10, 45, 779, DateTimeKind.Local).AddTicks(7283), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(1478), 1L, "Practical", -3, 2L },
                    { 100L, new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2466), 1L, new DateTime(2020, 10, 6, 12, 22, 0, 556, DateTimeKind.Local).AddTicks(1950), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2469), 5L, "Tasty Rubber Keyboard", 0, 1L },
                    { 92L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8101), 1L, new DateTime(2021, 1, 25, 1, 36, 54, 724, DateTimeKind.Local).AddTicks(1621), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8104), 2L, "parse", 10, 1L },
                    { 91L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8049), 1L, new DateTime(2020, 6, 4, 22, 16, 52, 520, DateTimeKind.Local).AddTicks(4128), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8053), 5L, "driver", -10, 1L },
                    { 90L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7992), 2L, new DateTime(2020, 11, 28, 10, 15, 34, 21, DateTimeKind.Local).AddTicks(9190), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7995), 2L, "Small Cotton Keyboard", 2, 1L },
                    { 84L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(5593), 4L, new DateTime(2020, 7, 29, 12, 45, 58, 373, DateTimeKind.Local).AddTicks(6169), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(5599), 5L, "Berkshire", -11, 1L },
                    { 75L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2433), 3L, new DateTime(2020, 4, 5, 22, 15, 35, 679, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2436), 1L, "Pre-emptive", -3, 1L },
                    { 60L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1473), 5L, new DateTime(2021, 2, 16, 12, 59, 13, 205, DateTimeKind.Local).AddTicks(3887), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1477), 2L, "supply-chains", -8, 1L },
                    { 57L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1310), 3L, new DateTime(2020, 6, 19, 0, 53, 14, 961, DateTimeKind.Local).AddTicks(9924), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1313), 3L, "online", 4, 1L },
                    { 56L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1256), 5L, new DateTime(2020, 6, 30, 8, 17, 54, 940, DateTimeKind.Local).AddTicks(5204), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1259), 3L, "Central", 8, 1L },
                    { 51L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(869), 1L, new DateTime(2021, 2, 20, 21, 9, 9, 689, DateTimeKind.Local).AddTicks(7079), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(873), 5L, "Implementation", 0, 1L },
                    { 49L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(709), 3L, new DateTime(2021, 2, 27, 6, 16, 59, 981, DateTimeKind.Local).AddTicks(8626), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(714), 2L, "Trafficway", 15, 1L },
                    { 37L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4517), 2L, new DateTime(2020, 10, 11, 8, 41, 33, 936, DateTimeKind.Local).AddTicks(5363), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4521), 3L, "cyan", -4, 1L },
                    { 30L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1385), 5L, new DateTime(2020, 4, 12, 13, 3, 12, 655, DateTimeKind.Local).AddTicks(7063), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1388), 1L, "connecting", -8, 1L },
                    { 29L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1294), 3L, new DateTime(2020, 7, 14, 19, 11, 32, 897, DateTimeKind.Local).AddTicks(870), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1299), 3L, "Credit Card Account", 0, 1L },
                    { 25L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8848), 4L, new DateTime(2020, 10, 9, 20, 58, 16, 711, DateTimeKind.Local).AddTicks(4800), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8852), 3L, "Delaware", -1, 1L },
                    { 31L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1470), 4L, new DateTime(2021, 2, 1, 22, 6, 0, 7, DateTimeKind.Local).AddTicks(9505), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1473), 1L, "Incredible Wooden Shoes", -8, 2L },
                    { 32L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(2363), 2L, new DateTime(2020, 7, 16, 18, 43, 33, 264, DateTimeKind.Local).AddTicks(8234), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(2368), 4L, "Rustic Steel Pants", 13, 2L },
                    { 34L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4348), 2L, new DateTime(2021, 2, 25, 4, 49, 30, 907, DateTimeKind.Local).AddTicks(631), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4352), 2L, "e-markets", -11, 2L },
                    { 38L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4592), 3L, new DateTime(2020, 7, 12, 1, 56, 29, 393, DateTimeKind.Local).AddTicks(7286), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4595), 4L, "Intelligent Concrete Shoes", 14, 2L },
                    { 53L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(974), 3L, new DateTime(2020, 3, 19, 1, 42, 56, 687, DateTimeKind.Local).AddTicks(8511), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(977), 5L, "Identity", -14, 3L },
                    { 50L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(809), 5L, new DateTime(2020, 8, 18, 10, 49, 30, 928, DateTimeKind.Local).AddTicks(8416), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(814), 2L, "Direct", 3, 3L },
                    { 48L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8779), 1L, new DateTime(2020, 8, 21, 11, 33, 13, 91, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8783), 5L, "Brazilian Real", -6, 3L },
                    { 47L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8709), 4L, new DateTime(2020, 4, 14, 23, 42, 36, 1, DateTimeKind.Local).AddTicks(6207), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8712), 4L, "fuchsia", -3, 3L },
                    { 45L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8551), 3L, new DateTime(2021, 1, 6, 0, 38, 10, 344, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8556), 2L, "bypass", 14, 3L },
                    { 35L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4406), 2L, new DateTime(2020, 5, 13, 16, 8, 17, 684, DateTimeKind.Local).AddTicks(8159), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4409), 2L, "efficient", -1, 3L },
                    { 23L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(6558), 3L, new DateTime(2021, 2, 5, 1, 47, 10, 567, DateTimeKind.Local).AddTicks(1054), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(6564), 1L, "COM", -8, 3L },
                    { 21L, new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4436), 5L, new DateTime(2020, 3, 25, 19, 38, 0, 477, DateTimeKind.Local).AddTicks(8928), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4442), 5L, "reinvent", 12, 3L },
                    { 19L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8769), 3L, new DateTime(2020, 10, 12, 5, 49, 55, 500, DateTimeKind.Local).AddTicks(8940), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8772), 4L, "paradigms", -14, 3L },
                    { 18L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8676), 2L, new DateTime(2020, 8, 16, 17, 59, 8, 343, DateTimeKind.Local).AddTicks(6085), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8682), 3L, "niches", -4, 3L },
                    { 98L, new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2292), 4L, new DateTime(2020, 8, 12, 17, 27, 23, 78, DateTimeKind.Local).AddTicks(8082), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2298), 2L, "withdrawal", 8, 5L },
                    { 13L, new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4340), 4L, new DateTime(2020, 7, 15, 12, 46, 24, 638, DateTimeKind.Local).AddTicks(8290), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4344), 5L, "mobile", 6, 3L },
                    { 8L, new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(1855), 3L, new DateTime(2020, 6, 8, 13, 37, 15, 805, DateTimeKind.Local).AddTicks(4566), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(1863), 3L, "Jewelery", -15, 3L },
                    { 6L, new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(9233), 4L, new DateTime(2020, 7, 4, 16, 17, 33, 882, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(9249), 3L, "even-keeled", 14, 3L },
                    { 2L, new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(4995), 3L, new DateTime(2020, 11, 14, 13, 47, 53, 66, DateTimeKind.Local).AddTicks(3307), new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(5063), 5L, "haptic", -6, 3L },
                    { 85L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7655), 2L, new DateTime(2020, 5, 9, 15, 15, 7, 457, DateTimeKind.Local).AddTicks(5337), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7660), 4L, "conglomeration", 10, 2L },
                    { 80L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3578), 4L, new DateTime(2020, 10, 23, 9, 24, 21, 962, DateTimeKind.Local).AddTicks(5810), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3582), 5L, "Investment Account", 12, 2L },
                    { 79L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3522), 5L, new DateTime(2021, 1, 25, 21, 32, 46, 917, DateTimeKind.Local).AddTicks(1289), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3525), 1L, "SMS", 4, 2L },
                    { 70L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2087), 3L, new DateTime(2020, 9, 24, 3, 19, 57, 81, DateTimeKind.Local).AddTicks(5410), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2091), 5L, "Small Cotton Car", -4, 2L },
                    { 67L, new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1904), 1L, new DateTime(2021, 1, 16, 2, 51, 40, 499, DateTimeKind.Local).AddTicks(5756), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1908), 3L, "Agent", -12, 2L },
                    { 46L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8651), 1L, new DateTime(2020, 12, 31, 5, 47, 44, 918, DateTimeKind.Local).AddTicks(7984), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8654), 3L, "networks", 13, 2L },
                    { 43L, new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6162), 2L, new DateTime(2020, 3, 19, 7, 4, 2, 297, DateTimeKind.Local).AddTicks(6267), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6166), 4L, "Incredible Frozen Cheese", 15, 2L },
                    { 9L, new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(4909), 2L, new DateTime(2020, 5, 11, 15, 35, 16, 863, DateTimeKind.Local).AddTicks(5563), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(4916), 3L, "Mississippi", 8, 3L },
                    { 99L, new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2386), 2L, new DateTime(2020, 11, 23, 5, 43, 40, 309, DateTimeKind.Local).AddTicks(9922), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2390), 4L, "Response", 0, 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_UserId",
                table: "WeatherForecast",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_country");

            migrationBuilder.DropTable(
                name: "Audit_WeatherForecast");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
