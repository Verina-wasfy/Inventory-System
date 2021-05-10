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
    public partial class Invent0ry : Form
    {
        InventorySystem inv = new InventorySystem();
        public Invent0ry()
        {
            InitializeComponent();
        }

        private void Invent0ry_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inv.Inventories.ToList();
            dataGridView1.Columns["Inventory_Items"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;


            var resp = (from d in inv.Employees
                select d);

            foreach (var I in resp)
            {
                comboBox1.Items.Add(I.Emp_Name);
            }
        }

       
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory inven = new Inventory();

                inven.Inventory_ID = int.Parse(textBox1.Text);
                inven.Name = textBox2.Text;
                inven.Address = textBox3.Text;
                    var ID= (from d in inv.Employees
                                    where d.Emp_Name == comboBox1.SelectedItem.ToString()
                                    select d.Emp_ID).First();
                    inven.EmpResp_ID = ID;

                inv.Inventories.Add(inven);
                inv.SaveChanges();

               
                 MessageBox.Show("You have added new Inventory.");

                 Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the data you have entered again.");

                throw;
            }
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
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory inven = new Inventory();

                int id = int.Parse(textBox1.Text);
                inven = (from d in inv.Inventories
                    where d.Inventory_ID == id
                    select d).First();
                inven.Name = textBox2.Text;
                var ID = (from d in inv.Employees
                    where d.Emp_Name == comboBox1.SelectedItem.ToString()
                    select d.Emp_ID).First();
                inven.EmpResp_ID = ID;
                inv.SaveChanges();
                MessageBox.Show("You have updated the Inventory details.");

                Reset();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Data can't be updated.");

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Inventory invenn = new Inventory();
                int id = int.Parse(textBox1.Text);
                invenn = (from d in inv.Inventories
                          where d.Inventory_ID == id
                    select d).First();
                inv.Inventories.Remove(invenn);
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
            #region Views
            textBox1.Text = dataGridView1.CurrentRow.Cells["Inventory_ID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["EmpResp_ID"].Value.ToString();


            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
