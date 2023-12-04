namespace LibraryManagement
{
    partial class frmAddBook
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
            btn_refresh = new Button();
            btn_register = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_refresh);
            groupBox1.Controls.Add(btn_register);
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
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 484);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOOK INFORMATION";
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(227, 435);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(161, 37);
            btn_refresh.TabIndex = 27;
            btn_refresh.Text = "REFRESH";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(51, 435);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(161, 37);
            btn_register.TabIndex = 26;
            btn_register.Text = "ADD NEW BOOK";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txtPublisherID
            // 
            txtPublisherID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublisherID.Location = new Point(160, 280);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(200, 30);
            txtPublisherID.TabIndex = 23;
            txtPublisherID.TextChanged += txtPublisherID_TextChanged;
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
            // frmAddBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 484);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM SÁCH MỚI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPublisherID;
        private ComboBox cmbGenre;
        private NumericUpDown nudQuantity;
        private TextBox txtDescription;
        private TextBox txtISBN;
        private TextBox txtPublicationYear;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label lbPublisherID;
        private Label lbTitle;
        private Label lbAuthor;
        private Label lbPublicationYear;
        private Label lbISBN;
        private Label lbQuantity;
        private Label lbGenre;
        private Label lbDescription;
        private Button btn_refresh;
        private Button btn_register;
    }
}