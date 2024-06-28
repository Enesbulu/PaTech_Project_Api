using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class forTestMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00eee368-7804-485a-b348-305a15003870"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7376), null, false, null, null, 1, "python.png", "Python 3.9", 100 },
                    { new Guid("1e18847c-8439-4996-9ccb-c8afe81f8b2c"), null, null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7329), null, true, null, null, 1, "csharp.png", "C# 9.0", 100 },
                    { new Guid("527d107d-b1f2-4a06-8fef-3d518ddc6da4"), null, null, new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7358), new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(7355), null, true, null, null, 1, "java.png", "Java 11", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 17, 24, 47, 941, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 17, 24, 47, 941, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("099b011c-9857-40a2-977f-2b0be96d95c7"), "Admin", new DateTime(2024, 6, 22, 17, 24, 47, 930, DateTimeKind.Local).AddTicks(8319), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("b7f0198c-85c1-4373-8fac-30bde74989d0"), 0, "Admin", new DateTime(2024, 6, 22, 17, 24, 47, 935, DateTimeKind.Local).AddTicks(3080), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 114, 48, 32, 122, 123, 166, 52, 27, 80, 219, 215, 114, 213, 88, 207, 228, 145, 107, 26, 108, 234, 184, 75, 150, 116, 202, 84, 119, 16, 40, 218, 209, 150, 191, 189, 241, 152, 121, 55, 124, 170, 154, 41, 159, 44, 89, 180, 192, 2, 88, 235, 164, 189, 211, 43, 34, 0, 82, 90, 197, 220, 113, 29, 40 }, new byte[] { 27, 38, 17, 130, 174, 146, 126, 76, 7, 48, 90, 75, 91, 91, 93, 219, 242, 117, 64, 207, 58, 211, 166, 112, 46, 99, 123, 136, 184, 139, 182, 182, 171, 55, 186, 219, 107, 248, 152, 52, 16, 178, 72, 171, 150, 213, 155, 209, 147, 44, 53, 227, 66, 171, 60, 183, 205, 129, 236, 64, 181, 138, 47, 189, 219, 83, 27, 128, 241, 178, 169, 254, 32, 66, 19, 76, 128, 229, 132, 247, 183, 26, 3, 227, 199, 138, 238, 221, 178, 169, 41, 233, 228, 65, 62, 133, 243, 85, 13, 244, 163, 66, 127, 13, 167, 10, 169, 201, 191, 96, 72, 50, 220, 20, 134, 216, 199, 115, 18, 219, 95, 142, 26, 107, 1, 5, 87, 165 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("416f8a04-8aac-401d-bd34-76d83ce8c55c"), null, "Admin", new DateTime(2024, 6, 22, 17, 24, 47, 936, DateTimeKind.Local).AddTicks(837), null, null, null, new Guid("099b011c-9857-40a2-977f-2b0be96d95c7"), 1, new Guid("b7f0198c-85c1-4373-8fac-30bde74989d0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00eee368-7804-485a-b348-305a15003870"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1e18847c-8439-4996-9ccb-c8afe81f8b2c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("527d107d-b1f2-4a06-8fef-3d518ddc6da4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("416f8a04-8aac-401d-bd34-76d83ce8c55c"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("099b011c-9857-40a2-977f-2b0be96d95c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7f0198c-85c1-4373-8fac-30bde74989d0"));

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
    }
}
