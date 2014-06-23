namespace VIES_SUSTAV
{
    partial class frm_LogInPorezniObveznik
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
            this.lbl_poreznaUprava = new System.Windows.Forms.Label();
            this.lbl_VIES = new System.Windows.Forms.Label();
            this.lbl_korisnickoIme = new System.Windows.Forms.Label();
            this.lbl_zaporka = new System.Windows.Forms.Label();
            this.txt_korisnickoIme = new System.Windows.Forms.TextBox();
            this.btn_prijava = new System.Windows.Forms.Button();
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.cbox_vrstaKorisnika = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pocisti = new System.Windows.Forms.Button();
            this.ds_porezniObveznik = new VIES_SUSTAV.ds_porezniObveznik();
            this.tbl_LogINporezniObveznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LogINporezniObveznikTableAdapter = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.tbl_LogINporezniObveznikTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager();
            this.txt_Oib = new System.Windows.Forms.TextBox();
            this.txt_bazaKorisnicko = new System.Windows.Forms.TextBox();
            this.txt_bazaZaporka = new System.Windows.Forms.TextBox();
            this.txt_zaporka = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ds_zaposlenik1 = new VIES_SUSTAV.ds_zaposlenik1();
            this.tbl_LogInZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LogInZaposlenikTableAdapter = new VIES_SUSTAV.ds_zaposlenik1TableAdapters.tbl_LogInZaposlenikTableAdapter();
            this.tableAdapterManager1 = new VIES_SUSTAV.ds_zaposlenik1TableAdapters.TableAdapterManager();
            this.txt_IDZaposlenika = new System.Windows.Forms.TextBox();
            this.txt_ZaposlenikKorisnicko = new System.Windows.Forms.TextBox();
            this.txt_zaposlenikZaporka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LogINporezniObveznikBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_zaposlenik1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LogInZaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_poreznaUprava
            // 
            this.lbl_poreznaUprava.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_poreznaUprava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_poreznaUprava.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poreznaUprava.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_poreznaUprava.Location = new System.Drawing.Point(12, 9);
            this.lbl_poreznaUprava.Name = "lbl_poreznaUprava";
            this.lbl_poreznaUprava.Size = new System.Drawing.Size(457, 24);
            this.lbl_poreznaUprava.TabIndex = 44;
            this.lbl_poreznaUprava.Text = "Ministarstvo financija - Porezna uprava";
            this.lbl_poreznaUprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VIES
            // 
            this.lbl_VIES.BackColor = System.Drawing.Color.Orange;
            this.lbl_VIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_VIES.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VIES.ForeColor = System.Drawing.Color.Navy;
            this.lbl_VIES.Location = new System.Drawing.Point(12, 36);
            this.lbl_VIES.Name = "lbl_VIES";
            this.lbl_VIES.Size = new System.Drawing.Size(457, 24);
            this.lbl_VIES.TabIndex = 45;
            this.lbl_VIES.Text = "VIES sustav poreznih podataka";
            this.lbl_VIES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_korisnickoIme
            // 
            this.lbl_korisnickoIme.AutoSize = true;
            this.lbl_korisnickoIme.Location = new System.Drawing.Point(22, 32);
            this.lbl_korisnickoIme.Name = "lbl_korisnickoIme";
            this.lbl_korisnickoIme.Size = new System.Drawing.Size(98, 14);
            this.lbl_korisnickoIme.TabIndex = 46;
            this.lbl_korisnickoIme.Text = "Korisničko ime:";
            // 
            // lbl_zaporka
            // 
            this.lbl_zaporka.AutoSize = true;
            this.lbl_zaporka.Location = new System.Drawing.Point(22, 70);
            this.lbl_zaporka.Name = "lbl_zaporka";
            this.lbl_zaporka.Size = new System.Drawing.Size(60, 14);
            this.lbl_zaporka.TabIndex = 47;
            this.lbl_zaporka.Text = "Zaporka:";
            // 
            // txt_korisnickoIme
            // 
            this.txt_korisnickoIme.ForeColor = System.Drawing.Color.Navy;
            this.txt_korisnickoIme.Location = new System.Drawing.Point(136, 29);
            this.txt_korisnickoIme.MaxLength = 8;
            this.txt_korisnickoIme.Name = "txt_korisnickoIme";
            this.txt_korisnickoIme.Size = new System.Drawing.Size(159, 22);
            this.txt_korisnickoIme.TabIndex = 0;
            this.txt_korisnickoIme.Leave += new System.EventHandler(this.txt_korisnickoIme_Leave);
            // 
            // btn_prijava
            // 
            this.btn_prijava.Location = new System.Drawing.Point(376, 81);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(80, 40);
            this.btn_prijava.TabIndex = 3;
            this.btn_prijava.Text = "Prijava";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.btn_prijava_Click);
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Location = new System.Drawing.Point(376, 186);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(80, 40);
            this.btn_izlaz.TabIndex = 5;
            this.btn_izlaz.Text = "Izlaz";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.btn_izlaz_Click);
            // 
            // cbox_vrstaKorisnika
            // 
            this.cbox_vrstaKorisnika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_vrstaKorisnika.ForeColor = System.Drawing.Color.Navy;
            this.cbox_vrstaKorisnika.FormattingEnabled = true;
            this.cbox_vrstaKorisnika.Items.AddRange(new object[] {
            "Porezni obveznik",
            "Zaposlenik PU"});
            this.cbox_vrstaKorisnika.Location = new System.Drawing.Point(136, 107);
            this.cbox_vrstaKorisnika.Name = "cbox_vrstaKorisnika";
            this.cbox_vrstaKorisnika.Size = new System.Drawing.Size(167, 22);
            this.cbox_vrstaKorisnika.TabIndex = 2;
            this.cbox_vrstaKorisnika.Text = "- odaberite -";
            this.cbox_vrstaKorisnika.SelectedIndexChanged += new System.EventHandler(this.cbox_vrstaKorisnika_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Vrsta korisnika:\r\n";
            // 
            // btn_pocisti
            // 
            this.btn_pocisti.Location = new System.Drawing.Point(376, 132);
            this.btn_pocisti.Name = "btn_pocisti";
            this.btn_pocisti.Size = new System.Drawing.Size(80, 40);
            this.btn_pocisti.TabIndex = 4;
            this.btn_pocisti.Text = "Počisti";
            this.btn_pocisti.UseVisualStyleBackColor = true;
            this.btn_pocisti.Click += new System.EventHandler(this.btn_pocisti_Click);
            // 
            // ds_porezniObveznik
            // 
            this.ds_porezniObveznik.DataSetName = "ds_porezniObveznik";
            this.ds_porezniObveznik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_LogINporezniObveznikBindingSource
            // 
            this.tbl_LogINporezniObveznikBindingSource.DataMember = "tbl_LogINporezniObveznik";
            this.tbl_LogINporezniObveznikBindingSource.DataSource = this.ds_porezniObveznik;
            // 
            // tbl_LogINporezniObveznikTableAdapter
            // 
            this.tbl_LogINporezniObveznikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LogINporezniObveznikTableAdapter = this.tbl_LogINporezniObveznikTableAdapter;
            this.tableAdapterManager.tbl_osnovnoporezniObveznikTableAdapter = null;
            this.tableAdapterManager.tbl_porezniObveznikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_porezniObveznikTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_Oib
            // 
            this.txt_Oib.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Oib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Oib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogINporezniObveznikBindingSource, "OIB", true));
            this.txt_Oib.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Oib.Location = new System.Drawing.Point(62, 91);
            this.txt_Oib.Name = "txt_Oib";
            this.txt_Oib.ReadOnly = true;
            this.txt_Oib.Size = new System.Drawing.Size(32, 15);
            this.txt_Oib.TabIndex = 61;
            this.txt_Oib.TabStop = false;
            // 
            // txt_bazaKorisnicko
            // 
            this.txt_bazaKorisnicko.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bazaKorisnicko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bazaKorisnicko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogINporezniObveznikBindingSource, "KorisnickoIme", true));
            this.txt_bazaKorisnicko.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_bazaKorisnicko.Location = new System.Drawing.Point(141, 91);
            this.txt_bazaKorisnicko.Name = "txt_bazaKorisnicko";
            this.txt_bazaKorisnicko.ReadOnly = true;
            this.txt_bazaKorisnicko.Size = new System.Drawing.Size(37, 15);
            this.txt_bazaKorisnicko.TabIndex = 63;
            this.txt_bazaKorisnicko.TabStop = false;
            // 
            // txt_bazaZaporka
            // 
            this.txt_bazaZaporka.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bazaZaporka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bazaZaporka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogINporezniObveznikBindingSource, "Zaporka", true));
            this.txt_bazaZaporka.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_bazaZaporka.Location = new System.Drawing.Point(99, 91);
            this.txt_bazaZaporka.Name = "txt_bazaZaporka";
            this.txt_bazaZaporka.ReadOnly = true;
            this.txt_bazaZaporka.Size = new System.Drawing.Size(36, 15);
            this.txt_bazaZaporka.TabIndex = 65;
            this.txt_bazaZaporka.TabStop = false;
            // 
            // txt_zaporka
            // 
            this.txt_zaporka.ForeColor = System.Drawing.Color.Navy;
            this.txt_zaporka.Location = new System.Drawing.Point(136, 67);
            this.txt_zaporka.MaxLength = 8;
            this.txt_zaporka.Name = "txt_zaporka";
            this.txt_zaporka.PasswordChar = '*';
            this.txt_zaporka.Size = new System.Drawing.Size(159, 22);
            this.txt_zaporka.TabIndex = 1;
            this.txt_zaporka.Leave += new System.EventHandler(this.txt_zaporka_Leave_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_korisnickoIme);
            this.panel1.Controls.Add(this.txt_zaporka);
            this.panel1.Controls.Add(this.lbl_korisnickoIme);
            this.panel1.Controls.Add(this.lbl_zaporka);
            this.panel1.Controls.Add(this.cbox_vrstaKorisnika);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 153);
            this.panel1.TabIndex = 66;
            // 
            // ds_zaposlenik1
            // 
            this.ds_zaposlenik1.DataSetName = "ds_zaposlenik1";
            this.ds_zaposlenik1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_LogInZaposlenikBindingSource
            // 
            this.tbl_LogInZaposlenikBindingSource.DataMember = "tbl_LogInZaposlenik";
            this.tbl_LogInZaposlenikBindingSource.DataSource = this.ds_zaposlenik1;
            // 
            // tbl_LogInZaposlenikTableAdapter
            // 
            this.tbl_LogInZaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_LogInZaposlenikTableAdapter = this.tbl_LogInZaposlenikTableAdapter;
            this.tableAdapterManager1.tbl_osnovnoZaposlenikTableAdapter = null;
            this.tableAdapterManager1.tbl_zaposlenikTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VIES_SUSTAV.ds_zaposlenik1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_IDZaposlenika
            // 
            this.txt_IDZaposlenika.BackColor = System.Drawing.SystemColors.Control;
            this.txt_IDZaposlenika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDZaposlenika.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogInZaposlenikBindingSource, "ID_zaposlenika", true));
            this.txt_IDZaposlenika.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_IDZaposlenika.Location = new System.Drawing.Point(185, 91);
            this.txt_IDZaposlenika.Name = "txt_IDZaposlenika";
            this.txt_IDZaposlenika.ReadOnly = true;
            this.txt_IDZaposlenika.Size = new System.Drawing.Size(31, 15);
            this.txt_IDZaposlenika.TabIndex = 68;
            this.txt_IDZaposlenika.TabStop = false;
            // 
            // txt_ZaposlenikKorisnicko
            // 
            this.txt_ZaposlenikKorisnicko.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ZaposlenikKorisnicko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ZaposlenikKorisnicko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogInZaposlenikBindingSource, "Korisnicko_ime", true));
            this.txt_ZaposlenikKorisnicko.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_ZaposlenikKorisnicko.Location = new System.Drawing.Point(222, 91);
            this.txt_ZaposlenikKorisnicko.Name = "txt_ZaposlenikKorisnicko";
            this.txt_ZaposlenikKorisnicko.ReadOnly = true;
            this.txt_ZaposlenikKorisnicko.Size = new System.Drawing.Size(35, 15);
            this.txt_ZaposlenikKorisnicko.TabIndex = 70;
            this.txt_ZaposlenikKorisnicko.TabStop = false;
            // 
            // txt_zaposlenikZaporka
            // 
            this.txt_zaposlenikZaporka.BackColor = System.Drawing.SystemColors.Control;
            this.txt_zaposlenikZaporka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_zaposlenikZaporka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_LogInZaposlenikBindingSource, "Zaporka", true));
            this.txt_zaposlenikZaporka.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_zaposlenikZaporka.Location = new System.Drawing.Point(263, 92);
            this.txt_zaposlenikZaporka.Name = "txt_zaposlenikZaporka";
            this.txt_zaposlenikZaporka.ReadOnly = true;
            this.txt_zaposlenikZaporka.Size = new System.Drawing.Size(29, 15);
            this.txt_zaposlenikZaporka.TabIndex = 72;
            this.txt_zaposlenikZaporka.TabStop = false;
            // 
            // frm_LogInPorezniObveznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 274);
            this.Controls.Add(this.txt_IDZaposlenika);
            this.Controls.Add(this.txt_ZaposlenikKorisnicko);
            this.Controls.Add(this.txt_zaposlenikZaporka);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Oib);
            this.Controls.Add(this.txt_bazaKorisnicko);
            this.Controls.Add(this.txt_bazaZaporka);
            this.Controls.Add(this.btn_pocisti);
            this.Controls.Add(this.btn_izlaz);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.lbl_VIES);
            this.Controls.Add(this.lbl_poreznaUprava);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_LogInPorezniObveznik";
            this.Text = "Prijava poreznog obveznika";
            this.Load += new System.EventHandler(this.frm_LogInPorezniObveznik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_porezniObveznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LogINporezniObveznikBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_zaposlenik1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LogInZaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_poreznaUprava;
        private System.Windows.Forms.Label lbl_VIES;
        private System.Windows.Forms.Label lbl_korisnickoIme;
        private System.Windows.Forms.Label lbl_zaporka;
        private System.Windows.Forms.TextBox txt_korisnickoIme;
        private System.Windows.Forms.Button btn_prijava;
        private System.Windows.Forms.Button btn_izlaz;
        private System.Windows.Forms.ComboBox cbox_vrstaKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pocisti;
        private ds_porezniObveznik ds_porezniObveznik;
        private System.Windows.Forms.BindingSource tbl_LogINporezniObveznikBindingSource;
        private ds_porezniObveznikTableAdapters.tbl_LogINporezniObveznikTableAdapter tbl_LogINporezniObveznikTableAdapter;
        private ds_porezniObveznikTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_Oib;
        private System.Windows.Forms.TextBox txt_bazaKorisnicko;
        private System.Windows.Forms.TextBox txt_bazaZaporka;
        private System.Windows.Forms.TextBox txt_zaporka;
        private System.Windows.Forms.Panel panel1;
        private ds_zaposlenik1 ds_zaposlenik1;
        private System.Windows.Forms.BindingSource tbl_LogInZaposlenikBindingSource;
        private ds_zaposlenik1TableAdapters.tbl_LogInZaposlenikTableAdapter tbl_LogInZaposlenikTableAdapter;
        private ds_zaposlenik1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txt_IDZaposlenika;
        private System.Windows.Forms.TextBox txt_ZaposlenikKorisnicko;
        private System.Windows.Forms.TextBox txt_zaposlenikZaporka;
    }
}