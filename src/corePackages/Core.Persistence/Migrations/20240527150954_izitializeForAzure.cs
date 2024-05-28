using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class izitializeForAzure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3a479532-c61b-4ce3-b890-170e02d09b77"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bc3cbffb-80e5-4401-83c6-28a1e9d9b555"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ee96b634-bd29-42d5-9fd5-8ccc8faef99e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("27b08ae1-9640-46a3-ba41-bf54564804c3"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e196ff9-d46c-4596-8114-6a3f47fe65b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f74c4783-67f5-4a10-a63e-e473b6c39407"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3a479532-c61b-4ce3-b890-170e02d09b77"), null, null, new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8939), null, true, null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("bc3cbffb-80e5-4401-83c6-28a1e9d9b555"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8913), new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8887), null, true, null, null, 1, "csharp.png", "C# 9.0", 100 },
                    { new Guid("ee96b634-bd29-42d5-9fd5-8ccc8faef99e"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 5, 19, 18, 39, 32, 704, DateTimeKind.Local).AddTicks(8976), null, false, null, null, 1, "python.png", "Python 3.9", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 18, 39, 32, 714, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 18, 39, 32, 714, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("3e196ff9-d46c-4596-8114-6a3f47fe65b5"), "Admin", new DateTime(2024, 5, 19, 18, 39, 32, 694, DateTimeKind.Local).AddTicks(6522), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("f74c4783-67f5-4a10-a63e-e473b6c39407"), 0, "Admin", new DateTime(2024, 5, 19, 18, 39, 32, 702, DateTimeKind.Local).AddTicks(8981), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 53, 159, 246, 221, 177, 31, 140, 112, 251, 65, 246, 164, 186, 219, 236, 239, 3, 236, 107, 179, 200, 173, 236, 222, 24, 18, 236, 7, 205, 111, 213, 86, 229, 238, 93, 230, 59, 245, 180, 80, 253, 233, 37, 110, 33, 200, 37, 204, 45, 60, 86, 156, 239, 231, 40, 162, 167, 55, 132, 3, 163, 113, 25, 54 }, new byte[] { 135, 163, 19, 91, 106, 133, 170, 246, 134, 129, 69, 102, 104, 240, 242, 102, 27, 33, 47, 131, 177, 109, 214, 115, 84, 213, 67, 171, 255, 72, 234, 44, 108, 24, 93, 110, 237, 222, 128, 139, 170, 13, 99, 154, 203, 109, 117, 250, 126, 19, 100, 47, 107, 248, 170, 47, 54, 210, 51, 9, 153, 190, 9, 71, 226, 205, 250, 96, 171, 70, 211, 17, 235, 195, 77, 81, 252, 162, 48, 177, 58, 32, 52, 16, 250, 163, 75, 125, 164, 2, 4, 70, 3, 131, 188, 183, 208, 183, 129, 174, 23, 88, 89, 210, 93, 64, 97, 221, 174, 231, 215, 145, 24, 65, 24, 11, 211, 29, 46, 99, 134, 242, 82, 210, 109, 27, 75, 170 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("27b08ae1-9640-46a3-ba41-bf54564804c3"), null, "Admin", new DateTime(2024, 5, 19, 18, 39, 32, 703, DateTimeKind.Local).AddTicks(9543), null, null, null, new Guid("3e196ff9-d46c-4596-8114-6a3f47fe65b5"), 1, new Guid("f74c4783-67f5-4a10-a63e-e473b6c39407") });
        }
    }
}
