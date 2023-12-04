namespace LibraryManagement.Forms
{
    partial class frmPublisher
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
            aDDPUBLISHERToolStripMenuItem = new ToolStripMenuItem();
            eDITToolStripMenuItem = new ToolStripMenuItem();
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            sEARCHToolStripMenuItem = new ToolStripMenuItem();
            rEFRESHToolStripMenuItem = new ToolStripMenuItem();
            bACKTOMENUToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txt_searchValue = new TextBox();
            dgvPublisher = new DataGridView();
            groupBox1 = new GroupBox();
            txt_phoneNumber = new TextBox();
            label3 = new Label();
            txt_address = new TextBox();
            lbl_address = new Label();
            lbl_publisherName = new Label();
            txt_publisherName = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDDPUBLISHERToolStripMenuItem, eDITToolStripMenuItem, uPDATEToolStripMenuItem, dELETEToolStripMenuItem, sEARCHToolStripMenuItem, rEFRESHToolStripMenuItem, bACKTOMENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDDPUBLISHERToolStripMenuItem
            // 
            aDDPUBLISHERToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            aDDPUBLISHERToolStripMenuItem.Name = "aDDPUBLISHERToolStripMenuItem";
            aDDPUBLISHERToolStripMenuItem.Size = new Size(149, 27);
            aDDPUBLISHERToolStripMenuItem.Text = "ADD PUBLISHER";
            aDDPUBLISHERToolStripMenuItem.Click += aDDPUBLISHERToolStripMenuItem_Click;
            // 
            // eDITToolStripMenuItem
            // 
            eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            eDITToolStripMenuItem.Size = new Size(59, 27);
            eDITToolStripMenuItem.Text = "EDIT";
            eDITToolStripMenuItem.Click += eDITToolStripMenuItem_Click;
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(86, 27);
            uPDATEToolStripMenuItem.Text = "UPDATE";
            uPDATEToolStripMenuItem.Click += uPDATEToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(80, 27);
            dELETEToolStripMenuItem.Text = "DELETE";
            dELETEToolStripMenuItem.Click += dELETEToolStripMenuItem_Click;
            // 
            // sEARCHToolStripMenuItem
            // 
            sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            sEARCHToolStripMenuItem.Size = new Size(86, 27);
            sEARCHToolStripMenuItem.Text = "SEARCH";
            sEARCHToolStripMenuItem.Click += sEARCHToolStripMenuItem_Click;
            // 
            // rEFRESHToolStripMenuItem
            // 
            rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            rEFRESHToolStripMenuItem.Size = new Size(127, 27);
            rEFRESHToolStripMenuItem.Text = "REFRESH LIST";
            rEFRESHToolStripMenuItem.Click += rEFRESHToolStripMenuItem_Click;
            // 
            // bACKTOMENUToolStripMenuItem
            // 
            bACKTOMENUToolStripMenuItem.Name = "bACKTOMENUToolStripMenuItem";
            bACKTOMENUToolStripMenuItem.Size = new Size(146, 27);
            bACKTOMENUToolStripMenuItem.Text = "BACK TO MENU";
            bACKTOMENUToolStripMenuItem.Click += bACKTOMENUToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_searchValue);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(29, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 112);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH PUBLISHER BY NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 49);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 7;
            label4.Text = "Publisher name:";
            // 
            // txt_searchValue
            // 
            txt_searchValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_searchValue.Location = new Point(152, 45);
            txt_searchValue.Margin = new Padding(3, 5, 3, 5);
            txt_searchValue.Name = "txt_searchValue";
            txt_searchValue.Size = new Size(262, 30);
            txt_searchValue.TabIndex = 6;
            // 
            // dgvPublisher
            // 
            dgvPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisher.Location = new Point(483, 45);
            dgvPublisher.Margin = new Padding(3, 5, 3, 5);
            dgvPublisher.Name = "dgvPublisher";
            dgvPublisher.RowHeadersWidth = 51;
            dgvPublisher.RowTemplate.Height = 25;
            dgvPublisher.Size = new Size(593, 329);
            dgvPublisher.TabIndex = 10;
            dgvPublisher.CellDoubleClick += dgvPublisher_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_phoneNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Controls.Add(lbl_address);
            groupBox1.Controls.Add(lbl_publisherName);
            groupBox1.Controls.Add(txt_publisherName);
            groupBox1.Enabled = false;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(29, 45);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(423, 194);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "PUBLISHER INFORMATION";
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phoneNumber.Location = new Point(152, 133);
            txt_phoneNumber.Margin = new Padding(3, 5, 3, 5);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(252, 30);
            txt_phoneNumber.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 136);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 4;
            label3.Text = "Phone number:";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(152, 89);
            txt_address.Margin = new Padding(3, 5, 3, 5);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(252, 30);
            txt_address.TabIndex = 3;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(8, 92);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(79, 23);
            lbl_address.TabIndex = 2;
            lbl_address.Text = "Address:";
            // 
            // lbl_publisherName
            // 
            lbl_publisherName.AutoSize = true;
            lbl_publisherName.Location = new Point(8, 52);
            lbl_publisherName.Name = "lbl_publisherName";
            lbl_publisherName.Size = new Size(138, 23);
            lbl_publisherName.TabIndex = 1;
            lbl_publisherName.Text = "Publisher name:";
            // 
            // txt_publisherName
            // 
            txt_publisherName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_publisherName.Location = new Point(152, 52);
            txt_publisherName.Margin = new Padding(3, 5, 3, 5);
            txt_publisherName.Name = "txt_publisherName";
            txt_publisherName.Size = new Size(252, 30);
            txt_publisherName.TabIndex = 0;
            // 
            // frmPublisher
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 399);
            Controls.Add(groupBox2);
            Controls.Add(dgvPublisher);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ THÔNG TIN NHÀ XUẤT BẢN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublisher).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txt_searchValue;
        private DataGridView dgvPublisher;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txt_address;
        private Label lbl_address;
        private Label lbl_publisherName;
        private TextBox txt_publisherName;
        private ToolStripMenuItem aDDPUBLISHERToolStripMenuItem;
        private ToolStripMenuItem eDITToolStripMenuItem;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem rEFRESHToolStripMenuItem;
        private ToolStripMenuItem bACKTOMENUToolStripMenuItem;
        private TextBox txt_phoneNumber;
        private ToolStripMenuItem sEARCHToolStripMenuItem;
    }
}