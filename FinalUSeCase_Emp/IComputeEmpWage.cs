using System;
using System.Collections.Generic;
using System.Text;

namespace FinalUSeCase_Emp
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }

}
