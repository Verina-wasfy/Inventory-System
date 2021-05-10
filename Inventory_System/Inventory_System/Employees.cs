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
    public partial class Employees : Form
    {
        InventorySystem inv=new InventorySystem();
        public Employees()
        {
            InitializeComponent();
        }

      
        private void Employees_Load(object sender, EventArgs e)
        {
            #region Navigation hide
            dataGridView1.DataSource = inv.Employees.ToList();
            dataGridView1.Columns["Inventories"].Visible = false;
            dataGridView1.Columns["Imports"].Visible = false;
            dataGridView1.Columns["Exports"].Visible = false;

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

        private void Insert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            try
            {
                emp.Emp_ID = int.Parse(textBox1.Text);
                emp.Emp_Name = textBox2.Text;
                emp.Emp_Phone = int.Parse(textBox3.Text);
                emp.Emp_Address = textBox4.Text;
                emp.Emp_Mail = textBox5.Text;
                inv.Employees.Add(emp);
                inv.SaveChanges();

                MessageBox.Show("You have added new Employee.");

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the ID again.");

                throw;
            }
         
        }

        public void Reset()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                Employee emp = new Employee();

                int id = int.Parse(textBox1.Text);

                emp = (from d in inv.Employees
                    where d.Emp_ID == id
                    select d).First();
                emp.Emp_Name = textBox2.Text;
                emp.Emp_Phone = int.Parse(textBox3.Text);
                emp.Emp_Address = textBox4.Text;
                emp.Emp_Mail = textBox5.Text;
                inv.SaveChanges();
                MessageBox.Show("You have updated the Employee details.");

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

            try
            {
                Employee empl = new Employee();

                int id = int.Parse(textBox1.Text);
                empl = (from d in inv.Employees
                    where d.Emp_ID== id
                    select d).First();
                inv.Employees.Remove(empl);
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
            textBox1.Text = dataGridView1.CurrentRow.Cells["Emp_ID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Emp_Name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Emp_Phone"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Emp_Address"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Emp_Mail"].Value.ToString();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
