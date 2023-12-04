namespace LibraryManagement
{
    partial class frmBorrowedBook
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
            dgvBorrowRecord = new DataGridView();
            txtRecordId = new TextBox();
            txtBookname = new TextBox();
            lbRecordId = new Label();
            lbBookTitle = new Label();
            label3 = new Label();
            txtMemberCode = new TextBox();
            lbMember = new Label();
            label6 = new Label();
            dtpBorrowDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            lbBorrowDate = new Label();
            lbDueDate = new Label();
            BorrowedBook = new GroupBox();
            label1 = new Label();
            rdBtnreturned = new RadioButton();
            txtEmpCode = new TextBox();
            lbEmpCode = new Label();
            menuStrip1 = new MenuStrip();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteABorrowedBookToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            backToMenuToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label12 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecord).BeginInit();
            BorrowedBook.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowRecord
            // 
            dgvBorrowRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecord.Location = new Point(435, 52);
            dgvBorrowRecord.Name = "dgvBorrowRecord";
            dgvBorrowRecord.RowHeadersWidth = 51;
            dgvBorrowRecord.RowTemplate.Height = 29;
            dgvBorrowRecord.Size = new Size(822, 537);
            dgvBorrowRecord.TabIndex = 0;
            dgvBorrowRecord.CellDoubleClick += dgvBorrowRecord_CellDoubleClick;
            // 
            // txtRecordId
            // 
            txtRecordId.BackColor = SystemColors.Window;
            txtRecordId.Enabled = false;
            txtRecordId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecordId.Location = new Point(160, 46);
            txtRecordId.Name = "txtRecordId";
            txtRecordId.ReadOnly = true;
            txtRecordId.Size = new Size(179, 30);
            txtRecordId.TabIndex = 6;
            // 
            // txtBookname
            // 
            txtBookname.BackColor = SystemColors.Window;
            txtBookname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookname.Location = new Point(160, 93);
            txtBookname.Name = "txtBookname";
            txtBookname.Size = new Size(179, 30);
            txtBookname.TabIndex = 7;
            // 
            // lbRecordId
            // 
            lbRecordId.AutoSize = true;
            lbRecordId.BackColor = SystemColors.Control;
            lbRecordId.Location = new Point(55, 49);
            lbRecordId.Name = "lbRecordId";
            lbRecordId.Size = new Size(94, 23);
            lbRecordId.TabIndex = 8;
            lbRecordId.Text = "RecordID :";
            // 
            // lbBookTitle
            // 
            lbBookTitle.AutoSize = true;
            lbBookTitle.BackColor = SystemColors.Control;
            lbBookTitle.Location = new Point(47, 96);
            lbBookTitle.Name = "lbBookTitle";
            lbBookTitle.Size = new Size(102, 23);
            lbBookTitle.TabIndex = 9;
            lbBookTitle.Text = "Book Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 337);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 11;
            // 
            // txtMemberCode
            // 
            txtMemberCode.BackColor = SystemColors.Window;
            txtMemberCode.Enabled = false;
            txtMemberCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberCode.Location = new Point(160, 142);
            txtMemberCode.Name = "txtMemberCode";
            txtMemberCode.Size = new Size(179, 30);
            txtMemberCode.TabIndex = 10;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.BackColor = SystemColors.Control;
            lbMember.Location = new Point(15, 142);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(134, 23);
            lbMember.TabIndex = 12;
            lbMember.Text = "Member Code :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(622, 309);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 17;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.CustomFormat = "yyyy-MM-dd";
            dtpBorrowDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(160, 189);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(179, 30);
            dtpBorrowDate.TabIndex = 18;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "yyyy-MM-dd";
            dtpDueDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(160, 240);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(179, 30);
            dtpDueDate.TabIndex = 19;
            // 
            // lbBorrowDate
            // 
            lbBorrowDate.AutoSize = true;
            lbBorrowDate.BackColor = SystemColors.Control;
            lbBorrowDate.Location = new Point(27, 189);
            lbBorrowDate.Name = "lbBorrowDate";
            lbBorrowDate.Size = new Size(122, 23);
            lbBorrowDate.TabIndex = 20;
            lbBorrowDate.Text = "Borrow Date :";
            // 
            // lbDueDate
            // 
            lbDueDate.AutoSize = true;
            lbDueDate.BackColor = SystemColors.Control;
            lbDueDate.Location = new Point(54, 240);
            lbDueDate.Name = "lbDueDate";
            lbDueDate.Size = new Size(95, 23);
            lbDueDate.TabIndex = 21;
            lbDueDate.Text = "Due Date :";
            // 
            // BorrowedBook
            // 
            BorrowedBook.Controls.Add(label1);
            BorrowedBook.Controls.Add(rdBtnreturned);
            BorrowedBook.Controls.Add(txtEmpCode);
            BorrowedBook.Controls.Add(lbDueDate);
            BorrowedBook.Controls.Add(txtRecordId);
            BorrowedBook.Controls.Add(lbBorrowDate);
            BorrowedBook.Controls.Add(txtBookname);
            BorrowedBook.Controls.Add(dtpDueDate);
            BorrowedBook.Controls.Add(lbRecordId);
            BorrowedBook.Controls.Add(dtpBorrowDate);
            BorrowedBook.Controls.Add(lbBookTitle);
            BorrowedBook.Controls.Add(label3);
            BorrowedBook.Controls.Add(lbEmpCode);
            BorrowedBook.Controls.Add(txtMemberCode);
            BorrowedBook.Controls.Add(lbMember);
            BorrowedBook.Enabled = false;
            BorrowedBook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowedBook.Location = new Point(29, 52);
            BorrowedBook.Name = "BorrowedBook";
            BorrowedBook.Size = new Size(369, 395);
            BorrowedBook.TabIndex = 22;
            BorrowedBook.TabStop = false;
            BorrowedBook.Text = "BORROW INFORMATION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(20, 291);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 23;
            label1.Text = "Return Status :";
            // 
            // rdBtnreturned
            // 
            rdBtnreturned.AutoSize = true;
            rdBtnreturned.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rdBtnreturned.Location = new Point(160, 291);
            rdBtnreturned.Name = "rdBtnreturned";
            rdBtnreturned.Size = new Size(101, 27);
            rdBtnreturned.TabIndex = 22;
            rdBtnreturned.TabStop = true;
            rdBtnreturned.Text = "Returned";
            rdBtnreturned.UseVisualStyleBackColor = true;
            rdBtnreturned.CheckedChanged += rdBtnreturned_CheckedChanged;
            rdBtnreturned.Click += rdBtnreturned_Click;
            // 
            // txtEmpCode
            // 
            txtEmpCode.BackColor = SystemColors.Window;
            txtEmpCode.Enabled = false;
            txtEmpCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpCode.Location = new Point(160, 337);
            txtEmpCode.Name = "txtEmpCode";
            txtEmpCode.Size = new Size(179, 30);
            txtEmpCode.TabIndex = 15;
            // 
            // lbEmpCode
            // 
            lbEmpCode.AutoSize = true;
            lbEmpCode.BackColor = SystemColors.Control;
            lbEmpCode.Location = new Point(6, 337);
            lbEmpCode.Name = "lbEmpCode";
            lbEmpCode.Size = new Size(144, 23);
            lbEmpCode.TabIndex = 16;
            lbEmpCode.Text = "Employee Code :";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eDITToolStripMenuItem, updateToolStripMenuItem, deleteABorrowedBookToolStripMenuItem, searchToolStripMenuItem, clearToolStripMenuItem, backToMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1283, 31);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(59, 27);
            eDITToolStripMenuItem.Text = "EDIT";
            eDITToolStripMenuItem.Click += eDITToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(86, 27);
            updateToolStripMenuItem.Text = "UPDATE";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteABorrowedBookToolStripMenuItem
            // 
            deleteABorrowedBookToolStripMenuItem.Name = "deleteABorrowedBookToolStripMenuItem";
            deleteABorrowedBookToolStripMenuItem.Size = new Size(80, 27);
            deleteABorrowedBookToolStripMenuItem.Text = "DELETE";
            deleteABorrowedBookToolStripMenuItem.Click += deleteABorrowedBookToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(86, 27);
            searchToolStripMenuItem.Text = "SEARCH";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(73, 27);
            clearToolStripMenuItem.Text = "CLEAR";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
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
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 125);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH BOOK BY TITTLE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 59);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 26;
            label12.Text = "Nhập Title :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(120, 55);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 30);
            txtSearch.TabIndex = 25;
            // 
            // frmBorrowedBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 608);
            Controls.Add(groupBox1);
            Controls.Add(BorrowedBook);
            Controls.Add(label6);
            Controls.Add(dgvBorrowRecord);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmBorrowedBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÍ SÁCH CHO MƯỢN";
            FormClosing += frmBorrowedBook_FormClosing;
            Load += frmBorrowedBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecord).EndInit();
            BorrowedBook.ResumeLayout(false);
            BorrowedBook.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowRecord;
        private TextBox txtRecordId;
        private TextBox txtBookname;
        private Label lbRecordId;
        private Label lbBookTitle;
        private Label label3;
        private TextBox txtMemberCode;
        private Label lbMember;
        private Label label6;
        private DateTimePicker dtpBorrowDate;
        private DateTimePicker dtpDueDate;
        private Label lbBorrowDate;
        private Label lbDueDate;
        private GroupBox BorrowedBook;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem deleteABorrowedBookToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private RadioButton rdBtnNo;
        private RadioButton rdBtnreturned;
        private Label label1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private TextBox txtEmpCode;
        private Label lbEmpCode;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox txtSearch;
    }
}