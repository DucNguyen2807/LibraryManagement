namespace LibraryManagement
{
    partial class frmRegisterBook
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
            menuStrip1 = new MenuStrip();
            viewBookListToolStripMenuItem = new ToolStripMenuItem();
            btn_registerBr = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            backToMenuToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            DTPRequestBr = new DateTimePicker();
            label3 = new Label();
            txtBrBook = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMemberCode = new TextBox();
            dgvListBook = new DataGridView();
            txtSearchBook = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewBookListToolStripMenuItem, btn_registerBr, searchToolStripMenuItem, backToMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1215, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewBookListToolStripMenuItem
            // 
            viewBookListToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewBookListToolStripMenuItem.Name = "viewBookListToolStripMenuItem";
            viewBookListToolStripMenuItem.Size = new Size(152, 27);
            viewBookListToolStripMenuItem.Text = "VIEW BOOK LIST";
            viewBookListToolStripMenuItem.Click += viewBookListToolStripMenuItem_Click;
            // 
            // btn_registerBr
            // 
            btn_registerBr.Name = "btn_registerBr";
            btn_registerBr.Size = new Size(255, 27);
            btn_registerBr.Text = "ADD NEW BORROW REQUEST";
            btn_registerBr.Click += btn_registerBr_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(86, 27);
            searchToolStripMenuItem.Text = "SEARCH";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // backToMenuToolStripMenuItem
            // 
            backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            backToMenuToolStripMenuItem.Size = new Size(146, 27);
            backToMenuToolStripMenuItem.Text = "BACK TO MENU";
            backToMenuToolStripMenuItem.Click += backToMenuToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DTPRequestBr);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBrBook);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMemberCode);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 53);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(423, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "BORROW REQUEST INFORMATION";
            // 
            // DTPRequestBr
            // 
            DTPRequestBr.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DTPRequestBr.CustomFormat = "yyyy-MM-dd";
            DTPRequestBr.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DTPRequestBr.Format = DateTimePickerFormat.Custom;
            DTPRequestBr.Location = new Point(215, 136);
            DTPRequestBr.Name = "DTPRequestBr";
            DTPRequestBr.Size = new Size(189, 30);
            DTPRequestBr.TabIndex = 31;
            DTPRequestBr.Value = new DateTime(2023, 10, 26, 10, 8, 30, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 136);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 4;
            label3.Text = "Request Borrow Date :";
            // 
            // txtBrBook
            // 
            txtBrBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrBook.Location = new Point(215, 89);
            txtBrBook.Margin = new Padding(3, 5, 3, 5);
            txtBrBook.Name = "txtBrBook";
            txtBrBook.Size = new Size(189, 30);
            txtBrBook.TabIndex = 3;
            txtBrBook.TextChanged += txtBrBook_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 2;
            label2.Text = "Book ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 52);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "Member Code :";
            // 
            // txtMemberCode
            // 
            txtMemberCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberCode.Location = new Point(215, 49);
            txtMemberCode.Margin = new Padding(3, 5, 3, 5);
            txtMemberCode.Name = "txtMemberCode";
            txtMemberCode.Size = new Size(189, 30);
            txtMemberCode.TabIndex = 0;
            // 
            // dgvListBook
            // 
            dgvListBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBook.Location = new Point(474, 53);
            dgvListBook.Margin = new Padding(3, 5, 3, 5);
            dgvListBook.Name = "dgvListBook";
            dgvListBook.RowHeadersWidth = 51;
            dgvListBook.RowTemplate.Height = 25;
            dgvListBook.Size = new Size(718, 329);
            dgvListBook.TabIndex = 6;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBook.Location = new Point(125, 45);
            txtSearchBook.Margin = new Padding(3, 5, 3, 5);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(262, 30);
            txtSearchBook.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 49);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 7;
            label4.Text = "Nhập Tittle :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSearchBook);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(20, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 112);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH BOOK BY TITTLE";
            // 
            // frmRegisterBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 403);
            Controls.Add(groupBox2);
            Controls.Add(dgvListBook);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "frmRegisterBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG KÍ MƯỢN SÁCH";
            Load += frmRegisterBook_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtBrBook;
        private Label label2;
        private Label label1;
        private TextBox txtMemberCode;
        private DataGridView dgvListBook;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private ToolStripMenuItem btn_registerBr;
        private TextBox txtSearchBook;
        private Label label4;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem viewBookListToolStripMenuItem;
        private DateTimePicker DTPRequestBr;
        private GroupBox groupBox2;
    }
}