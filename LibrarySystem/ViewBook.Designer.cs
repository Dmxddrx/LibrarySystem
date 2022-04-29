
namespace LibrarySystem
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblViewBooks = new System.Windows.Forms.Label();
            this.lblsearchBookName = new System.Windows.Forms.Label();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.pnlEditAddBook = new System.Windows.Forms.Panel();
            this.txtbookPurchaseDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookPurchaseDate = new System.Windows.Forms.Label();
            this.lblBookPublication = new System.Windows.Forms.Label();
            this.lblBookAuthorName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnAddbook = new System.Windows.Forms.Button();
            this.pnlexit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.pnlEditAddBook.SuspendLayout();
            this.pnlexit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoScroll = true;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.lblViewBooks);
            this.pnlTitle.Location = new System.Drawing.Point(0, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(669, 68);
            this.pnlTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblViewBooks
            // 
            this.lblViewBooks.AutoSize = true;
            this.lblViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblViewBooks.Font = new System.Drawing.Font("Ubuntu Mono", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblViewBooks.ForeColor = System.Drawing.Color.Black;
            this.lblViewBooks.Location = new System.Drawing.Point(378, 17);
            this.lblViewBooks.Name = "lblViewBooks";
            this.lblViewBooks.Size = new System.Drawing.Size(163, 29);
            this.lblViewBooks.TabIndex = 0;
            this.lblViewBooks.Text = "View Books";
            // 
            // lblsearchBookName
            // 
            this.lblsearchBookName.AutoSize = true;
            this.lblsearchBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblsearchBookName.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsearchBookName.ForeColor = System.Drawing.Color.Black;
            this.lblsearchBookName.Location = new System.Drawing.Point(166, 89);
            this.lblsearchBookName.Name = "lblsearchBookName";
            this.lblsearchBookName.Size = new System.Drawing.Size(71, 17);
            this.lblsearchBookName.TabIndex = 1;
            this.lblsearchBookName.Text = "Book Name";
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.Location = new System.Drawing.Point(261, 86);
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(233, 23);
            this.txtSearchBookName.TabIndex = 2;
            this.txtSearchBookName.TextChanged += new System.EventHandler(this.txtSearchBookName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(517, 86);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.Size = new System.Drawing.Size(776, 198);
            this.dataGridViewBooks.TabIndex = 4;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            this.dataGridViewBooks.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_ColumnHeaderMouseClick);
            this.dataGridViewBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_RowHeaderMouseClick);
            // 
            // pnlEditAddBook
            // 
            this.pnlEditAddBook.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditAddBook.Controls.Add(this.txtbookPurchaseDate);
            this.pnlEditAddBook.Controls.Add(this.btnCancel);
            this.pnlEditAddBook.Controls.Add(this.btnDelete);
            this.pnlEditAddBook.Controls.Add(this.btnUpdate);
            this.pnlEditAddBook.Controls.Add(this.txtBookPrice);
            this.pnlEditAddBook.Controls.Add(this.txtBookQuantity);
            this.pnlEditAddBook.Controls.Add(this.txtBookName);
            this.pnlEditAddBook.Controls.Add(this.txtBookAuthorName);
            this.pnlEditAddBook.Controls.Add(this.txtBookPublication);
            this.pnlEditAddBook.Controls.Add(this.lblBookQuantity);
            this.pnlEditAddBook.Controls.Add(this.lblBookPrice);
            this.pnlEditAddBook.Controls.Add(this.lblBookPurchaseDate);
            this.pnlEditAddBook.Controls.Add(this.lblBookPublication);
            this.pnlEditAddBook.Controls.Add(this.lblBookAuthorName);
            this.pnlEditAddBook.Controls.Add(this.lblBookName);
            this.pnlEditAddBook.Location = new System.Drawing.Point(12, 320);
            this.pnlEditAddBook.Name = "pnlEditAddBook";
            this.pnlEditAddBook.Size = new System.Drawing.Size(776, 222);
            this.pnlEditAddBook.TabIndex = 5;
            // 
            // txtbookPurchaseDate
            // 
            this.txtbookPurchaseDate.Location = new System.Drawing.Point(537, 29);
            this.txtbookPurchaseDate.Name = "txtbookPurchaseDate";
            this.txtbookPurchaseDate.Size = new System.Drawing.Size(222, 23);
            this.txtbookPurchaseDate.TabIndex = 20;
            this.txtbookPurchaseDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbookPurchaseDate_KeyDown);
            this.txtbookPurchaseDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookPurchaseDate_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(682, 167);
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
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(582, 167);
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
            this.btnUpdate.Location = new System.Drawing.Point(482, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(537, 67);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(222, 23);
            this.txtBookPrice.TabIndex = 15;
            this.txtBookPrice.TextChanged += new System.EventHandler(this.txtBookPrice_TextChanged);
            this.txtBookPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookPrice_KeyDown);
            this.txtBookPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPrice_KeyPress);
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(537, 105);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(222, 23);
            this.txtBookQuantity.TabIndex = 14;
            this.txtBookQuantity.TextChanged += new System.EventHandler(this.txtBookQuantity_TextChanged);
            this.txtBookQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookQuantity_KeyPress);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(140, 29);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(222, 23);
            this.txtBookName.TabIndex = 13;
            this.txtBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyDown);
            this.txtBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookName_KeyPress);
            // 
            // txtBookAuthorName
            // 
            this.txtBookAuthorName.Location = new System.Drawing.Point(140, 67);
            this.txtBookAuthorName.Name = "txtBookAuthorName";
            this.txtBookAuthorName.Size = new System.Drawing.Size(222, 23);
            this.txtBookAuthorName.TabIndex = 12;
            this.txtBookAuthorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookAuthorName_KeyDown);
            this.txtBookAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookAuthorName_KeyPress);
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Location = new System.Drawing.Point(140, 105);
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(222, 23);
            this.txtBookPublication.TabIndex = 11;
            this.txtBookPublication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPublication_KeyPress);
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblBookQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBookQuantity.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblBookQuantity.Location = new System.Drawing.Point(388, 107);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(112, 18);
            this.lblBookQuantity.TabIndex = 10;
            this.lblBookQuantity.Text = "Book Quantity";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPrice.Location = new System.Drawing.Point(388, 70);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(88, 18);
            this.lblBookPrice.TabIndex = 9;
            this.lblBookPrice.Text = "Book Price";
            // 
            // lblBookPurchaseDate
            // 
            this.lblBookPurchaseDate.AutoSize = true;
            this.lblBookPurchaseDate.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPurchaseDate.Location = new System.Drawing.Point(388, 31);
            this.lblBookPurchaseDate.Name = "lblBookPurchaseDate";
            this.lblBookPurchaseDate.Size = new System.Drawing.Size(152, 18);
            this.lblBookPurchaseDate.TabIndex = 8;
            this.lblBookPurchaseDate.Text = "Book Purchase Date";
            // 
            // lblBookPublication
            // 
            this.lblBookPublication.AutoSize = true;
            this.lblBookPublication.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPublication.Location = new System.Drawing.Point(6, 106);
            this.lblBookPublication.Name = "lblBookPublication";
            this.lblBookPublication.Size = new System.Drawing.Size(136, 18);
            this.lblBookPublication.TabIndex = 7;
            this.lblBookPublication.Text = "Book Publication";
            // 
            // lblBookAuthorName
            // 
            this.lblBookAuthorName.AutoSize = true;
            this.lblBookAuthorName.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookAuthorName.Location = new System.Drawing.Point(6, 69);
            this.lblBookAuthorName.Name = "lblBookAuthorName";
            this.lblBookAuthorName.Size = new System.Drawing.Size(136, 18);
            this.lblBookAuthorName.TabIndex = 6;
            this.lblBookAuthorName.Text = "Book Author Name";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.Location = new System.Drawing.Point(6, 31);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(80, 18);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Book Name";
            // 
            // btnAddbook
            // 
            this.btnAddbook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddbook.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddbook.ForeColor = System.Drawing.Color.Black;
            this.btnAddbook.Location = new System.Drawing.Point(611, 86);
            this.btnAddbook.Name = "btnAddbook";
            this.btnAddbook.Size = new System.Drawing.Size(114, 23);
            this.btnAddbook.TabIndex = 22;
            this.btnAddbook.Text = "Add a Book";
            this.btnAddbook.UseVisualStyleBackColor = false;
            this.btnAddbook.Click += new System.EventHandler(this.btnAddbook_Click);
            // 
            // pnlexit
            // 
            this.pnlexit.BackColor = System.Drawing.Color.Transparent;
            this.pnlexit.Controls.Add(this.btnExit);
            this.pnlexit.Location = new System.Drawing.Point(674, 12);
            this.pnlexit.Name = "pnlexit";
            this.pnlexit.Size = new System.Drawing.Size(132, 68);
            this.pnlexit.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(55, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 547);
            this.Controls.Add(this.pnlexit);
            this.Controls.Add(this.btnAddbook);
            this.Controls.Add(this.pnlEditAddBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchBookName);
            this.Controls.Add(this.lblsearchBookName);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.pnlEditAddBook.ResumeLayout(false);
            this.pnlEditAddBook.PerformLayout();
            this.pnlexit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblViewBooks;
        private System.Windows.Forms.Label lblsearchBookName;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Panel pnlEditAddBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookAuthorName;
        private System.Windows.Forms.Label lblBookPublication;
        private System.Windows.Forms.Label lblBookPurchaseDate;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookAuthorName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbookPurchaseDate;
        private System.Windows.Forms.Button btnAddbook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlexit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}