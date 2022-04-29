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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }


        private void ViewBook_Load(object sender, EventArgs e)
        {
            //Add book update panal should be hide
            pnlEditAddBook.Visible = false;

            //get sql connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            //command for get sql data
            cmd.CommandText = " select * from  AddNewBook";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            //sql data send to grid view to visible
            dataGridViewBooks.DataSource = dataSet.Tables[0];
        }


        //cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close form by press cancle button.
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                pnlEditAddBook.Visible = false;
                pnlexit.Visible = true;
            }
                
        }

        //Search a book,enter a text to search box and get information 
        private void txtSearchBookName_TextChanged(object sender, EventArgs e)
        {
            //search data on sql data base
            if(txtSearchBookName.Text != "")
            {
                //get sql connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;


                //find data
                cmd.CommandText =
                    " select * from  AddNewBook where BookName LIKE '"+txtSearchBookName.Text+"%'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                //set search data to data grid view
                dataGridViewBooks.DataSource = dataSet.Tables[0];
            }
            else
            {
                //get sql coonection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //get data from sql
                cmd.CommandText = " select * from  AddNewBook";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                
                //set data to data grid view
                dataGridViewBooks.DataSource = dataSet.Tables[0];
            }
        }


        //refresh button.Refresh all things
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //clear search boxx -- hide edit book panal -- load again
            txtSearchBookName.Text = "";
            pnlEditAddBook.Visible = false;
            pnlexit.Visible = true;
            ViewBook_Load(this,null);
        }

        //update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //set a message  what wil happend.(Update sql table)
            if (MessageBox.Show("Data will be Updated.  Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {

                //create variables for make a reationship with sql data table
                String bookname = txtBookName.Text;
                String bookAuthor = txtBookAuthorName.Text;
                String publish = txtBookPublication.Text;
                String purchaseDAte = txtbookPurchaseDate.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quntity = Int64.Parse(txtBookQuantity.Text);

                //get sql connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //update new data to addnewbook table enter by user
                //BookID,BookName,BookAuthor,BookPublication,BookPLdate,BookPrice,BookQuantity
                cmd.CommandText = "Update AddNewBook set" +
                    " BookName ='" + bookname + "'," +
                    " BookAuthor = '" + bookAuthor + "'," +
                    " BookPublication = '" + publish + "'," +
                    " BookPLdate = '" + purchaseDAte + "'," +
                    " BookPrice = '" + price + "'," +
                    " BookQuantity = " + quntity + " where BookID = " + rowID + ""; 

                //set data
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ViewBook_Load(this, null);
                pnlexit.Visible = true;
            }

        }

        //delete a data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //message box shows a warning
            if (MessageBox.Show("Data will be Deleted.  Confirm?", "Conformation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                //sql connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //delete data in addnewboook table
                //BookID,BookName,BookAuthor,BookPublication,BookPLdate,BookPrice,BookQuantity
                cmd.CommandText = "delete from  AddNewBook where BookID = " + rowID + "";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ViewBook_Load(this, null);
            }
        }

        
        int bookID;
        Int64 rowID;
        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bookID = int.Parse(dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                pnlexit.Visible = false;
            }
            else
            {
                pnlexit.Visible = true;
            }
            pnlEditAddBook.Visible = true;
            pnlexit.Visible = false;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = " select * from  AddNewBook where BookID= " + bookID + "";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            rowID = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());

            //fill data grid view with sql data table
            txtBookName.Text = dataSet.Tables[0].Rows[0][1].ToString();
            txtBookAuthorName.Text = dataSet.Tables[0].Rows[0][2].ToString();
            txtBookPublication.Text = dataSet.Tables[0].Rows[0][3].ToString();
            txtbookPurchaseDate.Text = dataSet.Tables[0].Rows[0][4].ToString();
            txtBookPrice.Text = dataSet.Tables[0].Rows[0][5].ToString();
            txtBookQuantity.Text = dataSet.Tables[0].Rows[0][6].ToString();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        //anyone needs add a book before view it---
        private void btnAddbook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to add a New Book.", "Then prees Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {
                AddBook addbook = new AddBook();
                addbook.Show();
                this.Close();
            }
        }

        private void dataGridViewBooks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //}
            pnlEditAddBook.Visible = true;
        }

        private void dataGridViewBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlEditAddBook.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtBookPrice_TextChanged(object sender, EventArgs e)
        {

            Int64 number = 0;
            if (Int64.TryParse(txtBookPrice.Text, out number))
            {
                errorProvider1.SetError(txtBookPrice, "");
                btnUpdate.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtBookPrice, " Its allowed Number only");
                btnUpdate.Enabled = false;
            }
        }

        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {
            Int64 number = 0;
            if (Int64.TryParse(txtBookQuantity.Text, out number))
            {
                errorProvider1.SetError(txtBookQuantity, "");
                btnUpdate.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtBookQuantity, " Its allowed Number only");
                btnUpdate.Enabled = false;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                if (pnlEditAddBook.Visible == true)
                {
                    btnCancel.PerformClick();
                }
                else
                {
                    btnExit.PerformClick();
                }
            }
            if (keyData == (Keys.Delete))
            {
                if (pnlEditAddBook.Visible == true)
                {
                    btnDelete.PerformClick();
                }
            }
            if (keyData == (Keys.F5))
            {
                btnRefresh.PerformClick();
                return true;
            }
            if (keyData == (Keys.Enter))
            {
                if (pnlEditAddBook.Visible == true)
                {
                    btnUpdate.PerformClick();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtBookAuthorName.Focus();
            }
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Right))
            {
                txtbookPurchaseDate.Focus();
            }
        }

        private void txtBookAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtBookPublication.Focus();
            }
        }

        private void txtBookAuthorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Right))
            {
                txtBookPrice.Focus();
            }
        }

        private void txtBookPublication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Right)
            {
                txtBookQuantity.Focus();
            }
        }

        private void txtbookPurchaseDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtBookPrice.Focus();
            }
        }

        private void txtbookPurchaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Left))
            {
                txtBookName.Focus();
            }
        }

        private void txtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtBookQuantity.Focus();
            }
        }

        private void txtBookPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Left))
            {
                txtBookAuthorName.Focus();
            }
        }

        private void txtBookQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Left)
            {
                txtBookPublication.Focus();
            }
        }
    }  
}
