using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ClubStrength = table.Column<double>(type: "float", nullable: false),
                    SaveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Saves_SaveId",
                        column: x => x.SaveId,
                        principalTable: "Saves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benches_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserves_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartingElevens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingElevens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartingElevens_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Value = table.Column<double>(type: "float", nullable: false),
                    Position1 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Position2 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Position3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    StartingElevenId = table.Column<int>(type: "int", nullable: true),
                    BenchId = table.Column<int>(type: "int", nullable: true),
                    ReservesId = table.Column<int>(type: "int", nullable: true)
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
                    AssistsAllTime = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benches_SquadId",
                table: "Benches",
                column: "SquadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SaveId",
                table: "Clubs",
                column: "SaveId");

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
                name: "IX_Reserves_SquadId",
                table: "Reserves",
                column: "SquadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Squads_ClubId",
                table: "Squads",
                column: "ClubId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StartingElevens_SquadId",
                table: "StartingElevens",
                column: "SquadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stats_PlayerId",
                table: "Stats",
                column: "PlayerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Benches");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "StartingElevens");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Saves");
        }
    }
}
