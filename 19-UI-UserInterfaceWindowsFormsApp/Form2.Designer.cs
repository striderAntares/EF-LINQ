namespace _19_UI_UserInterfaceWindowsFormsApp
{
    partial class Form2
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
            groupBox2 = new GroupBox();
            btnKaydet = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbTelefon = new TextBox();
            txtbAdres = new TextBox();
            txtbEmail = new TextBox();
            groupBox1 = new GroupBox();
            btnIletisimEkleme = new Button();
            combPersonel = new ComboBox();
            btnYeniPersonel = new Button();
            btnTumKayitlar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtbTelefon);
            groupBox2.Controls.Add(txtbAdres);
            groupBox2.Controls.Add(txtbEmail);
            groupBox2.Location = new Point(54, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(824, 561);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İletişim Bilgileri Giriş Ekranı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(105, 393);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(578, 100);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 266);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 1;
            label3.Text = "Ev Adresi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 177);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 1;
            label2.Text = "Telefon no:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 90);
            label1.Name = "label1";
            label1.Size = new Size(95, 41);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // txtbTelefon
            // 
            txtbTelefon.Location = new Point(212, 171);
            txtbTelefon.Name = "txtbTelefon";
            txtbTelefon.Size = new Size(587, 47);
            txtbTelefon.TabIndex = 0;
            // 
            // txtbAdres
            // 
            txtbAdres.Location = new Point(212, 266);
            txtbAdres.Name = "txtbAdres";
            txtbAdres.Size = new Size(587, 47);
            txtbAdres.TabIndex = 0;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(212, 87);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(587, 47);
            txtbEmail.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIletisimEkleme);
            groupBox1.Controls.Add(combPersonel);
            groupBox1.Location = new Point(54, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(824, 294);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "İletişim Bilgilerini Eklemek İçin Personel Seç";
            // 
            // btnIletisimEkleme
            // 
            btnIletisimEkleme.Location = new Point(105, 158);
            btnIletisimEkleme.Name = "btnIletisimEkleme";
            btnIletisimEkleme.Size = new Size(578, 100);
            btnIletisimEkleme.TabIndex = 1;
            btnIletisimEkleme.Text = "Giriş ve ya Güncelleme Yap";
            btnIletisimEkleme.UseVisualStyleBackColor = true;
            btnIletisimEkleme.Click += btnIletisimEkleme_Click;
            // 
            // combPersonel
            // 
            combPersonel.FormattingEnabled = true;
            combPersonel.Location = new Point(38, 73);
            combPersonel.Name = "combPersonel";
            combPersonel.Size = new Size(726, 49);
            combPersonel.TabIndex = 0;
            // 
            // btnYeniPersonel
            // 
            btnYeniPersonel.Location = new Point(159, 997);
            btnYeniPersonel.Name = "btnYeniPersonel";
            btnYeniPersonel.Size = new Size(245, 100);
            btnYeniPersonel.TabIndex = 1;
            btnYeniPersonel.Text = "Yeni Personel";
            btnYeniPersonel.UseVisualStyleBackColor = true;
            btnYeniPersonel.Click += btnYeniPersonel_Click;
            // 
            // btnTumKayitlar
            // 
            btnTumKayitlar.Location = new Point(492, 997);
            btnTumKayitlar.Name = "btnTumKayitlar";
            btnTumKayitlar.Size = new Size(245, 100);
            btnTumKayitlar.TabIndex = 1;
            btnTumKayitlar.Text = "Tüm Kayıtlar";
            btnTumKayitlar.UseVisualStyleBackColor = true;
            btnTumKayitlar.Click += btnTumKayitlar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 1124);
            Controls.Add(btnTumKayitlar);
            Controls.Add(btnYeniPersonel);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtbTelefon;
        private TextBox txtbAdres;
        private TextBox txtbEmail;
        private GroupBox groupBox1;
        private Button btnIletisimEkleme;
        private ComboBox combPersonel;
        private Button btnKaydet;
        private Label label3;
        private Label label2;
        private Button btnYeniPersonel;
        private Button btnTumKayitlar;
    }
}