using System;

namespace EmployeeWageUC9
{
    class EmployeeBuilderObj
    {

        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private string company;
        private int Emp_Wage_Per_Hour;
        private int Num_Of_Working_Days;
        private int Max_Hours_Per_Month;
        private int TotalEmpwage;
        public EmployeeBuilderObj(string company, int Emp_Wage_Per_Hour, int Num_Of_Working_Days, int Max_Hours_Per_Month)
        {
            this.company = company;
            this.Emp_Wage_Per_Hour = Emp_Wage_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hours_Per_Month = Max_Hours_Per_Month;
        }
        public void ComputeEmpWage()
        {
            int EmpHours = 0, Totalworkhrs = 0, totalworkingdays = 0;
            while (Totalworkhrs <= Max_Hours_Per_Month && totalworkingdays < Num_Of_Working_Days)
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
                        Console.WriteLine("FULL TIME");
                        EmpHours = 8;
                        break;
                    default:
                        Console.WriteLine("ABSENT");
                        EmpHours = 0;
                        break;

                }
                totalworkingdays++;
                Totalworkhrs += EmpHours;
                Console.WriteLine("Day#:" + totalworkingdays + "Emp Hrs :" + EmpHours);
            }

            TotalEmpwage = Totalworkhrs * this.Emp_Wage_Per_Hour;
            Console.WriteLine(company + "TOTAL WAGES =" + TotalEmpwage);
        }

            public string toString()
            {
            return "Total Employee wage for company :" + this.company + "is : " + this.TotalEmpwage;

            }

        
    }
       
    class Program
    { 
        static void Main(string[] args)
        {
            EmployeeBuilderObj obj1 = new EmployeeBuilderObj("Apple", 20, 2, 10);
            obj1. ComputeEmpWage();
            Console.WriteLine(obj1.toString());
            EmployeeBuilderObj obj2 = new EmployeeBuilderObj("Raymond", 20, 2, 10);
            obj2.ComputeEmpWage();
            Console.WriteLine(obj2.toString());
            
        }
    }
}
