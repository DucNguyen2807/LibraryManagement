namespace LibraryManagement
{
    partial class frmReviewBook
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
            cbRate = new ComboBox();
            txtMemberCode = new TextBox();
            label5 = new Label();
            txtBookName = new TextBox();
            txtComment = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            btn_submit = new ToolStripMenuItem();
            backToMenuToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbRate);
            groupBox1.Controls.Add(txtMemberCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(txtComment);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 33);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(554, 338);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOOK REVIEW INFORMATION";
            // 
            // cbRate
            // 
            cbRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbRate.FormattingEnabled = true;
            cbRate.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbRate.Location = new Point(164, 122);
            cbRate.Margin = new Padding(3, 5, 3, 5);
            cbRate.Name = "cbRate";
            cbRate.Size = new Size(49, 29);
            cbRate.TabIndex = 13;
            // 
            // txtMemberCode
            // 
            txtMemberCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMemberCode.Location = new Point(164, 44);
            txtMemberCode.Margin = new Padding(3, 5, 3, 5);
            txtMemberCode.Name = "txtMemberCode";
            txtMemberCode.Size = new Size(149, 29);
            txtMemberCode.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 44);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 11;
            label5.Text = "Member Code :";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookName.Location = new Point(164, 83);
            txtBookName.Margin = new Padding(3, 5, 3, 5);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(149, 29);
            txtBookName.TabIndex = 10;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComment.Location = new Point(162, 163);
            txtComment.Margin = new Padding(3, 5, 3, 5);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(367, 156);
            txtComment.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 163);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Comment :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(100, 122);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Rate :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 83);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Book ID :";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_submit, backToMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(554, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_submit
            // 
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(169, 27);
            btn_submit.Text = "SUBMIT FEEDBACK";
            btn_submit.Click += btn_submit_Click;
            // 
            // backToMenuToolStripMenuItem
            // 
            backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            backToMenuToolStripMenuItem.Size = new Size(146, 27);
            backToMenuToolStripMenuItem.Text = "BACK TO MENU";
            backToMenuToolStripMenuItem.Click += backToMenuToolStripMenuItem_Click;
            // 
            // frmReviewBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 371);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmReviewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐÁNH GIÁ SÁCH";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtMemberCode;
        private Label label5;
        private TextBox txtBookName;
        private TextBox txtComment;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private ToolStripMenuItem btn_submit;
        private ComboBox cbRate;
    }
}