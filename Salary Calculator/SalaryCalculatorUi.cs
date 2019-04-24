using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            SalaryCalculator salaryCalculator=new SalaryCalculator();
            salaryCalculator.Name = nameTextBox.Text;
            salaryCalculator.BasicSalary = Convert.ToDouble(basicAmountTextBox.Text);
            salaryCalculator.HouseRentP = Convert.ToDouble(houseRentTextBox.Text);
            salaryCalculator.MedicalAllowanceP = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(salaryCalculator.Name + " your Salary is: "+salaryCalculator.Salary());
        }
    }
}
