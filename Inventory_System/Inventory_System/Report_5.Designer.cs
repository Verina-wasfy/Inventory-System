namespace Inventory_System
{
    partial class Report_5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1050, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(20, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 222);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Expiring Period in Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Expiring Period in Year:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(284, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Expiring Period in Month:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SlateGray;
            this.label9.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(27, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(382, 40);
            this.label9.TabIndex = 45;
            this.label9.Text = "About To Expire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 90);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 407);
            this.dataGridView1.TabIndex = 49;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(237, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 40;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(237, 80);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown2.TabIndex = 41;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(237, 132);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown3.TabIndex = 42;
            // 
            // Report_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_5";
            this.Load += new System.EventHandler(this.Report_5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}