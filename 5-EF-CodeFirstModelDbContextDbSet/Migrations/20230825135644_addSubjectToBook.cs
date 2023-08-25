using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5_EF_CodeFirstModelDbContextDbSet.Migrations
{
    public partial class addSubjectToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Books");
        }
    }
}
