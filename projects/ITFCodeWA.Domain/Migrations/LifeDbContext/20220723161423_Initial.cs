using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITFCodeWA.Domain.Migrations.LifeDbContext
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Contractor",
                schema: "dbo",
                columns: table => new
                {
                    ContractorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "dbo",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                    table.CheckConstraint("CK_Currency_Code", "Code > 0 AND Code < 999");
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItem",
                schema: "dbo",
                columns: table => new
                {
                    ExpenseItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseItem", x => x.ExpenseItemId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "dbo",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "RevenueItem",
                schema: "dbo",
                columns: table => new
                {
                    RevenueItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevenueItem", x => x.RevenueItemId);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                schema: "dbo",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FinishDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contract_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalSchema: "dbo",
                        principalTable: "Contractor",
                        principalColumn: "ContractorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "dbo",
                        principalTable: "Currency",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Good",
                schema: "dbo",
                columns: table => new
                {
                    GoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueItemId = table.Column<int>(type: "int", nullable: true),
                    ExpenseItemId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Good", x => x.GoodId);
                    table.ForeignKey(
                        name: "FK_Good_ExpenseItem_ExpenseItemId",
                        column: x => x.ExpenseItemId,
                        principalSchema: "dbo",
                        principalTable: "ExpenseItem",
                        principalColumn: "ExpenseItemId");
                    table.ForeignKey(
                        name: "FK_Good_RevenueItem_RevenueItemId",
                        column: x => x.RevenueItemId,
                        principalSchema: "dbo",
                        principalTable: "RevenueItem",
                        principalColumn: "RevenueItemId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ContractorId",
                schema: "dbo",
                table: "Contract",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CurrencyId",
                schema: "dbo",
                table: "Contract",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_FinishDate",
                schema: "dbo",
                table: "Contract",
                column: "FinishDate");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_Name",
                schema: "dbo",
                table: "Contract",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contract_StartDate",
                schema: "dbo",
                table: "Contract",
                column: "StartDate");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_Name",
                schema: "dbo",
                table: "Contractor",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Currency_Code",
                schema: "dbo",
                table: "Currency",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Currency_Name",
                schema: "dbo",
                table: "Currency",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Currency_ShortName",
                schema: "dbo",
                table: "Currency",
                column: "ShortName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItem_Name",
                schema: "dbo",
                table: "ExpenseItem",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Good_ExpenseItemId",
                schema: "dbo",
                table: "Good",
                column: "ExpenseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Good_Name",
                schema: "dbo",
                table: "Good",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Good_RevenueItemId",
                schema: "dbo",
                table: "Good",
                column: "RevenueItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Name",
                schema: "dbo",
                table: "Person",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RevenueItem_Name",
                schema: "dbo",
                table: "RevenueItem",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Good",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Contractor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExpenseItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RevenueItem",
                schema: "dbo");
        }
    }
}
