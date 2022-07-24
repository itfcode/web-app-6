using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITFCodeWA.Domain.Migrations.LifeDbContext
{
    public partial class Test02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "dbo",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_Name",
                schema: "dbo",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "dbo",
                newName: "Persons",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                schema: "dbo",
                table: "Persons",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(99)",
                oldMaxLength: 99);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "dbo",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                schema: "dbo",
                table: "Persons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Food",
                schema: "dbo",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proteins = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Fats = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Calories = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_Name",
                schema: "dbo",
                table: "Food",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "dbo",
                newName: "Person",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Person",
                newName: "PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Person",
                type: "nvarchar(99)",
                maxLength: 99,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "dbo",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "dbo",
                table: "Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Name",
                schema: "dbo",
                table: "Person",
                column: "Name",
                unique: true);
        }
    }
}
