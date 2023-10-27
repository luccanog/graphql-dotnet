using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL.Dotnet.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingCategoryColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ImagemUrl",
                table: "Categories",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Categories",
                newName: "ImagemUrl");
        }
    }
}
