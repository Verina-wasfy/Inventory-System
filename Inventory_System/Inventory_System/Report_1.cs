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
    public partial class Report_1 : Form
    {
        InventorySystem inv = new InventorySystem();
        public Report_1()
        {
            InitializeComponent();
        }

        private void Report_1_Load(object sender, EventArgs e)
        {
            #region inventory
            var inv_nme = (from d in inv.Inventories

                           select d);

            foreach (var I in inv_nme)
            {
                comboBox1.Items.Add(I.Inventory_ID);
            }
            #endregion
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            //DateTime Fromm = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            //DateTime to = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());

            DateTime Fromm = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            var report = (from t in inv.Items
                          join b in inv.Inventory_Items
                              on t.Item_Code equals b.Item_ID
                          where b.Inventory_ID == id
                          && t.Entry_Date >= Fromm && t.Entry_Date <= to
                            select t).ToList();
            dataGridView1.DataSource = report;
            dataGridView1.Columns["Inventory_Items"].Visible = false;
            dataGridView1.Columns["Exports"].Visible = false;
            dataGridView1.Columns["Imports"].Visible = false;
            var WH_N = (from d in inv.Inventories
                where d.Inventory_ID == id
                select d.Name).FirstOrDefault();

            textBox2.Text = WH_N;


            var WH_LOC = (from d in inv.Inventories
                          where d.Inventory_ID == id
                select d.Address).FirstOrDefault();

            textBox4.Text = WH_LOC;


            var EmpName = (from d in inv.Employees
                where d.Emp_ID == id
                select d.Emp_Name).FirstOrDefault();

            textBox3.Text = EmpName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
