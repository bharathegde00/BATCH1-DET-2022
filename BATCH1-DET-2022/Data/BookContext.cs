using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BATCH1_DET_2022.Models;


namespace BATCH1_DET_2022.Data
{
    public class BookContext : DbContext
    {

        public BookContext()
            {



            }

            public BookContext(DbContextOptions<BookContext> options)
                  : base(options)
            {
            }

     public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

            optionsBuilder.UseSqlServer("Server=6BRWQG2-SHEL\\SQLEXPRESS;Database=Bharath_Tsql_Training;Trusted_Connection=True;");
        }
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                   .Property(b => b.price)
                   .IsRequired()
                   .HasColumnName("BKprice")
                   .HasDefaultValue(200);

        }
        public static void  Main()
        {


        }


    }
}
