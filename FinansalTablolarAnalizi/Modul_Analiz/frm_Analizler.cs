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

namespace FinansalTablolarAnalizi.Modul_Analiz
{
    public partial class frm_Analizler : Form
    {
        public frm_Analizler()
        {
            InitializeComponent();
        }
        float DonenVarlik, KisaVadeliBorc;
        float Sonuc;

        private void frm_Analizler_Load(object sender, EventArgs e)
        {
            string[] KayitAdi = new string[30];
            string sql = "Select * From AktifPasif ";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            for (int i = 0; i < KayitAdi.Length; i++)
            {
                while (dr1.Read())
                {
                    KayitAdi[i] = dr1["kayit_adi"].ToString();
                    cmb_Baslik.Items.Add(KayitAdi[i].ToString());
                }
            }

        }

        private void cmb_Baslik_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "";
            txt_Analiz.Text = "";
            string sql1 = "Select * From DonenVarlik where kayit_adi = '" + cmb_Baslik.Text + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql1);
            if (dr1.Read())
            {
                txt_Donen.Text = dr1["donenvarlik_toplami"].ToString();

            }
            string sql = "Select * From KVYK where kayit_adi = '" + cmb_Baslik.Text + "'";
            SqlDataReader dr = ConnectionQuerry.DataReader(sql);
            if (dr.Read())
            {
                txt_kvyk.Text = dr["kvyk_toplami"].ToString();

            }

            DonenVarlik = float.Parse(txt_Donen.Text);
            KisaVadeliBorc = float.Parse(txt_kvyk.Text);

        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            Sonuc = (DonenVarlik / KisaVadeliBorc);
            MessageBox.Show("Cari Oran Sonucu =" + " " + Sonuc.ToString());
            txt_Sonuc.Text = Sonuc.ToString();
            if (Sonuc > 2)
            {
                txt_Analiz.Text = "İşletmenizin cari oran sonucu " + Sonuc.ToString() + " " + "olarak gözüküyor.Oranın 2'nin üzerinde olması sektör ortalamasının üzerinde olduğu için yeterli bir orandır. Ek olarak"+" " + KisaVadeliBorc.ToString()+" " + "Olan KVYK oranı biraz düşürülebilir.";
            }
            else
            {
                txt_Analiz.Text = "Cari oran sonucu " + Sonuc.ToString() + " " + "Cari oran sonucunuz 2 nin altında gözüküyor.Oran kritik seviyededir.En kısa zamanda"+ " " + DonenVarlik.ToString() + " " + "Olan Dönen Varlık miktarı arttırılmalıdır. ";
            }

        }
    }
}



