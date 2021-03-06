// <auto-generated />
using System;
using ASP.NETCoreAPI.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NETCoreAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200529170507_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("ASP.NETCoreAPI.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<DateTime>("InsertDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new { Id = 1, Author = "Альберт Эйнштейн", InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Все мы гении. Но если вы будете судить рыбу по её способности взбираться на дерево, она проживёт всю жизнь, считая себя дурой." },
                        new { Id = 2, Author = "Вера Полозкова", InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Обязательно дружите с теми, кто лучше вас. Будете мучиться, но расти." },
                        new { Id = 3, Author = "Джей Ди", InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Важен тот человек, который приходит на помощь тогда, когда его даже не просят." },
                        new { Id = 4, Author = "Люси Скетч", InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Они улыбаются, когда ты звонишь им, но у них нет времени позвонить тебе." },
                        new { Id = 5, InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Хорошие друзья, хорошие книги и спящая совесть – вот идеальная жизнь." },
                        new { Id = 6, InsertDate = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), Text = "Трусливый друг страшнее врага, ибо врага опасаешься, а на друга надеешься." }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
