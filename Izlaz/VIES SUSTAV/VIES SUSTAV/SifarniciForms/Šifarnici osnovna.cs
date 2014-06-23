using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIES_SUSTAV.SifarniciForms
{
    public partial class frm_sifaniciOsnovna : Form
    {
        public frm_sifaniciOsnovna()
        {
            InitializeComponent();
        }

        private void btn_područni_Click(object sender, EventArgs e)
        {
            frm_sifarnikPodrucniUredi noviUred = new frm_sifarnikPodrucniUredi();
            noviUred.Show();
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       
        private void btn_ispostave_Click(object sender, EventArgs e)
        {
            frm_sifarnikIspostava novaIspostava = new frm_sifarnikIspostava();
            novaIspostava.Show();
        }

        private void btn_djelatnosti_Click(object sender, EventArgs e)
        {
            frm_sifarnikDjelatnosti novadjelatnost = new frm_sifarnikDjelatnosti();
            novadjelatnost.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_sifarnikZemalja novaZemlja = new frm_sifarnikZemalja();
            novaZemlja.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_sifarnikObveze novaObveza = new frm_sifarnikObveze();
            novaObveza.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_sifarnikVlasnistva novoVlasnistvo = new frm_sifarnikVlasnistva();
            novoVlasnistvo.Show();
        }
    }
}
