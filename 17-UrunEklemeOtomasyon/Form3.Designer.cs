namespace _17_UrunEklemeOtomasyon
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            grobUrunEkleme = new GroupBox();
            numericUnitPrice = new NumericUpDown();
            numericStock = new NumericUpDown();
            txtbProduct = new TextBox();
            combKategori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            gropUrunler = new GroupBox();
            listvUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnUrunKaydet = new Button();
            btnUrunGuncelle = new Button();
            btnSil = new Button();
            btnKategoriDonus = new Button();
            grobUrunEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            gropUrunler.SuspendLayout();
            SuspendLayout();
            // 
            // grobUrunEkleme
            // 
            grobUrunEkleme.Controls.Add(numericUnitPrice);
            grobUrunEkleme.Controls.Add(numericStock);
            grobUrunEkleme.Controls.Add(txtbProduct);
            grobUrunEkleme.Controls.Add(combKategori);
            grobUrunEkleme.Controls.Add(label3);
            grobUrunEkleme.Controls.Add(label2);
            grobUrunEkleme.Controls.Add(label4);
            grobUrunEkleme.Controls.Add(label1);
            grobUrunEkleme.Location = new Point(153, 59);
            grobUrunEkleme.Margin = new Padding(6, 6, 6, 6);
            grobUrunEkleme.Name = "grobUrunEkleme";
            grobUrunEkleme.Padding = new Padding(6, 6, 6, 6);
            grobUrunEkleme.Size = new Size(1564, 543);
            grobUrunEkleme.TabIndex = 0;
            grobUrunEkleme.TabStop = false;
            grobUrunEkleme.Text = "Ürün Ekleme Paneli";
            // 
            // numericUnitPrice
            // 
            numericUnitPrice.Location = new Point(355, 418);
            numericUnitPrice.Margin = new Padding(6, 6, 6, 6);
            numericUnitPrice.Name = "numericUnitPrice";
            numericUnitPrice.Size = new Size(805, 47);
            numericUnitPrice.TabIndex = 3;
            // 
            // numericStock
            // 
            numericStock.Location = new Point(355, 328);
            numericStock.Margin = new Padding(6, 6, 6, 6);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(805, 47);
            numericStock.TabIndex = 3;
            // 
            // txtbProduct
            // 
            txtbProduct.Location = new Point(355, 213);
            txtbProduct.Margin = new Padding(6, 6, 6, 6);
            txtbProduct.Name = "txtbProduct";
            txtbProduct.Size = new Size(801, 47);
            txtbProduct.TabIndex = 2;
            // 
            // combKategori
            // 
            combKategori.FormattingEnabled = true;
            combKategori.Location = new Point(355, 107);
            combKategori.Margin = new Padding(6, 6, 6, 6);
            combKategori.Name = "combKategori";
            combKategori.Size = new Size(801, 49);
            combKategori.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 422);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 41);
            label3.TabIndex = 0;
            label3.Text = "Birim fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 328);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 0;
            label2.Text = "Stok adeti:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 113);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 41);
            label4.TabIndex = 0;
            label4.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 221);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 0;
            label1.Text = "Ürün adı:";
            // 
            // gropUrunler
            // 
            gropUrunler.Controls.Add(listvUrunler);
            gropUrunler.Location = new Point(153, 648);
            gropUrunler.Margin = new Padding(6, 6, 6, 6);
            gropUrunler.Name = "gropUrunler";
            gropUrunler.Padding = new Padding(6, 6, 6, 6);
            gropUrunler.Size = new Size(1564, 576);
            gropUrunler.TabIndex = 1;
            gropUrunler.TabStop = false;
            gropUrunler.Text = "Ürünler:";
            // 
            // listvUrunler
            // 
            listvUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listvUrunler.Location = new Point(64, 78);
            listvUrunler.Margin = new Padding(6, 6, 6, 6);
            listvUrunler.Name = "listvUrunler";
            listvUrunler.Size = new Size(1413, 455);
            listvUrunler.TabIndex = 0;
            listvUrunler.UseCompatibleStateImageBehavior = false;
            listvUrunler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID:";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Adı:";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün fiyatı:";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün stoğu:";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kategori Adı:";
            columnHeader5.Width = 240;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Aktiflik:";
            columnHeader6.Width = 240;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Eklenme tarihi:";
            columnHeader7.Width = 360;
            // 
            // btnUrunKaydet
            // 
            btnUrunKaydet.Location = new Point(1832, 59);
            btnUrunKaydet.Margin = new Padding(6, 6, 6, 6);
            btnUrunKaydet.Name = "btnUrunKaydet";
            btnUrunKaydet.Size = new Size(366, 94);
            btnUrunKaydet.TabIndex = 2;
            btnUrunKaydet.Text = "Kaydet";
            btnUrunKaydet.UseVisualStyleBackColor = true;
            btnUrunKaydet.Click += btnUrunKaydet_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(1832, 252);
            btnUrunGuncelle.Margin = new Padding(6, 6, 6, 6);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(366, 94);
            btnUrunGuncelle.TabIndex = 2;
            btnUrunGuncelle.Text = "Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1832, 445);
            btnSil.Margin = new Padding(6, 6, 6, 6);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(366, 117);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKategoriDonus
            // 
            btnKategoriDonus.Location = new Point(366, 1259);
            btnKategoriDonus.Margin = new Padding(6, 6, 6, 6);
            btnKategoriDonus.Name = "btnKategoriDonus";
            btnKategoriDonus.Size = new Size(1118, 100);
            btnKategoriDonus.TabIndex = 3;
            btnKategoriDonus.Text = "Kategori Ekranına Geri Dön";
            btnKategoriDonus.UseVisualStyleBackColor = true;
            btnKategoriDonus.Click += btnKategoriDonus_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1384);
            Controls.Add(btnKategoriDonus);
            Controls.Add(btnSil);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnUrunKaydet);
            Controls.Add(gropUrunler);
            Controls.Add(grobUrunEkleme);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grobUrunEkleme.ResumeLayout(false);
            grobUrunEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            gropUrunler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grobUrunEkleme;
        public Label label2;
        public Label label1;
        public Label label3;
        public Label label4;
        public GroupBox gropUrunler;
        public ListView listvUrunler;
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public ColumnHeader columnHeader4;
        public ColumnHeader columnHeader5;
        public ColumnHeader columnHeader6;
        public ColumnHeader columnHeader7;
        public Button btnUrunKaydet;
        public Button btnUrunGuncelle;
        public Button btnSil;
        public Button btnKategoriDonus;
        public TextBox txtbProduct;
        public ComboBox combKategori;
        public NumericUpDown numericStock;
        public NumericUpDown numericUnitPrice;
    }
}