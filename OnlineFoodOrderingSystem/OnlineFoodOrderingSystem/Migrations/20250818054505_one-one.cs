using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFoodOrderingSystem.Migrations
{
    /// <inheritdoc />
    public partial class oneone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_registerUser_roles_roleID",
                table: "registerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_userRole_registerUser_RegisterVMId",
                table: "userRole");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropIndex(
                name: "IX_userRole_RegisterVMId",
                table: "userRole");

            migrationBuilder.DropIndex(
                name: "IX_registerUser_roleID",
                table: "registerUser");

            migrationBuilder.DropColumn(
                name: "RegisterVMId",
                table: "userRole");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "userRole",
                newName: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterVM_RoleID",
                table: "registerUser",
                column: "roleID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterVM_UserRole",
                table: "registerUser",
                column: "roleID",
                principalTable: "userRole",
                principalColumn: "roleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterVM_UserRole",
                table: "registerUser");

            migrationBuilder.DropIndex(
                name: "IX_RegisterVM_RoleID",
                table: "registerUser");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "userRole",
                newName: "UserRoleId");

            migrationBuilder.AddColumn<int>(
                name: "RegisterVMId",
                table: "userRole",
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
                name: "IX_userRole_RegisterVMId",
                table: "userRole",
                column: "RegisterVMId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_userRole_registerUser_RegisterVMId",
                table: "userRole",
                column: "RegisterVMId",
                principalTable: "registerUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
