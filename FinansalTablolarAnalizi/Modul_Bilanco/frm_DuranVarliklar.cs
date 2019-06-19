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
    public partial class frm_DuranVarliklar : Form
    {
        public frm_DuranVarliklar()
        {
            InitializeComponent();
        }
        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;
        bool Edit = false;
        bool SecimToplam = false;
        public string sirketadi;
        public decimal sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12,sayi13,sayi14,sayi15, toplam;
        public static decimal  A1,AToplam;
        private void frm_DuranVarliklar_Load(object sender, EventArgs e)
        {
            Design();
            lbl_durantoplam.Visible = false;
            label17.Visible = false;
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
                DuranToplam();

                Fonksiyonlar.DuranVarlik Duran = new Fonksiyonlar.DuranVarlik();
                Duran.canli_varliklar = decimal.Parse(txt_CanliVarliklar.Text);
                Duran.dduran_varliklar = decimal.Parse(txt_DigerDuran.Text);
                Duran.factoring_alacaklar = decimal.Parse(txt_Factoring.Text);
                Duran.finansal_duranvarlik = decimal.Parse(txt_FinansalDuran.Text);
                Duran.finansal_yatirim = decimal.Parse(txt_FinansalYatirim.Text);
                Duran.fkiralama_alacak = decimal.Parse(txt_FinansalKiralama.Text);
                Duran.krediler_avanslar = decimal.Parse(txt_KredilerAvanslar.Text);
                Duran.mduran_varliklar = decimal.Parse(txt_MaddiDuranVarliklar.Text);
                Duran.menkul_kiymetler = decimal.Parse(txt_MenkulKiymetler.Text);
                Duran.molmayan_duranvarlik = decimal.Parse(txt_MaddiOlmayan.Text);
                Duran.pesinodenmis_giderler = decimal.Parse(txt_PeşinÖdenmişGider.Text);
                Duran.pozitif_negatif = decimal.Parse(txt_PozitifNegatif.Text);
                Duran.sirket_adi = sirketadi;
                Duran.kayit_adi = frm_Donenvarliklar.KayitAdi;
                Duran.stoklar = decimal.Parse(txt_Stoklar.Text);
                Duran.duranvarlik_toplami = toplam;
                Duran.sirket_adi = sirketadi;
                Duran.türev_enstrümanlar = decimal.Parse(txt_TürevEnstrüman.Text);
                Duran.uvadeli_ticarialacak = decimal.Parse(txt_UzunAlacak.Text);
                DB.DuranVarliks.InsertOnSubmit(Duran);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Veri Girişi Yapıldı" + sirketadi);
                Göster();
                Temizle();
                
                
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void DuranToplam()
        {
            sayi1 = decimal.Parse(txt_CanliVarliklar.Text);
            sayi2 = decimal.Parse(txt_DigerDuran.Text);
            sayi3 = decimal.Parse(txt_Factoring.Text);
            sayi4 = decimal.Parse(txt_FinansalDuran.Text);
            sayi5 = decimal.Parse(txt_FinansalKiralama.Text);
            sayi6 = decimal.Parse(txt_FinansalYatirim.Text);
            sayi7 = decimal.Parse(txt_KredilerAvanslar.Text);
            sayi8 = decimal.Parse(txt_MaddiDuranVarliklar.Text);
            sayi9 = decimal.Parse(txt_MaddiOlmayan.Text);
            sayi10 = decimal.Parse(txt_MenkulKiymetler.Text);
            sayi11 = decimal.Parse(txt_PeşinÖdenmişGider.Text);
            sayi12 = decimal.Parse(txt_PozitifNegatif.Text);
            sayi13 = decimal.Parse(txt_Stoklar.Text);
            sayi14 = decimal.Parse(txt_TürevEnstrüman.Text);
            sayi15 = decimal.Parse(txt_UzunAlacak.Text);
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12 + sayi13 + sayi14 + sayi15;
        }
        void Güncelle()
        {
            DuranToplam();
            Fonksiyonlar.DuranVarlik Duran = DB.DuranVarliks.First(s => s.duran_id == SecimID);
            Duran.canli_varliklar = decimal.Parse(txt_CanliVarliklar.Text);
            Duran.dduran_varliklar = decimal.Parse(txt_DigerDuran.Text);
            // Duran.duran_ay = DateTime.Now.ToString("MMMM");
            //Duran.sirket_adi = sirketadi;
            Duran.factoring_alacaklar = decimal.Parse(txt_Factoring.Text);
            Duran.finansal_duranvarlik= decimal.Parse(txt_FinansalDuran.Text);
            Duran.finansal_yatirim = decimal.Parse(txt_FinansalYatirim.Text);
            Duran.fkiralama_alacak = decimal.Parse(txt_FinansalKiralama.Text);
            Duran.krediler_avanslar = decimal.Parse(txt_KredilerAvanslar.Text);
            Duran.mduran_varliklar = decimal.Parse(txt_MaddiDuranVarliklar.Text);
            Duran.menkul_kiymetler = decimal.Parse(txt_MenkulKiymetler.Text);
            Duran.molmayan_duranvarlik = decimal.Parse(txt_MaddiOlmayan.Text);
            Duran.pesinodenmis_giderler = decimal.Parse(txt_PeşinÖdenmişGider.Text);
            Duran.pozitif_negatif = decimal.Parse(txt_PozitifNegatif.Text);
            Duran.duranvarlik_toplami = toplam;
            Duran.stoklar = decimal.Parse(txt_Stoklar.Text);
            Duran.türev_enstrümanlar = decimal.Parse(txt_TürevEnstrüman.Text);
            Duran.uvadeli_ticarialacak = decimal.Parse(txt_UzunAlacak.Text);  
            DB.SubmitChanges();
            Mesajlar.Güncelle(true);
            Temizle();
 
        }
        void Göster()
        {
            var listele = from s in DB.DuranVarliks
                          where s.sirket_adi.Contains(sirketadi)
                          select s;
            lst.DataSource = listele;
           
        }
        void Temizle()
        {
            Edit = false;
            SecimID = -1;
            txt_CanliVarliklar.Text = "";
            txt_DigerDuran.Text = "";
            txt_Factoring.Text = "";
            txt_FinansalDuran.Text = "";
            txt_FinansalKiralama.Text = "";
            txt_FinansalYatirim.Text = "";
            txt_KredilerAvanslar.Text = "";
            txt_MaddiDuranVarliklar.Text = "";
            txt_MaddiOlmayan.Text = "";
            txt_MenkulKiymetler.Text = "";
            txt_PeşinÖdenmişGider.Text = "";
            txt_PozitifNegatif.Text = "";
            txt_Stoklar.Text = "";
            txt_TürevEnstrüman.Text = "";
            txt_UzunAlacak.Text = "";
            Göster();
        }
        void Sil()
        {
            DB.DuranVarliks.DeleteOnSubmit(DB.DuranVarliks.First(s => s.duran_id == SecimID));
            DB.SubmitChanges();
            Temizle();
 
        }
        void Sec()
        {
            try
            {
                SecimToplam = true;
                Edit = true;               
                SecimID = int.Parse(lst.CurrentRow.Cells["duran_id"].Value.ToString());
                txt_CanliVarliklar.Text = lst.CurrentRow.Cells["canli_varliklar"].Value.ToString();
                txt_DigerDuran.Text = lst.CurrentRow.Cells["dduran_varliklar"].Value.ToString();
                txt_Factoring.Text = lst.CurrentRow.Cells["factoring_alacaklar"].Value.ToString();
                txt_FinansalDuran.Text = lst.CurrentRow.Cells["finansal_duranvarlik"].Value.ToString();
                txt_FinansalKiralama.Text = lst.CurrentRow.Cells["fkiralama_alacak"].Value.ToString();
                txt_FinansalYatirim.Text = lst.CurrentRow.Cells["finansal_yatirim"].Value.ToString();
                txt_KredilerAvanslar.Text = lst.CurrentRow.Cells["krediler_avanslar"].Value.ToString();
                txt_MaddiDuranVarliklar.Text = lst.CurrentRow.Cells["mduran_varliklar"].Value.ToString();
                txt_MaddiOlmayan.Text = lst.CurrentRow.Cells["molmayan_duranvarlik"].Value.ToString();
                txt_MenkulKiymetler.Text = lst.CurrentRow.Cells["menkul_kiymetler"].Value.ToString();
                txt_PeşinÖdenmişGider.Text = lst.CurrentRow.Cells["pesinodenmis_giderler"].Value.ToString();
                txt_PozitifNegatif.Text = lst.CurrentRow.Cells["pozitif_negatif"].Value.ToString();
                txt_Stoklar.Text = lst.CurrentRow.Cells["stoklar"].Value.ToString();
                txt_TürevEnstrüman.Text = lst.CurrentRow.Cells["türev_enstrümanlar"].Value.ToString();
                txt_UzunAlacak.Text = lst.CurrentRow.Cells["uvadeli_ticarialacak"].Value.ToString();


                if (SecimToplam == true)
                {
                    DuranToplam();
                    double sayi = Convert.ToDouble(toplam);
                    string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                    lbl_durantoplam.Text = nsayi + " " + "TL";
                    lbl_durantoplam.Visible = true;
                    label17.Visible = true;
                    label17.ForeColor = Color.Brown;
                    label17.Text = "Seçilen Kayıdın Toplamı :";
                }
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
                SecimToplam = false;
            }
            
           
        }
        void AktifKaydet()
        {
            
            string sql = "Select * From DonenVarlik Where kayit_adi ='" + frm_Donenvarliklar.KayitAdi + "'";
            SqlDataReader dr = ConnectionQuerry.DataReader(sql);
            if (dr.Read())
            {
                A1 = decimal.Parse(dr["donenvarlik_toplami"].ToString());
                          
            }
            AToplam = A1 + toplam;

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

        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SecimToplam = false;
            YeniKaydet();
            AktifKaydet();
            if (SecimToplam == false)
            {
                double sayi = Convert.ToDouble(toplam);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                lbl_durantoplam.Text = nsayi + " " + "TL";
                lbl_durantoplam.Visible = true;
                label17.Visible = true;
                label17.ForeColor = Color.Green;
                label17.Text = "Kaydedilen Duran Varlık :";
            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
                lbl_durantoplam.Visible = false;
                label17.Visible = false;
            }
        }
        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
                lbl_durantoplam.Visible = false;
                label17.Visible = false;
                
            }
        }
    }
}
