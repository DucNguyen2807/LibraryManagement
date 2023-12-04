using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dtgvUser.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            groupbox1.Enabled = false;
            loadUserData();
            refresh();
        }


        UserRepository userRepository = new UserRepository();
        private int selectedRowIndex;

        public void loadUserData()
        {
            var userList = userRepository.GetAll();
            dtgvUser.DataSource = userList.ToList();
            dtgvUser.Columns["BorrowRequests"].Visible = false;
            dtgvUser.Columns["LostBooks"].Visible = false;
            dtgvUser.Columns["Reviews"].Visible = false;
            dtgvUser.Columns["ViewedBooks"].Visible = false;
            dtgvUser.Columns["BorrowRecords"].Visible = false;
        }


        private bool isSelectIndex()
        {
            return selectedRowIndex >= 0;
        }

        private void refresh()
        {
            txt_memberCode.Clear();
            txt_fullName.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_phoneNumber.Clear();
            txt_idCard.Clear();
            radio_male.Checked = false;
            radio_female.Checked = false;
            dateOfBirth.Value = DateTime.Now;
            registrationDate.Value = DateTime.Now;
            txt_searchValue.Clear();
        }

        private bool IsEmailValid(string email)
        {
            string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Vui lòng nhập lại email.\nĐịnh dạng email là user@xyc.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string phonePattern = @"^\d{10}$";
            if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại.\nSố điện thoại gồm 10 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private bool IsNameValid(string name)
        {
            string namePattern = @"^[\p{L}\s]+$";
            if (!Regex.IsMatch(name, namePattern))
            {
                MessageBox.Show("Vui lòng nhập lại tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (Regex.IsMatch(name, namePattern) && name.Length >= 2);
        }

        private bool IsIDCardValid(string idCard)
        {
            string phonePattern = @"^\d{12}$";
            if (!Regex.IsMatch(idCard, phonePattern))
            {
                MessageBox.Show("Vui lòng nhập lại ID Card.\nID CARD gồm 12 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Regex.IsMatch(idCard, phonePattern);
        }

        private bool isValid()
        {
            if (string.IsNullOrEmpty(txt_fullName.Text) ||
            string.IsNullOrEmpty(txt_address.Text) ||
            string.IsNullOrEmpty(txt_email.Text) ||
            string.IsNullOrEmpty(txt_phoneNumber.Text) ||
            string.IsNullOrEmpty(txt_idCard.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsNameValid(txt_fullName.Text) || !IsPhoneNumberValid(txt_phoneNumber.Text) || !IsEmailValid(txt_email.Text) || !IsIDCardValid(txt_idCard.Text))
            {
                return false;
            }
            else return true;
        }

        private void viewUserListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedRowIndex = -1;
            groupbox1.Enabled = false;
            loadUserData();
            refresh();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegisterUser frmRegisterUser = new frmRegisterUser();
            frmRegisterUser.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                selectedRowIndex = e.RowIndex;
                txt_memberCode.Text = dtgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_email.Text = dtgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_phoneNumber.Text = dtgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_idCard.Text = dtgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_address.Text = dtgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_fullName.Text = dtgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
                string birthDateString = dtgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateTime dateOfBirth_;
                if (DateTime.TryParse(birthDateString, out dateOfBirth_))
                {
                    dateOfBirth.Value = dateOfBirth_;
                    dateOfBirth.Format = DateTimePickerFormat.Custom;
                    dateOfBirth.CustomFormat = "yyyy-MM-dd";
                }
                else
                {
                    MessageBox.Show("Không thể lấy ngày sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string gender = dtgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (gender.Equals("Male"))
                {
                    radio_male.Checked = true;
                    radio_female.Checked = false;
                }
                else
                {
                    radio_female.Checked = true;
                    radio_male.Checked = false;
                }

                string datetimeString = dtgvUser.Rows[e.RowIndex].Cells[9].Value.ToString();
                DateTime dateTimeRegister_;
                if (DateTime.TryParse(datetimeString, out dateTimeRegister_))
                {
                    registrationDate.Value = dateTimeRegister_;
                    registrationDate.Format = DateTimePickerFormat.Custom;
                    registrationDate.CustomFormat = "yyyy-MM-dd";
                }
                else
                {
                    MessageBox.Show("Không thể lấy ngày đăng kí", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmUserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn người dùng để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var userId = Convert.ToInt32(dtgvUser.Rows[selectedRowIndex].Cells[0].Value);
            var memberCode = txt_memberCode.Text;
            var fullname = txt_fullName.Text;
            var email = txt_email.Text;
            var phone = txt_phoneNumber.Text;
            var idCard = txt_idCard.Text;
            var address = txt_address.Text;
            var birthDate = dateOfBirth.Value;
            var registerDate = registrationDate.Value;
            string gender = null;
            if (radio_male.Checked)
            {
                gender = radio_male.Text;
            }
            else if (radio_female.Checked)
            {
                gender = radio_female.Text;
            }

            try
            {
                if (!isValid())
                {
                    return;
                }
                var currentUser = userRepository.GetAll().Where(x => x.UserId == userId).FirstOrDefault();
                if (currentUser != null)
                {
                    currentUser.Email = email;
                    currentUser.PhoneNumber = phone;
                    currentUser.Idcard = idCard;
                    currentUser.Address = address;
                    currentUser.FullName = fullname;
                    currentUser.BirthDate = birthDate;
                    currentUser.RegistrationDate = registerDate;
                    currentUser.Gender = gender;
                    userRepository.Update(currentUser);
                    MessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    loadUserData();
                    groupbox1.Enabled = false;
                    selectedRowIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn người dùng để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var userId = Convert.ToInt32(dtgvUser.Rows[selectedRowIndex].Cells[0].Value);
            try
            {
                var currentUser = userRepository.GetAll().Where(x => x.UserId == userId).FirstOrDefault();
                if (currentUser != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa người dùng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        userRepository.Delete(currentUser);
                        MessageBox.Show("Xóa người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                        loadUserData();
                    }
                    else
                    {
                        MessageBox.Show("Hủy xóa người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                        loadUserData();
                    }
                }
                groupbox1.Enabled = false;
                selectedRowIndex = -1;
            }
            catch
            {
                MessageBox.Show("Xóa tài khoản người dùng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                loadUserData();
            }
        }


        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            var searchValue = txt_searchValue.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập vào thông tin để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                return;
            }
            var searchUserByFullname = userRepository.GetAll()
                .Where(x => x.FullName.ToLower().Equals(searchValue.ToLower().Trim()) || x.FullName.ToLower().Contains(searchValue.ToLower().Trim())).ToList();

            var searchUserByMemberCode = userRepository.GetAll()
                .Where(x => x.MemberCode.ToLower().Equals(searchValue.ToLower().Trim()));

            if (searchUserByFullname.Count != 0)
            {
                dtgvUser.DataSource = searchUserByFullname.ToList();
                dtgvUser.Columns["BorrowRequests"].Visible = false;
                dtgvUser.Columns["LostBooks"].Visible = false;
                dtgvUser.Columns["Reviews"].Visible = false;
                dtgvUser.Columns["ViewedBooks"].Visible = false;
                dtgvUser.Columns["BorrowRecords"].Visible = false;
                refresh();
            }
            else if (searchUserByMemberCode.Count() != 0)
            {
                dtgvUser.DataSource = searchUserByMemberCode.ToList();
                dtgvUser.Columns["BorrowRequests"].Visible = false;
                dtgvUser.Columns["LostBooks"].Visible = false;
                dtgvUser.Columns["Reviews"].Visible = false;
                dtgvUser.Columns["ViewedBooks"].Visible = false;
                dtgvUser.Columns["BorrowRecords"].Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchUserToolStripMenuItem.Enabled = false;
                refresh();
            }
        }


        private void bACKTOMAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmLogin frmLogin = new frmLogin();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn người dùng để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupbox1.Enabled = true;
        }

        private void dtgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
            {
                if (e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }

            }
        }
    }
}
