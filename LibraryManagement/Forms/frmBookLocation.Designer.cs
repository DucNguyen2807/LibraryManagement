namespace LibraryManagement
{
    partial class frmBookLocation
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
            dgvLocation = new DataGridView();
            txtBookTitle = new TextBox();
            txtShelf = new TextBox();
            txtShelfColumn = new TextBox();
            txtShelfRow = new TextBox();
            lbBookTitle = new Label();
            lbShelf = new Label();
            lbColumn = new Label();
            lbRow = new Label();
            menuStrip1 = new MenuStrip();
            addBookToShelfToolStripMenuItem = new ToolStripMenuItem();
            eDITBOOKINSHELFToolStripMenuItem = new ToolStripMenuItem();
            updateShelfToolStripMenuItem = new ToolStripMenuItem();
            deleteBookFromShelfToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            backToMenuToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label12 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLocation).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLocation
            // 
            dgvLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocation.Location = new Point(429, 45);
            dgvLocation.Name = "dgvLocation";
            dgvLocation.RowHeadersWidth = 51;
            dgvLocation.RowTemplate.Height = 29;
            dgvLocation.Size = new Size(663, 354);
            dgvLocation.TabIndex = 0;
            dgvLocation.CellDoubleClick += dgvLocation_CellDoubleClick;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookTitle.Location = new Point(130, 49);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(162, 30);
            txtBookTitle.TabIndex = 3;
            // 
            // txtShelf
            // 
            txtShelf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtShelf.Location = new Point(130, 96);
            txtShelf.Name = "txtShelf";
            txtShelf.Size = new Size(162, 30);
            txtShelf.TabIndex = 4;
            txtShelf.TextChanged += txtShelf_TextChanged;
            // 
            // txtShelfColumn
            // 
            txtShelfColumn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtShelfColumn.Location = new Point(130, 142);
            txtShelfColumn.Name = "txtShelfColumn";
            txtShelfColumn.Size = new Size(162, 30);
            txtShelfColumn.TabIndex = 5;
            txtShelfColumn.TextChanged += txtShelfColumn_TextChanged;
            // 
            // txtShelfRow
            // 
            txtShelfRow.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtShelfRow.Location = new Point(130, 187);
            txtShelfRow.Name = "txtShelfRow";
            txtShelfRow.Size = new Size(162, 30);
            txtShelfRow.TabIndex = 6;
            txtShelfRow.TextChanged += txtShelfRow_TextChanged;
            // 
            // lbBookTitle
            // 
            lbBookTitle.AutoSize = true;
            lbBookTitle.BackColor = SystemColors.Control;
            lbBookTitle.Location = new Point(15, 49);
            lbBookTitle.Name = "lbBookTitle";
            lbBookTitle.Size = new Size(109, 23);
            lbBookTitle.TabIndex = 11;
            lbBookTitle.Text = "Book Tittle :";
            // 
            // lbShelf
            // 
            lbShelf.AutoSize = true;
            lbShelf.BackColor = SystemColors.Control;
            lbShelf.Location = new Point(63, 96);
            lbShelf.Name = "lbShelf";
            lbShelf.Size = new Size(61, 23);
            lbShelf.TabIndex = 12;
            lbShelf.Text = "Shelf :";
            // 
            // lbColumn
            // 
            lbColumn.AutoSize = true;
            lbColumn.BackColor = SystemColors.Control;
            lbColumn.Location = new Point(42, 142);
            lbColumn.Name = "lbColumn";
            lbColumn.Size = new Size(82, 23);
            lbColumn.TabIndex = 13;
            lbColumn.Text = "Column :";
            // 
            // lbRow
            // 
            lbRow.AutoSize = true;
            lbRow.BackColor = SystemColors.Control;
            lbRow.Location = new Point(69, 187);
            lbRow.Name = "lbRow";
            lbRow.Size = new Size(55, 23);
            lbRow.TabIndex = 14;
            lbRow.Text = "Row :";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBookToShelfToolStripMenuItem, eDITBOOKINSHELFToolStripMenuItem, updateShelfToolStripMenuItem, deleteBookFromShelfToolStripMenuItem, clearToolStripMenuItem, searchToolStripMenuItem, backToMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1116, 31);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBookToShelfToolStripMenuItem
            // 
            addBookToShelfToolStripMenuItem.Name = "addBookToShelfToolStripMenuItem";
            addBookToShelfToolStripMenuItem.Size = new Size(187, 27);
            addBookToShelfToolStripMenuItem.Text = "ADD BOOK TO SHELF";
            addBookToShelfToolStripMenuItem.Click += addBookToShelfToolStripMenuItem_Click;
            // 
            // eDITBOOKINSHELFToolStripMenuItem
            // 
            eDITBOOKINSHELFToolStripMenuItem.Name = "eDITBOOKINSHELFToolStripMenuItem";
            eDITBOOKINSHELFToolStripMenuItem.Size = new Size(184, 27);
            eDITBOOKINSHELFToolStripMenuItem.Text = "EDIT BOOK IN SHELF";
            eDITBOOKINSHELFToolStripMenuItem.Click += eDITBOOKINSHELFToolStripMenuItem_Click;
            // 
            // updateShelfToolStripMenuItem
            // 
            updateShelfToolStripMenuItem.Name = "updateShelfToolStripMenuItem";
            updateShelfToolStripMenuItem.Size = new Size(137, 27);
            updateShelfToolStripMenuItem.Text = "UPDATE SHELF";
            updateShelfToolStripMenuItem.Click += updateShelfToolStripMenuItem_Click;
            // 
            // deleteBookFromShelfToolStripMenuItem
            // 
            deleteBookFromShelfToolStripMenuItem.Name = "deleteBookFromShelfToolStripMenuItem";
            deleteBookFromShelfToolStripMenuItem.Size = new Size(244, 27);
            deleteBookFromShelfToolStripMenuItem.Text = "REMOVE BOOK FROM SHELF";
            deleteBookFromShelfToolStripMenuItem.Click += deleteBookFromShelfToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(73, 27);
            clearToolStripMenuItem.Text = "CLEAR";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
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
            groupBox1.Controls.Add(txtShelf);
            groupBox1.Controls.Add(lbRow);
            groupBox1.Controls.Add(lbColumn);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(lbShelf);
            groupBox1.Controls.Add(txtShelfColumn);
            groupBox1.Controls.Add(lbBookTitle);
            groupBox1.Controls.Add(txtShelfRow);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOCATION INFORMATION";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(31, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 105);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEACH BOOK BY TITTLE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(18, 47);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 7;
            label12.Text = "Nhập Title :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(128, 47);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 30);
            txtSearch.TabIndex = 6;
            // 
            // frmBookLocation
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvLocation);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmBookLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ SÁCH TRONG KHO";
            FormClosing += frmBookLocation_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvLocation).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLocation;
        private TextBox txtBookTitle;
        private TextBox txtShelf;
        private TextBox txtShelfColumn;
        private TextBox txtShelfRow;
        private Label lbBookTitle;
        private Label lbShelf;
        private Label lbColumn;
        private Label lbRow;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addBookToShelfToolStripMenuItem;
        private ToolStripMenuItem deleteBookFromShelfToolStripMenuItem;
        private ToolStripMenuItem updateShelfToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem eDITBOOKINSHELFToolStripMenuItem;
        private GroupBox groupBox2;
        private Label label12;
        private TextBox txtSearch;
    }
}