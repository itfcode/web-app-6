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
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                    table.CheckConstraint("CK_Currency_Code", "Code > 0 AND Code < 999");
                });

            migrationBuilder.CreateTable(
                name: "ExpenseGroup",
                schema: "dbo",
                columns: table => new
                {
                    ExpenseGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseGroup", x => x.ExpenseGroupId);
                });

            migrationBuilder.CreateTable(
                name: "FoodGroup",
                schema: "dbo",
                columns: table => new
                {
                    FoodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodGroup", x => x.FoodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "GoodGroup",
                schema: "dbo",
                columns: table => new
                {
                    GoodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodGroup", x => x.GoodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "dbo",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(29)", maxLength: 29, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(29)", maxLength: 29, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(29)", maxLength: 29, nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Utr = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(29)", maxLength: 29, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "RevenueGroup",
                schema: "dbo",
                columns: table => new
                {
                    RevenueGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevenueGroup", x => x.RevenueGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                schema: "dbo",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FinishDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
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
                name: "ExpenseItem",
                schema: "dbo",
                columns: table => new
                {
                    ExpenseItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    ExpenseGroupId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseItem", x => x.ExpenseItemId);
                    table.ForeignKey(
                        name: "FK_ExpenseItem_ExpenseGroup_ExpenseGroupId",
                        column: x => x.ExpenseGroupId,
                        principalSchema: "dbo",
                        principalTable: "ExpenseGroup",
                        principalColumn: "ExpenseGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                schema: "dbo",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Proteins = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Fats = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Calories = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    FoodGroupId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Food_FoodGroup_FoodGroupId",
                        column: x => x.FoodGroupId,
                        principalSchema: "dbo",
                        principalTable: "FoodGroup",
                        principalColumn: "FoodGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightRegistrator",
                schema: "dbo",
                columns: table => new
                {
                    WeightRegistratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateMonth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commited = table.Column<bool>(type: "bit", nullable: false),
                    Marked = table.Column<bool>(type: "bit", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightRegistrator", x => x.WeightRegistratorId);
                    table.ForeignKey(
                        name: "FK_WeightRegistrator_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RevenueItem",
                schema: "dbo",
                columns: table => new
                {
                    RevenueItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    RevenueGroupId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevenueItem", x => x.RevenueItemId);
                    table.ForeignKey(
                        name: "FK_RevenueItem_RevenueGroup_RevenueGroupId",
                        column: x => x.RevenueGroupId,
                        principalSchema: "dbo",
                        principalTable: "RevenueGroup",
                        principalColumn: "RevenueGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightRegistratorRows",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDay = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightRegistratorRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightRegistratorRows_WeightRegistrator_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "dbo",
                        principalTable: "WeightRegistrator",
                        principalColumn: "WeightRegistratorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Good",
                schema: "dbo",
                columns: table => new
                {
                    GoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    RevenueItemId = table.Column<int>(type: "int", nullable: false),
                    ExpenseItemId = table.Column<int>(type: "int", nullable: false),
                    GoodGroupId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "ExpenseItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Good_GoodGroup_GoodGroupId",
                        column: x => x.GoodGroupId,
                        principalSchema: "dbo",
                        principalTable: "GoodGroup",
                        principalColumn: "GoodGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Good_RevenueItem_RevenueItemId",
                        column: x => x.RevenueItemId,
                        principalSchema: "dbo",
                        principalTable: "RevenueItem",
                        principalColumn: "RevenueItemId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_ExpenseGroup_Name",
                schema: "dbo",
                table: "ExpenseGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItem_ExpenseGroupId",
                schema: "dbo",
                table: "ExpenseItem",
                column: "ExpenseGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItem_Name",
                schema: "dbo",
                table: "ExpenseItem",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodGroupId",
                schema: "dbo",
                table: "Food",
                column: "FoodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_Name",
                schema: "dbo",
                table: "Food",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodGroup_Name",
                schema: "dbo",
                table: "FoodGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Good_ExpenseItemId",
                schema: "dbo",
                table: "Good",
                column: "ExpenseItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Good_GoodGroupId",
                schema: "dbo",
                table: "Good",
                column: "GoodGroupId");

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
                name: "IX_GoodGroup_Name",
                schema: "dbo",
                table: "GoodGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FirstName",
                schema: "dbo",
                table: "Person",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LastName",
                schema: "dbo",
                table: "Person",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MiddleName",
                schema: "dbo",
                table: "Person",
                column: "MiddleName");

            migrationBuilder.CreateIndex(
                name: "IX_RevenueGroup_Name",
                schema: "dbo",
                table: "RevenueGroup",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RevenueItem_Name",
                schema: "dbo",
                table: "RevenueItem",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RevenueItem_RevenueGroupId",
                schema: "dbo",
                table: "RevenueItem",
                column: "RevenueGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightRegistrator_AuthorId",
                schema: "dbo",
                table: "WeightRegistrator",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightRegistrator_Date",
                schema: "dbo",
                table: "WeightRegistrator",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_WeightRegistrator_Number",
                schema: "dbo",
                table: "WeightRegistrator",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeightRegistrator_PersonId",
                schema: "dbo",
                table: "WeightRegistrator",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightRegistratorRows_DocumentId",
                schema: "dbo",
                table: "WeightRegistratorRows",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Food",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Good",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WeightRegistratorRows",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Contractor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FoodGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExpenseItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GoodGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RevenueItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WeightRegistrator",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExpenseGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RevenueGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "dbo");
        }
    }
}
