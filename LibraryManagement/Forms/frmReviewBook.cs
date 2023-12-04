using Data.Models;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LibraryManagement
{
    public partial class frmReviewBook : Form
    {
        private ReviewRepository ReviewBookRepository;
        public frmReviewBook()
        {
            InitializeComponent();
            ReviewBookRepository = new ReviewRepository();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string memberCode = txtMemberCode.Text;
                string bookNamebr = txtBookName.Text;
                string rateStr = cbRate.SelectedItem.ToString();
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                DateTime rateDate = DateTime.ParseExact(formattedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string comment = txtComment.Text;

                if (string.IsNullOrEmpty(memberCode) || string.IsNullOrEmpty(bookNamebr) || string.IsNullOrEmpty(rateStr) || rateDate == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin đánh giá.");
                }
                else
                {
                    if (int.TryParse(rateStr, out int rate))
                    {
                        using (var context = new LibraryManagementContext())
                        {
                            var existingMember = context.Users.FirstOrDefault(m => m.MemberCode == memberCode);

                            if (existingMember != null)
                            {
                                var existingBook = context.Books.FirstOrDefault(b => b.BookId == int.Parse(bookNamebr));
                                if (existingBook != null)
                                {
                                    var review = new Review
                                    {
                                        MemberCode = existingMember.MemberCode,
                                        BookId = existingBook.BookId,
                                        Rating = rate,
                                        ReviewDate = rateDate,
                                        Comment = comment
                                    };

                                    context.Reviews.Add(review);
                                    context.SaveChanges();
                                    MessageBox.Show("Đánh giá đã được ghi nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Sách không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thành viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đánh giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBookName.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
