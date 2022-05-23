using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnlikedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikedPostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnlikedPostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnlikeOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikeOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikeOwnPostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnlikeOwnPostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnlikePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnlikePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnlikePostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnlikePostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnlikedPostActions_PostId",
                table: "UnlikedPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UnlikeOwnPostActions_PostId",
                table: "UnlikeOwnPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UnlikePostActions_PostId",
                table: "UnlikePostActions",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnlikedPostActions");

            migrationBuilder.DropTable(
                name: "UnlikeOwnPostActions");

            migrationBuilder.DropTable(
                name: "UnlikePostActions");
        }
    }
}
