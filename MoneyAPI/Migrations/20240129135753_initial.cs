using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseDatas",
                columns: table => new
                {
                    MonthName = table.Column<string>(type: "text", nullable: false),
                    Personal = table.Column<int>(type: "integer", nullable: false),
                    Investment = table.Column<int>(type: "integer", nullable: false),
                    Luxury = table.Column<int>(type: "integer", nullable: false),
                    Food = table.Column<int>(type: "integer", nullable: false),
                    Miscellaneous = table.Column<int>(type: "integer", nullable: false),
                    FirstExpenseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LatestExpenseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfExpenses = table.Column<int>(type: "integer", nullable: false),
                    TotalAmount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseDatas", x => x.MonthName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseDatas");
        }
    }
}
