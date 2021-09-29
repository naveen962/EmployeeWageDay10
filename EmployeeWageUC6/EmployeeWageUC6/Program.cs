using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class Program
    {
        static void Main(string [] args)
        {
            EmployeeWageUC6.UseCase6 uc = new EmployeeWageUC6.UseCase6();
            uc.TotalEmpWages();
        }
    }
}
