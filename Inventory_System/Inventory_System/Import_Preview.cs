using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Import_Preview : Form
    {
        InventorySystem inv = new InventorySystem();

        public int id { get; set; }
        public int Invid { get; set; }
        public Import_Preview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Import_Preview_Load(object sender, EventArgs e)
        {

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            var Inv_name = (from d in inv.Inventories
                where d.Inventory_ID == this.Invid
                select d.Name).FirstOrDefault();
            textBox1.Text = Inv_name;

            textBox2.Text = this.id.ToString();

            var import_Date = (from x in inv.Imports
                where x.Import_ID == this.id
                select x.Import_Date).First();
            textBox3.Text = import_Date.ToString();

           
            var table = (from t in inv.Imports
                join b in inv.Items on t.Item_ID
                    equals b.Item_Code
                join o in inv.Suppliers on t.Supplier_ID
                    equals o.Supplier_ID
                         where t.Import_ID == this.id
                select new { b.Item_Name, t.Quantity,b.Production_Date,b.Expiry_Date, o.Supplier_Name }).ToList();

            dataGridView1.DataSource = table;
        }
    }
}
