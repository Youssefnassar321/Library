namespace Library_Task.Forms.Users
{
    partial class AvilableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvilableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet12 = new Library_Task.Library_TaskDataSet12();
            this.label2 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new Library_Task.Library_TaskDataSet12TableAdapters.BooksTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.library_TaskDataSet13 = new Library_Task.Library_TaskDataSet13();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new Library_Task.Library_TaskDataSet13TableAdapters.BooksTableAdapter();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 56);
            this.panel1.TabIndex = 52;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(449, 8);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(47, 45);
            this.Closebutton.TabIndex = 4;
            this.Closebutton.TabStop = false;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
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
            // BooksdataGridView
            // 
            this.BooksdataGridView.AutoGenerateColumns = false;
            this.BooksdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.BookId});
            this.BooksdataGridView.DataSource = this.booksBindingSource1;
            this.BooksdataGridView.Location = new System.Drawing.Point(67, 185);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.Size = new System.Drawing.Size(344, 403);
            this.BooksdataGridView.TabIndex = 53;
            this.BooksdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellDoubleClick);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.library_TaskDataSet12;
            // 
            // library_TaskDataSet12
            // 
            this.library_TaskDataSet12.DataSetName = "Library_TaskDataSet12";
            this.library_TaskDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 64);
            this.label2.TabIndex = 54;
            this.label2.Text = "Avilable Books";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // genereDataGridViewTextBoxColumn
            // 
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // library_TaskDataSet13
            // 
            this.library_TaskDataSet13.DataSetName = "Library_TaskDataSet13";
            this.library_TaskDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.library_TaskDataSet13;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(104, 151);
            this.Searchtxt.Multiline = true;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(135, 28);
            this.Searchtxt.TabIndex = 63;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Refreshbutton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.White;
            this.Refreshbutton.Location = new System.Drawing.Point(280, 142);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(131, 37);
            this.Refreshbutton.TabIndex = 65;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // AvilableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(508, 609);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvilableForm";
            this.Text = "AvilableForm";
            this.Load += new System.EventHandler(this.AvilableForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.Label label2;
        private Library_TaskDataSet12 library_TaskDataSet12;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Library_TaskDataSet12TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private Library_TaskDataSet13 library_TaskDataSet13;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private Library_TaskDataSet13TableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Refreshbutton;
    }
}