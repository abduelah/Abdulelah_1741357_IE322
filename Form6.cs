using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_project
{
    public partial class FrmRandom : Form
    {
        Random Y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void FrmRandom_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(Y.Next(1, 100));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
