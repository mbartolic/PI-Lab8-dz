using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class NoviTim : Form
    {
        private Tim tim = null;
        public NoviTim()
        {
            InitializeComponent();
        }

        public NoviTim(Tim odabraniTim)
        {
            InitializeComponent();
            tim = odabraniTim;
        }

        private void NoviTim_Load(object sender, EventArgs e)
        {
            txtOznakaTima.Focus();
            if (tim != null)
            {
                txtId.Text = tim.Id.ToString();
                txtOznakaTima.Text = tim.OznakaTima;
                txtNazivProjekta.Text = tim.NazivProjekta;
                txtOpisProjekta.Text = tim.OpisProjekta;
                txtNapomena.Text = tim.Napomena;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (tim == null)
            {
                tim = new Tim();
            }
            tim.OznakaTima = txtOznakaTima.Text;
            tim.NazivProjekta = txtNazivProjekta.Text;
            tim.OpisProjekta = txtOpisProjekta.Text;
            tim.Napomena = txtNapomena.Text;
            tim.MetodaSpremi();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
