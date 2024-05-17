using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class recommendationsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_BookId",
                table: "Recommendations",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Books_BookId",
                table: "Recommendations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Books_BookId",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_BookId",
                table: "Recommendations");
        }
    }
}
