﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.VIESForms
{
    public partial class frm_UnosVIES : Form
    {
        string passedInOib;

        public frm_UnosVIES(string OIB)
        {
            InitializeComponent();
            this.passedInOib = OIB;
        }

        private void frm_UnosVIES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_sifarnici_lookUp.tbt_sifarnikStatusa' table. You can move, or remove it, as needed.
            this.tbt_sifarnikStatusaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbt_sifarnikStatusa);
           
            this.getIDTableAdapter.Fill(this.ds_ViesUnos.GetID);
          
            this.tbl_VIESizvjestajTableAdapter1.Fill(this.ds_ViesUnos.tbl_VIESizvjestaj);
            this.tbt_sifarnikStatusaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbt_sifarnikStatusa);
            
            this.tbl_ObveznikLookUpTableAdapter.FillByOIB(this.ds_T27.tbl_ObveznikLookUp,passedInOib);
            
            this.tbl_VIESizvjestajTableAdapter.Fill(this.ds_T27.tbl_VIESizvjestaj);
          
           

        }

        private void tbl_VIESizvjestajBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_VIESizvjestajBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_T27);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                this.txt_spremanjeOIB.Text = this.txt_OIB.Text.ToString();
            }
            catch (SystemException except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void txt_stjecanje_Validating(object sender, CancelEventArgs e)
        {
            int num;

            bool isNum = int.TryParse(txt_stjecanje.Text.Trim(), out num);

            if (!isNum)
            {
                MessageBox.Show("Greška! Potrebno je unijeti cijelobrojnu vrijednost.");
            }
        }

        private void txt_isporuke_Validating(object sender, CancelEventArgs e)
        {
            int num;
            bool isNum = int.TryParse(txt_isporuke.Text.Trim(), out num);

            if (!isNum)
            {
                MessageBox.Show("Greška! Potrebno je unijeti cjelobrojnu vrijednost.");
            }
        }

        private void btn_spremi_Click(object sender, EventArgs e)
        {
            this.txt_status.Text =("1");

            try
            {

                if (MessageBox.Show("Želite li spremiti unjete podatke?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    var razdoblje = Convert.ToDateTime(this.txt_RazdobljedateTimePicker.Text.ToString());
                    int stjecanje = int.Parse(this.txt_stjecanje.Text.ToString());
                    int isporuke = int.Parse(this.txt_isporuke.Text.ToString());
                    var date = Convert.ToDateTime(this.txt_datumUnosa.Text.ToString());

                    this.tbl_VIESizvjestajTableAdapter.Insert(this.txt_OIB.Text.ToString(), razdoblje, stjecanje, isporuke, date, this.txt_status.Text.ToString());

                    MessageBox.Show("Podaci su uspješno spremljeni.");

                    int noviID = (int.Parse(ctxt_zadnjiID.Text.ToString()) + 1);
                    this.txt_ID1.Text = noviID.ToString();
                 }
            }
            catch (SystemException except)
            {
                MessageBox.Show(except.Message);
            }



        }

        private void pbox_addPdvS_Click(object sender, EventArgs e)
        {
            try
            {
                int IdVies = int.Parse(this.txt_ID1.Text.ToString());
                int prethodniId = int.Parse(this.ctxt_zadnjiID.Text.ToString());
                if (IdVies - prethodniId == 1)
                {
                    string OIB = txt_OIB.Text;
                    int IDizvjesca = int.Parse(txt_ID1.Text.ToString());;
                    string razdoblje = txt_RazdobljedateTimePicker.Text;

                    frm_unosPdvS noviIzvjestajPdvS = new frm_unosPdvS(OIB, IDizvjesca, razdoblje);
                    noviIzvjestajPdvS.Show();
                    this.pbox_PdvsOK.Visible = true;
                    this.pbox_PdvsEdit.Visible = true;
                    this.pbox_PdvsProvjeri.Visible = true;
                    this.pbox_addPdvS.Visible = false;
                    this.pbx_pdvsDodan.Visible = true;
                    this.lbl_pdvsDodan.Visible = true;
                }
                else
                {
                    MessageBox.Show("Spremite VIES izvješće prije nastavka.");
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_PdvsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
                int IDizvjesca = int.Parse(txt_ID1.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                frm_PregledPdvS noviPregledPdvS = new frm_PregledPdvS(OIB, IDizvjesca, razdoblje);
                noviPregledPdvS.Show();
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
                int IDizvjesca = int.Parse(txt_ID1.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;
                int vrijednostStjecanja = int.Parse(txt_stjecanje.Text.ToString());

                frm_ProvjeraPDV_S novaProvjeraPdvS = new frm_ProvjeraPDV_S (OIB, IDizvjesca, razdoblje,vrijednostStjecanja);
                novaProvjeraPdvS.Show();

                this.pbox_provjera.Visible = true;
                this.lbl_provjeraPdvS.Visible = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_addZP_Click(object sender, EventArgs e)
        {
            try
            {
                int IdVies = int.Parse(this.txt_ID1.Text.ToString());
                int prethodniId = int.Parse(this.ctxt_zadnjiID.Text.ToString());
                if (IdVies - prethodniId == 1)
                {
                    string OIB = txt_OIB.Text;
                    int IDizvjesca = int.Parse(txt_ID1.Text.ToString());
                    string razdoblje = txt_RazdobljedateTimePicker.Text;

                    frm_UnosZP noviIzvjestajZP = new frm_UnosZP(OIB, IDizvjesca, razdoblje);
                    noviIzvjestajZP.Show();
                    this.pbox_zpOK.Visible = true;
                    this.pbox_zpEdit.Visible = true;
                    this.pbox_zpProvjeri.Visible = true;
                    this.pbox_addZP.Visible = false;
                    this.pbx_pdvsDodan.Visible = true;
                    this.lbl_ZPdodan.Visible = true;
                }
                else
                {
                    MessageBox.Show("Spremite VIES izvješće prije nastavka.");
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbox_zpEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string OIB = txt_OIB.Text;
                int IDizvjesca = int.Parse(txt_ID1.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;

                frm_pregledZP noviPregledZP = new frm_pregledZP(OIB, IDizvjesca, razdoblje);
                noviPregledZP.Show();
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
                int IDizvjesca = int.Parse(txt_ID1.Text.ToString());
                string razdoblje = txt_RazdobljedateTimePicker.Text;
                int vrijednostIsporuka = int.Parse(txt_isporuke.Text.ToString());
           
                frm_provjeraZP novaProvjeraZP = new frm_provjeraZP(OIB, IDizvjesca, razdoblje, vrijednostIsporuka);
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
