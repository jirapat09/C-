
namespace Project
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.teleBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username   #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(100, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(100, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(488, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telephonenumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(488, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(106, 220);
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(296, 22);
            this.unBox.TabIndex = 10;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(106, 301);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(296, 22);
            this.passBox.TabIndex = 11;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(106, 381);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(296, 22);
            this.emailBox.TabIndex = 12;
            // 
            // teleBox
            // 
            this.teleBox.Location = new System.Drawing.Point(494, 220);
            this.teleBox.MaxLength = 10;
            this.teleBox.Name = "teleBox";
            this.teleBox.Size = new System.Drawing.Size(373, 22);
            this.teleBox.TabIndex = 13;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(494, 301);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(373, 99);
            this.addressBox.TabIndex = 14;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editBtn.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(272, 476);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(141, 42);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "แก้ไขข้อมูล";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Green;
            this.logo.Location = new System.Drawing.Point(310, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 100);
            this.logo.TabIndex = 16;
            this.logo.Text = "ข้อมูลผู้ใช้";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backBtn.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.backBtn.Location = new System.Drawing.Point(475, 476);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(119, 42);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "ย้อนกลับ";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Layiji MaHaNiYom BAO OT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelID.Location = new System.Drawing.Point(255, 182);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 35);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(929, 713);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.teleBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.unBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox teleBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label labelID;
    }
}