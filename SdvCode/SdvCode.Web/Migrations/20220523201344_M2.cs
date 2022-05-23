using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CloudinaryPath",
                table: "WebsiteImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "WebsiteImages",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WebsiteImages",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SystemName",
                table: "WebsiteImages",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserCoverImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoverImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCoverImages_WebsiteImages_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteImages",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCoverImages");

            migrationBuilder.DropColumn(
                name: "CloudinaryPath",
                table: "WebsiteImages");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "WebsiteImages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WebsiteImages");

            migrationBuilder.DropColumn(
                name: "SystemName",
                table: "WebsiteImages");

            migrationBuilder.DropColumn(
                name: "RegisteredOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Users");
        }
    }
}