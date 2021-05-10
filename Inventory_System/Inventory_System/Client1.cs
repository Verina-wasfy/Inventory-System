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
    public partial class Client1 : Form
    {
        InventorySystem inv = new InventorySystem();
        public Client1()
        {
            InitializeComponent();
        }

        private void Client1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inv.Clients.ToList();
            dataGridView1.Columns["Exports"].Visible = false;

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
                Client clt = new Client();
                clt.Client_ID = int.Parse(textBox1.Text);
                clt.Client_Name = textBox2.Text;
                clt.Client_Phone = int.Parse(textBox3.Text);
                clt.Client_Mobile = int.Parse(textBox4.Text);
                clt.Client_Website = textBox5.Text;
                clt.Client_Mail = textBox6.Text;
                clt.Client_Fax = textBox7.Text;

                inv.Clients.Add(clt);
                inv.SaveChanges();

                MessageBox.Show("You have added new Client.");

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
            Client clt = new Client();
            {

                int id = int.Parse(textBox1.Text);

                clt = (from d in inv.Clients
                    where d.Client_ID == id
                    select d).First();
                clt.Client_Name = textBox2.Text;
                clt.Client_Phone = int.Parse(textBox3.Text);
                clt.Client_Mobile = int.Parse(textBox4.Text);
                clt.Client_Website = textBox5.Text;
                clt.Client_Mail = textBox6.Text;
                clt.Client_Fax = textBox7.Text;

                inv.SaveChanges();

                MessageBox.Show("You have Updated Client details.");

                Reset();
            }
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
            textBox1.Text = dataGridView1.CurrentRow.Cells["Client_ID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Client_Name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Client_Phone"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Client_Mobile"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Client_Website"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Client_Mail"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["Client_Fax"].Value.ToString();

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Client cltt = new Client();

                int id = int.Parse(textBox1.Text);
                cltt = (from d in inv.Clients
                    where d.Client_ID == id
                    select d).First();
                inv.Clients.Remove(cltt);
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
