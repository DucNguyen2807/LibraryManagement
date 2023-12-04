using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.Forms
{
    public partial class frmApproveBorrowRequest : Form
    {
        BorrowRequestRepository borrowRequestRepository = new BorrowRequestRepository();

        RegisterBrBookRepository brBookRepository = new RegisterBrBookRepository();

        BookRepository bookRepository = new BookRepository();

        BorrowBookRepository borrowBookRepository = new BorrowBookRepository();

        EmployeeRepository employeeRepository = new EmployeeRepository();

        ViewedBookRepository viewedBookRepository = new ViewedBookRepository();


        public void loadRequestData()
        {
            var borrowRequestList = borrowRequestRepository.GetAll()
                .Include(x => x.Book)
                .Include(x => x.MemberCodeNavigation)
                .Select(x => new
                {
                    RequestId = x.RequestId,
                    BookId = x.BookId,
                    BookTitle = x.Book.Title,
                    MemberCode = x.MemberCode,
                    FullName = x.MemberCodeNavigation.FullName,
                    RequestDate = x.RequestDate,
                    Status = x.Status,

                }).Where(x => x.Status == "Pending").ToList();


            dgvBorrowRequest.DataSource = borrowRequestList;

            if (dgvBorrowRequest.Columns["Action"] == null)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Action";
                buttonColumn.Name = "Action";
                buttonColumn.Text = "Approve";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvBorrowRequest.Columns.Add(buttonColumn);
            }
        }
        public frmApproveBorrowRequest()
        {
            InitializeComponent();
            loadRequestData();
        }

        private void dgvBorrowRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvBorrowRequest.Columns["Action"].Index;
                if (e.ColumnIndex == index)
                {
                    int requestId = int.Parse(dgvBorrowRequest.Rows[e.RowIndex].Cells[1].Value.ToString());
                    var borrowRequest = borrowRequestRepository.GetAll().Where(x => x.RequestId == requestId).FirstOrDefault();
                    if (borrowRequest != null)
                    {
                        borrowRequest.Status = "Approved";
                        borrowRequestRepository.Update(borrowRequest);

                    }

                    int bookId;
                    if (int.TryParse(dgvBorrowRequest.Rows[e.RowIndex].Cells[2].Value.ToString(), out bookId))
                    {
                        var book = bookRepository.GetAll().Where(x => x.BookId == bookId).FirstOrDefault();
                        if (book != null)
                        {
                            book.Quantity--;
                            bookRepository.Update(book);
                        }
                    }

                    var employee = employeeRepository.GetAll().Where(x => x.Username == frmLogin.username).FirstOrDefault();
                    if (employee != null)
                    {
                        int employeeId = employee.EmployeeId;
                        BorrowRecord newBorrowRecord = new BorrowRecord
                        {
                            BookId = int.Parse(dgvBorrowRequest.Rows[e.RowIndex].Cells[2].Value.ToString()),
                            MemberCode = dgvBorrowRequest.Rows[e.RowIndex].Cells[4].Value.ToString(),
                            BorrowDate = DateTime.Today,
                            DueDate = DateTime.Today.AddDays(7),
                            ReturnStatus = "Not Returned",
                            EmployeeId = employeeId,
                        };
                        borrowBookRepository.Create(newBorrowRecord);

                        ViewedBook newViewBook = new ViewedBook
                        {
                            BookId = int.Parse(dgvBorrowRequest.Rows[e.RowIndex].Cells[2].Value.ToString()),
                            MemberCode = dgvBorrowRequest.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        };
                        viewedBookRepository.Create(newViewBook);

                        MessageBox.Show("Duyệt đăng ký mượn sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dgvBorrowRequest.Rows.RemoveAt(e.RowIndex);
                        loadRequestData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }
    }
}
