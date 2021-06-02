
namespace Project
{
    partial class Form5
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
            this.datauserstock = new System.Windows.Forms.DataGridView();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.labelamount = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datauserstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datauserstock
            // 
            this.datauserstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datauserstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datauserstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datauserstock.Location = new System.Drawing.Point(35, 89);
            this.datauserstock.Name = "datauserstock";
            this.datauserstock.RowHeadersWidth = 51;
            this.datauserstock.RowTemplate.Height = 24;
            this.datauserstock.Size = new System.Drawing.Size(581, 311);
            this.datauserstock.TabIndex = 0;
            this.datauserstock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datauserstock_CellClick);
            // 
            // BtnBuy
            // 
            this.BtnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnBuy.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuy.Location = new System.Drawing.Point(117, 541);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(212, 40);
            this.BtnBuy.TabIndex = 16;
            this.BtnBuy.Text = "สั่งซื้อสินค้า";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(686, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnOut
            // 
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOut.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(370, 541);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(186, 40);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "นำออกจากตะกร้า";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // labelamount
            // 
            this.labelamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelamount.AutoSize = true;
            this.labelamount.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamount.Location = new System.Drawing.Point(147, 462);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(99, 50);
            this.labelamount.TabIndex = 30;
            this.labelamount.Text = "จำนวน";
            // 
            // labelname
            // 
            this.labelname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(108, 403);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(61, 50);
            this.labelname.TabIndex = 29;
            this.labelname.Text = "ชื่ิอ ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 50);
            this.label5.TabIndex = 28;
            this.label5.Text = "ราคา";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 50);
            this.label2.TabIndex = 27;
            this.label2.Text = "ชื่ิอ ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 50);
            this.label3.TabIndex = 31;
            this.label3.Text = "จำนวน";
            // 
            // labelprice
            // 
            this.labelprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(530, 462);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(79, 50);
            this.labelprice.TabIndex = 32;
            this.labelprice.Text = "ราคา";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1010, 629);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.datauserstock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datauserstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datauserstock;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelprice;
    }
}