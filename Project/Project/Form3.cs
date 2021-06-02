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
            cmd.CommandText = "SELECT * FROM stock";

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
                btnAccount.Visible = false;
                btnShop.Visible = false;
                btnMyCart.Visible = false;
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
            panelSubAccount.Visible = false;
            SubpanelAdmin.Visible = false;
            panelpay.Visible = false;
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
            if (panelSubAccount.Visible == true)
            {
                panelSubAccount.Visible = false;
            }
            if (SubpanelAdmin.Visible == true)
            {
                SubpanelAdmin.Visible = false;
            }
            if (panelpay.Visible == true)
            {
                panelpay.Visible = false;
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "gunpla";
            cmd.CommandText = "SELECT * FROM stock WHERE type='"+name+"'";
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
            cmd.CommandText = "SELECT * FROM stock WHERE type='" + name + "'";
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
            cmd.CommandText = "SELECT * FROM stock WHERE type='" + name + "'";
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

        private void CartBox_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form5()); 
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Username.Text = Program.username;
            showsub(panelSubAccount);
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
        private void Check_Click(object sender, EventArgs e)
        {
            showsub(panelpay);
        }
        private void billbtn_Click(object sender, EventArgs e)
        {
            openShowfrom(new Form7());
        }
        private void statusbtn_Click(object sender, EventArgs e)
        {

        }
        private void panel123_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataStock.CurrentRow.Selected = true;
            namestock.Text = dataStock.Rows[e.RowIndex].Cells["stock_name"].FormattedValue.ToString();
            pricestock.Text = dataStock.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            nstock.Text = dataStock.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            idstock.Text = dataStock.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            if (nstock.Text == "0")
            {
                nstock.Text = "สินค้าหมด";
                BtnCart.Visible = false;
            }
            else
            {
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

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โปรแกรมสั่งซื้อสินค้าเกี่ยวกับของเล่น\n\nขั้นตอนสั่งซื้อสินค้า\n\n1.เลือกสินค้าที่คุณต้องการโดยคลิกปุ่มหยิบลงตะกร้า\n\n2.เมื่อเลือกสินค้าครบแล้วให้คลิกปุ่มสั่งซื้อสินค้าในตะกร้าสินค้า\n\n3.เมื่อสั่งซื้อแล้ว ให้รอ Email ตอบกลับคอนเฟิร์มจากร้านภายใน 24 ชม. ก่อน\n\n4.ชำระค่าสินค้า (ต้องโอนและแจ้งโอนภายใน3วัน มิเช่นนั้นใบสั่งซื้อจะหมดอายุ)\n\n5.แจ้งการชำระเงินผ่านทางหน้าโปรแกรม","เกี่ยวกับโปรแกรม");
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            int selectedRows = dataStock.CurrentCell.RowIndex;
            int editid = Convert.ToInt32(dataStock.Rows[selectedRows].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT amount FROM stock WHERE stock_name ='" + namestock.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Program.amount = 1;
            int a = int.Parse(nstock.Text);
            Program.amount = a - Program.amount;
            if (ds.Tables[0].Rows.Count > 0)
            {
                String sql1 = "UPDATE stock SET amount = '" + Program.amount + "'WHERE id = '"+editid+"'";
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
                    String sql = "INSERT INTO mycart (name,amount,sumprice,username,image) VALUES('" + namestock.Text + "','" + "1" + "','" + pricestock.Text + "','" + Program.username + "',@Imgg)";
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
