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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudent_Load(this, null);
            txtSearchStudentName.Clear();
            pnlexit.Visible = true;
            pnlEditAddSudent.Visible = false;

            //ViewStudent viewstudent = new ViewStudent();
            //viewstudent.Hide();
            //AddBook addbook = new AddBook();
            //addbook.Hide();
            //AddStudent addstudent = new AddStudent();
            //addstudent.Hide();
            //ViewBook viewbook = new ViewBook();
            //viewbook.Close();
        }

        //When text changed in Textbox
        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            //when search a student name (type something on txtSearchStudentName TEXT BOX) change GIF to New Image & Change lable Text to new one
            if (txtSearchStudentName.Text != "")
            {
                Image image = Image.FromFile("D:/PS/search.png");
                picboxViewStu.Image = image;
                lblViewStudents.Text = "Searching Students";

                //Sql connection for Search a student in tables
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "Select * from NewStudent where EnrlNO LIKE '" + txtSearchStudentName.Text+"%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridViewStudents.DataSource = DS.Tables[0];
            }
            //else there must be in previous situation(*Texts & Images)
            else
            {
                Image image = Image.FromFile("D:/PS/search1.gif");
                picboxViewStu.Image = image;
                lblViewStudents.Text = "View Students";

                //create a sql connection for data grid view
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //show sql table's deatiles in data grid view
                cmd.CommandText = "Select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridViewStudents.DataSource = DS.Tables[0];
            }
        }

        //When form load  
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            //edit book panal should be hidden
            pnlEditAddSudent.Visible = false;

            //create a sql connection for data grid view
            SqlConnection connection = new SqlConnection ();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            //show sql table's deatiles in data grid view
            cmd.CommandText = "Select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewStudents.DataSource = DS.Tables[0];
        }

        int Stuid;
        Int64 rowID;
        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Stuid = int.Parse(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
                pnlexit.Visible = false;
            }
            else if(dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value != null)
            {
                pnlexit.Visible = true;
                pnlEditAddSudent.Visible = false;
            }
            
            

            pnlEditAddSudent.Visible = true;
            pnlexit.Visible = false;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
 
            cmd.CommandText = "Select * from NewStudent where StudentID = "+ Stuid +"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowID = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtStuName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnrll.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
            txtSemes.Text = DS.Tables[0].Rows[0][4].ToString();
            txtCon.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
        }
        

        private void dataGridViewStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value != null)
            {
                MessageBox.Show("You want to add a New Student.", "Then prees Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated.  Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                  == DialogResult.OK)
            {

                String stuName = txtStuName.Text;
                String entroll = txtEnrll.Text;
                String dep = txtDep.Text;
                String seme = txtSemes.Text;
                Int64 contact = Int64.Parse(txtCon.Text);
                String emaiL = txtEmail.Text;

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //StudentID,StudentName,EnrlNO,Department,Semester,Contact,Email
                cmd.CommandText = " Update NewStudent set " +
                    " StudentName ='" + stuName + "'," +
                    " EnrlNO = '" + entroll + "'," +
                    " Department = '" + dep + "'," +
                    " Semester = '" + seme + "'," +
                    " Email = '" + emaiL + "'," +
                    " Contact = " + contact + " where StudentID = " + rowID + ""; 

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ViewStudent_Load(this, null);
                pnlexit.Visible = true;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted?.  Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                  == DialogResult.OK)
            {

                String stuName = txtStuName.Text;
                String entroll = txtEnrll.Text;
                String dep = txtDep.Text;
                String seme = txtSemes.Text;
                Int64 contact = Int64.Parse(txtCon.Text);
                String emaiL = txtEmail.Text;

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //StudentID,StudentName,EnrlNO,Department,Semester,Contact,Email
                cmd.CommandText = " Delete from NewStudent where StudentID = '"+ rowID +"'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ViewStudent_Load(this, null);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                pnlEditAddSudent.Visible = false;
                pnlexit.Visible = true;
            }
              
            
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddstudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to add a New Student.", "Then prees Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                AddStudent addStudent = new AddStudent();
                addStudent.Show();
                this.Close();
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {
            Int64 number = 0;
            if (Int64.TryParse(txtCon.Text, out number))
            {
                errorProviderContact.SetError(txtCon, "");
                btnUpdate.Enabled = true;
            }
            else
            {
                errorProviderContact.SetError(txtCon, " Its allowed Number only");
                btnUpdate.Enabled = false;
            }
        }

        private int UserGmail(string user)
        {
            int num = 0;

            if (user.Contains("@gmail.com"))
            {
                num++;
                errorProviderEmail.Dispose();
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, "please Enter a google account");
            }
            return num;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String email = txtEmail.Text;

            if (UserGmail(email) >= 1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
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
                if (pnlEditAddSudent.Visible == true)
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
                if (pnlEditAddSudent.Visible == true)
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
                if (pnlEditAddSudent.Visible == true)
                {
                    btnUpdate.PerformClick();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtStuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtEnrll.Focus();
            }
        }

        private void txtStuName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Right))
            {
                txtSemes.Focus();
            }
        }

        private void txtEnrll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtDep.Focus();
            }
        }

        private void txtEnrll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Right))
            {
                txtCon.Focus();
            }
        }

        private void txtDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Right)
            {
                txtEmail.Focus();
            }
        }

        private void txtSemes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtCon.Focus();
            }
        }

        private void txtSemes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Left))
            {
                txtStuName.Focus();
            }
        }

        private void txtCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                txtEmail.Focus();
            }
        }

        private void txtCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Left))
            {
                txtEnrll.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Left)
            {
                txtDep.Focus();
            }
        }
    }
}
