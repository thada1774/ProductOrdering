using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductOrdering.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Aumphures_AumphureId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_AumphureId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "AumphureId",
                table: "Districts");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_Aumphure_id",
                table: "Districts",
                column: "Aumphure_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Aumphures_Aumphure_id",
                table: "Districts",
                column: "Aumphure_id",
                principalTable: "Aumphures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Aumphures_Aumphure_id",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_Aumphure_id",
                table: "Districts");

            migrationBuilder.AddColumn<int>(
                name: "AumphureId",
                table: "Districts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_AumphureId",
                table: "Districts",
                column: "AumphureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Aumphures_AumphureId",
                table: "Districts",
                column: "AumphureId",
                principalTable: "Aumphures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
