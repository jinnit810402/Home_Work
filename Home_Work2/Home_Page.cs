using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work2
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
            button6.Enabled = false;
            button7.Enabled = false;
            
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Work1 frm = new Home_Work1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_work2 frm2 = new Home_work2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_Work3 frm3 = new Home_Work3();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Work4 frm4 = new Home_Work4();
            frm4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home_Work8 frm8 = new Home_Work8();
            frm8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Home_Work10 frm10 = new Home_Work10();
            frm10.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home_Work frm08 = new Home_Work();
            frm08.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home_Work5 frm05 = new Home_Work5();
            frm05.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home_Work11 frm11 = new Home_Work11();
            frm11.Show();
        }
    }
}
