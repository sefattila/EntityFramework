using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.DAL.Migrations
{
    public partial class uiModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6989));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "TblActor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "TblCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "TblFilm",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "TblFilmActor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "TblFilmDetail",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 18, 28, 59, 592, DateTimeKind.Local).AddTicks(6180));
        }
    }
}
