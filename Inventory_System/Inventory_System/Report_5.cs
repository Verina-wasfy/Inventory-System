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
    public partial class Report_5 : Form
    {
        InventorySystem inv = new InventorySystem();

        public Report_5()
        {
            InitializeComponent();
        }

        private void Report_5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          //  var expiryMonth = DateTime.Now.);
            var expiryval= DateTime.Now.AddYears((int)numericUpDown1.Value).AddMonths((int)numericUpDown2.Value).AddDays((int)(numericUpDown3.Value));
           // var expiryDay= DateTime.Now;

            var exp =( from t in inv.Items
                      where t.Expiry_Date < expiryval
                       select new { t.Item_Code, t.Item_Name, t.Entry_Date, t.Production_Date, t.Expiry_Date }).ToList();

                dataGridView1.DataSource =exp;


        }
    }
}
