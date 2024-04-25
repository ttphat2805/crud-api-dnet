using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_api_dnet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSkill_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "HitPointId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills",
                column: "HitPointId",
                principalTable: "Characters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "HitPointId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characters_HitPointId",
                table: "Skills",
                column: "HitPointId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
