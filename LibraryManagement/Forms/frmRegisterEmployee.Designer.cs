namespace LibraryManagement
{
    partial class frmRegisterEmployee
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
            groupBox1 = new GroupBox();
            btn_refresh = new Button();
            btnRegister = new Button();
            dateTimeHire = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            txtSalary = new TextBox();
            label9 = new Label();
            label8 = new Label();
            cBRole = new ComboBox();
            label7 = new Label();
            txtFullName = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtIDCard = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_refresh);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(dateTimeHire);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cBRole);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtIDCard);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 530);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "EMPLOYEE REGISTER";
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(231, 479);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(161, 37);
            btn_refresh.TabIndex = 32;
            btn_refresh.Text = "REFRESH";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(14, 477);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(201, 39);
            btnRegister.TabIndex = 31;
            btnRegister.Text = "ADD NEW EMPLOYEE";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // dateTimeHire
            // 
            dateTimeHire.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeHire.CustomFormat = "yyyy-MM-dd";
            dateTimeHire.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeHire.Format = DateTimePickerFormat.Custom;
            dateTimeHire.Location = new Point(126, 388);
            dateTimeHire.Name = "dateTimeHire";
            dateTimeHire.Size = new Size(188, 30);
            dateTimeHire.TabIndex = 30;
            dateTimeHire.Value = new DateTime(2023, 10, 26, 10, 8, 30, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(321, 431);
            label11.Name = "label11";
            label11.Size = new Size(86, 23);
            label11.TabIndex = 29;
            label11.Text = "per hours";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(45, 431);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 28;
            label10.Text = "Salary :";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(126, 430);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(188, 30);
            txtSalary.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 388);
            label9.Name = "label9";
            label9.Size = new Size(97, 23);
            label9.TabIndex = 25;
            label9.Text = "Hire Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(58, 345);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 24;
            label8.Text = "Role :";
            // 
            // cBRole
            // 
            cBRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cBRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cBRole.FormattingEnabled = true;
            cBRole.Items.AddRange(new object[] { "Admin", "Librarian", "Researcher" });
            cBRole.Location = new Point(126, 342);
            cBRole.Name = "cBRole";
            cBRole.Size = new Size(188, 31);
            cBRole.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 300);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 22;
            label7.Text = "Full Name :";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(125, 300);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(189, 30);
            txtFullName.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 256);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 20;
            label6.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(125, 256);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(189, 30);
            txtAddress.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 211);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 18;
            label5.Text = "ID Card :";
            // 
            // txtIDCard
            // 
            txtIDCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDCard.Location = new Point(125, 211);
            txtIDCard.Name = "txtIDCard";
            txtIDCard.Size = new Size(189, 30);
            txtIDCard.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 171);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 16;
            label4.Text = "Phone :";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(126, 168);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 30);
            txtPhone.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(126, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 30);
            txtEmail.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 126);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 13;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 11;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 10;
            label1.Text = "Username :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(126, 81);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 30);
            txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(126, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 30);
            txtUsername.TabIndex = 8;
            // 
            // frmRegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 530);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegisterEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM NHÂN VIÊN MỚI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimeHire;
        private Label label11;
        private Label label10;
        private TextBox txtSalary;
        private Label label9;
        private Label label8;
        private ComboBox cBRole;
        private Label label7;
        private TextBox txtFullName;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtIDCard;
        private Label label4;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btn_refresh;
    }
}