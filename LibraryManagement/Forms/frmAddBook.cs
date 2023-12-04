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
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    public partial class frmAddBook : Form
    {
        BooksRepository booksRepository;

        PublisherRepository publisherRepository;
        public frmAddBook()
        {
            InitializeComponent();
            booksRepository = new BooksRepository();
            publisherRepository = new PublisherRepository();    
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
            if (!IsNameValid(txtAuthor.Text)){
                MessageBox.Show("Vui lòng nhập lại tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;

        }

        private bool IsNameValid(string name)
        {
            string namePattern = @"^[\p{L}\s]+$";
            return (Regex.IsMatch(name, namePattern) && name.Length >= 2);
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

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!missFill())
            {
                return;
            }
            try
            {
                var books = new Book();
                books.Title = txtTitle.Text;
                books.Author = txtAuthor.Text;
                books.PublicationYear = int.Parse(txtPublicationYear.Text.ToString());
                books.Isbn = txtISBN.Text.ToUpper();
                books.Quantity = (int)nudQuantity.Value;
                books.Genre = cmbGenre.SelectedItem.ToString();
                books.Description = txtDescription.Text;
                books.PublisherId = int.Parse(txtPublisherID.Text.ToString());


                if (publisherRepository.isPublisherExist(int.Parse(txtPublisherID.Text.ToString())))
                {
                    if (booksRepository.isISBNExist(txtISBN.Text))
                    {
                        MessageBox.Show("ISBN tồn tại. Vui Lòng Nhập ISBN khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        booksRepository.Create(books);
                        MessageBox.Show("Thêm sách mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show("PublisherID không tồn tại. Vui Lòng Nhập Đúng PublisherID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
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

        private void txtPublisherID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPublisherID.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
