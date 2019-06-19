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
    public partial class frm_Donenvarliklar : Form
    {
        public frm_Donenvarliklar()
        {
            InitializeComponent();
        }

        Fonksiyonlar.DataBase1DataContext DB = new Fonksiyonlar.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;
        bool Edit = false;
        bool SecimToplam = false;
        public string sirketadi;
        public decimal sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12, toplam;
        public static string KayitAdi;

        private void frm_Donenvarliklar_Load(object sender, EventArgs e)
        {
            Design();
            panel1.Visible = false;
            lbl_DonenToplam.Visible = false;
            label4.Visible = false;
            string sql = "Select * From Kullanici Where user_id = '" + giris.user_id + "'";
            SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
            if (dr1.Read())
            {
                sirketadi = dr1["company"].ToString();
            }
            txt_SirketAdi.Text = giris.sirket_adi;
            txt_KullaniciAdi.Text = giris.kullanici_adi;
            Göster();
        }
        void YeniKaydet()
        {
            try
            {
                DonenVarlikToplam();
                Fonksiyonlar.DonenVarlik DonenVarlik = new Fonksiyonlar.DonenVarlik();
                DonenVarlik.canli_varliklar = decimal.Parse(txtcanli_varliklar.Text);
                DonenVarlik.ddönen_varliklar = decimal.Parse(txtddönen_varliklar.Text);
                DonenVarlik.dkisavadeli_alacaklar = decimal.Parse(txtdkisa_alacaklar.Text);
                DonenVarlik.finansal_yatirimlar = decimal.Parse(txtfinansal_yatirimlar.Text);
                DonenVarlik.finansalkiralama_alacaklar = decimal.Parse(txtkiralama_alacaklar.Text);
                DonenVarlik.hazir_degerler = decimal.Parse(txthazir_degerler.Text);
                DonenVarlik.kisavadeli_alacaklar = decimal.Parse(txtkisavadeli_alacaklar.Text);
                DonenVarlik.krediler_avanslar = decimal.Parse(txtkrediler_avanslar.Text);
                DonenVarlik.menkul_kiymetler = decimal.Parse(txtmenkul_kiymetler.Text);
                DonenVarlik.pesinodenmis_giderler = decimal.Parse(txtödenmis_giderler.Text);
                DonenVarlik.stoklar = decimal.Parse(txtstoklar.Text);
                DonenVarlik.sirket_adi = sirketadi;
                DonenVarlik.kayit_adi = txt_KayitAdi.Text;             
                KayitAdi = txt_KayitAdi.Text;
                DonenVarlik.donenvarlik_toplami = toplam;
                DonenVarlik.türev_enstrümanlar = decimal.Parse(txttürev_enstrümanlar.Text);
                DonenVarlik.kayit_tarihi = DateTime.Parse(dt_Tarih.Text);
                DB.DonenVarliks.InsertOnSubmit(DonenVarlik);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Veri Girişi Yapıldı" + " " + sirketadi);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }



        }
        void DonenVarlikToplam()
        {
            sayi1 = decimal.Parse(txthazir_degerler.Text);
            sayi2 = decimal.Parse(txtddönen_varliklar.Text);
            sayi3 = decimal.Parse(txtcanli_varliklar.Text);
            sayi4 = decimal.Parse(txtdkisa_alacaklar.Text);
            sayi5 = decimal.Parse(txtfinansal_yatirimlar.Text);
            sayi6 = decimal.Parse(txtkiralama_alacaklar.Text);
            sayi7 = decimal.Parse(txtkisavadeli_alacaklar.Text);
            sayi8 = decimal.Parse(txtkrediler_avanslar.Text);
            sayi9 = decimal.Parse(txtmenkul_kiymetler.Text);
            sayi10 = decimal.Parse(txtödenmis_giderler.Text);
            sayi11 = decimal.Parse(txtstoklar.Text);
            sayi12 = decimal.Parse(txttürev_enstrümanlar.Text);
            toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12;

        }
        void Göster()
        {
            var listele = from s in DB.DonenVarliks
                          where s.sirket_adi.Contains(sirketadi)
                          select s;
            lst.DataSource = listele;
        }
        void Temizle()
        {

            txtcanli_varliklar.Text = "";
            txtddönen_varliklar.Text = "";
            txtdkisa_alacaklar.Text = "";
            txtfinansal_yatirimlar.Text = "";
            txthazir_degerler.Text = "";
            txtkiralama_alacaklar.Text = "";
            txtkisavadeli_alacaklar.Text = "";
            txtkrediler_avanslar.Text = "";
            txtmenkul_kiymetler.Text = "";
            txtödenmis_giderler.Text = "";
            txtstoklar.Text = "";
            txttürev_enstrümanlar.Text = "";
            txt_KayitAdi.Text = "";
            dt_Tarih.Text = DateTime.Now.ToShortDateString();
            SecimID = -1;
            Edit = false;
            Göster();
        }
        void Sec()
        {
            try
            {
                SecimToplam = true;
                Edit = true;
                SecimID = int.Parse(lst.CurrentRow.Cells["donen_id"].Value.ToString());
                txtcanli_varliklar.Text = lst.CurrentRow.Cells["canli_varliklar"].Value.ToString();
                txtddönen_varliklar.Text = lst.CurrentRow.Cells["ddönen_varliklar"].Value.ToString();
                txtdkisa_alacaklar.Text = lst.CurrentRow.Cells["dkisavadeli_alacaklar"].Value.ToString();
                txtfinansal_yatirimlar.Text = lst.CurrentRow.Cells["finansal_yatirimlar"].Value.ToString();
                txthazir_degerler.Text = lst.CurrentRow.Cells["hazir_degerler"].Value.ToString();
                txtkiralama_alacaklar.Text = lst.CurrentRow.Cells["finansalkiralama_alacaklar"].Value.ToString();
                txtkisavadeli_alacaklar.Text = lst.CurrentRow.Cells["kisavadeli_alacaklar"].Value.ToString();
                txtkrediler_avanslar.Text = lst.CurrentRow.Cells["krediler_avanslar"].Value.ToString();
                txtmenkul_kiymetler.Text = lst.CurrentRow.Cells["menkul_kiymetler"].Value.ToString();
                txtödenmis_giderler.Text = lst.CurrentRow.Cells["pesinodenmis_giderler"].Value.ToString();
                txtstoklar.Text = lst.CurrentRow.Cells["stoklar"].Value.ToString();
                txttürev_enstrümanlar.Text = lst.CurrentRow.Cells["türev_enstrümanlar"].Value.ToString();
                txt_KayitAdi.Text = lst.CurrentRow.Cells["kayit_adi"].Value.ToString();
                dt_Tarih.Text = lst.CurrentRow.Cells["kayit_tarihi"].Value.ToString();
                Nokta();
                Nokta1();
                Nokta2();
                if (SecimToplam)
                {
                    DonenVarlikToplam();
                    double sayi = Convert.ToDouble(toplam);
                    string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                    lbl_DonenToplam.Text = nsayi + " " + "TL";
                    lbl_DonenToplam.Visible = true;
                    label4.Visible = true;
                    label4.ForeColor = Color.Brown;
                    label4.Text = "Seçilen Kaydın Toplamı :";
                }


            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Sil()
        {
            try
            {
                DB.DonenVarliks.DeleteOnSubmit(DB.DonenVarliks.First(s => s.donen_id == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void Güncelle()
        {
            DonenVarlikToplam();
            Fonksiyonlar.DonenVarlik DonenVarlik = DB.DonenVarliks.First(s => s.donen_id == SecimID);
            DonenVarlik.canli_varliklar = decimal.Parse(txtcanli_varliklar.Text);
            DonenVarlik.ddönen_varliklar = decimal.Parse(txtddönen_varliklar.Text);
            DonenVarlik.dkisavadeli_alacaklar = decimal.Parse(txtdkisa_alacaklar.Text);
            DonenVarlik.finansal_yatirimlar = decimal.Parse(txtfinansal_yatirimlar.Text);
            DonenVarlik.finansalkiralama_alacaklar = decimal.Parse(txtkiralama_alacaklar.Text);
            DonenVarlik.hazir_degerler = decimal.Parse(txthazir_degerler.Text);
            DonenVarlik.kisavadeli_alacaklar = decimal.Parse(txtkisavadeli_alacaklar.Text);
            DonenVarlik.krediler_avanslar = decimal.Parse(txtkrediler_avanslar.Text);
            DonenVarlik.menkul_kiymetler = decimal.Parse(txtmenkul_kiymetler.Text);
            DonenVarlik.donenvarlik_toplami = toplam;
            DonenVarlik.pesinodenmis_giderler = decimal.Parse(txtödenmis_giderler.Text);
            DonenVarlik.stoklar = decimal.Parse(txtstoklar.Text);
            //DonenVarlik.sirket_adi = sirketadi;
            DonenVarlik.türev_enstrümanlar = decimal.Parse(txttürev_enstrümanlar.Text);
            // DonenVarlik.donen_ay = DateTime.Now.ToString("MMMM");
            DB.SubmitChanges();
            Mesajlar.Güncelle(true);
            Göster();
            Temizle();


        }
        void Nokta()
        {
            if (txthazir_degerler.Text != "")
            {
                double sayi = Convert.ToDouble(txthazir_degerler.Text);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                txthazir_degerler.Text = nsayi;
            }
            else
            {
                txthazir_degerler.Text = "0";
            }

        }
        void Nokta1()
        {
            if (txtfinansal_yatirimlar.Text != "")
            {
                double sayi = Convert.ToDouble(txtfinansal_yatirimlar.Text);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                txtfinansal_yatirimlar.Text = nsayi;
            }
            else
            {
                txtfinansal_yatirimlar.Text = "0";
            }

        }
        void Nokta2()
        {
            if (txtmenkul_kiymetler.Text != "")
            {
                double sayi = Convert.ToDouble(txtmenkul_kiymetler.Text);
                string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                txtmenkul_kiymetler.Text = nsayi;
            }
            else
            {
                txtmenkul_kiymetler.Text = "0";
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
            lst.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 30, 72);
            lst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
                lbl_DonenToplam.Visible = false;
                label4.Visible = false;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {                 
            if (txt_KayitAdi.Text != "" && dt_Tarih.Text != "")
            {

                SecimToplam = false;
                if (SecimToplam == false)
                {
                                                        
                    string k_ad = txt_KayitAdi.Text;          
                    string[] Ad = new string[11];
                    int i;
                    int sayac= 0;
                    string sql = "Select * From DonenVarlik ";
                    SqlDataReader dr1 = ConnectionQuerry.DataReader(sql);
                    for (i = 0; i < Ad.Length; i++)
                    {
                        while (dr1.Read())
                        {                          
                            Ad[i] = dr1["kayit_adi"].ToString();
                            if (Ad[i] == k_ad)
                            {
                                sayac = sayac + 1;
                            }
                        }                      
                    }
                    if (sayac == 0)
                    {
                        
                        YeniKaydet();
                        double sayi = Convert.ToDouble(toplam);
                        string nsayi = String.Format("{0:0,0}", sayi).Replace(",", ".");
                        lbl_DonenToplam.Text = nsayi + " " + "TL";
                        lbl_DonenToplam.Visible = true;
                        label4.Visible = true;
                        label4.ForeColor = Color.Green;
                        label4.Text = "Kaydedilen Dönen Varlık :";                     
                    }
                    else
                    {
                        MessageBox.Show("Bu İsimde Bir Kayıt Mevcut! \n Lütfen Yeni Bir Kayıt Adı Seçiniz!");
   
                        Temizle();
                    }

                   
                }
                else MessageBox.Show("Seçim Toplam Seçilmeli");
            }
            else
            {
                MessageBox.Show("Kayıt Adı ve Kayıt Tarihi Boş Geçilemez");
            }
            

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
                lbl_DonenToplam.Visible = false;
                label4.Visible = false;
            }

        }
        private void lst_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
        private void txthazir_degerler_Leave_1(object sender, EventArgs e)
        {
            Nokta();
        }
        private void txtfinansal_yatirimlar_Leave(object sender, EventArgs e)
        {
            Nokta1();

        }
        private void txtmenkul_kiymetler_Leave(object sender, EventArgs e)
        {
            Nokta2();

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


    }
}
