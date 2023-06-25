using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollService
{
    internal class Payroll
    {
        public static void createdatabase()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"data source=DESKTOP-SAGJTNV\SQLEXPRESS;initial catalog=master;integrated security=true");
                con.Open();
                string query = "create database payroll_service;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database created Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static SqlConnection con = new SqlConnection(@"data source=DESKTOP-SAGJTNV\SQLEXPRESS;initial catalog=payroll_service;integrated security=true");
        public static void createtable()
        {
            try
            {
                con.Open();
                string query = "create table employee_payroll(" +
                    "Columns_Id int identity(1,1) Primary key," +
                    "Name varchar(20)," +
                    "Salary int," +
                    "StartDate date," +
                    "Gender varchar(200)," +
                    "Phone int," +
                    "Address varchar (200)," +
                    "Department varchar(200)," +
                    "Deduction int," +
                    "Taxable_Pay int," +
                    "Income_Tax int," +
                    "Net_Pay int," +
                    ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void insert()
        {
            try
            {
                PayrollService payroll = new PayrollService();
                Console.WriteLine("Enter Name : ");
                payroll.Name = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                payroll.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter StartDate (yyyy-MM-dd):");
                payroll.StartDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Gender: ");
                payroll.Gender = Console.ReadLine();
                Console.WriteLine("Enter Phone : ");
                payroll.Phone = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Address : ");
                payroll.Address = Console.ReadLine();
                Console.WriteLine("Enter department : ");
                payroll.Department = Console.ReadLine();
                Console.WriteLine("Enter Deduction : ");
                payroll.Deduction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Taxable pay : ");
                payroll.Taxable_Pay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter IncomeTax : ");
                payroll.Income_Tax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter NetPay : ");
                payroll.Net_Pay = Convert.ToInt32(Console.ReadLine());
                con.Open();
                string query = "insert into employee_payroll values('"+payroll.Name+"',"+payroll.Salary+",'"+payroll.StartDate+"','"+payroll.Gender+"',"+payroll.Phone+",'"+payroll.Address+"','"+payroll.Department+"',"+payroll.Deduction+","+payroll.Taxable_Pay+","+payroll.Income_Tax+","+payroll.Net_Pay+");";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted data Succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
