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
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement
{
    public partial class frmViewedBook : Form
    {
        ViewedBookRepository viewedBookRepository;
        public frmViewedBook()
        {
            viewedBookRepository = new ViewedBookRepository();
            InitializeComponent();
            //loadViewBookData();

        }

        private void formViewedBook_Load(object sender, EventArgs e)
        {

        }

        public void loadViewBookData()
        {
            viewedBookRepository = new ViewedBookRepository();
            var listViewBook = viewedBookRepository.GetAll()
                .Include(x => x.Book)
                .Include(x => x.MemberCodeNavigation)
                .Select(x => new
                {
                    ID = x.ViewId,
                    BookId = x.BookId,
                    BookName = x.Book.Title,
                    MemberCode = x.MemberCode,
                    FullName = x.MemberCodeNavigation.FullName,
                }).ToList();
            dgvViewBooks.DataSource = listViewBook.ToList();
            dgvViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dgvViewBooks.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var searchValue = txt_searchValue.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập vào thông tin để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var userList = viewedBookRepository.GetAll()
                .Include(x => x.MemberCodeNavigation)
                .Select(x => new
                {
                    ID = x.ViewId,
                    BookId = x.BookId,
                    BookName = x.Book.Title,
                    MemberCode = x.MemberCode,
                    FullName = x.MemberCodeNavigation.FullName,
                }).Where(x => x.MemberCode.ToLower().Trim().Equals(searchValue.ToLower().Trim())).ToList();
            if (userList.Count != 0)
            {
                dgvViewBooks.DataSource = userList.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin mượn sách của người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadViewBookData();
        }
    }
}
