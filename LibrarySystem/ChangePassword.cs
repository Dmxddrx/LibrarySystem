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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit Without change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
             DialogResult.Yes)
            {
                this.Hide();
                StartUpPage startup = new StartUpPage();
                startup.Show();

            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select * from LoginTable where UserName='" + txtUserName.Text + "' and Password ='" + txtCurrentPass.Text + "' ";
            SqlDataAdapter datadapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            datadapter.Fill(dataset);

            if (dataset.Tables[0].Rows.Count != 0)
            {
                if (MessageBox.Show("User Name and password correct", "Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                    DialogResult.OK)
                {
                    pnllogButton.Visible = false;
                    //pnlLogin.Visible = false;
                    pnlUpdate.Visible = true;
                    txtUserName.ReadOnly = true;
                    txtCurrentPass.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Wrong User Name OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnllogButton.Visible = true;
                pnlLogin.Visible = true;
                pnlUpdate.Visible = false;
            }
        }

       
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter your user name")
            {
                txtUserName.Clear();
            }
        }

        private void txtCurrentPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCurrentPass.Text == "Enter your Current Password")
            {
                txtCurrentPass.Clear();
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Enter a new Password")
            {
                txtPass.Clear();
                txtPass.PasswordChar = '*';
            }
        }

        private void txtREpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtREpass.Text == "Enter password again")
            {
                txtREpass.Clear();
                txtREpass.PasswordChar = '*';
            }
        }

        private void txtREpass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtREpass.Text == txtPass.Text)
            {
                errorProviderrepass.SetError(txtREpass, "");
                btnChange.Enabled = true; 
            }
            else
            {
                errorProviderrepass.SetError(txtREpass, "Password and Confirm password does not match?");
                btnChange.Enabled = false;
            }
        }
      
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated.  Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                 == DialogResult.OK)
            {
                String repass = txtREpass.Text;
                String currentpass = txtCurrentPass.Text;

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "Update LoginTable set  Password = '" + repass + "' where Password = '" + currentpass + "'";



                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ChangePassword_Load(this, null);

                StartUpPage startUpPage = new StartUpPage();
                this.Hide();
                startUpPage.Show();
            }
              
           


        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtREpass.PasswordChar == '\0')
            {
                btnhide.BringToFront();
                txtREpass.PasswordChar = '*';
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtREpass.PasswordChar == '*')
            {
                btnshow.BringToFront();
                txtREpass.PasswordChar = '\0';
            }
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Enter your user name")
            {
                txtUserName.Clear();
            }
        }


        private void ChangePassword_Load(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCurrentPass.Focus();
                if(txtCurrentPass.Text == "Enter your Current Password")
                {
                    txtCurrentPass.Clear();
                }
            }
        }

        private void txtCurrentPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtCurrentPass.Focus();
                if (txtCurrentPass.Text == "Enter your Current Password")
                {
                    txtCurrentPass.Clear();
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtREpass.Focus();
                if(txtREpass.Text== "Enter password again")
                {
                    txtREpass.Clear();
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtREpass.Focus();
            }
        }

        private void txtREpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnChange.PerformClick();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                btnClose.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
