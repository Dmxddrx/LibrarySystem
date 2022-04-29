
namespace LibrarySystem
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlDeatiles = new System.Windows.Forms.Panel();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEnrlNO = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEnrlNO = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvidercontact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvideremail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidersemester = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlDeatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercontact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersemester)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.lbltitle);
            this.pnlTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitle.Location = new System.Drawing.Point(40, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(439, 63);
            this.pnlTitle.TabIndex = 0;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Ubuntu Mono", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.Black;
            this.lbltitle.Location = new System.Drawing.Point(109, 21);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(233, 26);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Add a new Student";
            // 
            // pnlDeatiles
            // 
            this.pnlDeatiles.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeatiles.Controls.Add(this.cmbSemester);
            this.pnlDeatiles.Controls.Add(this.btnSave);
            this.pnlDeatiles.Controls.Add(this.btnExit);
            this.pnlDeatiles.Controls.Add(this.btnRefresh);
            this.pnlDeatiles.Controls.Add(this.txtEnrlNO);
            this.pnlDeatiles.Controls.Add(this.txtdepartment);
            this.pnlDeatiles.Controls.Add(this.txtEmail);
            this.pnlDeatiles.Controls.Add(this.txtContact);
            this.pnlDeatiles.Controls.Add(this.txtName);
            this.pnlDeatiles.Controls.Add(this.lblEnrlNO);
            this.pnlDeatiles.Controls.Add(this.lblDepartment);
            this.pnlDeatiles.Controls.Add(this.lblSemester);
            this.pnlDeatiles.Controls.Add(this.lblContact);
            this.pnlDeatiles.Controls.Add(this.lblEmail);
            this.pnlDeatiles.Controls.Add(this.lblStudentName);
            this.pnlDeatiles.Location = new System.Drawing.Point(40, 148);
            this.pnlDeatiles.Name = "pnlDeatiles";
            this.pnlDeatiles.Size = new System.Drawing.Size(439, 339);
            this.pnlDeatiles.TabIndex = 1;
            // 
            // cmbSemester
            // 
            this.cmbSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "1st year",
            "2nd year",
            "3rd year",
            "4th year",
            "Final year",
            "Primery student",
            "Junior",
            "Senior",
            "Other",
            "**no entry?Type your own**"});
            this.cmbSemester.Location = new System.Drawing.Point(154, 146);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(240, 23);
            this.cmbSemester.TabIndex = 15;
            this.cmbSemester.Text = "1st ,2nd,3rd ...";
            this.cmbSemester.TextChanged += new System.EventHandler(this.cmbSemester_TextChanged);
            this.cmbSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSemester_KeyPress);
            this.cmbSemester.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbSemester_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(218, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save info";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(319, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(116, 287);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtEnrlNO
            // 
            this.txtEnrlNO.Location = new System.Drawing.Point(154, 65);
            this.txtEnrlNO.Name = "txtEnrlNO";
            this.txtEnrlNO.Size = new System.Drawing.Size(240, 23);
            this.txtEnrlNO.TabIndex = 11;
            this.txtEnrlNO.Text = "This is an Index number";
            this.txtEnrlNO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEnrlNO_MouseClick);
            this.txtEnrlNO.TextChanged += new System.EventHandler(this.txtEnrlNO_TextChanged);
            this.txtEnrlNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnrlNO_KeyPress);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(154, 106);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(240, 23);
            this.txtdepartment.TabIndex = 10;
            this.txtdepartment.Text = "like School or Work place";
            this.txtdepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdepartment_MouseClick);
            this.txtdepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdepartment_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "example@gmail.com";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(154, 186);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(240, 23);
            this.txtContact.TabIndex = 8;
            this.txtContact.Text = "+94 7X XXXX XXX";
            this.txtContact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContact_MouseClick);
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 23);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "eg; Dinindu Malinda";
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblEnrlNO
            // 
            this.lblEnrlNO.AutoSize = true;
            this.lblEnrlNO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlNO.Location = new System.Drawing.Point(22, 67);
            this.lblEnrlNO.Name = "lblEnrlNO";
            this.lblEnrlNO.Size = new System.Drawing.Size(104, 19);
            this.lblEnrlNO.TabIndex = 5;
            this.lblEnrlNO.Text = "Enrollment NO";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(22, 107);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(86, 19);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSemester.Location = new System.Drawing.Point(22, 147);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(122, 19);
            this.lblSemester.TabIndex = 3;
            this.lblSemester.Text = "Student Semester";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(22, 187);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(112, 19);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Student Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(22, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Student Email";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(22, 27);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(100, 19);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvidercontact
            // 
            this.errorProvidercontact.ContainerControl = this;
            // 
            // errorProvideremail
            // 
            this.errorProvideremail.ContainerControl = this;
            // 
            // errorProvidersemester
            // 
            this.errorProvidersemester.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlDeatiles);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDeatiles.ResumeLayout(false);
            this.pnlDeatiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercontact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideremail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlDeatiles;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEnrlNO;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEnrlNO;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvidercontact;
        private System.Windows.Forms.ErrorProvider errorProvideremail;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ErrorProvider errorProvidersemester;
    }
}