using BookLibraryRepoPetternCore.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryRepoPetternCore
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options){}

        public DbSet<Book> Books { get; set; } = null;
        public DbSet<Tbl_Author>  tbl_Authors{ get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "server=damilareLappy; Database=BookLibraryRepoPettern_DB;Trusted_connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Eternal secred king",
                Author = "Damilare oladele",
                Genre = "Asian",

                Description = "Display info about the Book.",

                PublishDate = DateTime.Now,
            },


            new Book
            {
                Id = 2,
                Title = "Legend of swordsMan",
                Author = "James wood",
                Genre = "Cultivation",
                Description = "Display info about the Book.",

                PublishDate = DateTime.Now,
            },

              new Book
              {
                  Id = 3,
                  Title = "Walker of Worlds",
                  Author = "muller james",
                  Genre = "Cultivation",
                  Description = "Display info about the Book.",

                  PublishDate = DateTime.Now,
              },

               new Book
               {
                   Id = 4,
                   Title = "Emperor Dominations",
                   Author = "Ibrahim Oloto",
                   Genre = "Cultivation",
                   Description = "Display info about the Book.",

                   PublishDate = DateTime.Now,
               },
                   new Book
                   {
                       Id = 5,
                       Title = "Loaded With Persive Skills",
                       Author = "chen Ming",
                       Genre = "Asian",
                       Description = "Display info about the Book.",

                       PublishDate = DateTime.Now,
                      
                   });
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Tbl_Author>().HasMany(AuthorId => tbl_Authors).WithMany(name => tbl_Authors).UsingEntity(j => j.ToTable("TBl_Authors"));
        //}
    }
}
