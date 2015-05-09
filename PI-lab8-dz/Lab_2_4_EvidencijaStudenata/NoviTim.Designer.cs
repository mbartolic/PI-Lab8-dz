namespace Lab_2_4_EvidencijaStudenata
{
    partial class NoviTim
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtOpisProjekta = new System.Windows.Forms.TextBox();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblOpisProjekta = new System.Windows.Forms.Label();
            this.lblNazivProjekta = new System.Windows.Forms.Label();
            this.lblOznakaTima = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(263, 315);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 28);
            this.btnSpremi.TabIndex = 23;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(344, 315);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 28);
            this.btnOdustani.TabIndex = 22;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(115, 192);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(304, 117);
            this.txtNapomena.TabIndex = 21;
            // 
            // txtOpisProjekta
            // 
            this.txtOpisProjekta.Location = new System.Drawing.Point(115, 91);
            this.txtOpisProjekta.Multiline = true;
            this.txtOpisProjekta.Name = "txtOpisProjekta";
            this.txtOpisProjekta.Size = new System.Drawing.Size(304, 95);
            this.txtOpisProjekta.TabIndex = 20;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(115, 65);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(304, 20);
            this.txtNazivProjekta.TabIndex = 19;
            // 
            // txtOznakaTima
            // 
            this.txtOznakaTima.Location = new System.Drawing.Point(115, 39);
            this.txtOznakaTima.Name = "txtOznakaTima";
            this.txtOznakaTima.Size = new System.Drawing.Size(304, 20);
            this.txtOznakaTima.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(93, 20);
            this.txtId.TabIndex = 17;
            this.txtId.TabStop = false;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(19, 195);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 16;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblOpisProjekta
            // 
            this.lblOpisProjekta.AutoSize = true;
            this.lblOpisProjekta.Location = new System.Drawing.Point(19, 94);
            this.lblOpisProjekta.Name = "lblOpisProjekta";
            this.lblOpisProjekta.Size = new System.Drawing.Size(72, 13);
            this.lblOpisProjekta.TabIndex = 15;
            this.lblOpisProjekta.Text = "Opis projekta:";
            // 
            // lblNazivProjekta
            // 
            this.lblNazivProjekta.AutoSize = true;
            this.lblNazivProjekta.Location = new System.Drawing.Point(19, 68);
            this.lblNazivProjekta.Name = "lblNazivProjekta";
            this.lblNazivProjekta.Size = new System.Drawing.Size(78, 13);
            this.lblNazivProjekta.TabIndex = 14;
            this.lblNazivProjekta.Text = "Naziv projekta:";
            // 
            // lblOznakaTima
            // 
            this.lblOznakaTima.AutoSize = true;
            this.lblOznakaTima.Location = new System.Drawing.Point(19, 42);
            this.lblOznakaTima.Name = "lblOznakaTima";
            this.lblOznakaTima.Size = new System.Drawing.Size(69, 13);
            this.lblOznakaTima.TabIndex = 13;
            this.lblOznakaTima.Text = "Oznaka tima:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id:";
            // 
            // NoviTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 366);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtOpisProjekta);
            this.Controls.Add(this.txtNazivProjekta);
            this.Controls.Add(this.txtOznakaTima);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblOpisProjekta);
            this.Controls.Add(this.lblNazivProjekta);
            this.Controls.Add(this.lblOznakaTima);
            this.Controls.Add(this.lblId);
            this.Name = "NoviTim";
            this.Text = "Unos podataka o novom ili postojećem timu";
            this.Load += new System.EventHandler(this.NoviTim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtOpisProjekta;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblOpisProjekta;
        private System.Windows.Forms.Label lblNazivProjekta;
        private System.Windows.Forms.Label lblOznakaTima;
        private System.Windows.Forms.Label lblId;
    }
}