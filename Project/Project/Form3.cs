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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void showStock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id,stock_name,amount,price,type FROM stock";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataStock.DataSource = ds.Tables[0].DefaultView;
        }
        public Form3()
        {
            InitializeComponent();
            DesingSide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Username.Text = Program.username;
            showStock();
            if (Program.username == "admin")
            {
                btnAdmin.Visible = true;
                btnOrder.Visible = true;
                btnShop.Visible = false;
                btnMyCart.Visible = false;
                btnAccount.Visible = false;
                openShowfrom(new Form6());
            }
            else
            {
                btnAdmin.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openShowfrom(Form showFormMenu)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = showFormMenu;
            showFormMenu.TopLevel = false;
            showFormMenu.FormBorderStyle = FormBorderStyle.None;
            showFormMenu.Dock = DockStyle.Fill;
            panelShowform.Controls.Add(showFormMenu);
            panelShowform.Tag = showFormMenu;
            showFormMenu.BringToFront();
            showFormMenu.Show();
        }
        private void DesingSide()
        {
            panelShopSub.Visible=false;
            panelSubMycart.Visible = false;
            panelSubOrder.Visible = false;
            SubpanelAdmin.Visible = false;
            panelsubaccount.Visible = false;
        }
        private void hideSub()
        {
            if (panelShopSub.Visible == true)
            {
                panelShopSub.Visible = false;
            }
            if (panelSubMycart.Visible == true)
            {
                panelSubMycart.Visible = false;
            }
            if (panelSubOrder.Visible == true)
            {
                panelSubOrder.Visible = false;
            }
            if (SubpanelAdmin.Visible == true)
            {
                SubpanelAdmin.Visible = false;
            }
            if (panelsubaccount.Visible == true)
            {
                panelsubaccount.Visible = false;
            }
        }
        private void showsub(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSub();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnShop_Click_1(object sender, EventArgs e)
        {
            Username.Text = Program.username;
            showsub(panelShopSub);
            showStock();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "gunpla";
            cmd.CommandText = "SELECT id,stock_name,amount,price,type FROM stock WHERE type='" + name+"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataStock.DataSource = ds.Tables[0].DefaultView;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "figure";
            cmd.CommandText = "SELECT id,stock_name,amount,price,type FROM stock WHERE type='" + name + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataStock.DataSource = ds.Tables[0].DefaultView;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "tool";
            cmd.CommandText = "SELECT id,stock_name,amount,price,type FROM stock WHERE type='" + name + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataStock.DataSource = ds.Tables[0].DefaultView;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        private void btnMyCart_Click(object sender, EventArgs e)
        {
            Username.Text = Program.username;
            showsub(panelSubMycart);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Username.Text = Program.username;
            showsub(panelSubOrder);
        }

        private void CartBox_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form5()); 
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btnExitmenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showsub(SubpanelAdmin);
        }
        private void btnCommands_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form6());
        }

        private void btnLogotAD_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }
        private void Account_Click(object sender, EventArgs e)
        {
            showsub(panelsubaccount);
        }
        private void billbtn_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form7());
        }
        private void historybill_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form8());
        }
        private void panel123_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataStock.CurrentRow.Selected = true;
                namestock.Text = dataStock.Rows[e.RowIndex].Cells["stock_name"].FormattedValue.ToString();
                pricestock.Text = dataStock.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                nstock.Text = dataStock.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
                idstock.Text = dataStock.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                numericUpDown.Maximum = int.Parse(nstock.Text);
                if (nstock.Text == "0")
                {
                    nstock.Text = "สินค้าหมด";
                    BtnCart.Visible = false;
                    labelnum.Visible = false;
                    numericUpDown.Visible = false;
                }
                else
                {
                    labelnum.Visible = true;
                    numericUpDown.Visible = true;
                    BtnCart.Visible = true;
                }

                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT image FROM stock WHERE stock_name = '" + namestock.Text + "'", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                    picturestock.Image = new Bitmap(ms);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FB : Jirapat Thongkhamwan \n\nLine : j4meza\n\nEmail : jamekung1234.1112@gmail.com\n\nTel. :098-242-5520","Contact");
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            int selectedRows = dataStock.CurrentCell.RowIndex;
            int editid = Convert.ToInt32(dataStock.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT amount FROM stock WHERE stock_name ='" + namestock.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Program.amountcart = int.Parse(numericUpDown.Text);
            int amount = int.Parse(nstock.Text);
            int price = int.Parse(pricestock.Text);
            Program.price = price * Program.amountcart;
            amount = amount - Program.amountcart;
            if (ds.Tables[0].Rows.Count > 0)
            {
                String sql1 = "UPDATE stock SET amount = '" + amount + "'WHERE id = '"+editid+"'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql1, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    Image img = picturestock.Image;
                    byte[] arr = null;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    String sql = "INSERT INTO mycart (name,amount,sumprice,username,image) VALUES('" + namestock.Text + "','" + Program.amountcart + "','" + Program.price + "','" + Program.username + "',@Imgg)";
                    conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.Add(new MySqlParameter("@Imgg", arr));
                    int rows1 = cmd1.ExecuteNonQuery();
                    conn.Close();
                    if (rows1 > 0)
                    {
                        MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                        showStock();
                    }
                }
            }
        }
    }
}
