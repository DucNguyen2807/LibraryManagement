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
    public partial class frmViewFeedback : Form
    {
        private ReviewRepository ReviewBookRepository;
        public frmViewFeedback()
        {
            InitializeComponent();
            ReviewBookRepository = new ReviewRepository();
            dgvReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dgvReview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            LoadBooks();
        }

        private void LoadBooks()
        {

            var allReview = ReviewBookRepository.GetAll()
                  .Include(p => p.Book)
                  .Include(p => p.MemberCodeNavigation)
                            .Select(p => new
                            {
                                ReviewID = p.ReviewId,
                                MemmberCode = p.MemberCode,
                                MemberName = p.MemberCodeNavigation.FullName,
                                BookTitle = p.Book.Title,
                                DateOfReview = p.ReviewDate,
                                Rating = p.Rating,
                                Comment = p.Comment
                            }).ToList();

            dgvReview.DataSource = allReview;
        }

        private void rEFRESHLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void bACKTOMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }
    }
}
