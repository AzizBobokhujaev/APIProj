using ASP.NETCoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreAPI.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasData
                (
                new Quote()
                {
                    Id = 1,
                    Text = "Все мы гении. Но если вы будете судить рыбу по её способности взбираться на дерево, она проживёт всю жизнь, считая себя дурой.",
                    Author = "Альберт Эйнштейн",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 2,
                    Text = "Обязательно дружите с теми, кто лучше вас. Будете мучиться, но расти.",
                    Author = "Вера Полозкова",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 3,
                    Text = "Важен тот человек, который приходит на помощь тогда, когда его даже не просят.",
                    Author = "Джей Ди",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 4,
                    Text = "Они улыбаются, когда ты звонишь им, но у них нет времени позвонить тебе.",
                    Author = "Люси Скетч",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 5,
                    Text = "Хорошие друзья, хорошие книги и спящая совесть – вот идеальная жизнь.",
                    InsertDate = DateTime.Now.Date,
                },
                new Quote()
                {
                    Id = 6,
                    Text = "Трусливый друг страшнее врага, ибо врага опасаешься, а на друга надеешься.",
                    InsertDate = DateTime.Now.Date,
                }
                );
        }

    }
}
