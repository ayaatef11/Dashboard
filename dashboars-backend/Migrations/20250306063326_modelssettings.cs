using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dashboars_backend.Migrations
{
    /// <inheritdoc />
    public partial class modelssettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackupTimes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placeholder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disabled = table.Column<bool>(type: "bit", nullable: false),
                    ShowLink = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placeholder = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BackupTimes",
                columns: new[] { "Id", "Checked", "Label" },
                values: new object[,]
                {
                    { "daily", true, "Daily" },
                    { "monthly", false, "Monthly" },
                    { "weekly", false, "Weekly" }
                });

            migrationBuilder.InsertData(
                table: "GeneralInfos",
                columns: new[] { "Id", "Disabled", "Label", "Placeholder", "ShowLink", "Type", "Value" },
                values: new object[,]
                {
                    { "email", true, "Email", "Email", true, "email", "o@nn.sa" },
                    { "first", false, "First Name", "First Name", false, "text", "" },
                    { "last", false, "Last Name", "Last Name", false, "text", "" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Checked", "Name" },
                values: new object[,]
                {
                    { "server-one", false, "Megaman" },
                    { "server-three", false, "Sigma" },
                    { "server-two", true, "Zero" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Placeholder" },
                values: new object[,]
                {
                    { "facebook", "fa-facebook-f", "Facebook Username" },
                    { "linkedin", "fa-linkedin", "LinkedIn Username" },
                    { "twitter", "fa-twitter", "Twitter Username" },
                    { "youtube", "fa-youtube", "YouTube Username" }
                });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Checked", "Name" },
                values: new object[,]
                {
                    { "five", false, "Latest Tasks" },
                    { "four", true, "Latest News" },
                    { "one", true, "Quick Draft" },
                    { "six", true, "Top Search Items" },
                    { "three", true, "Tickets Statistics" },
                    { "two", true, "Yearly Targets" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupTimes");

            migrationBuilder.DropTable(
                name: "GeneralInfos");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Widgets");
        }
    }
}
