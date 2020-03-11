using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "info",
                table: "WeatherForecast",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "info_rtf",
                table: "WeatherForecast",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "info",
                table: "address_country",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "info_rtf",
                table: "address_country",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "address_company_type",
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
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_company_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fagBinarys",
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
                    fk_id = table.Column<long>(nullable: false),
                    file_name = table.Column<string>(type: "varchar(max)", nullable: true),
                    data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fagBinarys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "address_address",
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
                    fk_parent_address = table.Column<long>(nullable: true),
                    fk_address_country = table.Column<long>(nullable: true),
                    fk_logo = table.Column<long>(nullable: true),
                    fk_address_company_type = table.Column<long>(nullable: true),
                    name = table.Column<string>(type: "varchar(max)", nullable: true),
                    addition = table.Column<string>(type: "varchar(max)", nullable: true),
                    addition2 = table.Column<string>(type: "varchar(max)", nullable: true),
                    street = table.Column<string>(type: "varchar(max)", nullable: true),
                    postcode = table.Column<string>(type: "varchar(max)", nullable: true),
                    city = table.Column<string>(type: "varchar(max)", nullable: true),
                    email = table.Column<string>(type: "varchar(max)", nullable: true),
                    phone = table.Column<string>(type: "varchar(max)", nullable: true),
                    fax = table.Column<string>(type: "varchar(max)", nullable: true),
                    vat_id_no = table.Column<string>(type: "varchar(max)", nullable: true),
                    timezone = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_address", x => x.id);
                    table.ForeignKey(
                        name: "FK_address_address_address_company_type_fk_address_company_type",
                        column: x => x.fk_address_company_type,
                        principalTable: "address_company_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_address_country_fk_address_country",
                        column: x => x.fk_address_country,
                        principalTable: "address_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_fagBinarys_fk_logo",
                        column: x => x.fk_logo,
                        principalTable: "fagBinarys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_address_address_address_address_fk_parent_address",
                        column: x => x.fk_parent_address,
                        principalTable: "address_address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_address_company_type",
                table: "address_address",
                column: "fk_address_company_type");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_address_country",
                table: "address_address",
                column: "fk_address_country");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_logo",
                table: "address_address",
                column: "fk_logo");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_fk_parent_address",
                table: "address_address",
                column: "fk_parent_address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_address");

            migrationBuilder.DropTable(
                name: "address_company_type");

            migrationBuilder.DropTable(
                name: "fagBinarys");

            migrationBuilder.DropColumn(
                name: "info",
                table: "WeatherForecast");

            migrationBuilder.DropColumn(
                name: "info_rtf",
                table: "WeatherForecast");

            migrationBuilder.DropColumn(
                name: "info",
                table: "address_country");

            migrationBuilder.DropColumn(
                name: "info_rtf",
                table: "address_country");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 143, 104, 163, 100, 71, 11, 205, 219, 160, 175, 144, 221, 230, 140, 113, 217, 156, 233, 240, 89, 122, 197, 250, 98, 136, 186, 52, 137, 170, 86, 179, 100, 24, 131, 228, 88, 174, 97, 63, 202, 56, 14, 83, 51, 214, 46, 185, 136, 172, 150, 119, 77, 144, 197, 45, 47, 52, 171, 227, 76, 80, 112, 80 }, new byte[] { 237, 94, 73, 227, 0, 65, 21, 243, 28, 71, 55, 61, 195, 15, 115, 32, 59, 12, 226, 183, 193, 238, 128, 199, 62, 58, 153, 133, 143, 64, 73, 237, 25, 123, 47, 196, 15, 156, 228, 228, 50, 205, 146, 150, 86, 216, 85, 7, 179, 155, 217, 86, 175, 145, 136, 102, 103, 251, 175, 221, 158, 131, 171, 133, 123, 211, 64, 8, 63, 124, 123, 155, 172, 8, 14, 2, 92, 255, 150, 189, 15, 132, 248, 181, 72, 245, 234, 168, 104, 36, 159, 27, 127, 157, 196, 131, 204, 36, 228, 212, 219, 189, 244, 5, 160, 129, 172, 141, 96, 242, 0, 182, 54, 56, 106, 6, 148, 52, 77, 119, 127, 20, 58, 137, 10, 223, 188, 209 } });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 735, DateTimeKind.Utc).AddTicks(1688), new DateTime(2020, 12, 22, 7, 26, 12, 228, DateTimeKind.Local).AddTicks(4887), new DateTime(2020, 3, 11, 14, 14, 58, 735, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(4995), new DateTime(2020, 11, 14, 13, 47, 53, 66, DateTimeKind.Local).AddTicks(3307), new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(8277), new DateTime(2020, 7, 30, 17, 59, 55, 820, DateTimeKind.Local).AddTicks(8597), new DateTime(2020, 3, 11, 14, 14, 58, 736, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(1468), new DateTime(2020, 5, 31, 10, 10, 45, 779, DateTimeKind.Local).AddTicks(7283), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(5708), new DateTime(2021, 2, 20, 11, 7, 3, 133, DateTimeKind.Local).AddTicks(1881), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(9233), new DateTime(2020, 7, 4, 16, 17, 33, 882, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 3, 11, 14, 14, 58, 737, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 738, DateTimeKind.Utc).AddTicks(3165), new DateTime(2020, 4, 13, 3, 18, 19, 845, DateTimeKind.Local).AddTicks(7492), new DateTime(2020, 3, 11, 14, 14, 58, 738, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(1855), new DateTime(2020, 6, 8, 13, 37, 15, 805, DateTimeKind.Local).AddTicks(4566), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(4909), new DateTime(2020, 5, 11, 15, 35, 16, 863, DateTimeKind.Local).AddTicks(5563), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(7023), new DateTime(2020, 5, 19, 11, 20, 48, 760, DateTimeKind.Local).AddTicks(4533), new DateTime(2020, 3, 11, 14, 14, 58, 739, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 11L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(1613), new DateTime(2020, 3, 12, 5, 28, 51, 377, DateTimeKind.Local).AddTicks(8009), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 12L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4232), new DateTime(2020, 3, 26, 12, 40, 12, 274, DateTimeKind.Local).AddTicks(1876), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 13L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4340), new DateTime(2020, 7, 15, 12, 46, 24, 638, DateTimeKind.Local).AddTicks(8290), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 14L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4407), new DateTime(2021, 2, 23, 0, 1, 25, 663, DateTimeKind.Local).AddTicks(2307), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 15L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4464), new DateTime(2020, 4, 8, 2, 17, 48, 711, DateTimeKind.Local).AddTicks(6733), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 16L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6362), new DateTime(2020, 12, 6, 21, 2, 56, 890, DateTimeKind.Local).AddTicks(3218), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 17L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6457), new DateTime(2020, 4, 18, 11, 1, 45, 278, DateTimeKind.Local).AddTicks(2473), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 18L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8676), new DateTime(2020, 8, 16, 17, 59, 8, 343, DateTimeKind.Local).AddTicks(6085), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 19L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8769), new DateTime(2020, 10, 12, 5, 49, 55, 500, DateTimeKind.Local).AddTicks(8940), new DateTime(2020, 3, 11, 14, 14, 58, 740, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 20L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(2033), new DateTime(2020, 11, 29, 17, 2, 20, 222, DateTimeKind.Local).AddTicks(6163), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 21L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4436), new DateTime(2020, 3, 25, 19, 38, 0, 477, DateTimeKind.Local).AddTicks(8928), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 22L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4548), new DateTime(2021, 1, 1, 19, 14, 37, 740, DateTimeKind.Local).AddTicks(2326), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 23L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(6558), new DateTime(2021, 2, 5, 1, 47, 10, 567, DateTimeKind.Local).AddTicks(1054), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 24L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8749), new DateTime(2020, 9, 27, 21, 43, 13, 909, DateTimeKind.Local).AddTicks(4314), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 25L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8848), new DateTime(2020, 10, 9, 20, 58, 16, 711, DateTimeKind.Local).AddTicks(4800), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 26L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8940), new DateTime(2020, 5, 22, 7, 42, 44, 71, DateTimeKind.Local).AddTicks(5583), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 27L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(8996), new DateTime(2020, 7, 7, 17, 18, 41, 935, DateTimeKind.Local).AddTicks(9570), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 28L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9051), new DateTime(2020, 8, 23, 15, 45, 25, 100, DateTimeKind.Local).AddTicks(9382), new DateTime(2020, 3, 11, 14, 14, 58, 741, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 29L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1294), new DateTime(2020, 7, 14, 19, 11, 32, 897, DateTimeKind.Local).AddTicks(870), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 30L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1385), new DateTime(2020, 4, 12, 13, 3, 12, 655, DateTimeKind.Local).AddTicks(7063), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 31L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1470), new DateTime(2021, 2, 1, 22, 6, 0, 7, DateTimeKind.Local).AddTicks(9505), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 32L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(2363), new DateTime(2020, 7, 16, 18, 43, 33, 264, DateTimeKind.Local).AddTicks(8234), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 33L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4255), new DateTime(2020, 3, 24, 3, 15, 7, 589, DateTimeKind.Local).AddTicks(9892), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 34L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4348), new DateTime(2021, 2, 25, 4, 49, 30, 907, DateTimeKind.Local).AddTicks(631), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 35L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4406), new DateTime(2020, 5, 13, 16, 8, 17, 684, DateTimeKind.Local).AddTicks(8159), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 36L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4463), new DateTime(2020, 10, 7, 21, 41, 18, 200, DateTimeKind.Local).AddTicks(1127), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 37L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4517), new DateTime(2020, 10, 11, 8, 41, 33, 936, DateTimeKind.Local).AddTicks(5363), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 38L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4592), new DateTime(2020, 7, 12, 1, 56, 29, 393, DateTimeKind.Local).AddTicks(7286), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 39L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4644), new DateTime(2021, 2, 21, 12, 57, 13, 488, DateTimeKind.Local).AddTicks(7991), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 40L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4801), new DateTime(2020, 8, 11, 14, 47, 45, 573, DateTimeKind.Local).AddTicks(6657), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 41L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(5667), new DateTime(2021, 1, 6, 23, 56, 33, 219, DateTimeKind.Local).AddTicks(5051), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 42L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6071), new DateTime(2020, 7, 17, 4, 35, 57, 831, DateTimeKind.Local).AddTicks(2178), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 43L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6162), new DateTime(2020, 3, 19, 7, 4, 2, 297, DateTimeKind.Local).AddTicks(6267), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 44L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6236), new DateTime(2020, 5, 6, 4, 42, 48, 302, DateTimeKind.Local).AddTicks(5154), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 45L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8551), new DateTime(2021, 1, 6, 0, 38, 10, 344, DateTimeKind.Local).AddTicks(3303), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 46L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8651), new DateTime(2020, 12, 31, 5, 47, 44, 918, DateTimeKind.Local).AddTicks(7984), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 47L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8709), new DateTime(2020, 4, 14, 23, 42, 36, 1, DateTimeKind.Local).AddTicks(6207), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 48L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8779), new DateTime(2020, 8, 21, 11, 33, 13, 91, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 3, 11, 14, 14, 58, 742, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 49L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(709), new DateTime(2021, 2, 27, 6, 16, 59, 981, DateTimeKind.Local).AddTicks(8626), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 50L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(809), new DateTime(2020, 8, 18, 10, 49, 30, 928, DateTimeKind.Local).AddTicks(8416), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 51L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(869), new DateTime(2021, 2, 20, 21, 9, 9, 689, DateTimeKind.Local).AddTicks(7079), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 52L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(922), new DateTime(2020, 9, 5, 13, 14, 14, 61, DateTimeKind.Local).AddTicks(5621), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 53L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(974), new DateTime(2020, 3, 19, 1, 42, 56, 687, DateTimeKind.Local).AddTicks(8511), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 54L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1028), new DateTime(2020, 5, 24, 16, 28, 19, 553, DateTimeKind.Local).AddTicks(9546), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 55L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1195), new DateTime(2020, 3, 18, 9, 38, 15, 535, DateTimeKind.Local).AddTicks(2811), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 56L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1256), new DateTime(2020, 6, 30, 8, 17, 54, 940, DateTimeKind.Local).AddTicks(5204), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 57L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1310), new DateTime(2020, 6, 19, 0, 53, 14, 961, DateTimeKind.Local).AddTicks(9924), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 58L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1362), new DateTime(2021, 3, 11, 13, 16, 59, 954, DateTimeKind.Local).AddTicks(9330), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 59L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1420), new DateTime(2020, 10, 2, 17, 1, 41, 511, DateTimeKind.Local).AddTicks(4722), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 60L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1473), new DateTime(2021, 2, 16, 12, 59, 13, 205, DateTimeKind.Local).AddTicks(3887), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 61L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1528), new DateTime(2020, 7, 21, 17, 9, 50, 384, DateTimeKind.Local).AddTicks(1485), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 62L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1580), new DateTime(2020, 8, 22, 18, 17, 8, 654, DateTimeKind.Local).AddTicks(1851), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 63L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1635), new DateTime(2020, 7, 21, 5, 48, 13, 86, DateTimeKind.Local).AddTicks(5566), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 64L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1686), new DateTime(2020, 6, 30, 4, 52, 53, 692, DateTimeKind.Local).AddTicks(2534), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 65L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1792), new DateTime(2020, 6, 11, 6, 29, 46, 683, DateTimeKind.Local).AddTicks(7903), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 66L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1846), new DateTime(2020, 8, 27, 20, 34, 8, 471, DateTimeKind.Local).AddTicks(2280), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 67L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1904), new DateTime(2021, 1, 16, 2, 51, 40, 499, DateTimeKind.Local).AddTicks(5756), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 68L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1960), new DateTime(2020, 9, 29, 15, 25, 23, 507, DateTimeKind.Local).AddTicks(2975), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 69L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2011), new DateTime(2021, 1, 7, 15, 41, 5, 99, DateTimeKind.Local).AddTicks(2588), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 70L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2087), new DateTime(2020, 9, 24, 3, 19, 57, 81, DateTimeKind.Local).AddTicks(5410), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 71L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2139), new DateTime(2021, 2, 16, 11, 52, 26, 465, DateTimeKind.Local).AddTicks(5688), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 72L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2190), new DateTime(2020, 10, 1, 21, 27, 3, 191, DateTimeKind.Local).AddTicks(3204), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 73L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2240), new DateTime(2020, 12, 1, 4, 47, 42, 918, DateTimeKind.Local).AddTicks(5770), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 74L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2293), new DateTime(2020, 5, 31, 0, 39, 41, 451, DateTimeKind.Local).AddTicks(6366), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 75L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2433), new DateTime(2020, 4, 5, 22, 15, 35, 679, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 76L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2490), new DateTime(2020, 7, 16, 0, 52, 6, 489, DateTimeKind.Local).AddTicks(7802), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 77L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3388), new DateTime(2021, 1, 10, 14, 12, 59, 940, DateTimeKind.Local).AddTicks(9329), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 78L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3468), new DateTime(2020, 12, 29, 7, 38, 51, 874, DateTimeKind.Local).AddTicks(291), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 79L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3522), new DateTime(2021, 1, 25, 21, 32, 46, 917, DateTimeKind.Local).AddTicks(1289), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 80L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3578), new DateTime(2020, 10, 23, 9, 24, 21, 962, DateTimeKind.Local).AddTicks(5810), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 81L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3633), new DateTime(2021, 1, 6, 23, 49, 34, 327, DateTimeKind.Local).AddTicks(9876), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 82L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3684), new DateTime(2020, 5, 29, 15, 2, 45, 377, DateTimeKind.Local).AddTicks(8816), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 83L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3735), new DateTime(2020, 11, 27, 8, 52, 0, 748, DateTimeKind.Local).AddTicks(2205), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 84L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(5593), new DateTime(2020, 7, 29, 12, 45, 58, 373, DateTimeKind.Local).AddTicks(6169), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 85L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7655), new DateTime(2020, 5, 9, 15, 15, 7, 457, DateTimeKind.Local).AddTicks(5337), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 86L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7751), new DateTime(2020, 9, 28, 15, 28, 54, 486, DateTimeKind.Local).AddTicks(2938), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 87L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7808), new DateTime(2020, 10, 6, 16, 2, 11, 310, DateTimeKind.Local).AddTicks(6739), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 88L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7860), new DateTime(2021, 1, 22, 7, 7, 57, 761, DateTimeKind.Local).AddTicks(884), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 89L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7917), new DateTime(2020, 11, 14, 18, 2, 50, 139, DateTimeKind.Local).AddTicks(9417), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 90L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7992), new DateTime(2020, 11, 28, 10, 15, 34, 21, DateTimeKind.Local).AddTicks(9190), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 91L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8049), new DateTime(2020, 6, 4, 22, 16, 52, 520, DateTimeKind.Local).AddTicks(4128), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 92L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8101), new DateTime(2021, 1, 25, 1, 36, 54, 724, DateTimeKind.Local).AddTicks(1621), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 93L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8164), new DateTime(2020, 7, 31, 10, 16, 45, 786, DateTimeKind.Local).AddTicks(9866), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 94L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8216), new DateTime(2021, 2, 16, 12, 29, 46, 765, DateTimeKind.Local).AddTicks(4322), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 95L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8466), new DateTime(2021, 1, 25, 4, 41, 40, 722, DateTimeKind.Local).AddTicks(2095), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 96L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8527), new DateTime(2020, 4, 25, 14, 21, 58, 145, DateTimeKind.Local).AddTicks(5312), new DateTime(2020, 3, 11, 14, 14, 58, 743, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 97L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(411), new DateTime(2021, 2, 9, 19, 35, 36, 610, DateTimeKind.Local).AddTicks(7423), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 98L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2292), new DateTime(2020, 8, 12, 17, 27, 23, 78, DateTimeKind.Local).AddTicks(8082), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 99L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2386), new DateTime(2020, 11, 23, 5, 43, 40, 309, DateTimeKind.Local).AddTicks(9922), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 100L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2466), new DateTime(2020, 10, 6, 12, 22, 0, 556, DateTimeKind.Local).AddTicks(1950), new DateTime(2020, 3, 11, 14, 14, 58, 744, DateTimeKind.Utc).AddTicks(2469) });
        }
    }
}
