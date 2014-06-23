namespace VIES_SUSTAV
{
    partial class frm_GlavniForm
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
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label nazivObveznikaLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label državaLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label iD_zaposlenikaLabel;
            System.Windows.Forms.Label ime_PrezimeLabel;
            System.Windows.Forms.Label ulogaLabel;
            this.btm_Izlaz = new System.Windows.Forms.Button();
            this.pnl_porezniObveznik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.tbl_osnovnoporezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.nazivObveznikaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.državaTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.tbl_osnovnoporezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_osnovnoporezniObveznikTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            this.pnl_zaposlenik = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iD_zaposlenikaTextBox = new System.Windows.Forms.TextBox();
            this.tbl_osnovnoZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_zaposlenik1 = new VIES_SUSTAV.ds_zaposlenik1();
            this.ime_PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.tbl_osnovnoZaposlenikTableAdapter = new VIES_SUSTAV.ds_zaposlenik1TableAdapters.tbl_osnovnoZaposlenikTableAdapter();
            this.tableAdapterManager1 = new VIES_SUSTAV.ds_zaposlenik1TableAdapters.TableAdapterManager();
            this.ms_osnovni = new System.Windows.Forms.MenuStrip();
            this.pregledŠifarnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarObveznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledObveznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogObveznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarVIESPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosVIESIzvještajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarVIESPodatakaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_obavijesti = new System.Windows.Forms.Panel();
            this.lbl_regVIES = new System.Windows.Forms.Label();
            this.lbl_izvjesta = new System.Windows.Forms.Label();
            this.lbl_unosObveznika = new System.Windows.Forms.Label();
            this.lbl_obveznici = new System.Windows.Forms.Label();
            this.lbl_vies = new System.Windows.Forms.Label();
            this.lbl_sifarnici = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            nazivObveznikaLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            državaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            iD_zaposlenikaLabel = new System.Windows.Forms.Label();
            ime_PrezimeLabel = new System.Windows.Forms.Label();
            ulogaLabel = new System.Windows.Forms.Label();
            this.pnl_porezniObveznik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_osnovnoporezniObveznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            this.pnl_zaposlenik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_osnovnoZaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_zaposlenik1)).BeginInit();
            this.ms_osnovni.SuspendLayout();
            this.pnl_obavijesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oIBLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            oIBLabel.Location = new System.Drawing.Point(3, 24);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(30, 13);
            oIBLabel.TabIndex = 0;
            oIBLabel.Text = "OIB:";
            // 
            // nazivObveznikaLabel
            // 
            nazivObveznikaLabel.AutoSize = true;
            nazivObveznikaLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nazivObveznikaLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            nazivObveznikaLabel.Location = new System.Drawing.Point(3, 47);
            nazivObveznikaLabel.Name = "nazivObveznikaLabel";
            nazivObveznikaLabel.Size = new System.Drawing.Size(40, 13);
            nazivObveznikaLabel.TabIndex = 6;
            nazivObveznikaLabel.Text = "Naziv:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresaLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            adresaLabel.Location = new System.Drawing.Point(3, 73);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(50, 13);
            adresaLabel.TabIndex = 8;
            adresaLabel.Text = "Adresa:";
            // 
            // državaLabel
            // 
            državaLabel.AutoSize = true;
            državaLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            državaLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            državaLabel.Location = new System.Drawing.Point(3, 102);
            državaLabel.Name = "državaLabel";
            državaLabel.Size = new System.Drawing.Size(50, 13);
            državaLabel.TabIndex = 10;
            državaLabel.Text = "Država:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.ForeColor = System.Drawing.Color.LightSlateGray;
            statusLabel.Location = new System.Drawing.Point(3, 128);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 13);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // iD_zaposlenikaLabel
            // 
            iD_zaposlenikaLabel.AutoSize = true;
            iD_zaposlenikaLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_zaposlenikaLabel.Location = new System.Drawing.Point(4, 35);
            iD_zaposlenikaLabel.Name = "iD_zaposlenikaLabel";
            iD_zaposlenikaLabel.Size = new System.Drawing.Size(23, 13);
            iD_zaposlenikaLabel.TabIndex = 0;
            iD_zaposlenikaLabel.Text = "ID:";
            // 
            // ime_PrezimeLabel
            // 
            ime_PrezimeLabel.AutoSize = true;
            ime_PrezimeLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ime_PrezimeLabel.Location = new System.Drawing.Point(3, 51);
            ime_PrezimeLabel.Name = "ime_PrezimeLabel";
            ime_PrezimeLabel.Size = new System.Drawing.Size(88, 13);
            ime_PrezimeLabel.TabIndex = 2;
            ime_PrezimeLabel.Text = "Ime i prezime:";
            // 
            // ulogaLabel
            // 
            ulogaLabel.AutoSize = true;
            ulogaLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ulogaLabel.Location = new System.Drawing.Point(3, 68);
            ulogaLabel.Name = "ulogaLabel";
            ulogaLabel.Size = new System.Drawing.Size(42, 13);
            ulogaLabel.TabIndex = 4;
            ulogaLabel.Text = "Uloga:";
            // 
            // btm_Izlaz
            // 
            this.btm_Izlaz.BackColor = System.Drawing.Color.NavajoWhite;
            this.btm_Izlaz.ForeColor = System.Drawing.Color.Navy;
            this.btm_Izlaz.Location = new System.Drawing.Point(913, 646);
            this.btm_Izlaz.Name = "btm_Izlaz";
            this.btm_Izlaz.Size = new System.Drawing.Size(97, 58);
            this.btm_Izlaz.TabIndex = 1;
            this.btm_Izlaz.Text = "Izlaz";
            this.btm_Izlaz.UseVisualStyleBackColor = false;
            this.btm_Izlaz.Click += new System.EventHandler(this.btm_Izlaz_Click);
            // 
            // pnl_porezniObveznik
            // 
            this.pnl_porezniObveznik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_porezniObveznik.Controls.Add(this.label1);
            this.pnl_porezniObveznik.Controls.Add(oIBLabel);
            this.pnl_porezniObveznik.Controls.Add(this.oIBTextBox);
            this.pnl_porezniObveznik.Controls.Add(nazivObveznikaLabel);
            this.pnl_porezniObveznik.Controls.Add(this.nazivObveznikaTextBox);
            this.pnl_porezniObveznik.Controls.Add(adresaLabel);
            this.pnl_porezniObveznik.Controls.Add(this.adresaTextBox);
            this.pnl_porezniObveznik.Controls.Add(državaLabel);
            this.pnl_porezniObveznik.Controls.Add(this.državaTextBox);
            this.pnl_porezniObveznik.Controls.Add(statusLabel);
            this.pnl_porezniObveznik.Controls.Add(this.statusTextBox);
            this.pnl_porezniObveznik.ForeColor = System.Drawing.Color.LightSlateGray;
            this.pnl_porezniObveznik.Location = new System.Drawing.Point(783, 55);
            this.pnl_porezniObveznik.Name = "pnl_porezniObveznik";
            this.pnl_porezniObveznik.Size = new System.Drawing.Size(217, 149);
            this.pnl_porezniObveznik.TabIndex = 3;
            this.pnl_porezniObveznik.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prijavljen porezni obveznik:";
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.oIBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoporezniObveznikBindingSource, "OIB", true));
            this.oIBTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oIBTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.oIBTextBox.Location = new System.Drawing.Point(58, 21);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(143, 13);
            this.oIBTextBox.TabIndex = 1;
            // 
            // tbl_osnovnoporezniObveznikBindingSource
            // 
            this.tbl_osnovnoporezniObveznikBindingSource.DataMember = "tbl_osnovnoporezniObveznik";
            this.tbl_osnovnoporezniObveznikBindingSource.DataSource = this.ds_porezniObveznik;
            // 
            // ds_porezniObveznik
            // 
            this.ds_porezniObveznik.DataSetName = "ds_porezniObveznik";
            this.ds_porezniObveznik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivObveznikaTextBox
            // 
            this.nazivObveznikaTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nazivObveznikaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazivObveznikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoporezniObveznikBindingSource, "NazivObveznika", true));
            this.nazivObveznikaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivObveznikaTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.nazivObveznikaTextBox.Location = new System.Drawing.Point(58, 47);
            this.nazivObveznikaTextBox.Name = "nazivObveznikaTextBox";
            this.nazivObveznikaTextBox.Size = new System.Drawing.Size(143, 13);
            this.nazivObveznikaTextBox.TabIndex = 7;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.adresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoporezniObveznikBindingSource, "Adresa", true));
            this.adresaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.adresaTextBox.Location = new System.Drawing.Point(58, 73);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(143, 13);
            this.adresaTextBox.TabIndex = 9;
            // 
            // državaTextBox
            // 
            this.državaTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.državaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.državaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoporezniObveznikBindingSource, "Država", true));
            this.državaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.državaTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.državaTextBox.Location = new System.Drawing.Point(58, 99);
            this.državaTextBox.Name = "državaTextBox";
            this.državaTextBox.Size = new System.Drawing.Size(107, 13);
            this.državaTextBox.TabIndex = 11;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoporezniObveznikBindingSource, "Status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.statusTextBox.Location = new System.Drawing.Point(58, 125);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(83, 13);
            this.statusTextBox.TabIndex = 13;
            // 
            // tbl_osnovnoporezniObveznikTableAdapter
            // 
            this.tbl_osnovnoporezniObveznikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LogINporezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_osnovnoporezniObveznikTableAdapter = this.tbl_osnovnoporezniObveznikTableAdapter;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnl_zaposlenik
            // 
            this.pnl_zaposlenik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_zaposlenik.Controls.Add(this.label2);
            this.pnl_zaposlenik.Controls.Add(iD_zaposlenikaLabel);
            this.pnl_zaposlenik.Controls.Add(this.iD_zaposlenikaTextBox);
            this.pnl_zaposlenik.Controls.Add(ime_PrezimeLabel);
            this.pnl_zaposlenik.Controls.Add(this.ime_PrezimeTextBox);
            this.pnl_zaposlenik.Controls.Add(ulogaLabel);
            this.pnl_zaposlenik.Controls.Add(this.txt_uloga);
            this.pnl_zaposlenik.ForeColor = System.Drawing.Color.LightSlateGray;
            this.pnl_zaposlenik.Location = new System.Drawing.Point(748, 210);
            this.pnl_zaposlenik.Name = "pnl_zaposlenik";
            this.pnl_zaposlenik.Size = new System.Drawing.Size(268, 94);
            this.pnl_zaposlenik.TabIndex = 4;
            this.pnl_zaposlenik.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prijavljen zaposlenik:";
            // 
            // iD_zaposlenikaTextBox
            // 
            this.iD_zaposlenikaTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.iD_zaposlenikaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iD_zaposlenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoZaposlenikBindingSource, "ID_zaposlenika", true));
            this.iD_zaposlenikaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_zaposlenikaTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.iD_zaposlenikaTextBox.Location = new System.Drawing.Point(33, 35);
            this.iD_zaposlenikaTextBox.Name = "iD_zaposlenikaTextBox";
            this.iD_zaposlenikaTextBox.Size = new System.Drawing.Size(100, 13);
            this.iD_zaposlenikaTextBox.TabIndex = 1;
            // 
            // tbl_osnovnoZaposlenikBindingSource
            // 
            this.tbl_osnovnoZaposlenikBindingSource.DataMember = "tbl_osnovnoZaposlenik";
            this.tbl_osnovnoZaposlenikBindingSource.DataSource = this.ds_zaposlenik1;
            // 
            // ds_zaposlenik1
            // 
            this.ds_zaposlenik1.DataSetName = "ds_zaposlenik1";
            this.ds_zaposlenik1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ime_PrezimeTextBox
            // 
            this.ime_PrezimeTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ime_PrezimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ime_PrezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoZaposlenikBindingSource, "Ime_Prezime", true));
            this.ime_PrezimeTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_PrezimeTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ime_PrezimeTextBox.Location = new System.Drawing.Point(97, 51);
            this.ime_PrezimeTextBox.Name = "ime_PrezimeTextBox";
            this.ime_PrezimeTextBox.Size = new System.Drawing.Size(143, 13);
            this.ime_PrezimeTextBox.TabIndex = 3;
            // 
            // txt_uloga
            // 
            this.txt_uloga.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_uloga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_uloga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_osnovnoZaposlenikBindingSource, "Uloga", true));
            this.txt_uloga.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uloga.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txt_uloga.Location = new System.Drawing.Point(49, 67);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(150, 13);
            this.txt_uloga.TabIndex = 5;
            // 
            // tbl_osnovnoZaposlenikTableAdapter
            // 
            this.tbl_osnovnoZaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_LogInZaposlenikTableAdapter = null;
            this.tableAdapterManager1.tbl_osnovnoZaposlenikTableAdapter = this.tbl_osnovnoZaposlenikTableAdapter;
            this.tableAdapterManager1.tbl_zaposlenikTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VIES_SUSTAV.ds_zaposlenik1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ms_osnovni
            // 
            this.ms_osnovni.BackColor = System.Drawing.Color.Orange;
            this.ms_osnovni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ms_osnovni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledŠifarnikaToolStripMenuItem,
            this.registarObveznikaToolStripMenuItem,
            this.registarVIESPodatakaToolStripMenuItem});
            this.ms_osnovni.Location = new System.Drawing.Point(0, 0);
            this.ms_osnovni.Name = "ms_osnovni";
            this.ms_osnovni.Size = new System.Drawing.Size(1028, 24);
            this.ms_osnovni.TabIndex = 5;
            this.ms_osnovni.Text = "menuStrip1";
            // 
            // pregledŠifarnikaToolStripMenuItem
            // 
            this.pregledŠifarnikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.šifarniciToolStripMenuItem});
            this.pregledŠifarnikaToolStripMenuItem.Name = "pregledŠifarnikaToolStripMenuItem";
            this.pregledŠifarnikaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.pregledŠifarnikaToolStripMenuItem.Text = "Pregled šifarnika";
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            this.šifarniciToolStripMenuItem.Click += new System.EventHandler(this.šifarniciToolStripMenuItem_Click);
            // 
            // registarObveznikaToolStripMenuItem
            // 
            this.registarObveznikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledObveznikaToolStripMenuItem,
            this.unosNovogObveznikaToolStripMenuItem});
            this.registarObveznikaToolStripMenuItem.Name = "registarObveznikaToolStripMenuItem";
            this.registarObveznikaToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.registarObveznikaToolStripMenuItem.Text = "Registar obveznika";
            // 
            // pregledObveznikaToolStripMenuItem
            // 
            this.pregledObveznikaToolStripMenuItem.Name = "pregledObveznikaToolStripMenuItem";
            this.pregledObveznikaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.pregledObveznikaToolStripMenuItem.Text = "Pregled obveznika";
            this.pregledObveznikaToolStripMenuItem.Click += new System.EventHandler(this.pregledObveznikaToolStripMenuItem_Click);
            // 
            // unosNovogObveznikaToolStripMenuItem
            // 
            this.unosNovogObveznikaToolStripMenuItem.Name = "unosNovogObveznikaToolStripMenuItem";
            this.unosNovogObveznikaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.unosNovogObveznikaToolStripMenuItem.Text = "Unos novog obveznika";
            this.unosNovogObveznikaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogObveznikaToolStripMenuItem_Click);
            // 
            // registarVIESPodatakaToolStripMenuItem
            // 
            this.registarVIESPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosVIESIzvještajaToolStripMenuItem,
            this.registarVIESPodatakaToolStripMenuItem1});
            this.registarVIESPodatakaToolStripMenuItem.Name = "registarVIESPodatakaToolStripMenuItem";
            this.registarVIESPodatakaToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.registarVIESPodatakaToolStripMenuItem.Text = "Registar VIES podataka";
            // 
            // unosVIESIzvještajaToolStripMenuItem
            // 
            this.unosVIESIzvještajaToolStripMenuItem.Name = "unosVIESIzvještajaToolStripMenuItem";
            this.unosVIESIzvještajaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.unosVIESIzvještajaToolStripMenuItem.Text = "Unos VIES izvještaja";
            this.unosVIESIzvještajaToolStripMenuItem.Click += new System.EventHandler(this.unosVIESIzvještajaToolStripMenuItem_Click);
            // 
            // registarVIESPodatakaToolStripMenuItem1
            // 
            this.registarVIESPodatakaToolStripMenuItem1.Name = "registarVIESPodatakaToolStripMenuItem1";
            this.registarVIESPodatakaToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.registarVIESPodatakaToolStripMenuItem1.Text = "Registar VIES podataka";
            this.registarVIESPodatakaToolStripMenuItem1.Click += new System.EventHandler(this.registarVIESPodatakaToolStripMenuItem1_Click);
            // 
            // pnl_obavijesti
            // 
            this.pnl_obavijesti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_obavijesti.Controls.Add(this.lbl_regVIES);
            this.pnl_obavijesti.Controls.Add(this.lbl_izvjesta);
            this.pnl_obavijesti.Controls.Add(this.lbl_unosObveznika);
            this.pnl_obavijesti.Controls.Add(this.lbl_obveznici);
            this.pnl_obavijesti.Controls.Add(this.lbl_vies);
            this.pnl_obavijesti.Controls.Add(this.lbl_sifarnici);
            this.pnl_obavijesti.Location = new System.Drawing.Point(748, 310);
            this.pnl_obavijesti.Name = "pnl_obavijesti";
            this.pnl_obavijesti.Size = new System.Drawing.Size(267, 330);
            this.pnl_obavijesti.TabIndex = 6;
            // 
            // lbl_regVIES
            // 
            this.lbl_regVIES.AutoSize = true;
            this.lbl_regVIES.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regVIES.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_regVIES.Location = new System.Drawing.Point(60, 226);
            this.lbl_regVIES.Name = "lbl_regVIES";
            this.lbl_regVIES.Size = new System.Drawing.Size(160, 58);
            this.lbl_regVIES.TabIndex = 5;
            this.lbl_regVIES.Text = "Registar \r\nVIES podataka";
            this.lbl_regVIES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_regVIES.Visible = false;
            // 
            // lbl_izvjesta
            // 
            this.lbl_izvjesta.AutoSize = true;
            this.lbl_izvjesta.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izvjesta.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_izvjesta.Location = new System.Drawing.Point(28, 197);
            this.lbl_izvjesta.Name = "lbl_izvjesta";
            this.lbl_izvjesta.Size = new System.Drawing.Size(225, 29);
            this.lbl_izvjesta.TabIndex = 4;
            this.lbl_izvjesta.Text = "Unos novog izvještaja";
            this.lbl_izvjesta.Visible = false;
            // 
            // lbl_unosObveznika
            // 
            this.lbl_unosObveznika.AutoSize = true;
            this.lbl_unosObveznika.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unosObveznika.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_unosObveznika.Location = new System.Drawing.Point(28, 168);
            this.lbl_unosObveznika.Name = "lbl_unosObveznika";
            this.lbl_unosObveznika.Size = new System.Drawing.Size(223, 29);
            this.lbl_unosObveznika.TabIndex = 3;
            this.lbl_unosObveznika.Text = "Unos novog obveznika";
            this.lbl_unosObveznika.Visible = false;
            // 
            // lbl_obveznici
            // 
            this.lbl_obveznici.AutoSize = true;
            this.lbl_obveznici.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obveznici.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_obveznici.Location = new System.Drawing.Point(42, 101);
            this.lbl_obveznici.Name = "lbl_obveznici";
            this.lbl_obveznici.Size = new System.Drawing.Size(197, 58);
            this.lbl_obveznici.TabIndex = 2;
            this.lbl_obveznici.Text = "Registar \r\nporeznih obveznika";
            this.lbl_obveznici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_obveznici.Visible = false;
            // 
            // lbl_vies
            // 
            this.lbl_vies.AutoSize = true;
            this.lbl_vies.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vies.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_vies.Location = new System.Drawing.Point(41, 16);
            this.lbl_vies.Name = "lbl_vies";
            this.lbl_vies.Size = new System.Drawing.Size(179, 38);
            this.lbl_vies.TabIndex = 1;
            this.lbl_vies.Text = "VIES sustav";
            // 
            // lbl_sifarnici
            // 
            this.lbl_sifarnici.AutoSize = true;
            this.lbl_sifarnici.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifarnici.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbl_sifarnici.Location = new System.Drawing.Point(52, 62);
            this.lbl_sifarnici.Name = "lbl_sifarnici";
            this.lbl_sifarnici.Size = new System.Drawing.Size(178, 29);
            this.lbl_sifarnici.TabIndex = 0;
            this.lbl_sifarnici.Text = "Pregled šifarnika";
            this.lbl_sifarnici.Visible = false;
            // 
            // frm_GlavniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1028, 746);
            this.Controls.Add(this.pnl_obavijesti);
            this.Controls.Add(this.pnl_zaposlenik);
            this.Controls.Add(this.pnl_porezniObveznik);
            this.Controls.Add(this.btm_Izlaz);
            this.Controls.Add(this.ms_osnovni);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(0, 100);
            this.MainMenuStrip = this.ms_osnovni;
            this.Name = "frm_GlavniForm";
            this.Text = "VIES SUSTAV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Glavni_form_Load);
            this.pnl_porezniObveznik.ResumeLayout(false);
            this.pnl_porezniObveznik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_osnovnoporezniObveznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            this.pnl_zaposlenik.ResumeLayout(false);
            this.pnl_zaposlenik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_osnovnoZaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_zaposlenik1)).EndInit();
            this.ms_osnovni.ResumeLayout(false);
            this.ms_osnovni.PerformLayout();
            this.pnl_obavijesti.ResumeLayout(false);
            this.pnl_obavijesti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_Izlaz;
        private System.Windows.Forms.Panel pnl_porezniObveznik;
        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.BindingSource tbl_osnovnoporezniObveznikBindingSource;
        private ds_porezniObveznikTableAdapters.tbl_osnovnoporezniObveznikTableAdapter tbl_osnovnoporezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox nazivObveznikaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox državaTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Panel pnl_zaposlenik;
        private ds_zaposlenik1 ds_zaposlenik1;
        private System.Windows.Forms.BindingSource tbl_osnovnoZaposlenikBindingSource;
        private ds_zaposlenik1TableAdapters.tbl_osnovnoZaposlenikTableAdapter tbl_osnovnoZaposlenikTableAdapter;
        private ds_zaposlenik1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox iD_zaposlenikaTextBox;
        private System.Windows.Forms.TextBox ime_PrezimeTextBox;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip ms_osnovni;
        private System.Windows.Forms.ToolStripMenuItem pregledŠifarnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_obavijesti;
        private System.Windows.Forms.Label lbl_sifarnici;
        private System.Windows.Forms.Label lbl_vies;
        private System.Windows.Forms.ToolStripMenuItem registarObveznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledObveznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogObveznikaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_obveznici;
        private System.Windows.Forms.Label lbl_unosObveznika;
        private System.Windows.Forms.ToolStripMenuItem registarVIESPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosVIESIzvještajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarVIESPodatakaToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_izvjesta;
        private System.Windows.Forms.Label lbl_regVIES;
    }
}