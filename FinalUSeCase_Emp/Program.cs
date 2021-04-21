using System;

namespace FinalUSeCase_Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.addCompanyEmpWage("Microsoft", 4, 30, 100);
            empWageBuilder.addCompanyEmpWage("Google", 5, 40, 170);
            empWageBuilder.addCompanyEmpWage("Amazon", 19, 10, 150);
            empWageBuilder.computeEmpWage();
            //Console.WriteLine("Total Wage for DMart company: "+empWageBuilder.getTotalWage("DMart"));
            Console.ReadKey();
        }

    }
}
