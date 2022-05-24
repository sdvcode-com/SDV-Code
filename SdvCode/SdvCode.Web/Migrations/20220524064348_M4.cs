using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatedPostActions_BlogPosts_PostId",
                table: "CreatedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatedPostActions_WebsiteActions_Id",
                table: "CreatedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatePostActions_BlogPosts_PostId",
                table: "CreatePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatePostActions_WebsiteActions_Id",
                table: "CreatePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostActions_BlogPosts_PostId",
                table: "LikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostActions_WebsiteActions_Id",
                table: "LikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeOwnPostActions_BlogPosts_PostId",
                table: "LikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeOwnPostActions_WebsiteActions_Id",
                table: "LikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePostActions_BlogPosts_PostId",
                table: "LikePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePostActions_WebsiteActions_Id",
                table: "LikePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikedPostActions_BlogPosts_PostId",
                table: "UnlikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikedPostActions_WebsiteActions_Id",
                table: "UnlikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikeOwnPostActions_BlogPosts_PostId",
                table: "UnlikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikeOwnPostActions_WebsiteActions_Id",
                table: "UnlikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikePostActions_BlogPosts_PostId",
                table: "UnlikePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikePostActions_WebsiteActions_Id",
                table: "UnlikePostActions");

            migrationBuilder.DropIndex(
                name: "IX_UnlikePostActions_PostId",
                table: "UnlikePostActions");

            migrationBuilder.DropIndex(
                name: "IX_UnlikeOwnPostActions_PostId",
                table: "UnlikeOwnPostActions");

            migrationBuilder.DropIndex(
                name: "IX_UnlikedPostActions_PostId",
                table: "UnlikedPostActions");

            migrationBuilder.DropIndex(
                name: "IX_LikePostActions_PostId",
                table: "LikePostActions");

            migrationBuilder.DropIndex(
                name: "IX_LikeOwnPostActions_PostId",
                table: "LikeOwnPostActions");

            migrationBuilder.DropIndex(
                name: "IX_LikedPostActions_PostId",
                table: "LikedPostActions");

            migrationBuilder.DropIndex(
                name: "IX_CreatePostActions_PostId",
                table: "CreatePostActions");

            migrationBuilder.DropIndex(
                name: "IX_CreatedPostActions_PostId",
                table: "CreatedPostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "UnlikePostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "UnlikeOwnPostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "UnlikedPostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "LikePostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "LikeOwnPostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "LikedPostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "CreatePostActions");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "CreatedPostActions");

            migrationBuilder.CreateTable(
                name: "BasePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasePostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasePostActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasePostActions_PostId",
                table: "BasePostActions",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatedPostActions_BasePostActions_Id",
                table: "CreatedPostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePostActions_BasePostActions_Id",
                table: "CreatePostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostActions_BasePostActions_Id",
                table: "LikedPostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikeOwnPostActions_BasePostActions_Id",
                table: "LikeOwnPostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikePostActions_BasePostActions_Id",
                table: "LikePostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikedPostActions_BasePostActions_Id",
                table: "UnlikedPostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikeOwnPostActions_BasePostActions_Id",
                table: "UnlikeOwnPostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikePostActions_BasePostActions_Id",
                table: "UnlikePostActions",
                column: "Id",
                principalTable: "BasePostActions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatedPostActions_BasePostActions_Id",
                table: "CreatedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatePostActions_BasePostActions_Id",
                table: "CreatePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikedPostActions_BasePostActions_Id",
                table: "LikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeOwnPostActions_BasePostActions_Id",
                table: "LikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_LikePostActions_BasePostActions_Id",
                table: "LikePostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikedPostActions_BasePostActions_Id",
                table: "UnlikedPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikeOwnPostActions_BasePostActions_Id",
                table: "UnlikeOwnPostActions");

            migrationBuilder.DropForeignKey(
                name: "FK_UnlikePostActions_BasePostActions_Id",
                table: "UnlikePostActions");

            migrationBuilder.DropTable(
                name: "EditedPostActions");

            migrationBuilder.DropTable(
                name: "EditOwnPostActions");

            migrationBuilder.DropTable(
                name: "EditPostActions");

            migrationBuilder.DropTable(
                name: "BasePostActions");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "UnlikePostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "UnlikeOwnPostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "UnlikedPostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "LikePostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "LikeOwnPostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "LikedPostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "CreatePostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostId",
                table: "CreatedPostActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UnlikePostActions_PostId",
                table: "UnlikePostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UnlikeOwnPostActions_PostId",
                table: "UnlikeOwnPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_UnlikedPostActions_PostId",
                table: "UnlikedPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikePostActions_PostId",
                table: "LikePostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeOwnPostActions_PostId",
                table: "LikeOwnPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedPostActions_PostId",
                table: "LikedPostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatePostActions_PostId",
                table: "CreatePostActions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedPostActions_PostId",
                table: "CreatedPostActions",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatedPostActions_BlogPosts_PostId",
                table: "CreatedPostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatedPostActions_WebsiteActions_Id",
                table: "CreatedPostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePostActions_BlogPosts_PostId",
                table: "CreatePostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePostActions_WebsiteActions_Id",
                table: "CreatePostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostActions_BlogPosts_PostId",
                table: "LikedPostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikedPostActions_WebsiteActions_Id",
                table: "LikedPostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikeOwnPostActions_BlogPosts_PostId",
                table: "LikeOwnPostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeOwnPostActions_WebsiteActions_Id",
                table: "LikeOwnPostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LikePostActions_BlogPosts_PostId",
                table: "LikePostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikePostActions_WebsiteActions_Id",
                table: "LikePostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikedPostActions_BlogPosts_PostId",
                table: "UnlikedPostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikedPostActions_WebsiteActions_Id",
                table: "UnlikedPostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikeOwnPostActions_BlogPosts_PostId",
                table: "UnlikeOwnPostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikeOwnPostActions_WebsiteActions_Id",
                table: "UnlikeOwnPostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikePostActions_BlogPosts_PostId",
                table: "UnlikePostActions",
                column: "PostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnlikePostActions_WebsiteActions_Id",
                table: "UnlikePostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");
        }
    }
}
