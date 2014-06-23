using System;
using System.Windows.Forms;

namespace VIES_SUSTAV.PretrazivanjeIkontrolaVIES
{
    public partial class frm_pretrazivanjeVIES : Form
    {
        string passedInID;
        string passedInKorisnik;

        public frm_pretrazivanjeVIES(string ID, string korisnik)
        {
            InitializeComponent();
            this.passedInID = ID;
            this.passedInKorisnik = korisnik;
        }
    
        private void frm_pretrazivanjeVIES_Load(object sender, EventArgs e)
        {
            if (passedInKorisnik=="Porezni obveznik")
            {
                this.txt_oib.Text=passedInID.ToString();
                this.cbox_OIB.Visible=false;
                this.rbtn_oib.Visible=true;
                this.panel2.Visible=true;
            }
            else
            {
            this.tbl_ObveznikLookUpTableAdapter.FillObveznik(this.ds_T27.tbl_ObveznikLookUp);
            }

            this.tbt_sifarnikStatusaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbt_sifarnikStatusa);

        }

        private void btm_Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbox_OIB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txt_oib.Text = cbox_OIB.SelectedValue.ToString();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_oib_TextChanged(object sender, EventArgs e)
        {
            this.rbtn_oib.Checked = true;
        }

        private void txt_RazdobljedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.rbtn_razdoblje.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rbtn_status.Checked = true;

            int index = this.cbox_status.SelectedIndex;
            index += 1;

            this.txt_status.Text = index.ToString();
        }

        int IndexPretraživanja = 0;

        private void btn_pocisti_Click(object sender, EventArgs e)
        {
            IndexPretraživanja = 0;   

            this.tbl_pretrazivanjeVIESBindingSource.DataSource = null;
            this.tbl_pretrazivanjeVIESDataGridView.Refresh();

            if (passedInKorisnik == "Porezni obveznik")
            {
                IndexPretraživanja = 1;
                this.txt_oib.Text = passedInID.ToString();
                this.rbtn_oib.Checked = true;
                this.rbtn_razdoblje.Checked = false;
                this.rbtn_status.Checked = false;
            }
            else
            {
                IndexPretraživanja = 0;
                this.txt_oib.Clear();
                this.rbtn_oib.Checked = false;
                this.rbtn_razdoblje.Checked = false;
                this.rbtn_status.Checked = false;
            }

            IndexPretraživanja = 0;

            this.tbl_pretrazivanjeVIESBindingSource.DataSource = null;
            this.tbl_pretrazivanjeVIESDataGridView.Refresh();

            if (passedInKorisnik == "Porezni obveznik")
            {
                IndexPretraživanja = 1;
                this.txt_oib.Text = passedInID.ToString();
                this.rbtn_oib.Checked = true;
                this.rbtn_razdoblje.Checked = false;
                this.rbtn_status.Checked = false;
            }
            else
            {
                IndexPretraživanja = 0;
                this.txt_oib.Clear();
                this.rbtn_oib.Checked = false;
                this.rbtn_razdoblje.Checked = false;
                this.rbtn_status.Checked = false;
            }
                
        }

      


        private void rbtn_oib_CheckedChanged(object sender, EventArgs e)
        {
            IndexPretraživanja += 1;
        }

        private void rbtn_razdoblje_CheckedChanged(object sender, EventArgs e)
        {
            IndexPretraživanja += 6;
        }

        private void rbtn_status_CheckedChanged(object sender, EventArgs e)
        {
            IndexPretraživanja += 4;
        }

        //pretraživanje izvještaja
        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
                       
            if (IndexPretraživanja == 0)
            {
                MessageBox.Show("Unesite kriterije pretraživanja.");
            }

            if (IndexPretraživanja == 1)
            {
                try
                {

                    string oib = this.txt_oib.Text.ToString();

                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByOIB(this.ds_ViesUnos.tbl_pretrazivanjeVIES, oib);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (IndexPretraživanja == 5)
            {
                try
                {

                    string oib = this.txt_oib.Text.ToString();
                    string status = this.txt_status.Text.ToString();

                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByOibStatus(this.ds_ViesUnos.tbl_pretrazivanjeVIES, oib, status);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (IndexPretraživanja == 7)
            {
                try
                {

                    string oib = this.txt_oib.Text.ToString();

                    string razdoblje = this.txt_RazdobljedateTimePicker.Text.ToString();
                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByOibRazdoblje(this.ds_ViesUnos.tbl_pretrazivanjeVIES, oib, razdoblje);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (IndexPretraživanja == 6)
            {

                try
                {

                    string razdoblje = this.txt_RazdobljedateTimePicker.Text.ToString();
                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByRazdoblje(this.ds_ViesUnos.tbl_pretrazivanjeVIES, razdoblje);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (IndexPretraživanja == 4)
            {

                try
                {
                    string status = this.txt_status.Text.ToString();
                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByStatus(this.ds_ViesUnos.tbl_pretrazivanjeVIES, status);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (IndexPretraživanja == 10)
            {

                try
                {

                    string razdoblje = this.txt_RazdobljedateTimePicker.Text.ToString();
                    string status = this.txt_status.Text.ToString();

                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillByRazdobStatus(this.ds_ViesUnos.tbl_pretrazivanjeVIES, razdoblje, status);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }

            if (IndexPretraživanja == 11)
            {

                try
                {
                    string oib = txt_oib.Text.ToString();
                    string razdoblje = this.txt_RazdobljedateTimePicker.Text.ToString();
                    string status = this.txt_status.Text.ToString();

                    this.tbl_pretrazivanjeVIESBindingSource.DataSource = this.ds_ViesUnos.tbl_pretrazivanjeVIES;
                    this.tbl_pretrazivanjeVIESTableAdapter.FillBySviKriteriji(this.ds_ViesUnos.tbl_pretrazivanjeVIES, oib,razdoblje, status);

                    int brojRedova = int.Parse(tbl_pretrazivanjeVIESDataGridView.RowCount.ToString());

                    if (brojRedova < 1)
                    {
                        MessageBox.Show("Nema izvještaja prema zadanom kriteriju.");

                    }

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

           
        }
    
        private void tbl_pretrazivanjeVIESDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    string evidencijski = tbl_pretrazivanjeVIESDataGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    int IDeviden = int.Parse(evidencijski);
                    frm_pregleVIES noviPregled = new frm_pregleVIES(IDeviden,passedInKorisnik);
                    noviPregled.Show();
                }
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
            }
        }
    }

}