
namespace Project
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.dataadmin = new System.Windows.Forms.DataGridView();
            this.Billnadd = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QRcode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(454, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 60);
            this.label1.TabIndex = 36;
            this.label1.Text = "รูป";
            // 
            // priceBox
            // 
            this.priceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceBox.Location = new System.Drawing.Point(621, 553);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(202, 22);
            this.priceBox.TabIndex = 35;
            // 
            // browsebtn
            // 
            this.browsebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browsebtn.Location = new System.Drawing.Point(767, 595);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(80, 30);
            this.browsebtn.TabIndex = 34;
            this.browsebtn.Text = "browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // dataadmin
            // 
            this.dataadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataadmin.Location = new System.Drawing.Point(38, 30);
            this.dataadmin.Name = "dataadmin";
            this.dataadmin.RowHeadersWidth = 51;
            this.dataadmin.RowTemplate.Height = 24;
            this.dataadmin.Size = new System.Drawing.Size(363, 409);
            this.dataadmin.TabIndex = 32;
            this.dataadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataadmin_CellClick);
            // 
            // Billnadd
            // 
            this.Billnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Billnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Billnadd.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Billnadd.Location = new System.Drawing.Point(583, 658);
            this.Billnadd.Name = "Billnadd";
            this.Billnadd.Size = new System.Drawing.Size(177, 40);
            this.Billnadd.TabIndex = 37;
            this.Billnadd.Text = "ส่งหลักฐาน";
            this.Billnadd.UseVisualStyleBackColor = false;
            this.Billnadd.Click += new System.EventHandler(this.Billnadd_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(621, 506);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(166, 22);
            this.dateTimePicker.TabIndex = 38;
            // 
            // locationBox
            // 
            this.locationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBox.Location = new System.Drawing.Point(621, 599);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(139, 22);
            this.locationBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 40;
            this.label2.Text = "จำนวนเงิน";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 35);
            this.label3.TabIndex = 41;
            this.label3.Text = "วันที่";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 35);
            this.label4.TabIndex = 42;
            this.label4.Text = "หลักฐานการโอน";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "ชื่อสินค้า";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(621, 457);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(202, 22);
            this.nameBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 48);
            this.label6.TabIndex = 46;
            this.label6.Text = "สถานะ :";
            // 
            // QRcode
            // 
            this.QRcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QRcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.QRcode.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.QRcode.Location = new System.Drawing.Point(137, 595);
            this.QRcode.Name = "QRcode";
            this.QRcode.Size = new System.Drawing.Size(177, 145);
            this.QRcode.TabIndex = 49;
            this.QRcode.Text = "QR CODE";
            this.QRcode.UseVisualStyleBackColor = false;
            this.QRcode.Click += new System.EventHandler(this.QRcode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(187, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 737);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Project.Properties.Resources._192547907_144650097717251_2042443533177255376_n;
            this.pictureBox2.Location = new System.Drawing.Point(134, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 575);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(525, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClose.Location = new System.Drawing.Point(211, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 45);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusBox
            // 
            this.statusBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusBox.Location = new System.Drawing.Point(150, 472);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(202, 22);
            this.statusBox.TabIndex = 51;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnupdate.Location = new System.Drawing.Point(187, 518);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 44);
            this.btnupdate.TabIndex = 52;
            this.btnupdate.Text = "แก้ไข";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(976, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.QRcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Billnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataadmin;
        private System.Windows.Forms.Button Billnadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button QRcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button btnupdate;
    }
}