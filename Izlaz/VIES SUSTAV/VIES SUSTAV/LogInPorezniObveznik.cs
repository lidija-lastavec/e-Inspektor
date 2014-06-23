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
    public partial class frm_LogInPorezniObveznik : Form
    {
        public frm_LogInPorezniObveznik()
        {
            InitializeComponent();
        }

       

        private void frm_LogInPorezniObveznik_Load(object sender, EventArgs e)
        {
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            string vrstaKorisnika = this.cbox_vrstaKorisnika.Text.ToString();

                if (string.IsNullOrEmpty(this.txt_korisnickoIme.Text))
            {
                MessageBox.Show("Greška! Upišite korisničko ime.");
                this.txt_korisnickoIme.Focus();
            }

            else 
                if (string.IsNullOrEmpty(this.txt_zaporka.Text))
            {
                MessageBox.Show("Greška! Upišite zaporku.");
                this.txt_zaporka.Focus();
            }

            else
                    if (vrstaKorisnika == "-odabir vrste korisnika-" || this.cbox_vrstaKorisnika.SelectedIndex==-1)
            {
                MessageBox.Show("Greška!Odaberite vrstu korisnika.");
                this.cbox_vrstaKorisnika.Focus();
            }

                string zaporka = this.txt_zaporka.Text.ToString();
                zaporka = zaporka.Trim();

                if (vrstaKorisnika == "Porezni obveznik")
                {
                    string provjeraZaporka = this.txt_bazaZaporka.Text.ToString();
                    provjeraZaporka = provjeraZaporka.Trim();

                    if (zaporka != provjeraZaporka)
                    {
                        MessageBox.Show("Greška!Pogrešna zaporka.");
                        this.txt_zaporka.Focus();
                    }
                    else
                    {
                        string Oib = this.txt_Oib.Text.ToString();
                        string korisnik = this.cbox_vrstaKorisnika.Text.ToString();

                        frm_GlavniForm noviGlavni = new frm_GlavniForm(Oib, korisnik);
                        this.Hide();
                        noviGlavni.Show();

                    }
                }

                if (vrstaKorisnika == "Zaposlenik PU")
                {
                    string provjeraZaporka = this.txt_zaposlenikZaporka.ToString();
                    provjeraZaporka = provjeraZaporka.Trim();

                    
                        string ID = this.txt_IDZaposlenika.Text.ToString();
                        string korisnik = this.cbox_vrstaKorisnika.Text.ToString();

                        frm_GlavniForm  noviGlavni= new frm_GlavniForm(ID, korisnik);
                        this.Hide();
                        noviGlavni.Show();

                 }
                



           
         
        }

        private void txt_korisnickoIme_Leave(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(this.txt_korisnickoIme.Text))

            {
                 MessageBox.Show("Greška! Upišite korisničko ime.");
                 this.txt_korisnickoIme.Focus();
            }
            
        }

        private void txt_zaporka_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_zaporka.Text))
            {
                MessageBox.Show("Greška! Upišite zaporku.");
                this.txt_zaporka.Focus();
            }
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pocisti_Click(object sender, EventArgs e)
        {
            this.txt_korisnickoIme.Clear();
            this.txt_zaporka.Clear();
            
        }

        private void cbox_vrstaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            string korisnickoIme = this.txt_korisnickoIme.Text.ToString();

            if (this.cbox_vrstaKorisnika.SelectedIndex == 0)
            {
                this.tbl_LogINporezniObveznikTableAdapter.FillbyKorisnickoime(this.ds_porezniObveznik.tbl_LogINporezniObveznik, korisnickoIme);

                string provjeraKorisnickoIme = this.txt_bazaKorisnicko.Text.ToString();

                if (korisnickoIme != provjeraKorisnickoIme)
                {
                    this.cbox_vrstaKorisnika.Text = "Odaberite korisnika!";
                    MessageBox.Show("Greška!Pogrešno korisničko ime.");
                    this.cbox_vrstaKorisnika.SelectedIndex = -1;

                    this.txt_korisnickoIme.Focus();
                }
            }

            if (this.cbox_vrstaKorisnika.SelectedIndex == 1)
            {
                this.tbl_LogInZaposlenikTableAdapter.FillByKorisnicko(this.ds_zaposlenik1.tbl_LogInZaposlenik, korisnickoIme);

                string provjeraKorisnickoIme = this.txt_ZaposlenikKorisnicko.Text.ToString();
                provjeraKorisnickoIme = provjeraKorisnickoIme.Trim();

                if (korisnickoIme != provjeraKorisnickoIme)
                {
                    this.cbox_vrstaKorisnika.Text = "Odaberite korisnika!";
                    MessageBox.Show("Greška!Pogrešno korisničko ime.");
                    this.cbox_vrstaKorisnika.SelectedIndex = -1;

                    this.txt_korisnickoIme.Focus();
                }
            }
        }
      
    }
}
