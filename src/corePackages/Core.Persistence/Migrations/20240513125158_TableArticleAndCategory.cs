using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableArticleAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d11b7a4e-1c96-44d5-8540-16af932cb2b5"));

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("dbf2a33b-42ac-4530-bf2e-37c88b0f3d7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12feec4a-bf2f-4e22-81ef-ce1b9c2fae66"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 250, nullable: false),
                    ViewCount = table.Column<int>(type: "int", maxLength: 250, nullable: false),
                    CommentCount = table.Column<int>(type: "int", maxLength: 250, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 250, nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

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

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[] { new Guid("dbf2a33b-42ac-4530-bf2e-37c88b0f3d7e"), "Admin", new DateTime(2024, 5, 13, 13, 37, 40, 229, DateTimeKind.Local).AddTicks(5749), null, null, null, "Admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedBy", "CreatedDate", "CultureType", "DeletedDate", "Email", "FirstName", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new Guid("12feec4a-bf2f-4e22-81ef-ce1b9c2fae66"), 0, "Admin", new DateTime(2024, 5, 13, 13, 37, 40, 234, DateTimeKind.Local).AddTicks(4286), 0, null, "admin@admin.com", "Admin", "Admin", null, null, new byte[] { 208, 236, 92, 123, 16, 190, 136, 140, 71, 238, 171, 51, 214, 42, 244, 46, 119, 238, 219, 35, 35, 181, 111, 164, 98, 65, 168, 227, 76, 64, 111, 157, 109, 234, 153, 9, 49, 138, 200, 32, 200, 166, 201, 128, 145, 14, 161, 129, 138, 106, 203, 236, 162, 105, 225, 30, 142, 82, 105, 192, 11, 124, 49, 8 }, new byte[] { 126, 6, 135, 99, 34, 155, 79, 211, 72, 108, 69, 131, 203, 137, 73, 65, 178, 97, 220, 5, 204, 29, 113, 107, 228, 164, 3, 133, 196, 29, 57, 8, 195, 49, 164, 227, 197, 253, 78, 62, 21, 191, 195, 120, 202, 173, 163, 196, 179, 66, 53, 109, 33, 108, 223, 236, 159, 253, 104, 82, 251, 18, 114, 230, 28, 159, 137, 187, 154, 118, 179, 201, 48, 95, 180, 26, 59, 10, 214, 15, 109, 90, 221, 75, 198, 39, 119, 193, 14, 196, 242, 196, 53, 121, 216, 229, 25, 9, 135, 80, 55, 208, 245, 196, 41, 61, 183, 15, 196, 255, 120, 30, 131, 105, 102, 63, 244, 56, 25, 20, 72, 196, 119, 164, 54, 12, 64, 234 }, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "ModifiedBy", "ModifiedDate", "OperationClaimId", "Status", "UserId" },
                values: new object[] { new Guid("d11b7a4e-1c96-44d5-8540-16af932cb2b5"), "Admin", new DateTime(2024, 5, 13, 13, 37, 40, 235, DateTimeKind.Local).AddTicks(4683), null, null, null, new Guid("dbf2a33b-42ac-4530-bf2e-37c88b0f3d7e"), 1, new Guid("12feec4a-bf2f-4e22-81ef-ce1b9c2fae66") });
        }
    }
}
