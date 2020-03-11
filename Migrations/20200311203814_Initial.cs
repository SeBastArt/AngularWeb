using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "address_country",
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
                name: "WeatherForecast",
                columns: table => new
                {
                    WeatherForecastId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "address_person_relation",
                columns: table => new
                {
                    AddressId = table.Column<long>(nullable: false),
                    AddressPersonId = table.Column<long>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<long>(nullable: false),
                    modified_by = table.Column<long>(nullable: false),
                    info = table.Column<string>(type: "varchar(max)", nullable: true),
                    info_rtf = table.Column<string>(type: "varchar(max)", nullable: true),
                    AddressPersonRelationId = table.Column<long>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { 1L, "Yvette", "Marquardt", new byte[] { 134, 32, 157, 161, 4, 13, 133, 88, 2, 105, 6, 59, 4, 3, 58, 219, 55, 117, 85, 47, 87, 193, 167, 242, 64, 211, 24, 88, 131, 12, 76, 220, 126, 36, 235, 157, 146, 54, 253, 201, 230, 254, 65, 17, 172, 212, 225, 106, 78, 158, 188, 111, 2, 175, 125, 43, 130, 43, 92, 218, 151, 1, 70, 255 }, new byte[] { 188, 141, 27, 128, 15, 243, 43, 212, 187, 13, 148, 52, 13, 194, 49, 72, 91, 194, 203, 214, 142, 127, 47, 177, 114, 46, 50, 149, 244, 225, 56, 203, 244, 47, 134, 18, 71, 187, 36, 69, 87, 252, 96, 126, 46, 53, 208, 134, 217, 97, 171, 81, 229, 227, 192, 8, 227, 228, 81, 95, 11, 12, 197, 103, 251, 153, 250, 36, 179, 156, 72, 255, 181, 192, 197, 58, 226, 253, 195, 76, 118, 75, 113, 147, 65, 133, 181, 134, 4, 177, 16, 197, 155, 178, 32, 32, 241, 156, 73, 149, 191, 232, 24, 66, 96, 222, 200, 223, 20, 25, 78, 141, 29, 169, 223, 181, 38, 198, 31, 158, 145, 157, 212, 3, 151, 101, 22, 144 }, "Admin", "Nigel" },
                    { 2L, "Joelle", "Bergstrom", new byte[] { 134, 32, 157, 161, 4, 13, 133, 88, 2, 105, 6, 59, 4, 3, 58, 219, 55, 117, 85, 47, 87, 193, 167, 242, 64, 211, 24, 88, 131, 12, 76, 220, 126, 36, 235, 157, 146, 54, 253, 201, 230, 254, 65, 17, 172, 212, 225, 106, 78, 158, 188, 111, 2, 175, 125, 43, 130, 43, 92, 218, 151, 1, 70, 255 }, new byte[] { 188, 141, 27, 128, 15, 243, 43, 212, 187, 13, 148, 52, 13, 194, 49, 72, 91, 194, 203, 214, 142, 127, 47, 177, 114, 46, 50, 149, 244, 225, 56, 203, 244, 47, 134, 18, 71, 187, 36, 69, 87, 252, 96, 126, 46, 53, 208, 134, 217, 97, 171, 81, 229, 227, 192, 8, 227, 228, 81, 95, 11, 12, 197, 103, 251, 153, 250, 36, 179, 156, 72, 255, 181, 192, 197, 58, 226, 253, 195, 76, 118, 75, 113, 147, 65, 133, 181, 134, 4, 177, 16, 197, 155, 178, 32, 32, 241, 156, 73, 149, 191, 232, 24, 66, 96, 222, 200, 223, 20, 25, 78, 141, 29, 169, 223, 181, 38, 198, 31, 158, 145, 157, 212, 3, 151, 101, 22, 144 }, "Admin", "Travis" },
                    { 3L, "Madisyn", "McCullough", new byte[] { 134, 32, 157, 161, 4, 13, 133, 88, 2, 105, 6, 59, 4, 3, 58, 219, 55, 117, 85, 47, 87, 193, 167, 242, 64, 211, 24, 88, 131, 12, 76, 220, 126, 36, 235, 157, 146, 54, 253, 201, 230, 254, 65, 17, 172, 212, 225, 106, 78, 158, 188, 111, 2, 175, 125, 43, 130, 43, 92, 218, 151, 1, 70, 255 }, new byte[] { 188, 141, 27, 128, 15, 243, 43, 212, 187, 13, 148, 52, 13, 194, 49, 72, 91, 194, 203, 214, 142, 127, 47, 177, 114, 46, 50, 149, 244, 225, 56, 203, 244, 47, 134, 18, 71, 187, 36, 69, 87, 252, 96, 126, 46, 53, 208, 134, 217, 97, 171, 81, 229, 227, 192, 8, 227, 228, 81, 95, 11, 12, 197, 103, 251, 153, 250, 36, 179, 156, 72, 255, 181, 192, 197, 58, 226, 253, 195, 76, 118, 75, 113, 147, 65, 133, 181, 134, 4, 177, 16, 197, 155, 178, 32, 32, 241, 156, 73, 149, 191, 232, 24, 66, 96, 222, 200, 223, 20, 25, 78, 141, 29, 169, 223, 181, 38, 198, 31, 158, 145, 157, 212, 3, 151, 101, 22, 144 }, "Admin", "Coralie" },
                    { 4L, "Donna", "Leannon", new byte[] { 134, 32, 157, 161, 4, 13, 133, 88, 2, 105, 6, 59, 4, 3, 58, 219, 55, 117, 85, 47, 87, 193, 167, 242, 64, 211, 24, 88, 131, 12, 76, 220, 126, 36, 235, 157, 146, 54, 253, 201, 230, 254, 65, 17, 172, 212, 225, 106, 78, 158, 188, 111, 2, 175, 125, 43, 130, 43, 92, 218, 151, 1, 70, 255 }, new byte[] { 188, 141, 27, 128, 15, 243, 43, 212, 187, 13, 148, 52, 13, 194, 49, 72, 91, 194, 203, 214, 142, 127, 47, 177, 114, 46, 50, 149, 244, 225, 56, 203, 244, 47, 134, 18, 71, 187, 36, 69, 87, 252, 96, 126, 46, 53, 208, 134, 217, 97, 171, 81, 229, 227, 192, 8, 227, 228, 81, 95, 11, 12, 197, 103, 251, 153, 250, 36, 179, 156, 72, 255, 181, 192, 197, 58, 226, 253, 195, 76, 118, 75, 113, 147, 65, 133, 181, 134, 4, 177, 16, 197, 155, 178, 32, 32, 241, 156, 73, 149, 191, 232, 24, 66, 96, 222, 200, 223, 20, 25, 78, 141, 29, 169, 223, 181, 38, 198, 31, 158, 145, 157, 212, 3, 151, 101, 22, 144 }, "Admin", "Yesenia" },
                    { 5L, "Sebastian", "Schüler", new byte[] { 134, 32, 157, 161, 4, 13, 133, 88, 2, 105, 6, 59, 4, 3, 58, 219, 55, 117, 85, 47, 87, 193, 167, 242, 64, 211, 24, 88, 131, 12, 76, 220, 126, 36, 235, 157, 146, 54, 253, 201, 230, 254, 65, 17, 172, 212, 225, 106, 78, 158, 188, 111, 2, 175, 125, 43, 130, 43, 92, 218, 151, 1, 70, 255 }, new byte[] { 188, 141, 27, 128, 15, 243, 43, 212, 187, 13, 148, 52, 13, 194, 49, 72, 91, 194, 203, 214, 142, 127, 47, 177, 114, 46, 50, 149, 244, 225, 56, 203, 244, 47, 134, 18, 71, 187, 36, 69, 87, 252, 96, 126, 46, 53, 208, 134, 217, 97, 171, 81, 229, 227, 192, 8, 227, 228, 81, 95, 11, 12, 197, 103, 251, 153, 250, 36, 179, 156, 72, 255, 181, 192, 197, 58, 226, 253, 195, 76, 118, 75, 113, 147, 65, 133, 181, 134, 4, 177, 16, 197, 155, 178, 32, 32, 241, 156, 73, 149, 191, 232, 24, 66, 96, 222, 200, 223, 20, 25, 78, 141, 29, 169, 223, 181, 38, 198, 31, 158, 145, 157, 212, 3, 151, 101, 22, 144 }, "Admin", "user" }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "WeatherForecastId", "created", "created_by", "Date", "info", "info_rtf", "modified", "modified_by", "summar_y", "TemperatureC", "UserId" },
                values: new object[,]
                {
                    { 3L, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(548), 1L, new DateTime(2020, 7, 31, 0, 23, 10, 919, DateTimeKind.Local).AddTicks(916), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(554), 5L, "orchid", 5, 1L },
                    { 69L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3932), 2L, new DateTime(2021, 1, 7, 22, 4, 20, 195, DateTimeKind.Local).AddTicks(4514), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3935), 3L, "Corporate", -14, 4L },
                    { 64L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3624), 2L, new DateTime(2020, 6, 30, 11, 16, 8, 788, DateTimeKind.Local).AddTicks(4477), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3627), 2L, "input", 1, 4L },
                    { 62L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3547), 2L, new DateTime(2020, 8, 23, 0, 40, 23, 750, DateTimeKind.Local).AddTicks(3822), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3549), 2L, "cultivate", -12, 4L },
                    { 59L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3431), 1L, new DateTime(2020, 10, 2, 23, 24, 56, 607, DateTimeKind.Local).AddTicks(6739), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3433), 1L, "scale", -15, 4L },
                    { 54L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3222), 2L, new DateTime(2020, 5, 24, 22, 51, 34, 650, DateTimeKind.Local).AddTicks(1745), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3225), 5L, "Internal", 11, 4L },
                    { 41L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9232), 2L, new DateTime(2021, 1, 7, 6, 19, 48, 315, DateTimeKind.Local).AddTicks(8625), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9236), 4L, "Metal", -1, 4L },
                    { 39L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8541), 4L, new DateTime(2021, 2, 21, 19, 20, 28, 585, DateTimeKind.Local).AddTicks(1891), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8544), 4L, "calculating", 9, 4L },
                    { 36L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8396), 1L, new DateTime(2020, 10, 8, 4, 4, 33, 296, DateTimeKind.Local).AddTicks(5063), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8398), 1L, "Mobility", 4, 4L },
                    { 24L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(3958), 2L, new DateTime(2020, 9, 28, 4, 6, 29, 5, DateTimeKind.Local).AddTicks(9535), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(3962), 3L, "backing up", -13, 4L },
                    { 17L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(5072), 4L, new DateTime(2020, 4, 18, 17, 25, 0, 375, DateTimeKind.Local).AddTicks(1092), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(5075), 5L, "open-source", -9, 4L },
                    { 16L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(5006), 3L, new DateTime(2020, 12, 7, 3, 26, 11, 987, DateTimeKind.Local).AddTicks(1878), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(5010), 4L, "Planner", 14, 4L },
                    { 15L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3585), 1L, new DateTime(2020, 4, 8, 8, 41, 3, 808, DateTimeKind.Local).AddTicks(5856), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3588), 1L, "national", -9, 4L },
                    { 1L, new DateTime(2020, 3, 11, 20, 38, 13, 833, DateTimeKind.Utc).AddTicks(8393), 4L, new DateTime(2020, 12, 22, 13, 49, 27, 328, DateTimeKind.Local).AddTicks(1259), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 834, DateTimeKind.Utc).AddTicks(552), 4L, "Danish Krone", 15, 4L },
                    { 97L, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(448), 5L, new DateTime(2021, 2, 10, 1, 58, 51, 706, DateTimeKind.Local).AddTicks(7470), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(451), 4L, "Cayman Islands", 13, 3L },
                    { 95L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(9001), 5L, new DateTime(2021, 1, 25, 11, 4, 55, 818, DateTimeKind.Local).AddTicks(2639), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(9003), 4L, "web-enabled", -12, 3L },
                    { 94L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8961), 1L, new DateTime(2021, 2, 16, 18, 53, 1, 861, DateTimeKind.Local).AddTicks(5071), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8963), 4L, "Centralized", 11, 3L },
                    { 89L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8735), 1L, new DateTime(2020, 11, 15, 0, 26, 5, 236, DateTimeKind.Local).AddTicks(238), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8738), 5L, "District", -13, 3L },
                    { 87L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8647), 4L, new DateTime(2020, 10, 6, 22, 25, 26, 406, DateTimeKind.Local).AddTicks(7580), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8650), 5L, "world-class", 15, 3L },
                    { 83L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5116), 1L, new DateTime(2020, 11, 27, 15, 15, 15, 844, DateTimeKind.Local).AddTicks(3590), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5118), 1L, "open-source", 12, 3L },
                    { 78L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4921), 5L, new DateTime(2020, 12, 29, 14, 2, 6, 970, DateTimeKind.Local).AddTicks(1746), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4923), 1L, "wireless", -14, 3L },
                    { 77L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4862), 1L, new DateTime(2021, 1, 10, 20, 36, 15, 37, DateTimeKind.Local).AddTicks(816), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4865), 2L, "Square", 7, 3L },
                    { 71L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4027), 2L, new DateTime(2021, 2, 16, 18, 15, 41, 561, DateTimeKind.Local).AddTicks(7581), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4029), 4L, "connecting", 4, 4L },
                    { 73L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4101), 1L, new DateTime(2020, 12, 1, 11, 10, 58, 14, DateTimeKind.Local).AddTicks(7635), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4104), 5L, "scale", 6, 3L },
                    { 72L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4064), 5L, new DateTime(2020, 10, 2, 3, 50, 18, 287, DateTimeKind.Local).AddTicks(5082), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4067), 5L, "Gorgeous", -2, 4L },
                    { 76L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4217), 1L, new DateTime(2020, 7, 16, 7, 15, 21, 585, DateTimeKind.Local).AddTicks(9533), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4219), 4L, "Officer", 7, 4L },
                    { 96L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(9040), 1L, new DateTime(2020, 4, 25, 20, 45, 13, 241, DateTimeKind.Local).AddTicks(5829), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(9043), 4L, "Credit Card Account", -12, 5L },
                    { 81L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5041), 1L, new DateTime(2021, 1, 7, 6, 12, 49, 424, DateTimeKind.Local).AddTicks(1288), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5044), 5L, "Maine", -3, 5L },
                    { 66L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3813), 1L, new DateTime(2020, 8, 28, 2, 57, 23, 567, DateTimeKind.Local).AddTicks(4250), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3816), 5L, "Lead", 4, 5L },
                    { 65L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3700), 5L, new DateTime(2020, 6, 11, 12, 53, 1, 779, DateTimeKind.Local).AddTicks(9814), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3770), 4L, "Movies & Clothing", -3, 5L },
                    { 63L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3586), 1L, new DateTime(2020, 7, 21, 12, 11, 28, 182, DateTimeKind.Local).AddTicks(7522), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3588), 4L, "Advanced", 14, 5L },
                    { 55L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3273), 2L, new DateTime(2020, 3, 18, 16, 1, 30, 631, DateTimeKind.Local).AddTicks(4992), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3276), 4L, "Guarani", -6, 5L },
                    { 52L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3146), 2L, new DateTime(2020, 9, 5, 19, 37, 29, 157, DateTimeKind.Local).AddTicks(7850), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3148), 4L, "Brand", 0, 5L },
                    { 44L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9647), 3L, new DateTime(2020, 5, 6, 11, 6, 3, 398, DateTimeKind.Local).AddTicks(8569), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9650), 5L, "Tunisian Dinar", -3, 5L },
                    { 42L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9513), 5L, new DateTime(2020, 7, 17, 10, 59, 12, 927, DateTimeKind.Local).AddTicks(5627), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9516), 5L, "Baby, Beauty & Games", -4, 5L },
                    { 40L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8583), 5L, new DateTime(2020, 8, 11, 21, 11, 0, 670, DateTimeKind.Local).AddTicks(443), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8585), 2L, "auxiliary", -10, 5L },
                    { 33L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8238), 5L, new DateTime(2020, 3, 24, 9, 38, 22, 686, DateTimeKind.Local).AddTicks(3887), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8241), 5L, "Principal", 3, 5L },
                    { 28L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4187), 3L, new DateTime(2020, 8, 23, 22, 8, 40, 197, DateTimeKind.Local).AddTicks(4520), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4189), 1L, "Self-enabling", 10, 5L },
                    { 26L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4100), 3L, new DateTime(2020, 5, 22, 14, 5, 59, 168, DateTimeKind.Local).AddTicks(746), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4102), 5L, "Practical Metal Hat", -12, 5L },
                    { 22L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(671), 2L, new DateTime(2021, 1, 2, 1, 37, 52, 836, DateTimeKind.Local).AddTicks(8454), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(674), 4L, "Technician", 3, 5L },
                    { 20L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(8858), 2L, new DateTime(2020, 11, 29, 23, 25, 35, 319, DateTimeKind.Local).AddTicks(3004), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(8863), 4L, "Kids, Electronics & Movies", 5, 5L },
                    { 11L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(1201), 1L, new DateTime(2020, 3, 12, 11, 52, 6, 474, DateTimeKind.Local).AddTicks(7612), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(1207), 1L, "Handmade Plastic Towels", -7, 5L },
                    { 5L, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(4061), 2L, new DateTime(2021, 2, 20, 17, 30, 18, 231, DateTimeKind.Local).AddTicks(281), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(4066), 3L, "sexy", -14, 5L },
                    { 93L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8921), 3L, new DateTime(2020, 7, 31, 16, 40, 0, 883, DateTimeKind.Local).AddTicks(626), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8924), 3L, "Latvian Lats", -6, 4L },
                    { 88L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8690), 5L, new DateTime(2021, 1, 22, 13, 31, 12, 857, DateTimeKind.Local).AddTicks(1717), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8693), 2L, "Triple-buffered", 10, 4L },
                    { 86L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8603), 1L, new DateTime(2020, 9, 28, 21, 52, 9, 582, DateTimeKind.Local).AddTicks(3792), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8605), 5L, "Walks", 8, 4L },
                    { 82L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5078), 3L, new DateTime(2020, 5, 29, 21, 26, 0, 474, DateTimeKind.Local).AddTicks(214), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5080), 2L, "AI", 8, 4L },
                    { 74L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4140), 5L, new DateTime(2020, 5, 31, 7, 2, 56, 547, DateTimeKind.Local).AddTicks(8218), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4143), 5L, "olive", 4, 4L },
                    { 68L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3894), 1L, new DateTime(2020, 9, 29, 21, 48, 38, 603, DateTimeKind.Local).AddTicks(4915), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3897), 5L, "real-time", 2, 3L },
                    { 61L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3509), 3L, new DateTime(2020, 7, 21, 23, 33, 5, 480, DateTimeKind.Local).AddTicks(3471), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3511), 2L, "SMS", -14, 3L },
                    { 58L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3391), 3L, new DateTime(2021, 3, 11, 19, 40, 15, 51, DateTimeKind.Local).AddTicks(1363), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3393), 4L, "index", 14, 3L },
                    { 27L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4143), 2L, new DateTime(2020, 7, 7, 23, 41, 57, 32, DateTimeKind.Local).AddTicks(4719), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4145), 3L, "1080p", 10, 2L },
                    { 14L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3468), 3L, new DateTime(2021, 2, 23, 6, 24, 40, 760, DateTimeKind.Local).AddTicks(1371), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3471), 3L, "Customer-focused", -8, 2L },
                    { 12L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3339), 2L, new DateTime(2020, 3, 26, 19, 3, 27, 371, DateTimeKind.Local).AddTicks(996), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3344), 1L, "Assurance", 10, 2L },
                    { 10L, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(7676), 4L, new DateTime(2020, 5, 19, 17, 44, 3, 857, DateTimeKind.Local).AddTicks(5232), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(7681), 5L, "hard drive", 15, 2L },
                    { 7L, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(7066), 4L, new DateTime(2020, 4, 13, 9, 41, 34, 943, DateTimeKind.Local).AddTicks(1418), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(7071), 3L, "Fully-configurable", -3, 2L },
                    { 4L, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(2043), 3L, new DateTime(2020, 5, 31, 16, 34, 0, 877, DateTimeKind.Local).AddTicks(7898), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(2048), 1L, "Practical", -3, 2L },
                    { 100L, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1968), 1L, new DateTime(2020, 10, 6, 18, 45, 15, 652, DateTimeKind.Local).AddTicks(1455), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1971), 5L, "Tasty Rubber Keyboard", 0, 1L },
                    { 92L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8873), 1L, new DateTime(2021, 1, 25, 8, 0, 9, 820, DateTimeKind.Local).AddTicks(2397), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8875), 2L, "parse", 10, 1L },
                    { 91L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8835), 1L, new DateTime(2020, 6, 5, 4, 40, 7, 616, DateTimeKind.Local).AddTicks(4917), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8837), 5L, "driver", -10, 1L },
                    { 90L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8795), 2L, new DateTime(2020, 11, 28, 16, 38, 49, 117, DateTimeKind.Local).AddTicks(9996), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8797), 2L, "Small Cotton Keyboard", 2, 1L },
                    { 84L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(6881), 4L, new DateTime(2020, 7, 29, 19, 9, 13, 469, DateTimeKind.Local).AddTicks(7459), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(6886), 5L, "Berkshire", -11, 1L },
                    { 75L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4179), 3L, new DateTime(2020, 4, 6, 4, 38, 50, 775, DateTimeKind.Local).AddTicks(7669), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4181), 1L, "Pre-emptive", -3, 1L },
                    { 60L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3470), 5L, new DateTime(2021, 2, 16, 19, 22, 28, 301, DateTimeKind.Local).AddTicks(5888), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3473), 2L, "supply-chains", -8, 1L },
                    { 57L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3352), 3L, new DateTime(2020, 6, 19, 7, 16, 30, 58, DateTimeKind.Local).AddTicks(1971), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3355), 3L, "online", 4, 1L },
                    { 56L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3312), 5L, new DateTime(2020, 6, 30, 14, 41, 10, 36, DateTimeKind.Local).AddTicks(7267), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3315), 3L, "Central", 8, 1L },
                    { 51L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3106), 1L, new DateTime(2021, 2, 21, 3, 32, 24, 785, DateTimeKind.Local).AddTicks(9322), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3109), 5L, "Implementation", 0, 1L },
                    { 49L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(2995), 3L, new DateTime(2021, 2, 27, 12, 40, 15, 78, DateTimeKind.Local).AddTicks(925), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(2999), 2L, "Trafficway", 15, 1L },
                    { 37L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8438), 2L, new DateTime(2020, 10, 11, 15, 4, 49, 32, DateTimeKind.Local).AddTicks(9286), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8441), 3L, "cyan", -4, 1L },
                    { 30L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(5962), 5L, new DateTime(2020, 4, 12, 19, 26, 27, 752, DateTimeKind.Local).AddTicks(1643), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(5965), 1L, "connecting", -8, 1L },
                    { 29L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(5893), 3L, new DateTime(2020, 7, 15, 1, 34, 47, 993, DateTimeKind.Local).AddTicks(5481), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(5898), 3L, "Credit Card Account", 0, 1L },
                    { 25L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4030), 4L, new DateTime(2020, 10, 10, 3, 21, 31, 807, DateTimeKind.Local).AddTicks(9985), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(4033), 3L, "Delaware", -1, 1L },
                    { 31L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(6108), 4L, new DateTime(2021, 2, 2, 4, 29, 15, 104, DateTimeKind.Local).AddTicks(4143), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(6111), 1L, "Incredible Wooden Shoes", -8, 2L },
                    { 32L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(6802), 2L, new DateTime(2020, 7, 17, 1, 6, 48, 361, DateTimeKind.Local).AddTicks(2683), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(6806), 4L, "Rustic Steel Pants", 13, 2L },
                    { 34L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8306), 2L, new DateTime(2021, 2, 25, 11, 12, 46, 3, DateTimeKind.Local).AddTicks(4592), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8309), 2L, "e-markets", -11, 2L },
                    { 38L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8499), 3L, new DateTime(2020, 7, 12, 8, 19, 44, 490, DateTimeKind.Local).AddTicks(1196), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8502), 4L, "Intelligent Concrete Shoes", 14, 2L },
                    { 53L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3184), 3L, new DateTime(2020, 3, 19, 8, 6, 11, 784, DateTimeKind.Local).AddTicks(727), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3186), 5L, "Identity", -14, 3L },
                    { 50L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3062), 5L, new DateTime(2020, 8, 18, 17, 12, 46, 25, DateTimeKind.Local).AddTicks(673), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3065), 2L, "Direct", 3, 3L },
                    { 48L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1406), 1L, new DateTime(2020, 8, 21, 17, 56, 28, 187, DateTimeKind.Local).AddTicks(6667), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1409), 5L, "Brazilian Real", -6, 3L },
                    { 47L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1351), 4L, new DateTime(2020, 4, 15, 6, 5, 51, 97, DateTimeKind.Local).AddTicks(8852), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1354), 4L, "fuchsia", -3, 3L },
                    { 45L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1148), 3L, new DateTime(2021, 1, 6, 7, 1, 25, 440, DateTimeKind.Local).AddTicks(5916), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1152), 2L, "bypass", 14, 3L },
                    { 35L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8350), 2L, new DateTime(2020, 5, 13, 22, 31, 32, 781, DateTimeKind.Local).AddTicks(2106), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(8353), 2L, "efficient", -1, 3L },
                    { 23L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(2344), 3L, new DateTime(2021, 2, 5, 8, 10, 25, 663, DateTimeKind.Local).AddTicks(6852), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(2348), 1L, "COM", -8, 3L },
                    { 21L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(589), 5L, new DateTime(2020, 3, 26, 2, 1, 15, 574, DateTimeKind.Local).AddTicks(5094), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(595), 5L, "reinvent", 12, 3L },
                    { 19L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(6656), 3L, new DateTime(2020, 10, 12, 12, 13, 10, 597, DateTimeKind.Local).AddTicks(6832), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(6659), 4L, "paradigms", -14, 3L },
                    { 18L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(6587), 2L, new DateTime(2020, 8, 17, 0, 22, 23, 440, DateTimeKind.Local).AddTicks(4007), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(6591), 3L, "niches", -4, 3L },
                    { 98L, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1832), 4L, new DateTime(2020, 8, 12, 23, 50, 38, 174, DateTimeKind.Local).AddTicks(7636), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1838), 2L, "withdrawal", 8, 5L },
                    { 13L, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3418), 4L, new DateTime(2020, 7, 15, 19, 9, 39, 735, DateTimeKind.Local).AddTicks(7371), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 837, DateTimeKind.Utc).AddTicks(3420), 5L, "mobile", 6, 3L },
                    { 8L, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(3667), 3L, new DateTime(2020, 6, 8, 20, 0, 30, 902, DateTimeKind.Local).AddTicks(6399), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(3673), 3L, "Jewelery", -15, 3L },
                    { 6L, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(5568), 4L, new DateTime(2020, 7, 4, 22, 40, 48, 979, DateTimeKind.Local).AddTicks(7412), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 835, DateTimeKind.Utc).AddTicks(5572), 3L, "even-keeled", 14, 3L },
                    { 2L, new DateTime(2020, 3, 11, 20, 38, 13, 834, DateTimeKind.Utc).AddTicks(8374), 3L, new DateTime(2020, 11, 14, 20, 11, 8, 164, DateTimeKind.Local).AddTicks(6749), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 834, DateTimeKind.Utc).AddTicks(8423), 5L, "haptic", -6, 3L },
                    { 85L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8526), 2L, new DateTime(2020, 5, 9, 21, 38, 22, 553, DateTimeKind.Local).AddTicks(6220), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(8531), 4L, "conglomeration", 10, 2L },
                    { 80L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5002), 4L, new DateTime(2020, 10, 23, 15, 47, 37, 58, DateTimeKind.Local).AddTicks(7237), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(5004), 5L, "Investment Account", 12, 2L },
                    { 79L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4960), 5L, new DateTime(2021, 1, 26, 3, 56, 2, 13, DateTimeKind.Local).AddTicks(2732), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(4963), 1L, "SMS", 4, 2L },
                    { 70L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3989), 3L, new DateTime(2020, 9, 24, 9, 43, 12, 177, DateTimeKind.Local).AddTicks(7316), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3992), 5L, "Small Cotton Car", -4, 2L },
                    { 67L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3855), 1L, new DateTime(2021, 1, 16, 9, 14, 55, 595, DateTimeKind.Local).AddTicks(7711), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(3857), 3L, "Agent", -12, 2L },
                    { 46L, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1215), 1L, new DateTime(2020, 12, 31, 12, 11, 0, 15, DateTimeKind.Local).AddTicks(555), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 839, DateTimeKind.Utc).AddTicks(1303), 3L, "networks", 13, 2L },
                    { 43L, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9586), 2L, new DateTime(2020, 3, 19, 13, 27, 17, 393, DateTimeKind.Local).AddTicks(9696), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 838, DateTimeKind.Utc).AddTicks(9589), 4L, "Incredible Frozen Cheese", 15, 2L },
                    { 9L, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(6063), 2L, new DateTime(2020, 5, 11, 21, 58, 31, 960, DateTimeKind.Local).AddTicks(6731), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 836, DateTimeKind.Utc).AddTicks(6068), 3L, "Mississippi", 8, 3L },
                    { 99L, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1906), 2L, new DateTime(2020, 11, 23, 12, 6, 55, 405, DateTimeKind.Local).AddTicks(9445), null, null, new DateTime(2020, 3, 11, 20, 38, 13, 840, DateTimeKind.Utc).AddTicks(1909), 4L, "Response", 0, 5L }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_address_person_PictureId",
                table: "address_person",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_address_person_relation_AddressPersonId",
                table: "address_person_relation",
                column: "AddressPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_UserId",
                table: "WeatherForecast",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_person_relation");

            migrationBuilder.DropTable(
                name: "Audit_WeatherForecast");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "address_address");

            migrationBuilder.DropTable(
                name: "address_person");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "address_company_type");

            migrationBuilder.DropTable(
                name: "address_country");

            migrationBuilder.DropTable(
                name: "fagBinarys");
        }
    }
}
