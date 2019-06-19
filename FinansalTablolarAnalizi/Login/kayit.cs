using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansalTablolarAnalizi
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        giris frmgiris = new giris();


        private void kayit_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("ddd, dd MMM yyy");
        }
        void Temizle()
        {
            txtCompany.Text = "";
            txtEmail.Text = "";
            txtLastname.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtSecurityQuestion.Text = "";
            txtUsername.Text = "";
            cbxBusinessType.Text = "";
            cbxCompanyType.Text = "";
            cbxQuestion.Text = "";
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Kullanici Kullanici = new Fonksiyonlar.Kullanici();
                Kullanici.user_name = txtUsername.Text;
                Kullanici.password = txtPassword.Text;
                Kullanici.name = txtName.Text;
                Kullanici.last_name = txtLastname.Text;
                Kullanici.company = txtCompany.Text;
                Kullanici.company_type = cbxCompanyType.Text;
                Kullanici.business_type = cbxBusinessType.Text;
                Kullanici.email = txtEmail.Text;
                Kullanici.security_question = txtSecurityQuestion.Text;
                DB.Kullanicis.InsertOnSubmit(Kullanici);
                DB.SubmitChanges();
                Mesajlar.YeniUserKayit("Yeni Kayit oluşturuldu" + " " + "Hoşgeldiniz Sayın" + " " + txtName.Text + " " + txtLastname.Text + "\n" + txtCompany.Text);
                Temizle();
                frmgiris.Show();
                this.Hide();
            }
            catch (Exception d)
            {
                Mesajlar.Hata(d);
            }
        }


        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            int i;
            int sayacSirket = 0;
            int sayacKullanici = 0;
            string[] Username = new string[11];
            string[] Company = new string[11];
            string Sirket = txtCompany.Text;
            string Kullanici = txtUsername.Text;
            
            string sql = "Select * From Kullanici ";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            for (i = 0; i < Username.Length; i++)
            {
                while (dr1.Read())
                {
                    Username[i] = dr1["user_name"].ToString();
                    Company[i] = dr1["company"].ToString();
                    if (Username[i]== Kullanici)
                    {
                        sayacKullanici = sayacKullanici + 1;                   
                    }
                    else if (Company[i] == Sirket)
                    {
                        sayacSirket = sayacSirket + 1;
                    }           
                }
            }
            if (txtCompany.Text != "" && txtEmail.Text != "" && txtLastname.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text !="")
            {
                if (sayacKullanici != 0)
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Zaten Var");
                }
                else if (sayacSirket != 0)
                {
                    MessageBox.Show("Böyle Bir Şirket Adı Zaten Var!");
                }
                else if (sayacSirket == 0 && sayacKullanici == 0)
                {
                    YeniKaydet();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
            
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Close();
        }
    }
}
