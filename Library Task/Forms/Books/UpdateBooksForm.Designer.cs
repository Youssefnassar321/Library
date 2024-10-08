namespace Library_Task
{
    partial class UpdateBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooksForm));
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.generecomboBox = new System.Windows.Forms.ComboBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
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
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet6 = new Library_Task.Library_TaskDataSet6();
            this.authorsTableAdapter = new Library_Task.Library_TaskDataSet6TableAdapters.AuthorsTableAdapter();
            this.library_TaskDataSet10 = new Library_Task.Library_TaskDataSet10();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter1 = new Library_Task.Library_TaskDataSet10TableAdapters.AuthorsTableAdapter();
            this.library_TaskDataSet11 = new Library_Task.Library_TaskDataSet11();
            this.authorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter2 = new Library_Task.Library_TaskDataSet11TableAdapters.AuthorsTableAdapter();
            this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.library_TaskDataSet16 = new Library_Task.Library_TaskDataSet16();
            this.authorsTableAdapter3 = new Library_Task.Library_TaskDataSet16TableAdapters.AuthorsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Deletebutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(317, 589);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(199, 66);
            this.Deletebutton.TabIndex = 52;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Updatebutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(33, 589);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(199, 66);
            this.Updatebutton.TabIndex = 50;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // generecomboBox
            // 
            this.generecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generecomboBox.FormattingEnabled = true;
            this.generecomboBox.Items.AddRange(new object[] {
            "Fantasy",
            "Historical",
            "Romance",
            "Poetry",
            "Science"});
            this.generecomboBox.Location = new System.Drawing.Point(339, 372);
            this.generecomboBox.Name = "generecomboBox";
            this.generecomboBox.Size = new System.Drawing.Size(177, 39);
            this.generecomboBox.TabIndex = 49;
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.statuscomboBox.Location = new System.Drawing.Point(339, 516);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(177, 39);
            this.statuscomboBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 50);
            this.label8.TabIndex = 47;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 50);
            this.label7.TabIndex = 46;
            this.label7.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 50);
            this.label6.TabIndex = 45;
            this.label6.Text = "Genere:";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 50);
            this.label5.TabIndex = 44;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 50);
            this.label4.TabIndex = 43;
            this.label4.Text = "Author ID:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 50);
            this.label3.TabIndex = 42;
            this.label3.Text = "Title:";
            // 
            // isbntxt
            // 
            this.isbntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntxt.Location = new System.Drawing.Point(339, 443);
            this.isbntxt.Multiline = true;
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(177, 41);
            this.isbntxt.TabIndex = 41;
            // 
            // yeartxt
            // 
            this.yeartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartxt.Location = new System.Drawing.Point(339, 299);
            this.yeartxt.Multiline = true;
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(177, 41);
            this.yeartxt.TabIndex = 40;
            // 
            // titletxt
            // 
            this.titletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.Location = new System.Drawing.Point(339, 153);
            this.titletxt.Multiline = true;
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(177, 41);
            this.titletxt.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 67);
            this.label2.TabIndex = 51;
            this.label2.Text = "Update Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 56);
            this.panel1.TabIndex = 53;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(515, 5);
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
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.library_TaskDataSet6;
            // 
            // library_TaskDataSet6
            // 
            this.library_TaskDataSet6.DataSetName = "Library_TaskDataSet6";
            this.library_TaskDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // library_TaskDataSet10
            // 
            this.library_TaskDataSet10.DataSetName = "Library_TaskDataSet10";
            this.library_TaskDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataMember = "Authors";
            this.authorsBindingSource1.DataSource = this.library_TaskDataSet10;
            // 
            // authorsTableAdapter1
            // 
            this.authorsTableAdapter1.ClearBeforeFill = true;
            // 
            // library_TaskDataSet11
            // 
            this.library_TaskDataSet11.DataSetName = "Library_TaskDataSet11";
            this.library_TaskDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource2
            // 
            this.authorsBindingSource2.DataMember = "Authors";
            this.authorsBindingSource2.DataSource = this.library_TaskDataSet11;
            // 
            // authorsTableAdapter2
            // 
            this.authorsTableAdapter2.ClearBeforeFill = true;
            // 
            // AuthorcomboBox
            // 
            this.AuthorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorcomboBox.FormattingEnabled = true;
            this.AuthorcomboBox.Location = new System.Drawing.Point(339, 232);
            this.AuthorcomboBox.Name = "AuthorcomboBox";
            this.AuthorcomboBox.Size = new System.Drawing.Size(177, 39);
            this.AuthorcomboBox.TabIndex = 54;
            // 
            // authorsBindingSource3
            // 
            this.authorsBindingSource3.DataMember = "Authors";
            this.authorsBindingSource3.DataSource = this.library_TaskDataSet16;
            // 
            // library_TaskDataSet16
            // 
            this.library_TaskDataSet16.DataSetName = "Library_TaskDataSet16";
            this.library_TaskDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter3
            // 
            this.authorsTableAdapter3.ClearBeforeFill = true;
            // 
            // UpdateBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(567, 678);
            this.Controls.Add(this.AuthorcomboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.generecomboBox);
            this.Controls.Add(this.statuscomboBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBooksForm";
            this.Text = "UpdateBooksForm";
            this.Load += new System.EventHandler(this.UpdateBooksForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.ComboBox generecomboBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
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
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Library_TaskDataSet6 library_TaskDataSet6;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Library_TaskDataSet6TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private Library_TaskDataSet10 library_TaskDataSet10;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private Library_TaskDataSet10TableAdapters.AuthorsTableAdapter authorsTableAdapter1;
        private Library_TaskDataSet11 library_TaskDataSet11;
        private System.Windows.Forms.BindingSource authorsBindingSource2;
        private Library_TaskDataSet11TableAdapters.AuthorsTableAdapter authorsTableAdapter2;
        private System.Windows.Forms.ComboBox AuthorcomboBox;
        private Library_TaskDataSet16 library_TaskDataSet16;
        private System.Windows.Forms.BindingSource authorsBindingSource3;
        private Library_TaskDataSet16TableAdapters.AuthorsTableAdapter authorsTableAdapter3;
    }
}