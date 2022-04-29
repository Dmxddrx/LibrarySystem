using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class StartUpPage : Form
    {
        public StartUpPage()
        {
            InitializeComponent();
        }

        //exit in application
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
               DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //when mouse click,text box text must clear
        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Enter your User Name here")
            {
                txtUserName.Clear();
                lblwarning.Visible = false;
            }
            else
            {
                lblwarning.Visible = true;
            }
        }

        ////when mouse click,text box text must clear
        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Enter your Password here")
            {
                txtPassword.Clear();
                //pasword content must hide
                txtPassword.PasswordChar = '*';

                lblwarning.Visible = false;
            }
            else
            {
                lblwarning.Visible = true;
            }
        }

        //make a connection with sql servers and jump into application by usien sql data table's data
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select * from LoginTable where UserName='"+txtUserName.Text+"' and Password ='"+txtPassword.Text+"' ";
            SqlDataAdapter datadapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            datadapter.Fill(dataset);

            if (dataset.Tables[0].Rows.Count !=0)
            {
                if(MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==
                    DialogResult.OK)

                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    //txtUserName.Text = "Enter your User Name here";
                    //txtPassword.Text = "Enter your Password here";
                    txtPassword.PasswordChar = '\0';
                    lblwarning.Visible = false;

                }
                
            }
            else
            {
                MessageBox.Show("Wrong User Name OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblwarning.Visible = true;
                txtUserName.Text = "Enter your User Name here";
                txtPassword.Text = "Enter your Password here";
            }
        }

        //going to sign up form
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signuppage = new SignUp();
            signuppage.Show();
        }

        //going to password change form 
        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Hide();
        }

        //private void pictureBoxShow_MouseEnter(object sender, EventArgs e)
        //{
        //    Image image = Image.FromFile("D:/Software/visual studio/pic/PicsArt_10-04-12.49.35.1.jpg");
        //    pictureBoxShow.Image = image;
        //}

        //private void pictureBoxShow_MouseLeave(object sender, EventArgs e)
        //{
        //    Image image = Image.FromFile("D:/Software/visual studio/pic/PicsArt_10-04-12.49.35.2.jpg");
        //    pictureBoxShow.Image = image;
        //}

    
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" )
            {
                btnshow.Visible = true;
                btnhide.Visible = true;
                lblwarning.Visible = false;
            }
            else
            {
                btnshow.Visible = false;
                btnhide.Visible = false;
                //lblwarning.Visible = true;
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnhide.BringToFront();
                //btnshow.Visible = false;
                //btnhide.Visible = true;
                txtPassword.PasswordChar = '*';
            }
            //else
            //{
            //    btnshow.Visible = false;
            //    btnhide.Visible = false;
            //}
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
           
            if (txtPassword.PasswordChar == '*')
            {
                btnshow.BringToFront();
                //btnshow.Visible = true;
                //btnhide.Visible = false;
                txtPassword.PasswordChar = '\0';
            }
            //else
            //{
            //    btnshow.Visible = false;
            //    btnhide.Visible = false;
            //}
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
                    txtPassword.Focus();
                }
                if(txtPassword.Text == "Enter your Password here" && txtUserName.Text !="")
                {
                    txtPassword.Clear();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtPassword.Text != "")
                {
                    btnLogin.PerformClick();
                    lblwarning.Visible = false;
                }
                else
                {
                    lblwarning.Visible = true;
                }
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

        private void StartUpPage_Load(object sender, EventArgs e)
        {
            lblwarning.Visible = false;
        }
    }
}
