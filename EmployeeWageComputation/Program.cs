using EmployeeWageComputation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wages");
        //  EmployeeAttendance applewagess = new EmployeeAttendance("Apple",100,20,100);
        ////  employeeAttendance.EmpAttendance();
        //  applewagess.CalculateEmpWage();

        //  EmployeeAttendance samsumgwages = new EmployeeAttendance("Samsumg", 80, 25, 150);
        //  //  employeeAttendance.EmpAttendance();
        //  samsumgwages.CalculateEmpWage();

        EmpWageBuilder emp = new EmpWageBuilder();
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter input -->\n1.Add \n2.exit");
            int input =Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter company Name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter wage per hour :");
                    int wagePerHour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Total working days :");
                    int totalworkngdys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Total working Hours :");
                    int totalwokignhrs = Convert.ToInt32(Console.ReadLine());
                    emp.AddToCompanyArray(name, wagePerHour, totalworkngdys, totalwokignhrs);
                    emp.CalculateWage();
                    break;
                 case 2:
                    flag = false;    
                    break;

            }
        }
      
    }
}