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
    public partial class frm_UVYK : Form
    {

        public frm_UVYK()
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

        private void frm_UVYK_Load(object sender, EventArgs e)
        {
            Design();
            label16.Visible = false;
            lbl_UVYKToplam.Visible = false;
            string sql = "Select * From Kullanici Where user_id = '" + giris.user_id + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                sirketadi = dr1["company"].ToString();
            }
            Göster();
        }
        void Temizle()
        {
            Edit = false;
            SecimID = -1;
            txt_AlinanAvanslar.Text = "";
            txt_Alinankredi.Text = "";
            txt_BlokeHesap.Text = "";
            txt_BorcGider.Text = "";
            txt_dFinansalY.Text = "";
            txt_dUzunvadeli.Text = "";
            txt_ErtelenmisGelir.Text = "";
            txt_Factoring.Text = "";
            txt_Finansalborc.Text = "";
            txt_iliskiliborc.Text = "";
            txt_Mevduat.Text = "";
            txt_PozitifNegatif.Text = "";
            txt_SigortaKarsiligi.Text = "";
            txt_Ticariborc.Text = "";

        }
        void Göster()
        {
            var Listele = from s in DB.UVYKs
                          where s.sirket_adi.Contains(sirketadi)
                          select s;
            lst.DataSource = Listele;

        }
        void YeniKaydet()
        {
            try
            {
                uvykToplam();

                Fonksiyonlar.UVYK UVYK = new Fonksiyonlar.UVYK();
                UVYK.alinan_avanslar = decimal.Parse(txt_AlinanAvanslar.Text);
                UVYK.alinan_krediler = decimal.Parse(txt_Alinankredi.Text);
                UVYK.bloke_hesaplar = decimal.Parse(txt_BlokeHesap.Text);
                UVYK.borcgider_karsiligi = decimal.Parse(txt_BorcGider.Text);
                UVYK.dfinansal_yukumluluk = decimal.Parse(txt_dFinansalY.Text);
                UVYK.duzun_borclar = decimal.Parse(txt_dUzunvadeli.Text);
                UVYK.ertelenmis_gelirler = decimal.Parse(txt_ErtelenmisGelir.Text);
                UVYK.factoring_borclar = decimal.Parse(txt_Factoring.Text);
                UVYK.finansal_borclar = decimal.Parse(txt_Finansalborc.Text);
                UVYK.iliskili_borclar = decimal.Parse(txt_iliskiliborc.Text);
                UVYK.mevduatlar = decimal.Parse(txt_Mevduat.Text);
                UVYK.pozitif_negatif = decimal.Parse(txt_PozitifNegatif.Text);
                UVYK.sigorta_karsiligi = decimal.Parse(txt_SigortaKarsiligi.Text);
                UVYK.ticari_borclar = decimal.Parse(txt_Ticariborc.Text);
                UVYK.sirket_adi = sirketadi;
                UVYK.kayit_adi = frm_Donenvarliklar.KayitAdi;
                UVYK.uvyk_toplami = toplam;
                DB.UVYKs.InsertOnSubmit(UVYK);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Veri Girişi Yapıldı!" + " " + sirketadi);
                Temizle();
                Göster();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }


        }
        void uvykToplam()
        {
            sayi1 = decimal.Parse(txt_AlinanAvanslar.Text);
            sayi2 = decimal.Parse(txt_Alinankredi.Text);
            sayi3 = decimal.Parse(txt_BlokeHesap.Text);
            sayi4 = decimal.Parse(txt_BorcGider.Text);
            sayi5 = decimal.Parse(txt_dFinansalY.Text);
            sayi6 = decimal.Parse(txt_dUzunvadeli.Text);
            sayi7 = decimal.Parse(txt_ErtelenmisGelir.Text);
            sayi8 = decimal.Parse(txt_Factoring.Text);
            sayi9 = decimal.Parse(txt_Finansalborc.Text);
            sayi10 = decimal.Parse(txt_iliskiliborc.Text);
            sayi11 = decimal.Parse(txt_Mevduat.Text);
            sayi12 = decimal.Parse(txt_PozitifNegatif.Text);
            sayi13 = decimal.Parse(txt_SigortaKarsiligi.Text);
            sayi14 = decimal.Parse(txt_Ticariborc.Text);
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12 + sayi13 + sayi14;
        }
        void Sil()
        {
            try
            {
                DB.UVYKs.DeleteOnSubmit(DB.UVYKs.First(s => s.uvyk_id == SecimID));
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
            SecimID = int.Parse(lst.CurrentRow.Cells["uvyk_id"].Value.ToString());
            txt_AlinanAvanslar.Text = lst.CurrentRow.Cells["alinan_avanslar"].Value.ToString();
            txt_Alinankredi.Text = lst.CurrentRow.Cells["alinan_krediler"].Value.ToString();
            txt_BlokeHesap.Text = lst.CurrentRow.Cells["bloke_hesaplar"].Value.ToString();
            txt_BorcGider.Text = lst.CurrentRow.Cells["borcgider_karsiligi"].Value.ToString();
            txt_dFinansalY.Text = lst.CurrentRow.Cells["dfinansal_yukumluluk"].Value.ToString();
            txt_dUzunvadeli.Text = lst.CurrentRow.Cells["duzun_borclar"].Value.ToString();
            txt_ErtelenmisGelir.Text = lst.CurrentRow.Cells["ertelenmis_gelirler"].Value.ToString();
            txt_Factoring.Text = lst.CurrentRow.Cells["factoring_borclar"].Value.ToString();
            txt_Finansalborc.Text = lst.CurrentRow.Cells["finansal_borclar"].Value.ToString();
            txt_iliskiliborc.Text = lst.CurrentRow.Cells["iliskili_borclar"].Value.ToString();
            txt_Mevduat.Text = lst.CurrentRow.Cells["mevduatlar"].Value.ToString();
            txt_PozitifNegatif.Text = lst.CurrentRow.Cells["pozitif_negatif"].Value.ToString();
            txt_SigortaKarsiligi.Text = lst.CurrentRow.Cells["sigorta_karsiligi"].Value.ToString();
            txt_Ticariborc.Text = lst.CurrentRow.Cells["ticari_borclar"].Value.ToString();
            if (SecimToplam)
            {
                uvykToplam();
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_UVYKToplam.Text = nsayi + " " + "TL";
                lbl_UVYKToplam.Visible = true;
                label16.Visible = true;
                label16.ForeColor = Color.Brown;
                label16.Text = "Seçilen Kayıdın Toplamı :";
            }

        }
        void Güncelle()
        {
            try
            {
                uvykToplam();
                Fonksiyonlar.UVYK UVYK = DB.UVYKs.First(s => s.uvyk_id == SecimID);
                UVYK.alinan_avanslar = decimal.Parse(txt_AlinanAvanslar.Text);
                UVYK.alinan_krediler = decimal.Parse(txt_Alinankredi.Text);
                UVYK.bloke_hesaplar = decimal.Parse(txt_BlokeHesap.Text);
                UVYK.borcgider_karsiligi = decimal.Parse(txt_BorcGider.Text);
                UVYK.dfinansal_yukumluluk = decimal.Parse(txt_dFinansalY.Text);
                UVYK.duzun_borclar = decimal.Parse(txt_dUzunvadeli.Text);
                UVYK.ertelenmis_gelirler = decimal.Parse(txt_ErtelenmisGelir.Text);
                UVYK.factoring_borclar = decimal.Parse(txt_Factoring.Text);
                UVYK.finansal_borclar = decimal.Parse(txt_Finansalborc.Text);
                UVYK.iliskili_borclar = decimal.Parse(txt_iliskiliborc.Text);
                UVYK.mevduatlar = decimal.Parse(txt_Mevduat.Text);
                UVYK.pozitif_negatif = decimal.Parse(txt_PozitifNegatif.Text);
                UVYK.sigorta_karsiligi = decimal.Parse(txt_SigortaKarsiligi.Text);
                UVYK.ticari_borclar = decimal.Parse(txt_Ticariborc.Text);
                //UVYK.sirket_adi = sirketadi;
                //UVYK.uvyk_ay = DateTime.Now.ToString("MMMM");
                UVYK.uvyk_toplami = toplam;
                DB.SubmitChanges();
                Mesajlar.Güncelle(true);
                Temizle();
                Göster();

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

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
                lbl_UVYKToplam.Visible = false;
                label16.Visible = false;

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
                lbl_UVYKToplam.Text = nsayi + " " + "TL";
                lbl_UVYKToplam.Visible = true;
                label16.Visible = true;
                label16.ForeColor = Color.Green;
                label16.Text = "Kaydedilen UVYK Toplamı :";
            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }
        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

    }
}
