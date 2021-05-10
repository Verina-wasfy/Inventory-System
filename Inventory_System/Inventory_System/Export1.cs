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
    public partial class Export1 : Form
    {
        InventorySystem inv = new InventorySystem();
        public int exportid;
        public int clientid;
        public int invid;
        public Export1()
        {
            InitializeComponent();
        }

        private void Export1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inv.Exports.ToList();
            dataGridView1.Columns["Client"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView1.Columns["Item"].Visible = false;
            #region Inventory
            var inv_id = (from d in inv.Inventories

                            select d);

            foreach (var I in inv_id)
            {
                comboBox1.Items.Add(I.Inventory_ID);
            }
            #endregion

            #region Client
            var clt_id = (from d in inv.Clients

                            select d);

            foreach (var W in clt_id)
            {
                comboBox4.Items.Add(W.Client_ID);
            }
            #endregion


        }

        private void Save_Click(object sender, EventArgs e)
        {
            inv.SaveChanges();
            MessageBox.Show("Changes Saved.");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reset()
        {
            textBox4.Text = textBox2.Text = comboBox2.Text = string.Empty;

        }
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Export ex = new Export();

                ex.Client_ID = int.Parse(comboBox4.Text);
                ex.Item_ID = int.Parse(comboBox2.Text);
                ex.Emp_ID = int.Parse(textBox5.Text);
                ex.Quantity = int.Parse(textBox4.Text);
                ex.Supplier_Name = textBox2.Text;
                ex.Export_Date = dateTimePicker1.Value;
                ex.Export_ID = int.Parse(textBox1.Text);
                inv.Exports.Add(ex);
                inv.SaveChanges();

                MessageBox.Show("You have added new item to your Export sheet.");

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the data you have entered again.");

                throw;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem;
            Employee empl = new Employee();
            var emp_id = (from d in inv.Inventories
                where d.Inventory_ID == id
                select d.EmpResp_ID).FirstOrDefault();

            textBox5.Text = emp_id.ToString();

            var Produ = (from i in inv.Inventory_Items
                where i.Inventory_ID == id
                select i.Item_ID).ToList();


            foreach (var I in Produ)
            {
                comboBox2.Items.Add(I);

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox2.Text);
            var sup = (from d in inv.Imports
                where d.Item_ID == id
                select d.Supplier_ID).FirstOrDefault();

            var sup_name = (from s in inv.Suppliers
                where s.Supplier_ID == sup
                select s.Supplier_Name).First();

            textBox2.Text = sup_name;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Export ex = new Export();

            int id = int.Parse(textBox5.Text);
            ex = (from d in inv.Exports
                where d.Emp_ID == id
                select d).First();


            int id_2 = int.Parse(comboBox4.Text);
            ex = (from d in inv.Exports
                  where d.Client_ID == id_2
                select d).First();

            int id_3 = int.Parse(comboBox2.Text);
            ex = (from d in inv.Exports
                where d.Item_ID == id_3
                select d).First();

            ex.Quantity = int.Parse(textBox4.Text);
            ex.Supplier_Name = ex.Supplier_Name;
            ex.Export_Date = ex.Export_Date;
            ex.Export_ID = ex.Export_ID;
            inv.SaveChanges();

            MessageBox.Show("Changes have been saved.");
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
          

            exportid = int.Parse(textBox1.Text);
            clientid =int.Parse(comboBox4.Text);
            invid = int.Parse(comboBox1.Text);
            Export_Preview exP = new Export_Preview();
            exP.id = exportid;
            exP.cltid=clientid;
            exP.Invid = invid;
            exP.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells["Emp_ID"].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells["Client_ID"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Item_ID"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Export_Date"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Export_ID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Supplier_Name"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Export exx = new Export();


                int id = int.Parse(comboBox2.Text);
                int id_2 = int.Parse(comboBox4.Text);
                int id_3 = int.Parse(textBox5.Text);

                exx = (from d in inv.Exports
                    where d.Item_ID== id &&d.Client_ID== id_2 && d.Emp_ID== id_3
                       select d).First();
                inv.Exports.Remove(exx);
                inv.SaveChanges();
                MessageBox.Show("Deleted Successfully.");

            }
            catch
            {
                MessageBox.Show("Invaild details.");
            }

        }
    }
}
