using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedCorrectionRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "EditorId",
                table: "Articles");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "UserOperationClaims",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "RefreshTokens",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "OtpAuthenticator",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "EmailAuthenticators",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Thumbnail",
                table: "Articles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AuthenticatorType = table.Column<int>(type: "int", nullable: false),
                    CultureType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", maxLength: 250, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 250, nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrectionRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_CorrectionRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrectionRequest_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorrectionRequest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_AuthorId",
                table: "UserOperationClaims",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_AuthorId",
                table: "RefreshTokens",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_OtpAuthenticator_AuthorId",
                table: "OtpAuthenticator",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAuthenticators_AuthorId",
                table: "EmailAuthenticators",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectionRequest_ArticleId",
                table: "CorrectionRequest",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectionRequest_UserId",
                table: "CorrectionRequest",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAuthenticators_Authors_AuthorId",
                table: "EmailAuthenticators",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OtpAuthenticator_Authors_AuthorId",
                table: "OtpAuthenticator",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Authors_AuthorId",
                table: "RefreshTokens",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_Authors_AuthorId",
                table: "UserOperationClaims",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAuthenticators_Authors_AuthorId",
                table: "EmailAuthenticators");

            migrationBuilder.DropForeignKey(
                name: "FK_OtpAuthenticator_Authors_AuthorId",
                table: "OtpAuthenticator");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Authors_AuthorId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_Authors_AuthorId",
                table: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "CorrectionRequest");

            migrationBuilder.DropIndex(
                name: "IX_UserOperationClaims_AuthorId",
                table: "UserOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_AuthorId",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_OtpAuthenticator_AuthorId",
                table: "OtpAuthenticator");

            migrationBuilder.DropIndex(
                name: "IX_EmailAuthenticators_AuthorId",
                table: "EmailAuthenticators");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles");

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "OtpAuthenticator");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "EmailAuthenticators");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Thumbnail",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EditorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }
    }
}
