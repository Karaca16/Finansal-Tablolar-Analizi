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
    public partial class frm_KVYK : Form
    {
        public frm_KVYK()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;
        bool Edit = false;
        bool SecimToplam = false;
        public string sirketadi;
        public decimal sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12, sayi13, sayi14, toplam;

        private void frm_KVYK_Load(object sender, EventArgs e)
        {
            Design();
            lbl_KVYK.Visible = false;
            label16.Visible = false;
            string sql = "Select * From Kullanici Where user_id = '" + giris.user_id + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                sirketadi = dr1["company"].ToString();
            }
            Göster();
        }
        void YeniKaydet()
        {
            try
            {
                kvykToplam();

                Fonksiyonlar.KVYK KVYK = new Fonksiyonlar.KVYK();
                KVYK.alinan_avanslar = decimal.Parse(txt_AlınanAvanslar.Text);
                KVYK.alinan_krediler = decimal.Parse(txt_AlınanKrediler.Text);
                KVYK.bloke_hesaplar = decimal.Parse(txt_BlokeHesap.Text);
                KVYK.borcgider_karsiligi = decimal.Parse(txt_BorçGiderK.Text);
                KVYK.dfinansal_yukumluluk = decimal.Parse(txt_dFinansal_Y.Text);
                KVYK.diger_borclar = decimal.Parse(txt_DigerBorc.Text);
                KVYK.ertelenmis_gelirler = decimal.Parse(txt_ErtelenmisGelirler.Text);
                KVYK.factoring_borclar = decimal.Parse(txt_Factoring.Text);
                KVYK.finansal_borclar = decimal.Parse(txt_FinansalBorç.Text);
                KVYK.iliskili_borclar = decimal.Parse(txt_IliskiliTaraflaraB.Text);
                KVYK.mevduat = decimal.Parse(txt_Mevduat.Text);
                KVYK.sigorta_karsiligi = decimal.Parse(txt_SigortaKarsiligi.Text);
                KVYK.turev_araclar = decimal.Parse(txt_TürevArac.Text);
                KVYK.ticari_borclar = decimal.Parse(txt_TicariBorc.Text);
                KVYK.kayit_adi = frm_Donenvarliklar.KayitAdi;
                KVYK.kvyk_toplami = toplam;
                KVYK.sirket_adi = sirketadi;
                DB.KVYKs.InsertOnSubmit(KVYK);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Veri Girişi Yapıldı" + " " + sirketadi);
                Göster();
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

        }
        void Göster()
        {
            var Listele = from s in DB.KVYKs
                          where s.sirket_adi.Contains(sirketadi)
                          select s;
            lst.DataSource = Listele;

        }
        void Temizle()
        {
            Edit = false;
            SecimID = -1;
            txt_AlınanAvanslar.Text = "";
            txt_AlınanKrediler.Text = "";
            txt_BlokeHesap.Text = "";
            txt_BorçGiderK.Text = "";
            txt_dFinansal_Y.Text = "";
            txt_DigerBorc.Text = "";
            txt_ErtelenmisGelirler.Text = "";
            txt_Factoring.Text = "";
            txt_FinansalBorç.Text = "";
            txt_IliskiliTaraflaraB.Text = "";
            txt_Mevduat.Text = "";
            txt_SigortaKarsiligi.Text = "";
            txt_TicariBorc.Text = "";
            txt_TürevArac.Text = "";
        }
        void Sil()
        {
            try
            {
                DB.KVYKs.DeleteOnSubmit(DB.KVYKs.First(s => s.kvyk_id == SecimID));
                DB.SubmitChanges();
                Temizle();
                Göster();
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
            SecimID = int.Parse(lst.CurrentRow.Cells["kvyk_id"].Value.ToString());
            txt_AlınanAvanslar.Text = lst.CurrentRow.Cells["alinan_avanslar"].Value.ToString();
            txt_AlınanKrediler.Text = lst.CurrentRow.Cells["alinan_krediler"].Value.ToString();
            txt_BlokeHesap.Text = lst.CurrentRow.Cells["bloke_hesaplar"].Value.ToString();
            txt_BorçGiderK.Text = lst.CurrentRow.Cells["borcgider_karsiligi"].Value.ToString();
            txt_dFinansal_Y.Text = lst.CurrentRow.Cells["dfinansal_yukumluluk"].Value.ToString();
            txt_DigerBorc.Text = lst.CurrentRow.Cells["diger_borclar"].Value.ToString();
            txt_ErtelenmisGelirler.Text = lst.CurrentRow.Cells["ertelenmis_gelirler"].Value.ToString();
            txt_Factoring.Text = lst.CurrentRow.Cells["factoring_borclar"].Value.ToString();
            txt_FinansalBorç.Text = lst.CurrentRow.Cells["finansal_borclar"].Value.ToString();
            txt_IliskiliTaraflaraB.Text = lst.CurrentRow.Cells["iliskili_borclar"].Value.ToString();
            txt_Mevduat.Text = lst.CurrentRow.Cells["mevduat"].Value.ToString();
            txt_SigortaKarsiligi.Text = lst.CurrentRow.Cells["sigorta_karsiligi"].Value.ToString();
            txt_TicariBorc.Text = lst.CurrentRow.Cells["ticari_borclar"].Value.ToString();
            txt_TürevArac.Text = lst.CurrentRow.Cells["turev_araclar"].Value.ToString();
            if (SecimToplam)
            {
                kvykToplam();
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_KVYK.Text = nsayi + " " + "TL";
                lbl_KVYK.Visible = true;
                label16.Visible = true;
                label16.Text = "Seçilen Kayıdın Toplamı :";
            }

        }
        void kvykToplam()
        {
            sayi1 = decimal.Parse(txt_AlınanAvanslar.Text);
            sayi2 = decimal.Parse(txt_AlınanKrediler.Text);
            sayi3 = decimal.Parse(txt_BlokeHesap.Text);
            sayi4 = decimal.Parse(txt_BorçGiderK.Text);
            sayi5 = decimal.Parse(txt_dFinansal_Y.Text);
            sayi6 = decimal.Parse(txt_DigerBorc.Text);
            sayi7 = decimal.Parse(txt_ErtelenmisGelirler.Text);
            sayi8 = decimal.Parse(txt_Factoring.Text);
            sayi9 = decimal.Parse(txt_FinansalBorç.Text);
            sayi10 = decimal.Parse(txt_IliskiliTaraflaraB.Text);
            sayi11 = decimal.Parse(txt_Mevduat.Text);
            sayi12 = decimal.Parse(txt_SigortaKarsiligi.Text);
            sayi13 = decimal.Parse(txt_TicariBorc.Text);
            sayi14 = decimal.Parse(txt_TürevArac.Text);
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12 + sayi13 + sayi14;


        }
        void Güncelle()
        {
            try
            {
                kvykToplam();
                Fonksiyonlar.KVYK KVYK = DB.KVYKs.First(s => s.kvyk_id == SecimID);
                KVYK.alinan_avanslar = decimal.Parse(txt_AlınanAvanslar.Text);
                KVYK.alinan_krediler = decimal.Parse(txt_AlınanKrediler.Text);
                KVYK.bloke_hesaplar = decimal.Parse(txt_BlokeHesap.Text);
                KVYK.borcgider_karsiligi = decimal.Parse(txt_BorçGiderK.Text);
                KVYK.dfinansal_yukumluluk = decimal.Parse(txt_dFinansal_Y.Text);
                KVYK.diger_borclar = decimal.Parse(txt_DigerBorc.Text);
                KVYK.ertelenmis_gelirler = decimal.Parse(txt_ErtelenmisGelirler.Text);
                KVYK.factoring_borclar = decimal.Parse(txt_Factoring.Text);
                KVYK.finansal_borclar = decimal.Parse(txt_FinansalBorç.Text);
                KVYK.iliskili_borclar = decimal.Parse(txt_IliskiliTaraflaraB.Text);
                KVYK.mevduat = decimal.Parse(txt_Mevduat.Text);
                KVYK.sigorta_karsiligi = decimal.Parse(txt_SigortaKarsiligi.Text);
                KVYK.turev_araclar = decimal.Parse(txt_TürevArac.Text);
                KVYK.ticari_borclar = decimal.Parse(txt_TicariBorc.Text);
                KVYK.kvyk_toplami = toplam;
                //KVYK.sirket_adi = sirketadi;
                // KVYK.kvyk_ay = DateTime.Now.ToString("MMMM");
                DB.SubmitChanges();
                Mesajlar.Güncelle(true);
                Göster();
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }

        }
        void Design()
        {
            lst.BorderStyle = BorderStyle.None;
            lst.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lst.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lst.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lst.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lst.BackgroundColor = Color.White;
            lst.EnableHeadersVisualStyles = false;
            lst.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lst.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            lst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SecimToplam = false;
            YeniKaydet();
            if (SecimToplam == false)
            {
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_KVYK.Text = nsayi + " " + "TL";
                lbl_KVYK.Visible = true;
                label16.Visible = true;
                label16.Text = "Kaydedilen KVYK Toplamı :";
            }

        }
        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
                lbl_KVYK.Visible = false;
                label16.Visible = false;

            }
        }
        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
