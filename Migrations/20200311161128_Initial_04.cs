using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularWeb.Migrations
{
    public partial class Initial_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AddressPersonRelationId",
                table: "address_person_relation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "created",
                table: "address_person_relation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "created_by",
                table: "address_person_relation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "info",
                table: "address_person_relation",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "info_rtf",
                table: "address_person_relation",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modified",
                table: "address_person_relation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "modified_by",
                table: "address_person_relation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 127, 70, 143, 47, 41, 252, 246, 241, 29, 244, 33, 27, 222, 141, 107, 56, 229, 15, 227, 69, 209, 210, 213, 223, 207, 186, 105, 173, 233, 157, 38, 51, 178, 215, 234, 12, 149, 114, 219, 90, 214, 176, 121, 144, 175, 16, 197, 131, 199, 190, 226, 197, 250, 139, 182, 153, 185, 141, 63, 129, 128, 164, 207 }, new byte[] { 22, 75, 71, 84, 177, 46, 81, 54, 177, 149, 169, 221, 109, 14, 205, 245, 2, 84, 48, 19, 43, 255, 8, 193, 78, 255, 77, 252, 90, 172, 119, 31, 15, 98, 215, 94, 34, 210, 27, 212, 255, 134, 178, 70, 25, 255, 169, 152, 232, 224, 91, 240, 204, 193, 211, 187, 119, 66, 43, 182, 204, 255, 124, 223, 167, 203, 213, 235, 241, 216, 16, 216, 177, 52, 110, 138, 220, 87, 222, 156, 115, 66, 157, 134, 238, 175, 125, 237, 161, 216, 195, 99, 92, 151, 74, 75, 20, 232, 158, 246, 212, 223, 200, 70, 249, 210, 225, 42, 249, 217, 43, 49, 204, 48, 255, 255, 206, 149, 221, 194, 117, 20, 205, 15, 237, 42, 174, 36 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 127, 70, 143, 47, 41, 252, 246, 241, 29, 244, 33, 27, 222, 141, 107, 56, 229, 15, 227, 69, 209, 210, 213, 223, 207, 186, 105, 173, 233, 157, 38, 51, 178, 215, 234, 12, 149, 114, 219, 90, 214, 176, 121, 144, 175, 16, 197, 131, 199, 190, 226, 197, 250, 139, 182, 153, 185, 141, 63, 129, 128, 164, 207 }, new byte[] { 22, 75, 71, 84, 177, 46, 81, 54, 177, 149, 169, 221, 109, 14, 205, 245, 2, 84, 48, 19, 43, 255, 8, 193, 78, 255, 77, 252, 90, 172, 119, 31, 15, 98, 215, 94, 34, 210, 27, 212, 255, 134, 178, 70, 25, 255, 169, 152, 232, 224, 91, 240, 204, 193, 211, 187, 119, 66, 43, 182, 204, 255, 124, 223, 167, 203, 213, 235, 241, 216, 16, 216, 177, 52, 110, 138, 220, 87, 222, 156, 115, 66, 157, 134, 238, 175, 125, 237, 161, 216, 195, 99, 92, 151, 74, 75, 20, 232, 158, 246, 212, 223, 200, 70, 249, 210, 225, 42, 249, 217, 43, 49, 204, 48, 255, 255, 206, 149, 221, 194, 117, 20, 205, 15, 237, 42, 174, 36 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 127, 70, 143, 47, 41, 252, 246, 241, 29, 244, 33, 27, 222, 141, 107, 56, 229, 15, 227, 69, 209, 210, 213, 223, 207, 186, 105, 173, 233, 157, 38, 51, 178, 215, 234, 12, 149, 114, 219, 90, 214, 176, 121, 144, 175, 16, 197, 131, 199, 190, 226, 197, 250, 139, 182, 153, 185, 141, 63, 129, 128, 164, 207 }, new byte[] { 22, 75, 71, 84, 177, 46, 81, 54, 177, 149, 169, 221, 109, 14, 205, 245, 2, 84, 48, 19, 43, 255, 8, 193, 78, 255, 77, 252, 90, 172, 119, 31, 15, 98, 215, 94, 34, 210, 27, 212, 255, 134, 178, 70, 25, 255, 169, 152, 232, 224, 91, 240, 204, 193, 211, 187, 119, 66, 43, 182, 204, 255, 124, 223, 167, 203, 213, 235, 241, 216, 16, 216, 177, 52, 110, 138, 220, 87, 222, 156, 115, 66, 157, 134, 238, 175, 125, 237, 161, 216, 195, 99, 92, 151, 74, 75, 20, 232, 158, 246, 212, 223, 200, 70, 249, 210, 225, 42, 249, 217, 43, 49, 204, 48, 255, 255, 206, 149, 221, 194, 117, 20, 205, 15, 237, 42, 174, 36 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 127, 70, 143, 47, 41, 252, 246, 241, 29, 244, 33, 27, 222, 141, 107, 56, 229, 15, 227, 69, 209, 210, 213, 223, 207, 186, 105, 173, 233, 157, 38, 51, 178, 215, 234, 12, 149, 114, 219, 90, 214, 176, 121, 144, 175, 16, 197, 131, 199, 190, 226, 197, 250, 139, 182, 153, 185, 141, 63, 129, 128, 164, 207 }, new byte[] { 22, 75, 71, 84, 177, 46, 81, 54, 177, 149, 169, 221, 109, 14, 205, 245, 2, 84, 48, 19, 43, 255, 8, 193, 78, 255, 77, 252, 90, 172, 119, 31, 15, 98, 215, 94, 34, 210, 27, 212, 255, 134, 178, 70, 25, 255, 169, 152, 232, 224, 91, 240, 204, 193, 211, 187, 119, 66, 43, 182, 204, 255, 124, 223, 167, 203, 213, 235, 241, 216, 16, 216, 177, 52, 110, 138, 220, 87, 222, 156, 115, 66, 157, 134, 238, 175, 125, 237, 161, 216, 195, 99, 92, 151, 74, 75, 20, 232, 158, 246, 212, 223, 200, 70, 249, 210, 225, 42, 249, 217, 43, 49, 204, 48, 255, 255, 206, 149, 221, 194, 117, 20, 205, 15, 237, 42, 174, 36 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 127, 70, 143, 47, 41, 252, 246, 241, 29, 244, 33, 27, 222, 141, 107, 56, 229, 15, 227, 69, 209, 210, 213, 223, 207, 186, 105, 173, 233, 157, 38, 51, 178, 215, 234, 12, 149, 114, 219, 90, 214, 176, 121, 144, 175, 16, 197, 131, 199, 190, 226, 197, 250, 139, 182, 153, 185, 141, 63, 129, 128, 164, 207 }, new byte[] { 22, 75, 71, 84, 177, 46, 81, 54, 177, 149, 169, 221, 109, 14, 205, 245, 2, 84, 48, 19, 43, 255, 8, 193, 78, 255, 77, 252, 90, 172, 119, 31, 15, 98, 215, 94, 34, 210, 27, 212, 255, 134, 178, 70, 25, 255, 169, 152, 232, 224, 91, 240, 204, 193, 211, 187, 119, 66, 43, 182, 204, 255, 124, 223, 167, 203, 213, 235, 241, 216, 16, 216, 177, 52, 110, 138, 220, 87, 222, 156, 115, 66, 157, 134, 238, 175, 125, 237, 161, 216, 195, 99, 92, 151, 74, 75, 20, 232, 158, 246, 212, 223, 200, 70, 249, 210, 225, 42, 249, 217, 43, 49, 204, 48, 255, 255, 206, 149, 221, 194, 117, 20, 205, 15, 237, 42, 174, 36 } });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 987, DateTimeKind.Utc).AddTicks(1936), new DateTime(2020, 12, 22, 9, 22, 41, 480, DateTimeKind.Local).AddTicks(3297), new DateTime(2020, 3, 11, 16, 11, 27, 987, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 988, DateTimeKind.Utc).AddTicks(6004), new DateTime(2020, 11, 14, 15, 44, 22, 318, DateTimeKind.Local).AddTicks(4313), new DateTime(2020, 3, 11, 16, 11, 27, 988, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 988, DateTimeKind.Utc).AddTicks(9229), new DateTime(2020, 7, 30, 19, 56, 25, 72, DateTimeKind.Local).AddTicks(9577), new DateTime(2020, 3, 11, 16, 11, 27, 988, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(1835), new DateTime(2020, 5, 31, 12, 7, 15, 31, DateTimeKind.Local).AddTicks(7657), new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(5137), new DateTime(2021, 2, 20, 13, 3, 32, 385, DateTimeKind.Local).AddTicks(1345), new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(6896), new DateTime(2020, 7, 4, 18, 14, 3, 133, DateTimeKind.Local).AddTicks(8730), new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(8596), new DateTime(2020, 4, 13, 5, 14, 49, 97, DateTimeKind.Local).AddTicks(2942), new DateTime(2020, 3, 11, 16, 11, 27, 989, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 990, DateTimeKind.Utc).AddTicks(5611), new DateTime(2020, 6, 8, 15, 33, 45, 56, DateTimeKind.Local).AddTicks(8339), new DateTime(2020, 3, 11, 16, 11, 27, 990, DateTimeKind.Utc).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 990, DateTimeKind.Utc).AddTicks(8104), new DateTime(2020, 5, 11, 17, 31, 46, 114, DateTimeKind.Local).AddTicks(8772), new DateTime(2020, 3, 11, 16, 11, 27, 990, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(185), new DateTime(2020, 5, 19, 13, 17, 18, 11, DateTimeKind.Local).AddTicks(7734), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 11L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(4126), new DateTime(2020, 3, 12, 7, 25, 20, 629, DateTimeKind.Local).AddTicks(530), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 12L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6368), new DateTime(2020, 3, 26, 14, 36, 41, 525, DateTimeKind.Local).AddTicks(4025), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 13L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6452), new DateTime(2020, 7, 15, 14, 42, 53, 890, DateTimeKind.Local).AddTicks(406), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 14L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6503), new DateTime(2021, 2, 23, 1, 57, 54, 914, DateTimeKind.Local).AddTicks(4403), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 15L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6633), new DateTime(2020, 4, 8, 4, 14, 17, 962, DateTimeKind.Local).AddTicks(8867), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 16L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(8933), new DateTime(2020, 12, 6, 22, 59, 26, 141, DateTimeKind.Local).AddTicks(5780), new DateTime(2020, 3, 11, 16, 11, 27, 991, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 17L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(795), new DateTime(2020, 4, 18, 12, 58, 14, 529, DateTimeKind.Local).AddTicks(6745), new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 18L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(4816), new DateTime(2020, 8, 16, 19, 55, 37, 595, DateTimeKind.Local).AddTicks(2206), new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 19L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(4948), new DateTime(2020, 10, 12, 7, 46, 24, 752, DateTimeKind.Local).AddTicks(5111), new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 20L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(9648), new DateTime(2020, 11, 29, 18, 58, 49, 474, DateTimeKind.Local).AddTicks(3751), new DateTime(2020, 3, 11, 16, 11, 27, 992, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 21L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(2727), new DateTime(2020, 3, 25, 21, 34, 29, 729, DateTimeKind.Local).AddTicks(7210), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 22L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(2866), new DateTime(2021, 1, 1, 21, 11, 6, 992, DateTimeKind.Local).AddTicks(640), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 23L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(5149), new DateTime(2021, 2, 5, 3, 43, 39, 818, DateTimeKind.Local).AddTicks(9640), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 24L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7337), new DateTime(2020, 9, 27, 23, 39, 43, 161, DateTimeKind.Local).AddTicks(2893), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 25L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7456), new DateTime(2020, 10, 9, 22, 54, 45, 963, DateTimeKind.Local).AddTicks(3402), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 26L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7577), new DateTime(2020, 5, 22, 9, 39, 13, 323, DateTimeKind.Local).AddTicks(4215), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 27L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7650), new DateTime(2020, 7, 7, 19, 15, 11, 187, DateTimeKind.Local).AddTicks(8219), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 28L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7972), new DateTime(2020, 8, 23, 17, 41, 54, 352, DateTimeKind.Local).AddTicks(8276), new DateTime(2020, 3, 11, 16, 11, 27, 993, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 29L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(311), new DateTime(2020, 7, 14, 21, 8, 2, 148, DateTimeKind.Local).AddTicks(9885), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 30L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(399), new DateTime(2020, 4, 12, 14, 59, 41, 907, DateTimeKind.Local).AddTicks(6078), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 31L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(472), new DateTime(2021, 2, 2, 0, 2, 29, 259, DateTimeKind.Local).AddTicks(8510), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 32L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(1257), new DateTime(2020, 7, 16, 20, 40, 2, 516, DateTimeKind.Local).AddTicks(7136), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 33L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3493), new DateTime(2020, 3, 24, 5, 11, 36, 841, DateTimeKind.Local).AddTicks(9095), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 34L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3683), new DateTime(2021, 2, 25, 6, 46, 0, 158, DateTimeKind.Local).AddTicks(9943), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 35L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3807), new DateTime(2020, 5, 13, 18, 4, 46, 936, DateTimeKind.Local).AddTicks(7544), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 36L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3938), new DateTime(2020, 10, 7, 23, 37, 47, 452, DateTimeKind.Local).AddTicks(585), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 37L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4058), new DateTime(2020, 10, 11, 10, 38, 3, 188, DateTimeKind.Local).AddTicks(4886), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 38L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4272), new DateTime(2020, 7, 12, 3, 52, 58, 645, DateTimeKind.Local).AddTicks(6943), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 39L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4346), new DateTime(2021, 2, 21, 14, 53, 42, 740, DateTimeKind.Local).AddTicks(7693), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 40L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4393), new DateTime(2020, 8, 11, 16, 44, 14, 825, DateTimeKind.Local).AddTicks(6253), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 41L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5204), new DateTime(2021, 1, 7, 1, 53, 2, 471, DateTimeKind.Local).AddTicks(4594), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 42L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5619), new DateTime(2020, 7, 17, 6, 32, 27, 83, DateTimeKind.Local).AddTicks(1729), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 43L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5770), new DateTime(2020, 3, 19, 9, 0, 31, 549, DateTimeKind.Local).AddTicks(5878), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 44L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5837), new DateTime(2020, 5, 6, 6, 39, 17, 554, DateTimeKind.Local).AddTicks(4759), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 45L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7513), new DateTime(2021, 1, 6, 2, 34, 39, 596, DateTimeKind.Local).AddTicks(2276), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 46L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7589), new DateTime(2020, 12, 31, 7, 44, 14, 170, DateTimeKind.Local).AddTicks(6928), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 47L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7633), new DateTime(2020, 4, 15, 1, 39, 5, 253, DateTimeKind.Local).AddTicks(5135), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 48L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7686), new DateTime(2020, 8, 21, 13, 29, 42, 343, DateTimeKind.Local).AddTicks(2949), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 49L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9756), new DateTime(2021, 2, 27, 8, 13, 29, 233, DateTimeKind.Local).AddTicks(7670), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 50L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9852), new DateTime(2020, 8, 18, 12, 46, 0, 180, DateTimeKind.Local).AddTicks(7461), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 51L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9905), new DateTime(2021, 2, 20, 23, 5, 38, 941, DateTimeKind.Local).AddTicks(6119), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 52L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9948), new DateTime(2020, 9, 5, 15, 10, 43, 313, DateTimeKind.Local).AddTicks(4652), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 53L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9990), new DateTime(2020, 3, 19, 3, 39, 25, 939, DateTimeKind.Local).AddTicks(7531), new DateTime(2020, 3, 11, 16, 11, 27, 994, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 54L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(33), new DateTime(2020, 5, 24, 18, 24, 48, 805, DateTimeKind.Local).AddTicks(8554), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 55L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(90), new DateTime(2020, 3, 18, 11, 34, 44, 787, DateTimeKind.Local).AddTicks(1809), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 56L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(132), new DateTime(2020, 6, 30, 10, 14, 24, 192, DateTimeKind.Local).AddTicks(4086), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 57L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(176), new DateTime(2020, 6, 19, 2, 49, 44, 213, DateTimeKind.Local).AddTicks(8794), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 58L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(216), new DateTime(2021, 3, 11, 15, 13, 29, 206, DateTimeKind.Local).AddTicks(8188), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 59L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(260), new DateTime(2020, 10, 2, 18, 58, 10, 763, DateTimeKind.Local).AddTicks(3568), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 60L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(301), new DateTime(2021, 2, 16, 14, 55, 42, 457, DateTimeKind.Local).AddTicks(2719), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 61L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(414), new DateTime(2020, 7, 21, 19, 6, 19, 636, DateTimeKind.Local).AddTicks(375), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 62L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(459), new DateTime(2020, 8, 22, 20, 13, 37, 906, DateTimeKind.Local).AddTicks(734), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 63L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(501), new DateTime(2020, 7, 21, 7, 44, 42, 338, DateTimeKind.Local).AddTicks(4437), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 64L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(541), new DateTime(2020, 6, 30, 6, 49, 22, 944, DateTimeKind.Local).AddTicks(1393), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 65L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(634), new DateTime(2020, 6, 11, 8, 26, 15, 935, DateTimeKind.Local).AddTicks(6748), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 66L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(678), new DateTime(2020, 8, 27, 22, 30, 37, 723, DateTimeKind.Local).AddTicks(1116), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 67L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(721), new DateTime(2021, 1, 16, 4, 48, 9, 751, DateTimeKind.Local).AddTicks(4577), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 68L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(765), new DateTime(2020, 9, 29, 17, 21, 52, 759, DateTimeKind.Local).AddTicks(1785), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 69L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(805), new DateTime(2021, 1, 7, 17, 37, 34, 351, DateTimeKind.Local).AddTicks(1387), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 70L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(867), new DateTime(2020, 9, 24, 5, 16, 26, 333, DateTimeKind.Local).AddTicks(4194), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 71L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(908), new DateTime(2021, 2, 16, 13, 48, 55, 717, DateTimeKind.Local).AddTicks(4461), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 72L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(949), new DateTime(2020, 10, 1, 23, 23, 32, 443, DateTimeKind.Local).AddTicks(1966), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 73L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(988), new DateTime(2020, 12, 1, 6, 44, 12, 170, DateTimeKind.Local).AddTicks(4521), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 74L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1028), new DateTime(2020, 5, 31, 2, 36, 10, 703, DateTimeKind.Local).AddTicks(5106), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 75L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1069), new DateTime(2020, 4, 6, 0, 12, 4, 931, DateTimeKind.Local).AddTicks(4560), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 76L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1110), new DateTime(2020, 7, 16, 2, 48, 35, 741, DateTimeKind.Local).AddTicks(6426), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 77L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1877), new DateTime(2021, 1, 10, 16, 9, 29, 192, DateTimeKind.Local).AddTicks(7827), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 78L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1944), new DateTime(2020, 12, 29, 9, 35, 21, 125, DateTimeKind.Local).AddTicks(8770), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 79L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1986), new DateTime(2021, 1, 25, 23, 29, 16, 168, DateTimeKind.Local).AddTicks(9758), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 80L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2100), new DateTime(2020, 10, 23, 11, 20, 51, 214, DateTimeKind.Local).AddTicks(4334), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 81L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2143), new DateTime(2021, 1, 7, 1, 46, 3, 579, DateTimeKind.Local).AddTicks(8390), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 82L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2184), new DateTime(2020, 5, 29, 16, 59, 14, 629, DateTimeKind.Local).AddTicks(7319), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 83L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2225), new DateTime(2020, 11, 27, 10, 48, 30, 0, DateTimeKind.Local).AddTicks(699), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 84L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(3800), new DateTime(2020, 7, 29, 14, 42, 27, 625, DateTimeKind.Local).AddTicks(4384), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 85L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5486), new DateTime(2020, 5, 9, 17, 11, 36, 709, DateTimeKind.Local).AddTicks(3177), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 86L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5561), new DateTime(2020, 9, 28, 17, 25, 23, 738, DateTimeKind.Local).AddTicks(752), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 87L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5605), new DateTime(2020, 10, 6, 17, 58, 40, 562, DateTimeKind.Local).AddTicks(4539), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 88L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5648), new DateTime(2021, 1, 22, 9, 4, 27, 12, DateTimeKind.Local).AddTicks(8674), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 89L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5694), new DateTime(2020, 11, 14, 19, 59, 19, 391, DateTimeKind.Local).AddTicks(7197), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 90L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5756), new DateTime(2020, 11, 28, 12, 12, 3, 273, DateTimeKind.Local).AddTicks(6958), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 91L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5801), new DateTime(2020, 6, 5, 0, 13, 21, 772, DateTimeKind.Local).AddTicks(1882), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 92L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5842), new DateTime(2021, 1, 25, 3, 33, 23, 975, DateTimeKind.Local).AddTicks(9366), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 93L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5895), new DateTime(2020, 7, 31, 12, 13, 15, 38, DateTimeKind.Local).AddTicks(7600), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 94L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5938), new DateTime(2021, 2, 16, 14, 26, 16, 17, DateTimeKind.Local).AddTicks(2048), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 95L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5979), new DateTime(2021, 1, 25, 6, 38, 9, 973, DateTimeKind.Local).AddTicks(9617), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 96L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(6022), new DateTime(2020, 4, 25, 16, 18, 27, 397, DateTimeKind.Local).AddTicks(2811), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 97L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(7589), new DateTime(2021, 2, 9, 21, 32, 5, 862, DateTimeKind.Local).AddTicks(4607), new DateTime(2020, 3, 11, 16, 11, 27, 995, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 98L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(145), new DateTime(2020, 8, 12, 19, 23, 52, 330, DateTimeKind.Local).AddTicks(5893), new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 99L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(313), new DateTime(2020, 11, 23, 7, 40, 9, 561, DateTimeKind.Local).AddTicks(7841), new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 100L,
                columns: new[] { "created", "Date", "modified" },
                values: new object[] { new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(439), new DateTime(2020, 10, 6, 14, 18, 29, 807, DateTimeKind.Local).AddTicks(9915), new DateTime(2020, 3, 11, 16, 11, 27, 996, DateTimeKind.Utc).AddTicks(443) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressPersonRelationId",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "created",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "info",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "info_rtf",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "modified",
                table: "address_person_relation");

            migrationBuilder.DropColumn(
                name: "modified_by",
                table: "address_person_relation");

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
        }
    }
}
