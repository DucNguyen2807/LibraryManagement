namespace LibraryManagement
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            cbHide = new CheckBox();
            btnGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(235, 195);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 30);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(235, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 198);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 3;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 239);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(244, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(205, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbHide
            // 
            cbHide.AutoSize = true;
            cbHide.Checked = true;
            cbHide.CheckState = CheckState.Checked;
            cbHide.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbHide.Location = new Point(430, 239);
            cbHide.Name = "cbHide";
            cbHide.Size = new Size(67, 27);
            cbHide.TabIndex = 7;
            cbHide.Text = "Hide";
            cbHide.UseVisualStyleBackColor = true;
            cbHide.CheckedChanged += cbHide_CheckedChanged;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuest.Location = new Point(337, 293);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(105, 39);
            btnGuest.TabIndex = 8;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 357);
            Controls.Add(btnGuest);
            Controls.Add(cbHide);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP PHẦN MỀM QUẢN LÍ THƯ VIỆN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private CheckBox cbHide;
        private Button btnGuest;
    }
}