using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2demo3
{
    internal class Analyst : Employee
    {
        public string ProjectId;
        public string Technology;
        public int VariablePay = 8000;

        public void GetAnalystDetails()
        {
            EmployeeId = 101;
            EmployeeName = "Prajwal";
            EmailId = "pvhiremath@gmail.com";
            ContactNumber = 12345678;
            ProjectId = "DTA";
            Technology = "Microsoft stream";


        }
        public void PrintDetails()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} ",EmployeeId , EmployeeName , EmailId , ContactNumber , 
                ProjectId , Technology);
        }
        public override double CalculateSalary()
        {
            return base.CalculateSalary() + VariablePay;
        }
    }
}
