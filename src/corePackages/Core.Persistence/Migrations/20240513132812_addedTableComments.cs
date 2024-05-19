using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedTableComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0"));

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentContents = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2a23fdf1-414e-4157-82d7-6e0e7e75a671"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1764), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100 },
                    { new Guid("ce172bf1-594d-467e-bbfd-b6ebe5d66a45"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1787), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("f351202a-6f87-4473-91c2-2f2db66d0b69"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1795), new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(1793), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 16, 28, 10, 11, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("d509f606-c40c-44e2-9e31-dbba5ce14c42"), "Admin", new DateTime(2024, 5, 13, 16, 28, 9, 998, DateTimeKind.Local).AddTicks(898), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("93139876-464c-4858-b7ed-aa005de8d18b"), 0, "Admin", new DateTime(2024, 5, 13, 16, 28, 10, 1, DateTimeKind.Local).AddTicks(541), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 121, 32, 234, 217, 157, 33, 25, 103, 38, 68, 226, 179, 41, 17, 111, 124, 148, 122, 143, 199, 30, 123, 43, 21, 2, 222, 212, 232, 134, 231, 81, 177, 47, 223, 141, 117, 2, 221, 149, 94, 18, 13, 123, 238, 122, 117, 1, 28, 113, 72, 83, 198, 122, 192, 149, 165, 88, 7, 144, 129, 221, 105, 98, 214 }, new byte[] { 101, 40, 106, 60, 206, 76, 197, 68, 38, 122, 197, 204, 245, 69, 218, 70, 89, 100, 8, 92, 224, 37, 77, 74, 66, 172, 85, 25, 128, 225, 75, 103, 146, 21, 217, 2, 24, 143, 113, 122, 251, 228, 205, 139, 75, 246, 204, 76, 142, 94, 236, 71, 98, 222, 94, 25, 124, 242, 168, 112, 58, 162, 131, 171, 147, 250, 228, 88, 187, 234, 206, 87, 117, 6, 210, 139, 17, 221, 239, 34, 16, 203, 78, 239, 113, 121, 108, 36, 47, 213, 187, 117, 250, 13, 203, 44, 108, 139, 24, 137, 221, 246, 37, 33, 31, 190, 130, 14, 8, 150, 55, 229, 14, 209, 186, 188, 240, 94, 101, 251, 123, 99, 106, 63, 91, 176, 185, 33 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("51b92944-6f6f-40ee-b5f8-16ef1b407621"), "Admin", new DateTime(2024, 5, 13, 16, 28, 10, 1, DateTimeKind.Local).AddTicks(9329), null, null, null, new Guid("d509f606-c40c-44e2-9e31-dbba5ce14c42"), 1, new Guid("93139876-464c-4858-b7ed-aa005de8d18b") });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleID",
                table: "Comments",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2a23fdf1-414e-4157-82d7-6e0e7e75a671"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ce172bf1-594d-467e-bbfd-b6ebe5d66a45"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f351202a-6f87-4473-91c2-2f2db66d0b69"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("51b92944-6f6f-40ee-b5f8-16ef1b407621"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d509f606-c40c-44e2-9e31-dbba5ce14c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93139876-464c-4858-b7ed-aa005de8d18b"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("67b36b56-a097-42be-b6b2-5a4994983a8c"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9005), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("b898d900-a6af-4ed4-bbb3-5d939638ab97"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(9013), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100 },
                    { new Guid("eac9a7fd-0c93-448a-9289-71376b7a33e3"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 5, 13, 16, 1, 38, 532, DateTimeKind.Local).AddTicks(8966), null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 16, 1, 38, 533, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 16, 1, 38, 533, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"), "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 524, DateTimeKind.Local).AddTicks(3073), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0"), 0, "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 527, DateTimeKind.Local).AddTicks(6319), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 173, 83, 101, 26, 160, 112, 109, 250, 246, 220, 52, 94, 174, 130, 24, 183, 202, 130, 6, 11, 30, 239, 64, 101, 145, 195, 98, 190, 61, 9, 0, 243, 190, 47, 246, 153, 52, 209, 188, 3, 124, 107, 14, 184, 246, 219, 89, 224, 244, 14, 60, 136, 78, 157, 84, 193, 179, 96, 78, 195, 88, 197, 212, 248 }, new byte[] { 41, 219, 66, 6, 150, 214, 204, 59, 9, 156, 103, 157, 114, 195, 24, 182, 107, 32, 117, 186, 153, 83, 238, 25, 234, 116, 196, 217, 160, 5, 18, 192, 86, 26, 202, 37, 103, 213, 152, 140, 40, 28, 226, 180, 214, 197, 55, 19, 132, 64, 107, 13, 37, 14, 227, 170, 126, 180, 45, 58, 177, 122, 94, 69, 57, 199, 35, 90, 250, 14, 5, 209, 183, 37, 146, 91, 57, 124, 154, 116, 32, 139, 88, 38, 31, 248, 103, 41, 29, 37, 55, 67, 56, 195, 195, 6, 85, 3, 210, 153, 64, 176, 15, 111, 32, 207, 237, 142, 122, 166, 236, 168, 181, 189, 210, 151, 36, 239, 11, 125, 10, 121, 113, 116, 216, 155, 96, 158 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("3ec19d49-64f4-46db-99c2-4094568890a6"), "Admin", new DateTime(2024, 5, 13, 16, 1, 38, 528, DateTimeKind.Local).AddTicks(3872), null, null, null, new Guid("b18d9d36-7cdf-4e09-ae30-376b7802a716"), 1, new Guid("4344fdef-a4f0-48a5-9986-68ddd20585e0") });
        }
    }
}
