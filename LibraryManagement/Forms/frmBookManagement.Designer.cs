namespace LibraryManagement
{
    partial class frmBookManagement
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
            dgvBooks = new DataGridView();
            groupBox1 = new GroupBox();
            txtPublisherID = new TextBox();
            cmbGenre = new ComboBox();
            nudQuantity = new NumericUpDown();
            txtDescription = new TextBox();
            txtISBN = new TextBox();
            txtPublicationYear = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            lbPublisherID = new Label();
            lbTitle = new Label();
            lbAuthor = new Label();
            lbPublicationYear = new Label();
            lbISBN = new Label();
            lbQuantity = new Label();
            lbGenre = new Label();
            lbDescription = new Label();
            menuStrip1 = new MenuStrip();
            aDDNEWBOOKToolStripMenuItem = new ToolStripMenuItem();
            eDITBOOKToolStripMenuItem = new ToolStripMenuItem();
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
            dELETEBOOKToolStripMenuItem = new ToolStripMenuItem();
            rEFRESHLISTToolStripMenuItem = new ToolStripMenuItem();
            sEARCHToolStripMenuItem = new ToolStripMenuItem();
            bACKTOMENUToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            label12 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(432, 46);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 29;
            dgvBooks.Size = new Size(731, 554);
            dgvBooks.TabIndex = 18;
            dgvBooks.CellMouseDoubleClick += dgvBooks_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPublisherID);
            groupBox1.Controls.Add(cmbGenre);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtPublicationYear);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(lbPublisherID);
            groupBox1.Controls.Add(lbTitle);
            groupBox1.Controls.Add(lbAuthor);
            groupBox1.Controls.Add(lbPublicationYear);
            groupBox1.Controls.Add(lbISBN);
            groupBox1.Controls.Add(lbQuantity);
            groupBox1.Controls.Add(lbGenre);
            groupBox1.Controls.Add(lbDescription);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 436);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOOK INFORMATION";
            // 
            // txtPublisherID
            // 
            txtPublisherID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublisherID.Location = new Point(160, 280);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(200, 30);
            txtPublisherID.TabIndex = 23;
            // 
            // cmbGenre
            // 
            cmbGenre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGenre.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbGenre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Fairy Tale", "Science Fiction", "Romance", "Mystery", "Horror", "Historical", "Adventure", "Technical" });
            cmbGenre.Location = new Point(161, 231);
            cmbGenre.Margin = new Padding(2);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(200, 31);
            cmbGenre.TabIndex = 22;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nudQuantity.Location = new Point(160, 189);
            nudQuantity.Margin = new Padding(2);
            nudQuantity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(201, 30);
            nudQuantity.TabIndex = 21;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(159, 322);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(202, 94);
            txtDescription.TabIndex = 20;
            // 
            // txtISBN
            // 
            txtISBN.Enabled = false;
            txtISBN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtISBN.Location = new Point(160, 150);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 30);
            txtISBN.TabIndex = 19;
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublicationYear.Location = new Point(160, 114);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(200, 30);
            txtPublicationYear.TabIndex = 18;
            txtPublicationYear.TextChanged += txtPublicationYear_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(160, 78);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 30);
            txtAuthor.TabIndex = 17;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(160, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 30);
            txtTitle.TabIndex = 16;
            // 
            // lbPublisherID
            // 
            lbPublisherID.AutoSize = true;
            lbPublisherID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPublisherID.Location = new Point(42, 283);
            lbPublisherID.Name = "lbPublisherID";
            lbPublisherID.Size = new Size(112, 23);
            lbPublisherID.TabIndex = 8;
            lbPublisherID.Text = "PublisherID :";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(98, 45);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(56, 23);
            lbTitle.TabIndex = 9;
            lbTitle.Text = "Title :";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbAuthor.Location = new Point(78, 81);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(76, 23);
            lbAuthor.TabIndex = 10;
            lbAuthor.Text = "Author :";
            // 
            // lbPublicationYear
            // 
            lbPublicationYear.AutoSize = true;
            lbPublicationYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPublicationYear.Location = new Point(6, 117);
            lbPublicationYear.Name = "lbPublicationYear";
            lbPublicationYear.Size = new Size(148, 23);
            lbPublicationYear.TabIndex = 11;
            lbPublicationYear.Text = "Publication Year :";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbISBN.Location = new Point(95, 153);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(59, 23);
            lbISBN.TabIndex = 12;
            lbISBN.Text = "ISBN :";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuantity.Location = new Point(64, 189);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(90, 23);
            lbQuantity.TabIndex = 13;
            lbQuantity.Text = "Quantity :";
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbGenre.Location = new Point(86, 234);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(67, 23);
            lbGenre.TabIndex = 14;
            lbGenre.Text = "Genre :";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescription.Location = new Point(42, 325);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(112, 23);
            lbDescription.TabIndex = 15;
            lbDescription.Text = "Description :";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDDNEWBOOKToolStripMenuItem, eDITBOOKToolStripMenuItem, uPDATEToolStripMenuItem, dELETEBOOKToolStripMenuItem, rEFRESHLISTToolStripMenuItem, sEARCHToolStripMenuItem, bACKTOMENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1188, 31);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDDNEWBOOKToolStripMenuItem
            // 
            aDDNEWBOOKToolStripMenuItem.Name = "aDDNEWBOOKToolStripMenuItem";
            aDDNEWBOOKToolStripMenuItem.Size = new Size(153, 27);
            aDDNEWBOOKToolStripMenuItem.Text = "ADD NEW BOOK";
            aDDNEWBOOKToolStripMenuItem.Click += aDDNEWBOOKToolStripMenuItem_Click;
            // 
            // eDITBOOKToolStripMenuItem
            // 
            eDITBOOKToolStripMenuItem.Name = "eDITBOOKToolStripMenuItem";
            eDITBOOKToolStripMenuItem.Size = new Size(110, 27);
            eDITBOOKToolStripMenuItem.Text = "EDIT BOOK";
            eDITBOOKToolStripMenuItem.Click += eDITBOOKToolStripMenuItem_Click;
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(137, 27);
            uPDATEToolStripMenuItem.Text = "UPDATE BOOK";
            uPDATEToolStripMenuItem.Click += uPDATEToolStripMenuItem_Click;
            // 
            // dELETEBOOKToolStripMenuItem
            // 
            dELETEBOOKToolStripMenuItem.Name = "dELETEBOOKToolStripMenuItem";
            dELETEBOOKToolStripMenuItem.Size = new Size(131, 27);
            dELETEBOOKToolStripMenuItem.Text = "DELETE BOOK";
            dELETEBOOKToolStripMenuItem.Click += dELETEBOOKToolStripMenuItem_Click;
            // 
            // rEFRESHLISTToolStripMenuItem
            // 
            rEFRESHLISTToolStripMenuItem.Name = "rEFRESHLISTToolStripMenuItem";
            rEFRESHLISTToolStripMenuItem.Size = new Size(127, 27);
            rEFRESHLISTToolStripMenuItem.Text = "REFRESH LIST";
            rEFRESHLISTToolStripMenuItem.Click += rEFRESHLISTToolStripMenuItem_Click;
            // 
            // sEARCHToolStripMenuItem
            // 
            sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            sEARCHToolStripMenuItem.Size = new Size(86, 27);
            sEARCHToolStripMenuItem.Text = "SEARCH";
            sEARCHToolStripMenuItem.Click += sEARCHToolStripMenuItem_Click;
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
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(25, 495);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 105);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH BOOK BY TITTLE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(7, 47);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 7;
            label12.Text = "Nhập Title :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(117, 47);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 30);
            txtSearch.TabIndex = 6;
            // 
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 631);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvBooks);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmBookManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÍ SÁCH TRONG THƯ VIỆN";
            FormClosing += frmBookManagement_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDDNEWBOOKToolStripMenuItem;
        private ToolStripMenuItem eDITBOOKToolStripMenuItem;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem dELETEBOOKToolStripMenuItem;
        private ToolStripMenuItem rEFRESHLISTToolStripMenuItem;
        private ToolStripMenuItem sEARCHToolStripMenuItem;
        private ToolStripMenuItem bACKTOMENUToolStripMenuItem;
        private Label lbPublisherID;
        private Label lbTitle;
        private Label lbAuthor;
        private Label lbPublicationYear;
        private Label lbISBN;
        private Label lbQuantity;
        private Label lbGenre;
        private Label lbDescription;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtISBN;
        private TextBox txtPublicationYear;
        private ComboBox cmbGenre;
        private NumericUpDown nudQuantity;
        private TextBox txtPublisherID;
        private GroupBox groupBox2;
        private Label label12;
        private TextBox txtSearch;
    }
}