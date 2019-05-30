using Microsoft.EntityFrameworkCore.Migrations;

namespace UI.Migrations
{
    public partial class AddedValidatonAttributesForFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Feedbacks",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Feedbacks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Feedbacks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Feedbacks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
