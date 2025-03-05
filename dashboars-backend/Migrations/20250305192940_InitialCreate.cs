using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dashboars_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Icon", "Label", "Path" },
                values: new object[,]
                {
                    { 1, "fa-chart-bar", "Dashboard", "/dashboard" },
                    { 2, "fa-gear", "Settings", "/settings" },
                    { 3, "fa-user", "Profile", "/profile" },
                    { 4, "fa-diagram-project", "Projects", "/projects" },
                    { 5, "fa-graduation-cap", "Courses", "/courses" },
                    { 6, "fa-circle-user", "Friends", "/friends" },
                    { 7, "fa-file", "Files", "/files" },
                    { 8, "fa-credit-card", "Plans", "/plans" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");
        }
    }
}
