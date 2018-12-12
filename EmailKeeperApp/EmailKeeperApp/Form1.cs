using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeperApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String emailAddr = addTextBox.Text;

            if (emailAddr.Contains("@") && emailAddr.Contains("."))
            {
                addListBox.Items.Add(addTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            if (Equals(emailAddr.Text, addTextBox.Text))
            {
                MessageBox.Show("found");
            }
            
            else
            {
                MessageBox.Show("Not found!");
            }
        }

        private void addListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
