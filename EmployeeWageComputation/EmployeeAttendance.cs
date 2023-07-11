using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance
    {
        public void EmpAttendance() {
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == 0)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }
    }
}
