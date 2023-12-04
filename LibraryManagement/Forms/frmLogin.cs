using Azure.Identity;
using Data;

namespace LibraryManagement
{
    public partial class frmLogin : Form
    {
        public static string username = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        EmployeeRepository EmployeeRepository = new EmployeeRepository();

        private void cbHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (EmployeeRepository.CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                frmMenu frmMenu = new frmMenu(txtUsername.Text);
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại" , "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu(""); 
            frm.ShowDialog();
        }
    }
}