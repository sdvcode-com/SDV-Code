using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeletedPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeletedPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeleteOwnPostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteOwnPostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeleteOwnPostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeletePostActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReasonToBeDeleted = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletePostActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeletePostActions_BasePostActions_Id",
                        column: x => x.Id,
                        principalTable: "BasePostActions",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeletedPostActions");

            migrationBuilder.DropTable(
                name: "DeleteOwnPostActions");

            migrationBuilder.DropTable(
                name: "DeletePostActions");
        }
    }
}
