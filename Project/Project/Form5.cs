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
    public partial class Form5 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void showuserStock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM mycart WHERE username = '"+Program.username+"'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datauserstock.DataSource = ds.Tables[0].DefaultView;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showuserStock();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mycart WHERE username = '" + Program.username + "'", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();
            Program.pricesum = 0;
            while (adapter.Read())
            {
                Program.pricesum = Program.pricesum + int.Parse(adapter.GetString("sumprice"));
            }
            ///sumBox.Text = Program.pricesum.ToString();
            btnOut.Visible = false;
            conn.Close();
        }

        private void datauserstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                datauserstock.CurrentRow.Selected = true;
                labelname.Text = datauserstock.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                labelprice.Text = datauserstock.Rows[e.RowIndex].Cells["sumprice"].FormattedValue.ToString();
                labelamount.Text = datauserstock.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
                if (labelprice.Text == "0")
                {
                    labelamount.Text = "สั่งแล้ว";
                    labelprice.Text = "สั่งแล้ว";
                    btnOut.Visible = false;
                }
                else
                {
                    btnOut.Visible = true;
                }

                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT image FROM mycart WHERE name = '" + labelname.Text + "'", conn);
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            int selectedRows = datauserstock.CurrentCell.RowIndex;
            int delete = Convert.ToInt32(datauserstock.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT amount FROM stock WHERE stock_name ='" + labelname.Text + "'", conn);
            DataSet ds = new DataSet();
            MySqlDataReader adap = cmd.ExecuteReader();
            Program.amountcart = int.Parse(labelamount.Text);
            while (adap.Read())
            {
                Program.amountcart = Program.amountcart + int.Parse(adap.GetString("amount"));
            }
            conn.Close();
            if ( Program.amountcart > 0)
            {
                String sql1 = "UPDATE stock SET amount = '" + Program.amountcart + "'WHERE stock_name ='"+labelname.Text+"'";
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows = cmd1.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    String sql = "DELETE FROM mycart WHERE id = '" + delete.ToString() + "' AND username = '" + Program.username + "'";
                    MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows1 = cmd2.ExecuteNonQuery();
                    conn.Close();
                    if (rows1 > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ");
                        showuserStock();
                    }
                }
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการสั้งสินค้านี้หรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedRows = datauserstock.CurrentCell.RowIndex;
                int delete = Convert.ToInt32(datauserstock.Rows[selectedRows].Cells["id"].Value);
                MySqlConnection conn = databaseConnection();
                Image img = pictureBox1.Image;
                byte[] arr = null;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                String sql = "INSERT INTO history (name,price,status,username,image) VALUES('"+labelname.Text+"','"+labelprice.Text+"','"+"รอการโอน"+"','"+Program.username+"',@Imgg)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add(new MySqlParameter("@Imgg", arr));
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    String sql1 = "DELETE FROM mycart WHERE id = '" + delete.ToString() + "' AND username = '" + Program.username + "'";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    conn.Open();
                    int rows1 = cmd1.ExecuteNonQuery();
                    conn.Close();
                    if (rows1 > 0)
                    MessageBox.Show("สั่งซื้อสำเร็จ");
                    showuserStock();
                }
            }
            else
            {
                
            }
            
        }
    }
}
