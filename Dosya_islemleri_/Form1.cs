﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosya_islemleri_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;

        }

        private void BtnSaveDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        string belgeninyolu, belgeninadi;

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            belgeninadi = TxtAd.Text;
            StreamWriter sw = File.CreateText(belgeninyolu + "\\" + belgeninadi + ".txt");
            MessageBox.Show ("Belgeniz başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null)

                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin Belgesine kayıt yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnKonum_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() ==DialogResult.OK)
            {
                belgeninyolu = folderBrowserDialog1.SelectedPath;
                TxtYol.Text = belgeninyolu;
            }
        }
    }
}
