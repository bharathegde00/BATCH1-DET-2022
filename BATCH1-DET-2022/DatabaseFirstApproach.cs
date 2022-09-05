using BATCH1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BATCH1_DET_2022
{
    class DatabaseFirstApproach
    {
        static void Main()
        {
            // GetAllEmpDetails();
            //  GetEmpDetailsByID();
            // AddNewEmployee();
            //RemoveNewEmployee();
            // UpdateEmployee();
            // GetSp();
            // getSPwithparam();
            // getSPWithoutpara();
            SPInsert();

            Console.ReadLine();

        }

        private static void UpdateEmployee()
        {
            var ctx = new Bharath_Tsql_TrainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2000;
                employee.Ename = "BharathS";
                employee.Sal = 35000;
                employee.Deptno = 10;
                employee.Job = "DET";
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("New Employee Updated");


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }

        private static void getSPWithoutpara()
        {
            var ctx = new Bharath_Tsql_TrainingContext();
            var employee = ctx.Emps.FromSqlRaw($"getempdetails").ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
        }

        private static void getSPwithparam()
        {
            var ctx = new Bharath_Tsql_TrainingContext();

            var employee = ctx.Emps.FromSqlRaw("getempname @p0", 7499).ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
        }

        private static void SPInsert()
        
            
        {
                    var ctx = new Bharath_Tsql_TrainingContext();
                    var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2233},


                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Bharat g"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Trainer"},

                          new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30000},

                           new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30 }

                           };
                    try
                    {

                var result = ctx.Database.ExecuteSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                //var result = ctx.Database.ExecuteSqlCommand("AddNewBook @id, @name, @price", param);
                //// var result = ctx.Emps.FromSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);
                //var result =ctx.Database.ExecuteSqlCommand("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                ctx.SaveChanges();
                        Console.WriteLine("inserted");
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }


                    Console.WriteLine("update successful");
        }


            



        





    }
}
