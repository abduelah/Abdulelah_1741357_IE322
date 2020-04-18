namespace Demo_project
{
    partial class FrmCombo
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveLast2 = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnSelected2 = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(129, 153);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 0;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.BackColor = System.Drawing.Color.White;
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(129, 244);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(108, 51);
            this.BtnRemoveByIndex.TabIndex = 2;
            this.BtnRemoveByIndex.Text = "Remove By Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = false;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.BackColor = System.Drawing.Color.White;
            this.BtnRemoveByName.Location = new System.Drawing.Point(243, 244);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(114, 51);
            this.BtnRemoveByName.TabIndex = 3;
            this.BtnRemoveByName.Text = "Remove By Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = false;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveLast2
            // 
            this.BtnRemoveLast2.BackColor = System.Drawing.Color.White;
            this.BtnRemoveLast2.Location = new System.Drawing.Point(429, 183);
            this.BtnRemoveLast2.Name = "BtnRemoveLast2";
            this.BtnRemoveLast2.Size = new System.Drawing.Size(90, 77);
            this.BtnRemoveLast2.TabIndex = 4;
            this.BtnRemoveLast2.Text = "Remove 2nd last item";
            this.BtnRemoveLast2.UseVisualStyleBackColor = false;
            this.BtnRemoveLast2.Click += new System.EventHandler(this.BtnRemoveLast2_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.BackColor = System.Drawing.Color.White;
            this.BtnRemoveLast.Location = new System.Drawing.Point(429, 109);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(90, 68);
            this.BtnRemoveLast.TabIndex = 5;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = false;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnSelected2
            // 
            this.BtnSelected2.BackColor = System.Drawing.Color.White;
            this.BtnSelected2.Location = new System.Drawing.Point(243, 29);
            this.BtnSelected2.Name = "BtnSelected2";
            this.BtnSelected2.Size = new System.Drawing.Size(114, 51);
            this.BtnSelected2.TabIndex = 6;
            this.BtnSelected2.Text = "Show Selected Method 2";
            this.BtnSelected2.UseVisualStyleBackColor = false;
            this.BtnSelected2.Click += new System.EventHandler(this.BtnSelected2_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.White;
            this.BtnShow.Location = new System.Drawing.Point(129, 29);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(114, 51);
            this.BtnShow.TabIndex = 7;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnSelected3
            // 
            this.BtnSelected3.BackColor = System.Drawing.Color.White;
            this.BtnSelected3.Location = new System.Drawing.Point(363, 29);
            this.BtnSelected3.Name = "BtnSelected3";
            this.BtnSelected3.Size = new System.Drawing.Size(126, 51);
            this.BtnSelected3.TabIndex = 8;
            this.BtnSelected3.Text = "Show Selected Method 3";
            this.BtnSelected3.UseVisualStyleBackColor = false;
            this.BtnSelected3.Click += new System.EventHandler(this.BtnSelected3_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1338, 539);
            this.Controls.Add(this.BtnSelected3);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnSelected2);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnRemoveLast2);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.CmbDays);
            this.Name = "FrmCombo";
            this.Text = "IE322_App_KAU";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLast2;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnSelected2;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnSelected3;
    }
}