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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
       

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select * from IssueBook where stdEnroll = '" + cmbSearch.Text + "' and bookReturndate is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                dataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No books Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            pnlDetiles.Visible = false;
            //txtBookName.Clear();
            //txtIssuedate.Clear();
            cmbSearch.Text = "";
            cmbdisplay();
        }

        String bname;
        String bissudate;
        Int64 rowID;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDetiles.Visible = true;

            if(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowID = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                bissudate = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtIssuedate.Text = bissudate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            connection.Open();

            cmd.CommandText = "update IssueBook set bookReturndate = '" + txtreturndate.Text + "'" +
                "where stdEnroll = '" + cmbSearch.Text + "'" +
                "and Id = '" + rowID + "'";

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);

        }

 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbSearch.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnexit2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbSearch.Text = "";
        }

        public void cmbdisplay()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = connection;

            connection.Open();

            string cmbo = "select EnrlNO , StudentID from NewStudent";
            SqlCommand cmd = new SqlCommand(cmbo, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbSearch.Items.Add(dr["EnrlNO"].ToString());
                cmbSearch.DisplayMember = (dr["EnrlNO"].ToString());
                cmbSearch.ValueMember = (dr["StudentID"].ToString());
            }
            connection.Close();
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            pnlDetiles.Visible = false;
            dataGridView.DataSource = null;
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                if (pnlDetiles.Visible == true)
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
                btnRefresh.PerformClick();
                return true;
            }
            if (keyData == (Keys.F5))
            {
                btnRefresh.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void cmbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReturn.PerformClick();
            }
        }

        private void txtIssuedate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReturn.PerformClick();
            }
        }

        private void txtreturndate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReturn.PerformClick();
            }
        }

        private void txtreturndate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                btnCancel.PerformClick();
            }
        }

        private void txtIssuedate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                btnCancel.PerformClick();
            }
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Escape))
            {
                btnCancel.PerformClick();
            }
        }

       
    }
}
