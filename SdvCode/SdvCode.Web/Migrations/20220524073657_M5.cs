using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChangeProfileCoverImageActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserCoverImageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeProfileCoverImageActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeProfileCoverImageActions_UserCoverImages_UserCoverImageId",
                        column: x => x.UserCoverImageId,
                        principalTable: "UserCoverImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChangeProfileCoverImageActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeProfileImageActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserProfileImageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeProfileImageActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeProfileImageActions_UserProfileImages_UserProfileImageId",
                        column: x => x.UserProfileImageId,
                        principalTable: "UserProfileImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChangeProfileImageActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EditPersonalDataActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditPersonalDataActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditPersonalDataActions_WebsiteActions_Id",
                        column: x => x.Id,
                        principalTable: "WebsiteActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProfileCoverImageActions_UserCoverImageId",
                table: "ChangeProfileCoverImageActions",
                column: "UserCoverImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeProfileImageActions_UserProfileImageId",
                table: "ChangeProfileImageActions",
                column: "UserProfileImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeProfileCoverImageActions");

            migrationBuilder.DropTable(
                name: "ChangeProfileImageActions");

            migrationBuilder.DropTable(
                name: "EditPersonalDataActions");
        }
    }
}