using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeOfficeApp.Migrations
{
    public partial class addingCurrencyTypeIntoReceipModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyType",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyType",
                table: "Receipts");
        }
    }
}
