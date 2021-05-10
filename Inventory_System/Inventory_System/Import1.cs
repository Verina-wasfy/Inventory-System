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
    public partial class Import1 : Form
    {
        InventorySystem inv = new InventorySystem();

        public int invoid;
        public int impid;

        public Import1()
        {
            InitializeComponent();
        }

        private void Import1_Load(object sender, EventArgs e)
        {
            #region inventory
            var inv_nme = (from d in inv.Inventories

                           select d);

            foreach (var I in inv_nme)
            {
                comboBox1.Items.Add(I.Inventory_ID);
            }
            #endregion


            dataGridView1.DataSource = inv.Imports.ToList();
            dataGridView1.Columns["Supplier"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView1.Columns["item"].Visible = false;

            #region items
            var itm_nme = (from d in inv.Items

                select d);

            foreach (var I in itm_nme)
            {
                comboBox3.Items.Add(I.Item_Code);
            }
            #endregion

            // int id = int.Parse(comboBox3.Text);
           var sup = (from d in inv.Suppliers
               
               select d.Supplier_ID).ToList();


           foreach (var I in sup)
           {
               comboBox2.Items.Add(I);
           }

        }
        /* public void Reset()
         {
             textBox1.Text = textBox4.Text = textBox5.Text = string.Empty;
             comboBox3.Items.Clear();
             comboBox2.Items.Clear();
         }*/
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Import imp = new Import();

                imp.Supplier_ID = int.Parse(comboBox2.Text);
                imp.Item_ID = int.Parse(comboBox3.Text);
                imp.Emp_ID = int.Parse(textBox5.Text);
                imp.Quantity = int.Parse(textBox4.Text);
                imp.Import_ID = int.Parse(textBox1.Text);
                imp.Import_Date = dateTimePicker1.Value;
                inv.Imports.Add(imp);
                inv.SaveChanges();

                MessageBox.Show("You have added new Import.");

               // Reset();
            }
            catch
            {
                MessageBox.Show("Invild Data !");


            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            inv.SaveChanges();
            MessageBox.Show("Changes saved.");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Import imp = new Import();

                int id = int.Parse(textBox5.Text);
                int id1 = int.Parse(comboBox3.Text);
                int id2 = int.Parse(comboBox2.Text);

                imp = (from d in inv.Imports
                    where d.Emp_ID == id
                    where d.Item_ID== id1
                    where d.Supplier_ID == id2
                    select d).First();
                imp.Quantity = int.Parse(textBox4.Text);
                imp.Import_ID = int.Parse(textBox1.Text);
                imp.Import_Date = dateTimePicker1.Value;
               // Reset();
                inv.SaveChanges();
                MessageBox.Show("Details have been updated.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the details again.");

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            int id = (int)comboBox1.SelectedItem;
            var emp = (from d in inv.Inventories
                where d.Inventory_ID == id
                select d.EmpResp_ID).FirstOrDefault();

            textBox5.Text = emp.ToString();

            var Produ = (from f in inv.Inventory_Items
                where f.Inventory_ID == id
                select f.Item_ID).ToList();


            foreach (var I in Produ)
            {
                comboBox3.Items.Add(I);

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          /*  int id = int.Parse(comboBox3.Text);
            var sup = (from d in inv.Imports
                where d.Item_ID== id
                select d.Supplier_ID).ToList();

          
            foreach (var I in sup)
            {
                comboBox2.Items.Add(I);
            }*/
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoid = int.Parse(comboBox1.Text);
            impid= int.Parse(textBox1.Text);
            Import_Preview ptrI= new Import_Preview();
            ptrI.Invid = invoid;
            ptrI.id = impid;
            ptrI.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Import impp = new Import();


                int id = int.Parse(comboBox3.Text);
                int id_2 = int.Parse(comboBox2.Text);
                int id_3 = int.Parse(textBox5.Text);

                impp = (from d in inv.Imports
                    where d.Item_ID == id && d.Supplier_ID == id_2 && d.Emp_ID == id_3
                    select d).First();
                inv.Imports.Remove(impp);
                inv.SaveChanges();
                MessageBox.Show("Deleted Successfully.");

            }
            catch
            {
                MessageBox.Show("Invaild details.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["Item_ID"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Import_Date"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Import_ID"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Emp_ID"].Value.ToString();
        }
    }
}
