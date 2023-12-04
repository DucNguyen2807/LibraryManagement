namespace LibraryManagement
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabAdmin = new TabPage();
            label1 = new Label();
            cBFunctionAdmin = new ComboBox();
            lblLogoutAdmin = new LinkLabel();
            tabEmployee = new TabPage();
            label2 = new Label();
            cbFunctionEmployee = new ComboBox();
            lblLogoutEmployee = new LinkLabel();
            tabGuest = new TabPage();
            label3 = new Label();
            cBFunctionGuest = new ComboBox();
            lblReturn = new LinkLabel();
            tabControl1.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabEmployee.SuspendLayout();
            tabGuest.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAdmin);
            tabControl1.Controls.Add(tabEmployee);
            tabControl1.Controls.Add(tabGuest);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(645, 162);
            tabControl1.TabIndex = 9;
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = SystemColors.Control;
            tabAdmin.Controls.Add(label1);
            tabAdmin.Controls.Add(cBFunctionAdmin);
            tabAdmin.Controls.Add(lblLogoutAdmin);
            tabAdmin.Location = new Point(4, 32);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(637, 126);
            tabAdmin.TabIndex = 0;
            tabAdmin.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 12;
            label1.Text = "CHỌN CHỨC NĂNG :";
            // 
            // cBFunctionAdmin
            // 
            cBFunctionAdmin.AllowDrop = true;
            cBFunctionAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cBFunctionAdmin.FormattingEnabled = true;
            cBFunctionAdmin.Items.AddRange(new object[] { "Quản lý nhân viên", "Quản lý thành viên" });
            cBFunctionAdmin.Location = new Point(237, 49);
            cBFunctionAdmin.Name = "cBFunctionAdmin";
            cBFunctionAdmin.Size = new Size(220, 31);
            cBFunctionAdmin.TabIndex = 11;
            cBFunctionAdmin.SelectedIndexChanged += cBFunctionAdmin_SelectedIndexChanged;
            // 
            // lblLogoutAdmin
            // 
            lblLogoutAdmin.AutoSize = true;
            lblLogoutAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogoutAdmin.LinkColor = Color.Red;
            lblLogoutAdmin.Location = new Point(473, 52);
            lblLogoutAdmin.Name = "lblLogoutAdmin";
            lblLogoutAdmin.Size = new Size(79, 23);
            lblLogoutAdmin.TabIndex = 10;
            lblLogoutAdmin.TabStop = true;
            lblLogoutAdmin.Text = "LOGOUT";
            lblLogoutAdmin.LinkClicked += lblLogoutAdmin_LinkClicked;
            // 
            // tabEmployee
            // 
            tabEmployee.BackColor = SystemColors.Control;
            tabEmployee.Controls.Add(label2);
            tabEmployee.Controls.Add(cbFunctionEmployee);
            tabEmployee.Controls.Add(lblLogoutEmployee);
            tabEmployee.Location = new Point(4, 32);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(637, 126);
            tabEmployee.TabIndex = 1;
            tabEmployee.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 54);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 14;
            label2.Text = "CHỌN CHỨC NĂNG :";
            // 
            // cbFunctionEmployee
            // 
            cbFunctionEmployee.AllowDrop = true;
            cbFunctionEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFunctionEmployee.FormattingEnabled = true;
            cbFunctionEmployee.Items.AddRange(new object[] { "Quản lý toàn bộ sách", "Quản lý sách trong kho", "Quản lý sách cho mượn", "Xem Feedback", "Quản lý nhà xuất bản", "Duyệt đăng ký mượn sách", "Quản lí thành viên" });
            cbFunctionEmployee.Location = new Point(229, 51);
            cbFunctionEmployee.Name = "cbFunctionEmployee";
            cbFunctionEmployee.Size = new Size(220, 31);
            cbFunctionEmployee.TabIndex = 13;
            cbFunctionEmployee.SelectedIndexChanged += cbFunctionEmployee_SelectedIndexChanged;
            // 
            // lblLogoutEmployee
            // 
            lblLogoutEmployee.AutoSize = true;
            lblLogoutEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogoutEmployee.LinkColor = Color.Red;
            lblLogoutEmployee.Location = new Point(464, 54);
            lblLogoutEmployee.Name = "lblLogoutEmployee";
            lblLogoutEmployee.Size = new Size(79, 23);
            lblLogoutEmployee.TabIndex = 11;
            lblLogoutEmployee.TabStop = true;
            lblLogoutEmployee.Text = "LOGOUT";
            lblLogoutEmployee.LinkClicked += lblLogoutEmployee_LinkClicked;
            // 
            // tabGuest
            // 
            tabGuest.BackColor = SystemColors.Control;
            tabGuest.Controls.Add(label3);
            tabGuest.Controls.Add(cBFunctionGuest);
            tabGuest.Controls.Add(lblReturn);
            tabGuest.Location = new Point(4, 29);
            tabGuest.Name = "tabGuest";
            tabGuest.Size = new Size(637, 129);
            tabGuest.TabIndex = 2;
            tabGuest.Text = "Guest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 53);
            label3.Name = "label3";
            label3.Size = new Size(178, 23);
            label3.TabIndex = 16;
            label3.Text = "CHỌN CHỨC NĂNG :";
            // 
            // cBFunctionGuest
            // 
            cBFunctionGuest.AllowDrop = true;
            cBFunctionGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cBFunctionGuest.FormattingEnabled = true;
            cBFunctionGuest.Items.AddRange(new object[] { "Đăng kí mượn sách", "Gửi Feedback", "Xem sách đã mượn" });
            cBFunctionGuest.Location = new Point(203, 50);
            cBFunctionGuest.Name = "cBFunctionGuest";
            cBFunctionGuest.Size = new Size(220, 31);
            cBFunctionGuest.TabIndex = 15;
            cBFunctionGuest.SelectedIndexChanged += cBFunctionGuest_SelectedIndexChanged;
            // 
            // lblReturn
            // 
            lblReturn.AutoSize = true;
            lblReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturn.LinkColor = Color.Red;
            lblReturn.Location = new Point(442, 53);
            lblReturn.Name = "lblReturn";
            lblReturn.Size = new Size(187, 23);
            lblReturn.TabIndex = 13;
            lblReturn.TabStop = true;
            lblReturn.Text = "RETURN LOGIN FORM";
            lblReturn.LinkClicked += lblReturn_LinkClicked;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 162);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU FORM";
            FormClosing += frmMenu_FormClosing;
            tabControl1.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            tabEmployee.ResumeLayout(false);
            tabEmployee.PerformLayout();
            tabGuest.ResumeLayout(false);
            tabGuest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabAdmin;
        private TabPage tabEmployee;
        private TabPage tabGuest;
        private LinkLabel lblLogoutAdmin;
        private LinkLabel lblLogoutEmployee;
        private LinkLabel lblReturn;
        private ComboBox cBFunctionAdmin;
        private Label label1;
        private Label label2;
        private ComboBox cbFunctionEmployee;
        private Label label3;
        private ComboBox cBFunctionGuest;
    }
}