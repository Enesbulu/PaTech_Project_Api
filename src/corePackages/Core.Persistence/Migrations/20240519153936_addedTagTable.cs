using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedTagTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7e2b28f1-483a-495d-bc3e-58eab4480e0e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cdfdd93c-1648-43c9-9b54-a88112e09259"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("eeda1f3d-f09a-4a6c-ae1b-cd1a2e32b8a4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4bc7a8d2-fa1b-451a-813d-0d80e64932d4"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("adac0ead-fc23-4576-9dbc-25feb48e8a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("152e1254-4b22-4d18-b261-9a6ed553ecbb"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovalDate",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticlesTags",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesTags", x => new { x.ArticleId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ArticlesTags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesTags_TagId",
                table: "ArticlesTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesTags");

            migrationBuilder.DropTable(
                name: "Tags");

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

            migrationBuilder.DropColumn(
                name: "ApprovalDate",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedDate", "ModifiedBy", "ModifiedDate", "Status", "Thumbnail", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("7e2b28f1-483a-495d-bc3e-58eab4480e0e"), null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(8002), null, null, null, 1, "python.png", "Python 3.9", 100 },
                    { new Guid("cdfdd93c-1648-43c9-9b54-a88112e09259"), null, new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(7998), new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(7996), null, null, null, 1, "java.png", "Java 11", 100 },
                    { new Guid("eeda1f3d-f09a-4a6c-ae1b-cd1a2e32b8a4"), null, new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(7976), null, null, null, 1, "csharp.png", "C# 9.0", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 16, 54, 22, 476, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 16, 54, 22, 476, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("adac0ead-fc23-4576-9dbc-25feb48e8a10"), "Admin", new DateTime(2024, 5, 19, 16, 54, 22, 467, DateTimeKind.Local).AddTicks(512), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("152e1254-4b22-4d18-b261-9a6ed553ecbb"), 0, "Admin", new DateTime(2024, 5, 19, 16, 54, 22, 469, DateTimeKind.Local).AddTicks(6667), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 35, 147, 115, 193, 78, 141, 210, 213, 52, 166, 109, 53, 227, 63, 151, 185, 72, 8, 8, 29, 94, 122, 113, 130, 246, 244, 107, 79, 38, 75, 35, 224, 12, 211, 158, 245, 243, 33, 22, 165, 150, 68, 81, 171, 32, 103, 87, 188, 164, 123, 42, 198, 82, 85, 164, 149, 229, 156, 161, 63, 32, 132, 116, 153 }, new byte[] { 247, 214, 11, 179, 244, 97, 102, 48, 23, 14, 53, 232, 210, 245, 73, 140, 103, 62, 1, 66, 79, 71, 68, 162, 56, 180, 25, 120, 193, 152, 57, 10, 66, 133, 1, 211, 191, 166, 223, 172, 202, 20, 80, 161, 3, 132, 165, 214, 230, 219, 201, 66, 26, 122, 213, 75, 126, 106, 87, 117, 5, 80, 161, 235, 233, 6, 88, 132, 102, 209, 96, 16, 163, 91, 21, 140, 102, 174, 3, 106, 56, 230, 199, 109, 204, 188, 177, 133, 31, 205, 23, 69, 252, 215, 188, 82, 122, 173, 134, 130, 59, 238, 192, 55, 215, 88, 93, 221, 156, 229, 28, 58, 81, 246, 6, 61, 134, 203, 40, 89, 100, 128, 226, 46, 250, 37, 127, 145 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("4bc7a8d2-fa1b-451a-813d-0d80e64932d4"), null, "Admin", new DateTime(2024, 5, 19, 16, 54, 22, 470, DateTimeKind.Local).AddTicks(2418), null, null, null, new Guid("adac0ead-fc23-4576-9dbc-25feb48e8a10"), 1, new Guid("152e1254-4b22-4d18-b261-9a6ed553ecbb") });
        }
    }
}
