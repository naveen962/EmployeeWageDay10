using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class UseCase3
    {
        public  void AddPartimeEmp()

        {
            //constants
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int EMPWAGE_PER_HOUR = 20;

            //variables
            int EmpHours = 0;

            Random ran = new Random();
            int Empcheck = ran.Next(0, 3);
            if (Empcheck == PART_TIME)
            {
                EmpHours = 4;
            }
            else if (Empcheck == FULL_TIME)
            {
                EmpHours = 8;
            }
            else
            {
                EmpHours = 0;
                Console.WriteLine("ABSENT");

            }
            int Empwage = EmpHours * EMPWAGE_PER_HOUR;
            Console.WriteLine("EMPLOYEE WAGE =" + Empwage);
        }


        static void Main(string[] args)
        {
            UseCase3 uc = new UseCase3();
            uc.AddPartimeEmp();
            
          
        }
    }
}


