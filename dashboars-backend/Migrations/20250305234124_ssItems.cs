using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dashboars_backend.Migrations
{
    /// <inheritdoc />
    public partial class ssItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SettingsItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingsItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SettingsItems",
                columns: new[] { "Id", "Icon", "Link", "Name" },
                values: new object[,]
                {
                    { 1, "fa-regular fa-chart-bar", "index", "Dashboard" },
                    { 2, "fa-solid fa-gear", "settings", "Settings" },
                    { 3, "fa-regular fa-user", "profile", "Profile" },
                    { 4, "fa-solid fa-diagram-project", "projects", "Projects" },
                    { 5, "fa-solid fa-graduation-cap", "courses", "Courses" },
                    { 6, "fa-regular fa-circle-user", "friends", "Friends" },
                    { 7, "fa-regular fa-file", "files", "Files " },
                    { 8, "fa-regular fa-credit-card", "plans", "Plans " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SettingsItems");
        }
    }
}
