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
    public partial class Form7 : Form
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
            cmd.CommandText = "SELECT id,name,price,status,username FROM history WHERE username = '"+Program.username+"' AND status = '"+ "โอนแล้ว(รอตรวจสอบ)" + "' OR status = '"+ "รอการโอน" + "' AND username = '"+Program.username+"'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataadmin.DataSource = ds.Tables[0].DefaultView;
        }
        private void showadmin()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,name,price,status,username FROM history ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataadmin.DataSource = ds.Tables[0].DefaultView;
        }
        public Form7()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            btnupdate.Visible = false;
            checkBox1.Visible = false;
            if (Program.username == "admin")
            {
                showadmin();
                btnupdate.Visible = true;
                checkBox1.Visible = true;
            }
            else
            {
                showhistory();
            }
        }

        private void dataadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataadmin.CurrentRow.Selected = true;
                nameBox.Text = dataadmin.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                priceBox.Text = dataadmin.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                statusBox.Text = dataadmin.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
                idlabel.Text = dataadmin.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                if (statusBox.Text == "โอนแล้ว(ตรวจสอบแล้ว)")
                {
                    Billnadd.Visible = false;
                    checkBox1.Visible = true;
                }
                else
                {
                    Billnadd.Visible = true;
                    checkBox1.Visible = true;
                }
                if (statusBox.Text == "รอการโอน")
                {
                    checkBox1.Visible = false;
                }
                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT image FROM history WHERE name = '" + nameBox.Text + "'AND id = '" + idlabel.Text + "'", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                    pictureBox1.Image = new Bitmap(ms);
                }
            }
            catch (Exception)
            {

            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                locationBox.Text = open.FileName;
            }
        }

        private void Billnadd_Click(object sender, EventArgs e)
        {
            if (locationBox.Text == "")
            {
                MessageBox.Show("กรุณาแนบรูปภาพ");
            }
            else
            {
                int selectedRows = dataadmin.CurrentCell.RowIndex;
                int editid = Convert.ToInt32(dataadmin.Rows[selectedRows].Cells["id"].Value);
                MySqlConnection conn = databaseConnection();
                byte[] image = null;
                pictureBox1.ImageLocation = locationBox.Text;
                string filepath = locationBox.Text;
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                String sql = "UPDATE history SET price = '" + priceBox.Text + "',username = '" + Program.username + "',status = '" + "โอนแล้ว(รอตรวจสอบ)"+"',date = '" + dateTimePicker.Text + "',image = @Imgg WHERE id ='"+editid+"'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                    showhistory();
                }
            }
        }
        private void QRcode_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                statusBox.Text = "โอนแล้ว(ตรวจสอบแล้ว)";
            }
            if (checkBox1.Checked == false)
            {
                statusBox.Text = "โอนแล้ว(รอตรวจสอบ)";
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            int selectedRows = dataadmin.CurrentCell.RowIndex;
            int editid = Convert.ToInt32(dataadmin.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE history SET status = '" + statusBox.Text + "' WHERE id ='" + editid + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขสำเร็จ");
                showhistory();
            }
        }
    }
}
