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
    public partial class FrmRezervacijaPopis : Form
    {
        public int IDRezervacija { get; set; }
        public FrmRezervacijaPopis()
        {
            InitializeComponent();
        }
        private void FrmPopisRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }
        private void OsvjeziPrikaz()
        {
            this.pregledRezervacijaTableAdapter.SelectByStanje(this._17003_DBDataSet.PregledRezervacija);
            pregledRezervacijaDataGridView.Columns[3].Visible = false;
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            rezervacijaTableAdapter.InsertNovaRezervacija(DateTime.Now, true);
            FrmRezervacija frmRezervacijaNova = new FrmRezervacija();
            frmRezervacijaNova.Show();
            this.Close();
        }
        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            IDRezervacija =int.Parse(pregledRezervacijaDataGridView.CurrentRow.Cells[0].Value.ToString());
            bool stanje = bool.Parse(pregledRezervacijaDataGridView.CurrentRow.Cells[3].Value.ToString());
            bool stanjeUnos = true; 
            if (stanje)
            {
                stanjeUnos = false;
            }
            this.rezervacijaTableAdapter.UpdateStanje(stanjeUnos, IDRezervacija, IDRezervacija);
            OsvjeziPrikaz();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            bool pogreska = false;
            try
            {
              
                IDRezervacija = int.Parse(txtBoxPretrazi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Upisana vrijednost mora biti broj!");
                pogreska = true;
            }
            if (pogreska)
            {
                pregledRezervacijaTableAdapter.SelectByStanje(this._17003_DBDataSet.PregledRezervacija);
            }
            else
            {
                pregledRezervacijaTableAdapter.FillByIDRezervacije(this._17003_DBDataSet.PregledRezervacija, IDRezervacija);
                pregledRezervacijaDataGridView.Columns[3].Visible = true;
            }
        }
    }
}
