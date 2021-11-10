using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudPeople.Migrations
{
    public partial class AddRelationOneCityHasManyPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cityId",
                table: "people",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_people_cityId",
                table: "people",
                column: "cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_people_cities_cityId",
                table: "people",
                column: "cityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict,
                onUpdate: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_people_cities_cityId",
                table: "people");

            migrationBuilder.DropIndex(
                name: "IX_people_cityId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "cityId",
                table: "people");
        }
    }
}
