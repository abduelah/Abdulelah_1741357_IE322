using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Demo_project
{
    public partial class FrmPic01 : Form
    { 
        Assembly _assembly;
        Stream _imageSream;
            System.Drawing.Graphics graphicsObj3;
        Pen MyPen = new
            Pen(System.Drawing.Color.Blue, 1);
        public FrmPic01()
        {
            InitializeComponent();
            PicTry.SizeMode = PictureBoxSizeMode.StretchImage;
            

            graphicsObj3 = this.PicTry.CreateGraphics();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void BtnLoadimage_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("C:\\Users\\nabee\\Pictures\\industrial engineering.jpg");
        
            {
                MessageBox.Show("Image file found");
            }

        }

        private void BtnImageFrom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
