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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees emp= new Employees();
            emp.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Invent0ry inv= new Invent0ry();
            inv.Show();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            Item1 item=new Item1();
            item.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

           /* Timer MyTimer = new Timer();
             MyTimer.Stop();
             MyTimer.Enabled = false;*/

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client1 client=new Client1();
            client.Show();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            Supplier1 spl=new Supplier1();
            spl.Show();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            Transaction1 trn =new Transaction1();
            trn.Show();
        }

        private void Imports_Click(object sender, EventArgs e)
        {
            Import1 imp=new Import1();
            imp.Show();
        }

        private void Exports_Click(object sender, EventArgs e)
        {
            Export1 exp=new Export1();
            exp.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Report1 rep=new Report1();
            rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
