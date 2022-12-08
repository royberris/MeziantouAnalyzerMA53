using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeziantouAnalyzerMA53.Migrations;

/// <inheritdoc />
public partial class Foo : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Foos",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Foos", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Foos");
    }
}
