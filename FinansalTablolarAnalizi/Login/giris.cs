using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace FinansalTablolarAnalizi
{
    public partial class giris : Form
    {

        public giris()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=IBRAHIM-KARACA\\MSSQLSERVER01;Initial Catalog=Finans;Integrated Security=True");
        public static string user_id;
        public static string sirket_adi;
        public static string kullanici_adi;

        private void giris_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {           
            string sql = "Select * From Kullanici Where user_name = '" + txtUser.Text + "'AND password = '" + txtPassword.Text + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                user_id = dr1["user_id"].ToString();
                sirket_adi = dr1["company"].ToString();
                kullanici_adi = dr1["name"].ToString();

            }

            string sorgu = " Select * From Kullanici Where user_name = @user_name AND password = @password";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cmd.Parameters.AddWithValue("@user_name", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                cnn.Close();

            }
             
        }
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kayit frm = new kayit();
            frm.Show();
            this.Hide();
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.White;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel1.BackColor = Color.White;
        }
    }
}



