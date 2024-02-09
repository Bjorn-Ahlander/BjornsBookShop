using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BjornsBookShop.Data.Migrations
{
    public partial class AddingPropTA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Transactions",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Transactions");
        }
    }
}
