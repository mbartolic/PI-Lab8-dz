using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class NoviStudent : Form
    {
        List<Tim> timovi;
        public NoviStudent()
        {
            InitializeComponent();
            timovi = new List<Tim>();
            timovi = Tim.DohvatiTimove();
            foreach (Tim t in timovi)
            cmbTim.Items.Add(t);
        }

        private Student student = null;

        public NoviStudent(Student odabraniTim)
        {
            InitializeComponent();
            student = odabraniTim;
        }

        private void NoviStudent_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
            if (student != null)
            {
                txtId.Text = student.Id.ToString();
                txtIme.Text = student.Ime;
                txtPrezime.Text = student.Prezime;
                txtEmail.Text = student.Email;
                txtNapomena.Text = student.Napomena;
                if (rbtnModelA.Checked)
                    student.OdabraniModel = 'A';
                if (rbtnModelB.Checked)
                    student.OdabraniModel = 'B';
                if (rbtnRedoviti.Checked)
                    student.Status = 'R';
                if (rbtnIzvanredni.Checked)
                    student.Status = 'I';
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                student = new Student();
            }
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.Email = txtEmail.Text;
            student.Napomena = txtNapomena.Text;
            if (rbtnModelA.Checked)
                student.OdabraniModel = 'A';
            if (rbtnModelB.Checked)
                student.OdabraniModel = 'B';
            if (rbtnRedoviti.Checked)
                student.Status = 'R';
            if (rbtnIzvanredni.Checked)
                student.Status = 'I';
            student.Tim = (Tim)cmbTim.SelectedItem;
            student.MetodaSpremi();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
