using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance

    {
        const int  FULL_DAY_HR = 8 , PART_DAY_HR = 4, IS_FULL_TIME =0 , IS_PART_TIME = 1 ;
        int totalEmpWage = 0 ,empHrs = 0,wagePerHr, totalWorkingDays,totalWorkingHrs,total_Employee_Wage ;
        string comapanyName = "";
        Random random = new Random();

        
        public EmployeeAttendance()
        {
            Console.WriteLine("Enter company name");
            this.comapanyName = Console.ReadLine();
            Console.WriteLine("Wages per hour");
            this.wagePerHr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NUmber of working days");
            this.totalWorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total working hours");
            this.totalWorkingHrs = Convert.ToInt32(Console.ReadLine());
        }
        public void EmpAttendanceAttendance() {
          
            int empCheck = random.Next(0,2); //return 0 or  1
            if (empCheck == 0)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }
        public void CalculateEmpWage() {
            
           
            for (int day = 0; day < totalWorkingDays  &&  empHrs < totalWorkingHrs; day++)
            {
                int empCheck = random.Next(0, 3);//0 1 2
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;

                    case IS_PART_TIME:
                        empHrs += PART_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;


                }
            }

            // int totalEmpWage = empHrs * wagePerHr;
            // Console.WriteLine(comapanyName+"---->"+totalEmpWage);
            total_Employee_Wage = wagePerHr * empHrs;
            Console.WriteLine("Daily wages of "+this.comapanyName+" is " + total_Employee_Wage);
        }
        
    }
}
