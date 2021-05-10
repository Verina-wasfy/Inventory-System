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
    public partial class Export_Preview : Form
    {
        InventorySystem inv = new InventorySystem();

        public int id { get; set; }
        public int cltid { get; set; }
        public int Invid { get; set; }


        public Export_Preview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Export_Preview_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;


            textBox2.Text = this.id.ToString();

            var Clt_name = (from f in inv.Clients
                where f.Client_ID == this.cltid
                select f.Client_Name).First();
            textBox4.Text = Clt_name;

            var Inv_name = (from d in inv.Inventories
                where d.Inventory_ID == this.Invid
                select d.Name).FirstOrDefault();
            textBox1.Text = Inv_name;

            var export_Date = (from x in inv.Exports
                where x.Export_ID == this.id
                select x.Export_Date).First();

            textBox3.Text = export_Date.ToString();

            var table = (from t in inv.Exports
                join b in inv.Items on t.Item_ID
                    equals b.Item_Code
                where t.Export_ID == this.id
                     select new { b.Item_Name, t.Quantity,t.Supplier_Name }).ToList();

            dataGridView1.DataSource = table;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
