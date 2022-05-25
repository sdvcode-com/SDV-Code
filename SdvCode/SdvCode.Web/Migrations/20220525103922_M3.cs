using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddedPostToFavoriteActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddedPostToFavoriteActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddedPostToFavoriteActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AddPostToFavoriteActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddPostToFavoriteActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddPostToFavoriteActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddedPostToFavoriteActions");

            migrationBuilder.DropTable(
                name: "AddPostToFavoriteActions");
        }
    }
}