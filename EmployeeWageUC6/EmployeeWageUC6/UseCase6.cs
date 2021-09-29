using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUC6
{
    class UseCase6
    {
        public void TotalEmpWages()

        {
            int EMPWAGE_PER_HOUR = 20;
            int Num_Working_of_days = 20;
            int max_work_hrs_month = 100;

            //variables
            int EmpHours = 0;
            int Empwage = 0;
            int Totalwages = 0;
            int Totalworkhrs = 0;
            int totalworkingdays = 0;


            //computation
            while (Totalworkhrs <= max_work_hrs_month && totalworkingdays < Num_Working_of_days)
            {
                Random ran = new Random();
                int Empcheck = ran.Next(0, 3);
                switch (Empcheck)
                {
                    case 1:
                        Console.WriteLine("PART TIME");
                        EmpHours = 4;
                        break;

                    case 2:
                        Console.WriteLine("FULL Time");
                        EmpHours = 8;
                        break;
                    default:
                        Console.WriteLine("ABSENT");
                        EmpHours = 0;
                        break;

                }
                totalworkingdays++;
                Totalworkhrs += EmpHours;

                Empwage = EmpHours * EMPWAGE_PER_HOUR;
                Console.WriteLine("EMPLOYEE WAGE =" + Empwage);
                Totalwages += Empwage;

            }
            Console.WriteLine("TOTAL WAGES =" + Totalwages);
        }
    }
}
