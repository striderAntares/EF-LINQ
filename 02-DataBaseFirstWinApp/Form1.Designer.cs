namespace _02_DataBaseFirstWinApp
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
            txtbCategoryName = new TextBox();
            txtbCategoryDescription = new TextBox();
            btnAddContent = new Button();
            label1 = new Label();
            label2 = new Label();
            btnList = new Button();
            btnRemove = new Button();
            lboxCategories = new ListBox();
            listView1 = new ListView();
            CategoryID = new ColumnHeader();
            CategoryName = new ColumnHeader();
            Description = new ColumnHeader();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtbCategoryName
            // 
            txtbCategoryName.Location = new Point(76, 95);
            txtbCategoryName.Name = "txtbCategoryName";
            txtbCategoryName.Size = new Size(207, 27);
            txtbCategoryName.TabIndex = 0;
            // 
            // txtbCategoryDescription
            // 
            txtbCategoryDescription.Location = new Point(76, 169);
            txtbCategoryDescription.Name = "txtbCategoryDescription";
            txtbCategoryDescription.Size = new Size(207, 27);
            txtbCategoryDescription.TabIndex = 0;
            // 
            // btnAddContent
            // 
            btnAddContent.Location = new Point(108, 234);
            btnAddContent.Name = "btnAddContent";
            btnAddContent.Size = new Size(142, 52);
            btnAddContent.TabIndex = 1;
            btnAddContent.Text = "Add";
            btnAddContent.UseVisualStyleBackColor = true;
            btnAddContent.Click += btnAddContent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 60);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 134);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "Category Description:";
            // 
            // btnList
            // 
            btnList.Location = new Point(108, 367);
            btnList.Name = "btnList";
            btnList.Size = new Size(142, 52);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(108, 302);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(142, 52);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lboxCategories
            // 
            lboxCategories.FormattingEnabled = true;
            lboxCategories.Location = new Point(336, 95);
            lboxCategories.Name = "lboxCategories";
            lboxCategories.Size = new Size(451, 324);
            lboxCategories.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CategoryID, CategoryName, Description });
            listView1.Location = new Point(336, 469);
            listView1.Name = "listView1";
            listView1.Size = new Size(451, 366);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CategoryID
            // 
            CategoryID.Text = "CategoryID";
            CategoryID.Width = 175;
            // 
            // CategoryName
            // 
            CategoryName.Text = "CategoryName";
            CategoryName.Width = 175;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 175;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(108, 443);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 51);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 847);
            Controls.Add(btnUpdate);
            Controls.Add(listView1);
            Controls.Add(lboxCategories);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnList);
            Controls.Add(btnAddContent);
            Controls.Add(txtbCategoryDescription);
            Controls.Add(txtbCategoryName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbCategoryName;
        private TextBox txtbCategoryDescription;
        private Button btnAddContent;
        private Label label1;
        private Label label2;
        private Button btnList;
        private Button btnRemove;
        private ListBox lboxCategories;
        private ListView listView1;
        private ColumnHeader CategoryID;
        private ColumnHeader CategoryName;
        private ColumnHeader Description;
        private Button btnUpdate;
    }
}
