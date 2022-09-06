using BATCH1_DET_2022.Data;
using BATCH1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BATCH1_DET_2022
{
    internal class codefirstapproach
    {
        private static void Main()
        {
            AddNewBook();
            //removebook();
            // updatebook();
            //selectbook();
            //getallbooks();
            Console.ReadLine();
        }

        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 6;
            book.BookName = "Sqlgrgrgrrgrgrgrg";
            book.author = "Bill";
            book.price = 200;


            try
            {
                ctx.Books.Add(book);
               

                ctx.SaveChanges();
                Console.WriteLine("New book added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        private static void removebook()
        {
            var ctx = new BookContext();
            var Books = ctx.Books.Where(b=>b.BookID == 7).SingleOrDefault();
           
            try
            {
                ctx.Remove(Books);
              
                ctx.SaveChanges();
                Console.WriteLine("New book removed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        private static void updatebook()
        {

            var ctx = new BookContext();
           
            var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();
            try
            {
                
                
                Books.price = 2000;
                ctx.Update(Books);
              
                ctx.SaveChanges();
              
                Console.WriteLine("New book updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }



        }

        private static void selectbook()
        {
            var ctx = new BookContext();

            var Books = ctx.Books.Where(b => b.BookID == 1).SingleOrDefault();
            try
            {                         

                ctx.SaveChanges();

                Console.WriteLine(Books.BookID  + "   "  + Books.BookName  +  "   "  +  Books.author  +  "  " +  Books.price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        private static void getallbooks()
        {
            var ctx = new BookContext();
            foreach (var book in ctx.Books)
            {
                Console.WriteLine(book.BookID + "   " + book.BookName + "   " + book.author + "  " + book.price);
            }


        }
    }
}
