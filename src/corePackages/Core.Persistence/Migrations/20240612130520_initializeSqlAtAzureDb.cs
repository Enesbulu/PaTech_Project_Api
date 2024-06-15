using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initializeSqlAtAzureDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("31af55d8-be94-4b51-9418-b85f83a55e4d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5dbc3357-939b-427d-bd80-103b4d35e326"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d2e93056-a35f-4bf3-af1e-e29b26177172"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1d94e722-8401-4b5b-b65e-9ffc83dff2f8"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bf76ac26-d8b6-4563-bacf-ea21f6cdb823"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8a96f38-032a-4240-b88b-03017d9e280d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ApprovalDate", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "IsApproved", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5304259a-4032-4874-81f3-a4ea84875cca"), null, null, new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5436), null, true, null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("72d12296-94d4-4213-98af-0a5d98cfc981"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5430), new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5416), null, true, null, null, 1, "csharp.png", "C# 9.0", 100 },
                    { new Guid("c316d9f3-530e-4717-bdd8-e4bd0639e440"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(5449), null, false, null, null, 1, "python.png", "Python 3.9", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 12, 16, 5, 18, 11, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 12, 16, 5, 18, 11, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("8b6b7144-b3aa-490d-91f5-1ac5b9905a33"), "Admin", new DateTime(2024, 6, 12, 16, 5, 18, 1, DateTimeKind.Local).AddTicks(7339), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("4beea140-9244-4784-a8e1-e69e798041bb"), 0, "Admin", new DateTime(2024, 6, 12, 16, 5, 18, 4, DateTimeKind.Local).AddTicks(4447), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 4, 158, 74, 117, 26, 39, 195, 34, 121, 120, 114, 189, 254, 64, 148, 236, 159, 5, 235, 236, 176, 105, 60, 205, 250, 57, 78, 236, 217, 149, 247, 219, 210, 246, 232, 23, 227, 111, 99, 114, 172, 91, 206, 161, 239, 215, 23, 146, 56, 19, 180, 127, 43, 89, 83, 52, 219, 71, 11, 125, 192, 100, 59, 3 }, new byte[] { 93, 13, 107, 172, 105, 57, 18, 58, 207, 236, 14, 44, 203, 21, 221, 177, 135, 0, 255, 18, 159, 49, 50, 1, 112, 242, 222, 32, 55, 245, 42, 93, 16, 227, 27, 22, 203, 76, 83, 207, 211, 43, 211, 148, 153, 201, 64, 164, 153, 87, 208, 118, 236, 152, 107, 102, 142, 85, 78, 98, 52, 229, 118, 229, 65, 6, 158, 230, 135, 14, 216, 253, 149, 219, 25, 51, 60, 131, 27, 183, 198, 87, 98, 221, 231, 194, 60, 207, 225, 253, 35, 168, 252, 182, 200, 9, 232, 115, 10, 154, 174, 250, 182, 220, 60, 33, 118, 122, 126, 191, 167, 44, 56, 144, 162, 40, 163, 167, 69, 142, 180, 250, 188, 104, 217, 46, 127, 87 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("58126f99-7965-496b-b416-65375d14da49"), null, "Admin", new DateTime(2024, 6, 12, 16, 5, 18, 5, DateTimeKind.Local).AddTicks(237), null, null, null, new Guid("8b6b7144-b3aa-490d-91f5-1ac5b9905a33"), 1, new Guid("4beea140-9244-4784-a8e1-e69e798041bb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5304259a-4032-4874-81f3-a4ea84875cca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("72d12296-94d4-4213-98af-0a5d98cfc981"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c316d9f3-530e-4717-bdd8-e4bd0639e440"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("58126f99-7965-496b-b416-65375d14da49"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8b6b7144-b3aa-490d-91f5-1ac5b9905a33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4beea140-9244-4784-a8e1-e69e798041bb"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ApprovalDate", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "IsApproved", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("31af55d8-be94-4b51-9418-b85f83a55e4d"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6810), null, true, null, null, 1, "csharp.png", "C# 9.0", 100 },
                    { new Guid("5dbc3357-939b-427d-bd80-103b4d35e326"), null, null, new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6847), null, true, null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("d2e93056-a35f-4bf3-af1e-e29b26177172"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(6875), null, false, null, null, 1, "python.png", "Python 3.9", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 18, 9, 51, 89, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 18, 9, 51, 89, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("bf76ac26-d8b6-4563-bacf-ea21f6cdb823"), "Admin", new DateTime(2024, 5, 27, 18, 9, 51, 76, DateTimeKind.Local).AddTicks(9417), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("b8a96f38-032a-4240-b88b-03017d9e280d"), 0, "Admin", new DateTime(2024, 5, 27, 18, 9, 51, 80, DateTimeKind.Local).AddTicks(4513), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 132, 177, 208, 166, 158, 134, 231, 81, 77, 160, 82, 153, 237, 204, 19, 219, 191, 20, 111, 175, 225, 243, 186, 70, 24, 255, 247, 175, 212, 209, 222, 66, 4, 181, 111, 100, 83, 203, 186, 26, 255, 99, 123, 10, 244, 127, 233, 60, 97, 135, 139, 47, 119, 47, 90, 57, 208, 159, 145, 185, 255, 164, 5, 1 }, new byte[] { 140, 95, 183, 215, 226, 3, 164, 34, 24, 124, 11, 14, 215, 128, 102, 23, 47, 131, 18, 174, 187, 75, 174, 74, 86, 104, 78, 51, 103, 160, 225, 168, 162, 146, 17, 158, 65, 51, 34, 176, 109, 182, 74, 251, 115, 197, 184, 177, 249, 81, 18, 22, 15, 183, 109, 143, 19, 246, 219, 33, 112, 157, 172, 207, 131, 116, 117, 105, 255, 214, 164, 12, 183, 197, 65, 22, 15, 107, 7, 22, 2, 111, 42, 252, 29, 26, 0, 60, 20, 95, 247, 254, 156, 31, 76, 227, 140, 220, 140, 17, 87, 78, 55, 214, 24, 57, 214, 147, 179, 247, 184, 197, 43, 102, 158, 64, 211, 127, 1, 62, 174, 117, 196, 161, 0, 40, 204, 26 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("1d94e722-8401-4b5b-b65e-9ffc83dff2f8"), null, "Admin", new DateTime(2024, 5, 27, 18, 9, 51, 81, DateTimeKind.Local).AddTicks(1129), null, null, null, new Guid("bf76ac26-d8b6-4563-bacf-ea21f6cdb823"), 1, new Guid("b8a96f38-032a-4240-b88b-03017d9e280d") });
        }
    }
}
