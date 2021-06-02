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
    public partial class Form6 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void showStockadmin()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stock";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataadmin.DataSource = ds.Tables[0].DefaultView;
        }
        private void showhistory()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT name,price,username,date FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataadmin.DataSource = ds.Tables[0].DefaultView;
        }
        public Form6()
        {
            InitializeComponent();
            showStockadmin();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM history ", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();
            Program.pricesum = 0;
            while (adapter.Read())
            {
                Program.pricesum = Program.pricesum + int.Parse(adapter.GetString("price"));
            }
            sellBox.Text = Program.pricesum.ToString();
            conn.Close();
        }
        private void dataadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox.Text == "คำสั่ง")
            {
                dataadmin.CurrentRow.Selected = true;
                nameBox.Text = dataadmin.Rows[e.RowIndex].Cells["stock_name"].FormattedValue.ToString();
                amountBox.Text = dataadmin.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
                priceBox.Text = dataadmin.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                typeBox.Text = dataadmin.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();
                fileBox.Text = "D:\\Jirapat_C#\\Project\\Stock Image\\" + nameBox.Text + ".jpg";
            }
            else if (comboBox.Text == "ประวัติการขาย")
            {
                sellBox.Text = dataadmin.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            }

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            
            MySqlCommand cmd = new MySqlCommand ("SELECT image FROM stock WHERE stock_name = '"+nameBox.Text+"'",conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                pictureBox1.Image = new Bitmap(ms);
            }
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            byte[] image = null;
            pictureBox1.ImageLocation = fileBox.Text;
            string filepath = fileBox.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            String sql = "INSERT INTO stock (stock_name,amount,price,type,image) VALUES('" + nameBox.Text + "','" + amountBox.Text + "','"+priceBox.Text+"','"+typeBox.Text+"',@Imgg)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows >0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                showStockadmin();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedRows = dataadmin.CurrentCell.RowIndex;
            int editid = Convert.ToInt32(dataadmin.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            byte[] image = null;
            pictureBox1.ImageLocation = fileBox.Text;
            string filepath = fileBox.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            String sql = "UPDATE stock SET stock_name = '" + nameBox.Text + "',amount = '" + amountBox.Text + "',price = '" + priceBox.Text + "',type = '" + typeBox.Text + "',image = @Imgg WHERE id ='"+editid+"'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                showStockadmin();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRows = dataadmin.CurrentCell.RowIndex;
            int delete = Convert.ToInt32(dataadmin.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM stock WHERE id = '" + delete + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showStockadmin();
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                fileBox.Text = open.FileName;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "คำสั่ง")
            {
                showStockadmin();
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupsellBox.Visible = false;
            }
            else if (comboBox.Text == "ประวัติการขาย")
            {
                showhistory();
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupsellBox.Visible = true;
            }
        }
    }
}
