using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasePostImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePostImages_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePostImages_WebsiteImages_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostCoverImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCoverImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostCoverImages_BasePostImages_Id",
                        column: x => x.Id,
                        principalTable: "BasePostImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_BasePostImages_Id",
                        column: x => x.Id,
                        principalTable: "BasePostImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasePostImages_PostId",
                table: "BasePostImages",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostCoverImages");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "BasePostImages");
        }
    }
}
