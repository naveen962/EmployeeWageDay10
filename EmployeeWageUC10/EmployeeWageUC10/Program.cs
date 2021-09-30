using System;

namespace EmployeeWageUC10
{
    class CompanyEmpWage
    {


        public string company;
        public int Emp_Wage_Per_Hour;
        public int Num_Of_Working_Days;
        public int Max_Hours_Per_Month;
        public int TotalEmpwage;
        public CompanyEmpWage(string company, int Emp_Wage_Per_Hour, int Num_Of_Working_Days, int Max_Hours_Per_Month)
        {
            this.company = company;
            this.Emp_Wage_Per_Hour = Emp_Wage_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hours_Per_Month = Max_Hours_Per_Month;
        }
        public void setTotalEmpWage(int TotalEmpwage)
        {
            this.TotalEmpwage = TotalEmpwage;
        }
        public string toString()
        {
            return "Total Employee wage for company :" + this.company + "is : " + this.TotalEmpwage;

        }
    }
    public class EmpWageBuilderArray 
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        private CompanyEmpWage[] CompanyEmpWageArray;
        public int numofcompany;
        public int Max_Hours_Per_Month;
        public int Num_Of_Working_Days;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int Emp_Wage_Per_Hour, int Num_Of_Working_Days, int Max_Hours_Per_Month)
        {
            CompanyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, Emp_Wage_Per_Hour, Num_Of_Working_Days, Max_Hours_Per_Month);
            numofcompany++;
        }
        public void ComputeEmpWage()
        {
            for(int i=0;i<numofcompany;i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));

            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
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

            return Totalworkhrs * companyEmpWage.Emp_Wage_Per_Hour;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart",20,2,10);
             empWageBuilder.addCompanyEmpWage("Apple",20,2,10);
            empWageBuilder.ComputeEmpWage();
        }
    }
}
