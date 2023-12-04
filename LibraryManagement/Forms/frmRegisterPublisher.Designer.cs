namespace LibraryManagement.Forms
{
    partial class frmRegisterPublisher
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
            btnRegister = new Button();
            txt_phoneNumber = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_address = new TextBox();
            txt_publisherName = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(29, 217);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(198, 45);
            btnRegister.TabIndex = 31;
            btnRegister.Text = "ADD NEW PUBLISHER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phoneNumber.Location = new Point(176, 139);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(292, 27);
            txt_phoneNumber.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 144);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 13;
            label3.Text = "Phone number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 11;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 10;
            label1.Text = "PublisherName:";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(176, 92);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(292, 27);
            txt_address.TabIndex = 9;
            // 
            // txt_publisherName
            // 
            txt_publisherName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_publisherName.Location = new Point(176, 47);
            txt_publisherName.Name = "txt_publisherName";
            txt_publisherName.Size = new Size(292, 27);
            txt_publisherName.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txt_phoneNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Controls.Add(txt_publisherName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "PUBLISHER REGISTER";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(253, 217);
            button1.Name = "button1";
            button1.Size = new Size(198, 45);
            button1.TabIndex = 32;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRegisterPublisher
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 283);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegisterPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM NHÀ XUẤT BẢN MỚI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private TextBox txt_phoneNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_address;
        private TextBox txt_publisherName;
        private GroupBox groupBox1;
        private Button button1;
    }
}