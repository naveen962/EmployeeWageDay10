using System;

namespace EmployeeCheck
{
    class Program
    {
        public void DailyWages()
        {
            int wage_per_hour = 20;
            int fulltime = 8;
            //Random object created
            Random ran = new Random();
            int EmpCheck = ran.Next(0, 2);

            //condition
            if (EmpCheck == 1)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
                int DailyWages = wage_per_hour * fulltime;
                Console.WriteLine("Daily wage = " + DailyWages);
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }



        static void Main(string[] args)
        {
            //object created
            Program p = new Program();
            p.DailyWages();
        }
    }
}

