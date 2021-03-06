﻿namespace PharmaCure
{
    partial class FrmKolicine
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lijekovi_IDLabel;
            System.Windows.Forms.Label poslovnica_IDLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKolicine));
            this.PregledLijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17003_DBDataSet = new PharmaCure._17003_DBDataSet();
            this.dostupnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnicaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PoslovnicaTableAdapter();
            this.tableAdapterManager = new PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager();
            this.dostupnostTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.DostupnostTableAdapter();
            this.lijekoviTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviComboBox = new System.Windows.Forms.ComboBox();
            this.poslovniceComboBox = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PregledLijekovaTableAdapter = new PharmaCure._17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter();
            this.grafStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prikaziSve = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lijekoviReceptTableAdapter1 = new PharmaCure._17003_DBDataSetTableAdapters.LijekoviReceptTableAdapter();
            lijekovi_IDLabel = new System.Windows.Forms.Label();
            poslovnica_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PregledLijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostupnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekovi_IDLabel
            // 
            lijekovi_IDLabel.AutoSize = true;
            lijekovi_IDLabel.BackColor = System.Drawing.Color.Transparent;
            lijekovi_IDLabel.Location = new System.Drawing.Point(402, 15);
            lijekovi_IDLabel.Name = "lijekovi_IDLabel";
            lijekovi_IDLabel.Size = new System.Drawing.Size(61, 13);
            lijekovi_IDLabel.TabIndex = 4;
            lijekovi_IDLabel.Text = "Naziv lijeka";
            // 
            // poslovnica_IDLabel
            // 
            poslovnica_IDLabel.AutoSize = true;
            poslovnica_IDLabel.BackColor = System.Drawing.Color.Transparent;
            poslovnica_IDLabel.Location = new System.Drawing.Point(181, 15);
            poslovnica_IDLabel.Name = "poslovnica_IDLabel";
            poslovnica_IDLabel.Size = new System.Drawing.Size(88, 13);
            poslovnica_IDLabel.TabIndex = 5;
            poslovnica_IDLabel.Text = "Naziv poslovnice";
            // 
            // PregledLijekovaBindingSource
            // 
            this.PregledLijekovaBindingSource.DataMember = "PregledLijekova";
            this.PregledLijekovaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // _17003_DBDataSet
            // 
            this._17003_DBDataSet.DataSetName = "_17003_DBDataSet";
            this._17003_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostupnostBindingSource
            // 
            this.dostupnostBindingSource.DataMember = "Dostupnost";
            this.dostupnostBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "Poslovnica";
            this.poslovnicaBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AkcijaTableAdapter = null;
            this.tableAdapterManager.Artikli_RacunTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DjelatnikTableAdapter = null;
            this.tableAdapterManager.DostupnostTableAdapter = this.dostupnostTableAdapter;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.LijekoviOsiguranjeTableAdapter = null;
            this.tableAdapterManager.LijekoviReceptTableAdapter = null;
            this.tableAdapterManager.LijekoviTableAdapter = this.lijekoviTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OsiguranjeTableAdapter = null;
            this.tableAdapterManager.PopisOsiguranihLijekovaTableAdapter = null;
            this.tableAdapterManager.PopisTableAdapter = null;
            this.tableAdapterManager.PoslovnicaTableAdapter = this.poslovnicaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.RezervacijaTableAdapter = null;
            this.tableAdapterManager.StanjaTableAdapter = null;
            this.tableAdapterManager.StavkeNarudzbeTableAdapter = null;
            this.tableAdapterManager.TipDjelatnikaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PharmaCure._17003_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dostupnostTableAdapter
            // 
            this.dostupnostTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviTableAdapter
            // 
            this.lijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataMember = "Lijekovi";
            this.lijekoviBindingSource.DataSource = this._17003_DBDataSet;
            // 
            // lijekoviComboBox
            // 
            this.lijekoviComboBox.DataSource = this.lijekoviBindingSource;
            this.lijekoviComboBox.DisplayMember = "Naziv";
            this.lijekoviComboBox.FormattingEnabled = true;
            this.lijekoviComboBox.Location = new System.Drawing.Point(469, 9);
            this.lijekoviComboBox.Name = "lijekoviComboBox";
            this.lijekoviComboBox.Size = new System.Drawing.Size(121, 21);
            this.lijekoviComboBox.TabIndex = 2;
            this.lijekoviComboBox.ValueMember = "ID_Lijek";
            this.lijekoviComboBox.SelectedIndexChanged += new System.EventHandler(this.LijekoviComboBox_SelectedIndexChanged);
            // 
            // poslovniceComboBox
            // 
            this.poslovniceComboBox.DataSource = this.poslovnicaBindingSource;
            this.poslovniceComboBox.DisplayMember = "Naziv";
            this.poslovniceComboBox.FormattingEnabled = true;
            this.poslovniceComboBox.Location = new System.Drawing.Point(275, 10);
            this.poslovniceComboBox.Name = "poslovniceComboBox";
            this.poslovniceComboBox.Size = new System.Drawing.Size(121, 21);
            this.poslovniceComboBox.TabIndex = 1;
            this.poslovniceComboBox.ValueMember = "ID_Poslovnica";
            this.poslovniceComboBox.SelectedIndexChanged += new System.EventHandler(this.poslovniceComboBox_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PregledLijekovaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharmaCure.Izvjestaj_KolicinaLijekova.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 233);
            this.reportViewer1.TabIndex = 13;
            // 
            // PregledLijekovaTableAdapter
            // 
            this.PregledLijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // grafStatistika
            // 
            chartArea1.Name = "ChartArea1";
            this.grafStatistika.ChartAreas.Add(chartArea1);
            this.grafStatistika.DataSource = this.PregledLijekovaBindingSource;
            legend1.Name = "Legend1";
            this.grafStatistika.Legends.Add(legend1);
            this.grafStatistika.Location = new System.Drawing.Point(678, 56);
            this.grafStatistika.Name = "grafStatistika";
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Kolicine lijeka";
            series1.XValueMember = "NazivLijeka";
            series1.YValueMembers = "Kolicina_skladiste";
            this.grafStatistika.Series.Add(series1);
            this.grafStatistika.Size = new System.Drawing.Size(319, 300);
            this.grafStatistika.TabIndex = 14;
            this.grafStatistika.Text = "chart1";
            // 
            // prikaziSve
            // 
            this.prikaziSve.Location = new System.Drawing.Point(311, 46);
            this.prikaziSve.Name = "prikaziSve";
            this.prikaziSve.Size = new System.Drawing.Size(152, 23);
            this.prikaziSve.TabIndex = 15;
            this.prikaziSve.Text = "Prikazi sve poslovnice";
            this.prikaziSve.UseVisualStyleBackColor = true;
            this.prikaziSve.Click += new System.EventHandler(this.prikaziSve_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(862, 5);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(30, 7);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click_1);
            // 
            // lijekoviReceptTableAdapter1
            // 
            this.lijekoviReceptTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmKolicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1009, 424);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.prikaziSve);
            this.Controls.Add(this.grafStatistika);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.poslovniceComboBox);
            this.Controls.Add(this.lijekoviComboBox);
            this.Controls.Add(poslovnica_IDLabel);
            this.Controls.Add(lijekovi_IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKolicine";
            this.Text = "FrmKolicine";
            this.Load += new System.EventHandler(this.FrmKolicine_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKolicine_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PregledLijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17003_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostupnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafStatistika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _17003_DBDataSet _17003_DBDataSet;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private _17003_DBDataSetTableAdapters.PoslovnicaTableAdapter poslovnicaTableAdapter;
        private _17003_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _17003_DBDataSetTableAdapters.DostupnostTableAdapter dostupnostTableAdapter;
        private System.Windows.Forms.BindingSource dostupnostBindingSource;
        private _17003_DBDataSetTableAdapters.LijekoviTableAdapter lijekoviTableAdapter;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private System.Windows.Forms.ComboBox lijekoviComboBox;
        private System.Windows.Forms.ComboBox poslovniceComboBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PregledLijekovaBindingSource;
        private _17003_DBDataSetTableAdapters.PregledLijekovaTableAdapter PregledLijekovaTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafStatistika;
        private System.Windows.Forms.Button prikaziSve;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPovratak;
        private _17003_DBDataSetTableAdapters.LijekoviReceptTableAdapter lijekoviReceptTableAdapter1;
    }
}