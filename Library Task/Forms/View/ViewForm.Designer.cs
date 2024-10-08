namespace Library_Task
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet3 = new Library_Task.Library_TaskDataSet3();
            this.AuthorsdataGridView = new System.Windows.Forms.DataGridView();
            this.authorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet4 = new Library_Task.Library_TaskDataSet4();
            this.Refbookbtn = new System.Windows.Forms.Button();
            this.SearchBookstxt = new System.Windows.Forms.TextBox();
            this.RefAuthorBtn = new System.Windows.Forms.Button();
            this.SearchAuthorstxt = new System.Windows.Forms.TextBox();
            this.booksTableAdapter = new Library_Task.Library_TaskDataSet3TableAdapters.BooksTableAdapter();
            this.authorsTableAdapter = new Library_Task.Library_TaskDataSet4TableAdapters.AuthorsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.library_TaskDataSet7 = new Library_Task.Library_TaskDataSet7();
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyTableAdapter = new Library_Task.Library_TaskDataSet7TableAdapters.BuyTableAdapter();
            this.library_TaskDataSet8 = new Library_Task.Library_TaskDataSet8();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new Library_Task.Library_TaskDataSet8TableAdapters.BooksTableAdapter();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchiveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 56);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1062, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "MTI-Library";
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(-10, -17);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(92, 74);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(556, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 64);
            this.label2.TabIndex = 56;
            this.label2.Text = "View";
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.AllowUserToAddRows = false;
            this.BooksdataGridView.AllowUserToDeleteRows = false;
            this.BooksdataGridView.AutoGenerateColumns = false;
            this.BooksdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.AuthorId,
            this.PublishedYear,
            this.Genere,
            this.ISBN,
            this.ArchiveStatus,
            this.BookId});
            this.BooksdataGridView.DataSource = this.booksBindingSource1;
            this.BooksdataGridView.Location = new System.Drawing.Point(5, 154);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.ReadOnly = true;
            this.BooksdataGridView.Size = new System.Drawing.Size(644, 429);
            this.BooksdataGridView.TabIndex = 54;
            this.BooksdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellDoubleClick);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_TaskDataSet3;
            // 
            // library_TaskDataSet3
            // 
            this.library_TaskDataSet3.DataSetName = "Library_TaskDataSet3";
            this.library_TaskDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AuthorsdataGridView
            // 
            this.AuthorsdataGridView.AllowUserToAddRows = false;
            this.AuthorsdataGridView.AllowUserToDeleteRows = false;
            this.AuthorsdataGridView.AutoGenerateColumns = false;
            this.AuthorsdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.AuthorsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn});
            this.AuthorsdataGridView.DataSource = this.authorsBindingSource;
            this.AuthorsdataGridView.Location = new System.Drawing.Point(665, 154);
            this.AuthorsdataGridView.Name = "AuthorsdataGridView";
            this.AuthorsdataGridView.ReadOnly = true;
            this.AuthorsdataGridView.Size = new System.Drawing.Size(444, 429);
            this.AuthorsdataGridView.TabIndex = 55;
            // 
            // authorIdDataGridViewTextBoxColumn1
            // 
            this.authorIdDataGridViewTextBoxColumn1.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn1.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn1.Name = "authorIdDataGridViewTextBoxColumn1";
            this.authorIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biographyDataGridViewTextBoxColumn
            // 
            this.biographyDataGridViewTextBoxColumn.DataPropertyName = "Biography";
            this.biographyDataGridViewTextBoxColumn.HeaderText = "Biography";
            this.biographyDataGridViewTextBoxColumn.Name = "biographyDataGridViewTextBoxColumn";
            this.biographyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.library_TaskDataSet4;
            // 
            // library_TaskDataSet4
            // 
            this.library_TaskDataSet4.DataSetName = "Library_TaskDataSet4";
            this.library_TaskDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Refbookbtn
            // 
            this.Refbookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Refbookbtn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refbookbtn.ForeColor = System.Drawing.Color.White;
            this.Refbookbtn.Location = new System.Drawing.Point(519, 111);
            this.Refbookbtn.Name = "Refbookbtn";
            this.Refbookbtn.Size = new System.Drawing.Size(130, 37);
            this.Refbookbtn.TabIndex = 58;
            this.Refbookbtn.Text = "Refresh";
            this.Refbookbtn.UseVisualStyleBackColor = false;
            this.Refbookbtn.Click += new System.EventHandler(this.Refbookbtn_Click);
            // 
            // SearchBookstxt
            // 
            this.SearchBookstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookstxt.Location = new System.Drawing.Point(61, 125);
            this.SearchBookstxt.Multiline = true;
            this.SearchBookstxt.Name = "SearchBookstxt";
            this.SearchBookstxt.Size = new System.Drawing.Size(158, 28);
            this.SearchBookstxt.TabIndex = 57;
            this.SearchBookstxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // RefAuthorBtn
            // 
            this.RefAuthorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.RefAuthorBtn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefAuthorBtn.ForeColor = System.Drawing.Color.White;
            this.RefAuthorBtn.Location = new System.Drawing.Point(979, 111);
            this.RefAuthorBtn.Name = "RefAuthorBtn";
            this.RefAuthorBtn.Size = new System.Drawing.Size(130, 37);
            this.RefAuthorBtn.TabIndex = 60;
            this.RefAuthorBtn.Text = "Refresh";
            this.RefAuthorBtn.UseVisualStyleBackColor = false;
            this.RefAuthorBtn.Click += new System.EventHandler(this.RefAuthorBtn_Click_1);
            // 
            // SearchAuthorstxt
            // 
            this.SearchAuthorstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAuthorstxt.Location = new System.Drawing.Point(700, 125);
            this.SearchAuthorstxt.Multiline = true;
            this.SearchAuthorstxt.Name = "SearchAuthorstxt";
            this.SearchAuthorstxt.Size = new System.Drawing.Size(158, 28);
            this.SearchAuthorstxt.TabIndex = 59;
            this.SearchAuthorstxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // library_TaskDataSet7
            // 
            this.library_TaskDataSet7.DataSetName = "Library_TaskDataSet7";
            this.library_TaskDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataMember = "Buy";
            this.buyBindingSource.DataSource = this.library_TaskDataSet7;
            // 
            // buyTableAdapter
            // 
            this.buyTableAdapter.ClearBeforeFill = true;
            // 
            // library_TaskDataSet8
            // 
            this.library_TaskDataSet8.DataSetName = "Library_TaskDataSet8";
            this.library_TaskDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.library_TaskDataSet8;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // AuthorId
            // 
            this.AuthorId.DataPropertyName = "AuthorId";
            this.AuthorId.HeaderText = "AuthorId";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            // 
            // PublishedYear
            // 
            this.PublishedYear.DataPropertyName = "PublishedYear";
            this.PublishedYear.HeaderText = "PublishedYear";
            this.PublishedYear.Name = "PublishedYear";
            this.PublishedYear.ReadOnly = true;
            // 
            // Genere
            // 
            this.Genere.DataPropertyName = "Genere";
            this.Genere.HeaderText = "Genere";
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // ArchiveStatus
            // 
            this.ArchiveStatus.DataPropertyName = "ArchiveStatus";
            this.ArchiveStatus.HeaderText = "ArchiveStatus";
            this.ArchiveStatus.Name = "ArchiveStatus";
            this.ArchiveStatus.ReadOnly = true;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1121, 589);
            this.Controls.Add(this.RefAuthorBtn);
            this.Controls.Add(this.SearchAuthorstxt);
            this.Controls.Add(this.Refbookbtn);
            this.Controls.Add(this.SearchBookstxt);
            this.Controls.Add(this.AuthorsdataGridView);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.DataGridView AuthorsdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refbookbtn;
        private System.Windows.Forms.TextBox SearchBookstxt;
        private System.Windows.Forms.Button RefAuthorBtn;
        private System.Windows.Forms.TextBox SearchAuthorstxt;
        private Library_TaskDataSet3 library_TaskDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_TaskDataSet3TableAdapters.BooksTableAdapter booksTableAdapter;
        private Library_TaskDataSet4 library_TaskDataSet4;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Library_TaskDataSet4TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Library_TaskDataSet7 library_TaskDataSet7;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private Library_TaskDataSet7TableAdapters.BuyTableAdapter buyTableAdapter;
        private Library_TaskDataSet8 library_TaskDataSet8;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private Library_TaskDataSet8TableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArchiveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
    }
}