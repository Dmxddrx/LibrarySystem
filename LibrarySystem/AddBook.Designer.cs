
namespace LibrarySystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitleAddBook = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookPurchaseDate = new System.Windows.Forms.Label();
            this.lblBookPublication = new System.Windows.Forms.Label();
            this.lblBookAuthorName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.dateTimePurchase = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlBookDeatiles = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlBookDeatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.lblTitleAddBook);
            this.pnlTitle.Location = new System.Drawing.Point(3, 26);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(512, 44);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitleAddBook
            // 
            this.lblTitleAddBook.AutoSize = true;
            this.lblTitleAddBook.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleAddBook.Font = new System.Drawing.Font("Ubuntu Mono", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleAddBook.ForeColor = System.Drawing.Color.Black;
            this.lblTitleAddBook.Location = new System.Drawing.Point(160, 4);
            this.lblTitleAddBook.Name = "lblTitleAddBook";
            this.lblTitleAddBook.Size = new System.Drawing.Size(194, 26);
            this.lblTitleAddBook.TabIndex = 0;
            this.lblTitleAddBook.Text = "Add a New Book";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(28, 13);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(71, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookQuantity.Location = new System.Drawing.Point(28, 198);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(99, 17);
            this.lblBookQuantity.TabIndex = 1;
            this.lblBookQuantity.Text = "Book Quantity";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPrice.Location = new System.Drawing.Point(28, 161);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(78, 17);
            this.lblBookPrice.TabIndex = 2;
            this.lblBookPrice.Text = "Book Price";
            // 
            // lblBookPurchaseDate
            // 
            this.lblBookPurchaseDate.AutoSize = true;
            this.lblBookPurchaseDate.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPurchaseDate.Location = new System.Drawing.Point(28, 123);
            this.lblBookPurchaseDate.Name = "lblBookPurchaseDate";
            this.lblBookPurchaseDate.Size = new System.Drawing.Size(134, 17);
            this.lblBookPurchaseDate.TabIndex = 3;
            this.lblBookPurchaseDate.Text = "Book Purchase Date";
            // 
            // lblBookPublication
            // 
            this.lblBookPublication.AutoSize = true;
            this.lblBookPublication.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPublication.Location = new System.Drawing.Point(28, 87);
            this.lblBookPublication.Name = "lblBookPublication";
            this.lblBookPublication.Size = new System.Drawing.Size(120, 17);
            this.lblBookPublication.TabIndex = 4;
            this.lblBookPublication.Text = "Book Publication";
            // 
            // lblBookAuthorName
            // 
            this.lblBookAuthorName.AutoSize = true;
            this.lblBookAuthorName.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookAuthorName.Location = new System.Drawing.Point(28, 49);
            this.lblBookAuthorName.Name = "lblBookAuthorName";
            this.lblBookAuthorName.Size = new System.Drawing.Size(120, 17);
            this.lblBookAuthorName.TabIndex = 5;
            this.lblBookAuthorName.Text = "Book Author Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookName.Location = new System.Drawing.Point(168, 11);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(240, 23);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyDown);
            this.txtBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookName_KeyPress);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookPrice.Location = new System.Drawing.Point(168, 157);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(240, 23);
            this.txtBookPrice.TabIndex = 7;
            this.txtBookPrice.TextChanged += new System.EventHandler(this.txtBookPrice_TextChanged);
            this.txtBookPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookPrice_KeyDown);
            this.txtBookPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPrice_KeyPress);
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookQuantity.Location = new System.Drawing.Point(168, 194);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(240, 23);
            this.txtBookQuantity.TabIndex = 8;
            this.txtBookQuantity.TextChanged += new System.EventHandler(this.txtBookQuantity_TextChanged);
            this.txtBookQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookQuantity_KeyPress);
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookPublication.Location = new System.Drawing.Point(168, 83);
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(240, 23);
            this.txtBookPublication.TabIndex = 9;
            this.txtBookPublication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookPublication_KeyDown);
            this.txtBookPublication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPublication_KeyPress);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAuthorName.Location = new System.Drawing.Point(168, 46);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(240, 23);
            this.txtAuthorName.TabIndex = 10;
            this.txtAuthorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAuthorName_KeyDown);
            this.txtAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
            // 
            // dateTimePurchase
            // 
            this.dateTimePurchase.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePurchase.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePurchase.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePurchase.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePurchase.CalendarTrailingForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePurchase.Location = new System.Drawing.Point(168, 120);
            this.dateTimePurchase.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePurchase.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePurchase.Name = "dateTimePurchase";
            this.dateTimePurchase.Size = new System.Drawing.Size(240, 23);
            this.dateTimePurchase.TabIndex = 11;
            this.dateTimePurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePurchase_KeyDown);
            this.dateTimePurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePurchase_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(250, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(333, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(168, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlBookDeatiles
            // 
            this.pnlBookDeatiles.BackColor = System.Drawing.Color.Transparent;
            this.pnlBookDeatiles.Controls.Add(this.btnClear);
            this.pnlBookDeatiles.Controls.Add(this.btnCancel);
            this.pnlBookDeatiles.Controls.Add(this.btnSave);
            this.pnlBookDeatiles.Controls.Add(this.dateTimePurchase);
            this.pnlBookDeatiles.Controls.Add(this.txtAuthorName);
            this.pnlBookDeatiles.Controls.Add(this.txtBookPublication);
            this.pnlBookDeatiles.Controls.Add(this.txtBookQuantity);
            this.pnlBookDeatiles.Controls.Add(this.txtBookPrice);
            this.pnlBookDeatiles.Controls.Add(this.txtBookName);
            this.pnlBookDeatiles.Controls.Add(this.lblBookAuthorName);
            this.pnlBookDeatiles.Controls.Add(this.lblBookPublication);
            this.pnlBookDeatiles.Controls.Add(this.lblBookPurchaseDate);
            this.pnlBookDeatiles.Controls.Add(this.lblBookPrice);
            this.pnlBookDeatiles.Controls.Add(this.lblBookQuantity);
            this.pnlBookDeatiles.Controls.Add(this.lblBookName);
            this.pnlBookDeatiles.Location = new System.Drawing.Point(47, 192);
            this.pnlBookDeatiles.Name = "pnlBookDeatiles";
            this.pnlBookDeatiles.Size = new System.Drawing.Size(420, 270);
            this.pnlBookDeatiles.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(517, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlBookDeatiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooks ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddBook_Load);
       
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlBookDeatiles.ResumeLayout(false);
            this.pnlBookDeatiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitleAddBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookPurchaseDate;
        private System.Windows.Forms.Label lblBookPublication;
        private System.Windows.Forms.Label lblBookAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.DateTimePicker dateTimePurchase;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlBookDeatiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}