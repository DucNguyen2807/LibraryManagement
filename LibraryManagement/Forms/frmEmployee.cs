using Data;
using Data.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    public partial class frmEmployee : Form
    {
        EmployeeRepository employeeRepository;
        private int selectedRowIndex = -1;
        public frmEmployee()
        {
            employeeRepository = new EmployeeRepository();
            InitializeComponent();
            var employees = employeeRepository.GetAll().ToList();
            dtgvEmployee.DataSource = employees;
            dtgvEmployee.Columns["BorrowRecords"].Visible = false;
            groupBox1.Enabled = false;
            txtUsername.Enabled = false;
            dtgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dtgvEmployee.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private bool isSelectIndex()
        {
            return selectedRowIndex >= 0;
        }


        private void bACKTOMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            frmMenu menu = new frmMenu(frmLogin.username);
            menu.ShowDialog();
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void dtgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                selectedRowIndex = e.RowIndex;
                txtUsername.Text = dtgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dtgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dtgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dtgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtIDCard.Text = dtgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dtgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtFullName.Text = dtgvEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
                cBRole.Text = dtgvEmployee.Rows[e.RowIndex].Cells[8].Value.ToString();
                string datetimeString = dtgvEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
                DateTime dateTimeHire_;
                if (DateTime.TryParse(datetimeString, out dateTimeHire_))
                {
                    dateTimeHire.Value = dateTimeHire_;
                    dateTimeHire.Format = DateTimePickerFormat.Custom;
                    dateTimeHire.CustomFormat = "yyyy-MM-dd";
                }
                else
                {
                    MessageBox.Show("Không thể lấy ngày bắt đầu làm việc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtSalary.Text = dtgvEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }



        private void dtgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void aDDNEWEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterEmployee frmRegisterEmployee = new frmRegisterEmployee();
            frmRegisterEmployee.ShowDialog();
        }

        private void rEFRESHLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employees = employeeRepository.GetAll().ToList();
            dtgvEmployee.DataSource = employees;
            dtgvEmployee.Columns["BorrowRecords"].Visible = false;
            selectedRowIndex = -1;
            groupBox1.Enabled = false;
            refresh();
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
            if (!Regex.IsMatch(name,namePattern))
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
            if(!IsNameValid(txtFullName.Text) || !IsEmailValid(txtEmail.Text) || !IsPhoneNumberValid(txtPhone.Text) || !IsIDCardValid(txtIDCard.Text))
            {
                return false;
            }
            else return true;
        }

        private void eDITEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn nhân viên để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBox1.Enabled = true;

        }

        private void uPDATEEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn nhân viên để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Employee employee = new Employee
            {
                EmployeeId = Convert.ToInt32(dtgvEmployee.Rows[selectedRowIndex].Cells[0].Value),
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Idcard = txtIDCard.Text,
                Address = txtAddress.Text,
                FullName = txtFullName.Text,
                EmployeeType = cBRole.Text,
                HireDate = dateTimeHire.Value,
                Salary = Convert.ToDecimal(txtSalary.Text)
            };
            dtgvEmployee.Rows[selectedRowIndex].Cells[1].Value = txtUsername.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[2].Value = txtPassword.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[3].Value = txtEmail.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[4].Value = txtPhone.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[5].Value = txtIDCard.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[6].Value = txtAddress.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[7].Value = txtFullName.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[8].Value = cBRole.Text;
            dtgvEmployee.Rows[selectedRowIndex].Cells[9].Value = dateTimeHire.Value;
            dtgvEmployee.Rows[selectedRowIndex].Cells[10].Value = txtSalary.Text;
            try
            {
                if (!isFill())
                {
                    return;
                }
                employeeRepository = new EmployeeRepository();
                employeeRepository.Update(employee);
                MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                refresh();
                selectedRowIndex = -1;
            }
            catch
            {
                MessageBox.Show("Cập nhật nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dELETEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSelectIndex())
            {
                MessageBox.Show("Vui lòng chọn nhân viên để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Employee employee = new Employee
                {
                    EmployeeId = Convert.ToInt32(dtgvEmployee.Rows[selectedRowIndex].Cells[0].Value),
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhone.Text,
                    Idcard = txtIDCard.Text,
                    Address = txtAddress.Text,
                    FullName = txtFullName.Text,
                    EmployeeType = cBRole.Text,
                    HireDate = dateTimeHire.Value,
                    Salary = Convert.ToDecimal(txtSalary.Text)
                };
                try
                {
                    employeeRepository = new EmployeeRepository();
                    employeeRepository.Delete(employee);
                    MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    selectedRowIndex = -1;
                }
                catch
                {
                    MessageBox.Show("Xóa tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy xóa nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                selectedRowIndex = -1;
            }
        }

        private void sEARCHBYUSERNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetAll().ToList();
            var employeesWithDesiredUsername = employees.Where(employee => employee.Username == txtSearch.Text).ToList();
            if (employeesWithDesiredUsername.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }
            dtgvEmployee.DataSource = employeesWithDesiredUsername;
            dtgvEmployee.Columns["BorrowRecords"].Visible = false;
            dtgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dtgvEmployee.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}