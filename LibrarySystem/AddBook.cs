using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }


        //make a connection with sql servers and insert data to addnewbook table
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBookName.Text != "" &&
                txtAuthorName.Text != "" &&
                txtBookPrice.Text != "" &&
                txtBookPublication.Text != "" &&
                txtBookQuantity.Text != "")
            {



                String bookname = txtBookName.Text;
                String bookAuthor = txtAuthorName.Text;
                String bookPublish = txtBookPublication.Text;
                String purchaseDate = dateTimePurchase.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quntity = Int64.Parse(txtBookQuantity.Text);

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //insert values to data table
                connection.Open();
                cmd.CommandText =
                    "insert into AddNewBook(BookName,BookAuthor,BookPublication,BookPLdate,BookPrice,BookQuantity)" +
                    "values('" + bookname + "','" + bookAuthor + "','" + bookPublish + "','" + purchaseDate + "','" + price + "','" + quntity + "')";

                cmd.ExecuteNonQuery();
                connection.Close();

                //after data saving operation must be refresh all things
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtBookPublication.Clear();
                txtBookQuantity.Clear();
                txtBookPrice.Clear();
            }
            else
            {
                MessageBox.Show("Deatiles cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        //cancle oparation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //set warning message
            if(MessageBox.Show("Are you sure cancel ? This will DELETE your unsaved DATA ","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                ==DialogResult.OK) 
            {
                this.Close();
            }
           
        }

        //actual working like refresh button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthorName.Text = "";
            txtBookName.Text = "";
            txtBookPrice.Text = "";
            txtBookPublication.Text = "";
            txtBookQuantity.Text = "";
            dateTimePurchase.Text = "";

        }

        private void txtBookPrice_TextChanged(object sender, EventArgs e)
        {

            Int64 number = 0;
            if (Int64.TryParse(txtBookPrice.Text, out number))
            {
                errorProvider1.SetError(txtBookPrice, "");
                btnSave.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtBookPrice, " Its allowed Number only");
                btnSave.Enabled = false;
            }
        }

        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {

            Int64 number = 0;
            if (Int64.TryParse(txtBookQuantity.Text, out number))
            {
                errorProvider1.SetError(txtBookQuantity, "");
                btnSave.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtBookQuantity, " Its allowed Number only");
                btnSave.Enabled = false;
            }
        }

        //private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        btn.PerformClick();
        //    }
        //}

        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAuthorName.Focus();
            }
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBookPublication.Focus();
            }
        }

        private void txtBookPublication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dateTimePurchase.Focus();
            }
        }

        private void dateTimePurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBookPrice.Focus();
            }
        }

        private void txtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBookQuantity.Focus();
            }
        }

        private void txtBookQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
            }
            
        }

      

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtAuthorName.Focus();
            }
        }

        private void txtAuthorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBookPublication.Focus();
            }
        }

        private void txtBookPublication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dateTimePurchase.Focus();
            }
        }

        private void dateTimePurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBookPrice.Focus();
            }
        }

        private void txtBookPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBookQuantity.Focus();
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                btnCancel.PerformClick();
                return true;
            }
            if (keyData == (Keys.Delete))
            {
                btnClear.PerformClick();
                return true;
            }
            if (keyData == (Keys.F5))
            {
                btnClear.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
