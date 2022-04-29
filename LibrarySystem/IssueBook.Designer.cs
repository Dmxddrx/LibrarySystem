
namespace LibrarySystem
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblViewBooks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchEnroll1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblenterenroll = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnexit2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnexit2);
            this.panel1.Controls.Add(this.lblViewBooks);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 104);
            this.panel1.TabIndex = 0;
            // 
            // lblViewBooks
            // 
            this.lblViewBooks.AutoSize = true;
            this.lblViewBooks.Font = new System.Drawing.Font("Ubuntu Mono", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewBooks.Location = new System.Drawing.Point(280, 38);
            this.lblViewBooks.Name = "lblViewBooks";
            this.lblViewBooks.Size = new System.Drawing.Size(178, 29);
            this.lblViewBooks.TabIndex = 2;
            this.lblViewBooks.Text = "Issue Books";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtSearchEnroll1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblenterenroll);
            this.panel2.Location = new System.Drawing.Point(10, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 338);
            this.panel2.TabIndex = 1;
            // 
            // txtSearchEnroll1
            // 
            this.txtSearchEnroll1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchEnroll1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtSearchEnroll1.FormattingEnabled = true;
            this.txtSearchEnroll1.Location = new System.Drawing.Point(32, 179);
            this.txtSearchEnroll1.Name = "txtSearchEnroll1";
            this.txtSearchEnroll1.Size = new System.Drawing.Size(222, 23);
            this.txtSearchEnroll1.TabIndex = 19;
            this.txtSearchEnroll1.TextChanged += new System.EventHandler(this.combobox_TextChanged);
            this.txtSearchEnroll1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEnroll1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(179, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(32, 286);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(81, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 35);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblenterenroll
            // 
            this.lblenterenroll.AutoSize = true;
            this.lblenterenroll.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblenterenroll.Location = new System.Drawing.Point(54, 145);
            this.lblenterenroll.Name = "lblenterenroll";
            this.lblenterenroll.Size = new System.Drawing.Size(179, 18);
            this.lblenterenroll.TabIndex = 2;
            this.lblenterenroll.Text = "Enter Enrollment NO";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtIssueDate);
            this.panel3.Controls.Add(this.cmbBookName);
            this.panel3.Controls.Add(this.txtStdName);
            this.panel3.Controls.Add(this.txtDep);
            this.panel3.Controls.Add(this.txtSem);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtContact);
            this.panel3.Controls.Add(this.btnIssueBook);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblBookName);
            this.panel3.Location = new System.Drawing.Point(298, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 338);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(108, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Maximum 3 Books Can be ISSUED to 1 Student.";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssueDate.Location = new System.Drawing.Point(185, 255);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(222, 23);
            this.txtIssueDate.TabIndex = 24;
            this.txtIssueDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssueDate_KeyPress);
            // 
            // cmbBookName
            // 
            this.cmbBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(185, 216);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(222, 23);
            this.cmbBookName.TabIndex = 23;
            this.cmbBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBookName_KeyPress);
            // 
            // txtStdName
            // 
            this.txtStdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdName.Location = new System.Drawing.Point(185, 21);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.ReadOnly = true;
            this.txtStdName.Size = new System.Drawing.Size(222, 23);
            this.txtStdName.TabIndex = 22;
            // 
            // txtDep
            // 
            this.txtDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDep.Location = new System.Drawing.Point(185, 60);
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(222, 23);
            this.txtDep.TabIndex = 21;
            // 
            // txtSem
            // 
            this.txtSem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSem.Location = new System.Drawing.Point(185, 99);
            this.txtSem.Name = "txtSem";
            this.txtSem.ReadOnly = true;
            this.txtSem.Size = new System.Drawing.Size(222, 23);
            this.txtSem.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(185, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(222, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(185, 138);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(222, 23);
            this.txtContact.TabIndex = 18;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssueBook.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueBook.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBook.Location = new System.Drawing.Point(307, 290);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(100, 27);
            this.btnIssueBook.TabIndex = 17;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books Name";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.Location = new System.Drawing.Point(39, 258);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(128, 18);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Issue Date";
            // 
            // btnexit2
            // 
            this.btnexit2.BackColor = System.Drawing.Color.Transparent;
            this.btnexit2.FlatAppearance.BorderSize = 0;
            this.btnexit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit2.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit2.ForeColor = System.Drawing.Color.Black;
            this.btnexit2.Location = new System.Drawing.Point(653, 2);
            this.btnexit2.Name = "btnexit2";
            this.btnexit2.Size = new System.Drawing.Size(75, 31);
            this.btnexit2.TabIndex = 28;
            this.btnexit2.Text = "Exit";
            this.btnexit2.UseVisualStyleBackColor = false;
            this.btnexit2.Click += new System.EventHandler(this.btnexit2_Click);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblViewBooks;
        private System.Windows.Forms.Label lblenterenroll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtIssueDate;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox txtSearchEnroll1;
        private System.Windows.Forms.Button btnexit2;
    }
}