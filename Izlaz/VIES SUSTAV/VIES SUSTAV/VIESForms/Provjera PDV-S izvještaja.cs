using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.VIESForms
{
    public partial class frm_ProvjeraPDV_S : Form
    {
        string passedInText;
        int passedInText2;
        string passedInText3;
        int passedInText4;

        public frm_ProvjeraPDV_S(string OIB, int IDizvjesca, string razdoblje, int vrijednostStjecanja)
        {
            InitializeComponent();
            this.passedInText = OIB;
            this.passedInText2 = IDizvjesca;
            this.passedInText3 = razdoblje;
            this.passedInText4 = vrijednostStjecanja;
        }

        private void frm_ProvjeraPDV_S_Load(object sender, EventArgs e)
        {
            
            this.tbl_sifarnikZemljaTableAdapter.Fill(this.ds_sifarnici_lookUp.tbl_sifarnikZemlja);
            
            this.tbl_PdvSTableAdapter.FillByViesID(this.ds_PdvS.tbl_PdvS,passedInText2);
            
            this.tbl_ObveznikLookUpTableAdapter.FillByOIB(this.ds_T27.tbl_ObveznikLookUp,passedInText);

            this.txt_IDizvjesca.Text = passedInText2.ToString();
            this.txt_razdoblje.Text = passedInText3;

        }

      
        private void btn_provjeri_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < this.tbl_PdvSDataGridView.Rows.Count - 1; i++)
                {
                    sum += Convert.ToInt32(tbl_PdvSDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn5"].Value);
                }

                this.txt_ukupnoPdvS.Text = sum.ToString();
                this.txt_ViesStjecanje.Text = passedInText4.ToString();

                int razlika = sum - passedInText4;

                this.txt_razlikaPdvS.Text = razlika.ToString();

                if (razlika != 0)
                {
                    this.pbox_PdvSKrivo.Visible = true;
                    this.lbl_PdvsKrivo.Visible = true;
                }

                else
                {
                    this.pbox_PdvsOK.Visible = true;
                    this.lbl_PdvSOK.Visible = true;
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
    }
}
