namespace Demo_project
{
    partial class frmMain
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
            this.Btnlogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LPUser = new System.Windows.Forms.Label();
            this.LPW = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.TextPW = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCheckbox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btnlogin.ForeColor = System.Drawing.Color.DarkRed;
            this.Btnlogin.Location = new System.Drawing.Point(44, 235);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(253, 72);
            this.Btnlogin.TabIndex = 0;
            this.Btnlogin.Text = "login";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Blue;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(44, 385);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(140, 53);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LPUser
            // 
            this.LPUser.AutoSize = true;
            this.LPUser.Location = new System.Drawing.Point(6, 42);
            this.LPUser.Name = "LPUser";
            this.LPUser.Size = new System.Drawing.Size(79, 17);
            this.LPUser.TabIndex = 2;
            this.LPUser.Text = "User Name";
            this.LPUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // LPW
            // 
            this.LPW.AutoSize = true;
            this.LPW.Location = new System.Drawing.Point(6, 83);
            this.LPW.Name = "LPW";
            this.LPW.Size = new System.Drawing.Size(106, 17);
            this.LPW.TabIndex = 3;
            this.LPW.Text = "Enter password";
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(136, 42);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(100, 22);
            this.TextUser.TabIndex = 4;
            this.TextUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextPW
            // 
            this.TextPW.Location = new System.Drawing.Point(136, 83);
            this.TextPW.Name = "TextPW";
            this.TextPW.Size = new System.Drawing.Size(100, 22);
            this.TextPW.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextUser);
            this.groupBox1.Controls.Add(this.LPW);
            this.groupBox1.Controls.Add(this.TextPW);
            this.groupBox1.Controls.Add(this.LPUser);
            this.groupBox1.Location = new System.Drawing.Point(44, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "login in IE322";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRadio.Location = new System.Drawing.Point(6, 21);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(151, 56);
            this.BtnRadio.TabIndex = 7;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCheckbox
            // 
            this.BtnCheckbox.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckbox.Location = new System.Drawing.Point(163, 21);
            this.BtnCheckbox.Name = "BtnCheckbox";
            this.BtnCheckbox.Size = new System.Drawing.Size(149, 56);
            this.BtnCheckbox.TabIndex = 8;
            this.BtnCheckbox.Text = "Checkbox";
            this.BtnCheckbox.UseVisualStyleBackColor = false;
            this.BtnCheckbox.Click += new System.EventHandler(this.BtnCheckbox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCombo.Location = new System.Drawing.Point(6, 97);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(306, 49);
            this.BtnCombo.TabIndex = 9;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPictureBox.Location = new System.Drawing.Point(6, 21);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(306, 120);
            this.BtnPictureBox.TabIndex = 10;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = false;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnRandomCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandomCombo.Location = new System.Drawing.Point(287, 21);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(224, 334);
            this.BtnRandomCombo.TabIndex = 23;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandom.Location = new System.Drawing.Point(6, 21);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(266, 334);
            this.BtnRandom.TabIndex = 24;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Controls.Add(this.BtnCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 172);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(362, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 159);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnRandom);
            this.groupBox4.Controls.Add(this.BtnRandomCombo);
            this.groupBox4.Location = new System.Drawing.Point(783, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 361);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.Btnlogin);
            this.Name = "frmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LPUser;
        private System.Windows.Forms.Label LPW;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.TextBox TextPW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCheckbox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

