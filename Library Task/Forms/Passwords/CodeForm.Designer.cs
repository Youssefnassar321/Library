namespace Library_Task
{
    partial class CodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Codetxt = new System.Windows.Forms.TextBox();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(611, 56);
            this.panel1.TabIndex = 53;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(557, 5);
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
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 50);
            this.label3.TabIndex = 75;
            this.label3.Text = "Enter Email:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(52, 149);
            this.Emailtxt.Multiline = true;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(505, 41);
            this.Emailtxt.TabIndex = 76;
            this.Emailtxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 50);
            this.label2.TabIndex = 77;
            this.label2.Text = "Enter Code:";
            // 
            // Codetxt
            // 
            this.Codetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codetxt.Location = new System.Drawing.Point(206, 294);
            this.Codetxt.Multiline = true;
            this.Codetxt.Name = "Codetxt";
            this.Codetxt.Size = new System.Drawing.Size(246, 41);
            this.Codetxt.TabIndex = 78;
            this.Codetxt.UseSystemPasswordChar = true;
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Confirmbutton.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbutton.ForeColor = System.Drawing.Color.White;
            this.Confirmbutton.Location = new System.Drawing.Point(407, 356);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(184, 52);
            this.Confirmbutton.TabIndex = 79;
            this.Confirmbutton.Text = "Verfiy";
            this.Confirmbutton.UseVisualStyleBackColor = false;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 80;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(613, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Confirmbutton);
            this.Controls.Add(this.Codetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeForm";
            this.Text = "CodeForm";
            this.Load += new System.EventHandler(this.CodeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Codetxt;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Button button1;
    }
}