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

namespace FinansalTablolarAnalizi.Modul_Bilanco
{
    public partial class frm_Ozkaynak : Form
    {
        public frm_Ozkaynak()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;
        bool Edit = false;
        bool SecimToplam = false;
        public string sirketadi;
        public decimal sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12, sayi13, sayi14, sayi15, sayi16, toplam, P1, P2, PToplam;
        private void frm_Ozkaynak_Load(object sender, EventArgs e)
        {
            Desing();
            string sql = "Select * From Kullanici Where user_id = '" + giris.user_id + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                sirketadi = dr1["company"].ToString();

            }
            Göster();
        }
        void Göster()
        {
            var Listele = from s in DB.Ozkaynaks
                          select s;
            lst.DataSource = Listele;
        }
        void Temizle()
        {
            Edit = false;
            SecimID = -1;
            txt_DagilmamisSermaye.Text = "";
            txt_DonemZarar.Text = "";
            txt_EmisyonPrimi.Text = "";
            txt_GecmisYilk.Text = "";
            txt_GemisYilz.Text = "";
            txt_İlaveÖdenmis.Text = "";
            txt_KarYedekleri.Text = "";
            txt_KatkiSermaye.Text = "";
            txt_DonemKar.Text = "";
            txt_OdenmeyenSermaye.Text = "";
            txt_Sermaye.Text = "";
            txt_SermayeAvansi.Text = "";
            txt_SermayeYedekleri.Text = "";
            txt_YatirimTesfikleri.Text = "";
            txt_YenidenDegerleme.Text = "";
            txt_ZararTelafi.Text = "";
            Göster();

        }
        void YeniKaydet()
        {
            try
            {
                OzkaynakToplam();
                Fonksiyonlar.Ozkaynak Ozkaynak = new Fonksiyonlar.Ozkaynak();
                Ozkaynak.dagilmamis_sermaye = decimal.Parse(txt_DagilmamisSermaye.Text);
                Ozkaynak.emisyon_primi = decimal.Parse(txt_EmisyonPrimi.Text);
                Ozkaynak.gecmisyil_kar = decimal.Parse(txt_GecmisYilk.Text);
                Ozkaynak.gecmisyil_zarar = decimal.Parse(txt_GemisYilz.Text);
                Ozkaynak.iodenmis_sermaye = decimal.Parse(txt_İlaveÖdenmis.Text);
                Ozkaynak.kar_yedekleri = decimal.Parse(txt_KarYedekleri.Text);
                Ozkaynak.katki_sermaye = decimal.Parse(txt_KatkiSermaye.Text);
                Ozkaynak.netdonem_kari = decimal.Parse(txt_DonemKar.Text);
                Ozkaynak.netdonem_zarari = decimal.Parse(txt_DonemZarar.Text);
                Ozkaynak.odenmeyen_sermaye = decimal.Parse(txt_OdenmeyenSermaye.Text);
                Ozkaynak.sermaye = decimal.Parse(txt_Sermaye.Text);
                Ozkaynak.sermaye_avansi = decimal.Parse(txt_SermayeAvansi.Text);
                Ozkaynak.sermaye_yedekleri = decimal.Parse(txt_SermayeYedekleri.Text);
                Ozkaynak.yatirim_tesfikleri = decimal.Parse(txt_YatirimTesfikleri.Text);
                Ozkaynak.yeniden_degerleme = decimal.Parse(txt_YenidenDegerleme.Text);
                Ozkaynak.zarartelafi_fonu = decimal.Parse(txt_ZararTelafi.Text);
                Ozkaynak.kayit_adi = frm_Donenvarliklar.KayitAdi;
                Ozkaynak.sirket_adi = sirketadi;
                Ozkaynak.ozkaynak_toplami = toplam;
                DB.Ozkaynaks.InsertOnSubmit(Ozkaynak);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Veri Girişi Yapıldı!");
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

        }
        void OzkaynakToplam()
        {
            sayi1 = decimal.Parse(txt_DagilmamisSermaye.Text);
            sayi2 = decimal.Parse(txt_EmisyonPrimi.Text);
            sayi3 = decimal.Parse(txt_GecmisYilk.Text);
            sayi4 = decimal.Parse(txt_GemisYilz.Text);
            sayi5 = decimal.Parse(txt_İlaveÖdenmis.Text);
            sayi6 = decimal.Parse(txt_KarYedekleri.Text);
            sayi7 = decimal.Parse(txt_KatkiSermaye.Text);
            sayi8 = decimal.Parse(txt_DonemKar.Text);
            sayi9 = decimal.Parse(txt_OdenmeyenSermaye.Text);
            sayi10 = decimal.Parse(txt_Sermaye.Text);
            sayi11 = decimal.Parse(txt_SermayeAvansi.Text);
            sayi12 = decimal.Parse(txt_SermayeYedekleri.Text);
            sayi13 = decimal.Parse(txt_YatirimTesfikleri.Text);
            sayi14 = decimal.Parse(txt_YenidenDegerleme.Text);
            sayi15 = decimal.Parse(txt_ZararTelafi.Text);
            sayi16 = decimal.Parse(txt_DonemZarar.Text);
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12 + sayi13 + sayi14 + sayi15 + sayi16;

        }
        void Güncelle()
        {
            try
            {
                OzkaynakToplam();
                Fonksiyonlar.Ozkaynak Ozkaynak = DB.Ozkaynaks.First(s => s.ozkaynak_id == SecimID);
                Ozkaynak.dagilmamis_sermaye = decimal.Parse(txt_DagilmamisSermaye.Text);
                Ozkaynak.emisyon_primi = decimal.Parse(txt_EmisyonPrimi.Text);
                Ozkaynak.gecmisyil_kar = decimal.Parse(txt_GecmisYilk.Text);
                Ozkaynak.gecmisyil_zarar = decimal.Parse(txt_GemisYilz.Text);
                Ozkaynak.iodenmis_sermaye = decimal.Parse(txt_İlaveÖdenmis.Text);
                Ozkaynak.kar_yedekleri = decimal.Parse(txt_KarYedekleri.Text);
                Ozkaynak.katki_sermaye = decimal.Parse(txt_KatkiSermaye.Text);
                Ozkaynak.netdonem_kari = decimal.Parse(txt_DonemKar.Text);
                Ozkaynak.netdonem_zarari = decimal.Parse(txt_DonemZarar.Text);
                Ozkaynak.odenmeyen_sermaye = decimal.Parse(txt_OdenmeyenSermaye.Text);
                Ozkaynak.sermaye = decimal.Parse(txt_Sermaye.Text);
                Ozkaynak.sermaye_avansi = decimal.Parse(txt_SermayeAvansi.Text);
                Ozkaynak.sermaye_yedekleri = decimal.Parse(txt_SermayeYedekleri.Text);
                Ozkaynak.yatirim_tesfikleri = decimal.Parse(txt_YatirimTesfikleri.Text);
                Ozkaynak.yeniden_degerleme = decimal.Parse(txt_YenidenDegerleme.Text);
                Ozkaynak.zarartelafi_fonu = decimal.Parse(txt_ZararTelafi.Text);
                // Ozkaynak.ozkaynak_ay = DateTime.Now.ToString("MMMM");
                // Ozkaynak.sirket_adi = sirketadi;
                Ozkaynak.ozkaynak_toplami = toplam;
                Mesajlar.Güncelle(true);
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }



        }
        void Sec()
        {
            Edit = true;
            SecimToplam = true;
            SecimID = int.Parse(lst.CurrentRow.Cells["ozkaynak_id"].Value.ToString());
            txt_DagilmamisSermaye.Text = lst.CurrentRow.Cells["dagilmamis_sermaye"].Value.ToString();
            txt_DonemKar.Text = lst.CurrentRow.Cells["netdonem_kari"].Value.ToString();
            txt_DonemZarar.Text = lst.CurrentRow.Cells["netdonem_zarari"].Value.ToString();
            txt_EmisyonPrimi.Text = lst.CurrentRow.Cells["emisyon_primi"].Value.ToString();
            txt_GecmisYilk.Text = lst.CurrentRow.Cells["gecmisyil_kar"].Value.ToString();
            txt_GemisYilz.Text = lst.CurrentRow.Cells["gecmisyil_zarar"].Value.ToString();
            txt_İlaveÖdenmis.Text = lst.CurrentRow.Cells["iodenmis_sermaye"].Value.ToString();
            txt_KarYedekleri.Text = lst.CurrentRow.Cells["kar_yedekleri"].Value.ToString();
            txt_KatkiSermaye.Text = lst.CurrentRow.Cells["katki_sermaye"].Value.ToString();
            txt_OdenmeyenSermaye.Text = lst.CurrentRow.Cells["odenmeyen_sermaye"].Value.ToString();
            txt_Sermaye.Text = lst.CurrentRow.Cells["sermaye"].Value.ToString();
            txt_SermayeAvansi.Text = lst.CurrentRow.Cells["sermaye_avansi"].Value.ToString();
            txt_SermayeYedekleri.Text = lst.CurrentRow.Cells["sermaye_yedekleri"].Value.ToString();
            txt_YatirimTesfikleri.Text = lst.CurrentRow.Cells["yatirim_tesfikleri"].Value.ToString();
            txt_YenidenDegerleme.Text = lst.CurrentRow.Cells["yeniden_degerleme"].Value.ToString();
            txt_ZararTelafi.Text = lst.CurrentRow.Cells["zarartelafi_fonu"].Value.ToString();
            if (SecimToplam == true)
            {
                OzkaynakToplam();
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_OzkaynakToplam.Text = nsayi + " " + "TL";
                lbl_OzkaynakToplam.Visible = true;
                label16.Visible = true;
                label16.ForeColor = Color.Brown;
                label16.Text = "Seçilen Kaydın Toplamı :";
            }

        }
        void Sil()
        {
            DB.Ozkaynaks.DeleteOnSubmit(DB.Ozkaynaks.First(s => s.ozkaynak_id == SecimID));
            DB.SubmitChanges();
            Temizle();

        }
        void PasifKaydet()
        {
            string sql = "Select * From KVYK Where kayit_adi ='" + frm_Donenvarliklar.KayitAdi + "'";
            SqlDataReader dr = ConnectionQuerry.DataReader(sql);
            if (dr.Read())
            {
                P1 = decimal.Parse(dr["kvyk_toplami"].ToString());

            }
            string sql1 = "Select * From UVYK Where kayit_adi ='" + frm_Donenvarliklar.KayitAdi + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql1);
            if (dr1.Read())
            {
                P2 = decimal.Parse(dr1["uvyk_toplami"].ToString());

            }


            PToplam = P1 + P2 + toplam;
            Fonksiyonlar.AktifPasif AktifPasif = new Fonksiyonlar.AktifPasif();
            AktifPasif.pasif_toplam = PToplam;
            AktifPasif.aktif_toplam = frm_DuranVarliklar.AToplam;
            AktifPasif.sirket_adi = sirketadi;
            AktifPasif.kayit_adi = frm_Donenvarliklar.KayitAdi;
            DB.AktifPasifs.InsertOnSubmit(AktifPasif);
            DB.SubmitChanges();
        }
        void Desing()
        {
            lst.BorderStyle = BorderStyle.None;
            lst.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lst.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lst.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lst.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lst.BackgroundColor = Color.White;
            lst.EnableHeadersVisualStyles = false;
            lst.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lst.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 30, 72);
            lst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SecimToplam = false;
            YeniKaydet();
            PasifKaydet();
            if (SecimToplam == false)
            {
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_OzkaynakToplam.Text = nsayi + " " + "TL";
                lbl_OzkaynakToplam.Visible = true;
                label16.Visible = true;
                label16.ForeColor = Color.Green;
                label16.Text = "Kaydedilen Özkaynak Verisi :";
            }
        }
        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
                lbl_OzkaynakToplam.Visible = false;
                label16.Visible = false;

            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
                lbl_OzkaynakToplam.Visible = false;
                label16.Visible = false;
            }
        }
        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }


    }
}
