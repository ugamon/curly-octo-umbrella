using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroAttributes",
                columns: table => new
                {
                    HeroAttributeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hp = table.Column<double>(type: "REAL", nullable: false),
                    Mana = table.Column<double>(type: "REAL", nullable: false),
                    Exp = table.Column<double>(type: "REAL", nullable: false),
                    Dex = table.Column<double>(type: "REAL", nullable: true),
                    Str = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroAttributes", x => x.HeroAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "HeroClasses",
                columns: table => new
                {
                    HeroClassModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HeroClassName = table.Column<string>(type: "TEXT", nullable: true),
                    HeroAttributeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroClasses", x => x.HeroClassModelId);
                    table.ForeignKey(
                        name: "FK_HeroClasses_HeroAttributes_HeroAttributeId",
                        column: x => x.HeroAttributeId,
                        principalTable: "HeroAttributes",
                        principalColumn: "HeroAttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroClasses_HeroAttributeId",
                table: "HeroClasses",
                column: "HeroAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroClasses");

            migrationBuilder.DropTable(
                name: "HeroAttributes");
        }
    }
}
