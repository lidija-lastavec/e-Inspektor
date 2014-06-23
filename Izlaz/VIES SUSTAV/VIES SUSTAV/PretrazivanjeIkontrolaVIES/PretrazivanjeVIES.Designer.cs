namespace VIES_SUSTAV.PretrazivanjeIkontrolaVIES
{
    partial class frm_pretrazivanjeVIES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ds_ViesUnos = new VIES_SUSTAV.ds_ViesUnos();
            this.tbl_pretrazivanjeVIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pretrazivanjeVIESTableAdapter = new VIES_SUSTAV.ds_ViesUnosTableAdapters.tbl_pretrazivanjeVIESTableAdapter();
            this.tableAdapterManager = new VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager();
            this.tbl_pretrazivanjeVIESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SifarnicibindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sifarnici_lookUp = new VIES_SUSTAV.ds_sifarnici_lookUp();
            this.ID_VIES_Izvješća = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.btn_pocisti = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_status = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_razdoblje = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_oib = new System.Windows.Forms.RadioButton();
            this.cbox_status = new System.Windows.Forms.ComboBox();
            this.txt_oib = new System.Windows.Forms.TextBox();
            this.txt_RazdobljedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbox_OIB = new System.Windows.Forms.ComboBox();
            this.ObveznikLookUPbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_T27 = new VIES_SUSTAV.ds_T27();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_sifarnikStatusaTableAdapter = new VIES_SUSTAV.ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter();
            this.btm_Izlaz = new System.Windows.Forms.Button();
            this.tbl_ObveznikLookUpTableAdapter = new VIES_SUSTAV.ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pretrazivanjeVIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pretrazivanjeVIESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifarnicibindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUPbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_ViesUnos
            // 
            this.ds_ViesUnos.DataSetName = "ds_ViesUnos";
            this.ds_ViesUnos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pretrazivanjeVIESBindingSource
            // 
            this.tbl_pretrazivanjeVIESBindingSource.DataMember = "tbl_pretrazivanjeVIES";
            this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos;
            // 
            // tbl_pretrazivanjeVIESTableAdapter
            // 
            this.tbl_pretrazivanjeVIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbl_VIESizvjestajTableAdapter = null;
            this.tableAdapterManager.tbt_sifarnikStatusaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VIES_SUSTAV.ds_ViesUnosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pretrazivanjeVIESDataGridView
            // 
            this.tbl_pretrazivanjeVIESDataGridView.AllowUserToAddRows = false;
            this.tbl_pretrazivanjeVIESDataGridView.AllowUserToDeleteRows = false;
            this.tbl_pretrazivanjeVIESDataGridView.AllowUserToResizeColumns = false;
            this.tbl_pretrazivanjeVIESDataGridView.AllowUserToResizeRows = false;
            this.tbl_pretrazivanjeVIESDataGridView.AutoGenerateColumns = false;
            this.tbl_pretrazivanjeVIESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pretrazivanjeVIESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ID_VIES_Izvješća});
            this.tbl_pretrazivanjeVIESDataGridView.DataSource = this.tbl_pretrazivanjeVIESBindingSource;
            this.tbl_pretrazivanjeVIESDataGridView.Location = new System.Drawing.Point(12, 209);
            this.tbl_pretrazivanjeVIESDataGridView.Name = "tbl_pretrazivanjeVIESDataGridView";
            this.tbl_pretrazivanjeVIESDataGridView.ReadOnly = true;
            this.tbl_pretrazivanjeVIESDataGridView.Size = new System.Drawing.Size(568, 286);
            this.tbl_pretrazivanjeVIESDataGridView.TabIndex = 1;
            this.tbl_pretrazivanjeVIESDataGridView.TabStop = false;
            this.tbl_pretrazivanjeVIESDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pretrazivanjeVIESDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OIB";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazivObveznika";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv obveznika";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Razdoblje_izvještavanja";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Razdoblje izvještavanja";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.DataSource = this.SifarnicibindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Opis_Statusa";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Status zaprimanja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDStatusa";
            this.dataGridViewTextBoxColumn4.Width = 131;
            // 
            // SifarnicibindingSource
            // 
            this.SifarnicibindingSource.DataMember = "tbt_sifarnikStatusa";
            this.SifarnicibindingSource.DataSource = this.ds_sifarnici_lookUp;
            // 
            // ds_sifarnici_lookUp
            // 
            this.ds_sifarnici_lookUp.DataSetName = "ds_sifarnici_lookUp";
            this.ds_sifarnici_lookUp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_VIES_Izvješća
            // 
            this.ID_VIES_Izvješća.DataPropertyName = "ID_VIES_Izvješća";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_VIES_Izvješća.DefaultCellStyle = dataGridViewCellStyle5;
            this.ID_VIES_Izvješća.HeaderText = "Evidencijski broj";
            this.ID_VIES_Izvješća.Name = "ID_VIES_Izvješća";
            this.ID_VIES_Izvješća.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_status);
            this.panel1.Controls.Add(this.btn_pretrazi);
            this.panel1.Controls.Add(this.btn_pocisti);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbox_status);
            this.panel1.Controls.Add(this.txt_oib);
            this.panel1.Controls.Add(this.txt_RazdobljedateTimePicker);
            this.panel1.Controls.Add(this.cbox_OIB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 157);
            this.panel1.TabIndex = 2;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.Wheat;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.ForeColor = System.Drawing.Color.Wheat;
            this.txt_status.Location = new System.Drawing.Point(85, 110);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(20, 15);
            this.txt_status.TabIndex = 21;
            this.txt_status.TabStop = false;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Location = new System.Drawing.Point(423, 36);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(100, 40);
            this.btn_pretrazi.TabIndex = 20;
            this.btn_pretrazi.Text = "Traži";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // btn_pocisti
            // 
            this.btn_pocisti.Location = new System.Drawing.Point(423, 87);
            this.btn_pocisti.Name = "btn_pocisti";
            this.btn_pocisti.Size = new System.Drawing.Size(100, 40);
            this.btn_pocisti.TabIndex = 18;
            this.btn_pocisti.Text = "Počisti";
            this.btn_pocisti.UseVisualStyleBackColor = true;
            this.btn_pocisti.Click += new System.EventHandler(this.btn_pocisti_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtn_status);
            this.panel4.Location = new System.Drawing.Point(288, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 17;
            // 
            // rbtn_status
            // 
            this.rbtn_status.AutoSize = true;
            this.rbtn_status.Location = new System.Drawing.Point(3, 4);
            this.rbtn_status.Name = "rbtn_status";
            this.rbtn_status.Size = new System.Drawing.Size(14, 13);
            this.rbtn_status.TabIndex = 12;
            this.rbtn_status.TabStop = true;
            this.rbtn_status.UseVisualStyleBackColor = true;
            this.rbtn_status.CheckedChanged += new System.EventHandler(this.rbtn_status_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtn_razdoblje);
            this.panel3.Location = new System.Drawing.Point(288, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 16;
            // 
            // rbtn_razdoblje
            // 
            this.rbtn_razdoblje.AutoSize = true;
            this.rbtn_razdoblje.Location = new System.Drawing.Point(4, 4);
            this.rbtn_razdoblje.Name = "rbtn_razdoblje";
            this.rbtn_razdoblje.Size = new System.Drawing.Size(14, 13);
            this.rbtn_razdoblje.TabIndex = 12;
            this.rbtn_razdoblje.TabStop = true;
            this.rbtn_razdoblje.UseVisualStyleBackColor = true;
            this.rbtn_razdoblje.CheckedChanged += new System.EventHandler(this.rbtn_razdoblje_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_oib);
            this.panel2.Location = new System.Drawing.Point(288, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 15;
            // 
            // rbtn_oib
            // 
            this.rbtn_oib.AutoSize = true;
            this.rbtn_oib.Location = new System.Drawing.Point(4, 3);
            this.rbtn_oib.Name = "rbtn_oib";
            this.rbtn_oib.Size = new System.Drawing.Size(14, 13);
            this.rbtn_oib.TabIndex = 12;
            this.rbtn_oib.TabStop = true;
            this.rbtn_oib.UseVisualStyleBackColor = true;
            this.rbtn_oib.CheckedChanged += new System.EventHandler(this.rbtn_oib_CheckedChanged);
            // 
            // cbox_status
            // 
            this.cbox_status.ForeColor = System.Drawing.Color.Navy;
            this.cbox_status.FormattingEnabled = true;
            this.cbox_status.Items.AddRange(new object[] {
            "Novi unos      ",
            "ZAPRIMLJEN     ",
            "ODBIJEN        "});
            this.cbox_status.Location = new System.Drawing.Point(122, 110);
            this.cbox_status.Name = "cbox_status";
            this.cbox_status.Size = new System.Drawing.Size(147, 22);
            this.cbox_status.TabIndex = 11;
            this.cbox_status.Text = "- status -";
            this.cbox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_oib
            // 
            this.txt_oib.ForeColor = System.Drawing.Color.Navy;
            this.txt_oib.Location = new System.Drawing.Point(122, 19);
            this.txt_oib.Name = "txt_oib";
            this.txt_oib.ReadOnly = true;
            this.txt_oib.Size = new System.Drawing.Size(147, 22);
            this.txt_oib.TabIndex = 10;
            this.txt_oib.TabStop = false;
            this.txt_oib.TextChanged += new System.EventHandler(this.txt_oib_TextChanged);
            // 
            // txt_RazdobljedateTimePicker
            // 
            this.txt_RazdobljedateTimePicker.CustomFormat = "MM-yyyy";
            this.txt_RazdobljedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_RazdobljedateTimePicker.Location = new System.Drawing.Point(122, 71);
            this.txt_RazdobljedateTimePicker.Name = "txt_RazdobljedateTimePicker";
            this.txt_RazdobljedateTimePicker.ShowUpDown = true;
            this.txt_RazdobljedateTimePicker.Size = new System.Drawing.Size(148, 22);
            this.txt_RazdobljedateTimePicker.TabIndex = 9;
            this.txt_RazdobljedateTimePicker.ValueChanged += new System.EventHandler(this.txt_RazdobljedateTimePicker_ValueChanged);
            // 
            // cbox_OIB
            // 
            this.cbox_OIB.DataSource = this.ObveznikLookUPbindingSource;
            this.cbox_OIB.DisplayMember = "OIB";
            this.cbox_OIB.ForeColor = System.Drawing.Color.Navy;
            this.cbox_OIB.FormattingEnabled = true;
            this.cbox_OIB.Location = new System.Drawing.Point(122, 40);
            this.cbox_OIB.Name = "cbox_OIB";
            this.cbox_OIB.Size = new System.Drawing.Size(148, 22);
            this.cbox_OIB.TabIndex = 6;
            this.cbox_OIB.ValueMember = "OIB";
            this.cbox_OIB.SelectedIndexChanged += new System.EventHandler(this.cbox_OIB_SelectedIndexChanged);
            // 
            // ObveznikLookUPbindingSource
            // 
            this.ObveznikLookUPbindingSource.DataMember = "tbl_ObveznikLookUp";
            this.ObveznikLookUPbindingSource.DataSource = this.ds_T27;
            // 
            // ds_T27
            // 
            this.ds_T27.DataSetName = "ds_T27";
            this.ds_T27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razdoblje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "OIB:";
            // 
            // tbt_sifarnikStatusaTableAdapter
            // 
            this.tbt_sifarnikStatusaTableAdapter.ClearBeforeFill = true;
            // 
            // btm_Izlaz
            // 
            this.btm_Izlaz.BackColor = System.Drawing.SystemColors.Window;
            this.btm_Izlaz.ForeColor = System.Drawing.Color.Navy;
            this.btm_Izlaz.Location = new System.Drawing.Point(480, 514);
            this.btm_Izlaz.Name = "btm_Izlaz";
            this.btm_Izlaz.Size = new System.Drawing.Size(100, 40);
            this.btm_Izlaz.TabIndex = 3;
            this.btm_Izlaz.Text = "Izlaz";
            this.btm_Izlaz.UseVisualStyleBackColor = false;
            this.btm_Izlaz.Click += new System.EventHandler(this.btm_Izlaz_Click);
            // 
            // tbl_ObveznikLookUpTableAdapter
            // 
            this.tbl_ObveznikLookUpTableAdapter.ClearBeforeFill = true;
            // 
            // frm_pretrazivanjeVIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.btm_Izlaz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_pretrazivanjeVIESDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(60, 80);
            this.Name = "frm_pretrazivanjeVIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PretrazivanjeVIES";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_pretrazivanjeVIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_ViesUnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pretrazivanjeVIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pretrazivanjeVIESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SifarnicibindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sifarnici_lookUp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObveznikLookUPbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_T27)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_ViesUnos ds_ViesUnos;
        private System.Windows.Forms.BindingSource tbl_pretrazivanjeVIESBindingSource;
        private ds_ViesUnosTableAdapters.tbl_pretrazivanjeVIESTableAdapter tbl_pretrazivanjeVIESTableAdapter;
        private ds_ViesUnosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_pretrazivanjeVIESDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource SifarnicibindingSource;
        private ds_sifarnici_lookUp ds_sifarnici_lookUp;
        private ds_sifarnici_lookUpTableAdapters.tbt_sifarnikStatusaTableAdapter tbt_sifarnikStatusaTableAdapter;
        private System.Windows.Forms.Button btm_Izlaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_OIB;
        private System.Windows.Forms.TextBox txt_oib;
        private System.Windows.Forms.DateTimePicker txt_RazdobljedateTimePicker;
        private System.Windows.Forms.BindingSource ObveznikLookUPbindingSource;
        private ds_T27 ds_T27;
        private ds_T27TableAdapters.tbl_ObveznikLookUpTableAdapter tbl_ObveznikLookUpTableAdapter;
        private System.Windows.Forms.ComboBox cbox_status;
        private System.Windows.Forms.RadioButton rbtn_oib;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn_razdoblje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pocisti;
        private System.Windows.Forms.Button btn_pretrazi;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VIES_Izvješća;
    }
}