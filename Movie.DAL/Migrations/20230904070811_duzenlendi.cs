using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.DAL.Migrations
{
    public partial class duzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblActor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Biography = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblActor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblFilm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FilmDuration = table.Column<double>(type: "float", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFilm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFilm_TblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblFilmActor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    WorkDay = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFilmActor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFilmActor_TblActor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "TblActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblFilmActor_TblFilm_FilmId",
                        column: x => x.FilmId,
                        principalTable: "TblFilm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblFilmDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmDetails = table.Column<string>(type: "text", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFilmDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblFilmDetail_TblFilm_FilmId",
                        column: x => x.FilmId,
                        principalTable: "TblFilm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblActor",
                columns: new[] { "Id", "ActorName", "Biography", "BirthDate", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Leonardo DiCaprio", null, null, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8226), null, 0, null },
                    { 2, "Tom Hanks", null, null, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8277), null, 0, null },
                    { 3, "Michael Clarke Duncan", null, null, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8279), null, 0, null },
                    { 4, "Tom Hardy", null, null, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8281), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "TblCategory",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Drama", new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8742), null, 0, null },
                    { 2, "Action", new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8744), null, 0, null },
                    { 3, "Science Fiction", new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8746), null, 0, null },
                    { 4, "Comedy", new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8748), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "TblFilm",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "FilmDuration", "FilmName", "PublishDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8925), null, 2.5, "Cath Me If You Can", null, 0, null },
                    { 2, 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8927), null, 3.0, "Forest Gump", null, 0, null },
                    { 3, 3, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8929), null, 2.0, "Inception", null, 0, null },
                    { 4, 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8931), null, 2.2999999999999998, "The Green Mile", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "TblFilmActor",
                columns: new[] { "Id", "ActorId", "CreatedDate", "DeletedDate", "FilmId", "Status", "UpdatedDate", "WorkDay" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8617), null, 1, 0, null, null },
                    { 2, 2, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8621), null, 1, 0, null, null },
                    { 3, 2, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8622), null, 2, 0, null, null },
                    { 4, 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8624), null, 3, 0, null, null },
                    { 5, 4, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8626), null, 3, 0, null, null },
                    { 6, 2, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8627), null, 4, 0, null, null },
                    { 7, 3, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8629), null, 4, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "TblFilmDetail",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FilmDetails", "FilmId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8832), null, "DenemeDenemeDeneme", 1, 0, null },
                    { 2, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8834), null, "DenemeDenemeDeneme", 2, 0, null },
                    { 3, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8836), null, "DenemeDenemeDeneme", 3, 0, null },
                    { 4, new DateTime(2023, 9, 4, 10, 8, 11, 444, DateTimeKind.Local).AddTicks(8837), null, "DenemeDenemeDeneme", 4, 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblFilm_CategoryId",
                table: "TblFilm",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFilmActor_ActorId",
                table: "TblFilmActor",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFilmActor_FilmId",
                table: "TblFilmActor",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFilmDetail_FilmId",
                table: "TblFilmDetail",
                column: "FilmId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblFilmActor");

            migrationBuilder.DropTable(
                name: "TblFilmDetail");

            migrationBuilder.DropTable(
                name: "TblActor");

            migrationBuilder.DropTable(
                name: "TblFilm");

            migrationBuilder.DropTable(
                name: "TblCategory");
        }
    }
}
