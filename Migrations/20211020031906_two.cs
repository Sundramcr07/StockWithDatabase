using Microsoft.EntityFrameworkCore.Migrations;

namespace StockWithDatabase.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedicineName",
                table: "MedicineStock",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MedicineStock",
                newName: "MedicineName");
        }
    }
}
