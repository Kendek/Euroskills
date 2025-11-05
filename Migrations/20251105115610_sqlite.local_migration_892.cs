using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Euriskills.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_892 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orszagok",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    orszagNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orszagok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Szakmak",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    szakmaNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szakmak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versenyzok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    szakmaId = table.Column<string>(type: "TEXT", nullable: false),
                    orszagId = table.Column<string>(type: "TEXT", nullable: false),
                    Pont = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versenyzok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Versenyzok_Orszagok_orszagId",
                        column: x => x.orszagId,
                        principalTable: "Orszagok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Versenyzok_Szakmak_szakmaId",
                        column: x => x.szakmaId,
                        principalTable: "Szakmak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Versenyzok_orszagId",
                table: "Versenyzok",
                column: "orszagId");

            migrationBuilder.CreateIndex(
                name: "IX_Versenyzok_szakmaId",
                table: "Versenyzok",
                column: "szakmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Versenyzok");

            migrationBuilder.DropTable(
                name: "Orszagok");

            migrationBuilder.DropTable(
                name: "Szakmak");
        }
    }
}
