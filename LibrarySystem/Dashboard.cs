using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //exit from dashboard form
        private void menuToolExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==
                DialogResult.Yes)
            {
                Application.Exit();
            }
            if (MessageBox.Show("You want to relogin?","Reloging",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==
                    DialogResult.Yes)
            { 
                this.Close();
                StartUpPage startUpPage = new StartUpPage();
                startUpPage.Show();
            }

            
            
        }

        //going to addbook form
        private void menuToolAddNewBook_Click(object sender, EventArgs e)
        {
            AddBook addBooks = new AddBook();
            addBooks.Show();

            //if(MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    ViewBook viewBook = new ViewBook();
            //    viewBook.Close();
            //    AddStudent addStudent = new AddStudent();
            //    addStudent.Close();
            //    ViewStudent viewStudent = new ViewStudent();
            //    viewStudent.Close();
            //    IssueBook issuebook = new IssueBook();
            //    issuebook.Close();
            //    ReturnBook returnbook = new ReturnBook();
            //    returnbook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
            
           
             
        }

        //going to view book form
        private void menuToolViewBooks_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.Show();

            //if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    AddBook addBooks = new AddBook();
            //    addBooks.Close();
            //    AddStudent addStudent = new AddStudent();
            //    addStudent.Close();
            //    ViewStudent viewStudent = new ViewStudent();
            //    viewStudent.Close();
            //    IssueBook issuebook = new IssueBook();
            //    issuebook.Close();
            //    ReturnBook returnbook = new ReturnBook();
            //    returnbook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
                
        }

        //going to add student form
        private void menuToolAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();

            //if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    ViewBook viewBook = new ViewBook();
            //    viewBook.Close();
            //    AddBook addBooks = new AddBook();
            //    addBooks.Close();
            //    ViewStudent viewStudent = new ViewStudent();
            //    viewStudent.Close();
            //    IssueBook issuebook = new IssueBook();
            //    issuebook.Close();
            //    ReturnBook returnbook = new ReturnBook();
            //    returnbook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
               
        }

        //going to view student form
        private void menuToolViewStudentInfo_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.Show();

            //if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    ViewBook viewBook = new ViewBook();
            //    viewBook.Close();
            //    AddBook addBooks = new AddBook();
            //    addBooks.Close();
            //    AddStudent addStudent = new AddStudent();
            //    addStudent.Close();
            //    IssueBook issuebook = new IssueBook();
            //    issuebook.Close();
            //    ReturnBook returnbook = new ReturnBook();
            //    returnbook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
                
        }

        //going to issue book form
        private void menuToolIsuueBook_Click(object sender, EventArgs e)
        {
            IssueBook issuebook = new IssueBook();
            issuebook.Show();
            //if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    ViewBook viewBook = new ViewBook();
            //    viewBook.Hide();
            //    AddBook addBooks = new AddBook();
            //    addBooks.Hide();
            //    AddStudent addStudent = new AddStudent();
            //    addStudent.Close();
            //    ViewStudent viewStudent = new ViewStudent();
            //    viewStudent.Close();
            //    ReturnBook returnbook = new ReturnBook();
            //    returnbook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
               

        }

        //going to return book form
        private void menuToolReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook returnbook = new ReturnBook();
            returnbook.Show();

            //if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            //    ViewBook viewBook = new ViewBook();
            //    viewBook.Close();
            //    AddBook addBooks = new AddBook();
            //    addBooks.Close();
            //    AddStudent addStudent = new AddStudent();
            //    addStudent.Close();
            //    ViewStudent viewStudent = new ViewStudent();
            //    viewStudent.Close();
            //    IssueBook issuebook = new IssueBook();
            //    issuebook.Close();
            //    CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            //    completeBookDetails.Close();
            //}
                
        }

        //going to complete book detiels form 
        private void menuToolCompleteBookDetails_Click(object sender, EventArgs e)
        {
            CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            completeBookDetails.Show();

            ////if (MessageBox.Show("Are u want to close all open tabs before ADD a BOOK", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            ////{
            ////    ViewBook viewBook = new ViewBook();
            ////    viewBook.Close();
            ////    AddBook addBooks = new AddBook();
            ////    addBooks.Close();
            ////    AddStudent addStudent = new AddStudent();
            ////    addStudent.Close();
            ////    ViewStudent viewStudent = new ViewStudent();
            ////    viewStudent.Close();
            ////    IssueBook issuebook = new IssueBook();
            ////    issuebook.Close();
            ////    ReturnBook returnbook = new ReturnBook();
            ////    returnbook.Close();
            ////}
                
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        //-----key events
        //-----------------------------------------------------------------------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                menuToolExit.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
