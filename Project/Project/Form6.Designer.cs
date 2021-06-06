
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sellBox = new System.Windows.Forms.TextBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.teleBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupsellBox.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataadmin
            // 
            this.dataadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataadmin.Location = new System.Drawing.Point(21, 77);
            this.dataadmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataadmin.Name = "dataadmin";
            this.dataadmin.RowHeadersWidth = 51;
            this.dataadmin.RowTemplate.Height = 24;
            this.dataadmin.Size = new System.Drawing.Size(497, 297);
            this.dataadmin.TabIndex = 0;
            this.dataadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataadmin_CellClick);
            // 
            // Btnadd
            // 
            this.Btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnadd.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Btnadd.Location = new System.Drawing.Point(29, 316);
            this.Btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(129, 32);
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
            this.btnDelete.Location = new System.Drawing.Point(29, 441);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 32);
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
            this.btnEdit.Location = new System.Drawing.Point(29, 375);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 32);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "อัพเดตสินค้า";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(52, 55);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(126, 20);
            this.nameBox.TabIndex = 20;
            // 
            // amountBox
            // 
            this.amountBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountBox.Location = new System.Drawing.Point(244, 55);
            this.amountBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(126, 20);
            this.amountBox.TabIndex = 21;
            // 
            // typeBox
            // 
            this.typeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeBox.Location = new System.Drawing.Point(52, 115);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(126, 20);
            this.typeBox.TabIndex = 22;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceBox.Location = new System.Drawing.Point(244, 115);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(126, 20);
            this.priceBox.TabIndex = 23;
            // 
            // namestock
            // 
            this.namestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namestock.AutoSize = true;
            this.namestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.namestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.namestock.Location = new System.Drawing.Point(48, 24);
            this.namestock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namestock.Name = "namestock";
            this.namestock.Size = new System.Drawing.Size(53, 28);
            this.namestock.TabIndex = 24;
            this.namestock.Text = "Name";
            // 
            // typestock
            // 
            this.typestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typestock.AutoSize = true;
            this.typestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.typestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.typestock.Location = new System.Drawing.Point(48, 84);
            this.typestock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typestock.Name = "typestock";
            this.typestock.Size = new System.Drawing.Size(47, 28);
            this.typestock.TabIndex = 25;
            this.typestock.Text = "Type";
            // 
            // amountstock
            // 
            this.amountstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountstock.AutoSize = true;
            this.amountstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.amountstock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.amountstock.Location = new System.Drawing.Point(239, 24);
            this.amountstock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountstock.Name = "amountstock";
            this.amountstock.Size = new System.Drawing.Size(67, 28);
            this.amountstock.TabIndex = 26;
            this.amountstock.Text = "Amount";
            // 
            // pricestock
            // 
            this.pricestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pricestock.AutoSize = true;
            this.pricestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pricestock.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pricestock.Location = new System.Drawing.Point(239, 84);
            this.pricestock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricestock.Name = "pricestock";
            this.pricestock.Size = new System.Drawing.Size(49, 28);
            this.pricestock.TabIndex = 27;
            this.pricestock.Text = "price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(29, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // browsebtn
            // 
            this.browsebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browsebtn.Location = new System.Drawing.Point(119, 249);
            this.browsebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(56, 24);
            this.browsebtn.TabIndex = 29;
            this.browsebtn.Text = "browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // fileBox
            // 
            this.fileBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileBox.Location = new System.Drawing.Point(19, 252);
            this.fileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(96, 20);
            this.fileBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 31;
            this.label1.Text = "รูปสินค้า";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "คำสั่ง",
            "ประวัติการขาย",
            "ข้อมูลลูกค้า"});
            this.comboBox.Location = new System.Drawing.Point(32, 35);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(131, 38);
            this.comboBox.TabIndex = 32;
            this.comboBox.Text = "คำสั่ง";
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
            this.groupBox1.Location = new System.Drawing.Point(56, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 162);
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
            this.groupBox2.Location = new System.Drawing.Point(522, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(199, 541);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // groupsellBox
            // 
            this.groupsellBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupsellBox.Controls.Add(this.label3);
            this.groupsellBox.Controls.Add(this.label2);
            this.groupsellBox.Controls.Add(this.sellBox);
            this.groupsellBox.Location = new System.Drawing.Point(32, 384);
            this.groupsellBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsellBox.Name = "groupsellBox";
            this.groupsellBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsellBox.Size = new System.Drawing.Size(678, 183);
            this.groupsellBox.TabIndex = 35;
            this.groupsellBox.TabStop = false;
            this.groupsellBox.Text = "Sell";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "บาท";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "ขายได้";
            // 
            // sellBox
            // 
            this.sellBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sellBox.Location = new System.Drawing.Point(266, 74);
            this.sellBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellBox.Name = "sellBox";
            this.sellBox.ReadOnly = true;
            this.sellBox.Size = new System.Drawing.Size(145, 32);
            this.sellBox.TabIndex = 25;
            this.sellBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxUser.Controls.Add(this.editbtn);
            this.groupBoxUser.Controls.Add(this.passBox);
            this.groupBoxUser.Controls.Add(this.addressBox);
            this.groupBoxUser.Controls.Add(this.label8);
            this.groupBoxUser.Controls.Add(this.emailBox);
            this.groupBoxUser.Controls.Add(this.teleBox);
            this.groupBoxUser.Controls.Add(this.label7);
            this.groupBoxUser.Controls.Add(this.unBox);
            this.groupBoxUser.Controls.Add(this.label6);
            this.groupBoxUser.Controls.Add(this.label5);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Location = new System.Drawing.Point(32, 384);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUser.Size = new System.Drawing.Size(678, 193);
            this.groupBoxUser.TabIndex = 36;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User Data";
            // 
            // editbtn
            // 
            this.editbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editbtn.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.editbtn.Location = new System.Drawing.Point(280, 145);
            this.editbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(129, 32);
            this.editbtn.TabIndex = 21;
            this.editbtn.Text = "แก้ไขข้อมูล";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(250, 44);
            this.passBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(148, 20);
            this.passBox.TabIndex = 18;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(274, 110);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(328, 20);
            this.addressBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(65, 110);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(184, 20);
            this.emailBox.TabIndex = 15;
            // 
            // teleBox
            // 
            this.teleBox.Location = new System.Drawing.Point(458, 44);
            this.teleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teleBox.MaxLength = 10;
            this.teleBox.Name = "teleBox";
            this.teleBox.Size = new System.Drawing.Size(146, 20);
            this.teleBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telephone";
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(65, 46);
            this.unBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unBox.Name = "unBox";
            this.unBox.ReadOnly = true;
            this.unBox.Size = new System.Drawing.Size(133, 20);
            this.unBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(732, 587);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupsellBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.TextBox teleBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button editbtn;
    }
}