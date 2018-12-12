using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchBillCalculatorApp
{
    public partial class Form1 : Form
    {
        private double total, vat, discount;
        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double rice = Convert.ToDouble(riceTextBox.Text);
            double fish = Convert.ToDouble(fishTextBox.Text);
            double meat = Convert.ToDouble(meatTextBox.Text);
            total = (rice*20) + (fish*80) + (meat*100);
            totalTextBox.Text = total.ToString();
        }

        private void netBillButton_Click(object sender, EventArgs e)
        {
            double discountPercent = Convert.ToDouble(discountTextBox.Text);
            discount = (total*discountPercent)/100;
            double newTotal = (total - discount);
            vat = (newTotal * 5) / 100;
            vatLabel.Text = vat.ToString() + " tk";
            double netBill = newTotal + vat;
            MessageBox.Show(netBill.ToString());
            ClearBox();
        }

        public void ClearBox()
        {
            riceTextBox.Clear();
            fishTextBox.Clear();
            meatTextBox.Clear();
            totalTextBox.Clear();
            discountTextBox.Clear();
            vatLabel.Text = "      ";
        }
    }
}
