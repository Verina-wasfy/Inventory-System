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
    public partial class Report_4 : Form
    {
        InventorySystem inv = new InventorySystem();
        
        public Report_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          DateTime d1 = System.DateTime.Now.AddMonths(-(int)numericUpDown2.Value).AddYears(-(int)numericUpDown1.Value);
           
            var dat = (from t in inv.Items where t.Entry_Date<= d1 select t).ToList();
            dataGridView1.DataSource = dat;

            dataGridView1.Columns["Exports"].Visible = false;
            dataGridView1.Columns["Imports"].Visible = false;
            dataGridView1.Columns["Inventory_Items"].Visible = false;
       
        }

        private void Report_4_Load(object sender, EventArgs e)
        {
            #region items
            var itm_id = (from d in inv.Items
                select d);

            foreach (var V in itm_id)
            {
                comboBox2.Items.Add(V.Item_Code);
            }
            #endregion

        }
    }
}
