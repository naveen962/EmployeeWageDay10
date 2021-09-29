using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class UseCase4
    {
        public void AddPartimeEmp()

        {
            //constants
            int EMPWAGE_PER_HOUR = 20;
            int Num_Working_of_days = 20;


            //variables
            int EmpHours = 0;
            int Empwage = 0;


            //computation
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

            Empwage = EmpHours * EMPWAGE_PER_HOUR;
            Console.WriteLine("EMPLOYEE WAGE =" + Empwage);

        }
        static void Main(string[] args)
        {
            UseCase4 uc4 = new UseCase4();
            uc4.AddPartimeEmp();
        }
    }
}
