namespace _19_UI_UserInterfaceWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grobPersonelKayit = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            combBirimler = new ComboBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            datetPDogum = new DateTimePicker();
            txtbTCNo = new TextBox();
            txtbSurname = new TextBox();
            txtbName = new TextBox();
            btnTemizle = new Button();
            btnKayıt = new Button();
            btnIletisim = new Button();
            grobPersonelKayit.SuspendLayout();
            SuspendLayout();
            // 
            // grobPersonelKayit
            // 
            grobPersonelKayit.Controls.Add(label6);
            grobPersonelKayit.Controls.Add(label5);
            grobPersonelKayit.Controls.Add(label4);
            grobPersonelKayit.Controls.Add(label3);
            grobPersonelKayit.Controls.Add(label2);
            grobPersonelKayit.Controls.Add(label1);
            grobPersonelKayit.Controls.Add(combBirimler);
            grobPersonelKayit.Controls.Add(rbKadin);
            grobPersonelKayit.Controls.Add(rbErkek);
            grobPersonelKayit.Controls.Add(datetPDogum);
            grobPersonelKayit.Controls.Add(txtbTCNo);
            grobPersonelKayit.Controls.Add(txtbSurname);
            grobPersonelKayit.Controls.Add(txtbName);
            grobPersonelKayit.Location = new Point(93, 78);
            grobPersonelKayit.Name = "grobPersonelKayit";
            grobPersonelKayit.Size = new Size(839, 746);
            grobPersonelKayit.TabIndex = 0;
            grobPersonelKayit.TabStop = false;
            grobPersonelKayit.Text = "Personel Kayıt Ekranı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 581);
            label6.Name = "label6";
            label6.Size = new Size(125, 41);
            label6.TabIndex = 4;
            label6.Text = "Birimler:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 490);
            label5.Name = "label5";
            label5.Size = new Size(122, 41);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 381);
            label4.Name = "label4";
            label4.Size = new Size(199, 41);
            label4.TabIndex = 4;
            label4.Text = "Doğum tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 280);
            label3.Name = "label3";
            label3.Size = new Size(209, 41);
            label3.TabIndex = 4;
            label3.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 179);
            label2.Name = "label2";
            label2.Size = new Size(114, 41);
            label2.TabIndex = 4;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(69, 41);
            label1.TabIndex = 4;
            label1.Text = "Adı:";
            // 
            // combBirimler
            // 
            combBirimler.FormattingEnabled = true;
            combBirimler.Location = new Point(256, 581);
            combBirimler.Name = "combBirimler";
            combBirimler.Size = new Size(551, 49);
            combBirimler.TabIndex = 3;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(579, 491);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(129, 45);
            rbKadin.TabIndex = 2;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(256, 490);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(126, 45);
            rbErkek.TabIndex = 2;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // datetPDogum
            // 
            datetPDogum.Location = new Point(256, 381);
            datetPDogum.Name = "datetPDogum";
            datetPDogum.Size = new Size(551, 47);
            datetPDogum.TabIndex = 1;
            // 
            // txtbTCNo
            // 
            txtbTCNo.Location = new Point(256, 280);
            txtbTCNo.Name = "txtbTCNo";
            txtbTCNo.Size = new Size(551, 47);
            txtbTCNo.TabIndex = 0;
            // 
            // txtbSurname
            // 
            txtbSurname.Location = new Point(256, 179);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(551, 47);
            txtbSurname.TabIndex = 0;
            // 
            // txtbName
            // 
            txtbName.Location = new Point(256, 78);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(551, 47);
            txtbName.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(93, 849);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(214, 85);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKayıt
            // 
            btnKayıt.Location = new Point(718, 849);
            btnKayıt.Name = "btnKayıt";
            btnKayıt.Size = new Size(214, 85);
            btnKayıt.TabIndex = 1;
            btnKayıt.Text = "Kayıt";
            btnKayıt.UseVisualStyleBackColor = true;
            btnKayıt.Click += btnKayıt_Click;
            // 
            // btnIletisim
            // 
            btnIletisim.Location = new Point(93, 962);
            btnIletisim.Name = "btnIletisim";
            btnIletisim.Size = new Size(839, 85);
            btnIletisim.TabIndex = 1;
            btnIletisim.Text = "İletişim Bilgilerini Gör";
            btnIletisim.UseVisualStyleBackColor = true;
            btnIletisim.Click += btnIletisim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 1081);
            Controls.Add(btnIletisim);
            Controls.Add(btnKayıt);
            Controls.Add(btnTemizle);
            Controls.Add(grobPersonelKayit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grobPersonelKayit.ResumeLayout(false);
            grobPersonelKayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grobPersonelKayit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combBirimler;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private DateTimePicker datetPDogum;
        private TextBox txtbTCNo;
        private TextBox txtbSurname;
        private TextBox txtbName;
        private Button btnTemizle;
        private Button btnKayıt;
        private Button btnIletisim;
    }
}
