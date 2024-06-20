namespace _19_UI_UserInterfaceWindowsFormsApp
{
    partial class Form3
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
            listView1 = new ListView();
            btnEkranaDon = new Button();
            btnSil = new Button();
            grobPersonelBul = new GroupBox();
            btnListViewTemizle = new Button();
            btnAra = new Button();
            combKosul = new ComboBox();
            txtbKosulMetini = new TextBox();
            grobPersoneller = new GroupBox();
            btnGuncelle = new Button();
            btnLabelTemizlik = new Button();
            label1 = new Label();
            grobPersonelBul.SuspendLayout();
            grobPersoneller.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(82, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(1373, 633);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEkranaDon
            // 
            btnEkranaDon.Location = new Point(400, 1021);
            btnEkranaDon.Name = "btnEkranaDon";
            btnEkranaDon.Size = new Size(533, 129);
            btnEkranaDon.TabIndex = 1;
            btnEkranaDon.Text = "İletişim Ekranına Dön";
            btnEkranaDon.UseVisualStyleBackColor = true;
            btnEkranaDon.Click += button1_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1258, 1021);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(533, 129);
            btnSil.TabIndex = 1;
            btnSil.Text = "Personeli Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // grobPersonelBul
            // 
            grobPersonelBul.Controls.Add(btnListViewTemizle);
            grobPersonelBul.Controls.Add(btnAra);
            grobPersonelBul.Controls.Add(combKosul);
            grobPersonelBul.Controls.Add(txtbKosulMetini);
            grobPersonelBul.Controls.Add(listView1);
            grobPersonelBul.Location = new Point(1176, 99);
            grobPersonelBul.Name = "grobPersonelBul";
            grobPersonelBul.Size = new Size(1481, 870);
            grobPersonelBul.TabIndex = 2;
            grobPersonelBul.TabStop = false;
            grobPersonelBul.Text = "Personel Bul";
            // 
            // btnListViewTemizle
            // 
            btnListViewTemizle.Location = new Point(82, 793);
            btnListViewTemizle.Name = "btnListViewTemizle";
            btnListViewTemizle.Size = new Size(238, 58);
            btnListViewTemizle.TabIndex = 1;
            btnListViewTemizle.Text = "Temizle";
            btnListViewTemizle.UseVisualStyleBackColor = true;
            btnListViewTemizle.Click += btnListViewTemizle_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(799, 59);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(188, 58);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // combKosul
            // 
            combKosul.FormattingEnabled = true;
            combKosul.Items.AddRange(new object[] { "ile başlayan", "içeren", "ile biten" });
            combKosul.Location = new Point(551, 59);
            combKosul.Name = "combKosul";
            combKosul.Size = new Size(201, 49);
            combKosul.TabIndex = 2;
            // 
            // txtbKosulMetini
            // 
            txtbKosulMetini.Location = new Point(241, 59);
            txtbKosulMetini.Name = "txtbKosulMetini";
            txtbKosulMetini.Size = new Size(271, 47);
            txtbKosulMetini.TabIndex = 1;
            // 
            // grobPersoneller
            // 
            grobPersoneller.Controls.Add(btnGuncelle);
            grobPersoneller.Controls.Add(btnLabelTemizlik);
            grobPersoneller.Controls.Add(label1);
            grobPersoneller.Location = new Point(83, 99);
            grobPersoneller.Name = "grobPersoneller";
            grobPersoneller.Size = new Size(1051, 870);
            grobPersoneller.TabIndex = 3;
            grobPersoneller.TabStop = false;
            grobPersoneller.Text = "Personel Bilgileri";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(317, 783);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(238, 58);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnLabelTemizlik
            // 
            btnLabelTemizlik.Location = new Point(612, 783);
            btnLabelTemizlik.Name = "btnLabelTemizlik";
            btnLabelTemizlik.Size = new Size(238, 58);
            btnLabelTemizlik.TabIndex = 1;
            btnLabelTemizlik.Text = "Temizle";
            btnLabelTemizlik.UseVisualStyleBackColor = true;
            btnLabelTemizlik.Click += btnLabelTemizlik_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(43, 59);
            label1.Name = "label1";
            label1.Size = new Size(983, 708);
            label1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2770, 1301);
            Controls.Add(grobPersoneller);
            Controls.Add(grobPersonelBul);
            Controls.Add(btnSil);
            Controls.Add(btnEkranaDon);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grobPersonelBul.ResumeLayout(false);
            grobPersonelBul.PerformLayout();
            grobPersoneller.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnEkranaDon;
        private Button btnSil;
        private GroupBox grobPersonelBul;
        private Button btnListViewTemizle;
        private Button btnAra;
        private ComboBox combKosul;
        private TextBox txtbKosulMetini;
        private GroupBox grobPersoneller;
        private Button btnLabelTemizlik;
        private Label label1;
        private Button btnGuncelle;
    }
}