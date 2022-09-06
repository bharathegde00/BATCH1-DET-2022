using BATCH1_DET_2022.Data;
using BATCH1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BATCH1_DET_2022
{
    internal class EFonetomany
    {
        private static void Main()
        {
            // addnewcustandorder();
            // neworder();
            //orderinclude();
            // lateinclude();
            disconnarch();
            Console.ReadLine();

        }

        private static void addnewcustandorder()
        {
            var ctx = new BookContext();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Bharath";
            customer.Age = 22;

            Order ord= new Order();  
            ord.Order_ID = 100;
            ord.Amount = 5000;
            ord.OrderDate = DateTime.Now;

            ord.cust = customer;

            try 
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("Customer and Order is added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void neworder()
        {
            var ctx = new BookContext();
            Order ord = new Order();
            ord.Order_ID = 300;
            ord.Amount = 4000;
            ord.OrderDate = DateTime.Now;
            


            var neword = ctx.Customers.Where(o => o.ID== 1).SingleOrDefault();

            ord.cust = neword;

            try
            {
                ctx.Orders.Add(ord);


                ctx.SaveChanges();
                Console.WriteLine("New order added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        private static void orderinclude()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void lateinclude()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static void disconnarch()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Bharath";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }

}
