namespace LibraryManagement
{
    partial class frmRegisterUser
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
            groupbox1 = new GroupBox();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            btn_refresh = new Button();
            dateOfBirth = new DateTimePicker();
            btn_register = new Button();
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
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(radio_female);
            groupbox1.Controls.Add(radio_male);
            groupbox1.Controls.Add(btn_refresh);
            groupbox1.Controls.Add(dateOfBirth);
            groupbox1.Controls.Add(btn_register);
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
            groupbox1.Dock = DockStyle.Fill;
            groupbox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupbox1.Location = new Point(0, 0);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(391, 444);
            groupbox1.TabIndex = 23;
            groupbox1.TabStop = false;
            groupbox1.Text = "REGISTER USER INFORMATION";
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radio_female.Location = new Point(247, 190);
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
            radio_male.Location = new Point(148, 190);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(68, 27);
            radio_male.TabIndex = 46;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(202, 394);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(161, 37);
            btn_refresh.TabIndex = 25;
            btn_refresh.Text = "REFRESH";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dateOfBirth
            // 
            dateOfBirth.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth.CustomFormat = "yyyy-MM-dd";
            dateOfBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth.Format = DateTimePickerFormat.Custom;
            dateOfBirth.Location = new Point(148, 96);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(187, 30);
            dateOfBirth.TabIndex = 45;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(26, 394);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(161, 37);
            btn_register.TabIndex = 24;
            btn_register.Text = "ADD NEW USER";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(148, 284);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(187, 30);
            txt_email.TabIndex = 39;
            // 
            // txt_idCard
            // 
            txt_idCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idCard.Location = new Point(148, 336);
            txt_idCard.Name = "txt_idCard";
            txt_idCard.Size = new Size(187, 30);
            txt_idCard.TabIndex = 37;
            // 
            // txt_fullName
            // 
            txt_fullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fullName.Location = new Point(148, 50);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(187, 30);
            txt_fullName.TabIndex = 36;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(148, 142);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(187, 30);
            txt_address.TabIndex = 35;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phoneNumber.Location = new Point(148, 234);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(187, 30);
            txt_phoneNumber.TabIndex = 33;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gender.Location = new Point(64, 190);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(78, 23);
            lbl_gender.TabIndex = 30;
            lbl_gender.Text = "Gender :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(78, 287);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(64, 23);
            lbl_email.TabIndex = 29;
            lbl_email.Text = "Email :";
            // 
            // lbl_dateOfBirth
            // 
            lbl_dateOfBirth.AutoSize = true;
            lbl_dateOfBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dateOfBirth.Location = new Point(17, 96);
            lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            lbl_dateOfBirth.Size = new Size(125, 23);
            lbl_dateOfBirth.TabIndex = 28;
            lbl_dateOfBirth.Text = "Date of birth :";
            // 
            // lbl_idCard
            // 
            lbl_idCard.AutoSize = true;
            lbl_idCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idCard.Location = new Point(61, 339);
            lbl_idCard.Name = "lbl_idCard";
            lbl_idCard.Size = new Size(81, 23);
            lbl_idCard.TabIndex = 27;
            lbl_idCard.Text = "ID Card :";
            // 
            // lbl_fullName
            // 
            lbl_fullName.AutoSize = true;
            lbl_fullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_fullName.Location = new Point(41, 53);
            lbl_fullName.Name = "lbl_fullName";
            lbl_fullName.Size = new Size(101, 23);
            lbl_fullName.TabIndex = 26;
            lbl_fullName.Text = "Full Name :";
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_phoneNumber.Location = new Point(73, 234);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(69, 23);
            lbl_phoneNumber.TabIndex = 25;
            lbl_phoneNumber.Text = "Phone :";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_address.Location = new Point(58, 145);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(84, 23);
            lbl_address.TabIndex = 23;
            lbl_address.Text = "Address :";
            // 
            // frmRegisterUser
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 444);
            Controls.Add(groupbox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM THÀNH VIÊN MỚI";
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupbox1;
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
        private Button btn_register;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private Button btn_refresh;
    }
}