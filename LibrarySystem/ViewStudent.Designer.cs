
namespace LibrarySystem
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picboxViewStu = new System.Windows.Forms.PictureBox();
            this.lblViewStudents = new System.Windows.Forms.Label();
            this.lblsearchEnroll = new System.Windows.Forms.Label();
            this.txtSearchStudentName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.pnlEditAddSudent = new System.Windows.Forms.Panel();
            this.txtSemes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtEnrll = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEnrlNo = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnAddstudent = new System.Windows.Forms.Button();
            this.pnlexit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxViewStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.pnlEditAddSudent.SuspendLayout();
            this.pnlexit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoScroll = true;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.picboxViewStu);
            this.pnlTitle.Controls.Add(this.lblViewStudents);
            this.pnlTitle.Location = new System.Drawing.Point(9, 6);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(668, 68);
            this.pnlTitle.TabIndex = 1;
            // 
            // picboxViewStu
            // 
            this.picboxViewStu.Image = ((System.Drawing.Image)(resources.GetObject("picboxViewStu.Image")));
            this.picboxViewStu.Location = new System.Drawing.Point(82, 0);
            this.picboxViewStu.Name = "picboxViewStu";
            this.picboxViewStu.Size = new System.Drawing.Size(89, 68);
            this.picboxViewStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxViewStu.TabIndex = 1;
            this.picboxViewStu.TabStop = false;
            // 
            // lblViewStudents
            // 
            this.lblViewStudents.AutoSize = true;
            this.lblViewStudents.Font = new System.Drawing.Font("Ubuntu Mono", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewStudents.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblViewStudents.Location = new System.Drawing.Point(331, 18);
            this.lblViewStudents.Name = "lblViewStudents";
            this.lblViewStudents.Size = new System.Drawing.Size(208, 29);
            this.lblViewStudents.TabIndex = 0;
            this.lblViewStudents.Text = "View Students";
            // 
            // lblsearchEnroll
            // 
            this.lblsearchEnroll.AutoSize = true;
            this.lblsearchEnroll.BackColor = System.Drawing.Color.Transparent;
            this.lblsearchEnroll.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsearchEnroll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblsearchEnroll.Location = new System.Drawing.Point(190, 83);
            this.lblsearchEnroll.Name = "lblsearchEnroll";
            this.lblsearchEnroll.Size = new System.Drawing.Size(100, 18);
            this.lblsearchEnroll.TabIndex = 2;
            this.lblsearchEnroll.Text = "Enrollment NO";
            // 
            // txtSearchStudentName
            // 
            this.txtSearchStudentName.Location = new System.Drawing.Point(294, 80);
            this.txtSearchStudentName.Name = "txtSearchStudentName";
            this.txtSearchStudentName.Size = new System.Drawing.Size(233, 23);
            this.txtSearchStudentName.TabIndex = 3;
            this.txtSearchStudentName.TextChanged += new System.EventHandler(this.txtSearchStudentName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(549, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(9, 110);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowTemplate.Height = 25;
            this.dataGridViewStudents.Size = new System.Drawing.Size(800, 198);
            this.dataGridViewStudents.TabIndex = 5;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            this.dataGridViewStudents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudents_ColumnHeaderMouseClick);
            // 
            // pnlEditAddSudent
            // 
            this.pnlEditAddSudent.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditAddSudent.Controls.Add(this.txtSemes);
            this.pnlEditAddSudent.Controls.Add(this.btnCancel);
            this.pnlEditAddSudent.Controls.Add(this.btnDelete);
            this.pnlEditAddSudent.Controls.Add(this.btnUpdate);
            this.pnlEditAddSudent.Controls.Add(this.txtCon);
            this.pnlEditAddSudent.Controls.Add(this.txtEmail);
            this.pnlEditAddSudent.Controls.Add(this.txtStuName);
            this.pnlEditAddSudent.Controls.Add(this.txtEnrll);
            this.pnlEditAddSudent.Controls.Add(this.txtDep);
            this.pnlEditAddSudent.Controls.Add(this.lblEmail);
            this.pnlEditAddSudent.Controls.Add(this.lblContact);
            this.pnlEditAddSudent.Controls.Add(this.lblSemester);
            this.pnlEditAddSudent.Controls.Add(this.lblDepartment);
            this.pnlEditAddSudent.Controls.Add(this.lblEnrlNo);
            this.pnlEditAddSudent.Controls.Add(this.lblStudentName);
            this.pnlEditAddSudent.Location = new System.Drawing.Point(9, 324);
            this.pnlEditAddSudent.Name = "pnlEditAddSudent";
            this.pnlEditAddSudent.Size = new System.Drawing.Size(800, 222);
            this.pnlEditAddSudent.TabIndex = 6;
            // 
            // txtSemes
            // 
            this.txtSemes.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSemes.Location = new System.Drawing.Point(542, 29);
            this.txtSemes.Name = "txtSemes";
            this.txtSemes.Size = new System.Drawing.Size(222, 19);
            this.txtSemes.TabIndex = 20;
            this.txtSemes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSemes_KeyDown);
            this.txtSemes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemes_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(669, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(569, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(469, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCon
            // 
            this.txtCon.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCon.Location = new System.Drawing.Point(542, 67);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(222, 19);
            this.txtCon.TabIndex = 15;
            this.txtCon.TextChanged += new System.EventHandler(this.txtCon_TextChanged);
            this.txtCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCon_KeyDown);
            this.txtCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCon_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(542, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 19);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStuName.Location = new System.Drawing.Point(134, 29);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(222, 19);
            this.txtStuName.TabIndex = 13;
            this.txtStuName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStuName_KeyDown);
            this.txtStuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStuName_KeyPress);
            // 
            // txtEnrll
            // 
            this.txtEnrll.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnrll.Location = new System.Drawing.Point(134, 67);
            this.txtEnrll.Name = "txtEnrll";
            this.txtEnrll.Size = new System.Drawing.Size(222, 19);
            this.txtEnrll.TabIndex = 12;
            this.txtEnrll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnrll_KeyDown);
            this.txtEnrll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnrll_KeyPress);
            // 
            // txtDep
            // 
            this.txtDep.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDep.Location = new System.Drawing.Point(134, 105);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(222, 19);
            this.txtDep.TabIndex = 11;
            this.txtDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDep_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(405, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(112, 18);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Student Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(405, 70);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(128, 18);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Student Contact";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSemester.Location = new System.Drawing.Point(405, 31);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(136, 18);
            this.lblSemester.TabIndex = 8;
            this.lblSemester.Text = "Student Semester";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(6, 106);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(88, 18);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // lblEnrlNo
            // 
            this.lblEnrlNo.AutoSize = true;
            this.lblEnrlNo.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlNo.Location = new System.Drawing.Point(6, 69);
            this.lblEnrlNo.Name = "lblEnrlNo";
            this.lblEnrlNo.Size = new System.Drawing.Size(112, 18);
            this.lblEnrlNo.TabIndex = 6;
            this.lblEnrlNo.Text = "Enrollment NO";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(6, 31);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(104, 18);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // btnAddstudent
            // 
            this.btnAddstudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddstudent.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddstudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddstudent.Location = new System.Drawing.Point(639, 81);
            this.btnAddstudent.Name = "btnAddstudent";
            this.btnAddstudent.Size = new System.Drawing.Size(114, 23);
            this.btnAddstudent.TabIndex = 21;
            this.btnAddstudent.Text = "Add a Student";
            this.btnAddstudent.UseVisualStyleBackColor = false;
            this.btnAddstudent.Click += new System.EventHandler(this.btnAddstudent_Click);
            // 
            // pnlexit
            // 
            this.pnlexit.BackColor = System.Drawing.Color.Transparent;
            this.pnlexit.Controls.Add(this.btnExit);
            this.pnlexit.Location = new System.Drawing.Point(683, 6);
            this.pnlexit.Name = "pnlexit";
            this.pnlexit.Size = new System.Drawing.Size(132, 68);
            this.pnlexit.TabIndex = 22;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(55, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.pnlexit);
            this.Controls.Add(this.btnAddstudent);
            this.Controls.Add(this.pnlEditAddSudent);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchStudentName);
            this.Controls.Add(this.lblsearchEnroll);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxViewStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.pnlEditAddSudent.ResumeLayout(false);
            this.pnlEditAddSudent.PerformLayout();
            this.pnlexit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblViewStudents;
        private System.Windows.Forms.Label lblsearchEnroll;
        private System.Windows.Forms.TextBox txtSearchStudentName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Panel pnlEditAddSudent;
        private System.Windows.Forms.TextBox txtSemes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtEnrll;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEnrlNo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.PictureBox picboxViewStu;
        private System.Windows.Forms.Button btnAddstudent;
        private System.Windows.Forms.Panel pnlexit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
    }
}