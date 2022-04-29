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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local);Initial Catalog=TutorialD2;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;



            cmd.CommandText = "select * from IssueBook where bookReturndate is null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewIssed.DataSource = ds.Tables[0];



            cmd.CommandText = "select * from IssueBook where bookReturndate is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dataGridViewreturn.DataSource = ds1.Tables[0];


        }

        private void dataGridViewIssed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Unsaved Data will be lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            //   == DialogResult.OK)
            //{
            //    this.Close();
            //}
            this.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                btnExit.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
