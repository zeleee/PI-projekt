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
    public partial class FrmRezervacijaLijek : Form
    {
        public int IDRezervacija { get; set; }
        public int IDLijek { get; set; }
        public string NazivLijeka { get; set; }
        public int Kolicina { get; set; }
        public int NacinRada { get; set; }
        public FrmRezervacijaLijek()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        /// <summary>
        /// Ukoliko je odabran određen lijek u prijašnjoj formi tada se popunjavaju podaci prema tom lijeku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRezervacijaLijek_Load(object sender, EventArgs e)
        {
            lijekoviTableAdapter.Fill(_17003_DBDataSet.Lijekovi);
            if (NacinRada == 1)
            {
                comboBoxNaziv.Text = NazivLijeka;
                textBoxKolicina.Text = Kolicina.ToString();
            }
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmRezervacija frmRezervacija = new FrmRezervacija();
            frmRezervacija.Show();
            this.Close();
        }
        /// <summary>
        /// Metoda za unos novog lijeka u određenu rezervaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool pogreska = false;
            IDLijek = int.Parse(comboBoxNaziv.SelectedValue.ToString());
            try
            {
                Kolicina = int.Parse(textBoxKolicina.Text);
            }
            catch (FormatException)
            {
                pogreska = true;
                MessageBox.Show("Provjerite da li je količina unešena te da li je unešena brojka!");
            }
            if (!pogreska)
            {
                try
                {
                    popisTableAdapter.InsertQuery(IDLijek, IDRezervacija, Kolicina);
                    FrmRezervacija frmRezervacija = new FrmRezervacija();
                    frmRezervacija.IDRezervacija = IDRezervacija;
                    frmRezervacija.NacinRada = 1;
                    frmRezervacija.Show();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    pogreska = true;
                    MessageBox.Show("Već se odabrali traženi lijek!");
                }
            }
            if (!pogreska)
            {
                this.Close();
            }
        }
        public void UnesiLijek(int IDLijek, int IDRezervacija, int Kolicina)
        {
            popisTableAdapter.InsertQuery(IDLijek, IDRezervacija, Kolicina);
        }

        private void FrmRezervacijaLijek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r17003/wiki/Korisnička-dokumentacija#2114-odabir-lijeka");
            }
        }
    }
}

