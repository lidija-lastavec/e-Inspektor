using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.PretrazivanjeIkontrolaVIES
{
    public partial class frm_pregleVIES : Form
    {
        int passedINevidencijski;
        string passedInKorisnik;

        public frm_pregleVIES(int evidencijski, string korisnik)
        {
            InitializeComponent();
            this.passedINevidencijski = evidencijski;
            this.passedInKorisnik = korisnik;
        }

        private void frm_pregleVIES_Load(object sender, EventArgs e)
        {
            
            this.tbt_sifarnikStatusaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbt_sifarnikStatusa);
            this.tbl_VIESizvjestajTableAdapter.FillByIDizvješća(this.ds_ViesUnos.tbl_VIESizvjestaj, passedINevidencijski);
            string OIB = this.txt_OIB.Text.ToString();
            this.tbl_ObveznikLookUpTableAdapter.FillByOIB(this.ds_T27.tbl_ObveznikLookUp,OIB);

           
         
        }

        private void tbl_VIESizvjestajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_VIESizvjestajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_ViesUnos);

        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ažuriraj_Click(object sender, EventArgs e)
        {
            if (passedInKorisnik == "Porezni obveznik")
            {
                this.txt_stjecanje.Enabled = true;
                this.txt_isporuke.Enabled = true;
                this.btn_spremi.Visible = true;
                this.btn_ažuriraj.Visible = false;
                this.txt_stjecanje.Focus();
                this.txt_datumUnosa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Izvještaj može ažurirati samo porezni obveznik.");

            }

        }

        private void btn_spremi_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Želite li spremiti podatke za ovog poreznog obveznika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    this.Validate();
                    this.tbl_VIESizvjestajBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.ds_ViesUnos);


                    MessageBox.Show("Podaci su uspješno spremljeni");

                    this.lbl_Vies_ažuriranje.Visible = true;
                    this.pbox_PdvsEdit.Visible = true;
                    this.pbox_zpEdit.Visible = true;
                    this.pbox_zpProvjeri.Visible = true;
                    this.pbox_PdvsProvjeri.Visible = true;
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void pbox_PdvsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
               
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                VIESForms.frm_PregledPdvS noviPregledPdvS = new VIESForms.frm_PregledPdvS(OIB, passedINevidencijski, razdoblje);
                noviPregledPdvS.Show();

                this.pbx_pdvsDodan.Visible = true;
                this.lbl_pdvsDodan.Visible = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_zpEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
              
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                VIESForms.frm_pregledZP noviPregledZP = new VIESForms.frm_pregledZP(OIB, passedINevidencijski, razdoblje);
                noviPregledZP.Show();
                this.pbx_pdvsDodan.Visible = true;
                this.lbl_ZPdodan.Visible = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_PdvsProvjeri_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
               
                string razdoblje = txt_RazdobljedateTimePicker.Text;
                int vrijednostStjecanja = int.Parse(txt_stjecanje.Text.ToString());

                VIESForms.frm_ProvjeraPDV_S novaProvjeraPdvS = new VIESForms.frm_ProvjeraPDV_S(OIB, passedINevidencijski, razdoblje, vrijednostStjecanja);
                novaProvjeraPdvS.Show();

                this.pbox_provjera.Visible = true;
                this.lbl_provjeraPdvS.Visible = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_zpProvjeri_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
               
                string razdoblje = txt_RazdobljedateTimePicker.Text;
                int vrijednostIsporuka = int.Parse(txt_isporuke.Text.ToString());

                VIESForms.frm_provjeraZP novaProvjeraZP = new VIESForms.frm_provjeraZP(OIB, passedINevidencijski, razdoblje, vrijednostIsporuka);
                novaProvjeraZP.Show();

                this.pbox_provjera.Visible = true;
                this.lbl_provjerenZP.Visible = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
