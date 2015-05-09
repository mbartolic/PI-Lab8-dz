using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void OsvjeziTimove()
        {
            List<Tim> listaTimova = Tim.DohvatiTimove();
            dgvTimovi.DataSource = listaTimova;
        }

        private void OsvjeziStudente()
        {
            List<Student> listaStudent = Student.DohvatiStudente();
            dataGridView1.DataSource = listaStudent;
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            OsvjeziTimove();
            OsvjeziStudente();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            NoviTim frmNoviTim = new NoviTim();
            frmNoviTim.ShowDialog();
            OsvjeziTimove();
        }

        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                NoviTim frmNoviTim = new NoviTim(odabraniTim);
                frmNoviTim.ShowDialog();
                OsvjeziTimove();
            }
        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTimovi.SelectedRows)
                {
                    Tim odabraniTim = row.DataBoundItem as Tim;
                    odabraniTim.MetodaBrisi();
                }
            }
            OsvjeziTimove();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            NoviStudent frmNoviStudent = new NoviStudent();
            frmNoviStudent.ShowDialog();
            OsvjeziStudente();
        }

        private void btnIzmijeniStudenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Student odabraniStudent = dataGridView1.SelectedRows[0].DataBoundItem as Student;
                NoviStudent frmNoviStudent = new NoviStudent(odabraniStudent);
                frmNoviStudent.ShowDialog();
                OsvjeziStudente();
            }
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Student odabraniStudent = row.DataBoundItem as Student;
                    odabraniStudent.MetodaBrisi();
                }
            }
            OsvjeziStudente();
        }
    }
}
