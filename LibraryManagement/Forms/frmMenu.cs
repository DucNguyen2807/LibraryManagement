using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using LibraryManagement.Forms;

namespace LibraryManagement
{
    public partial class frmMenu : Form
    {
        EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public frmMenu(string username)
        {
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
            if (username == "")
            {
                base.Text = "MENU FORM FOR GUEST";
                tabControl1.SelectTab(tabGuest);
                tabAdmin.Visible = false;
                tabEmployee.Visible = false;
            }
            else
            {
                base.Text = "MENU FORM - XIN CHÀO " + EmployeeRepository.GetFullName(username).ToUpper().ToString();
                if (EmployeeRepository.GetRole(username) == 0)
                {
                    tabControl1.SelectTab(tabAdmin);
                    tabGuest.Visible = false;
                    tabEmployee.Visible = false;
                }
                else
                {
                    tabControl1.SelectTab(tabEmployee);
                    tabGuest.Visible = false;
                    tabAdmin.Visible = false;
                }
            }
        }



        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }


        private void lblLogoutAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            base.Hide();
            frmLogin.username = "";
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void lblLogoutEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            base.Hide();
            frmLogin.username = "";
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void lblReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            base.Hide();
            frmLogin.username = "";
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void cBFunctionAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunction = cBFunctionAdmin.SelectedIndex;
            switch (selectedFunction)
            {
                case 0:
                    base.Hide();
                    frmEmployee frmEmployee = new frmEmployee();
                    frmEmployee.ShowDialog();
                    break;
                case 1:
                    base.Hide();
                    frmUserManagement frmUserManagement = new frmUserManagement();
                    frmUserManagement.ShowDialog();
                    break;
            }
        }

        private void cbFunctionEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunction = cbFunctionEmployee.SelectedIndex;
            switch (selectedFunction)
            {
                case 0:
                    base.Hide();
                    frmBookManagement frmBookManagement = new frmBookManagement();
                    frmBookManagement.ShowDialog();
                    break;
                case 1:
                    base.Hide();
                    frmBookLocation frmBookLocation = new frmBookLocation();
                    frmBookLocation.ShowDialog();
                    break;
                case 2:
                    base.Hide();
                    frmBorrowedBook frmBorrowedBook = new frmBorrowedBook();
                    frmBorrowedBook.ShowDialog();
                    break;
                case 3:
                    base.Hide();
                    frmViewFeedback frmViewFeedback = new frmViewFeedback();
                    frmViewFeedback.ShowDialog();
                    break;
                case 4:
                    base.Hide();
                    frmPublisher frmPublisher = new frmPublisher();
                    frmPublisher.ShowDialog();
                    break;
                case 5:
                    base.Hide();
                    frmApproveBorrowRequest frm = new frmApproveBorrowRequest();
                    frm.ShowDialog();
                    break;
                case 6:
                    base.Hide();
                    frmUserManagement frmUserManagement = new frmUserManagement();
                    frmUserManagement.ShowDialog();
                    break;
            }
        }

        private void cBFunctionGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFunction = cBFunctionGuest.SelectedIndex;
            switch (selectedFunction)
            {
                case 0:
                    base.Hide();
                    frmRegisterBook frmRegisterBook = new frmRegisterBook();
                    frmRegisterBook.ShowDialog();
                    break;
                case 1:
                    base.Hide();
                    frmReviewBook frmReviewBook = new frmReviewBook();
                    frmReviewBook.ShowDialog();
                    break;
                case 2:
                    base.Hide();
                    frmViewedBook viewedBook = new frmViewedBook();
                    viewedBook.ShowDialog();
                    break;
            }
        }
    }
}
