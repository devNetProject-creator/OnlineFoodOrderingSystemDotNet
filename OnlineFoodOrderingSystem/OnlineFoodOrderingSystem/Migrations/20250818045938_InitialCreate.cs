using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFoodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "emailID",
                table: "registerUser",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "roleID",
                table: "registerUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.RoleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_registerUser_emailID",
                table: "registerUser",
                column: "emailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_registerUser_roleID",
                table: "registerUser",
                column: "roleID");

            migrationBuilder.AddForeignKey(
                name: "FK_registerUser_roles_roleID",
                table: "registerUser",
                column: "roleID",
                principalTable: "roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_registerUser_roles_roleID",
                table: "registerUser");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropIndex(
                name: "IX_registerUser_emailID",
                table: "registerUser");

            migrationBuilder.DropIndex(
                name: "IX_registerUser_roleID",
                table: "registerUser");

            migrationBuilder.DropColumn(
                name: "roleID",
                table: "registerUser");

            migrationBuilder.AlterColumn<string>(
                name: "emailID",
                table: "registerUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
