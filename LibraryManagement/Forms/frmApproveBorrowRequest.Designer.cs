namespace LibraryManagement.Forms
{
    partial class frmApproveBorrowRequest
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
            dgvBorrowRequest = new DataGridView();
            menuStrip1 = new MenuStrip();
            backToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            lbl_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRequest).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowRequest
            // 
            dgvBorrowRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRequest.Location = new Point(14, 76);
            dgvBorrowRequest.Name = "dgvBorrowRequest";
            dgvBorrowRequest.RowHeadersWidth = 51;
            dgvBorrowRequest.RowTemplate.Height = 29;
            dgvBorrowRequest.Size = new Size(1066, 447);
            dgvBorrowRequest.TabIndex = 0;
            dgvBorrowRequest.CellClick += dgvBorrowRequest_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToMainMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1103, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            backToMainMenuToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            backToMainMenuToolStripMenuItem.Size = new Size(146, 27);
            backToMainMenuToolStripMenuItem.Text = "BACK TO MENU";
            backToMainMenuToolStripMenuItem.Click += backToMainMenuToolStripMenuItem_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(14, 50);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(256, 23);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "PENDING BOOK REQUEST LIST";
            // 
            // frmApproveBorrowRequest
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 535);
            Controls.Add(lbl_title);
            Controls.Add(dgvBorrowRequest);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmApproveBorrowRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmApproveBorrowRequest";
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRequest).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowRequest;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private Label lbl_title;
    }
}