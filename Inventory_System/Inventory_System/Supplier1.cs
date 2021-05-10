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
    public partial class Supplier1 : Form
    {
        InventorySystem inv = new InventorySystem();
        public Supplier1()
        {
            InitializeComponent();
        }

        private void Supplier1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inv.Suppliers.ToList();
            dataGridView1.Columns["Imports"].Visible = false;

        }

        public void Reset()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;

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
                Supplier spl = new Supplier();

                spl.Supplier_ID = int.Parse(textBox1.Text);
                spl.Supplier_Name = textBox2.Text;
                spl.Supplier_Phone = int.Parse(textBox3.Text);
                spl.Supplier_Mobile = int.Parse(textBox4.Text);
                spl.Supplier_Website = textBox5.Text;
                spl.Supplier_Mail = textBox6.Text;
                spl.Supplier_Fax = textBox7.Text;

                inv.Suppliers.Add(spl);
                inv.SaveChanges();

                MessageBox.Show("You have added new Supplier.");

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
                Supplier spl = new Supplier();

                int id = int.Parse(textBox1.Text);

                spl = (from d in inv.Suppliers
                    where d.Supplier_ID == id
                    select d).First();
                spl.Supplier_Name = textBox2.Text;
                spl.Supplier_Phone = int.Parse(textBox3.Text);
                spl.Supplier_Mobile = int.Parse(textBox4.Text);
                spl.Supplier_Website = textBox5.Text;
                spl.Supplier_Mail = textBox6.Text;
                spl.Supplier_Fax = textBox7.Text;

                inv.SaveChanges();

                MessageBox.Show("You have Updated Supplier details.");

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the ID again.");

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
            textBox1.Text = dataGridView1.CurrentRow.Cells["Supplier_ID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Supplier_Name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Supplier_Phone"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Supplier_Mobile"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Supplier_Website"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Supplier_Mail"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["Supplier_Fax"].Value.ToString();

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier spll = new Supplier();
                int id = int.Parse(textBox1.Text);
                spll = (from d in inv.Suppliers
                    where d.Supplier_ID == id
                    select d).First();
                inv.Suppliers.Remove(spll);
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
