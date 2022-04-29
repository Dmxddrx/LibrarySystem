
namespace LibrarySystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStripDashboard = new System.Windows.Forms.MenuStrip();
            this.menuToolBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolAddNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolViewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolViewStudentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolIsuueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolCompleteBookDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDashboard
            // 
            this.menuStripDashboard.BackColor = System.Drawing.Color.Wheat;
            this.menuStripDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolBooks,
            this.menuToolStudent,
            this.menuToolIsuueBook,
            this.menuToolReturnBook,
            this.menuToolCompleteBookDetails,
            this.menuToolExit});
            this.menuStripDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuStripDashboard.Name = "menuStripDashboard";
            this.menuStripDashboard.Size = new System.Drawing.Size(1092, 58);
            this.menuStripDashboard.TabIndex = 0;
            this.menuStripDashboard.Text = "menuStripDashboard";
            // 
            // menuToolBooks
            // 
            this.menuToolBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuToolBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolAddNewBook,
            this.menuToolViewBooks});
            this.menuToolBooks.Image = ((System.Drawing.Image)(resources.GetObject("menuToolBooks.Image")));
            this.menuToolBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolBooks.Name = "menuToolBooks";
            this.menuToolBooks.Size = new System.Drawing.Size(101, 54);
            this.menuToolBooks.Text = "Books";
            // 
            // menuToolAddNewBook
            // 
            this.menuToolAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("menuToolAddNewBook.Image")));
            this.menuToolAddNewBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolAddNewBook.Name = "menuToolAddNewBook";
            this.menuToolAddNewBook.Size = new System.Drawing.Size(187, 56);
            this.menuToolAddNewBook.Text = "Add New Book";
            this.menuToolAddNewBook.Click += new System.EventHandler(this.menuToolAddNewBook_Click);
            // 
            // menuToolViewBooks
            // 
            this.menuToolViewBooks.Image = ((System.Drawing.Image)(resources.GetObject("menuToolViewBooks.Image")));
            this.menuToolViewBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolViewBooks.Name = "menuToolViewBooks";
            this.menuToolViewBooks.Size = new System.Drawing.Size(187, 56);
            this.menuToolViewBooks.Text = "View Books";
            this.menuToolViewBooks.Click += new System.EventHandler(this.menuToolViewBooks_Click);
            // 
            // menuToolStudent
            // 
            this.menuToolStudent.BackColor = System.Drawing.Color.OldLace;
            this.menuToolStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolAddStudent,
            this.menuToolViewStudentInfo});
            this.menuToolStudent.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStudent.Image")));
            this.menuToolStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolStudent.Name = "menuToolStudent";
            this.menuToolStudent.Size = new System.Drawing.Size(110, 54);
            this.menuToolStudent.Text = "Student";
            // 
            // menuToolAddStudent
            // 
            this.menuToolAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("menuToolAddStudent.Image")));
            this.menuToolAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolAddStudent.Name = "menuToolAddStudent";
            this.menuToolAddStudent.Size = new System.Drawing.Size(201, 56);
            this.menuToolAddStudent.Text = "Add Student";
            this.menuToolAddStudent.Click += new System.EventHandler(this.menuToolAddStudent_Click);
            // 
            // menuToolViewStudentInfo
            // 
            this.menuToolViewStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("menuToolViewStudentInfo.Image")));
            this.menuToolViewStudentInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolViewStudentInfo.Name = "menuToolViewStudentInfo";
            this.menuToolViewStudentInfo.Size = new System.Drawing.Size(201, 56);
            this.menuToolViewStudentInfo.Text = "View Student Info";
            this.menuToolViewStudentInfo.Click += new System.EventHandler(this.menuToolViewStudentInfo_Click);
            // 
            // menuToolIsuueBook
            // 
            this.menuToolIsuueBook.Image = ((System.Drawing.Image)(resources.GetObject("menuToolIsuueBook.Image")));
            this.menuToolIsuueBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolIsuueBook.Name = "menuToolIsuueBook";
            this.menuToolIsuueBook.Size = new System.Drawing.Size(125, 54);
            this.menuToolIsuueBook.Text = "Issue Book";
            this.menuToolIsuueBook.Click += new System.EventHandler(this.menuToolIsuueBook_Click);
            // 
            // menuToolReturnBook
            // 
            this.menuToolReturnBook.BackColor = System.Drawing.Color.OldLace;
            this.menuToolReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("menuToolReturnBook.Image")));
            this.menuToolReturnBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolReturnBook.Name = "menuToolReturnBook";
            this.menuToolReturnBook.Size = new System.Drawing.Size(134, 54);
            this.menuToolReturnBook.Text = "Return Book";
            this.menuToolReturnBook.Click += new System.EventHandler(this.menuToolReturnBook_Click);
            // 
            // menuToolCompleteBookDetails
            // 
            this.menuToolCompleteBookDetails.Image = ((System.Drawing.Image)(resources.GetObject("menuToolCompleteBookDetails.Image")));
            this.menuToolCompleteBookDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolCompleteBookDetails.Name = "menuToolCompleteBookDetails";
            this.menuToolCompleteBookDetails.Size = new System.Drawing.Size(182, 54);
            this.menuToolCompleteBookDetails.Text = "Complete Book Details";
            this.menuToolCompleteBookDetails.Click += new System.EventHandler(this.menuToolCompleteBookDetails_Click);
            // 
            // menuToolExit
            // 
            this.menuToolExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuToolExit.BackColor = System.Drawing.Color.FloralWhite;
            this.menuToolExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuToolExit.ForeColor = System.Drawing.Color.Red;
            this.menuToolExit.Image = ((System.Drawing.Image)(resources.GetObject("menuToolExit.Image")));
            this.menuToolExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuToolExit.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.menuToolExit.Name = "menuToolExit";
            this.menuToolExit.Size = new System.Drawing.Size(95, 54);
            this.menuToolExit.Text = "Exit";
            this.menuToolExit.Click += new System.EventHandler(this.menuToolExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 515);
            this.Controls.Add(this.menuStripDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripDashboard;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStripDashboard.ResumeLayout(false);
            this.menuStripDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuToolBooks;
        private System.Windows.Forms.ToolStripMenuItem menuToolAddNewBook;
        private System.Windows.Forms.ToolStripMenuItem menuToolViewBooks;
        private System.Windows.Forms.ToolStripMenuItem menuToolStudent;
        private System.Windows.Forms.ToolStripMenuItem menuToolAddStudent;
        private System.Windows.Forms.ToolStripMenuItem menuToolViewStudentInfo;
        private System.Windows.Forms.ToolStripMenuItem menuToolIsuueBook;
        private System.Windows.Forms.ToolStripMenuItem menuToolReturnBook;
        private System.Windows.Forms.ToolStripMenuItem menuToolCompleteBookDetails;
        private System.Windows.Forms.ToolStripMenuItem menuToolExit;
    }
}