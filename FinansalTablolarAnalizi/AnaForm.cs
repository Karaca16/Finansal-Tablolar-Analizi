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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();    
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        public string sirketadi;
        public static int Aktarma = -1;
        private void AnaForm_Load(object sender, EventArgs e)
        {       

            label2.Text = DateTime.Now.ToString("ddd, dd MMM yyy HH : mm");
            string sql = "Select * From Kullanici Where user_id = '" + giris.user_id + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                sirketadi = dr1["company"].ToString();              
               label4.Text = ("Hoşgeldiniz Sayın" + " " + dr1["name"].ToString() + " " + dr1["last_name"].ToString() + "\n" + " " + dr1["company"].ToString());
            }        
        }

        private void btn_DonenVarliklar_Click(object sender, EventArgs e)
        {
            Modul_Bilanco.frm_Donenvarliklar frm = new Modul_Bilanco.frm_Donenvarliklar();
            frm.ShowDialog();
        }
        private void btn_DuranVarliklar_Click(object sender, EventArgs e)
        {
            Modul_Bilanco.frm_DuranVarliklar frm = new Modul_Bilanco.frm_DuranVarliklar();
            frm.ShowDialog();

        }

        private void btn_KVYK_Click(object sender, EventArgs e)
        {
            Modul_Bilanco.frm_KVYK frm = new Modul_Bilanco.frm_KVYK();
            frm.ShowDialog();
        }

        private void btn_UVYK_Click(object sender, EventArgs e)
        {
            Modul_Bilanco.frm_UVYK frm = new Modul_Bilanco.frm_UVYK();
            frm.ShowDialog();
        }

        private void btn_Özkaynak_Click(object sender, EventArgs e)
        {
            Modul_Bilanco.frm_Ozkaynak frm = new Modul_Bilanco.frm_Ozkaynak();
            frm.ShowDialog();
        }

        private void btn_Analiz_Click(object sender, EventArgs e)
        {
            Modul_Analiz.frm_Analizler frm = new Modul_Analiz.frm_Analizler();
            frm.ShowDialog();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
             
    }
}
