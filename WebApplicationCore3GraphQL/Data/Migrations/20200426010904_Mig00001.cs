using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Mig00001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academy1CBGUs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academy1CBGUs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AcademyIncome1CBGUs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyСategory = table.Column<string>(nullable: false),
                    KindOfActivityСategory = table.Column<string>(nullable: false),
                    BudgetSPСategory = table.Column<string>(nullable: false),
                    BudgetIndicator = table.Column<double>(nullable: false),
                    EstimateIndicator = table.Column<double>(nullable: false),
                    CashIncomeIndicator = table.Column<double>(nullable: false),
                    DifferenceFromEstimateIndicator = table.Column<double>(nullable: false),
                    FormationDateReport = table.Column<DateTime>(nullable: false),
                    ReportDate = table.Column<DateTime>(nullable: false),
                    ReportPeriodStartDate = table.Column<DateTime>(nullable: false),
                    ReportPeriodEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyIncome1CBGUs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academy1CBGUs");

            migrationBuilder.DropTable(
                name: "AcademyIncome1CBGUs");
        }
    }
}
