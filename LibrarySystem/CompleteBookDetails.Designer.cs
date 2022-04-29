
namespace LibrarySystem
{
    partial class CompleteBookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteBookDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewIssed = new System.Windows.Forms.DataGridView();
            this.dataGridViewreturn = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issued Books";
            // 
            // dataGridViewIssed
            // 
            this.dataGridViewIssed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssed.Location = new System.Drawing.Point(11, 49);
            this.dataGridViewIssed.Name = "dataGridViewIssed";
            this.dataGridViewIssed.RowTemplate.Height = 25;
            this.dataGridViewIssed.Size = new System.Drawing.Size(935, 202);
            this.dataGridViewIssed.TabIndex = 1;
            this.dataGridViewIssed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIssed_CellContentClick);
            // 
            // dataGridViewreturn
            // 
            this.dataGridViewreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreturn.Location = new System.Drawing.Point(11, 327);
            this.dataGridViewreturn.Name = "dataGridViewreturn";
            this.dataGridViewreturn.RowTemplate.Height = 25;
            this.dataGridViewreturn.Size = new System.Drawing.Size(935, 202);
            this.dataGridViewreturn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Books";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Ubuntu Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(871, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridViewreturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewIssed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompleteBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBookDetails";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewIssed;
        private System.Windows.Forms.DataGridView dataGridViewreturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}