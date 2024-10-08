namespace Library_Task
{
    partial class AddBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet = new Library_Task.Library_TaskDataSet();
            this.generecomboBox = new System.Windows.Forms.ComboBox();
            this.genereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet22 = new Library_Task.Library_TaskDataSet22();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.booksTableAdapter = new Library_Task.Library_TaskDataSetTableAdapters.BooksTableAdapter();
            this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet15 = new Library_Task.Library_TaskDataSet15();
            this.authorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet5 = new Library_Task.Library_TaskDataSet5();
            this.authorsTableAdapter = new Library_Task.Library_TaskDataSet5TableAdapters.AuthorsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authorsTableAdapter1 = new Library_Task.Library_TaskDataSet15TableAdapters.AuthorsTableAdapter();
            this.genereTableAdapter = new Library_Task.Library_TaskDataSet22TableAdapters.GenereTableAdapter();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet22)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Refreshbutton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.White;
            this.Refreshbutton.Location = new System.Drawing.Point(938, 86);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(179, 37);
            this.Refreshbutton.TabIndex = 42;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(505, 95);
            this.Searchtxt.Multiline = true;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(304, 28);
            this.Searchtxt.TabIndex = 41;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.AutoGenerateColumns = false;
            this.BooksdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.archiveStatusDataGridViewTextBoxColumn,
            this.BookId});
            this.BooksdataGridView.DataSource = this.booksBindingSource1;
            this.BooksdataGridView.Location = new System.Drawing.Point(468, 125);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.Size = new System.Drawing.Size(646, 530);
            this.BooksdataGridView.TabIndex = 40;
            this.BooksdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellContentClick);
            this.BooksdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellDoubleClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            // 
            // genereDataGridViewTextBoxColumn
            // 
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // archiveStatusDataGridViewTextBoxColumn
            // 
            this.archiveStatusDataGridViewTextBoxColumn.DataPropertyName = "ArchiveStatus";
            this.archiveStatusDataGridViewTextBoxColumn.HeaderText = "ArchiveStatus";
            this.archiveStatusDataGridViewTextBoxColumn.Name = "archiveStatusDataGridViewTextBoxColumn";
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataSource = typeof(Library_Task.Model.Books);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_TaskDataSet;
            // 
            // library_TaskDataSet
            // 
            this.library_TaskDataSet.DataSetName = "Library_TaskDataSet";
            this.library_TaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generecomboBox
            // 
            this.generecomboBox.AllowDrop = true;
            this.generecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.generecomboBox.DataSource = this.genereBindingSource;
            this.generecomboBox.DisplayMember = "Genere";
            this.generecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generecomboBox.FormattingEnabled = true;
            this.generecomboBox.Location = new System.Drawing.Point(278, 376);
            this.generecomboBox.Name = "generecomboBox";
            this.generecomboBox.Size = new System.Drawing.Size(178, 39);
            this.generecomboBox.TabIndex = 39;
            this.generecomboBox.Tag = "";
            this.generecomboBox.ValueMember = "Genere";
            // 
            // genereBindingSource
            // 
            this.genereBindingSource.DataMember = "Genere";
            this.genereBindingSource.DataSource = this.library_TaskDataSet22;
            // 
            // library_TaskDataSet22
            // 
            this.library_TaskDataSet22.DataSetName = "Library_TaskDataSet22";
            this.library_TaskDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.statuscomboBox.Location = new System.Drawing.Point(278, 524);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(178, 39);
            this.statuscomboBox.TabIndex = 38;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Addbutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(120, 589);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(200, 66);
            this.Addbutton.TabIndex = 37;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 50);
            this.label8.TabIndex = 36;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 50);
            this.label7.TabIndex = 35;
            this.label7.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 50);
            this.label6.TabIndex = 34;
            this.label6.Text = "Genere:";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 33;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 50);
            this.label4.TabIndex = 32;
            this.label4.Text = "Author ID:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 50);
            this.label3.TabIndex = 31;
            this.label3.Text = "Title:";
            // 
            // isbntxt
            // 
            this.isbntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntxt.Location = new System.Drawing.Point(278, 449);
            this.isbntxt.Multiline = true;
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(178, 41);
            this.isbntxt.TabIndex = 30;
            // 
            // yeartxt
            // 
            this.yeartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartxt.Location = new System.Drawing.Point(278, 301);
            this.yeartxt.Multiline = true;
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(178, 41);
            this.yeartxt.TabIndex = 29;
            // 
            // titletxt
            // 
            this.titletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.Location = new System.Drawing.Point(278, 151);
            this.titletxt.Multiline = true;
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(178, 41);
            this.titletxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 64);
            this.label2.TabIndex = 26;
            this.label2.Text = "ADD Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 56);
            this.panel1.TabIndex = 43;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1073, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 45);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-10, -17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 74);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorcomboBox
            // 
            this.AuthorcomboBox.DataSource = this.authorsBindingSource3;
            this.AuthorcomboBox.DisplayMember = "AuthorId";
            this.AuthorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorcomboBox.FormattingEnabled = true;
            this.AuthorcomboBox.Location = new System.Drawing.Point(278, 234);
            this.AuthorcomboBox.Name = "AuthorcomboBox";
            this.AuthorcomboBox.Size = new System.Drawing.Size(178, 39);
            this.AuthorcomboBox.TabIndex = 40;
            this.AuthorcomboBox.ValueMember = "FirstName";
            this.AuthorcomboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorcomboBox_SelectedIndexChanged);
            // 
            // authorsBindingSource3
            // 
            this.authorsBindingSource3.DataSource = typeof(Library_Task.Model.Authors);
            // 
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataMember = "Authors";
            this.authorsBindingSource1.DataSource = this.library_TaskDataSet15;
            // 
            // library_TaskDataSet15
            // 
            this.library_TaskDataSet15.DataSetName = "Library_TaskDataSet15";
            this.library_TaskDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource2
            // 
            this.authorsBindingSource2.DataSource = typeof(Library_Task.Model.Authors);
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.library_TaskDataSet5;
            // 
            // library_TaskDataSet5
            // 
            this.library_TaskDataSet5.DataSetName = "Library_TaskDataSet5";
            this.library_TaskDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // authorsTableAdapter1
            // 
            this.authorsTableAdapter1.ClearBeforeFill = true;
            // 
            // genereTableAdapter
            // 
            this.genereTableAdapter.ClearBeforeFill = true;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(Library_Task.Classes.Connection);
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1126, 668);
            this.Controls.Add(this.AuthorcomboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.generecomboBox);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooksForm";
            this.Text = "AddBooksForm";
            this.Load += new System.EventHandler(this.AddBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet22)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.ComboBox generecomboBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Library_TaskDataSet library_TaskDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_TaskDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.ComboBox AuthorcomboBox;
        private Library_TaskDataSet5 library_TaskDataSet5;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Library_TaskDataSet5TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Library_TaskDataSet15 library_TaskDataSet15;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private Library_TaskDataSet15TableAdapters.AuthorsTableAdapter authorsTableAdapter1;
        private Library_TaskDataSet22 library_TaskDataSet22;
        private System.Windows.Forms.BindingSource genereBindingSource;
        private Library_TaskDataSet22TableAdapters.GenereTableAdapter genereTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource2;
        private System.Windows.Forms.BindingSource authorsBindingSource3;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource1;
    }
}