namespace _17_UrunEklemeOtomasyon
{
    partial class Form2
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
            grobKategoriEkleme = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtbAciklama = new TextBox();
            txtbKategoriAdı = new TextBox();
            grobKategoriler = new GroupBox();
            btnKategoriYenile = new Button();
            listvKategoriler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnUrunEkle = new Button();
            btnKategoriEkle = new Button();
            grobKategoriEkleme.SuspendLayout();
            grobKategoriler.SuspendLayout();
            SuspendLayout();
            // 
            // grobKategoriEkleme
            // 
            grobKategoriEkleme.Controls.Add(label2);
            grobKategoriEkleme.Controls.Add(label1);
            grobKategoriEkleme.Controls.Add(txtbAciklama);
            grobKategoriEkleme.Controls.Add(txtbKategoriAdı);
            grobKategoriEkleme.Location = new Point(43, 33);
            grobKategoriEkleme.Name = "grobKategoriEkleme";
            grobKategoriEkleme.Size = new Size(411, 158);
            grobKategoriEkleme.TabIndex = 0;
            grobKategoriEkleme.TabStop = false;
            grobKategoriEkleme.Text = "Kategori Ekleme Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı:";
            // 
            // txtbAciklama
            // 
            txtbAciklama.Location = new Point(160, 89);
            txtbAciklama.Name = "txtbAciklama";
            txtbAciklama.Size = new Size(223, 27);
            txtbAciklama.TabIndex = 0;
            // 
            // txtbKategoriAdı
            // 
            txtbKategoriAdı.Location = new Point(160, 38);
            txtbKategoriAdı.Name = "txtbKategoriAdı";
            txtbKategoriAdı.Size = new Size(223, 27);
            txtbKategoriAdı.TabIndex = 0;
            // 
            // grobKategoriler
            // 
            grobKategoriler.Controls.Add(btnKategoriYenile);
            grobKategoriler.Controls.Add(listvKategoriler);
            grobKategoriler.Location = new Point(43, 261);
            grobKategoriler.Name = "grobKategoriler";
            grobKategoriler.Size = new Size(411, 411);
            grobKategoriler.TabIndex = 1;
            grobKategoriler.TabStop = false;
            grobKategoriler.Text = "Kategoriler";
            // 
            // btnKategoriYenile
            // 
            btnKategoriYenile.Location = new Point(80, 361);
            btnKategoriYenile.Name = "btnKategoriYenile";
            btnKategoriYenile.Size = new Size(233, 33);
            btnKategoriYenile.TabIndex = 1;
            btnKategoriYenile.Text = "Kategori Listesini Yenile";
            btnKategoriYenile.UseVisualStyleBackColor = true;
            btnKategoriYenile.Click += btnKategoriYenile_Click;
            // 
            // listvKategoriler
            // 
            listvKategoriler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listvKategoriler.Location = new Point(21, 41);
            listvKategoriler.Name = "listvKategoriler";
            listvKategoriler.Size = new Size(362, 303);
            listvKategoriler.TabIndex = 0;
            listvKategoriler.UseCompatibleStateImageBehavior = false;
            listvKategoriler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori Adı";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açıklama";
            columnHeader3.Width = 360;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(154, 678);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(169, 33);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(154, 207);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(169, 33);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 723);
            Controls.Add(btnKategoriEkle);
            Controls.Add(btnUrunEkle);
            Controls.Add(grobKategoriler);
            Controls.Add(grobKategoriEkleme);
            Name = "Form2";
            Text = "Form2";
            grobKategoriEkleme.ResumeLayout(false);
            grobKategoriEkleme.PerformLayout();
            grobKategoriler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grobKategoriEkleme;
        public Label label2;
        public Label label1;
        public TextBox txtbAciklama;
        public TextBox txtbKategoriAdı;
        public GroupBox grobKategoriler;
        public Button btnUrunEkle;
        public ListView listvKategoriler;
        public ColumnHeader columnHeader1;
        public ColumnHeader columnHeader2;
        public ColumnHeader columnHeader3;
        public Button btnKategoriEkle;
        public Button btnKategoriYenile;
    }
}