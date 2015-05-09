namespace Lab_2_4_EvidencijaStudenata
{
    partial class NoviStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTim = new System.Windows.Forms.Label();
            this.cmbTim = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbOdabraniModel = new System.Windows.Forms.GroupBox();
            this.rbtnModelB = new System.Windows.Forms.RadioButton();
            this.rbtnModelA = new System.Windows.Forms.RadioButton();
            this.gbStatusStudenta = new System.Windows.Forms.GroupBox();
            this.rbtnIzvanredni = new System.Windows.Forms.RadioButton();
            this.rbtnRedoviti = new System.Windows.Forms.RadioButton();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gbOdabraniModel.SuspendLayout();
            this.gbStatusStudenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(19, 168);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(27, 13);
            this.lblTim.TabIndex = 43;
            this.lblTim.Text = "Tim:";
            // 
            // cmbTim
            // 
            this.cmbTim.FormattingEnabled = true;
            this.cmbTim.Location = new System.Drawing.Point(115, 165);
            this.cmbTim.Name = "cmbTim";
            this.cmbTim.Size = new System.Drawing.Size(242, 21);
            this.cmbTim.TabIndex = 42;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(199, 297);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 28);
            this.btnSpremi.TabIndex = 41;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(280, 297);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 28);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(115, 218);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(242, 73);
            this.txtNapomena.TabIndex = 39;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(20, 221);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 38;
            this.lblNapomena.Text = "Napomena:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            // 
            // gbOdabraniModel
            // 
            this.gbOdabraniModel.Controls.Add(this.rbtnModelB);
            this.gbOdabraniModel.Controls.Add(this.rbtnModelA);
            this.gbOdabraniModel.Location = new System.Drawing.Point(249, 90);
            this.gbOdabraniModel.Name = "gbOdabraniModel";
            this.gbOdabraniModel.Size = new System.Drawing.Size(108, 69);
            this.gbOdabraniModel.TabIndex = 35;
            this.gbOdabraniModel.TabStop = false;
            this.gbOdabraniModel.Text = "Odabrani model";
            // 
            // rbtnModelB
            // 
            this.rbtnModelB.AutoSize = true;
            this.rbtnModelB.Location = new System.Drawing.Point(6, 42);
            this.rbtnModelB.Name = "rbtnModelB";
            this.rbtnModelB.Size = new System.Drawing.Size(64, 17);
            this.rbtnModelB.TabIndex = 1;
            this.rbtnModelB.Text = "Model B";
            this.rbtnModelB.UseVisualStyleBackColor = true;
            // 
            // rbtnModelA
            // 
            this.rbtnModelA.AutoSize = true;
            this.rbtnModelA.Checked = true;
            this.rbtnModelA.Location = new System.Drawing.Point(6, 17);
            this.rbtnModelA.Name = "rbtnModelA";
            this.rbtnModelA.Size = new System.Drawing.Size(64, 17);
            this.rbtnModelA.TabIndex = 0;
            this.rbtnModelA.TabStop = true;
            this.rbtnModelA.Text = "Model A";
            this.rbtnModelA.UseVisualStyleBackColor = true;
            // 
            // gbStatusStudenta
            // 
            this.gbStatusStudenta.Controls.Add(this.rbtnIzvanredni);
            this.gbStatusStudenta.Controls.Add(this.rbtnRedoviti);
            this.gbStatusStudenta.Location = new System.Drawing.Point(115, 90);
            this.gbStatusStudenta.Name = "gbStatusStudenta";
            this.gbStatusStudenta.Size = new System.Drawing.Size(128, 69);
            this.gbStatusStudenta.TabIndex = 34;
            this.gbStatusStudenta.TabStop = false;
            this.gbStatusStudenta.Text = "Status studenta";
            // 
            // rbtnIzvanredni
            // 
            this.rbtnIzvanredni.AutoSize = true;
            this.rbtnIzvanredni.Location = new System.Drawing.Point(6, 42);
            this.rbtnIzvanredni.Name = "rbtnIzvanredni";
            this.rbtnIzvanredni.Size = new System.Drawing.Size(112, 17);
            this.rbtnIzvanredni.TabIndex = 1;
            this.rbtnIzvanredni.Text = "Izvanredni student";
            this.rbtnIzvanredni.UseVisualStyleBackColor = true;
            // 
            // rbtnRedoviti
            // 
            this.rbtnRedoviti.AutoSize = true;
            this.rbtnRedoviti.Checked = true;
            this.rbtnRedoviti.Location = new System.Drawing.Point(6, 19);
            this.rbtnRedoviti.Name = "rbtnRedoviti";
            this.rbtnRedoviti.Size = new System.Drawing.Size(102, 17);
            this.rbtnRedoviti.TabIndex = 0;
            this.rbtnRedoviti.TabStop = true;
            this.rbtnRedoviti.Text = "Redoviti student";
            this.rbtnRedoviti.UseVisualStyleBackColor = true;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(115, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(242, 20);
            this.txtPrezime.TabIndex = 33;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(115, 38);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(242, 20);
            this.txtIme.TabIndex = 32;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(93, 20);
            this.txtId.TabIndex = 31;
            this.txtId.TabStop = false;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(19, 67);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 30;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(19, 41);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 29;
            this.lblIme.Text = "Ime:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "Id:";
            // 
            // NoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 339);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.cmbTim);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.gbOdabraniModel);
            this.Controls.Add(this.gbStatusStudenta);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblId);
            this.Name = "NoviStudent";
            this.Text = "Unos podataka o novom ili postojećem studentu";
            this.Load += new System.EventHandler(this.NoviStudent_Load);
            this.gbOdabraniModel.ResumeLayout(false);
            this.gbOdabraniModel.PerformLayout();
            this.gbStatusStudenta.ResumeLayout(false);
            this.gbStatusStudenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ComboBox cmbTim;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbOdabraniModel;
        private System.Windows.Forms.RadioButton rbtnModelB;
        private System.Windows.Forms.RadioButton rbtnModelA;
        private System.Windows.Forms.GroupBox gbStatusStudenta;
        private System.Windows.Forms.RadioButton rbtnIzvanredni;
        private System.Windows.Forms.RadioButton rbtnRedoviti;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblId;
    }
}