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
using System.Text.RegularExpressions;
namespace LibraryManagement
{
    public partial class frmBookManagement : Form
    {
        BooksRepository booksRepository;
        private int selectedRowIndex = -1;
        public frmBookManagement()
        {
            booksRepository = new BooksRepository();
            InitializeComponent();
            groupBox1.Enabled = false;
            txtAuthor.Enabled = false;
            txtTitle.Enabled = false;
            cmbGenre.Enabled = false;
            txtPublisherID.Enabled = false;
            LoadBooks();
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgvBooks.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void LoadBooks()
        {
            var allBooks = booksRepository.GetAll().ToList();
            dgvBooks.DataSource = allBooks;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBooks.Columns["Publisher"].Visible = false;
            dgvBooks.Columns["BookLocations"].Visible = false;
            dgvBooks.Columns["BorrowRecords"].Visible = false;
            dgvBooks.Columns["BorrowRequests"].Visible = false;
            dgvBooks.Columns["LostBooks"].Visible = false;
            dgvBooks.Columns["Reviews"].Visible = false;
            dgvBooks.Columns["ViewedBooks"].Visible = false;
            foreach (DataGridViewColumn column in dgvBooks.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private bool isSelectIndex()
        {
            return selectedRowIndex >= 0;
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bookId = Convert.ToInt32(dgvBooks.Rows[selectedRowIndex].Cells[0].Value);
            var year = int.Parse(txtPublicationYear.Text.ToString());
            var isbn = txtISBN.Text;
            var quantity = (int)nudQuantity.Value;
            var description = txtDescription.Text;
            try
            {
                if (!missFill())
                {
                    return;
                }
                var currentBook = booksRepository.GetAll().Where(x => x.BookId == bookId).FirstOrDefault();
                if (currentBook != null)
                {
                    currentBook.PublicationYear = year;
                    currentBook.Isbn = isbn;
                    currentBook.Quantity = quantity;
                    currentBook.Description = description;
                    booksRepository.Update(currentBook);
                    MessageBox.Show("Cập nhật thông tin sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = false;
                    selectedRowIndex = -1;
                    refresh();
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadBooks();
        }

        private bool missFill()
        {
            if (string.IsNullOrEmpty(txtTitle.Text) ||
                     string.IsNullOrEmpty(txtAuthor.Text) ||
                     string.IsNullOrEmpty(txtPublicationYear.Text) ||
                     string.IsNullOrEmpty(txtISBN.Text) ||
                     string.IsNullOrEmpty(nudQuantity.Value.ToString()) ||
                     cmbGenre.SelectedItem == null ||
                     string.IsNullOrEmpty(txtDescription.Text) ||
                     string.IsNullOrEmpty(txtPublisherID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsISBNValid(txtISBN.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin ISBN sách \n ISBN sách bao gồm 10 hoặc 13 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;

        }
        private bool IsISBNValid(string isbn)
        {
            // Remove any hyphens or spaces from the ISBN.
            isbn = isbn.Replace("-", "").Replace(" ", "");

            // Check the length of the cleaned ISBN.
            if (isbn.Length != 10 && isbn.Length != 13)
            {
                return false;
            }

            if (isbn.Length == 10)
            {
                // Validate ISBN-10.
                int checksum = 0;

                for (int i = 0; i < 9; i++)
                {
                    if (!char.IsDigit(isbn[i]))
                    {
                        return false;
                    }

                    checksum += (10 - i) * int.Parse(isbn[i].ToString());
                }

                if (isbn[9] == 'X')
                {
                    checksum += 10;
                }
                else if (char.IsDigit(isbn[9]))
                {
                    checksum += int.Parse(isbn[9].ToString());
                }
                else
                {
                    return false;
                }

                return checksum % 11 == 0;
            }
            else if (isbn.Length == 13)
            {
                // Validate ISBN-13.
                int checksum = 0;
                bool alternate = false;

                for (int i = isbn.Length - 1; i >= 0; i--)
                {
                    if (!char.IsDigit(isbn[i]))
                    {
                        return false;
                    }

                    int digit = int.Parse(isbn[i].ToString());

                    if (alternate)
                    {
                        checksum += 3 * digit;
                    }
                    else
                    {
                        checksum += digit;
                    }

                    alternate = !alternate;
                }

                return checksum % 10 == 0;
            }

            return false;
        }

        private void aDDNEWBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook frmAddBook = new frmAddBook();
            frmAddBook.ShowDialog();
        }

        private void eDITBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBox1.Enabled = true;
        }

        private void dELETEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn sách để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bookId = Convert.ToInt32(dgvBooks.Rows[selectedRowIndex].Cells[0].Value);
            var currentBook = booksRepository.GetAll().Where(x => x.BookId == bookId).FirstOrDefault();
            if (currentBook != null)
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xóa sách này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    booksRepository.Delete(currentBook);
                    MessageBox.Show("Đã xóa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedRowIndex = -1;
                    groupBox1.Enabled = false;
                    refresh();
                }
                else
                {
                    MessageBox.Show("Hủy xóa sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedRowIndex = -1;
                    groupBox1.Enabled = false;
                    refresh();
                }
            }
        }

        private void rEFRESHLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedRowIndex = -1;
            groupBox1.Enabled = false;
            LoadBooks();
            refresh();

        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booksRepository = new BooksRepository();
            var books = booksRepository.GetAll().ToList();
            var booksWithTitle = books.Where(book => book.Title.ToLower().Equals(txtSearch.Text.ToLower()) || book.Title.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            if (booksWithTitle.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvBooks.DataSource = booksWithTitle;
                dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvBooks.Columns["Publisher"].Visible = false;
                dgvBooks.Columns["BookLocations"].Visible = false;
                dgvBooks.Columns["BorrowRecords"].Visible = false;
                dgvBooks.Columns["BorrowRequests"].Visible = false;
                dgvBooks.Columns["LostBooks"].Visible = false;
                dgvBooks.Columns["Reviews"].Visible = false;
                dgvBooks.Columns["ViewedBooks"].Visible = false;
                foreach (DataGridViewColumn column in dgvBooks.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void refresh()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublicationYear.Clear();
            txtISBN.Clear();
            nudQuantity.Value = 0;
            cmbGenre.SelectedIndex = -1;
            txtDescription.Clear();
            txtPublisherID.Clear();
        }

        private void bACKTOMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void dgvBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (e.RowIndex < 0)
                    {
                        return;
                    }
                    selectedRowIndex = e.RowIndex;
                    var title = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var author = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var year = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                    var isbn = dgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                    var quantity = dgvBooks.Rows[e.RowIndex].Cells[5].Value.ToString();
                    var genre = dgvBooks.Rows[e.RowIndex].Cells[6].Value.ToString();
                    var description = dgvBooks.Rows[e.RowIndex].Cells[7].Value.ToString();
                    var publisherid = dgvBooks.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtTitle.Text = title;
                    txtAuthor.Text = author;
                    txtPublicationYear.Text = year;
                    txtISBN.Text = isbn;
                    nudQuantity.Value = int.Parse(quantity);
                    cmbGenre.Text = genre;
                    txtDescription.Text = description;
                    txtPublisherID.Text = publisherid;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(nudQuantity.Value) > 500)
            {
                MessageBox.Show("Số lượng sách phải nhỏ hơn 500", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPublicationYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPublicationYear.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBookManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
