using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedAarticleAndCategorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("37ae5f52-a7a2-4a01-89c2-48ac593b0220"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bd1a20f2-fd8a-4097-aa17-84f1a053bd9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("946d4a9f-1618-4f03-a80f-7d3166993631"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), "System", new DateTime(2024, 5, 13, 16, 1, 38, 533, DateTimeKind.Local).AddTicks(3143), null, "C# ile ilgili makaleler", null, null, "C#", 1 },
                    { new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), "System", new DateTime(2024, 5, 13, 16, 1, 38, 533, DateTimeKind.Local).AddTicks(3148), null, "Java ile ilgili makaleler", null, null, "Java", 1 }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"), "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 524, DateTimeKind.Local).AddTicks(3073), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0"), 0, "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 527, DateTimeKind.Local).AddTicks(6319), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 173, 83, 101, 26, 160, 112, 109, 250, 246, 220, 52, 94, 174, 130, 24, 183, 202, 130, 6, 11, 30, 239, 64, 101, 145, 195, 98, 190, 61, 9, 0, 243, 190, 47, 246, 153, 52, 209, 188, 3, 124, 107, 14, 184, 246, 219, 89, 224, 244, 14, 60, 136, 78, 157, 84, 193, 179, 96, 78, 195, 88, 197, 212, 248 }, new byte[] { 41, 219, 66, 6, 150, 214, 204, 59, 9, 156, 103, 157, 114, 195, 24, 182, 107, 32, 117, 186, 153, 83, 238, 25, 234, 116, 196, 217, 160, 5, 18, 192, 86, 26, 202, 37, 103, 213, 152, 140, 40, 28, 226, 180, 214, 197, 55, 19, 132, 64, 107, 13, 37, 14, 227, 170, 126, 180, 45, 58, 177, 122, 94, 69, 57, 199, 35, 90, 250, 14, 5, 209, 183, 37, 146, 91, 57, 124, 154, 116, 32, 139, 88, 38, 31, 248, 103, 41, 29, 37, 55, 67, 56, 195, 195, 6, 85, 3, 210, 153, 64, 176, 15, 111, 32, 207, 237, 142, 122, 166, 236, 168, 181, 189, 210, 151, 36, 239, 11, 125, 10, 121, 113, 116, 216, 155, 96, 158 }, 1 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("67b36b56-a097-42be-b6b2-5a4994983a8c"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9005), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("b898d900-a6af-4ed4-bbb3-5d939638ab97"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9013), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100 },
                    { new Guid("eac9a7fd-0c93-448a-9289-71376b7a33e3"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(8966), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100 }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("3ec19d49-64f4-46db-99c2-4094568890a6"), "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 528, DateTimeKind.Local).AddTicks(3872), null, null, null, new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"), 1, new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("67b36b56-a097-42be-b6b2-5a4994983a8c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b898d900-a6af-4ed4-bbb3-5d939638ab97"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("eac9a7fd-0c93-448a-9289-71376b7a33e3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3ec19d49-64f4-46db-99c2-4094568890a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("bd1a20f2-fd8a-4097-aa17-84f1a053bd9a"), "Admin", new DateTime(2024, 5, 13, 15, 51, 55, 674, DateTimeKind.Local).AddTicks(4870), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("946d4a9f-1618-4f03-a80f-7d3166993631"), 0, "Admin", new DateTime(2024, 5, 13, 15, 51, 55, 677, DateTimeKind.Local).AddTicks(6844), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 40, 46, 17, 47, 34, 157, 191, 190, 36, 48, 44, 28, 193, 198, 110, 175, 159, 33, 165, 28, 97, 94, 67, 60, 52, 52, 231, 118, 135, 200, 237, 58, 9, 242, 12, 92, 145, 85, 205, 216, 144, 76, 219, 66, 206, 184, 120, 29, 205, 187, 190, 115, 234, 170, 176, 241, 102, 237, 56, 210, 168, 247, 159, 99 }, new byte[] { 190, 98, 228, 132, 20, 140, 250, 92, 211, 141, 164, 143, 28, 215, 139, 66, 188, 243, 189, 44, 183, 19, 131, 216, 197, 58, 231, 42, 186, 167, 247, 228, 54, 178, 31, 251, 83, 43, 173, 253, 125, 49, 118, 105, 93, 87, 169, 53, 195, 190, 107, 223, 60, 20, 137, 97, 101, 208, 156, 161, 20, 190, 27, 69, 195, 119, 14, 166, 216, 145, 129, 77, 57, 112, 171, 45, 54, 67, 217, 85, 110, 132, 237, 238, 190, 112, 227, 58, 215, 43, 202, 250, 130, 45, 120, 74, 65, 232, 232, 149, 40, 20, 23, 129, 73, 199, 248, 99, 0, 214, 169, 99, 38, 143, 90, 171, 24, 172, 198, 209, 81, 63, 106, 70, 50, 162, 117, 63 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("37ae5f52-a7a2-4a01-89c2-48ac593b0220"), "Admin", new DateTime(2024, 5, 13, 15, 51, 55, 678, DateTimeKind.Local).AddTicks(3368), null, null, null, new Guid("bd1a20f2-fd8a-4097-aa17-84f1a053bd9a"), 1, new Guid("946d4a9f-1618-4f03-a80f-7d3166993631") });
        }
    }
}
