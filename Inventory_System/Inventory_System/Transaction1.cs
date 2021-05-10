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
    public partial class Transaction1 : Form
    {
        InventorySystem inv=new InventorySystem();
         public int quan = 0;
       

        public Transaction1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transaction1_Load(object sender, EventArgs e)
        {
            #region items
            var itm_id = (from d in inv.Items
                          select d);

            foreach (var V in itm_id)
            {
                comboBox1.Items.Add(V.Item_Code);
            }
            #endregion
            #region Transfer_to

            var inv_id = (from x in inv.Inventories
                          select x);
            foreach (var y in inv_id)
            {
                comboBox2.Items.Add(y.Inventory_ID);
            } 
            #endregion
        }
        public void Reset()
        {
             textBox2.Text = String.Empty;
             comboBox3.Items.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            inv.SaveChanges();
            MessageBox.Show("Changes saved.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();

            int id = (int) comboBox1.SelectedItem;
            var inv_from = (from d in inv.Inventory_Items
                where d.Item_ID == id
                select d.Inventory_ID).ToList();
           
            foreach (var o in inv_from)
            {
                comboBox3.Items.Add(o);

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory_Items inv_itm = new Inventory_Items();
                Inventory_Items newinv_itm = new Inventory_Items();
                int id = (int)comboBox3.SelectedItem;
                int id_2 = (int)comboBox1.SelectedItem;

                inv_itm = (from d in inv.Inventory_Items
                    where d.Inventory_ID == id
                    where d.Item_ID == id_2
                           select d).First();



                


                inv_itm.Quantity_Transferred = int.Parse(textBox2.Text);
                inv_itm.Transfer_from= (int)comboBox3.SelectedItem;
                inv_itm.Transfer_to = (int)comboBox2.SelectedItem;
                inv_itm.Transfer_Date = dateTimePicker1.Value;
                 quan = int.Parse(textBox2.Text);
                inv_itm.Item_Quantity -= quan;
                




                int id_3 = (int)comboBox2.SelectedItem;

                newinv_itm = (from q in inv.Inventory_Items
                    where q.Inventory_ID == id_3
                    where q.Item_ID == id_2
                              select q).First();

                newinv_itm.Item_Quantity += quan;
                newinv_itm.Transfer_Date = dateTimePicker1.Value;
              

             

                inv.SaveChanges();
                MessageBox.Show("You have Transferred Item.");

                Reset();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Check the values again.");
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
