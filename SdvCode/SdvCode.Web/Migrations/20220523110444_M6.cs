using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikePostActions_Actions_Id",
                table: "LikePostActions");

            migrationBuilder.DropTable(
                name: "UsersActions");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.CreateTable(
                name: "WebsiteActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActionStatus = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsiteActions_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WebsiteActions_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WebsiteActions_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteActions_OwnerId",
                table: "WebsiteActions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteActions_ReceiverId",
                table: "WebsiteActions",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikePostActions_WebsiteActions_Id",
                table: "LikePostActions",
                column: "Id",
                principalTable: "WebsiteActions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikePostActions_WebsiteActions_Id",
                table: "LikePostActions");

            migrationBuilder.DropTable(
                name: "WebsiteActions");

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActionStatus = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_BaseData_Id",
                        column: x => x.Id,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsersActions",
                columns: table => new
                {
                    ActionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersActions", x => new { x.ActionId, x.OwnerId, x.ReceiverId });
                    table.ForeignKey(
                        name: "FK_UsersActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersActions_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersActions_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersActions_OwnerId",
                table: "UsersActions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersActions_ReceiverId",
                table: "UsersActions",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikePostActions_Actions_Id",
                table: "LikePostActions",
                column: "Id",
                principalTable: "Actions",
                principalColumn: "Id");
        }
    }
}
