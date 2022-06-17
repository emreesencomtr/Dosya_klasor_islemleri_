
namespace Dosya_islemleri_
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKonumSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnSaveDialog = new System.Windows.Forms.Button();
            this.TxtYol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKonum = new System.Windows.Forms.Button();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.Label();
            this.BtnOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // BtnKonumSec
            // 
            this.BtnKonumSec.Location = new System.Drawing.Point(526, 12);
            this.BtnKonumSec.Name = "BtnKonumSec";
            this.BtnKonumSec.Size = new System.Drawing.Size(139, 33);
            this.BtnKonumSec.TabIndex = 1;
            this.BtnKonumSec.Text = "Folder Browser Dialog";
            this.BtnKonumSec.UseVisualStyleBackColor = true;
            this.BtnKonumSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(526, 68);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(139, 27);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // BtnSaveDialog
            // 
            this.BtnSaveDialog.Location = new System.Drawing.Point(526, 117);
            this.BtnSaveDialog.Name = "BtnSaveDialog";
            this.BtnSaveDialog.Size = new System.Drawing.Size(139, 23);
            this.BtnSaveDialog.TabIndex = 3;
            this.BtnSaveDialog.Text = "Save File Dialog";
            this.BtnSaveDialog.UseVisualStyleBackColor = true;
            this.BtnSaveDialog.Click += new System.EventHandler(this.BtnSaveDialog_Click);
            // 
            // TxtYol
            // 
            this.TxtYol.Location = new System.Drawing.Point(73, 29);
            this.TxtYol.Name = "TxtYol";
            this.TxtYol.Size = new System.Drawing.Size(167, 20);
            this.TxtYol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belge Yolu:";
            // 
            // BtnKonum
            // 
            this.BtnKonum.Location = new System.Drawing.Point(526, 158);
            this.BtnKonum.Name = "BtnKonum";
            this.BtnKonum.Size = new System.Drawing.Size(139, 23);
            this.BtnKonum.TabIndex = 6;
            this.BtnKonum.Text = "Konum Seç";
            this.BtnKonum.UseVisualStyleBackColor = true;
            this.BtnKonum.Click += new System.EventHandler(this.BtnKonum_Click);
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(526, 198);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(139, 23);
            this.BtnOlustur.TabIndex = 7;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(73, 72);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(167, 20);
            this.TxtAd.TabIndex = 8;
            // 
            // TxtAdi
            // 
            this.TxtAdi.AutoSize = true;
            this.TxtAdi.Location = new System.Drawing.Point(12, 75);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(55, 13);
            this.TxtAdi.TabIndex = 9;
            this.TxtAdi.Text = "Belge Adı:";
            // 
            // BtnOku
            // 
            this.BtnOku.Location = new System.Drawing.Point(526, 237);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(139, 23);
            this.BtnOku.TabIndex = 10;
            this.BtnOku.Text = "Oku";
            this.BtnOku.UseVisualStyleBackColor = true;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(15, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 30);
            this.listBox1.TabIndex = 11;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(526, 266);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(139, 23);
            this.BtnYazdir.TabIndex = 12;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 129);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.BtnKonum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYol);
            this.Controls.Add(this.BtnSaveDialog);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.BtnKonumSec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKonumSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnSaveDialog;
        private System.Windows.Forms.TextBox TxtYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKonum;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label TxtAdi;
        private System.Windows.Forms.Button BtnOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

