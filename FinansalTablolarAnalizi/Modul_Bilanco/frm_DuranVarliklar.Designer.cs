namespace FinansalTablolarAnalizi.Modul_Bilanco
{
    partial class frm_DuranVarliklar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DuranVarliklar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst = new System.Windows.Forms.DataGridView();
            this.duran_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayit_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menkul_kiymetler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krediler_avanslar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoring_alacaklar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uvadeli_ticarialacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkiralama_alacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türev_enstrümanlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finansal_yatirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canli_varliklar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mduran_varliklar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dduran_varliklar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.molmayan_duranvarlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finansal_duranvarlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesinodenmis_giderler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozitif_negatif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duranvarlik_toplamı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirket_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_durantoplam = new System.Windows.Forms.Label();
            this.txt_PozitifNegatif = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_PeşinÖdenmişGider = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_FinansalDuran = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_MaddiOlmayan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DigerDuran = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MaddiDuranVarliklar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Stoklar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CanliVarliklar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FinansalYatirim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TürevEnstrüman = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_FinansalKiralama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UzunAlacak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Factoring = new System.Windows.Forms.TextBox();
            this.txt_KredilerAvanslar = new System.Windows.Forms.TextBox();
            this.txt_MenkulKiymetler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Güncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duran Varlık Tablosu ";
            // 
            // lst
            // 
            this.lst.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duran_id,
            this.kayit_adi,
            this.menkul_kiymetler,
            this.krediler_avanslar,
            this.factoring_alacaklar,
            this.uvadeli_ticarialacak,
            this.fkiralama_alacak,
            this.türev_enstrümanlar,
            this.finansal_yatirim,
            this.canli_varliklar,
            this.stoklar,
            this.mduran_varliklar,
            this.dduran_varliklar,
            this.molmayan_duranvarlik,
            this.finansal_duranvarlik,
            this.pesinodenmis_giderler,
            this.pozitif_negatif,
            this.duranvarlik_toplamı,
            this.sirket_adi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lst.DefaultCellStyle = dataGridViewCellStyle2;
            this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst.GridColor = System.Drawing.Color.DimGray;
            this.lst.Location = new System.Drawing.Point(3, 16);
            this.lst.Name = "lst";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Adobe Song Std L", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lst.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.lst.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.lst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lst.Size = new System.Drawing.Size(1231, 242);
            this.lst.TabIndex = 0;
            this.lst.DoubleClick += new System.EventHandler(this.lst_DoubleClick);
            // 
            // duran_id
            // 
            this.duran_id.DataPropertyName = "duran_id";
            this.duran_id.HeaderText = "ID";
            this.duran_id.Name = "duran_id";
            this.duran_id.Visible = false;
            this.duran_id.Width = 40;
            // 
            // kayit_adi
            // 
            this.kayit_adi.DataPropertyName = "kayit_adi";
            this.kayit_adi.HeaderText = "Kayıt Adı";
            this.kayit_adi.Name = "kayit_adi";
            this.kayit_adi.Width = 70;
            // 
            // menkul_kiymetler
            // 
            this.menkul_kiymetler.DataPropertyName = "menkul_kiymetler";
            this.menkul_kiymetler.HeaderText = "Menkul Kıymetler";
            this.menkul_kiymetler.Name = "menkul_kiymetler";
            this.menkul_kiymetler.Width = 70;
            // 
            // krediler_avanslar
            // 
            this.krediler_avanslar.DataPropertyName = "krediler_avanslar";
            this.krediler_avanslar.HeaderText = "Krediler Avanslar";
            this.krediler_avanslar.Name = "krediler_avanslar";
            this.krediler_avanslar.Width = 70;
            // 
            // factoring_alacaklar
            // 
            this.factoring_alacaklar.DataPropertyName = "factoring_alacaklar";
            this.factoring_alacaklar.HeaderText = "Factoring Alacaklar";
            this.factoring_alacaklar.Name = "factoring_alacaklar";
            this.factoring_alacaklar.Width = 70;
            // 
            // uvadeli_ticarialacak
            // 
            this.uvadeli_ticarialacak.DataPropertyName = "uvadeli_ticarialacak";
            this.uvadeli_ticarialacak.HeaderText = "Uzun Vadeli Ticari Alacak";
            this.uvadeli_ticarialacak.Name = "uvadeli_ticarialacak";
            this.uvadeli_ticarialacak.Width = 70;
            // 
            // fkiralama_alacak
            // 
            this.fkiralama_alacak.DataPropertyName = "fkiralama_alacak";
            this.fkiralama_alacak.HeaderText = "Finansal Kiralama Alacakları";
            this.fkiralama_alacak.Name = "fkiralama_alacak";
            this.fkiralama_alacak.Width = 70;
            // 
            // türev_enstrümanlar
            // 
            this.türev_enstrümanlar.DataPropertyName = "türev_enstrümanlar";
            this.türev_enstrümanlar.HeaderText = "Türev Enstrümanlar";
            this.türev_enstrümanlar.Name = "türev_enstrümanlar";
            this.türev_enstrümanlar.Width = 70;
            // 
            // finansal_yatirim
            // 
            this.finansal_yatirim.DataPropertyName = "finansal_yatirim";
            this.finansal_yatirim.HeaderText = "Finansal Yatırımlar";
            this.finansal_yatirim.Name = "finansal_yatirim";
            this.finansal_yatirim.Width = 70;
            // 
            // canli_varliklar
            // 
            this.canli_varliklar.DataPropertyName = "canli_varliklar";
            this.canli_varliklar.HeaderText = "Canlı Varlıklar";
            this.canli_varliklar.Name = "canli_varliklar";
            this.canli_varliklar.Width = 70;
            // 
            // stoklar
            // 
            this.stoklar.DataPropertyName = "stoklar";
            this.stoklar.HeaderText = "Stoklar";
            this.stoklar.Name = "stoklar";
            this.stoklar.Width = 70;
            // 
            // mduran_varliklar
            // 
            this.mduran_varliklar.DataPropertyName = "mduran_varliklar";
            this.mduran_varliklar.HeaderText = "Maddi Duran Varlıklar ";
            this.mduran_varliklar.Name = "mduran_varliklar";
            this.mduran_varliklar.Width = 70;
            // 
            // dduran_varliklar
            // 
            this.dduran_varliklar.DataPropertyName = "dduran_varliklar";
            this.dduran_varliklar.HeaderText = "Diğer Duran Varlıklar";
            this.dduran_varliklar.Name = "dduran_varliklar";
            this.dduran_varliklar.Width = 70;
            // 
            // molmayan_duranvarlik
            // 
            this.molmayan_duranvarlik.DataPropertyName = "molmayan_duranvarlik";
            this.molmayan_duranvarlik.HeaderText = "Maddi Olmayan Duran Varlıklar";
            this.molmayan_duranvarlik.Name = "molmayan_duranvarlik";
            this.molmayan_duranvarlik.Width = 70;
            // 
            // finansal_duranvarlik
            // 
            this.finansal_duranvarlik.DataPropertyName = "finansal_duranvarlik";
            this.finansal_duranvarlik.HeaderText = "Finansal Duran Varlık";
            this.finansal_duranvarlik.Name = "finansal_duranvarlik";
            this.finansal_duranvarlik.Width = 70;
            // 
            // pesinodenmis_giderler
            // 
            this.pesinodenmis_giderler.DataPropertyName = "pesinodenmis_giderler";
            this.pesinodenmis_giderler.HeaderText = "Pesin Ödenmiş Giderler";
            this.pesinodenmis_giderler.Name = "pesinodenmis_giderler";
            this.pesinodenmis_giderler.Width = 70;
            // 
            // pozitif_negatif
            // 
            this.pozitif_negatif.DataPropertyName = "pozitif_negatif";
            this.pozitif_negatif.HeaderText = "Pozitif/Negatif Şerefiye";
            this.pozitif_negatif.Name = "pozitif_negatif";
            this.pozitif_negatif.Width = 70;
            // 
            // duranvarlik_toplamı
            // 
            this.duranvarlik_toplamı.DataPropertyName = "duranvarlik_toplami";
            this.duranvarlik_toplamı.HeaderText = "DURAN VARLIK TOPLAMI";
            this.duranvarlik_toplamı.Name = "duranvarlik_toplamı";
            this.duranvarlik_toplamı.Width = 70;
            // 
            // sirket_adi
            // 
            this.sirket_adi.DataPropertyName = "sirket_adi";
            this.sirket_adi.HeaderText = "Şirket Adı";
            this.sirket_adi.Name = "sirket_adi";
            this.sirket_adi.Visible = false;
            this.sirket_adi.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lbl_durantoplam);
            this.groupBox2.Controls.Add(this.txt_PozitifNegatif);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_PeşinÖdenmişGider);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_FinansalDuran);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_MaddiOlmayan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_DigerDuran);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_MaddiDuranVarliklar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_Stoklar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_CanliVarliklar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_FinansalYatirim);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_TürevEnstrüman);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_FinansalKiralama);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_UzunAlacak);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Factoring);
            this.groupBox2.Controls.Add(this.txt_KredilerAvanslar);
            this.groupBox2.Controls.Add(this.txt_MenkulKiymetler);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Sil);
            this.groupBox2.Controls.Add(this.btn_Kaydet);
            this.groupBox2.Controls.Add(this.btn_Güncelle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duran Varlık Bilgileri";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(240, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Kaydedilen Duran Varlık :";
            // 
            // lbl_durantoplam
            // 
            this.lbl_durantoplam.AutoSize = true;
            this.lbl_durantoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durantoplam.Location = new System.Drawing.Point(397, 171);
            this.lbl_durantoplam.Name = "lbl_durantoplam";
            this.lbl_durantoplam.Size = new System.Drawing.Size(21, 13);
            this.lbl_durantoplam.TabIndex = 34;
            this.lbl_durantoplam.Text = "00";
            // 
            // txt_PozitifNegatif
            // 
            this.txt_PozitifNegatif.Location = new System.Drawing.Point(1123, 123);
            this.txt_PozitifNegatif.Name = "txt_PozitifNegatif";
            this.txt_PozitifNegatif.Size = new System.Drawing.Size(100, 20);
            this.txt_PozitifNegatif.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(995, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Pozitif/Negatif Şerefiye :";
            // 
            // txt_PeşinÖdenmişGider
            // 
            this.txt_PeşinÖdenmişGider.Location = new System.Drawing.Point(1123, 89);
            this.txt_PeşinÖdenmişGider.Name = "txt_PeşinÖdenmişGider";
            this.txt_PeşinÖdenmişGider.Size = new System.Drawing.Size(100, 20);
            this.txt_PeşinÖdenmişGider.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(994, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Peşin Ödenmiş Giderler :";
            // 
            // txt_FinansalDuran
            // 
            this.txt_FinansalDuran.Location = new System.Drawing.Point(1123, 58);
            this.txt_FinansalDuran.Name = "txt_FinansalDuran";
            this.txt_FinansalDuran.Size = new System.Drawing.Size(100, 20);
            this.txt_FinansalDuran.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(995, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Fiansal Duran Varlıklar :";
            // 
            // txt_MaddiOlmayan
            // 
            this.txt_MaddiOlmayan.Location = new System.Drawing.Point(876, 120);
            this.txt_MaddiOlmayan.Name = "txt_MaddiOlmayan";
            this.txt_MaddiOlmayan.Size = new System.Drawing.Size(100, 20);
            this.txt_MaddiOlmayan.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(756, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Maddi Olmayan \r\nDuran Varlıklar :";
            // 
            // txt_DigerDuran
            // 
            this.txt_DigerDuran.Location = new System.Drawing.Point(876, 86);
            this.txt_DigerDuran.Name = "txt_DigerDuran";
            this.txt_DigerDuran.Size = new System.Drawing.Size(100, 20);
            this.txt_DigerDuran.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(756, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Diğer Duran Varlıklar :";
            // 
            // txt_MaddiDuranVarliklar
            // 
            this.txt_MaddiDuranVarliklar.Location = new System.Drawing.Point(876, 55);
            this.txt_MaddiDuranVarliklar.Name = "txt_MaddiDuranVarliklar";
            this.txt_MaddiDuranVarliklar.Size = new System.Drawing.Size(100, 20);
            this.txt_MaddiDuranVarliklar.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(756, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Maddi Duran Varlıklar :";
            // 
            // txt_Stoklar
            // 
            this.txt_Stoklar.Location = new System.Drawing.Point(633, 124);
            this.txt_Stoklar.Name = "txt_Stoklar";
            this.txt_Stoklar.Size = new System.Drawing.Size(100, 20);
            this.txt_Stoklar.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stoklar :";
            // 
            // txt_CanliVarliklar
            // 
            this.txt_CanliVarliklar.Location = new System.Drawing.Point(633, 90);
            this.txt_CanliVarliklar.Name = "txt_CanliVarliklar";
            this.txt_CanliVarliklar.Size = new System.Drawing.Size(100, 20);
            this.txt_CanliVarliklar.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Canlı Varlıklar :";
            // 
            // txt_FinansalYatirim
            // 
            this.txt_FinansalYatirim.Location = new System.Drawing.Point(633, 55);
            this.txt_FinansalYatirim.Name = "txt_FinansalYatirim";
            this.txt_FinansalYatirim.Size = new System.Drawing.Size(100, 20);
            this.txt_FinansalYatirim.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Finansal Yatırımlar :";
            // 
            // txt_TürevEnstrüman
            // 
            this.txt_TürevEnstrüman.Location = new System.Drawing.Point(406, 120);
            this.txt_TürevEnstrüman.Name = "txt_TürevEnstrüman";
            this.txt_TürevEnstrüman.Size = new System.Drawing.Size(100, 20);
            this.txt_TürevEnstrüman.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Türev Enstrümanlar :";
            // 
            // txt_FinansalKiralama
            // 
            this.txt_FinansalKiralama.Location = new System.Drawing.Point(406, 86);
            this.txt_FinansalKiralama.Name = "txt_FinansalKiralama";
            this.txt_FinansalKiralama.Size = new System.Drawing.Size(100, 20);
            this.txt_FinansalKiralama.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Finansal Kiralama Alacakları :";
            // 
            // txt_UzunAlacak
            // 
            this.txt_UzunAlacak.Location = new System.Drawing.Point(406, 55);
            this.txt_UzunAlacak.Name = "txt_UzunAlacak";
            this.txt_UzunAlacak.Size = new System.Drawing.Size(100, 20);
            this.txt_UzunAlacak.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Uzun Vadeli Ticari Alacak :";
            // 
            // txt_Factoring
            // 
            this.txt_Factoring.Location = new System.Drawing.Point(139, 120);
            this.txt_Factoring.Name = "txt_Factoring";
            this.txt_Factoring.Size = new System.Drawing.Size(100, 20);
            this.txt_Factoring.TabIndex = 9;
            // 
            // txt_KredilerAvanslar
            // 
            this.txt_KredilerAvanslar.Location = new System.Drawing.Point(139, 89);
            this.txt_KredilerAvanslar.Name = "txt_KredilerAvanslar";
            this.txt_KredilerAvanslar.Size = new System.Drawing.Size(100, 20);
            this.txt_KredilerAvanslar.TabIndex = 8;
            // 
            // txt_MenkulKiymetler
            // 
            this.txt_MenkulKiymetler.Location = new System.Drawing.Point(139, 55);
            this.txt_MenkulKiymetler.Name = "txt_MenkulKiymetler";
            this.txt_MenkulKiymetler.Size = new System.Drawing.Size(100, 20);
            this.txt_MenkulKiymetler.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Factoring Alacakları(net) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Krediler ve Avanslar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menkul Kıymetler :";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sil.Location = new System.Drawing.Point(1000, 161);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(86, 33);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Kaydet.Location = new System.Drawing.Point(908, 161);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(86, 33);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Güncelle.BackgroundImage")));
            this.btn_Güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Güncelle.Location = new System.Drawing.Point(816, 161);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(86, 33);
            this.btn_Güncelle.TabIndex = 0;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Güncelle.UseVisualStyleBackColor = true;
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // frm_DuranVarliklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DuranVarliklar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duran Varlıklar";
            this.Load += new System.EventHandler(this.frm_DuranVarliklar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Güncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox txt_PozitifNegatif;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_PeşinÖdenmişGider;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_FinansalDuran;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_MaddiOlmayan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_DigerDuran;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_MaddiDuranVarliklar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Stoklar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CanliVarliklar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_FinansalYatirim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TürevEnstrüman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FinansalKiralama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UzunAlacak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Factoring;
        private System.Windows.Forms.TextBox txt_KredilerAvanslar;
        private System.Windows.Forms.TextBox txt_MenkulKiymetler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_durantoplam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn duran_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayit_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn menkul_kiymetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn krediler_avanslar;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoring_alacaklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn uvadeli_ticarialacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkiralama_alacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn türev_enstrümanlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn finansal_yatirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn canli_varliklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn mduran_varliklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dduran_varliklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn molmayan_duranvarlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn finansal_duranvarlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesinodenmis_giderler;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozitif_negatif;
        private System.Windows.Forms.DataGridViewTextBoxColumn duranvarlik_toplamı;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirket_adi;
    }
}