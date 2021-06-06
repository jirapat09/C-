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
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form4()
        {
            InitializeComponent();
            unBox.Text = Program.username;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader mdr;

            string sql = "SELECT * FROM user WHERE username = '" + Program.username + "'";
            cmd = new MySqlCommand(sql, conn);

            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                labelID.Text = mdr.GetString("id");
                unBox.Text = mdr.GetString("username");
                passBox.Text = mdr.GetString("password");
                emailBox.Text = mdr.GetString("email");
                teleBox.Text = mdr.GetString("telephone");
                addressBox.Text = mdr.GetString("address");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (unBox.Text == "admin")
            {
                MessageBox.Show("ห้ามใช้ชื่อ admin");
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                String sql = "UPDATE user SET username = '" + unBox.Text + "',password = '" + passBox.Text + "',email = '" + emailBox.Text + "',telephone = '" + teleBox.Text + "',address = '" + addressBox.Text + "'WHERE id = '" + labelID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int row = cmd.ExecuteNonQuery();

                conn.Close();
                if (row > 0)
                {
                    Program.username = unBox.Text;
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
