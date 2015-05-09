namespace Lab_2_4_EvidencijaStudenata
{
    partial class GlavnaForma
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
            this.lblTimovi = new System.Windows.Forms.Label();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnObrisiTim = new System.Windows.Forms.Button();
            this.btnIzmijeniTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzmijeniStudenta = new System.Windows.Forms.Button();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimovi
            // 
            this.lblTimovi.AutoSize = true;
            this.lblTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimovi.Location = new System.Drawing.Point(12, 9);
            this.lblTimovi.Name = "lblTimovi";
            this.lblTimovi.Size = new System.Drawing.Size(48, 13);
            this.lblTimovi.TabIndex = 0;
            this.lblTimovi.Text = "Timovi:";
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudenti.Location = new System.Drawing.Point(12, 207);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(58, 13);
            this.lblStudenti.TabIndex = 1;
            this.lblStudenti.Text = "Studenti:";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(15, 25);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(627, 140);
            this.dgvTimovi.TabIndex = 2;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Location = new System.Drawing.Point(561, 171);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(81, 34);
            this.btnDodajTim.TabIndex = 3;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Location = new System.Drawing.Point(387, 171);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(81, 34);
            this.btnObrisiTim.TabIndex = 4;
            this.btnObrisiTim.Text = "Obriši tim";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            this.btnObrisiTim.Click += new System.EventHandler(this.btnObrisiTim_Click);
            // 
            // btnIzmijeniTim
            // 
            this.btnIzmijeniTim.Location = new System.Drawing.Point(474, 171);
            this.btnIzmijeniTim.Name = "btnIzmijeniTim";
            this.btnIzmijeniTim.Size = new System.Drawing.Size(81, 34);
            this.btnIzmijeniTim.TabIndex = 5;
            this.btnIzmijeniTim.Text = "Izmijeni tim";
            this.btnIzmijeniTim.UseVisualStyleBackColor = true;
            this.btnIzmijeniTim.Click += new System.EventHandler(this.btnIzmijeniTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 140);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnIzmijeniStudenta
            // 
            this.btnIzmijeniStudenta.Location = new System.Drawing.Point(474, 369);
            this.btnIzmijeniStudenta.Name = "btnIzmijeniStudenta";
            this.btnIzmijeniStudenta.Size = new System.Drawing.Size(81, 34);
            this.btnIzmijeniStudenta.TabIndex = 9;
            this.btnIzmijeniStudenta.Text = "Izmijeni studenta";
            this.btnIzmijeniStudenta.UseVisualStyleBackColor = true;
            this.btnIzmijeniStudenta.Click += new System.EventHandler(this.btnIzmijeniStudenta_Click);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Location = new System.Drawing.Point(387, 369);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(81, 34);
            this.btnObrisiStudenta.TabIndex = 8;
            this.btnObrisiStudenta.Text = "Obriši studenta";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            this.btnObrisiStudenta.Click += new System.EventHandler(this.btnObrisiStudenta_Click);
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(561, 369);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(81, 34);
            this.btnDodajStudenta.TabIndex = 7;
            this.btnDodajStudenta.Text = "Dodaj studenta";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 415);
            this.Controls.Add(this.btnIzmijeniStudenta);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzmijeniTim);
            this.Controls.Add(this.btnObrisiTim);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.lblTimovi);
            this.Name = "GlavnaForma";
            this.Text = "Glavna forma aplikacije";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimovi;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnObrisiTim;
        private System.Windows.Forms.Button btnIzmijeniTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzmijeniStudenta;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnDodajStudenta;
    }
}

