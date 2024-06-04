using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCSD_Police_Compaint_Form.Data.Migrations
{
    /// <inheritdoc />
    public partial class formScaffold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationOfIncident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintTypes = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfIncident = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfEmployees = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailsToHelpIdentifyEmployee = table.Column<string>(type: "text", nullable: false),
                    SummaryOfComplaint = table.Column<string>(type: "text", nullable: false),
                    Witnesses = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");
        }
    }
}
