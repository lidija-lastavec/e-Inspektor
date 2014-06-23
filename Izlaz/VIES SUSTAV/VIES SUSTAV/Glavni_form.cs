using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV
{
    public partial class frm_GlavniForm : Form
    {
        string passedInID;
        string passedInKorisnik;

        public frm_GlavniForm(string ID, string korisnik)
        {
            InitializeComponent();
            this.passedInID = ID;
            this.passedInKorisnik = korisnik;
        }

        private void Glavni_form_Load(object sender, EventArgs e)
        {
                    

            if (passedInKorisnik == "Porezni obveznik")
            {
                pnl_porezniObveznik.Visible = true;
                try
                {
                   this.tbl_osnovnoporezniObveznikTableAdapter.FillOIB(this.ds_porezniObveznik.tbl_osnovnoporezniObveznik, passedInID);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
                if (passedInKorisnik == "Zaposlenik PU")
                {
                   

                    this.pnl_zaposlenik.Visible = true;
                    try
                    {
                        this.tbl_osnovnoZaposlenikTableAdapter.FillByID(this.ds_zaposlenik1.tbl_osnovnoZaposlenik, passedInID);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
               
            
        }

        private void btm_Izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void šifarniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifarniciForms.frm_sifaniciOsnovna noviSifarnici = new SifarniciForms.frm_sifaniciOsnovna();
            noviSifarnici.Show();
            this.lbl_sifarnici.Visible = true;
        }

        private void pregledObveznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (passedInKorisnik == "Zaposlenik PU")
            {
                string uloga = this.txt_uloga.Text.ToString();
            ViesForms.frn_registarVIES noviRegistar = new ViesForms.frn_registarVIES(uloga);
            noviRegistar.Show();
            this.lbl_obveznici.Visible = true;
            }
            else
            {
                MessageBox.Show ("Greška! Pregled registra omogućen je samo za zaposlenika PU.");

            }
        }

        private void unosNovogObveznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_uloga.Text == "Administrator PU    ")
            {
                ViesForms.frm_unosNovogObveznika noviObveznik = new ViesForms.frm_unosNovogObveznika();
                noviObveznik.Show();
                this.lbl_unosObveznika.Visible = true;
            }
            else 
            {
                MessageBox.Show("Greška! Unos novog obveznika omogućen je samo za administratora.");
            }
        }

        private void unosVIESIzvještajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (passedInKorisnik == "Porezni obveznik")
                {
                    VIESForms.frm_UnosVIES noviUnos = new VIESForms.frm_UnosVIES(passedInID);
                    noviUnos.Show();
                    this.lbl_izvjesta.Visible = true;
                }
                else
                {
                    MessageBox.Show("Greška! Unos Vies izvještaja omogućen je samo za porezne obveznike.");
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void registarVIESPodatakaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PretrazivanjeIkontrolaVIES.frm_pretrazivanjeVIES novoPretrazivanje = new PretrazivanjeIkontrolaVIES.frm_pretrazivanjeVIES(passedInID,passedInKorisnik);
            novoPretrazivanje.Show();
            this.lbl_regVIES.Visible = true;
        }

        

    }
}
