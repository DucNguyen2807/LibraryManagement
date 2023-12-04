namespace LibraryManagement
{
    partial class frmViewFeedback
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
            rEFRESHLISTToolStripMenuItem = new ToolStripMenuItem();
            bACKTOMENUToolStripMenuItem = new ToolStripMenuItem();
            dgvReview = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReview).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { rEFRESHLISTToolStripMenuItem, bACKTOMENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 31);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // rEFRESHLISTToolStripMenuItem
            // 
            rEFRESHLISTToolStripMenuItem.Name = "rEFRESHLISTToolStripMenuItem";
            rEFRESHLISTToolStripMenuItem.Size = new Size(127, 27);
            rEFRESHLISTToolStripMenuItem.Text = "REFRESH LIST";
            rEFRESHLISTToolStripMenuItem.Click += rEFRESHLISTToolStripMenuItem_Click;
            // 
            // bACKTOMENUToolStripMenuItem
            // 
            bACKTOMENUToolStripMenuItem.Name = "bACKTOMENUToolStripMenuItem";
            bACKTOMENUToolStripMenuItem.Size = new Size(146, 27);
            bACKTOMENUToolStripMenuItem.Text = "BACK TO MENU";
            bACKTOMENUToolStripMenuItem.Click += bACKTOMENUToolStripMenuItem_Click;
            // 
            // dgvReview
            // 
            dgvReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReview.Dock = DockStyle.Fill;
            dgvReview.Location = new Point(0, 31);
            dgvReview.Margin = new Padding(3, 5, 3, 5);
            dgvReview.Name = "dgvReview";
            dgvReview.RowHeadersWidth = 51;
            dgvReview.RowTemplate.Height = 25;
            dgvReview.Size = new Size(1124, 568);
            dgvReview.TabIndex = 8;
            // 
            // frmViewFeedback
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 599);
            Controls.Add(dgvReview);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmViewFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEEDBACK LIST";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rEFRESHLISTToolStripMenuItem;
        private ToolStripMenuItem bACKTOMENUToolStripMenuItem;
        private DataGridView dgvReview;
    }
}