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
                string query = "create table employee_payroll(Columns_Id int identity(1,1) Primary key,Name varchar(20),Salary int,StartDate date,Note_Id int)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
