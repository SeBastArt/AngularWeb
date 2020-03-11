using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_person",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "varchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "varchar(max)", nullable: true),
                    sex = table.Column<string>(type: "varchar(max)", nullable: true),
                    department = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone_office = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone_private = table.Column<string>(type: "varchar(max)", nullable: true),
                    email = table.Column<string>(type: "varchar(max)", nullable: true),
                    PictureId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_address_person_fagBinarys_PictureId",
                        column: x => x.PictureId,
                        principalTable: "fagBinarys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address_person_relation",
                columns: table => new
                {
                    AddressId = table.Column<long>(nullable: false),
                    AddressPersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_person_relation", x => new { x.AddressId, x.AddressPersonId });
                    table.ForeignKey(
                        name: "FK_address_person_relation_address_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_address_person_relation_address_person_AddressPersonId",
                        column: x => x.AddressPersonId,
                        principalTable: "address_person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 165, 120, 217, 243, 135, 40, 212, 14, 9, 181, 133, 71, 113, 65, 247, 91, 133, 156, 237, 46, 157, 96, 118, 121, 239, 21, 61, 249, 161, 20, 159, 130, 234, 187, 175, 12, 66, 40, 224, 117, 162, 31, 92, 90, 6, 101, 115, 245, 211, 251, 20, 180, 176, 193, 30, 13, 200, 185, 215, 58, 61, 131, 106 }, new byte[] { 135, 55, 108, 115, 36, 128, 86, 239, 253, 162, 139, 103, 195, 52, 250, 39, 196, 254, 66, 24, 148, 12, 158, 128, 230, 103, 88, 108, 111, 59, 82, 128, 114, 230, 75, 167, 56, 70, 27, 240, 170, 93, 171, 43, 201, 47, 119, 204, 140, 24, 221, 1, 83, 12, 200, 243, 87, 70, 14, 97, 55, 24, 41, 68, 13, 250, 200, 190, 32, 245, 47, 68, 181, 163, 241, 173, 141, 141, 77, 9, 253, 53, 63, 217, 247, 114, 116, 42, 132, 156, 133, 126, 119, 127, 10, 219, 21, 54, 1, 134, 34, 120, 68, 195, 235, 123, 252, 50, 144, 104, 3, 202, 29, 249, 193, 175, 159, 232, 65, 57, 92, 176, 120, 13, 255, 32, 190, 5 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 165, 120, 217, 243, 135, 40, 212, 14, 9, 181, 133, 71, 113, 65, 247, 91, 133, 156, 237, 46, 157, 96, 118, 121, 239, 21, 61, 249, 161, 20, 159, 130, 234, 187, 175, 12, 66, 40, 224, 117, 162, 31, 92, 90, 6, 101, 115, 245, 211, 251, 20, 180, 176, 193, 30, 13, 200, 185, 215, 58, 61, 131, 106 }, new byte[] { 135, 55, 108, 115, 36, 128, 86, 239, 253, 162, 139, 103, 195, 52, 250, 39, 196, 254, 66, 24, 148, 12, 158, 128, 230, 103, 88, 108, 111, 59, 82, 128, 114, 230, 75, 167, 56, 70, 27, 240, 170, 93, 171, 43, 201, 47, 119, 204, 140, 24, 221, 1, 83, 12, 200, 243, 87, 70, 14, 97, 55, 24, 41, 68, 13, 250, 200, 190, 32, 245, 47, 68, 181, 163, 241, 173, 141, 141, 77, 9, 253, 53, 63, 217, 247, 114, 116, 42, 132, 156, 133, 126, 119, 127, 10, 219, 21, 54, 1, 134, 34, 120, 68, 195, 235, 123, 252, 50, 144, 104, 3, 202, 29, 249, 193, 175, 159, 232, 65, 57, 92, 176, 120, 13, 255, 32, 190, 5 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 165, 120, 217, 243, 135, 40, 212, 14, 9, 181, 133, 71, 113, 65, 247, 91, 133, 156, 237, 46, 157, 96, 118, 121, 239, 21, 61, 249, 161, 20, 159, 130, 234, 187, 175, 12, 66, 40, 224, 117, 162, 31, 92, 90, 6, 101, 115, 245, 211, 251, 20, 180, 176, 193, 30, 13, 200, 185, 215, 58, 61, 131, 106 }, new byte[] { 135, 55, 108, 115, 36, 128, 86, 239, 253, 162, 139, 103, 195, 52, 250, 39, 196, 254, 66, 24, 148, 12, 158, 128, 230, 103, 88, 108, 111, 59, 82, 128, 114, 230, 75, 167, 56, 70, 27, 240, 170, 93, 171, 43, 201, 47, 119, 204, 140, 24, 221, 1, 83, 12, 200, 243, 87, 70, 14, 97, 55, 24, 41, 68, 13, 250, 200, 190, 32, 245, 47, 68, 181, 163, 241, 173, 141, 141, 77, 9, 253, 53, 63, 217, 247, 114, 116, 42, 132, 156, 133, 126, 119, 127, 10, 219, 21, 54, 1, 134, 34, 120, 68, 195, 235, 123, 252, 50, 144, 104, 3, 202, 29, 249, 193, 175, 159, 232, 65, 57, 92, 176, 120, 13, 255, 32, 190, 5 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 165, 120, 217, 243, 135, 40, 212, 14, 9, 181, 133, 71, 113, 65, 247, 91, 133, 156, 237, 46, 157, 96, 118, 121, 239, 21, 61, 249, 161, 20, 159, 130, 234, 187, 175, 12, 66, 40, 224, 117, 162, 31, 92, 90, 6, 101, 115, 245, 211, 251, 20, 180, 176, 193, 30, 13, 200, 185, 215, 58, 61, 131, 106 }, new byte[] { 135, 55, 108, 115, 36, 128, 86, 239, 253, 162, 139, 103, 195, 52, 250, 39, 196, 254, 66, 24, 148, 12, 158, 128, 230, 103, 88, 108, 111, 59, 82, 128, 114, 230, 75, 167, 56, 70, 27, 240, 170, 93, 171, 43, 201, 47, 119, 204, 140, 24, 221, 1, 83, 12, 200, 243, 87, 70, 14, 97, 55, 24, 41, 68, 13, 250, 200, 190, 32, 245, 47, 68, 181, 163, 241, 173, 141, 141, 77, 9, 253, 53, 63, 217, 247, 114, 116, 42, 132, 156, 133, 126, 119, 127, 10, 219, 21, 54, 1, 134, 34, 120, 68, 195, 235, 123, 252, 50, 144, 104, 3, 202, 29, 249, 193, 175, 159, 232, 65, 57, 92, 176, 120, 13, 255, 32, 190, 5 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 165, 120, 217, 243, 135, 40, 212, 14, 9, 181, 133, 71, 113, 65, 247, 91, 133, 156, 237, 46, 157, 96, 118, 121, 239, 21, 61, 249, 161, 20, 159, 130, 234, 187, 175, 12, 66, 40, 224, 117, 162, 31, 92, 90, 6, 101, 115, 245, 211, 251, 20, 180, 176, 193, 30, 13, 200, 185, 215, 58, 61, 131, 106 }, new byte[] { 135, 55, 108, 115, 36, 128, 86, 239, 253, 162, 139, 103, 195, 52, 250, 39, 196, 254, 66, 24, 148, 12, 158, 128, 230, 103, 88, 108, 111, 59, 82, 128, 114, 230, 75, 167, 56, 70, 27, 240, 170, 93, 171, 43, 201, 47, 119, 204, 140, 24, 221, 1, 83, 12, 200, 243, 87, 70, 14, 97, 55, 24, 41, 68, 13, 250, 200, 190, 32, 245, 47, 68, 181, 163, 241, 173, 141, 141, 77, 9, 253, 53, 63, 217, 247, 114, 116, 42, 132, 156, 133, 126, 119, 127, 10, 219, 21, 54, 1, 134, 34, 120, 68, 195, 235, 123, 252, 50, 144, 104, 3, 202, 29, 249, 193, 175, 159, 232, 65, 57, 92, 176, 120, 13, 255, 32, 190, 5 } });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 675, DateTimeKind.Utc).AddTicks(9508), new DateTime(2020, 12, 22, 9, 19, 16, 169, DateTimeKind.Local).AddTicks(8463), new DateTime(2020, 3, 11, 16, 8, 2, 676, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(699), new DateTime(2020, 11, 14, 15, 40, 57, 6, DateTimeKind.Local).AddTicks(9045), new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(3103), new DateTime(2020, 7, 30, 19, 52, 59, 761, DateTimeKind.Local).AddTicks(3468), new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(4761), new DateTime(2020, 5, 31, 12, 3, 49, 720, DateTimeKind.Local).AddTicks(582), new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(6986), new DateTime(2021, 2, 20, 13, 0, 7, 73, DateTimeKind.Local).AddTicks(3201), new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(8636), new DateTime(2020, 7, 4, 18, 10, 37, 822, DateTimeKind.Local).AddTicks(478), new DateTime(2020, 3, 11, 16, 8, 2, 677, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 678, DateTimeKind.Utc).AddTicks(247), new DateTime(2020, 4, 13, 5, 11, 23, 785, DateTimeKind.Local).AddTicks(4596), new DateTime(2020, 3, 11, 16, 8, 2, 678, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 678, DateTimeKind.Utc).AddTicks(9994), new DateTime(2020, 6, 8, 15, 30, 19, 745, DateTimeKind.Local).AddTicks(2680), new DateTime(2020, 3, 11, 16, 8, 2, 679, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 679, DateTimeKind.Utc).AddTicks(4498), new DateTime(2020, 5, 11, 17, 28, 20, 803, DateTimeKind.Local).AddTicks(5125), new DateTime(2020, 3, 11, 16, 8, 2, 679, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 679, DateTimeKind.Utc).AddTicks(6866), new DateTime(2020, 5, 19, 13, 13, 52, 700, DateTimeKind.Local).AddTicks(4419), new DateTime(2020, 3, 11, 16, 8, 2, 679, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 11L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(445), new DateTime(2020, 3, 12, 7, 21, 55, 317, DateTimeKind.Local).AddTicks(6855), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 12L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2577), new DateTime(2020, 3, 26, 14, 33, 16, 214, DateTimeKind.Local).AddTicks(234), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 13L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2659), new DateTime(2020, 7, 15, 14, 39, 28, 578, DateTimeKind.Local).AddTicks(6611), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 14L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2711), new DateTime(2021, 2, 23, 1, 54, 29, 603, DateTimeKind.Local).AddTicks(612), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 15L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2754), new DateTime(2020, 4, 8, 4, 10, 52, 651, DateTimeKind.Local).AddTicks(5026), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 16L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(4201), new DateTime(2020, 12, 6, 22, 56, 0, 830, DateTimeKind.Local).AddTicks(1071), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 17L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(4273), new DateTime(2020, 4, 18, 12, 54, 49, 218, DateTimeKind.Local).AddTicks(294), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 18L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(6043), new DateTime(2020, 8, 16, 19, 52, 12, 283, DateTimeKind.Local).AddTicks(3463), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 19L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(6116), new DateTime(2020, 10, 12, 7, 42, 59, 440, DateTimeKind.Local).AddTicks(6292), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 20L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(8575), new DateTime(2020, 11, 29, 18, 55, 24, 162, DateTimeKind.Local).AddTicks(2717), new DateTime(2020, 3, 11, 16, 8, 2, 680, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 21L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(505), new DateTime(2020, 3, 25, 21, 31, 4, 417, DateTimeKind.Local).AddTicks(5008), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 22L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(590), new DateTime(2021, 1, 1, 21, 7, 41, 679, DateTimeKind.Local).AddTicks(8372), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 23L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(2192), new DateTime(2021, 2, 5, 3, 40, 14, 506, DateTimeKind.Local).AddTicks(6699), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 24L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3738), new DateTime(2020, 9, 27, 23, 36, 17, 848, DateTimeKind.Local).AddTicks(9315), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 25L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3814), new DateTime(2020, 10, 9, 22, 51, 20, 650, DateTimeKind.Local).AddTicks(9769), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 26L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3886), new DateTime(2020, 5, 22, 9, 35, 48, 11, DateTimeKind.Local).AddTicks(531), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 27L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3931), new DateTime(2020, 7, 7, 19, 11, 45, 875, DateTimeKind.Local).AddTicks(4507), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 28L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(4117), new DateTime(2020, 8, 23, 17, 38, 29, 40, DateTimeKind.Local).AddTicks(4445), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 29L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6036), new DateTime(2020, 7, 14, 21, 4, 36, 836, DateTimeKind.Local).AddTicks(5624), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 30L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6120), new DateTime(2020, 4, 12, 14, 56, 16, 595, DateTimeKind.Local).AddTicks(1794), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 31L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6356), new DateTime(2021, 2, 1, 23, 59, 3, 947, DateTimeKind.Local).AddTicks(4343), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 32L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(7782), new DateTime(2020, 7, 16, 20, 36, 37, 204, DateTimeKind.Local).AddTicks(3633), new DateTime(2020, 3, 11, 16, 8, 2, 681, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 33L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(784), new DateTime(2020, 3, 24, 5, 8, 11, 529, DateTimeKind.Local).AddTicks(6394), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 34L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(945), new DateTime(2021, 2, 25, 6, 42, 34, 846, DateTimeKind.Local).AddTicks(7212), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 35L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1062), new DateTime(2020, 5, 13, 18, 1, 21, 624, DateTimeKind.Local).AddTicks(4800), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 36L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1173), new DateTime(2020, 10, 7, 23, 34, 22, 139, DateTimeKind.Local).AddTicks(7821), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 37L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1277), new DateTime(2020, 10, 11, 10, 34, 37, 876, DateTimeKind.Local).AddTicks(2109), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 38L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1463), new DateTime(2020, 7, 12, 3, 49, 33, 333, DateTimeKind.Local).AddTicks(4136), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 39L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1535), new DateTime(2021, 2, 21, 14, 50, 17, 428, DateTimeKind.Local).AddTicks(4882), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 40L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1579), new DateTime(2020, 8, 11, 16, 40, 49, 513, DateTimeKind.Local).AddTicks(3440), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 41L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2323), new DateTime(2021, 1, 7, 1, 49, 37, 159, DateTimeKind.Local).AddTicks(1716), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 42L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2657), new DateTime(2020, 7, 17, 6, 29, 1, 770, DateTimeKind.Local).AddTicks(8771), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 43L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2881), new DateTime(2020, 3, 19, 8, 57, 6, 237, DateTimeKind.Local).AddTicks(2987), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 44L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2946), new DateTime(2020, 5, 6, 6, 35, 52, 242, DateTimeKind.Local).AddTicks(1867), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 45L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4479), new DateTime(2021, 1, 6, 2, 31, 14, 283, DateTimeKind.Local).AddTicks(9246), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 46L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4550), new DateTime(2020, 12, 31, 7, 40, 48, 858, DateTimeKind.Local).AddTicks(3889), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 47L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4620), new DateTime(2020, 4, 15, 1, 35, 39, 941, DateTimeKind.Local).AddTicks(2121), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 48L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4671), new DateTime(2020, 8, 21, 13, 26, 17, 30, DateTimeKind.Local).AddTicks(9933), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 49L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6140), new DateTime(2021, 2, 27, 8, 10, 3, 921, DateTimeKind.Local).AddTicks(4069), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 50L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6213), new DateTime(2020, 8, 18, 12, 42, 34, 868, DateTimeKind.Local).AddTicks(3824), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 51L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6257), new DateTime(2021, 2, 20, 23, 2, 13, 629, DateTimeKind.Local).AddTicks(2471), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 52L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6296), new DateTime(2020, 9, 5, 15, 7, 18, 1, DateTimeKind.Local).AddTicks(999), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 53L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6333), new DateTime(2020, 3, 19, 3, 36, 0, 627, DateTimeKind.Local).AddTicks(3875), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 54L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6372), new DateTime(2020, 5, 24, 18, 21, 23, 493, DateTimeKind.Local).AddTicks(4894), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 55L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6421), new DateTime(2020, 3, 18, 11, 31, 19, 474, DateTimeKind.Local).AddTicks(8140), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 56L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6459), new DateTime(2020, 6, 30, 10, 10, 58, 880, DateTimeKind.Local).AddTicks(413), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 57L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6555), new DateTime(2020, 6, 19, 2, 46, 18, 901, DateTimeKind.Local).AddTicks(5135), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 58L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6745), new DateTime(2021, 3, 11, 15, 10, 3, 894, DateTimeKind.Local).AddTicks(4668), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 59L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6870), new DateTime(2020, 10, 2, 18, 54, 45, 451, DateTimeKind.Local).AddTicks(153), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 60L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6979), new DateTime(2021, 2, 16, 14, 52, 17, 144, DateTimeKind.Local).AddTicks(9377), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 61L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7207), new DateTime(2020, 7, 21, 19, 2, 54, 323, DateTimeKind.Local).AddTicks(7148), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 62L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7316), new DateTime(2020, 8, 22, 20, 10, 12, 593, DateTimeKind.Local).AddTicks(7572), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 63L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7415), new DateTime(2020, 7, 21, 7, 41, 17, 26, DateTimeKind.Local).AddTicks(1332), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 64L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7516), new DateTime(2020, 6, 30, 6, 45, 57, 631, DateTimeKind.Local).AddTicks(8350), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 65L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7704), new DateTime(2020, 6, 11, 8, 22, 50, 623, DateTimeKind.Local).AddTicks(3800), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 66L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7812), new DateTime(2020, 8, 27, 22, 27, 12, 410, DateTimeKind.Local).AddTicks(8233), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 67L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7922), new DateTime(2021, 1, 16, 4, 44, 44, 439, DateTimeKind.Local).AddTicks(1761), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 68L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8032), new DateTime(2020, 9, 29, 17, 18, 27, 446, DateTimeKind.Local).AddTicks(9036), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 69L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8139), new DateTime(2021, 1, 7, 17, 34, 9, 38, DateTimeKind.Local).AddTicks(8698), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 70L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8284), new DateTime(2020, 9, 24, 5, 13, 1, 21, DateTimeKind.Local).AddTicks(1591), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 71L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8383), new DateTime(2021, 2, 16, 13, 45, 30, 405, DateTimeKind.Local).AddTicks(1917), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 72L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8487), new DateTime(2020, 10, 1, 23, 20, 7, 130, DateTimeKind.Local).AddTicks(9487), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 73L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8586), new DateTime(2020, 12, 1, 6, 40, 46, 858, DateTimeKind.Local).AddTicks(2099), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 74L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8686), new DateTime(2020, 5, 31, 2, 32, 45, 391, DateTimeKind.Local).AddTicks(2747), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 75L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8786), new DateTime(2020, 4, 6, 0, 8, 39, 619, DateTimeKind.Local).AddTicks(2259), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 76L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8893), new DateTime(2020, 7, 16, 2, 45, 10, 429, DateTimeKind.Local).AddTicks(4190), new DateTime(2020, 3, 11, 16, 8, 2, 682, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 77L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(221), new DateTime(2021, 1, 10, 16, 6, 3, 880, DateTimeKind.Local).AddTicks(6147), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 78L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(363), new DateTime(2020, 12, 29, 9, 31, 55, 813, DateTimeKind.Local).AddTicks(7169), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 79L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(469), new DateTime(2021, 1, 25, 23, 25, 50, 856, DateTimeKind.Local).AddTicks(8223), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 80L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(730), new DateTime(2020, 10, 23, 11, 17, 25, 902, DateTimeKind.Local).AddTicks(2943), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 81L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(843), new DateTime(2021, 1, 7, 1, 42, 38, 267, DateTimeKind.Local).AddTicks(7068), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 82L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(946), new DateTime(2020, 5, 29, 16, 55, 49, 317, DateTimeKind.Local).AddTicks(6065), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 83L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(1053), new DateTime(2020, 11, 27, 10, 45, 4, 687, DateTimeKind.Local).AddTicks(9506), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 84L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(2931), new DateTime(2020, 7, 29, 14, 39, 2, 313, DateTimeKind.Local).AddTicks(3508), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 85L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4549), new DateTime(2020, 5, 9, 17, 8, 11, 397, DateTimeKind.Local).AddTicks(2214), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 86L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4782), new DateTime(2020, 9, 28, 17, 21, 58, 425, DateTimeKind.Local).AddTicks(9820), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 87L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4832), new DateTime(2020, 10, 6, 17, 55, 15, 250, DateTimeKind.Local).AddTicks(3764), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 88L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4878), new DateTime(2021, 1, 22, 9, 1, 1, 700, DateTimeKind.Local).AddTicks(7904), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 89L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4927), new DateTime(2020, 11, 14, 19, 55, 54, 79, DateTimeKind.Local).AddTicks(6429), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 90L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4989), new DateTime(2020, 11, 28, 12, 8, 37, 961, DateTimeKind.Local).AddTicks(6190), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 91L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5033), new DateTime(2020, 6, 5, 0, 9, 56, 460, DateTimeKind.Local).AddTicks(1114), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 92L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5073), new DateTime(2021, 1, 25, 3, 29, 58, 663, DateTimeKind.Local).AddTicks(8596), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 93L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5124), new DateTime(2020, 7, 31, 12, 9, 49, 726, DateTimeKind.Local).AddTicks(6828), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 94L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5165), new DateTime(2021, 2, 16, 14, 22, 50, 705, DateTimeKind.Local).AddTicks(1275), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 95L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5208), new DateTime(2021, 1, 25, 6, 34, 44, 661, DateTimeKind.Local).AddTicks(8846), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 96L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5251), new DateTime(2020, 4, 25, 16, 15, 2, 85, DateTimeKind.Local).AddTicks(2039), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 97L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(6772), new DateTime(2021, 2, 9, 21, 28, 40, 550, DateTimeKind.Local).AddTicks(3791), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 98L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8276), new DateTime(2020, 8, 12, 19, 20, 27, 18, DateTimeKind.Local).AddTicks(4077), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 99L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8416), new DateTime(2020, 11, 23, 7, 36, 44, 249, DateTimeKind.Local).AddTicks(5954), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 100L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8480), new DateTime(2020, 10, 6, 14, 15, 4, 495, DateTimeKind.Local).AddTicks(7966), new DateTime(2020, 3, 11, 16, 8, 2, 683, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.CreateIndex(
                name: "IX_address_person_PictureId",
                table: "address_person",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_address_person_relation_AddressPersonId",
                table: "address_person_relation",
                column: "AddressPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_person_relation");

            migrationBuilder.DropTable(
                name: "address_person");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 204, 98, 37, 134, 199, 51, 26, 101, 148, 185, 35, 167, 239, 251, 107, 112, 183, 0, 24, 119, 91, 62, 119, 191, 220, 121, 213, 130, 102, 110, 179, 57, 39, 153, 9, 67, 163, 152, 16, 6, 185, 92, 254, 110, 231, 55, 48, 222, 174, 209, 31, 150, 245, 87, 131, 1, 26, 183, 229, 226, 68, 79, 234 }, new byte[] { 115, 18, 232, 71, 212, 188, 46, 135, 99, 196, 93, 135, 225, 49, 102, 122, 136, 16, 190, 112, 142, 25, 209, 47, 96, 96, 179, 103, 226, 106, 93, 79, 74, 223, 152, 98, 184, 13, 218, 33, 92, 209, 11, 81, 229, 20, 92, 246, 224, 223, 217, 233, 147, 132, 192, 93, 43, 132, 229, 68, 82, 211, 218, 248, 232, 249, 119, 86, 137, 4, 39, 2, 118, 121, 93, 227, 84, 41, 91, 23, 13, 125, 74, 178, 88, 124, 230, 173, 107, 142, 210, 215, 170, 177, 92, 38, 51, 74, 159, 196, 254, 171, 203, 105, 154, 249, 81, 182, 208, 138, 1, 136, 117, 154, 243, 86, 95, 46, 160, 137, 66, 87, 199, 210, 158, 35, 79, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 204, 98, 37, 134, 199, 51, 26, 101, 148, 185, 35, 167, 239, 251, 107, 112, 183, 0, 24, 119, 91, 62, 119, 191, 220, 121, 213, 130, 102, 110, 179, 57, 39, 153, 9, 67, 163, 152, 16, 6, 185, 92, 254, 110, 231, 55, 48, 222, 174, 209, 31, 150, 245, 87, 131, 1, 26, 183, 229, 226, 68, 79, 234 }, new byte[] { 115, 18, 232, 71, 212, 188, 46, 135, 99, 196, 93, 135, 225, 49, 102, 122, 136, 16, 190, 112, 142, 25, 209, 47, 96, 96, 179, 103, 226, 106, 93, 79, 74, 223, 152, 98, 184, 13, 218, 33, 92, 209, 11, 81, 229, 20, 92, 246, 224, 223, 217, 233, 147, 132, 192, 93, 43, 132, 229, 68, 82, 211, 218, 248, 232, 249, 119, 86, 137, 4, 39, 2, 118, 121, 93, 227, 84, 41, 91, 23, 13, 125, 74, 178, 88, 124, 230, 173, 107, 142, 210, 215, 170, 177, 92, 38, 51, 74, 159, 196, 254, 171, 203, 105, 154, 249, 81, 182, 208, 138, 1, 136, 117, 154, 243, 86, 95, 46, 160, 137, 66, 87, 199, 210, 158, 35, 79, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 204, 98, 37, 134, 199, 51, 26, 101, 148, 185, 35, 167, 239, 251, 107, 112, 183, 0, 24, 119, 91, 62, 119, 191, 220, 121, 213, 130, 102, 110, 179, 57, 39, 153, 9, 67, 163, 152, 16, 6, 185, 92, 254, 110, 231, 55, 48, 222, 174, 209, 31, 150, 245, 87, 131, 1, 26, 183, 229, 226, 68, 79, 234 }, new byte[] { 115, 18, 232, 71, 212, 188, 46, 135, 99, 196, 93, 135, 225, 49, 102, 122, 136, 16, 190, 112, 142, 25, 209, 47, 96, 96, 179, 103, 226, 106, 93, 79, 74, 223, 152, 98, 184, 13, 218, 33, 92, 209, 11, 81, 229, 20, 92, 246, 224, 223, 217, 233, 147, 132, 192, 93, 43, 132, 229, 68, 82, 211, 218, 248, 232, 249, 119, 86, 137, 4, 39, 2, 118, 121, 93, 227, 84, 41, 91, 23, 13, 125, 74, 178, 88, 124, 230, 173, 107, 142, 210, 215, 170, 177, 92, 38, 51, 74, 159, 196, 254, 171, 203, 105, 154, 249, 81, 182, 208, 138, 1, 136, 117, 154, 243, 86, 95, 46, 160, 137, 66, 87, 199, 210, 158, 35, 79, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 204, 98, 37, 134, 199, 51, 26, 101, 148, 185, 35, 167, 239, 251, 107, 112, 183, 0, 24, 119, 91, 62, 119, 191, 220, 121, 213, 130, 102, 110, 179, 57, 39, 153, 9, 67, 163, 152, 16, 6, 185, 92, 254, 110, 231, 55, 48, 222, 174, 209, 31, 150, 245, 87, 131, 1, 26, 183, 229, 226, 68, 79, 234 }, new byte[] { 115, 18, 232, 71, 212, 188, 46, 135, 99, 196, 93, 135, 225, 49, 102, 122, 136, 16, 190, 112, 142, 25, 209, 47, 96, 96, 179, 103, 226, 106, 93, 79, 74, 223, 152, 98, 184, 13, 218, 33, 92, 209, 11, 81, 229, 20, 92, 246, 224, 223, 217, 233, 147, 132, 192, 93, 43, 132, 229, 68, 82, 211, 218, 248, 232, 249, 119, 86, 137, 4, 39, 2, 118, 121, 93, 227, 84, 41, 91, 23, 13, 125, 74, 178, 88, 124, 230, 173, 107, 142, 210, 215, 170, 177, 92, 38, 51, 74, 159, 196, 254, 171, 203, 105, 154, 249, 81, 182, 208, 138, 1, 136, 117, 154, 243, 86, 95, 46, 160, 137, 66, 87, 199, 210, 158, 35, 79, 232 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 204, 98, 37, 134, 199, 51, 26, 101, 148, 185, 35, 167, 239, 251, 107, 112, 183, 0, 24, 119, 91, 62, 119, 191, 220, 121, 213, 130, 102, 110, 179, 57, 39, 153, 9, 67, 163, 152, 16, 6, 185, 92, 254, 110, 231, 55, 48, 222, 174, 209, 31, 150, 245, 87, 131, 1, 26, 183, 229, 226, 68, 79, 234 }, new byte[] { 115, 18, 232, 71, 212, 188, 46, 135, 99, 196, 93, 135, 225, 49, 102, 122, 136, 16, 190, 112, 142, 25, 209, 47, 96, 96, 179, 103, 226, 106, 93, 79, 74, 223, 152, 98, 184, 13, 218, 33, 92, 209, 11, 81, 229, 20, 92, 246, 224, 223, 217, 233, 147, 132, 192, 93, 43, 132, 229, 68, 82, 211, 218, 248, 232, 249, 119, 86, 137, 4, 39, 2, 118, 121, 93, 227, 84, 41, 91, 23, 13, 125, 74, 178, 88, 124, 230, 173, 107, 142, 210, 215, 170, 177, 92, 38, 51, 74, 159, 196, 254, 171, 203, 105, 154, 249, 81, 182, 208, 138, 1, 136, 117, 154, 243, 86, 95, 46, 160, 137, 66, 87, 199, 210, 158, 35, 79, 232 } });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 139, DateTimeKind.Utc).AddTicks(1962), new DateTime(2020, 12, 22, 8, 58, 45, 630, DateTimeKind.Local).AddTicks(7191), new DateTime(2020, 3, 11, 15, 47, 32, 139, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 140, DateTimeKind.Utc).AddTicks(5463), new DateTime(2020, 11, 14, 15, 20, 26, 470, DateTimeKind.Local).AddTicks(3772), new DateTime(2020, 3, 11, 15, 47, 32, 140, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 140, DateTimeKind.Utc).AddTicks(8383), new DateTime(2020, 7, 30, 19, 32, 29, 224, DateTimeKind.Local).AddTicks(8734), new DateTime(2020, 3, 11, 15, 47, 32, 140, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(422), new DateTime(2020, 5, 31, 11, 43, 19, 183, DateTimeKind.Local).AddTicks(6260), new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(3102), new DateTime(2021, 2, 20, 12, 39, 36, 536, DateTimeKind.Local).AddTicks(9306), new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(5733), new DateTime(2020, 7, 4, 17, 50, 7, 285, DateTimeKind.Local).AddTicks(7554), new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(8044), new DateTime(2020, 4, 13, 4, 50, 53, 249, DateTimeKind.Local).AddTicks(2375), new DateTime(2020, 3, 11, 15, 47, 32, 141, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 142, DateTimeKind.Utc).AddTicks(7024), new DateTime(2020, 6, 8, 15, 9, 49, 208, DateTimeKind.Local).AddTicks(9742), new DateTime(2020, 3, 11, 15, 47, 32, 142, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(6), new DateTime(2020, 5, 11, 17, 7, 50, 267, DateTimeKind.Local).AddTicks(662), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(2091), new DateTime(2020, 5, 19, 12, 53, 22, 163, DateTimeKind.Local).AddTicks(9638), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 11L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(6857), new DateTime(2020, 3, 12, 7, 1, 24, 781, DateTimeKind.Local).AddTicks(3252), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 12L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9770), new DateTime(2020, 3, 26, 14, 12, 45, 677, DateTimeKind.Local).AddTicks(7410), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 13L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9875), new DateTime(2020, 7, 15, 14, 18, 58, 42, DateTimeKind.Local).AddTicks(3823), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 14L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9939), new DateTime(2021, 2, 23, 1, 33, 59, 66, DateTimeKind.Local).AddTicks(7838), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 15L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9995), new DateTime(2020, 4, 8, 3, 50, 22, 115, DateTimeKind.Local).AddTicks(2264), new DateTime(2020, 3, 11, 15, 47, 32, 143, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 16L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(2142), new DateTime(2020, 12, 6, 22, 35, 30, 293, DateTimeKind.Local).AddTicks(8998), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 17L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(2241), new DateTime(2020, 4, 18, 12, 34, 18, 681, DateTimeKind.Local).AddTicks(8258), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 18L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(4336), new DateTime(2020, 8, 16, 19, 31, 41, 747, DateTimeKind.Local).AddTicks(1746), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 19L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(4430), new DateTime(2020, 10, 12, 7, 22, 28, 904, DateTimeKind.Local).AddTicks(4601), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 20L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(7587), new DateTime(2020, 11, 29, 18, 34, 53, 626, DateTimeKind.Local).AddTicks(1716), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 21L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(9918), new DateTime(2020, 3, 25, 21, 10, 33, 881, DateTimeKind.Local).AddTicks(4410), new DateTime(2020, 3, 11, 15, 47, 32, 144, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 22L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(28), new DateTime(2021, 1, 1, 20, 47, 11, 143, DateTimeKind.Local).AddTicks(7805), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 23L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(2013), new DateTime(2021, 2, 5, 3, 19, 43, 970, DateTimeKind.Local).AddTicks(6510), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 24L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(3999), new DateTime(2020, 9, 27, 23, 15, 47, 312, DateTimeKind.Local).AddTicks(9563), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 25L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4097), new DateTime(2020, 10, 9, 22, 30, 50, 115, DateTimeKind.Local).AddTicks(48), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 26L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4186), new DateTime(2020, 5, 22, 9, 15, 17, 475, DateTimeKind.Local).AddTicks(828), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 27L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4237), new DateTime(2020, 7, 7, 18, 51, 15, 339, DateTimeKind.Local).AddTicks(4812), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 28L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4289), new DateTime(2020, 8, 23, 17, 17, 58, 504, DateTimeKind.Local).AddTicks(4621), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 29L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6327), new DateTime(2020, 7, 14, 20, 44, 6, 300, DateTimeKind.Local).AddTicks(5905), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 30L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6415), new DateTime(2020, 4, 12, 14, 35, 46, 59, DateTimeKind.Local).AddTicks(2093), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 31L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6492), new DateTime(2021, 2, 1, 23, 38, 33, 411, DateTimeKind.Local).AddTicks(4528), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 32L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(7597), new DateTime(2020, 7, 16, 20, 16, 6, 668, DateTimeKind.Local).AddTicks(3467), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 33L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9466), new DateTime(2020, 3, 24, 4, 47, 40, 993, DateTimeKind.Local).AddTicks(5102), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 34L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9556), new DateTime(2021, 2, 25, 6, 22, 4, 310, DateTimeKind.Local).AddTicks(5839), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 35L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9609), new DateTime(2020, 5, 13, 17, 40, 51, 88, DateTimeKind.Local).AddTicks(3363), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 36L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9663), new DateTime(2020, 10, 7, 23, 13, 51, 603, DateTimeKind.Local).AddTicks(6328), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 37L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9717), new DateTime(2020, 10, 11, 10, 14, 7, 340, DateTimeKind.Local).AddTicks(563), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 38L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9787), new DateTime(2020, 7, 12, 3, 29, 2, 797, DateTimeKind.Local).AddTicks(2482), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 39L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9837), new DateTime(2021, 2, 21, 14, 29, 46, 892, DateTimeKind.Local).AddTicks(3185), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 40L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9888), new DateTime(2020, 8, 11, 16, 20, 18, 977, DateTimeKind.Local).AddTicks(1746), new DateTime(2020, 3, 11, 15, 47, 32, 145, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 41L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(759), new DateTime(2021, 1, 7, 1, 29, 6, 623, DateTimeKind.Local).AddTicks(144), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 42L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1189), new DateTime(2020, 7, 17, 6, 8, 31, 234, DateTimeKind.Local).AddTicks(7296), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 43L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1273), new DateTime(2020, 3, 19, 8, 36, 35, 701, DateTimeKind.Local).AddTicks(1379), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 44L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1345), new DateTime(2020, 5, 6, 6, 15, 21, 706, DateTimeKind.Local).AddTicks(264), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 45L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3270), new DateTime(2021, 1, 6, 2, 10, 43, 747, DateTimeKind.Local).AddTicks(8026), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 46L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3352), new DateTime(2020, 12, 31, 7, 20, 18, 322, DateTimeKind.Local).AddTicks(2689), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 47L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3403), new DateTime(2020, 4, 15, 1, 15, 9, 405, DateTimeKind.Local).AddTicks(902), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 48L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3565), new DateTime(2020, 8, 21, 13, 5, 46, 494, DateTimeKind.Local).AddTicks(8823), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 49L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5395), new DateTime(2021, 2, 27, 7, 49, 33, 385, DateTimeKind.Local).AddTicks(3315), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 50L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5488), new DateTime(2020, 8, 18, 12, 22, 4, 332, DateTimeKind.Local).AddTicks(3095), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 51L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5544), new DateTime(2021, 2, 20, 22, 41, 43, 93, DateTimeKind.Local).AddTicks(1755), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 52L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5593), new DateTime(2020, 9, 5, 14, 46, 47, 465, DateTimeKind.Local).AddTicks(294), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 53L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5643), new DateTime(2020, 3, 19, 3, 15, 30, 91, DateTimeKind.Local).AddTicks(3182), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 54L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5692), new DateTime(2020, 5, 24, 18, 0, 52, 957, DateTimeKind.Local).AddTicks(4212), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 55L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5756), new DateTime(2020, 3, 18, 11, 10, 48, 938, DateTimeKind.Local).AddTicks(7472), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 56L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5805), new DateTime(2020, 6, 30, 9, 50, 28, 343, DateTimeKind.Local).AddTicks(9758), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 57L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5857), new DateTime(2020, 6, 19, 2, 25, 48, 365, DateTimeKind.Local).AddTicks(4473), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 58L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5906), new DateTime(2021, 3, 11, 14, 49, 33, 358, DateTimeKind.Local).AddTicks(3876), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 59L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5958), new DateTime(2020, 10, 2, 18, 34, 14, 914, DateTimeKind.Local).AddTicks(9263), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 60L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6007), new DateTime(2021, 2, 16, 14, 31, 46, 608, DateTimeKind.Local).AddTicks(8422), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 61L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6058), new DateTime(2020, 7, 21, 18, 42, 23, 787, DateTimeKind.Local).AddTicks(6017), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 62L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6106), new DateTime(2020, 8, 22, 19, 49, 42, 57, DateTimeKind.Local).AddTicks(6378), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 63L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6155), new DateTime(2020, 7, 21, 7, 20, 46, 490, DateTimeKind.Local).AddTicks(89), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 64L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6203), new DateTime(2020, 6, 30, 6, 25, 27, 95, DateTimeKind.Local).AddTicks(7053), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 65L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6302), new DateTime(2020, 6, 11, 8, 2, 20, 87, DateTimeKind.Local).AddTicks(2413), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 66L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6354), new DateTime(2020, 8, 27, 22, 6, 41, 874, DateTimeKind.Local).AddTicks(6790), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 67L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6505), new DateTime(2021, 1, 16, 4, 24, 13, 903, DateTimeKind.Local).AddTicks(356), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 68L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6562), new DateTime(2020, 9, 29, 16, 57, 56, 910, DateTimeKind.Local).AddTicks(7578), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 69L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6610), new DateTime(2021, 1, 7, 17, 13, 38, 502, DateTimeKind.Local).AddTicks(7189), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 70L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6682), new DateTime(2020, 9, 24, 4, 52, 30, 485, DateTimeKind.Local).AddTicks(6), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 71L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6730), new DateTime(2021, 2, 16, 13, 24, 59, 869, DateTimeKind.Local).AddTicks(281), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 72L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6781), new DateTime(2020, 10, 1, 22, 59, 36, 594, DateTimeKind.Local).AddTicks(7795), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 73L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6828), new DateTime(2020, 12, 1, 6, 20, 16, 322, DateTimeKind.Local).AddTicks(358), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 74L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6877), new DateTime(2020, 5, 31, 2, 12, 14, 855, DateTimeKind.Local).AddTicks(952), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 75L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6926), new DateTime(2020, 4, 5, 23, 48, 9, 83, DateTimeKind.Local).AddTicks(414), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 76L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6977), new DateTime(2020, 7, 16, 2, 24, 39, 893, DateTimeKind.Local).AddTicks(2291), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 77L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7848), new DateTime(2021, 1, 10, 15, 45, 33, 344, DateTimeKind.Local).AddTicks(3794), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 78L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7927), new DateTime(2020, 12, 29, 9, 11, 25, 277, DateTimeKind.Local).AddTicks(4750), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 79L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7979), new DateTime(2021, 1, 25, 23, 5, 20, 320, DateTimeKind.Local).AddTicks(5748), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 80L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8033), new DateTime(2020, 10, 23, 10, 56, 55, 366, DateTimeKind.Local).AddTicks(265), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 81L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8085), new DateTime(2021, 1, 7, 1, 22, 7, 731, DateTimeKind.Local).AddTicks(4330), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 82L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8133), new DateTime(2020, 5, 29, 16, 35, 18, 781, DateTimeKind.Local).AddTicks(3266), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 83L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8183), new DateTime(2020, 11, 27, 10, 24, 34, 151, DateTimeKind.Local).AddTicks(6654), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 84L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(9989), new DateTime(2020, 7, 29, 14, 18, 31, 777, DateTimeKind.Local).AddTicks(565), new DateTime(2020, 3, 11, 15, 47, 32, 146, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 85L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(1972), new DateTime(2020, 5, 9, 16, 47, 40, 860, DateTimeKind.Local).AddTicks(9657), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 86L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2160), new DateTime(2020, 9, 28, 17, 1, 27, 889, DateTimeKind.Local).AddTicks(7344), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 87L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2215), new DateTime(2020, 10, 6, 17, 34, 44, 714, DateTimeKind.Local).AddTicks(1146), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 88L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2266), new DateTime(2021, 1, 22, 8, 40, 31, 164, DateTimeKind.Local).AddTicks(5291), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 89L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2321), new DateTime(2020, 11, 14, 19, 35, 23, 543, DateTimeKind.Local).AddTicks(3822), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 90L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2394), new DateTime(2020, 11, 28, 11, 48, 7, 425, DateTimeKind.Local).AddTicks(3592), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 91L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2447), new DateTime(2020, 6, 4, 23, 49, 25, 923, DateTimeKind.Local).AddTicks(8526), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 92L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2495), new DateTime(2021, 1, 25, 3, 9, 28, 127, DateTimeKind.Local).AddTicks(6017), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 93L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2558), new DateTime(2020, 7, 31, 11, 49, 19, 190, DateTimeKind.Local).AddTicks(4260), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 94L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2606), new DateTime(2021, 2, 16, 14, 2, 20, 168, DateTimeKind.Local).AddTicks(8714), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 95L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2656), new DateTime(2021, 1, 25, 6, 14, 14, 125, DateTimeKind.Local).AddTicks(6291), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 96L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2707), new DateTime(2020, 4, 25, 15, 54, 31, 548, DateTimeKind.Local).AddTicks(9493), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 97L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(4546), new DateTime(2021, 2, 9, 21, 8, 10, 14, DateTimeKind.Local).AddTicks(1561), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 98L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6367), new DateTime(2020, 8, 12, 18, 59, 56, 482, DateTimeKind.Local).AddTicks(2160), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 99L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6460), new DateTime(2020, 11, 23, 7, 16, 13, 713, DateTimeKind.Local).AddTicks(3995), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 100L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6534), new DateTime(2020, 10, 6, 13, 54, 33, 959, DateTimeKind.Local).AddTicks(6019), new DateTime(2020, 3, 11, 15, 47, 32, 147, DateTimeKind.Utc).AddTicks(6538) });
        }
    }
}
