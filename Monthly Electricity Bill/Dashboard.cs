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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
       
        private void openChildForm(Form childForm)
        {

            if(activeForm != null)
            {
                activeForm.Close();
            }
           
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_2_right.Controls.Add(childForm);
            panel_2_right.Tag = childForm;
            childForm.BringToFront();
            
            childForm.Show();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void showCategory()
        {

            panel_category.Visible = true;
        }

        

        private void panel_2_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_1_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_1_logo_Click(object sender, EventArgs e)
        {

        }

        private void button_category_2_hotel_Click(object sender, EventArgs e)
        {

        }

        private void button_category_1_home_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1_home_category());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_BillCalculator_Click(object sender, EventArgs e)
        {
            showCategory();
        }
    }
}
