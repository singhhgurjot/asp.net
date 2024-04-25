using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace BlogWebsite.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogModel_RegisterModel_UserId",
                table: "BlogModel");

            migrationBuilder.DropIndex(
                name: "IX_BlogModel_UserId",
                table: "BlogModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BlogModel_UserId",
                table: "BlogModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogModel_RegisterModel_UserId",
                table: "BlogModel",
                column: "UserId",
                principalTable: "RegisterModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
