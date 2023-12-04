namespace LibraryManagement
{
    partial class frmViewedBook
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
            refreshListToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            backToMenuToolStripMenuItem = new ToolStripMenuItem();
            dgvViewBooks = new DataGridView();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txt_searchValue = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooks).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { refreshListToolStripMenuItem, searchToolStripMenuItem, backToMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1092, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // refreshListToolStripMenuItem
            // 
            refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            refreshListToolStripMenuItem.Size = new Size(127, 27);
            refreshListToolStripMenuItem.Text = "REFRESH LIST";
            refreshListToolStripMenuItem.Click += refreshListToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(86, 27);
            searchToolStripMenuItem.Text = "SEARCH";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click_1;
            // 
            // backToMenuToolStripMenuItem
            // 
            backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            backToMenuToolStripMenuItem.Size = new Size(146, 27);
            backToMenuToolStripMenuItem.Text = "BACK TO MENU";
            backToMenuToolStripMenuItem.Click += backToMenuToolStripMenuItem_Click;
            // 
            // dgvViewBooks
            // 
            dgvViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewBooks.Location = new Point(14, 171);
            dgvViewBooks.Name = "dgvViewBooks";
            dgvViewBooks.RowHeadersWidth = 51;
            dgvViewBooks.RowTemplate.Height = 29;
            dgvViewBooks.Size = new Size(1066, 420);
            dgvViewBooks.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_searchValue);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(14, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 112);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH MEMBER CODE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 49);
            label4.Name = "label4";
            label4.Size = new Size(182, 23);
            label4.TabIndex = 7;
            label4.Text = "Nhập Member Code :";
            // 
            // txt_searchValue
            // 
            txt_searchValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchValue.Location = new Point(196, 49);
            txt_searchValue.Margin = new Padding(3, 5, 3, 5);
            txt_searchValue.Name = "txt_searchValue";
            txt_searchValue.Size = new Size(262, 30);
            txt_searchValue.TabIndex = 6;
            // 
            // frmViewedBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 603);
            Controls.Add(groupBox2);
            Controls.Add(dgvViewBooks);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmViewedBook";
            Text = "XEM SÁCH ĐÃ MƯỢN";
            Load += formViewedBook_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooks).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem refreshListToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem backToMenuToolStripMenuItem;
        private DataGridView dgvViewBooks;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txt_searchValue;
    }
}