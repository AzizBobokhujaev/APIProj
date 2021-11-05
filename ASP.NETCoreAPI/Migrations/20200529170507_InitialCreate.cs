using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NETCoreAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 1, "Альберт Эйнштейн", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Все мы гении. Но если вы будете судить рыбу по её способности взбираться на дерево, она проживёт всю жизнь, считая себя дурой." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 2, "Вера Полозкова", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Обязательно дружите с теми, кто лучше вас. Будете мучиться, но расти." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 3, "Джей Ди", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Важен тот человек, который приходит на помощь тогда, когда его даже не просят." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 4, "Люси Скетч", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Они улыбаются, когда ты звонишь им, но у них нет времени позвонить тебе." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 5, null, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Хорошие друзья, хорошие книги и спящая совесть – вот идеальная жизнь." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 6, null, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), "Трусливый друг страшнее врага, ибо врага опасаешься, а на друга надеешься." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
