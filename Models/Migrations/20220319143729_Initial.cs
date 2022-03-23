using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaveName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartingElevens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingElevens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamesPlayedCurrentSeason = table.Column<int>(type: "int", nullable: false),
                    GamesPlayedAllTime = table.Column<int>(type: "int", nullable: false),
                    GoalsScoredCurrentSeason = table.Column<int>(type: "int", nullable: false),
                    GoalsScoredAllTime = table.Column<int>(type: "int", nullable: false),
                    CleanSheetsCurrentSeason = table.Column<int>(type: "int", nullable: false),
                    CleanSheetsAllTime = table.Column<int>(type: "int", nullable: false),
                    AssistsCurrentSeason = table.Column<int>(type: "int", nullable: false),
                    AssistsAllTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingElevenId = table.Column<int>(type: "int", nullable: true),
                    BenchId = table.Column<int>(type: "int", nullable: true),
                    ReservesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Benches_BenchId",
                        column: x => x.BenchId,
                        principalTable: "Benches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Squads_Reserves_ReservesId",
                        column: x => x.ReservesId,
                        principalTable: "Reserves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Squads_StartingElevens_StartingElevenId",
                        column: x => x.StartingElevenId,
                        principalTable: "StartingElevens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Potential = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StatsId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Position1 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Position2 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Position3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    BenchId = table.Column<int>(type: "int", nullable: true),
                    ReservesId = table.Column<int>(type: "int", nullable: true),
                    StartingElevenId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Benches_BenchId",
                        column: x => x.BenchId,
                        principalTable: "Benches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Reserves_ReservesId",
                        column: x => x.ReservesId,
                        principalTable: "Reserves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_StartingElevens_StartingElevenId",
                        column: x => x.StartingElevenId,
                        principalTable: "StartingElevens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Stats_StatsId",
                        column: x => x.StatsId,
                        principalTable: "Stats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClubStrength = table.Column<double>(type: "float", nullable: false),
                    SquadId = table.Column<int>(type: "int", nullable: true),
                    SaveId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Saves_SaveId",
                        column: x => x.SaveId,
                        principalTable: "Saves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clubs_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SaveId",
                table: "Clubs",
                column: "SaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SquadId",
                table: "Clubs",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_BenchId",
                table: "Players",
                column: "BenchId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ReservesId",
                table: "Players",
                column: "ReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_StartingElevenId",
                table: "Players",
                column: "StartingElevenId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_StatsId",
                table: "Players",
                column: "StatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_BenchId",
                table: "Squads",
                column: "BenchId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_ReservesId",
                table: "Squads",
                column: "ReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_StartingElevenId",
                table: "Squads",
                column: "StartingElevenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Saves");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Benches");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "StartingElevens");
        }
    }
}
