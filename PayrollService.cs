using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollService
{
    internal class PayrollService
    {
        public int Columns_Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public DateTime StartDate{ get; set; }
        public int Note_Id { get; set; }
    }
}
