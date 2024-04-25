using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_api_dnet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_CharacterId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Skills",
                newName: "HitPointId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_CharacterId",
                table: "Skills",
                newName: "IX_Skills_HitPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills",
                column: "HitPointId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "HitPointId",
                table: "Skills",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_HitPointId",
                table: "Skills",
                newName: "IX_Skills_CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_CharacterId",
                table: "Skills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
