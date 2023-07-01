using System;

namespace EmployeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Payroll.createdatabase();
            //Payroll.createtable();
            //Payroll.insert();
            //Payroll.retrievedata();
            //Payroll.RetrieveSalaryData("MadhurVerma");
            DateTime StartDate = new DateTime(2020,2,2);
            DateTime EndDate = DateTime.Now;
            Payroll.RetrieveEmployeesByDateRange(StartDate,EndDate);
        }
    }
}
