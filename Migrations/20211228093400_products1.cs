using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sample1.Migrations
{
    public partial class products1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Price",
                table: "product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Product_Name",
                table: "product",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Product_Model",
                table: "product",
                newName: "Brand");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "product",
                newName: "Product_Price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "product",
                newName: "Product_Name");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "product",
                newName: "Product_Model");
        }
    }
}
