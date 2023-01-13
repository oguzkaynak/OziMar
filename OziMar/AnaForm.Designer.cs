
namespace OziMar
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kategoriİslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedariciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MusteriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MusteriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MusteriGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MusteriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MusteriSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.Size = new System.Drawing.Size(104, 22);
            this.TSMI_Kapat.Text = "Kapat";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_kategoriİslemleri,
            this.TSMI_UrunIslemleri,
            this.TSMI_TedarikciIslemleri,
            this.TSMI_MusteriIslemleri});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // TSMI_kategoriİslemleri
            // 
            this.TSMI_kategoriİslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_KategoriEkle,
            this.TSMI_KategoriGuncelle,
            this.TSMI_KategoriListele,
            this.TSMI_KategoriSil});
            this.TSMI_kategoriİslemleri.Name = "TSMI_kategoriİslemleri";
            this.TSMI_kategoriİslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_kategoriİslemleri.Text = "Kategori İşlemleri";
            // 
            // TSMI_KategoriEkle
            // 
            this.TSMI_KategoriEkle.Name = "TSMI_KategoriEkle";
            this.TSMI_KategoriEkle.Size = new System.Drawing.Size(167, 22);
            this.TSMI_KategoriEkle.Text = "Kategori Ekle";
            this.TSMI_KategoriEkle.Click += new System.EventHandler(this.TSMI_KategoriEkle_Click);
            // 
            // TSMI_KategoriGuncelle
            // 
            this.TSMI_KategoriGuncelle.Name = "TSMI_KategoriGuncelle";
            this.TSMI_KategoriGuncelle.Size = new System.Drawing.Size(167, 22);
            this.TSMI_KategoriGuncelle.Text = "Kategori Güncelle";
            // 
            // TSMI_KategoriListele
            // 
            this.TSMI_KategoriListele.Name = "TSMI_KategoriListele";
            this.TSMI_KategoriListele.Size = new System.Drawing.Size(167, 22);
            this.TSMI_KategoriListele.Text = "Kategori Listele";
            // 
            // TSMI_KategoriSil
            // 
            this.TSMI_KategoriSil.Name = "TSMI_KategoriSil";
            this.TSMI_KategoriSil.Size = new System.Drawing.Size(167, 22);
            this.TSMI_KategoriSil.Text = "Kategori Sil";
            // 
            // TSMI_UrunIslemleri
            // 
            this.TSMI_UrunIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIUrunEkle,
            this.TSMI_UrunGuncelle,
            this.TSMI_UrunListele,
            this.TSMI_UrunSil});
            this.TSMI_UrunIslemleri.Name = "TSMI_UrunIslemleri";
            this.TSMI_UrunIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunIslemleri.Text = "Ürün İşlemleri";
            // 
            // TSMIUrunEkle
            // 
            this.TSMIUrunEkle.Name = "TSMIUrunEkle";
            this.TSMIUrunEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMIUrunEkle.Text = "Ürün Ekle";
            // 
            // TSMI_UrunGuncelle
            // 
            this.TSMI_UrunGuncelle.Name = "TSMI_UrunGuncelle";
            this.TSMI_UrunGuncelle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunGuncelle.Text = "Ürün Güncelle";
            // 
            // TSMI_UrunListele
            // 
            this.TSMI_UrunListele.Name = "TSMI_UrunListele";
            this.TSMI_UrunListele.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunListele.Text = "Ürün Listele";
            this.TSMI_UrunListele.Click += new System.EventHandler(this.TSMI_UrunListele_Click);
            // 
            // TSMI_UrunSil
            // 
            this.TSMI_UrunSil.Name = "TSMI_UrunSil";
            this.TSMI_UrunSil.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunSil.Text = "Ürün Sil";
            // 
            // TSMI_TedarikciIslemleri
            // 
            this.TSMI_TedarikciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TedariciEkle,
            this.TSMI_TedarikciGuncelle,
            this.TSMI_TedarikciListele,
            this.TSMI_TedarikciSil});
            this.TSMI_TedarikciIslemleri.Name = "TSMI_TedarikciIslemleri";
            this.TSMI_TedarikciIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_TedarikciIslemleri.Text = "Tedarikci İşlemleri";
            // 
            // TSMI_TedariciEkle
            // 
            this.TSMI_TedariciEkle.Name = "TSMI_TedariciEkle";
            this.TSMI_TedariciEkle.Size = new System.Drawing.Size(169, 22);
            this.TSMI_TedariciEkle.Text = "Tedarikci Ekle";
            // 
            // TSMI_TedarikciGuncelle
            // 
            this.TSMI_TedarikciGuncelle.Name = "TSMI_TedarikciGuncelle";
            this.TSMI_TedarikciGuncelle.Size = new System.Drawing.Size(169, 22);
            this.TSMI_TedarikciGuncelle.Text = "Tedarikci Güncelle";
            // 
            // TSMI_TedarikciListele
            // 
            this.TSMI_TedarikciListele.Name = "TSMI_TedarikciListele";
            this.TSMI_TedarikciListele.Size = new System.Drawing.Size(169, 22);
            this.TSMI_TedarikciListele.Text = "Tedarkci Listele";
            // 
            // TSMI_TedarikciSil
            // 
            this.TSMI_TedarikciSil.Name = "TSMI_TedarikciSil";
            this.TSMI_TedarikciSil.Size = new System.Drawing.Size(169, 22);
            this.TSMI_TedarikciSil.Text = "Tedarikci Sil";
            // 
            // TSMI_MusteriIslemleri
            // 
            this.TSMI_MusteriIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_MusteriEkle,
            this.TSMI_MusteriGuncelle,
            this.TSMI_MusteriListele,
            this.TSMI_MusteriSil});
            this.TSMI_MusteriIslemleri.Name = "TSMI_MusteriIslemleri";
            this.TSMI_MusteriIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_MusteriIslemleri.Text = "Müşteri İşlemleri";
            // 
            // TSMI_MusteriEkle
            // 
            this.TSMI_MusteriEkle.Name = "TSMI_MusteriEkle";
            this.TSMI_MusteriEkle.Size = new System.Drawing.Size(163, 22);
            this.TSMI_MusteriEkle.Text = "Müşteri Ekle";
            // 
            // TSMI_MusteriGuncelle
            // 
            this.TSMI_MusteriGuncelle.Name = "TSMI_MusteriGuncelle";
            this.TSMI_MusteriGuncelle.Size = new System.Drawing.Size(163, 22);
            this.TSMI_MusteriGuncelle.Text = "Müşteri Güncelle";
            // 
            // TSMI_MusteriListele
            // 
            this.TSMI_MusteriListele.Name = "TSMI_MusteriListele";
            this.TSMI_MusteriListele.Size = new System.Drawing.Size(163, 22);
            this.TSMI_MusteriListele.Text = "Müşteri Listele";
            // 
            // TSMI_MusteriSil
            // 
            this.TSMI_MusteriSil.Name = "TSMI_MusteriSil";
            this.TSMI_MusteriSil.Size = new System.Drawing.Size(163, 22);
            this.TSMI_MusteriSil.Text = "Müşteri Sil";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kategoriİslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MusteriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriGuncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriSil;
        private System.Windows.Forms.ToolStripMenuItem TSMIUrunEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunGuncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunSil;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedariciEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciGuncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciSil;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MusteriGuncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MusteriListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MusteriSil;
    }
}