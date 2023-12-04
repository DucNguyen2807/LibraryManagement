using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Data;

namespace LibraryManagement
{
    public partial class frmRegisterBook : Form
    {
        private RegisterBrBookRepository BookRepository;
        public frmRegisterBook()
        {
            InitializeComponent();
            BookRepository = new RegisterBrBookRepository();
            DTPRequestBr.Value = DateTime.Now;
            DTPRequestBr.CustomFormat = "yyyy-MM-dd";
            DTPRequestBr.Format = DateTimePickerFormat.Custom;
        }

        private void frmRegisterBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            var allBooks = BookRepository.GetAllBooks().ToList();
            dgvListBook.DataSource = allBooks;
            dgvListBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListBook.Columns["Publisher"].Visible = false;
            dgvListBook.Columns["BookLocations"].Visible = false;
            dgvListBook.Columns["BorrowRecords"].Visible = false;
            dgvListBook.Columns["BorrowRequests"].Visible = false;
            dgvListBook.Columns["LostBooks"].Visible = false;
            dgvListBook.Columns["Reviews"].Visible = false;
            dgvListBook.Columns["ViewedBooks"].Visible = false;
            foreach (DataGridViewColumn column in dgvListBook.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void refresh()
        {
            txtSearchBook.Clear();
            txtMemberCode.Clear();
            txtBrBook.Clear();
        }

        private void btn_registerBr_Click(object sender, EventArgs e)
        {
            var memberCode = txtMemberCode.Text;
            string brBookIdStr = txtBrBook.Text;
            DateTime dateTime = DTPRequestBr.Value;
            if (string.IsNullOrEmpty(memberCode) || string.IsNullOrEmpty(brBookIdStr))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var bookId = Convert.ToInt32(brBookIdStr);
                var Book = BookRepository.GetAll().Where(x => x.BookId == bookId).FirstOrDefault();
                if (Book != null)
                {
                    using (var context = new LibraryManagementContext())
                    {
                        var existingMember = context.Users.FirstOrDefault(m => m.MemberCode == memberCode);

                        if (existingMember != null)
                        {
                            var newBrRequest = new BorrowRequest
                            {
                                MemberCode = existingMember.MemberCode,
                                BookId = Book.BookId,
                                RequestDate = dateTime,
                                Status = "Pending"
                            };
                            context.BorrowRequests.Add(newBrRequest);
                            context.SaveChanges();
                            MessageBox.Show("Yêu cầu mượn sách đã được gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();

                        }
                        else
                        {
                            MessageBox.Show("Thành viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                } else
                {
                    MessageBox.Show("Sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchValue = txtSearchBook.Text;
            var searchBookList = BookRepository.GetAll().Where(p => p.Title.ToLower().Equals(searchValue.ToLower().Trim()) || p.Title.ToLower().Contains(searchValue.ToLower().Trim()));
            if (searchBookList != null)
            {
                dgvListBook.DataSource = searchBookList.ToList();
                searchToolStripMenuItem.Enabled = false;
                btn_registerBr.Enabled = true;

            }
            else
            {
                MessageBox.Show("Sách không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                searchToolStripMenuItem.Enabled = false;
                btn_registerBr.Enabled = true;
            }
        }

        private void viewBookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBooks();
            searchToolStripMenuItem.Enabled = false;
            btn_registerBr.Enabled = true;
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void txtBrBook_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrBook.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}