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

namespace LibraryManagement
{
    public partial class frmBookLocation : Form
    {
        private BookRepository bookRepository;
        private BookLocationRepository bookLocationRepository;
        private int selectedRowIndex = -1;

        private bool isSelectIndex()
        {
            return selectedRowIndex >= 0;
        }

        public frmBookLocation()
        {
            bookLocationRepository = new BookLocationRepository();
            bookRepository = new BookRepository();
            InitializeComponent();
            dgvLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dgvLocation.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            updateGridView();
            groupBox1.Enabled = false;
        }

        public void updateGridView()
        {

            var bookLocations = bookLocationRepository.GetAll().Include(x => x.Book).ToList();
            if (bookLocations != null)
            {
                var bookLocationList = bookLocations.ToList();
                dgvLocation.DataSource = bookLocationList.Select(x => new
                {
                    LocationId = x.LocationId,
                    BookTitle = x.Book.Title,
                    Shelf = x.Shelf,
                    Column = x.ColumnShelf,
                    Row = x.RowShelf

                }).ToList();
            }
        }

        private void dgvLocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                var row = dgvLocation.Rows[e.RowIndex];
                selectedRowIndex = e.RowIndex;
                txtBookTitle.Text = row.Cells[1].Value.ToString();
                txtShelf.Text = row.Cells[2].Value.ToString();
                txtShelfColumn.Text = row.Cells[3].Value.ToString();
                txtShelfRow.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearTextBox()
        {
            txtBookTitle.Text = string.Empty;
            txtShelf.Text = string.Empty;
            txtShelfColumn.Text = string.Empty;
            txtShelfRow.Text = string.Empty;
        }

        private void txtShelf_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtShelf.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShelf.Text = txtShelf.Text.Remove(txtShelf.Text.Length - 1);
            }
        }

        private void txtShelfColumn_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtShelfColumn.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShelfColumn.Text = txtShelfColumn.Text.Remove(txtShelfColumn.Text.Length - 1);
            }
        }

        private void txtShelfRow_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtShelfRow.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.");
                txtShelfRow.Text = txtShelfRow.Text.Remove(txtShelfRow.Text.Length - 1);
            }
        }

        private void addBookToShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!groupBox1.Enabled)
            {
                groupBox1.Enabled = true;
                MessageBox.Show("Hãy điền thông tin vị trí của sách rồi nhấn ADD BOOK TO SHELF", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtShelf.Text) ||
                string.IsNullOrWhiteSpace(txtShelfColumn.Text) ||
                string.IsNullOrWhiteSpace(txtShelfRow.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int bookId = bookRepository.GetBookIdByTitle(txtBookTitle.Text);
            if (bookId == -1)
            {
                MessageBox.Show("Sách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                BookLocation bookLocation = new BookLocation
                {

                    BookId = bookRepository.GetBookIdByTitle(txtBookTitle.Text),
                    Shelf = int.Parse(txtShelf.Text),
                    ColumnShelf = int.Parse(txtShelfColumn.Text),
                    RowShelf = int.Parse(txtShelfRow.Text)
                };
                if (bookLocationRepository.IsLocationEmpty(bookLocation))
                {
                    bookLocationRepository.Create(bookLocation);
                    MessageBox.Show("Thêm sách vào kệ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateGridView();
                    clearTextBox();
                    groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vị trí không thể trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtShelf.Text) ||
                string.IsNullOrWhiteSpace(txtShelfColumn.Text) ||
                string.IsNullOrWhiteSpace(txtShelfRow.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int bookId = bookRepository.GetBookIdByTitle(txtBookTitle.Text);
            if (bookId == -1)
            {
                MessageBox.Show("Sách không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                BookLocation? bookLocation = bookLocationRepository.GetLocationById(Convert.ToInt32(dgvLocation.Rows[selectedRowIndex].Cells[0].Value));
                bookLocation.BookId = bookRepository.GetBookIdByTitle(txtBookTitle.Text);
                bookLocation.Shelf = int.Parse(txtShelf.Text);
                bookLocation.ColumnShelf = int.Parse(txtShelfColumn.Text);
                bookLocation.RowShelf = int.Parse(txtShelfRow.Text);
                if (bookLocationRepository.IsLocationEmpty(bookLocation))
                {
                    bookLocationRepository.Update(bookLocation);
                    MessageBox.Show("Thêm sách vào kệ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateGridView();
                    clearTextBox();
                    selectedRowIndex = -1;
                    groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void deleteBookFromShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var locationId = Convert.ToInt32(dgvLocation.Rows[selectedRowIndex].Cells[0].Value);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách khỏi kệ ?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool deleted = bookLocationRepository.DeleteLocation(locationId);

                if (deleted)
                {
                    MessageBox.Show("Xóa sách khỏi kệ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateGridView();
                    clearTextBox();
                    selectedRowIndex = -1;
                    groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi kệ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTextBox();
                }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookIdToSearch = 0;
            var query = bookLocationRepository.GetAll()
                .Include(location => location.Book)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                bookIdToSearch = bookRepository.GetBookIdByTitle(txtSearch.Text);
                if (bookIdToSearch > 0)
                {
                    query = query.Where(location => location.BookId == bookIdToSearch);
                }
                else
                {
                    MessageBox.Show("Sách không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Text = String.Empty;
                    updateGridView();
                    return;
                }
            }
            int shelf, column, row;
            if (int.TryParse(txtShelf.Text, out shelf))
            {
                query = query.Where(location => location.Shelf == shelf);
            }
            if (int.TryParse(txtShelfColumn.Text, out column))
            {
                query = query.Where(location => location.ColumnShelf == column);
            }
            if (int.TryParse(txtShelfRow.Text, out row))
            {
                query = query.Where(location => location.RowShelf == row);
            }
            var filteredLocations = query.ToList();
            dgvLocation.DataSource = filteredLocations.Select(x => new
            {
                LocationId = x.LocationId,
                BookTitle = x.Book.Title,
                Shelf = x.Shelf,
                Column = x.ColumnShelf,
                Row = x.RowShelf
            }).ToList();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void frmBookLocation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBookTitle.Text = string.Empty;
            txtShelf.Text = string.Empty;
            txtShelfColumn.Text = string.Empty;
            txtShelfRow.Text = string.Empty;
        }

        private void eDITBOOKINSHELFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBox1.Enabled = true;
        }
    }
}
