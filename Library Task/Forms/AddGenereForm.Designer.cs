namespace Library_Task.Forms
{
    partial class AddGenereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenereForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GeneredataGridView = new System.Windows.Forms.DataGridView();
            this.library_TaskDataSet23 = new Library_Task.Library_TaskDataSet23();
            this.genereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genereTableAdapter = new Library_Task.Library_TaskDataSet23TableAdapters.GenereTableAdapter();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneredataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.Closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 56);
            this.panel1.TabIndex = 52;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(449, 5);
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
            // GeneredataGridView
            // 
            this.GeneredataGridView.AutoGenerateColumns = false;
            this.GeneredataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.GeneredataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneredataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genereDataGridViewTextBoxColumn});
            this.GeneredataGridView.DataSource = this.genereBindingSource;
            this.GeneredataGridView.Location = new System.Drawing.Point(314, 141);
            this.GeneredataGridView.Name = "GeneredataGridView";
            this.GeneredataGridView.Size = new System.Drawing.Size(144, 403);
            this.GeneredataGridView.TabIndex = 54;
            // 
            // library_TaskDataSet23
            // 
            this.library_TaskDataSet23.DataSetName = "Library_TaskDataSet23";
            this.library_TaskDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genereBindingSource
            // 
            this.genereBindingSource.DataMember = "Genere";
            this.genereBindingSource.DataSource = this.library_TaskDataSet23;
            // 
            // genereTableAdapter
            // 
            this.genereTableAdapter.ClearBeforeFill = true;
            // 
            // genereDataGridViewTextBoxColumn
            // 
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            // 
            // Generetxt
            // 
            this.Generetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generetxt.Location = new System.Drawing.Point(54, 298);
            this.Generetxt.Multiline = true;
            this.Generetxt.Name = "Generetxt";
            this.Generetxt.Size = new System.Drawing.Size(204, 44);
            this.Generetxt.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 50);
            this.label3.TabIndex = 65;
            this.label3.Text = "Enter Genere:";
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Addbutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(64, 400);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(185, 59);
            this.Addbutton.TabIndex = 66;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 127);
            this.label2.TabIndex = 67;
            this.label2.Text = "   ADD\r\n Genere";
            // 
            // AddGenereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(498, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Generetxt);
            this.Controls.Add(this.GeneredataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGenereForm";
            this.Text = "AddGenereForm";
            this.Load += new System.EventHandler(this.AddGenereForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneredataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_TaskDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView GeneredataGridView;
        private Library_TaskDataSet23 library_TaskDataSet23;
        private System.Windows.Forms.BindingSource genereBindingSource;
        private Library_TaskDataSet23TableAdapters.GenereTableAdapter genereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Generetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label2;
    }
}