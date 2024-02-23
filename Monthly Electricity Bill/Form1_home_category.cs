using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Electricity_Bill
{
    public partial class Form1_home_category : Form
    {
        public Form1_home_category()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double current = double.Parse(textBox_current.Text);
            double previous = double.Parse(textBox_previous.Text);
            double unit = current - previous;
            textBox_unit.Text = unit.ToString();


            if(unit>= 1 && unit <=30)
            {
                home_engery_label.Text = (32 * unit).ToString();
                home_fixed_charge_label.Text = 150.ToString();
                home_electricity_bill_label.Text = ((32 * unit) + 150).ToString();


            }
            else if (unit >= 31 && unit <= 60)
            {
                home_engery_label.Text = (32 * unit).ToString();
                home_fixed_charge_label.Text = 300.ToString();
                home_electricity_bill_label.Text = ((32 * unit) + 300).ToString();


            }
            else if (unit >= 61 && unit <= 90)
            {
                home_engery_label.Text = (  (60 * 32) + (  (unit - 60) * 35 )  ).ToString();
                home_fixed_charge_label.Text = 400.ToString();
                home_electricity_bill_label.Text = (   (60*32) +  ( (unit-60)*35)   + 400).ToString();


            }

            else if (unit >= 91 && unit <= 120)
            {
                home_engery_label.Text = ( (60 * 32) + (30 * 35) + ((unit - 90) * 50) ).ToString();
                home_fixed_charge_label.Text = 1000.ToString();
                home_electricity_bill_label.Text = ((60 * 32) + (30 * 35) + ((unit - 90) * 50)   + 1000 ).ToString();


            }


            else if (unit >= 121 && unit <= 180)
            {
                home_engery_label.Text = ((60 * 32) + (30 * 35) + (30*50) + ((unit - 120) * 50)).ToString();
                home_fixed_charge_label.Text = 1500.ToString();
                home_electricity_bill_label.Text = ((60 * 32) + (30 * 35) + (30 * 50) + ((unit - 120) * 50) + 1500).ToString();


            }

            else if (unit >= 181)
            {
                home_engery_label.Text = ((60 * 32) + (30 * 35) + (30 * 50) + (60 * 50) + ((unit - 180) * 75)).ToString();
                home_fixed_charge_label.Text = 2000.ToString();
                home_electricity_bill_label.Text = ((60 * 32) + (30 * 35) + (30 * 50) + (60 * 50) + ((unit - 180) * 75) + 2000).ToString();


            }


        }

        private void textBox_previous_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_current_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_unit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void Form1_home_category_Load(object sender, EventArgs e)
        {

        }

        private void Form1_home_category_Load_1(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
}
