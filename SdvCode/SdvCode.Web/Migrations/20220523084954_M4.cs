using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdvCode.Web.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersActions_BaseData_Id",
                table: "UsersActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersActions",
                table: "UsersActions");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UsersActions",
                newName: "ActionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersActions",
                table: "UsersActions",
                columns: new[] { "ActionId", "OwnerId", "ReceiverId" });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.AddForeignKey(
                name: "FK_UsersActions_Actions_ActionId",
                table: "UsersActions",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersActions_Actions_ActionId",
                table: "UsersActions");

            migrationBuilder.DropTable(
                name: "MyFirstActions");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersActions",
                table: "UsersActions");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "UsersActions",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersActions",
                table: "UsersActions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersActions_BaseData_Id",
                table: "UsersActions",
                column: "Id",
                principalTable: "BaseData",
                principalColumn: "Id");
        }
    }
}
