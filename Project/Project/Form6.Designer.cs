
namespace Project
{
    partial class Form6
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
            this.dataadmin = new System.Windows.Forms.DataGridView();
            this.Btnadd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.namestock = new System.Windows.Forms.Label();
            this.typestock = new System.Windows.Forms.Label();
            this.amountstock = new System.Windows.Forms.Label();
            this.pricestock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupsellBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupsellBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataadmin
            // 
            this.dataadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataadmin.Location = new System.Drawing.Point(12, 95);
            this.dataadmin.Name = "dataadmin";
            this.dataadmin.RowHeadersWidth = 51;
            this.dataadmin.RowTemplate.Height = 24;
            this.dataadmin.Size = new System.Drawing.Size(663, 365);
            this.dataadmin.TabIndex = 0;
            this.dataadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataadmin_CellClick);
            // 
            // Btnadd
            // 
            this.Btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnadd.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Btnadd.Location = new System.Drawing.Point(39, 389);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(172, 40);
            this.Btnadd.TabIndex = 17;
            this.Btnadd.Text = "เพิ่มสินค้า";
            this.Btnadd.UseVisualStyleBackColor = false;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.Location = new System.Drawing.Point(39, 543);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "ลบสินค้า";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.Location = new System.Drawing.Point(39, 462);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 40);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "อัพเดตสินค้า";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(70, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(167, 22);
            this.nameBox.TabIndex = 20;
            // 
            // amountBox
            // 
            this.amountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountBox.Location = new System.Drawing.Point(325, 68);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(167, 22);
            this.amountBox.TabIndex = 21;
            // 
            // typeBox
            // 
            this.typeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeBox.Location = new System.Drawing.Point(70, 142);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(167, 22);
            this.typeBox.TabIndex = 22;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceBox.Location = new System.Drawing.Point(325, 142);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(167, 22);
            this.priceBox.TabIndex = 23;
            // 
            // namestock
            // 
            this.namestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namestock.AutoSize = true;
            this.namestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.namestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.namestock.Location = new System.Drawing.Point(64, 29);
            this.namestock.Name = "namestock";
            this.namestock.Size = new System.Drawing.Size(67, 35);
            this.namestock.TabIndex = 24;
            this.namestock.Text = "Name";
            // 
            // typestock
            // 
            this.typestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typestock.AutoSize = true;
            this.typestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.typestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.typestock.Location = new System.Drawing.Point(64, 104);
            this.typestock.Name = "typestock";
            this.typestock.Size = new System.Drawing.Size(60, 35);
            this.typestock.TabIndex = 25;
            this.typestock.Text = "Type";
            // 
            // amountstock
            // 
            this.amountstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountstock.AutoSize = true;
            this.amountstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.amountstock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.amountstock.Location = new System.Drawing.Point(319, 29);
            this.amountstock.Name = "amountstock";
            this.amountstock.Size = new System.Drawing.Size(83, 35);
            this.amountstock.TabIndex = 26;
            this.amountstock.Text = "Amount";
            // 
            // pricestock
            // 
            this.pricestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pricestock.AutoSize = true;
            this.pricestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pricestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pricestock.Location = new System.Drawing.Point(319, 104);
            this.pricestock.Name = "pricestock";
            this.pricestock.Size = new System.Drawing.Size(62, 35);
            this.pricestock.TabIndex = 27;
            this.pricestock.Text = "price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(39, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // browsebtn
            // 
            this.browsebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browsebtn.Location = new System.Drawing.Point(159, 307);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(75, 30);
            this.browsebtn.TabIndex = 29;
            this.browsebtn.Text = "browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // fileBox
            // 
            this.fileBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileBox.Location = new System.Drawing.Point(27, 311);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(126, 22);
            this.fileBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 60);
            this.label1.TabIndex = 31;
            this.label1.Text = "รูปสินค้า";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "คำสั่ง",
            "ประวัติการขาย"});
            this.comboBox.Location = new System.Drawing.Point(12, 48);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(153, 24);
            this.comboBox.TabIndex = 32;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pricestock);
            this.groupBox1.Controls.Add(this.amountstock);
            this.groupBox1.Controls.Add(this.typestock);
            this.groupBox1.Controls.Add(this.namestock);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.amountBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(75, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 199);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fileBox);
            this.groupBox2.Controls.Add(this.browsebtn);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.Btnadd);
            this.groupBox2.Location = new System.Drawing.Point(681, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 666);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // groupsellBox
            // 
            this.groupsellBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupsellBox.Controls.Add(this.label3);
            this.groupsellBox.Controls.Add(this.label2);
            this.groupsellBox.Controls.Add(this.sellBox);
            this.groupsellBox.Location = new System.Drawing.Point(42, 473);
            this.groupsellBox.Name = "groupsellBox";
            this.groupsellBox.Size = new System.Drawing.Size(621, 225);
            this.groupsellBox.TabIndex = 35;
            this.groupsellBox.TabStop = false;
            this.groupsellBox.Text = "sell";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 43);
            this.label2.TabIndex = 26;
            this.label2.Text = "ขายได้";
            // 
            // sellBox
            // 
            this.sellBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sellBox.Location = new System.Drawing.Point(212, 91);
            this.sellBox.Name = "sellBox";
            this.sellBox.ReadOnly = true;
            this.sellBox.Size = new System.Drawing.Size(192, 38);
            this.sellBox.TabIndex = 25;
            this.sellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "บาท";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(976, 722);
            this.Controls.Add(this.groupsellBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupsellBox.ResumeLayout(false);
            this.groupsellBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataadmin;
        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label namestock;
        private System.Windows.Forms.Label typestock;
        private System.Windows.Forms.Label amountstock;
        private System.Windows.Forms.Label pricestock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupsellBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sellBox;
        private System.Windows.Forms.Label label3;
    }
}