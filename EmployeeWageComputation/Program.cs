using EmployeeWageComputation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wages");
        EmployeeAttendance applewagess = new EmployeeAttendance("Apple",100,20,100);
      //  employeeAttendance.EmpAttendance();
        applewagess.CalculateEmpWage();

        EmployeeAttendance samsumgwages = new EmployeeAttendance("Samsumg", 80, 25, 150);
        //  employeeAttendance.EmpAttendance();
        samsumgwages.CalculateEmpWage();
    }
}