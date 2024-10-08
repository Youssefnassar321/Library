namespace Library_Task
{
    partial class AvailableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.library_TaskDataSet9 = new Library_Task.Library_TaskDataSet9();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library_Task.Library_TaskDataSet9TableAdapters.BooksTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.Refbookbtn = new System.Windows.Forms.Button();
            this.SearchAuthorstxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 56);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(576, 5);
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
            // BooksdataGridView
            // 
            this.BooksdataGridView.AllowUserToAddRows = false;
            this.BooksdataGridView.AllowUserToDeleteRows = false;
            this.BooksdataGridView.AutoGenerateColumns = false;
            this.BooksdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.BookId});
            this.BooksdataGridView.DataSource = this.booksBindingSource;
            this.BooksdataGridView.Location = new System.Drawing.Point(91, 178);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.ReadOnly = true;
            this.BooksdataGridView.Size = new System.Drawing.Size(443, 420);
            this.BooksdataGridView.TabIndex = 58;
            this.BooksdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsdataGridView_CellContentClick);
            this.BooksdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsdataGridView_CellDoubleClick);
            // 
            // library_TaskDataSet9
            // 
            this.library_TaskDataSet9.DataSetName = "Library_TaskDataSet9";
            this.library_TaskDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_TaskDataSet9;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 64);
            this.label2.TabIndex = 59;
            this.label2.Text = "Available Books";
            // 
            // Refbookbtn
            // 
            this.Refbookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Refbookbtn.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refbookbtn.ForeColor = System.Drawing.Color.White;
            this.Refbookbtn.Location = new System.Drawing.Point(404, 135);
            this.Refbookbtn.Name = "Refbookbtn";
            this.Refbookbtn.Size = new System.Drawing.Size(130, 37);
            this.Refbookbtn.TabIndex = 60;
            this.Refbookbtn.Text = "Refresh";
            this.Refbookbtn.UseVisualStyleBackColor = false;
            // 
            // SearchAuthorstxt
            // 
            this.SearchAuthorstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAuthorstxt.Location = new System.Drawing.Point(120, 148);
            this.SearchAuthorstxt.Multiline = true;
            this.SearchAuthorstxt.Name = "SearchAuthorstxt";
            this.SearchAuthorstxt.Size = new System.Drawing.Size(158, 28);
            this.SearchAuthorstxt.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(89, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            this.publishedYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genereDataGridViewTextBoxColumn
            // 
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            this.genereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // AvailableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(630, 610);
            this.Controls.Add(this.SearchAuthorstxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Refbookbtn);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvailableForm";
            this.Text = "AvailableForm";
            this.Load += new System.EventHandler(this.AvailableForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private Library_TaskDataSet9 library_TaskDataSet9;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_TaskDataSet9TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refbookbtn;
        private System.Windows.Forms.TextBox SearchAuthorstxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
    }
}