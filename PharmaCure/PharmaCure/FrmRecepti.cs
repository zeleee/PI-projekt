﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace PharmaCure
{
    public partial class FrmRecepti : Form
    {
        public List<LijekRecept> lr = new List<LijekRecept>();
        public List<Lijek> ll = new List<Lijek>();
        public List<Osiguranje> lo = new List<Osiguranje>();
        public FrmRecepti()
        {
            InitializeComponent();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmOsiguranjeLijek o = new FrmOsiguranjeLijek();
            o.Show();
            this.Close();
        }
        private void OsvjeziListu()
        {
            
            lr = LijekRecept.DohvatiRecepte(int.Parse(txtIDKlijent.Text));
            dgvLijekoviRecept.DataSource = lr;
            ll = Lijek.DohvatiSveLijekove();
            dgvLijekoviPravo.DataSource = ll;
        }

        private void txtIDLijek_TextChanged(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void dgvLijekoviPravo_SelectionChanged(object sender, EventArgs e)
        {
            lo = Osiguranje.DohvatiOsiguranja();
            cmbOsiguranje.DisplayMember = "naziv";
            cmbOsiguranje.ValueMember = "participacija";
            cmbOsiguranje.DataSource = lo;
        }

        private void btnPropisi_Click(object sender, EventArgs e)
        {
            LijekRecept lijeR = new LijekRecept();
            lijeR.IDLijek = int.Parse(dgvLijekoviPravo.CurrentRow.Cells[0].Value.ToString());
            lijeR.Naziv = dgvLijekoviPravo.CurrentRow.Cells[1].Value.ToString();
            lijeR.KlijentID = int.Parse(txtIDKlijent.Text);
            lijeR.Kolicina = int.Parse(txtKolicina.Text);
            lijeR.Participacija = int.Parse(cmbOsiguranje.SelectedValue.ToString());
            lijeR.DodajRecept();
            OsvjeziListu();
        }

        private void lblArtikli_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLijekoviPravo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
