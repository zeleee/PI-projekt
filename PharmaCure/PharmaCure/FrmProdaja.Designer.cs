﻿namespace PharmaCure
{
    partial class FrmProdaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdaja));
            this.btnSve = new System.Windows.Forms.Button();
            this.btnJedan = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbStanje = new System.Windows.Forms.ComboBox();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.btnRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.cmbLijek = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.lblRecepti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSve
            // 
            this.btnSve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSve.BackgroundImage")));
            this.btnSve.Location = new System.Drawing.Point(659, 288);
            this.btnSve.Margin = new System.Windows.Forms.Padding(2);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(35, 31);
            this.btnSve.TabIndex = 37;
            this.btnSve.Text = "<<";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnJedan
            // 
            this.btnJedan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJedan.BackgroundImage")));
            this.btnJedan.Location = new System.Drawing.Point(659, 240);
            this.btnJedan.Margin = new System.Windows.Forms.Padding(2);
            this.btnJedan.Name = "btnJedan";
            this.btnJedan.Size = new System.Drawing.Size(35, 31);
            this.btnJedan.TabIndex = 36;
            this.btnJedan.Text = "<";
            this.btnJedan.UseVisualStyleBackColor = true;
            this.btnJedan.Click += new System.EventHandler(this.btnJedan_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnObrisi.Location = new System.Drawing.Point(281, 494);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(63, 26);
            this.btnObrisi.TabIndex = 35;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(698, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Količlina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKolicina.Location = new System.Drawing.Point(700, 25);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(47, 23);
            this.txtKolicina.TabIndex = 33;
            // 
            // cmbStanje
            // 
            this.cmbStanje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStanje.FormattingEnabled = true;
            this.cmbStanje.Location = new System.Drawing.Point(14, 497);
            this.cmbStanje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStanje.Name = "cmbStanje";
            this.cmbStanje.Size = new System.Drawing.Size(109, 25);
            this.cmbStanje.TabIndex = 32;
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(700, 80);
            this.dgvRecepti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowTemplate.Height = 24;
            this.dgvRecepti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepti.Size = new System.Drawing.Size(441, 407);
            this.dgvRecepti.TabIndex = 31;
            // 
            // btnRacun
            // 
            this.btnRacun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRacun.BackgroundImage")));
            this.btnRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRacun.Location = new System.Drawing.Point(140, 494);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(126, 27);
            this.btnRacun.TabIndex = 30;
            this.btnRacun.Text = "Dodaj Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(959, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(1046, 494);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(95, 20);
            this.txtCijena.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(116, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Korisnik ID:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKorisnik.Location = new System.Drawing.Point(119, 25);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(125, 23);
            this.txtKorisnik.TabIndex = 25;
            this.txtKorisnik.TextChanged += new System.EventHandler(this.txtKorisnik_TextChanged);
            // 
            // cmbLijek
            // 
            this.cmbLijek.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbLijek.FormattingEnabled = true;
            this.cmbLijek.Location = new System.Drawing.Point(787, 23);
            this.cmbLijek.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLijek.Name = "cmbLijek";
            this.cmbLijek.Size = new System.Drawing.Size(158, 25);
            this.cmbLijek.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(784, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lijek:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.Location = new System.Drawing.Point(1066, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Prodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodaj.Location = new System.Drawing.Point(962, 23);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(14, 80);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(640, 407);
            this.dgvArtikli.TabIndex = 21;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPovratak.Location = new System.Drawing.Point(14, 23);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 20;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click_1);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.BackColor = System.Drawing.Color.Transparent;
            this.lblArtikli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblArtikli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArtikli.Location = new System.Drawing.Point(11, 59);
            this.lblArtikli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(46, 17);
            this.lblArtikli.TabIndex = 38;
            this.lblArtikli.Text = "Artikli:";
            // 
            // lblRecepti
            // 
            this.lblRecepti.AutoSize = true;
            this.lblRecepti.BackColor = System.Drawing.Color.Transparent;
            this.lblRecepti.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblRecepti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecepti.Location = new System.Drawing.Point(702, 59);
            this.lblRecepti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecepti.Name = "lblRecepti";
            this.lblRecepti.Size = new System.Drawing.Size(61, 17);
            this.lblRecepti.TabIndex = 39;
            this.lblRecepti.Text = "Recepti:";
            // 
            // FrmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1153, 530);
            this.Controls.Add(this.lblRecepti);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.btnJedan);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbStanje);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.cmbLijek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdaja";
            this.Text = "FrmProdaja";
            this.Load += new System.EventHandler(this.FrmProdaja_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdaja_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnJedan;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbStanje;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.ComboBox cmbLijek;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label lblArtikli;
        private System.Windows.Forms.Label lblRecepti;
    }
}