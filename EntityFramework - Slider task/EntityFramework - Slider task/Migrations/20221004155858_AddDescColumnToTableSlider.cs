using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework___Slider_task.Migrations
{
    public partial class AddDescColumnToTableSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Sliders");
        }
    }
}
