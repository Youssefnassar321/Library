namespace Library_Task.Forms
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.library_TaskDataSet14 = new Library_Task.Library_TaskDataSet14();
            this.nationalIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationalIdTableAdapter = new Library_Task.Library_TaskDataSet14TableAdapters.NationalIdTableAdapter();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalIdBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 53;
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
            this.BookId,
            this.bookIdDataGridViewTextBoxColumn,
            this.nationalIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.BooksdataGridView.DataSource = this.nationalIdBindingSource;
            this.BooksdataGridView.Location = new System.Drawing.Point(82, 121);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.Size = new System.Drawing.Size(344, 403);
            this.BooksdataGridView.TabIndex = 54;
            // 
            // library_TaskDataSet14
            // 
            this.library_TaskDataSet14.DataSetName = "Library_TaskDataSet14";
            this.library_TaskDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nationalIdBindingSource
            // 
            this.nationalIdBindingSource.DataMember = "NationalId";
            this.nationalIdBindingSource.DataSource = this.library_TaskDataSet14;
            // 
            // nationalIdTableAdapter
            // 
            this.nationalIdTableAdapter.ClearBeforeFill = true;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // nationalIdDataGridViewTextBoxColumn
            // 
            this.nationalIdDataGridViewTextBoxColumn.DataPropertyName = "NationalId";
            this.nationalIdDataGridViewTextBoxColumn.HeaderText = "NationalId";
            this.nationalIdDataGridViewTextBoxColumn.Name = "nationalIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(506, 536);
            this.Controls.Add(this.BooksdataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private Library_TaskDataSet14 library_TaskDataSet14;
        private System.Windows.Forms.BindingSource nationalIdBindingSource;
        private Library_TaskDataSet14TableAdapters.NationalIdTableAdapter nationalIdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}