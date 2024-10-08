namespace Library_Task
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Showpic = new System.Windows.Forms.PictureBox();
            this.Hidepic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hidepic)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(565, 56);
            this.panel1.TabIndex = 51;
            // 
            // Closebutton
            // 
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(514, 5);
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
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 50);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 50);
            this.label3.TabIndex = 61;
            this.label3.Text = "User Name:";
            // 
            // UserNametxt
            // 
            this.UserNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.Location = new System.Drawing.Point(325, 156);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(177, 35);
            this.UserNametxt.TabIndex = 60;
            this.UserNametxt.TextChanged += new System.EventHandler(this.UserNametxt_TextChanged_1);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.Loginbutton.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(179, 327);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(199, 66);
            this.Loginbutton.TabIndex = 64;
            this.Loginbutton.Text = "Log In";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 70);
            this.label2.TabIndex = 65;
            this.label2.Text = "Welcome";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 31);
            this.label4.TabIndex = 67;
            this.label4.Text = "-If You Forget The Password Click Here:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(400, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 68;
            this.button1.Text = "Forget";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(325, 231);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(177, 35);
            this.passwordtxt.TabIndex = 16;
            this.passwordtxt.UseSystemPasswordChar = true;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // Showpic
            // 
            this.Showpic.BackColor = System.Drawing.Color.White;
            this.Showpic.Image = ((System.Drawing.Image)(resources.GetObject("Showpic.Image")));
            this.Showpic.Location = new System.Drawing.Point(456, 232);
            this.Showpic.Name = "Showpic";
            this.Showpic.Size = new System.Drawing.Size(46, 33);
            this.Showpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Showpic.TabIndex = 71;
            this.Showpic.TabStop = false;
            this.Showpic.Click += new System.EventHandler(this.Showpic_Click_1);
            // 
            // Hidepic
            // 
            this.Hidepic.BackColor = System.Drawing.Color.White;
            this.Hidepic.Image = ((System.Drawing.Image)(resources.GetObject("Hidepic.Image")));
            this.Hidepic.Location = new System.Drawing.Point(456, 232);
            this.Hidepic.Name = "Hidepic";
            this.Hidepic.Size = new System.Drawing.Size(46, 33);
            this.Hidepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hidepic.TabIndex = 72;
            this.Hidepic.TabStop = false;
            this.Hidepic.Visible = false;
            this.Hidepic.Click += new System.EventHandler(this.Hidepic_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(564, 484);
            this.Controls.Add(this.Showpic);
            this.Controls.Add(this.Hidepic);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNametxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hidepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.PictureBox Showpic;
        private System.Windows.Forms.PictureBox Hidepic;
    }
}