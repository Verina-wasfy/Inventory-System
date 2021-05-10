using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_1 rep1=new Report_1();
            rep1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_2 rep2 = new Report_2();
            rep2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report_3 rep3 = new Report_3();
            rep3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report_5 rep5= new Report_5();
            rep5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report_4 rep4 = new Report_4();
            rep4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
