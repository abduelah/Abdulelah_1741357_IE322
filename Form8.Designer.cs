namespace Demo_project
{
    partial class FrmPic01
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
            this.BtnLoadimage = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PicTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadimage
            // 
            this.BtnLoadimage.BackColor = System.Drawing.Color.Gold;
            this.BtnLoadimage.Location = new System.Drawing.Point(148, 83);
            this.BtnLoadimage.Name = "BtnLoadimage";
            this.BtnLoadimage.Size = new System.Drawing.Size(152, 65);
            this.BtnLoadimage.TabIndex = 0;
            this.BtnLoadimage.Text = "Load image From File";
            this.BtnLoadimage.UseVisualStyleBackColor = false;
            this.BtnLoadimage.Click += new System.EventHandler(this.BtnLoadimage_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Gold;
            this.BtnBack.Location = new System.Drawing.Point(1154, 443);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(118, 57);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(450, 172);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(457, 282);
            this.PicTry.TabIndex = 2;
            this.PicTry.TabStop = false;
            // 
            // FrmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 546);
            this.Controls.Add(this.PicTry);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLoadimage);
            this.Name = "FrmPic01";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadimage;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PicTry;
    }
}