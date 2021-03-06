﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCure
{
    public partial class FrmRezervacijaKlijent : Form
    {
        public int IDRezervacija { get; set; }
        public FrmRezervacijaKlijent()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void FrmRezervacijaKlijent_Load(object sender, EventArgs e)
        {
            this.rezervacijaTableAdapter.Fill(this._17003_DBDataSet.Rezervacija);
            this.pregledKlijenataTableAdapter.Fill(this._17003_DBDataSet.PregledKlijenata);
            this.klijentTableAdapter.Fill(this._17003_DBDataSet.Klijent);
            comboBoxPretraga.SelectedIndex = 0;
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacijaPopis frmRezervacijaPopis = new FrmRezervacijaPopis();
            frmRezervacijaPopis.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metoda koja služi za pretragu prema ID-u ili nazivu klijenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (comboBoxPretraga.SelectedIndex == 0)
            {
                this.pregledKlijenataTableAdapter.SelectById(this._17003_DBDataSet.PregledKlijenata, int.Parse(txtBoxPretrazi.Text));
            }
            else
            {
                this.pregledKlijenataTableAdapter.SelectByImePrezime(this._17003_DBDataSet.PregledKlijenata, txtBoxPretrazi.Text);
            }
        }
        /// <summary>
        /// Metoda za spremanje promjena te dodavanja klijenta za određenu rezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            int idKlijent= int.Parse(pregledKlijenataDataGridView.CurrentRow.Cells[0].Value.ToString());
            rezervacijaTableAdapter.DodajKlijenta(idKlijent,IDRezervacija);
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.IDRezervacija = IDRezervacija;
            frmRezervacija.ImePrezimeKlijenta= pregledKlijenataDataGridView.CurrentRow.Cells[1].Value.ToString();
            frmRezervacija.NacinRada = 1;
            frmRezervacija.Show();
            this.Close();
        }

        private void FrmRezervacijaKlijent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#2113-odabir-klijenta");
            }
        }
    }
}
