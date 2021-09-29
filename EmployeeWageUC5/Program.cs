using System;

namespace EmployeeWageUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWages.UseCase5 uc = new EmpWages.UseCase5();
            uc.AddPartimeEmp();
        }
    }
}
