namespace _10_StudentsHomeWork_CreateReadUpdateDelete
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
            txtbFirstName = new TextBox();
            txtbLastName = new TextBox();
            txtbEmail = new TextBox();
            txtbPhoneNumber = new TextBox();
            txtbTCKNO = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            combSex = new ComboBox();
            combField = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtbFirstName
            // 
            txtbFirstName.Location = new Point(74, 64);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(250, 27);
            txtbFirstName.TabIndex = 0;
            txtbFirstName.KeyPress += txtbFirstName_KeyPress;
            // 
            // txtbLastName
            // 
            txtbLastName.Location = new Point(74, 121);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(250, 27);
            txtbLastName.TabIndex = 1;
            txtbLastName.KeyPress += txtbFirstName_KeyPress;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(74, 178);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(250, 27);
            txtbEmail.TabIndex = 2;
            // 
            // txtbPhoneNumber
            // 
            txtbPhoneNumber.Location = new Point(74, 235);
            txtbPhoneNumber.Name = "txtbPhoneNumber";
            txtbPhoneNumber.Size = new Size(250, 27);
            txtbPhoneNumber.TabIndex = 3;
            txtbPhoneNumber.KeyPress += txtbTCKNO_KeyPress;
            // 
            // txtbTCKNO
            // 
            txtbTCKNO.Location = new Point(74, 292);
            txtbTCKNO.Name = "txtbTCKNO";
            txtbTCKNO.Size = new Size(250, 27);
            txtbTCKNO.TabIndex = 4;
            txtbTCKNO.KeyPress += txtbTCKNO_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 153);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 210);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 1;
            label4.Text = "Phone number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 267);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 1;
            label5.Text = "TCKNO:";
            // 
            // combSex
            // 
            combSex.FormattingEnabled = true;
            combSex.Location = new Point(74, 349);
            combSex.Name = "combSex";
            combSex.Size = new Size(250, 28);
            combSex.TabIndex = 5;
            combSex.KeyPress += combSex_KeyPress;
            // 
            // combField
            // 
            combField.FormattingEnabled = true;
            combField.Location = new Point(74, 407);
            combField.Name = "combField";
            combField.Size = new Size(250, 28);
            combField.TabIndex = 6;
            combField.KeyPress += combSex_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 465);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 324);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 1;
            label6.Text = "Sex:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 382);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 1;
            label7.Text = "Field";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 440);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 1;
            label8.Text = "Birthdate:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.Location = new Point(341, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(839, 428);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "StudentID:";
            columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First name:";
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last name:";
            columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email:";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone number:";
            columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TCKNO:";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Sex:";
            columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Field Name:";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Birthdate:";
            columnHeader9.Width = 90;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(341, 514);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(149, 42);
            btnRead.TabIndex = 9;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(74, 514);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(831, 514);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 594);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(listView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(combField);
            Controls.Add(combSex);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbTCKNO);
            Controls.Add(txtbPhoneNumber);
            Controls.Add(txtbEmail);
            Controls.Add(txtbLastName);
            Controls.Add(txtbFirstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbFirstName;
        private TextBox txtbLastName;
        private TextBox txtbEmail;
        private TextBox txtbPhoneNumber;
        private TextBox txtbTCKNO;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox combSex;
        private ComboBox combField;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
