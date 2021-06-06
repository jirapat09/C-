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
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Boolean checkUser()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string username = unBox.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE username = @user", conn);

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (unBox.Text == "admin")
            {
                MessageBox.Show("ห้ามใช้ชื่อ admin");
            }
            else if (checkUser())
            {
                MessageBox.Show("ชื่อ user ซ้ำ \nกรุณากรอกใหม่");
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                String sql = "INSERT INTO user (username,password,email,telephone,address) VALUES('" + unBox.Text + "','" + pwBox.Text + "','" + emailBox.Text + "','" + telBox.Text + "','" + addressBox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                this.Close();
            }
        }
    }
}
