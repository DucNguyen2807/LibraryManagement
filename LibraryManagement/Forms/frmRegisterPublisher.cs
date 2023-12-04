using Data;
using Data.Models;
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

namespace LibraryManagement.Forms
{
    public partial class frmRegisterPublisher : Form
    {
        PublisherRepository publisherRepository = new PublisherRepository();
        public frmRegisterPublisher()
        {
            InitializeComponent();
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
                MessageBox.Show("Vui lòng nhập lại tên nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (Regex.IsMatch(name, namePattern) && name.Length >= 2);
        }

        private Boolean isValid()
        {
            if (string.IsNullOrEmpty(txt_publisherName.Text) ||
            string.IsNullOrEmpty(txt_address.Text) ||
            string.IsNullOrEmpty(txt_phoneNumber.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNameValid(txt_publisherName.Text) || !IsPhoneNumberValid(txt_phoneNumber.Text))
            {
                return false;
            }
            else return true;
        }

        private void refresh()
        {
            txt_publisherName.Clear();
            txt_address.Clear();
            txt_phoneNumber.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValid())
                {
                    return;
                }
                Publisher publisher = new Publisher();
                publisher.PublisherName = txt_publisherName.Text;
                publisher.Address = txt_address.Text;
                publisher.PhoneNumber = txt_phoneNumber.Text;

                publisherRepository.Create(publisher);
                MessageBox.Show("Thêm nhà xuất bản mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch
            {
                MessageBox.Show("Thêm nhà xuất bản mới thất bại mới thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
