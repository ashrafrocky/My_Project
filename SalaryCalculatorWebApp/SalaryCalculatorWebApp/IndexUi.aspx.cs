using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalculatorWebApp
{
    public partial class IndexUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.basicSalary = Convert.ToDecimal(basicSalaryTextBox.Text);
            salary.medicalAllowancePercentage = Convert.ToDecimal(medicalAllowanceTextBox.Text);
            salary.conveyancePercentage = Convert.ToDecimal(conveyanceTextBox.Text);

            basicSalaryTextBox.Text = String.Empty;
            medicalAllowanceTextBox.Text = String.Empty;
            conveyanceTextBox.Text =String.Empty;

            ViewState["salaryVS"] = salary;
        }

        protected void calculateSalaryButton_Click(object sender, EventArgs e)
        {
            Salary salary = (Salary)ViewState["salaryVS"];
            outputLabel.Text = salary.GetTotalSalary().ToString();

        }
    }
}