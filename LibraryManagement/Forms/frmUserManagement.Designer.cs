namespace LibraryManagement
{
    partial class frmUserManagement
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
            dtgvUser = new DataGridView();
            menuStrip1 = new MenuStrip();
            RegisterNewUserToolStripMenuItem = new ToolStripMenuItem();
            eDITUSERToolStripMenuItem = new ToolStripMenuItem();
            updateUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            searchUserToolStripMenuItem = new ToolStripMenuItem();
            viewUserListToolStripMenuItem = new ToolStripMenuItem();
            bACKTOMAINMENUToolStripMenuItem = new ToolStripMenuItem();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txt_searchValue = new TextBox();
            groupbox1 = new GroupBox();
            label2 = new Label();
            registrationDate = new DateTimePicker();
            label1 = new Label();
            txt_memberCode = new TextBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            dateOfBirth = new DateTimePicker();
            txt_email = new TextBox();
            txt_idCard = new TextBox();
            txt_fullName = new TextBox();
            txt_address = new TextBox();
            txt_phoneNumber = new TextBox();
            lbl_gender = new Label();
            lbl_email = new Label();
            lbl_dateOfBirth = new Label();
            lbl_idCard = new Label();
            lbl_fullName = new Label();
            lbl_phoneNumber = new Label();
            lbl_address = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).BeginInit();
            menuStrip1.SuspendLayout();
            groupbox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvUser
            // 
            dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUser.Location = new Point(459, 45);
            dtgvUser.Name = "dtgvUser";
            dtgvUser.RowHeadersWidth = 51;
            dtgvUser.RowTemplate.Height = 29;
            dtgvUser.Size = new Size(830, 571);
            dtgvUser.TabIndex = 0;
            dtgvUser.CellDoubleClick += dataGridView1_CellDoubleClick;
            dtgvUser.CellFormatting += dtgvUser_CellFormatting;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { RegisterNewUserToolStripMenuItem, eDITUSERToolStripMenuItem, updateUserToolStripMenuItem, deleteUserToolStripMenuItem, searchUserToolStripMenuItem, viewUserListToolStripMenuItem, bACKTOMAINMENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1315, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // RegisterNewUserToolStripMenuItem
            // 
            RegisterNewUserToolStripMenuItem.Name = "RegisterNewUserToolStripMenuItem";
            RegisterNewUserToolStripMenuItem.Size = new Size(147, 27);
            RegisterNewUserToolStripMenuItem.Text = "ADD NEW USER";
            RegisterNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // eDITUSERToolStripMenuItem
            // 
            eDITUSERToolStripMenuItem.Name = "eDITUSERToolStripMenuItem";
            eDITUSERToolStripMenuItem.Size = new Size(104, 27);
            eDITUSERToolStripMenuItem.Text = "EDIT USER";
            eDITUSERToolStripMenuItem.Click += eDITUSERToolStripMenuItem_Click;
            // 
            // updateUserToolStripMenuItem
            // 
            updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            updateUserToolStripMenuItem.Size = new Size(131, 27);
            updateUserToolStripMenuItem.Text = "UPDATE USER";
            updateUserToolStripMenuItem.Click += updateUserToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(125, 27);
            deleteUserToolStripMenuItem.Text = "DELETE USER";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // searchUserToolStripMenuItem
            // 
            searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            searchUserToolStripMenuItem.Size = new Size(131, 27);
            searchUserToolStripMenuItem.Text = "SEARCH USER";
            searchUserToolStripMenuItem.Click += searchUserToolStripMenuItem_Click;
            // 
            // viewUserListToolStripMenuItem
            // 
            viewUserListToolStripMenuItem.Name = "viewUserListToolStripMenuItem";
            viewUserListToolStripMenuItem.Size = new Size(127, 27);
            viewUserListToolStripMenuItem.Text = "REFRESH LIST";
            viewUserListToolStripMenuItem.Click += viewUserListToolStripMenuItem_Click;
            // 
            // bACKTOMAINMENUToolStripMenuItem
            // 
            bACKTOMAINMENUToolStripMenuItem.Name = "bACKTOMAINMENUToolStripMenuItem";
            bACKTOMAINMENUToolStripMenuItem.Size = new Size(146, 27);
            bACKTOMAINMENUToolStripMenuItem.Text = "BACK TO MENU";
            bACKTOMAINMENUToolStripMenuItem.Click += bACKTOMAINMENUToolStripMenuItem_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // txt_searchValue
            // 
            txt_searchValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchValue.Location = new Point(176, 51);
            txt_searchValue.Name = "txt_searchValue";
            txt_searchValue.Size = new Size(192, 30);
            txt_searchValue.TabIndex = 46;
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(registrationDate);
            groupbox1.Controls.Add(label1);
            groupbox1.Controls.Add(txt_memberCode);
            groupbox1.Controls.Add(radio_female);
            groupbox1.Controls.Add(radio_male);
            groupbox1.Controls.Add(dateOfBirth);
            groupbox1.Controls.Add(txt_email);
            groupbox1.Controls.Add(txt_idCard);
            groupbox1.Controls.Add(txt_fullName);
            groupbox1.Controls.Add(txt_address);
            groupbox1.Controls.Add(txt_phoneNumber);
            groupbox1.Controls.Add(lbl_gender);
            groupbox1.Controls.Add(lbl_email);
            groupbox1.Controls.Add(lbl_dateOfBirth);
            groupbox1.Controls.Add(lbl_idCard);
            groupbox1.Controls.Add(lbl_fullName);
            groupbox1.Controls.Add(lbl_phoneNumber);
            groupbox1.Controls.Add(lbl_address);
            groupbox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupbox1.Location = new Point(29, 45);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(390, 441);
            groupbox1.TabIndex = 47;
            groupbox1.TabStop = false;
            groupbox1.Text = "USER INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 396);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 51;
            label2.Text = "Created Date :";
            // 
            // registrationDate
            // 
            registrationDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            registrationDate.CustomFormat = "yyyy-MM-dd";
            registrationDate.Enabled = false;
            registrationDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            registrationDate.Format = DateTimePickerFormat.Custom;
            registrationDate.Location = new Point(153, 396);
            registrationDate.Name = "registrationDate";
            registrationDate.Size = new Size(187, 30);
            registrationDate.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 45);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 49;
            label1.Text = "Member Code :";
            // 
            // txt_memberCode
            // 
            txt_memberCode.Enabled = false;
            txt_memberCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_memberCode.Location = new Point(153, 42);
            txt_memberCode.Name = "txt_memberCode";
            txt_memberCode.Size = new Size(187, 30);
            txt_memberCode.TabIndex = 48;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radio_female.Location = new Point(255, 218);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(85, 27);
            radio_female.TabIndex = 47;
            radio_female.TabStop = true;
            radio_female.Text = "Female";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radio_male.Location = new Point(153, 218);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(68, 27);
            radio_male.TabIndex = 46;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            dateOfBirth.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth.CustomFormat = "yyyy-MM-dd";
            dateOfBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth.Format = DateTimePickerFormat.Custom;
            dateOfBirth.Location = new Point(153, 134);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(187, 30);
            dateOfBirth.TabIndex = 45;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(153, 305);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(187, 30);
            txt_email.TabIndex = 39;
            // 
            // txt_idCard
            // 
            txt_idCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idCard.Location = new Point(153, 350);
            txt_idCard.Name = "txt_idCard";
            txt_idCard.Size = new Size(187, 30);
            txt_idCard.TabIndex = 37;
            // 
            // txt_fullName
            // 
            txt_fullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fullName.Location = new Point(153, 88);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(187, 30);
            txt_fullName.TabIndex = 36;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(153, 173);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(187, 30);
            txt_address.TabIndex = 35;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phoneNumber.Location = new Point(153, 259);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(187, 30);
            txt_phoneNumber.TabIndex = 33;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gender.Location = new Point(69, 218);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(78, 23);
            lbl_gender.TabIndex = 30;
            lbl_gender.Text = "Gender :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(83, 308);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(64, 23);
            lbl_email.TabIndex = 29;
            lbl_email.Text = "Email :";
            // 
            // lbl_dateOfBirth
            // 
            lbl_dateOfBirth.AutoSize = true;
            lbl_dateOfBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dateOfBirth.Location = new Point(22, 134);
            lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            lbl_dateOfBirth.Size = new Size(125, 23);
            lbl_dateOfBirth.TabIndex = 28;
            lbl_dateOfBirth.Text = "Date of birth :";
            // 
            // lbl_idCard
            // 
            lbl_idCard.AutoSize = true;
            lbl_idCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idCard.Location = new Point(63, 353);
            lbl_idCard.Name = "lbl_idCard";
            lbl_idCard.Size = new Size(81, 23);
            lbl_idCard.TabIndex = 27;
            lbl_idCard.Text = "ID Card :";
            // 
            // lbl_fullName
            // 
            lbl_fullName.AutoSize = true;
            lbl_fullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_fullName.Location = new Point(46, 88);
            lbl_fullName.Name = "lbl_fullName";
            lbl_fullName.Size = new Size(101, 23);
            lbl_fullName.TabIndex = 26;
            lbl_fullName.Text = "Full Name :";
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_phoneNumber.Location = new Point(78, 259);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(69, 23);
            lbl_phoneNumber.TabIndex = 25;
            lbl_phoneNumber.Text = "Phone :";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_address.Location = new Point(63, 176);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(84, 23);
            lbl_address.TabIndex = 23;
            lbl_address.Text = "Address :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txt_searchValue);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(29, 511);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 105);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH USER BY NAME OR MEMBER CODE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(6, 55);
            label12.Name = "label12";
            label12.Size = new Size(164, 23);
            label12.TabIndex = 7;
            label12.Text = "Nhập Name/Code :";
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 636);
            Controls.Add(groupBox2);
            Controls.Add(groupbox1);
            Controls.Add(dtgvUser);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÍ NGƯỜI DÙNG";
            FormClosing += frmUserManagement_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dtgvUser).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewUserListToolStripMenuItem;
        private ToolStripMenuItem RegisterNewUserToolStripMenuItem;
        private ToolStripMenuItem updateUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem searchUserToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolStripMenuItem bACKTOMAINMENUToolStripMenuItem;
        private TextBox txt_searchValue;
        private GroupBox groupbox1;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private DateTimePicker dateOfBirth;
        private TextBox txt_email;
        private TextBox txt_idCard;
        private TextBox txt_fullName;
        private TextBox txt_address;
        private TextBox txt_phoneNumber;
        private Label lbl_gender;
        private Label lbl_email;
        private Label lbl_dateOfBirth;
        private Label lbl_idCard;
        private Label lbl_fullName;
        private Label lbl_phoneNumber;
        private Label lbl_address;
        private GroupBox groupBox2;
        private Label label12;
        private Label label1;
        private TextBox txt_memberCode;
        private ToolStripMenuItem eDITUSERToolStripMenuItem;
        private Label label2;
        private DateTimePicker registrationDate;
    }
}