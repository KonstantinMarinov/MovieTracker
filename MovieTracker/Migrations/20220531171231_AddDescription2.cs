using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTracker.Migrations
{
    public partial class AddDescription2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    movie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    watched_on = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    review_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    movie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    author = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    text = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.review_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
