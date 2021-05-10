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
    public partial class Report_2 : Form
    {
        InventorySystem inv = new InventorySystem();
      
        public Report_2()
        {
            InitializeComponent();
        }

        private void Report_2_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
           
            Inventory inven = new Inventory();

            int id_2 = int.Parse(comboBox2.Text);

            DateTime Fromm = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            var report = (from t in inv.Items
                join b in inv.Inventory_Items
                    on t.Item_Code equals b.Item_ID
                join f in inv.Inventories on b.Inventory_ID equals f.Inventory_ID
                          where b.Item_ID == id_2
                      && t.Entry_Date >= Fromm && t.Entry_Date <= to
                select new { b.Inventory_ID, t.Item_Code, t.Item_Name, t.Entry_Date, t.Production_Date, t.Expiry_Date, b.Item_Quantity }).ToList();
            dataGridView1.DataSource = report;
           
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
