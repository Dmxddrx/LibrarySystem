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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }
        
        private void IssueBook_Load(object sender, EventArgs e)
        {
            cmbdisplay();
            this.AcceptButton = this.btnSearch;


            //make sql connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();

            cmd = new SqlCommand("select BookName from AddNewBook", connection);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    cmbBookName.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            connection.Close();
        }

        int count;
        public void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEnroll1.Text != "")
            {
                String eid = txtSearchEnroll1.Text;

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = " select * from NewStudent where EnrlNO = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //-------------------------------------------------------------------------------------------------------------------------
                //code to count how many book has been issued on this enrollment number
                //Id,stdEnroll,stdName,stdDep,stdSem,stdContact,stdEmail,bookName,bookIsuueDate,bookReturndate

                cmd.CommandText = " select count(stdEnroll) from IssueBook where stdEnroll = '" + eid + "'and bookReturndate is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //-------------------------------------------------------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtStdName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtStdName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();

                    MessageBox.Show("Invalied Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Maximum 3 Books Can be ISSUED to 1 Student.
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(txtStdName.Text != "")
            {
                //count issue books
                if(cmbBookName.SelectedIndex != -1 && count <= 2)
                {
                    
                    String enroll1 = txtSearchEnroll1.Text;
                    String stdname = txtStdName.Text;
                    String stddep = txtDep.Text;
                    String sem = txtSem.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = cmbBookName.Text;
                    String bookissuedate = txtIssueDate.Text;

                    String eid = txtSearchEnroll1.Text;

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    connection.Open();

                    //Id,stdEnroll,stdName,stdDep,stdSem,stdContact,stdEmail,bookName,bookIsuueDate,bookReturndate
                    cmd.CommandText =
                      "insert into IssueBook (stdEnroll,stdName,stdDep,stdSem,stdContact,stdEmail,bookName,bookIsuueDate)" +
                      "values('" + enroll1 + "','" + stdname + "','" + stddep + "','" + sem + "','" + contact + "','" + email + "','"+ bookname + "','"+ bookissuedate + "')";

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected Book or Maximum number of book ISSUED", "No book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valied Enrollment number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchEnroll1.Text == "")
            {
                txtStdName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnexit2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchEnroll1.Text = "";
            

        }

        private void combobox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = connection;

            //connection.Open();

            //cmd = new SqlCommand("Select EnrlNO from NewStudent", connection);
            //SqlDataReader sdr1 = cmd.ExecuteReader();

            ////while (sdr1.Read())
            ////{
            ////    txtSearchEnroll1.Items.Add(sdr1);
            ////}

            //while (sdr1.Read())
            //{
            //    for (int i = 0; i < sdr1.FieldCount; i++)
            //    {
            //        txtSearchEnroll1.Items.Add(sdr1.GetString(i));
            //    }
            //}
            //sdr1.Close();
            //connection.Close();

            if (txtSearchEnroll1.Text == "")
            {
                txtStdName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }

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
                txtSearchEnroll1.Items.Add(dr["EnrlNO"].ToString());
                txtSearchEnroll1.DisplayMember = (dr["EnrlNO"].ToString());
                txtSearchEnroll1.ValueMember = (dr["StudentID"].ToString());
            }
            connection.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        private void txtSearchEnroll1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void cmbBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIssueBook.PerformClick();
            }
        }

        private void txtIssueDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIssueBook.PerformClick();
            }
        }

       
    }
}
