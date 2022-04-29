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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        //exit confirmation via message box
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) 
                == DialogResult.OK) 
            {
                this.Close();
            }
        }

        //when click refresh,txt box fill with these texts
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Text = "eg; Dinindu Malinda";
            txtEnrlNO.Text = "This is an Index number";
            txtdepartment.Text = "like School or Work place";
            cmbSemester.Text = "1st ,2nd,3rd ...";
            txtContact.Text = "+94 7X XXXX XXX";
            txtEmail.Text = "example@gmail.com";

            btnSave.Enabled = false;
        }


        //make a connection with sql server 
        //save data in sql data table 
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
                if (txtName.Text != "" &&
                    txtEnrlNO.Text != "" &&
                    txtdepartment.Text != "" &&
                    cmbSemester.Text != "" &&
                    txtContact.Text != "" &&
                    txtEmail.Text != "")

                {

                    String name = txtName.Text;
                    String enrl = txtEnrlNO.Text;
                    String department = txtdepartment.Text;
                    String seme = cmbSemester.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    //StudentID,StudentName,EnrlNO,Department,Semester,Contact,Email

                    connection.Open();
                    cmd.CommandText =
                        "insert into NewStudent(StudentName,EnrlNO,Department,Semester,Contact,Email) " +
                        "values('" + name + "','" + enrl + "','" + department + "','" + seme + "','" + contact + "','" + email + "')";

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //display saved 
                    MessageBox.Show("Data Saved!", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtEnrlNO.Clear();
                    txtdepartment.Clear();
                    cmbSemester.Text = "";
                    txtContact.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill empty fields  !   or you can't use Contact number or Email ,Who use already ", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

        }
        //------------------------------------------------------------------------------------------------------
        //whene mouse click ,clear txt box's texts
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "eg; Dinindu Malinda")
            {
                txtName.Clear();
            }
        }
        
        private void txtEnrlNO_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEnrlNO.Text == "This is an Index number")
            {
                txtEnrlNO.Clear();
            }
        }

        private void txtdepartment_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtdepartment.Text == "like School or Work place")
            {
                txtdepartment.Clear();
            }

        }

       
        private void txtContact_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContact.Text == "+94 7X XXXX XXX")
            {
                txtContact.Clear();
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "example@gmail.com")
            {
                txtEmail.Clear();
            }
        }
        //------------------------------------------------------------------------------------------------------



        //contacts must be in numbers,do it with error provider
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            Int64 number = 0;
            if (Int64.TryParse(txtContact.Text, out number))
            {
                errorProvidercontact.SetError(txtContact, "");
                btnSave.Enabled = true;
            }
            else
            {
                errorProvidercontact.SetError(txtContact, " Its allowed Number only");
                btnSave.Enabled = false;
            }
        }

        private int UserGmail(string user)
        {
            int num = 0;

            if (user.Contains("@gmail.com"))
            {
                num++;
                errorProvideremail.Dispose();
            }
            else
            {
                errorProvideremail.SetError(txtEmail, "please Enter a google account");
            }
            return num;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String email = txtEmail.Text;

            if (UserGmail(email) >= 1)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnExit.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void cmbSemester_TextChanged(object sender, EventArgs e)
        {
            if(cmbSemester.Text== "**no entry?Type your own**")
            {
                errorProvidersemester.SetError(cmbSemester, "none of these suggections,please enter your own or select 'OTHER' in row");
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void cmbSemester_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbSemester.Text == "1st ,2nd,3rd ...")
            {
                cmbSemester.Text = "";
            }
        }

        private void txtEnrlNO_TextChanged(object sender, EventArgs e)
        {
            Int64 number = 0;
            if (Int64.TryParse(txtEnrlNO.Text, out number))
            {
                errorProvidercontact.SetError(txtEnrlNO, "");
                btnSave.Enabled = true;
            }
            else
            {
                errorProvidercontact.SetError(txtEnrlNO, " Its allowed Number only");
                btnSave.Enabled = false;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtEnrlNO.Text == "This is an Index number")
                {
                    txtEnrlNO.Clear();
                }
                txtEnrlNO.Focus();
            }
        }

        private void txtEnrlNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtdepartment.Text == "like School or Work place")
                {
                    txtdepartment.Clear();
                }
                txtdepartment.Focus();
            }
        }

        private void txtdepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cmbSemester.Text == "1st ,2nd,3rd ...")
                {
                    cmbSemester.Text = "";
                }
                cmbSemester.Focus();
            }
        }

        private void cmbSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtContact.Text == "+94 7X XXXX XXX")
                {
                    txtContact.Clear();
                }
                txtContact.Focus();
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtEmail.Text == "example@gmail.com")
                {
                    txtEmail.Clear();
                }
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                btnExit.PerformClick();
                return true;
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
    }
}
