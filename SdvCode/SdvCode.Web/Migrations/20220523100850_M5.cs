using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyFirstActions");

            migrationBuilder.AddColumn<int>(
                name: "ActionStatus",
                table: "Actions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LikePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikePostActions_Actions_Id",
                        column: x => x.Id,
                        principalTable: "Actions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LikePostActions_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikePostActions_PostId",
                table: "LikePostActions",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikePostActions");

            migrationBuilder.DropColumn(
                name: "ActionStatus",
                table: "Actions");

            migrationBuilder.CreateTable(
                name: "MyFirstActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFirstActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyFirstActions_Actions_Id",
                        column: x => x.Id,
                        principalTable: "Actions",
                        principalColumn: "Id");
                });
        }
    }
}
