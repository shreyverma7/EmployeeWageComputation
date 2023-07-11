using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance

    {
        const int WAGE_PER_HR = 20 , WAGE_PER_DAY = 8 ;
        public void EmpAttendance() {
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == 0)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }
        public void CalculateEmpWage() {
            int dailyEmpwage = WAGE_PER_DAY * WAGE_PER_HR;
            Console.WriteLine(dailyEmpwage);

        }
    }
}
