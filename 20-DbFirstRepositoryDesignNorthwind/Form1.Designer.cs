namespace _20_DbFirstRepositoryDesignNorthwind
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
            txtbKatAdi = new TextBox();
            txtbKatAciklama = new TextBox();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtbKatAdi
            // 
            txtbKatAdi.Location = new Point(295, 120);
            txtbKatAdi.Name = "txtbKatAdi";
            txtbKatAdi.Size = new Size(569, 47);
            txtbKatAdi.TabIndex = 0;
            // 
            // txtbKatAciklama
            // 
            txtbKatAciklama.Location = new Point(295, 228);
            txtbKatAciklama.Name = "txtbKatAciklama";
            txtbKatAciklama.Size = new Size(569, 47);
            txtbKatAciklama.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(197, 346);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(667, 92);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 120);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 2;
            label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 228);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 2;
            label2.Text = "Açıklama:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(197, 479);
            listView1.Name = "listView1";
            listView1.Size = new Size(667, 513);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category Name";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 300;
            // 
            // button1
            // 
            button1.Location = new Point(197, 1031);
            button1.Name = "button1";
            button1.Size = new Size(667, 92);
            button1.TabIndex = 1;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(197, 1154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(667, 90);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 1316);
            Controls.Add(btnDelete);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEkle);
            Controls.Add(txtbKatAciklama);
            Controls.Add(txtbKatAdi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbKatAdi;
        private TextBox txtbKatAciklama;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Button btnDelete;
    }
}
