using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_lojaKX.Migrations
{
    public partial class ModifyingTablePurchases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf_Client",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf_Client",
                table: "Purchases");
        }
    }
}
