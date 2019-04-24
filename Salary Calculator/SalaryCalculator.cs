using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class SalaryCalculator
    {
        private string name;
        private double basicSalary;
        private double houseRentP;
        private double medicalAllowanceP;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public double HouseRentP
        {
            get { return houseRentP; }
            set { houseRentP = value; }
        }

        public double MedicalAllowanceP
        {
            get { return medicalAllowanceP; }
            set { medicalAllowanceP = value; }
        }

        public double Salary()
        {
            double houseRent=(houseRentP *basicSalary)/100;
            double medicalAllowance=(medicalAllowanceP *basicSalary )/100;
            return basicSalary - (houseRent + medicalAllowance);
        }
    }
}
