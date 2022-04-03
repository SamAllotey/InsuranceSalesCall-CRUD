using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MariaAndSonsInsLtd.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Callers",
                columns: table => new
                {
                    CallerId = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CallerName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CallDuration = table.Column<double>(type: "float", nullable: false),
                    CallDestinationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallCost = table.Column<double>(type: "float", nullable: false),
                    CallType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallPlan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Callers", x => x.CallerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Callers");
        }
    }
}
