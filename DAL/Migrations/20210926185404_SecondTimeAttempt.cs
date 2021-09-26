using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SecondTimeAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Books_Id", "Author_Firstname", "Author_Lastname", "BookRatings_Id", "MyImpressions", "Title" },
                values: new object[] { 1, "John", "Doe", null, null, "13km under pressure" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Books_Id",
                keyValue: 1);
        }
    }
}
