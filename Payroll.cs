using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollService
{
    internal class Payroll
    {
        
        public static SqlConnection con = new SqlConnection(@"data source=DESKTOP-SAGJTNV\SQLEXPRESS;initial catalog=payroll_service;integrated security=true");

        
    }
}
