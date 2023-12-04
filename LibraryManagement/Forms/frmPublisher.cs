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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.Forms
{
    public partial class frmPublisher : Form
    {


        public frmPublisher()
        {
            InitializeComponent();
            dgvPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dgvPublisher.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            groupBox1.Enabled = false;
            loadPublisherData();
        }

        PublisherRepository publisherRepository = new PublisherRepository();
        private int selectedRowIndex;

        public void loadPublisherData()
        {
            var publisherList = publisherRepository.GetAll();
            dgvPublisher.DataSource = publisherList.ToList();
            dgvPublisher.Columns["Books"].Visible = false;
        }

        private bool isSelectedIndex()
        {
            return selectedRowIndex >= 0;
        }

        private void refresh()
        {
            txt_publisherName.Clear();
            txt_address.Clear();
            txt_phoneNumber.Clear();
            txt_searchValue.Clear();
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

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPublisherData();
            refresh();
        }

        private void dgvPublisher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                selectedRowIndex = e.RowIndex;
                txt_publisherName.Text = dgvPublisher.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_address.Text = dgvPublisher.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_phoneNumber.Text = dgvPublisher.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectedIndex())
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBox1.Enabled = true;
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectedIndex())
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var publisherId = Convert.ToInt32(dgvPublisher.Rows[selectedRowIndex].Cells[0].Value);
            var publisherName = txt_publisherName.Text;
            var address = txt_address.Text;
            var phoneNumber = txt_phoneNumber.Text;
            try
            {
                if (!isValid())
                {
                    return;
                }
                var currentPublisher = publisherRepository.GetAll().Where(x => x.PublisherId == publisherId).FirstOrDefault();
                if (currentPublisher != null)
                {
                    currentPublisher.PublisherName = publisherName;
                    currentPublisher.Address = address;
                    currentPublisher.PhoneNumber = phoneNumber;
                    publisherRepository.Update(currentPublisher);
                    MessageBox.Show("Cập nhật thông tin nhà xuất bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    loadPublisherData();
                    groupBox1.Enabled = false;
                    selectedRowIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectedIndex())
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var publisherId = Convert.ToInt32(dgvPublisher.Rows[selectedRowIndex].Cells[0].Value);
            try
            {
                var currentPublisher = publisherRepository.GetAll().Where(x => x.PublisherId == publisherId).FirstOrDefault();
                if (currentPublisher != null)
                {
                    DialogResult result = MessageBox.Show("Xác nhận xóa thông tin nhà xuất bản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        publisherRepository.Delete(currentPublisher);
                        MessageBox.Show("Xóa thông tin nhà xuất bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                        loadPublisherData();
                    }
                    else
                    {
                        MessageBox.Show("Hủy xóa thông tin nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                        loadPublisherData();
                    }
                }
                groupBox1.Enabled = false;
                selectedRowIndex = -1;
            }
            catch
            {
                MessageBox.Show("Xóa thông tin nhà xuất bản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                loadPublisherData();
            }
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publisherRepository = new PublisherRepository();
            var searchValue = txt_searchValue.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập vào thông tin để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                return;
            }

            var searchPublisher = publisherRepository.GetAll()
                .Where(x => x.PublisherName.ToLower().Equals(searchValue.ToLower().Trim()) || x.PublisherName.ToLower().Contains(searchValue.ToLower().Trim())).ToList();

            if (searchPublisher.Count != 0)
            {
                dgvPublisher.DataSource = searchPublisher.ToList();
                dgvPublisher.Columns["Books"].Visible = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void bACKTOMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void aDDPUBLISHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterPublisher frmPublisherRegister = new frmRegisterPublisher();
            frmPublisherRegister.ShowDialog();

        }
    }
}
