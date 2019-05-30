using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.Migrations
{
    public partial class FeedbackHeadeFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContantMe",
                table: "Feedbacks",
                newName: "ContactMe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactMe",
                table: "Feedbacks",
                newName: "ContantMe");
        }
    }
}
