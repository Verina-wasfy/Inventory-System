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
    public partial class Report_3 : Form
    {

        InventorySystem inv = new InventorySystem();

        public Report_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_3_Load(object sender, EventArgs e)
        {
            #region items
            var itm_id = (from d in inv.Items
                select d);

            foreach (var V in itm_id)
            {
                comboBox1.Items.Add(V.Item_Code);
            }
            #endregion



        }

        private void button2_Click(object sender, EventArgs e)
        {

            int id_2 = int.Parse(comboBox1.Text); 
            

            DateTime Fromm = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            var report = (from t in inv.Inventory_Items   
                          join d in inv.Items on 
                          t.Item_ID equals d.Item_Code
                          where t.Item_ID == id_2
                      && t.Transfer_Date >= Fromm && t.Transfer_Date <= to && t.Transfer_from!=null
                select new { t.Inventory_ID, t.Item_Quantity,d.Item_Code, d.Item_Name, t.Transfer_from, t.Transfer_to, t.Transfer_Date , t.Quantity_Transferred}).ToList();
            dataGridView1.DataSource = report;
        }
    }
}
