using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class xxxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyAnswers_Answers_AnswerId",
                table: "ReplyAnswers");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyAnswers_Answers_AnswerId",
                table: "ReplyAnswers",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyAnswers_Answers_AnswerId",
                table: "ReplyAnswers");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyAnswers_Answers_AnswerId",
                table: "ReplyAnswers",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id");
        }
    }
}
