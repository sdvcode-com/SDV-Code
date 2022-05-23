using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreatedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatedPostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatedPostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatedPostActions_PostId",
                table: "CreatedPostActions",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatedPostActions");
        }
    }
}
