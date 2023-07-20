using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
   
        public class EmpWageBuilder
        {
            EmployeeAttendance[] companyArray = new EmployeeAttendance[10];
            int numofcompany = 0;

            public void AddToCompanyArray(string companyname, int wageperhr, int totalWorkingdays, int totalworkinghrs)
            {
                companyArray[numofcompany] = new EmployeeAttendance(companyname, wageperhr, totalWorkingdays, totalworkinghrs);
                numofcompany++;
            }
            public void CalculateWage()
            {
                for (int i = 0; i < numofcompany; i++)
                {
                    EmployeeAttendance empwage = companyArray[i];
                    empwage.CalculateEmpWage();
                }
            }
        }
}

