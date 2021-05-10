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
    public partial class Item1 : Form
    {
        InventorySystem inv = new InventorySystem();
       
        public Item1()
        {
            InitializeComponent();
        }

        private void Item1_Load(object sender, EventArgs e)
        {
            var Inv_name = (from d in inv.Inventories
                select d);
            foreach (var I in Inv_name)
            {
                comboBox1.Items.Add(I.Inventory_ID);
            }
            dataGridView1.DataSource = inv.Items.ToList();
            dataGridView1.Columns["Inventory_Items"].Visible = false;
            dataGridView1.Columns["Imports"].Visible = false;
            dataGridView1.Columns["Exports"].Visible = false;


        }

        public void Reset()
        {
            textBox1.Text = textBox2.Text = textBox3.Text  = textBox6.Text = textBox7.Text = comboBox1.Text= string.Empty;

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

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Item itm = new Item();
                Inventory_Items inv_itm = new Inventory_Items();
                itm.Item_Code= int.Parse(textBox1.Text);
                itm.Item_Name = textBox2.Text;
                itm.Measuring_Unit = textBox3.Text;
                itm.Production_Date = dateTimePicker3.Value;
                itm.Expiry_Date = dateTimePicker1.Value;
                itm.Total_Quantity =int.Parse( textBox6.Text);
                itm.Price = int.Parse(textBox7.Text);
                itm.Entry_Date = dateTimePicker2.Value;
                inv_itm.Inventory_ID = (int)comboBox1.SelectedItem;
                inv_itm.Item_Quantity= int.Parse(textBox6.Text);
                inv_itm.Item_ID= int.Parse(textBox1.Text);
                inv.Inventory_Items.Add(inv_itm);
                inv.Items.Add(itm);
                inv.SaveChanges();

                MessageBox.Show("You have added new Item.");

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the ID again.");

                throw;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Item itm = new Item();
                Inventory_Items inv_itm = new Inventory_Items();
                int id = int.Parse(textBox1.Text);

                itm = (from d in inv.Items
                    where d.Item_Code == id
                    select d).First();

                itm.Item_Name = textBox2.Text;
                itm.Measuring_Unit = textBox3.Text;
                itm.Production_Date = dateTimePicker3.Value;
                itm.Expiry_Date = dateTimePicker1.Value;
                itm.Total_Quantity = int.Parse(textBox6.Text);
                itm.Price = int.Parse(textBox7.Text);
                itm.Entry_Date = dateTimePicker2.Value;
                inv_itm.Inventory_ID = (int)comboBox1.SelectedItem;
                inv_itm.Item_Quantity = int.Parse(textBox6.Text);
                inv_itm.Item_ID = int.Parse(textBox1.Text);
                inv.SaveChanges();
                MessageBox.Show("You have updated the Item details.");

                Reset();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Data can't be updated.");

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Views
            textBox1.Text = dataGridView1.CurrentRow.Cells["Item_Code"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Measuring_Unit"].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells["Production_Date"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Expiry_Date"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["Entry_Date"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Total_Quantity"].Value.ToString();



            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Item itmm = new Item();

                int id = int.Parse(textBox1.Text);
                itmm = (from d in inv.Items
                    where d.Item_Code == id
                    select d).First();
                inv.Items.Remove(itmm);
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
