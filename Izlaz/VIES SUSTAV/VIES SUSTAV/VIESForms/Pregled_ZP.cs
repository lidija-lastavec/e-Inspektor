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
    public partial class frm_pregledZP : Form
    {
        string passedInText;
        int passedInText2;
        string passedInText3;
        int spremanje = 0;
        int brojUnosaInic;

        public frm_pregledZP(string OIB, int IDizvjesca, string razdoblje)
        {
            InitializeComponent();
            this.passedInText = OIB;
            this.passedInText2 = IDizvjesca;
            this.passedInText3 = razdoblje;
        }

        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            int brojUnosa = this.tbl_ZPDataGridView.Rows.Count;

            if (brojUnosa == brojUnosaInic)
            {
                this.Close();
            }

            if (brojUnosa > brojUnosaInic & spremanje == 0)
            {
                if (MessageBox.Show("Imate ne spremljene podatke! Želite li ipak zatvoriti unos?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }

            if (spremanje == 1)
            {
                this.Close();
            }
        }

        private void frm_pregledZP_Load(object sender, EventArgs e)
        {
           
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
           
            this.tbl_ZPTableAdapter.FillByViesID(this.ds_ZP.tbl_ZP,passedInText2);
            int brojUnosaInic = this.tbl_ZPDataGridView.Rows.Count;

            this.txt_razdoblje.Text = passedInText3;
            this.tbl_ObveznikLookUpTableAdapter.FillByOIB(this.ds_T27.tbl_ObveznikLookUp,passedInText);

        }

       
           
     

        private void tbl_ZPDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Završen unos?");        
        }

        private void tbl_PdvSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int brojUnosa = this.tbl_ZPDataGridView.Rows.Count;

            if (brojUnosa == 1)
            {
                if (MessageBox.Show("Želite spremiti prazni obrazac?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                  System.Windows.Forms.DialogResult.Yes)
                {
                    this.Validate();
                    this.tbl_ZPBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.ds_ZP);

                    MessageBox.Show("Podaci su uspješno spremljeni!");
                    spremanje = 1;
                }
            }

            if (brojUnosa > 1)
            {
                try
                { 
                   
                    if (MessageBox.Show("Želite li stvarno spremiti podatke?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Validate();
                        this.tbl_ZPBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.ds_ZP);

                        MessageBox.Show("Podaci su uspješno spremljeni!");
                        spremanje = 1;
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                        
                MessageBox.Show("Navedenu izmjenu je potrebno SPREMITI!");
          
        }

        private void tbl_ZPDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    this.tbl_ZPDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = passedInText2;
                }
            }

            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        private void tbl_ZPDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow startingBalanceRow = tbl_ZPDataGridView.Rows[0];


            if (tbl_ZPDataGridView.SelectedRows.Contains(startingBalanceRow))
            {

                MessageBox.Show("Inicijalni red se ne može brisati!");

                e.Cancel = true;
            }
        }


    }
}
