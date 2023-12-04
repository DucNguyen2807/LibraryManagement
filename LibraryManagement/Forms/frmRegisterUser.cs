using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmRegisterUser : Form
    {
        UserRepository userRepository = new UserRepository();
        public frmRegisterUser()
        {
            InitializeComponent();
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

        private string randomMemberCode()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100000);

            string formattedNumber = randomNumber.ToString("D3");

            string memberCode = "USR" + formattedNumber;

            return memberCode;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValid())
                {
                    return;
                }
                User user = new User();
                user.FullName = txt_fullName.Text;
                user.Email = txt_email.Text;
                user.PhoneNumber = txt_phoneNumber.Text;
                user.Idcard = txt_idCard.Text;
                user.Address = txt_address.Text;
                if (radio_male.Checked)
                {
                    user.Gender = radio_male.Text;
                }
                else if (radio_female.Checked)
                {
                    user.Gender = radio_female.Text;
                }
                user.BirthDate = dateOfBirth.Value;
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                user.RegistrationDate = DateTime.ParseExact(formattedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                user.MemberCode = randomMemberCode();
                userRepository.Create(user);
                MessageBox.Show("Thêm tài khoản người dùng mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch
            {
                MessageBox.Show("Thêm tài khoản người dùng mới thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void refresh()
        {
            txt_fullName.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_phoneNumber.Clear();
            txt_idCard.Clear();
            radio_male.Checked = false;
            radio_female.Checked = false;
            dateOfBirth.Value = DateTime.Now;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void frmRegisterUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
