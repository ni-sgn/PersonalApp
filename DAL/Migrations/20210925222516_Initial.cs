using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookRatings",
                columns: table => new
                {
                    BookRatings_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookRatings", x => x.BookRatings_Id);
                });

            migrationBuilder.CreateTable(
                name: "bookTypes",
                columns: table => new
                {
                    BookTypes_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookTypes", x => x.BookTypes_Id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Books_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author_Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author_Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyImpressions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookRatings_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Books_Id);
                    table.ForeignKey(
                        name: "FK_books_bookRatings_BookRatings_Id",
                        column: x => x.BookRatings_Id,
                        principalTable: "bookRatings",
                        principalColumn: "BookRatings_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookTypesBooks",
                columns: table => new
                {
                    BookTypes_Id = table.Column<int>(type: "int", nullable: false),
                    Books_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTypesBooks", x => new { x.BookTypes_Id, x.Books_Id });
                    table.ForeignKey(
                        name: "FK_BookTypesBooks_books_Books_Id",
                        column: x => x.Books_Id,
                        principalTable: "books",
                        principalColumn: "Books_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTypesBooks_bookTypes_BookTypes_Id",
                        column: x => x.BookTypes_Id,
                        principalTable: "bookTypes",
                        principalColumn: "BookTypes_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_BookRatings_Id",
                table: "books",
                column: "BookRatings_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTypesBooks_Books_Id",
                table: "BookTypesBooks",
                column: "Books_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTypesBooks");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "bookTypes");

            migrationBuilder.DropTable(
                name: "bookRatings");
        }
    }
}
