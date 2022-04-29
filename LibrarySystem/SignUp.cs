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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

  

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Enter your user name")
            {
                txtUserName.Clear();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Enter a Password")
            {
                txtPass.Clear();
                txtPass.PasswordChar = '*';
            }
        }

        private void txtREpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtREpass.Text == "Re enter your Password")
            {
                txtREpass.Clear();
                txtREpass.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit from sign up page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
              DialogResult.Yes)
            {
                this.Hide();
                StartUpPage startup = new StartUpPage();
                startup.Show();

            }
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {if (MessageBox.Show("Use Your new User name, Password and Login Now", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Hide();
                StartUpPage startup = new StartUpPage();
                startup.Show();
            }
        }
       
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" &&
               txtPass.Text != "" &&
               txtREpass.Text != "")

                
            {
                String username = txtUserName.Text;
                String stdname = txtPass.Text;
                String repass = txtREpass.Text;

                //if (txtREpass.Text = stdname)
                //{

                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    connection.Open();
                    cmd.CommandText =
                        "insert into LoginTable(UserName,Password)" +
                        "values('" + username + "','" + repass + "')";

                    cmd.ExecuteNonQuery();
                    connection.Close();

                if(MessageBox.Show("Data Saved and you must Remember Your User name and Password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning) ==
                    DialogResult.OK)
                {
                    txtPass.PasswordChar = '\0';
                    txtREpass.Clear();

                    btnLogin.Enabled = true;
                    btnhide.Visible = false;
                    btnshow.Visible = false;

                    txtUserName.ReadOnly = true;
                    txtPass.ReadOnly = true;
                    txtREpass.ReadOnly = true;

                    pnlRepass.Visible = false;
                }
                else
                {
                    txtPass.PasswordChar = '*';

                    btnLogin.Enabled = false;
                    btnhide.Visible = true;
                    btnshow.Visible = true;

                    txtUserName.ReadOnly = false;
                    txtPass.ReadOnly = false;
                    txtREpass.ReadOnly = false;

                    pnlRepass.Visible = true;
                }
                //}
            }
            else
            {
                MessageBox.Show("Don't use the User Name who already used or Deatiles cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void txtREpass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtREpass.Text == txtPass.Text)
            {
                errorProvider1.SetError(txtREpass, "");
                btnSignUp.Enabled = true;

                
            }
            else
            {
                errorProvider1.SetError(txtREpass, "Password and Confirm password does not match?");
                btnSignUp.Enabled = false;
            }
        }

      

        private void btnhide_Click(object sender, EventArgs e)
        {
            //if (txtREpass.PasswordChar == '*')
            //{
            //    btnshow.BringToFront();
            //    txtREpass.PasswordChar = '\0';
            //}
            if (txtREpass.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtREpass.PasswordChar = '*';
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //if (txtREpass.PasswordChar == '\0')
            //{
            //    btnhide.BringToFront();
            //    txtREpass.PasswordChar = '*';
            //}
            //else
            //{
            //    btnshow.BringToFront();
            //}
            if (txtREpass.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtREpass.PasswordChar = '\0';
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtUserName.Text != "")
                {
                    txtPass.Focus();
                }
                if(txtPass.Text== "Enter a Password" && txtUserName.Text !="")
                {
                    txtPass.Clear();
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtPass.Text != "")
                {
                    txtREpass.Focus();
                }
                if (txtREpass.Text == "Re enter your Password" && txtPass.Text != "")
                {
                    txtREpass.Clear();
                }
            }
        }

        private void txtREpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignUp.PerformClick();
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

        private void SignUp_Load(object sender, EventArgs e)
        {
            //btnshow.BringToFront();

        }
    }
}
