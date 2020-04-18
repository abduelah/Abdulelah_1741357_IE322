namespace Demo_project
{
    partial class frmCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.ChkDonut = new System.Windows.Forms.CheckBox();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkBrownie);
            this.groupBox1.Controls.Add(this.ChkDonut);
            this.groupBox1.Controls.Add(this.ChkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(116, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(194, 128);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(80, 21);
            this.ChkBrownie.TabIndex = 2;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            // 
            // ChkDonut
            // 
            this.ChkDonut.AutoSize = true;
            this.ChkDonut.Location = new System.Drawing.Point(317, 50);
            this.ChkDonut.Name = "ChkDonut";
            this.ChkDonut.Size = new System.Drawing.Size(68, 21);
            this.ChkDonut.TabIndex = 1;
            this.ChkDonut.Text = "Donut";
            this.ChkDonut.UseVisualStyleBackColor = true;
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(97, 50);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(71, 21);
            this.ChkCoffee.TabIndex = 0;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.White;
            this.BtnShow.Location = new System.Drawing.Point(116, 378);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(554, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 530);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCheck";
            this.Text = "Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.CheckBox ChkDonut;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
    }
}