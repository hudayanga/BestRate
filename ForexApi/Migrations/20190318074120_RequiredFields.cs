using Microsoft.EntityFrameworkCore.Migrations;

namespace ForexApi.Migrations
{
    public partial class RequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Partner",
                table: "Rates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Partner",
                table: "Rates",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
