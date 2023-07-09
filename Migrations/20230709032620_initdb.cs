using System;
using Bogus;
using Microsoft.EntityFrameworkCore.Migrations;
using razorweb.models;

#nullable disable

namespace razorweb.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.Id);
                });

            Randomizer.Seed = new Random(8675309);
            var fakerAritcle = new Faker<Article>();
            fakerAritcle.RuleFor(a => a.Title, f => f.Lorem.Sentence(10, 2));
            fakerAritcle.RuleFor(a => a.Create, f => f.Date.Between(new DateTime(2023, 1, 1), new DateTime(2025, 1, 1)));
            fakerAritcle.RuleFor(a => a.Content, f => f.Lorem.Paragraphs(1, 4));

            Article article = fakerAritcle.Generate();



            for (int i = 0; i < 150; i++)
            {
                migrationBuilder.InsertData(
                table: "articles",
                columns: new[] { "Title", "Create", "Content" },
                values: new object[]{
                        article.Title,
                        article.Create,
                        article.Content
                }
            );
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articles");
        }
    }
}
