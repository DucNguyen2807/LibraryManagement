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
    public partial class frmRegisterEmployee : Form
    {
        EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public frmRegisterEmployee()
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

        private bool isFill()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) ||
            string.IsNullOrEmpty(txtPassword.Text) ||
            string.IsNullOrEmpty(txtEmail.Text) ||
            string.IsNullOrEmpty(txtPhone.Text) ||
            string.IsNullOrEmpty(txtIDCard.Text) ||
            string.IsNullOrEmpty(txtAddress.Text) ||
            string.IsNullOrEmpty(txtFullName.Text) ||
            string.IsNullOrEmpty(cBRole.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsNameValid(txtFullName.Text) || !IsEmailValid(txtEmail.Text) || !IsPhoneNumberValid(txtPhone.Text) || !IsIDCardValid(txtIDCard.Text))
            {
                return false;
            }
            else return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isFill())
                {
                    return;
                }
                Employee employee = new Employee();
                if (EmployeeRepository.isUserNameExist(txtUsername.Text))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại.\nVui lòng nhập tên tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                employee.Username = txtUsername.Text;
                employee.Password = txtPassword.Text;
                employee.Email = txtEmail.Text;
                employee.PhoneNumber = txtPhone.Text;
                employee.Idcard = txtIDCard.Text;
                employee.Address = txtAddress.Text;
                employee.FullName = txtFullName.Text;
                employee.EmployeeType = cBRole.Text;
                employee.HireDate = dateTimeHire.Value;
                employee.Salary = Convert.ToDecimal(txtSalary.Text);
                EmployeeRepository.Create(employee);
                MessageBox.Show("Thêm tài khoản mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch
            {
                MessageBox.Show("Thêm tài khoản mới thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtIDCard.Clear();
            txtFullName.Clear();
            cBRole.SelectedIndex = -1;
            txtSalary.Clear();
        }
    }
}
