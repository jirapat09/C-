using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form1()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
        }
        private Form activeForm = null;
        private void openShowfrom(Form showFormlogin)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = showFormlogin;
            showFormlogin.TopLevel = false;
            showFormlogin.FormBorderStyle = FormBorderStyle.None;
            showFormlogin.Dock = DockStyle.Fill;
            panelShowFLogin.Controls.Add(showFormlogin);
            panelShowFLogin.Tag = showFormlogin;
            showFormlogin.BringToFront();
            showFormlogin.Show();
        }
        private void LonginBtn_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username = '" + usernameBox.Text + "'AND password = '" + passwordBox.Text + "'";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.Read())
            {
                Program.username = usernameBox.Text;
                MessageBox.Show("login สำเร็จ");
                Form3 menu = new Form3();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username หรือ Password ผิด");
            }
            conn.Close();
        }

        private void RegBtn_Click_1(object sender, EventArgs e)
        {
            openShowfrom(new Form2());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false)
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
