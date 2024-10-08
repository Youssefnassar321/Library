namespace Library_Task
{
    partial class AddAuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorsForm));
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BIOtxt = new System.Windows.Forms.TextBox();
            this.LNtxt = new System.Windows.Forms.TextBox();
            this.FNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorsdataGridView = new System.Windows.Forms.DataGridView();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet1 = new Library_Task.Library_TaskDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.authorsTableAdapter = new Library_Task.Library_TaskDataSet1TableAdapters.AuthorsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Refreshbutton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.White;
            this.Refreshbutton.Location = new System.Drawing.Point(773, 101);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(131, 37);
            this.Refreshbutton.TabIndex = 45;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(488, 112);
            this.Searchtxt.Multiline = true;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(135, 28);
            this.Searchtxt.TabIndex = 44;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Addbutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(112, 556);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(199, 66);
            this.Addbutton.TabIndex = 43;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 50);
            this.label5.TabIndex = 42;
            this.label5.Text = "Biography:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 50);
            this.label4.TabIndex = 41;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 50);
            this.label3.TabIndex = 40;
            this.label3.Text = "First Name:";
            // 
            // BIOtxt
            // 
            this.BIOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIOtxt.Location = new System.Drawing.Point(277, 455);
            this.BIOtxt.Multiline = true;
            this.BIOtxt.Name = "BIOtxt";
            this.BIOtxt.Size = new System.Drawing.Size(177, 41);
            this.BIOtxt.TabIndex = 39;
            // 
            // LNtxt
            // 
            this.LNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNtxt.Location = new System.Drawing.Point(277, 356);
            this.LNtxt.Multiline = true;
            this.LNtxt.Name = "LNtxt";
            this.LNtxt.Size = new System.Drawing.Size(177, 41);
            this.LNtxt.TabIndex = 38;
            // 
            // FNtxt
            // 
            this.FNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNtxt.Location = new System.Drawing.Point(277, 257);
            this.FNtxt.Multiline = true;
            this.FNtxt.Name = "FNtxt";
            this.FNtxt.Size = new System.Drawing.Size(177, 41);
            this.FNtxt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 146);
            this.label2.TabIndex = 36;
            this.label2.Text = "ADD Authors\r\n       Page";
            // 
            // AuthorsdataGridView
            // 
            this.AuthorsdataGridView.AllowUserToAddRows = false;
            this.AuthorsdataGridView.AllowUserToDeleteRows = false;
            this.AuthorsdataGridView.AutoGenerateColumns = false;
            this.AuthorsdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.AuthorsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn,
            this.AuthorId});
            this.AuthorsdataGridView.DataSource = this.authorsBindingSource1;
            this.AuthorsdataGridView.Location = new System.Drawing.Point(460, 143);
            this.AuthorsdataGridView.Name = "AuthorsdataGridView";
            this.AuthorsdataGridView.ReadOnly = true;
            this.AuthorsdataGridView.Size = new System.Drawing.Size(414, 506);
            this.AuthorsdataGridView.TabIndex = 35;
            this.AuthorsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsdataGridView_CellContentClick);
            this.AuthorsdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorsdataGridView_CellDoubleClick);
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.library_TaskDataSet1;
            // 
            // library_TaskDataSet1
            // 
            this.library_TaskDataSet1.DataSetName = "Library_TaskDataSet1";
            this.library_TaskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 56);
            this.panel1.TabIndex = 46;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(856, 3);
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
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // AuthorId
            // 
            this.AuthorId.DataPropertyName = "AuthorId";
            this.AuthorId.HeaderText = "AuthorId";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ReadOnly = true;
            this.AuthorId.Visible = false;
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
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataSource = typeof(Library_Task.Model.Authors);
            // 
            // AddAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(916, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BIOtxt);
            this.Controls.Add(this.LNtxt);
            this.Controls.Add(this.FNtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorsdataGridView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAuthorsForm";
            this.Text = "AddAuthorsForm";
            this.Load += new System.EventHandler(this.AddAuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BIOtxt;
        private System.Windows.Forms.TextBox LNtxt;
        private System.Windows.Forms.TextBox FNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AuthorsdataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Library_TaskDataSet1 library_TaskDataSet1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Library_TaskDataSet1TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
    }
}