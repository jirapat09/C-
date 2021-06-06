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
using System.IO;

namespace Project
{
    public partial class Form8 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void showhistory()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT name,price,username,date FROM history WHERE username = '"+Program.username+"'AND status = '"+ "โอนแล้ว(ตรวจสอบแล้ว)" + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataHistory.DataSource = ds.Tables[0].DefaultView;
        }
        private void showhistoryadmin()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT name,price,username,date FROM history WHERE status = '" + "โอนแล้ว(ตรวจสอบแล้ว)" + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataHistory.DataSource = ds.Tables[0].DefaultView;
        }
        public Form8()
        {
            InitializeComponent();
            if (Program.username == "admin")
            {
                showhistoryadmin();
            }
            else
            {
                showhistory();
            }
        }
    }
}
