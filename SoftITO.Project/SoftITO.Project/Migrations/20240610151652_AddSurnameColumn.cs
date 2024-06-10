using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftITO.Project.Migrations
{
    /// <inheritdoc />
    public partial class AddSurnameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Author");
        }
    }
}
