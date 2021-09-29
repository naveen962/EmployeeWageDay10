using System;

namespace EmployeeCheck
{
    class Program
    {
       
        public void check()
        {
            //Random object created
            Random ran = new Random();
            int EmpCheck = ran.Next(0, 2);
            int Fulltime = 1;
            //condition
            if (EmpCheck == Fulltime)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.check();


        }
    }

}
