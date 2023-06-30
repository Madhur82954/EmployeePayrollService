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
                string query = "create table employee_payroll(Columns_Id int identity(1,1) Primary key,Name varchar(20),Salary int,Gender varchar(20),Phone varchar(50),Address varchar (100),Department varchar(20),Deduction int,Taxable_Pay int,Income_Tax int,Net_Pay int);";
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
                Console.WriteLine("Enter StartDate :");
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
                string query = "insert into employee_payroll values('"+payroll.Name+"',"+payroll.Salary+",'"+payroll.StartDate+"','"+payroll.Gender+"','"+payroll.Phone+"','"+payroll.Address+"','"+payroll.Department+"',"+payroll.Deduction+","+payroll.Taxable_Pay+","+payroll.Income_Tax+","+payroll.Net_Pay+");";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Inserted data Succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error has occured"+e.Message);
            }
        }
        public static void retrievedata()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM employee_payroll";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Records from employeePayroll table:");
                    while (reader.Read())
                    {
                        int columnsId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string salary = reader.GetString(2);
                        DateTime startDate = reader.GetDateTime(3);
                        string gender = reader.GetString(4);
                        int phone = reader.GetInt32(5);
                        string address = reader.GetString(6);
                        string department = reader.GetString(7);
                        int deduction = reader.GetInt32(8);
                        int taxablePay = reader.GetInt32(9);
                        int incomeTax = reader.GetInt32(10);
                        int netPay = reader.GetInt32(11);

                        Console.WriteLine($"{columnsId}\t\t{name}\t{salary}\t{startDate.ToShortDateString()}\t{gender}\t{phone}\t{address}\t{department}\t{deduction}\t{taxablePay}\t{incomeTax}\t{netPay}");
                    }
                }
                else
                {
                    Console.WriteLine("No records found in the employeePayroll table.");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
