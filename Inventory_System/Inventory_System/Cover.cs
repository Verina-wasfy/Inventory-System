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
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        private void Cover_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
