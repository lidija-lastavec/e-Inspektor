namespace VIES_SUSTAV.PretrazivanjeIkontrolaVIES
{
    partial class frm_pregleVIES
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_podrucniUred;
            System.Windows.Forms.Label vrijednost_isporukaLabel;
            System.Windows.Forms.Label vrijednost_stjecanjaLabel;
            System.Windows.Forms.Label lbl_nazivObveznika;
            System.Windows.Forms.Label iD_VIES_IzvješćaLabel;
            System.Windows.Forms.Label lbl_adresaLabel;
            System.Windows.Forms.Label lbl_poreznaIspostava;
            System.Windows.Forms.Label razdoblje_izvještavanjaLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label datum_unosaLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pregleVIES));
            this.pbox_zpEdit = new System.Windows.Forms.PictureBox();
            this.btn_ažuriraj = new System.Windows.Forms.Button();
            this.pbox_zpProvjeri = new System.Windows.Forms.PictureBox();
            this.pbox_dodatiAnalitiku = new System.Windows.Forms.PictureBox();
            this.txt_RazdobljedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbl_VIESizvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ViesUnos = new VIES_SUSTAV.ds_ViesUnos();
            this.pbox_PdvsProvjeri = new System.Windows.Forms.PictureBox();
            this.lbl_zbirna = new System.Windows.Forms.Label();
            this.pnl_isporuke = new System.Windows.Forms.Panel();
            this.txt_isporuke = new System.Windows.Forms.TextBox();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.lbl_provjerenZP = new System.Windows.Forms.Label();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.lbl_ZPdodan = new System.Windows.Forms.Label();
            this.lbl_provjeraPdvS = new System.Windows.Forms.Label();
            this.pbox_provjera = new System.Windows.Forms.PictureBox();
            this.lbl_pdvsDodan = new System.Windows.Forms.Label();
            this.pbx_pdvsDodan = new System.Windows.Forms.PictureBox();
            this.ctxt_zadnjiID = new System.Windows.Forms.TextBox();
            this.pnl_stjecanja = new System.Windows.Forms.Panel();
            this.pbox_PdvsEdit = new System.Windows.Forms.PictureBox();
            this.txt_stjecanje = new System.Windows.Forms.TextBox();
            this.lbl_PdvS = new System.Windows.Forms.Label();
            this.txt_podrucni = new System.Windows.Forms.TextBox();
            this.LoojUpObveznikbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.lbl_NaslovVIES = new System.Windows.Forms.Label();
            this.txt_datumUnosa = new System.Windows.Forms.DateTimePicker();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_lookUpStatus = new System.Windows.Forms.TextBox();
            this.txt_ID1 = new System.Windows.Forms.TextBox();
            this.pnl_VIESizvjestaj = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_OIB = new System.Windows.Forms.TextBox();
            this.txt_ispostava = new System.Windows.Forms.TextBox();
            this.tbl_VIESizvjestajTableAdapter = new VIES_SUSTAV.ds_ViesUnosTableAdapters.tbl_VIESizvjestajTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager();
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            this.Statusbinding = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.tbt_sifarnikStatusaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.lbl_Vies_ažuriranje = new System.Windows.Forms.Label();
            lbl_podrucniUred = new System.Windows.Forms.Label();
            vrijednost_isporukaLabel = new System.Windows.Forms.Label();
            vrijednost_stjecanjaLabel = new System.Windows.Forms.Label();
            lbl_nazivObveznika = new System.Windows.Forms.Label();
            iD_VIES_IzvješćaLabel = new System.Windows.Forms.Label();
            lbl_adresaLabel = new System.Windows.Forms.Label();
            lbl_poreznaIspostava = new System.Windows.Forms.Label();
            razdoblje_izvještavanjaLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            datum_unosaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpProvjeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dodatiAnalitiku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri)).BeginInit();
            this.pnl_isporuke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_provjera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pdvsDodan)).BeginInit();
            this.pnl_stjecanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoojUpObveznikbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            this.pnl_VIESizvjestaj.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statusbinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_podrucniUred
            // 
            lbl_podrucniUred.AutoSize = true;
            lbl_podrucniUred.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_podrucniUred.ForeColor = System.Drawing.Color.Navy;
            lbl_podrucniUred.Location = new System.Drawing.Point(28, 57);
            lbl_podrucniUred.Name = "lbl_podrucniUred";
            lbl_podrucniUred.Size = new System.Drawing.Size(117, 14);
            lbl_podrucniUred.TabIndex = 87;
            lbl_podrucniUred.Text = "Područni Ured PU:";
            // 
            // vrijednost_isporukaLabel
            // 
            vrijednost_isporukaLabel.AutoSize = true;
            vrijednost_isporukaLabel.Location = new System.Drawing.Point(23, 29);
            vrijednost_isporukaLabel.Name = "vrijednost_isporukaLabel";
            vrijednost_isporukaLabel.Size = new System.Drawing.Size(130, 14);
            vrijednost_isporukaLabel.TabIndex = 53;
            vrijednost_isporukaLabel.Text = "Vrijednost isporuka:";
            // 
            // vrijednost_stjecanjaLabel
            // 
            vrijednost_stjecanjaLabel.AutoSize = true;
            vrijednost_stjecanjaLabel.Location = new System.Drawing.Point(23, 27);
            vrijednost_stjecanjaLabel.Name = "vrijednost_stjecanjaLabel";
            vrijednost_stjecanjaLabel.Size = new System.Drawing.Size(133, 14);
            vrijednost_stjecanjaLabel.TabIndex = 51;
            vrijednost_stjecanjaLabel.Text = "Vrijednost stjecanja:";
            // 
            // lbl_nazivObveznika
            // 
            lbl_nazivObveznika.AutoSize = true;
            lbl_nazivObveznika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_nazivObveznika.ForeColor = System.Drawing.Color.Navy;
            lbl_nazivObveznika.Location = new System.Drawing.Point(16, 37);
            lbl_nazivObveznika.Name = "lbl_nazivObveznika";
            lbl_nazivObveznika.Size = new System.Drawing.Size(107, 14);
            lbl_nazivObveznika.TabIndex = 65;
            lbl_nazivObveznika.Text = "Naziv obveznika:";
            // 
            // iD_VIES_IzvješćaLabel
            // 
            iD_VIES_IzvješćaLabel.AutoSize = true;
            iD_VIES_IzvješćaLabel.Location = new System.Drawing.Point(12, 633);
            iD_VIES_IzvješćaLabel.Name = "iD_VIES_IzvješćaLabel";
            iD_VIES_IzvješćaLabel.Size = new System.Drawing.Size(179, 14);
            iD_VIES_IzvješćaLabel.TabIndex = 94;
            iD_VIES_IzvješćaLabel.Text = "Evidencijski broj zaprimanja:";
            // 
            // lbl_adresaLabel
            // 
            lbl_adresaLabel.AutoSize = true;
            lbl_adresaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_adresaLabel.ForeColor = System.Drawing.Color.Navy;
            lbl_adresaLabel.Location = new System.Drawing.Point(16, 69);
            lbl_adresaLabel.Name = "lbl_adresaLabel";
            lbl_adresaLabel.Size = new System.Drawing.Size(53, 14);
            lbl_adresaLabel.TabIndex = 66;
            lbl_adresaLabel.Text = "Adresa:";
            // 
            // lbl_poreznaIspostava
            // 
            lbl_poreznaIspostava.AutoSize = true;
            lbl_poreznaIspostava.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_poreznaIspostava.ForeColor = System.Drawing.Color.Navy;
            lbl_poreznaIspostava.Location = new System.Drawing.Point(28, 84);
            lbl_poreznaIspostava.Name = "lbl_poreznaIspostava";
            lbl_poreznaIspostava.Size = new System.Drawing.Size(124, 14);
            lbl_poreznaIspostava.TabIndex = 88;
            lbl_poreznaIspostava.Text = "Porezna Ispostava:";
            // 
            // razdoblje_izvještavanjaLabel
            // 
            razdoblje_izvještavanjaLabel.AutoSize = true;
            razdoblje_izvještavanjaLabel.Location = new System.Drawing.Point(22, 27);
            razdoblje_izvještavanjaLabel.Name = "razdoblje_izvještavanjaLabel";
            razdoblje_izvještavanjaLabel.Size = new System.Drawing.Size(154, 14);
            razdoblje_izvještavanjaLabel.TabIndex = 49;
            razdoblje_izvještavanjaLabel.Text = "Razdoblje izvještavanja:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIBLabel.ForeColor = System.Drawing.Color.Navy;
            oIBLabel.Location = new System.Drawing.Point(16, 10);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(33, 14);
            oIBLabel.TabIndex = 47;
            oIBLabel.Text = "OIB:";
            // 
            // datum_unosaLabel
            // 
            datum_unosaLabel.AutoSize = true;
            datum_unosaLabel.Location = new System.Drawing.Point(350, 200);
            datum_unosaLabel.Name = "datum_unosaLabel";
            datum_unosaLabel.Size = new System.Drawing.Size(93, 14);
            datum_unosaLabel.TabIndex = 55;
            datum_unosaLabel.Text = "Datum unosa:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(23, 200);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 14);
            statusLabel.TabIndex = 57;
            statusLabel.Text = "Status:";
            // 
            // pbox_zpEdit
            // 
            this.pbox_zpEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbox_zpEdit.Image")));
            this.pbox_zpEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_zpEdit.InitialImage")));
            this.pbox_zpEdit.Location = new System.Drawing.Point(459, 20);
            this.pbox_zpEdit.Name = "pbox_zpEdit";
            this.pbox_zpEdit.Size = new System.Drawing.Size(24, 24);
            this.pbox_zpEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_zpEdit.TabIndex = 71;
            this.pbox_zpEdit.TabStop = false;
            this.pbox_zpEdit.Visible = false;
            this.pbox_zpEdit.Click += new System.EventHandler(this.pbox_zpEdit_Click);
            // 
            // btn_ažuriraj
            // 
            this.btn_ažuriraj.Location = new System.Drawing.Point(529, 529);
            this.btn_ažuriraj.Name = "btn_ažuriraj";
            this.btn_ažuriraj.Size = new System.Drawing.Size(100, 45);
            this.btn_ažuriraj.TabIndex = 82;
            this.btn_ažuriraj.TabStop = false;
            this.btn_ažuriraj.Text = "Ažuriraj";
            this.btn_ažuriraj.UseVisualStyleBackColor = true;
            this.btn_ažuriraj.Click += new System.EventHandler(this.btn_ažuriraj_Click);
            // 
            // pbox_zpProvjeri
            // 
            this.pbox_zpProvjeri.Image = ((System.Drawing.Image)(resources.GetObject("pbox_zpProvjeri.Image")));
            this.pbox_zpProvjeri.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_zpProvjeri.InitialImage")));
            this.pbox_zpProvjeri.Location = new System.Drawing.Point(500, 20);
            this.pbox_zpProvjeri.Name = "pbox_zpProvjeri";
            this.pbox_zpProvjeri.Size = new System.Drawing.Size(24, 24);
            this.pbox_zpProvjeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_zpProvjeri.TabIndex = 72;
            this.pbox_zpProvjeri.TabStop = false;
            this.pbox_zpProvjeri.Visible = false;
            this.pbox_zpProvjeri.Click += new System.EventHandler(this.pbox_zpProvjeri_Click);
            // 
            // pbox_dodatiAnalitiku
            // 
            this.pbox_dodatiAnalitiku.Image = global::VIES_SUSTAV.Properties.Resources.alert;
            this.pbox_dodatiAnalitiku.Location = new System.Drawing.Point(44, 535);
            this.pbox_dodatiAnalitiku.Name = "pbox_dodatiAnalitiku";
            this.pbox_dodatiAnalitiku.Size = new System.Drawing.Size(24, 24);
            this.pbox_dodatiAnalitiku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_dodatiAnalitiku.TabIndex = 92;
            this.pbox_dodatiAnalitiku.TabStop = false;
            // 
            // txt_RazdobljedateTimePicker
            // 
            this.txt_RazdobljedateTimePicker.CustomFormat = "MM-yyyy";
            this.txt_RazdobljedateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_VIESizvjestajBindingSource, "Razdoblje_izvještavanja", true));
            this.txt_RazdobljedateTimePicker.Enabled = false;
            this.txt_RazdobljedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_RazdobljedateTimePicker.Location = new System.Drawing.Point(223, 23);
            this.txt_RazdobljedateTimePicker.Name = "txt_RazdobljedateTimePicker";
            this.txt_RazdobljedateTimePicker.ShowUpDown = true;
            this.txt_RazdobljedateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.txt_RazdobljedateTimePicker.TabIndex = 0;
            // 
            // tbl_VIESizvjestajBindingSource
            // 
            this.tbl_VIESizvjestajBindingSource.DataMember = "tbl_VIESizvjestaj";
            this.tbl_VIESizvjestajBindingSource.DataSource = this.ds_ViesUnos;
            // 
            // ds_ViesUnos
            // 
            this.ds_ViesUnos.DataSetName = "ds_ViesUnos";
            this.ds_ViesUnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbox_PdvsProvjeri
            // 
            this.pbox_PdvsProvjeri.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri.Image")));
            this.pbox_PdvsProvjeri.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsProvjeri.InitialImage")));
            this.pbox_PdvsProvjeri.Location = new System.Drawing.Point(500, 22);
            this.pbox_PdvsProvjeri.Name = "pbox_PdvsProvjeri";
            this.pbox_PdvsProvjeri.Size = new System.Drawing.Size(24, 24);
            this.pbox_PdvsProvjeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsProvjeri.TabIndex = 64;
            this.pbox_PdvsProvjeri.TabStop = false;
            this.pbox_PdvsProvjeri.Visible = false;
            this.pbox_PdvsProvjeri.Click += new System.EventHandler(this.pbox_PdvsProvjeri_Click);
            // 
            // lbl_zbirna
            // 
            this.lbl_zbirna.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zbirna.Location = new System.Drawing.Point(446, 4);
            this.lbl_zbirna.Name = "lbl_zbirna";
            this.lbl_zbirna.Size = new System.Drawing.Size(108, 20);
            this.lbl_zbirna.TabIndex = 61;
            this.lbl_zbirna.Text = "Zbirna prijava";
            // 
            // pnl_isporuke
            // 
            this.pnl_isporuke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_isporuke.Controls.Add(this.pbox_zpProvjeri);
            this.pnl_isporuke.Controls.Add(this.pbox_zpEdit);
            this.pnl_isporuke.Controls.Add(this.txt_isporuke);
            this.pnl_isporuke.Controls.Add(this.lbl_zbirna);
            this.pnl_isporuke.Controls.Add(vrijednost_isporukaLabel);
            this.pnl_isporuke.Location = new System.Drawing.Point(-1, 124);
            this.pnl_isporuke.Name = "pnl_isporuke";
            this.pnl_isporuke.Size = new System.Drawing.Size(613, 59);
            this.pnl_isporuke.TabIndex = 62;
            // 
            // txt_isporuke
            // 
            this.txt_isporuke.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "Vrijednost isporuka", true));
            this.txt_isporuke.Enabled = false;
            this.txt_isporuke.ForeColor = System.Drawing.Color.Navy;
            this.txt_isporuke.Location = new System.Drawing.Point(210, 20);
            this.txt_isporuke.Name = "txt_isporuke";
            this.txt_isporuke.Size = new System.Drawing.Size(233, 22);
            this.txt_isporuke.TabIndex = 0;
            this.txt_isporuke.Text = "0";
            this.txt_isporuke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_alert
            // 
            this.lbl_alert.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_alert.Location = new System.Drawing.Point(93, 535);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(408, 24);
            this.lbl_alert.TabIndex = 93;
            this.lbl_alert.Text = "Vrijednosti u izvještaju može ažurirati samo porezni obveznik.";
            // 
            // lbl_provjerenZP
            // 
            this.lbl_provjerenZP.AutoSize = true;
            this.lbl_provjerenZP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provjerenZP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_provjerenZP.Location = new System.Drawing.Point(93, 613);
            this.lbl_provjerenZP.Name = "lbl_provjerenZP";
            this.lbl_provjerenZP.Size = new System.Drawing.Size(140, 13);
            this.lbl_provjerenZP.TabIndex = 101;
            this.lbl_provjerenZP.Text = "ZP izvještaj - Provjeren";
            this.lbl_provjerenZP.Visible = false;
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.Location = new System.Drawing.Point(529, 591);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(100, 45);
            this.btn_zatvori.TabIndex = 83;
            this.btn_zatvori.TabStop = false;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = true;
            this.btn_zatvori.Click += new System.EventHandler(this.btn_zatvori_Click);
            // 
            // lbl_ZPdodan
            // 
            this.lbl_ZPdodan.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ZPdodan.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_ZPdodan.Location = new System.Drawing.Point(93, 579);
            this.lbl_ZPdodan.Name = "lbl_ZPdodan";
            this.lbl_ZPdodan.Size = new System.Drawing.Size(162, 14);
            this.lbl_ZPdodan.TabIndex = 100;
            this.lbl_ZPdodan.Text = "Ažuriran ZP izvještaj";
            this.lbl_ZPdodan.Visible = false;
            // 
            // lbl_provjeraPdvS
            // 
            this.lbl_provjeraPdvS.AutoSize = true;
            this.lbl_provjeraPdvS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provjeraPdvS.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_provjeraPdvS.Location = new System.Drawing.Point(93, 597);
            this.lbl_provjeraPdvS.Name = "lbl_provjeraPdvS";
            this.lbl_provjeraPdvS.Size = new System.Drawing.Size(160, 13);
            this.lbl_provjeraPdvS.TabIndex = 99;
            this.lbl_provjeraPdvS.Text = "PDV-S izvještaj - Provjeren";
            this.lbl_provjeraPdvS.Visible = false;
            // 
            // pbox_provjera
            // 
            this.pbox_provjera.Image = ((System.Drawing.Image)(resources.GetObject("pbox_provjera.Image")));
            this.pbox_provjera.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_provjera.InitialImage")));
            this.pbox_provjera.Location = new System.Drawing.Point(43, 597);
            this.pbox_provjera.Name = "pbox_provjera";
            this.pbox_provjera.Size = new System.Drawing.Size(24, 24);
            this.pbox_provjera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_provjera.TabIndex = 98;
            this.pbox_provjera.TabStop = false;
            this.pbox_provjera.Visible = false;
            // 
            // lbl_pdvsDodan
            // 
            this.lbl_pdvsDodan.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pdvsDodan.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_pdvsDodan.Location = new System.Drawing.Point(93, 566);
            this.lbl_pdvsDodan.Name = "lbl_pdvsDodan";
            this.lbl_pdvsDodan.Size = new System.Drawing.Size(162, 14);
            this.lbl_pdvsDodan.TabIndex = 97;
            this.lbl_pdvsDodan.Text = "Ažuriran PDV-S izvještaj";
            this.lbl_pdvsDodan.Visible = false;
            // 
            // pbx_pdvsDodan
            // 
            this.pbx_pdvsDodan.Image = ((System.Drawing.Image)(resources.GetObject("pbx_pdvsDodan.Image")));
            this.pbx_pdvsDodan.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_pdvsDodan.InitialImage")));
            this.pbx_pdvsDodan.Location = new System.Drawing.Point(43, 568);
            this.pbx_pdvsDodan.Name = "pbx_pdvsDodan";
            this.pbx_pdvsDodan.Size = new System.Drawing.Size(24, 24);
            this.pbx_pdvsDodan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_pdvsDodan.TabIndex = 96;
            this.pbx_pdvsDodan.TabStop = false;
            this.pbx_pdvsDodan.Visible = false;
            // 
            // ctxt_zadnjiID
            // 
            this.ctxt_zadnjiID.BackColor = System.Drawing.Color.Gainsboro;
            this.ctxt_zadnjiID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctxt_zadnjiID.ForeColor = System.Drawing.Color.Gainsboro;
            this.ctxt_zadnjiID.Location = new System.Drawing.Point(564, 606);
            this.ctxt_zadnjiID.Name = "ctxt_zadnjiID";
            this.ctxt_zadnjiID.Size = new System.Drawing.Size(50, 15);
            this.ctxt_zadnjiID.TabIndex = 95;
            this.ctxt_zadnjiID.TabStop = false;
            // 
            // pnl_stjecanja
            // 
            this.pnl_stjecanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_stjecanja.Controls.Add(this.pbox_PdvsProvjeri);
            this.pnl_stjecanja.Controls.Add(this.pbox_PdvsEdit);
            this.pnl_stjecanja.Controls.Add(this.txt_stjecanje);
            this.pnl_stjecanja.Controls.Add(vrijednost_stjecanjaLabel);
            this.pnl_stjecanja.Controls.Add(this.lbl_PdvS);
            this.pnl_stjecanja.Location = new System.Drawing.Point(-1, 66);
            this.pnl_stjecanja.Name = "pnl_stjecanja";
            this.pnl_stjecanja.Size = new System.Drawing.Size(613, 59);
            this.pnl_stjecanja.TabIndex = 63;
            // 
            // pbox_PdvsEdit
            // 
            this.pbox_PdvsEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsEdit.Image")));
            this.pbox_PdvsEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbox_PdvsEdit.InitialImage")));
            this.pbox_PdvsEdit.Location = new System.Drawing.Point(459, 22);
            this.pbox_PdvsEdit.Name = "pbox_PdvsEdit";
            this.pbox_PdvsEdit.Size = new System.Drawing.Size(24, 24);
            this.pbox_PdvsEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_PdvsEdit.TabIndex = 63;
            this.pbox_PdvsEdit.TabStop = false;
            this.pbox_PdvsEdit.Visible = false;
            this.pbox_PdvsEdit.Click += new System.EventHandler(this.pbox_PdvsEdit_Click);
            // 
            // txt_stjecanje
            // 
            this.txt_stjecanje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "Vrijednost stjecanja", true));
            this.txt_stjecanje.Enabled = false;
            this.txt_stjecanje.ForeColor = System.Drawing.Color.Navy;
            this.txt_stjecanje.Location = new System.Drawing.Point(210, 24);
            this.txt_stjecanje.Name = "txt_stjecanje";
            this.txt_stjecanje.Size = new System.Drawing.Size(233, 22);
            this.txt_stjecanje.TabIndex = 1;
            this.txt_stjecanje.Tag = "";
            this.txt_stjecanje.Text = "0";
            this.txt_stjecanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_PdvS
            // 
            this.lbl_PdvS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PdvS.Location = new System.Drawing.Point(446, 6);
            this.lbl_PdvS.Name = "lbl_PdvS";
            this.lbl_PdvS.Size = new System.Drawing.Size(108, 20);
            this.lbl_PdvS.TabIndex = 60;
            this.lbl_PdvS.Text = "PDV-S Obrazac";
            // 
            // txt_podrucni
            // 
            this.txt_podrucni.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_podrucni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_podrucni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoojUpObveznikbindingSource, "nazivPodrucnogUreda", true));
            this.txt_podrucni.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_podrucni.ForeColor = System.Drawing.Color.Navy;
            this.txt_podrucni.Location = new System.Drawing.Point(226, 56);
            this.txt_podrucni.Name = "txt_podrucni";
            this.txt_podrucni.ReadOnly = true;
            this.txt_podrucni.Size = new System.Drawing.Size(233, 17);
            this.txt_podrucni.TabIndex = 86;
            this.txt_podrucni.TabStop = false;
            // 
            // LoojUpObveznikbindingSource
            // 
            this.LoojUpObveznikbindingSource.DataMember = "tbl_ObveznikLookUp";
            this.LoojUpObveznikbindingSource.DataSource = this.ds_T27;
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(0, 16);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(650, 26);
            this.lbl_poreznaUprava.TabIndex = 84;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NaslovVIES
            // 
            this.lbl_NaslovVIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_NaslovVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NaslovVIES.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NaslovVIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_NaslovVIES.Location = new System.Drawing.Point(-1, 230);
            this.lbl_NaslovVIES.Name = "lbl_NaslovVIES";
            this.lbl_NaslovVIES.Size = new System.Drawing.Size(644, 47);
            this.lbl_NaslovVIES.TabIndex = 85;
            this.lbl_NaslovVIES.Text = "MJESEČNI IZVJEŠTAJ\r\nVIES - POREZ NA DODANU VRIJEDNOST";
            this.lbl_NaslovVIES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_datumUnosa
            // 
            this.txt_datumUnosa.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_VIESizvjestajBindingSource, "Datum unosa", true));
            this.txt_datumUnosa.Enabled = false;
            this.txt_datumUnosa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_datumUnosa.Location = new System.Drawing.Point(459, 196);
            this.txt_datumUnosa.Name = "txt_datumUnosa";
            this.txt_datumUnosa.Size = new System.Drawing.Size(121, 22);
            this.txt_datumUnosa.TabIndex = 1;
            // 
            // txt_naziv
            // 
            this.txt_naziv.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_naziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_naziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoojUpObveznikbindingSource, "NazivObveznika", true));
            this.txt_naziv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_naziv.ForeColor = System.Drawing.Color.Navy;
            this.txt_naziv.Location = new System.Drawing.Point(215, 33);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.ReadOnly = true;
            this.txt_naziv.Size = new System.Drawing.Size(233, 17);
            this.txt_naziv.TabIndex = 67;
            this.txt_naziv.TabStop = false;
            // 
            // txt_adresa
            // 
            this.txt_adresa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_adresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoojUpObveznikbindingSource, "Adresa", true));
            this.txt_adresa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresa.ForeColor = System.Drawing.Color.Navy;
            this.txt_adresa.Location = new System.Drawing.Point(215, 69);
            this.txt_adresa.Multiline = true;
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.ReadOnly = true;
            this.txt_adresa.Size = new System.Drawing.Size(357, 22);
            this.txt_adresa.TabIndex = 68;
            this.txt_adresa.TabStop = false;
            // 
            // txt_lookUpStatus
            // 
            this.txt_lookUpStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_lookUpStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lookUpStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Statusbinding, "Opis_Statusa", true));
            this.txt_lookUpStatus.ForeColor = System.Drawing.Color.Red;
            this.txt_lookUpStatus.Location = new System.Drawing.Point(91, 197);
            this.txt_lookUpStatus.Name = "txt_lookUpStatus";
            this.txt_lookUpStatus.ReadOnly = true;
            this.txt_lookUpStatus.Size = new System.Drawing.Size(147, 15);
            this.txt_lookUpStatus.TabIndex = 68;
            this.txt_lookUpStatus.TabStop = false;
            this.txt_lookUpStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ID1
            // 
            this.txt_ID1.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_ID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "ID_VIES_Izvješća", true));
            this.txt_ID1.ForeColor = System.Drawing.Color.Red;
            this.txt_ID1.Location = new System.Drawing.Point(224, 634);
            this.txt_ID1.Name = "txt_ID1";
            this.txt_ID1.ReadOnly = true;
            this.txt_ID1.Size = new System.Drawing.Size(147, 15);
            this.txt_ID1.TabIndex = 102;
            this.txt_ID1.TabStop = false;
            this.txt_ID1.Text = "0";
            // 
            // pnl_VIESizvjestaj
            // 
            this.pnl_VIESizvjestaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_status);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_lookUpStatus);
            this.pnl_VIESizvjestaj.Controls.Add(this.pnl_stjecanja);
            this.pnl_VIESizvjestaj.Controls.Add(this.pnl_isporuke);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_RazdobljedateTimePicker);
            this.pnl_VIESizvjestaj.Controls.Add(razdoblje_izvještavanjaLabel);
            this.pnl_VIESizvjestaj.Controls.Add(datum_unosaLabel);
            this.pnl_VIESizvjestaj.Controls.Add(this.txt_datumUnosa);
            this.pnl_VIESizvjestaj.Controls.Add(statusLabel);
            this.pnl_VIESizvjestaj.Location = new System.Drawing.Point(15, 296);
            this.pnl_VIESizvjestaj.Name = "pnl_VIESizvjestaj";
            this.pnl_VIESizvjestaj.Size = new System.Drawing.Size(628, 227);
            this.pnl_VIESizvjestaj.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_adresa);
            this.panel1.Controls.Add(this.txt_naziv);
            this.panel1.Controls.Add(lbl_nazivObveznika);
            this.panel1.Controls.Add(lbl_adresaLabel);
            this.panel1.Controls.Add(this.txt_OIB);
            this.panel1.Controls.Add(oIBLabel);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(23, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 110);
            this.panel1.TabIndex = 90;
            // 
            // txt_OIB
            // 
            this.txt_OIB.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_OIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "OIB", true));
            this.txt_OIB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OIB.ForeColor = System.Drawing.Color.Navy;
            this.txt_OIB.Location = new System.Drawing.Point(215, 10);
            this.txt_OIB.Name = "txt_OIB";
            this.txt_OIB.ReadOnly = true;
            this.txt_OIB.Size = new System.Drawing.Size(233, 17);
            this.txt_OIB.TabIndex = 64;
            this.txt_OIB.TabStop = false;
            // 
            // txt_ispostava
            // 
            this.txt_ispostava.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_ispostava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ispostava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoojUpObveznikbindingSource, "nazivIspostave", true));
            this.txt_ispostava.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ispostava.ForeColor = System.Drawing.Color.Navy;
            this.txt_ispostava.Location = new System.Drawing.Point(226, 84);
            this.txt_ispostava.Name = "txt_ispostava";
            this.txt_ispostava.ReadOnly = true;
            this.txt_ispostava.Size = new System.Drawing.Size(233, 17);
            this.txt_ispostava.TabIndex = 89;
            this.txt_ispostava.TabStop = false;
            // 
            // tbl_VIESizvjestajTableAdapter
            // 
            this.tbl_VIESizvjestajTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_VIESizvjestajTableAdapter = this.tbl_VIESizvjestajTableAdapter;
            this.tableAdapterManager.tbt_sifarnikStatusaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_ObveznikLookUpTableAdapter
            // 
            this.tbl_ObveznikLookUpTableAdapter.ClearBeforeFill = true;
            // 
            // Statusbinding
            // 
            this.Statusbinding.DataMember = "tbt_sifarnikStatusa";
            this.Statusbinding.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbt_sifarnikStatusaTableAdapter
            // 
            this.tbt_sifarnikStatusaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_VIESizvjestajBindingSource, "Status", true));
            this.txt_status.ForeColor = System.Drawing.Color.Navy;
            this.txt_status.Location = new System.Drawing.Point(244, 192);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(25, 22);
            this.txt_status.TabIndex = 69;
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(423, 591);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(100, 45);
            this.btn_spremi.TabIndex = 103;
            this.btn_spremi.TabStop = false;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Visible = false;
            this.btn_spremi.Click += new System.EventHandler(this.btn_spremi_Click);
            // 
            // lbl_Vies_ažuriranje
            // 
            this.lbl_Vies_ažuriranje.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vies_ažuriranje.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_Vies_ažuriranje.Location = new System.Drawing.Point(93, 552);
            this.lbl_Vies_ažuriranje.Name = "lbl_Vies_ažuriranje";
            this.lbl_Vies_ažuriranje.Size = new System.Drawing.Size(162, 14);
            this.lbl_Vies_ažuriranje.TabIndex = 104;
            this.lbl_Vies_ažuriranje.Text = "VIES izvještaj je ažuriran";
            this.lbl_Vies_ažuriranje.Visible = false;
            // 
            // frm_pregleVIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(661, 661);
            this.Controls.Add(this.lbl_Vies_ažuriranje);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.btn_ažuriraj);
            this.Controls.Add(lbl_podrucniUred);
            this.Controls.Add(this.pbox_dodatiAnalitiku);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.lbl_provjerenZP);
            this.Controls.Add(this.btn_zatvori);
            this.Controls.Add(this.lbl_ZPdodan);
            this.Controls.Add(this.lbl_provjeraPdvS);
            this.Controls.Add(this.pbox_provjera);
            this.Controls.Add(this.lbl_pdvsDodan);
            this.Controls.Add(this.pbx_pdvsDodan);
            this.Controls.Add(this.ctxt_zadnjiID);
            this.Controls.Add(iD_VIES_IzvješćaLabel);
            this.Controls.Add(lbl_poreznaIspostava);
            this.Controls.Add(this.txt_podrucni);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Controls.Add(this.lbl_NaslovVIES);
            this.Controls.Add(this.txt_ID1);
            this.Controls.Add(this.pnl_VIESizvjestaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ispostava);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "frm_pregleVIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pregled VIES izvještaja";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_pregleVIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zpProvjeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dodatiAnalitiku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_VIESizvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsProvjeri)).EndInit();
            this.pnl_isporuke.ResumeLayout(false);
            this.pnl_isporuke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_provjera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pdvsDodan)).EndInit();
            this.pnl_stjecanja.ResumeLayout(false);
            this.pnl_stjecanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_PdvsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoojUpObveznikbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            this.pnl_VIESizvjestaj.ResumeLayout(false);
            this.pnl_VIESizvjestaj.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statusbinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_zpEdit;
        private System.Windows.Forms.Button btn_ažuriraj;
        private System.Windows.Forms.PictureBox pbox_zpProvjeri;
        private System.Windows.Forms.PictureBox pbox_dodatiAnalitiku;
        private System.Windows.Forms.DateTimePicker txt_RazdobljedateTimePicker;
        private System.Windows.Forms.PictureBox pbox_PdvsProvjeri;
        private System.Windows.Forms.Label lbl_zbirna;
        private System.Windows.Forms.Panel pnl_isporuke;
        private System.Windows.Forms.TextBox txt_isporuke;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.Label lbl_provjerenZP;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.Label lbl_ZPdodan;
        private System.Windows.Forms.Label lbl_provjeraPdvS;
        private System.Windows.Forms.PictureBox pbox_provjera;
        private System.Windows.Forms.Label lbl_pdvsDodan;
        private System.Windows.Forms.PictureBox pbx_pdvsDodan;
        private System.Windows.Forms.TextBox ctxt_zadnjiID;
        private System.Windows.Forms.Panel pnl_stjecanja;
        private System.Windows.Forms.PictureBox pbox_PdvsEdit;
        private System.Windows.Forms.TextBox txt_stjecanje;
        private System.Windows.Forms.Label lbl_PdvS;
        private System.Windows.Forms.TextBox txt_podrucni;
        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.Label lbl_NaslovVIES;
        private System.Windows.Forms.DateTimePicker txt_datumUnosa;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_lookUpStatus;
        private System.Windows.Forms.TextBox txt_ID1;
        private System.Windows.Forms.Panel pnl_VIESizvjestaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_OIB;
        private System.Windows.Forms.TextBox txt_ispostava;
        private ds_ViesUnos ds_ViesUnos;
        private System.Windows.Forms.BindingSource tbl_VIESizvjestajBindingSource;
        private ds_ViesUnosTableAdapters.tbl_VIESizvjestajTableAdapter tbl_VIESizvjestajTableAdapter;
        private ds_ViesUnosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource LoojUpObveznikbindingSource;
        private ds_T27 ds_T27;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
        private System.Windows.Forms.BindingSource Statusbinding;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter tbt_sifarnikStatusaTableAdapter;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.Label lbl_Vies_ažuriranje;
    }
}