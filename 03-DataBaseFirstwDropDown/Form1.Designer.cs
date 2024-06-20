namespace _03_DataBaseFirstwDropDown
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
            cbCategory = new ComboBox();
            label1 = new Label();
            txtbProductName = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(49, 144);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(206, 28);
            cbCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 109);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Category:";
            // 
            // txtbProductName
            // 
            txtbProductName.Location = new Point(49, 66);
            txtbProductName.Name = "txtbProductName";
            txtbProductName.Size = new Size(206, 27);
            txtbProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 28);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(85, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 422);
            Controls.Add(btnAdd);
            Controls.Add(txtbProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCategory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategory;
        private Label label1;
        private TextBox txtbProductName;
        private Label label2;
        private Button btnAdd;
    }
}
