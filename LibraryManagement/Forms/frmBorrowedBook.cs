using Data.Models;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryManagement
{
    public partial class frmBorrowedBook : Form
    {

        private BorrowBookRepository borrowBookRepository;

        private BookRepository bookRepository;
        private EmployeeRepository employeeRepository;
        private UserRepository userRepository;
        private int selectedRowIndex = -1;
        private void updateGridView()
        {
            var borrowedBooks = borrowBookRepository.GetAll().Include(x => x.Book).Include(u => u.MemberCodeNavigation).Include(e => e.Employee).ToList();
            if (borrowedBooks != null)
            {
                var listBorrowedBook = borrowedBooks.ToList();
                dgvBorrowRecord.DataSource = listBorrowedBook.Select(x => new
                {
                    RecordId = x.RecordId,
                    BookTitle = x.Book.Title,
                    MemberCode = x.MemberCode,
                    BorrowDate = x.BorrowDate,
                    DueDate = x.DueDate,
                    Status = x.ReturnStatus,
                    EmployeeCode = x.EmployeeId
                }).ToList();
            }
        }

        private bool isSelectIndex()
        {
            return selectedRowIndex >= 0;
        }

        public void clear()
        {
            txtBookname.Text = string.Empty;
            txtEmpCode.Text = string.Empty;
            txtMemberCode.Text = string.Empty;
            txtRecordId.Text = string.Empty;
            rdBtnreturned.Checked = false;
            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            deleteABorrowedBookToolStripMenuItem.Enabled = false;
            updateToolStripMenuItem.Enabled = false;

        }

        public frmBorrowedBook()
        {
            InitializeComponent();

            bookRepository = new BookRepository();
            borrowBookRepository = new BorrowBookRepository();
            employeeRepository = new EmployeeRepository();
            userRepository = new UserRepository();

            updateGridView();

            deleteABorrowedBookToolStripMenuItem.Enabled = false;
            updateToolStripMenuItem.Enabled = false;
        }


        private void frmBorrowedBook_Load(object sender, EventArgs e)
        {
            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
        }

        private void dgvBorrowRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            selectedRowIndex = e.RowIndex;
            var row = dgvBorrowRecord.Rows[e.RowIndex];
            txtRecordId.Text = row.Cells[0].Value.ToString();
            txtBookname.Text = row.Cells[1].Value.ToString();

            txtMemberCode.Text = row.Cells[2].Value.ToString();

            if (row.Cells[3].Value is DateTime borrowDate)
            {
                dtpBorrowDate.Value = borrowDate;
            }
            if (row.Cells[4].Value is DateTime dueDate)
            {
                dtpDueDate.Value = dueDate;
            }
            string? status = row.Cells[5].Value.ToString();
            if (status == "Returned")
            {
                rdBtnreturned.Checked = true;
            }
            else
            {
                rdBtnreturned.Checked = false;
            }

            txtEmpCode.Text = row.Cells[6].Value.ToString();
            deleteABorrowedBookToolStripMenuItem.Enabled = true;
            updateToolStripMenuItem.Enabled = true;
        }

        private void deleteABorrowedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn thông tin mượn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var recordId = int.Parse(txtRecordId.Text);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin sách mượn này !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool deleted = borrowBookRepository.DeleteBorrowRecord(recordId);

                if (deleted)
                {
                    // Location was successfully deleted.
                    MessageBox.Show("Xóa thông tin sách mượn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateGridView();
                    clear();
                }
                else
                {
                    // Handle the case where deletion failed.
                    MessageBox.Show("Xóa thông tin sách mượn thất bại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBookname.Text = string.Empty;
            txtEmpCode.Text = string.Empty;
            txtMemberCode.Text = string.Empty;
            txtRecordId.Text = string.Empty;
            rdBtnreturned.Checked = false;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
        }

        private void frmBorrowedBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn thông tin mượn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBookname.Text) ||
                string.IsNullOrWhiteSpace(txtMemberCode.Text) ||
                string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int bookId = bookRepository.GetBookIdByTitle(txtBookname.Text);


            bool memberCodeExisted = userRepository.checkUserCode(txtMemberCode.Text);


            int empId = employeeRepository.GetEmployeeIdByUsername(frmLogin.username);

            if (bookId == -1)
            {
                MessageBox.Show("Thông tin sách không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (empId == -1)
            {
                MessageBox.Show("Thông tin nhân viên không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (!memberCodeExisted)
            {
                MessageBox.Show("Thành viên không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (dtpBorrowDate.Value > dtpDueDate.Value)
                {
                    MessageBox.Show("Ngày trả sách phải sau ngày mượn sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String returnStatus = "";
                if (rdBtnreturned.Checked)
                {
                    returnStatus = "Returned";
                }
                else { returnStatus = "Not returned"; }
                BorrowRecord? borrowRecord = borrowBookRepository.GetBorrowRecord(int.Parse(txtRecordId.Text));
                if (borrowRecord == null)
                {
                    MessageBox.Show("Thông tin mượn sách không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    borrowRecord.BookId = bookId;
                    borrowRecord.MemberCode = txtMemberCode.Text;
                    borrowRecord.BorrowDate = dtpBorrowDate.Value;
                    borrowRecord.DueDate = dtpDueDate.Value;
                    borrowRecord.ReturnStatus = returnStatus;
                    borrowRecord.EmployeeId = empId;
                }

                borrowBookRepository.Update(borrowRecord);
                MessageBox.Show("Cập nhật thông tin mượn sách thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateGridView();
                clear();
                return;

            }
        }
        bool isChecked = false;
        private void rdBtnreturned_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdBtnreturned.Checked;
        }

        private void rdBtnreturned_Click(object sender, EventArgs e)
        {

            if (rdBtnreturned.Checked && !isChecked)
                rdBtnreturned.Checked = false;
            else
            {
                rdBtnreturned.Checked = true;
                isChecked = false;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookIdToSearch = 0;          
            // Start with a query that retrieves all book locations.
            var query = borrowBookRepository.GetAll()
                .Include(location => location.Book) // Include the Book entity.
                .AsQueryable();
            // Check if the user has entered a book title.
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                // Retrieve the BookId based on the book title.
                bookIdToSearch = bookRepository.GetBookIdByTitle(txtSearch.Text);
                if (bookIdToSearch > 0)
                {
                    query = query.Where(record => record.BookId == bookIdToSearch);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookname.Text = String.Empty;
                    updateGridView();
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtMemberCode.Text))
            {
                query = query.Where(record => record.MemberCode == txtMemberCode.Text);
            }

            // Check if the user has entered an employee code.
            if (!string.IsNullOrWhiteSpace(txtEmpCode.Text))
            {
                query = query.Where(record => record.EmployeeId == int.Parse(txtEmpCode.Text));
            }

            // Check if a date range is selected using the DateTimePickers.
            if (dtpBorrowDate.Value != DateTime.Today)
            {
                query = query.Where(record => record.BorrowDate >= DateTime.Today);
            }


            // Check if the DueDate DateTimePicker is set to DateTime.Now.
            if (dtpDueDate.Value != DateTime.Today)
            {
                query = query.Where(record => record.DueDate <= DateTime.Today);
            }


            var filteredLocations = query.ToList();
            dgvBorrowRecord.DataSource = filteredLocations.Select(x => new
            {
                RecordId = x.RecordId,
                BookTitle = x.Book.Title,
                MemberCode = x.MemberCode,
                BorrowDate = x.BorrowDate,
                DueDate = x.DueDate,
                Status = x.ReturnStatus,
                EmployeeCode = x.EmployeeId
            }).ToList();


        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn thông tin mượn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BorrowedBook.Enabled = true;
        }
    }
}
