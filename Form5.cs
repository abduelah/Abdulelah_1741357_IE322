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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoBlue.Checked = false;
            RdoYellow.Checked = false;

            RdoRed.ForeColor =
                Color.FromName("Black");
            RdoGreen.ForeColor =
                Color.FromName("Black");
            RdoBlue.ForeColor =
                Color.FromName("Black");
            RdoYellow.ForeColor =
                Color.FromName("Black");

            RdoRed2.ForeColor =
                Color.FromName("Black");
            RdoGreen2.ForeColor =
                Color.FromName("Black");
            RdoBlue2.ForeColor =
                Color.FromName("Black");
            RdoYellow2.ForeColor =
                Color.FromName("Black");
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor =
                    Color.FromArgb(255, 0, 0);
            else
                RdoRed.ForeColor =
                    Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor =
                    Color.FromName("Green");
            else
                RdoGreen.ForeColor =
                    Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor =
                    Color.FromName("Blue");
            else
                RdoBlue.ForeColor =
                    Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor =
                    Color.FromName("Yellow");
            else
                RdoYellow.ForeColor =
                    Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor =
                Color.FromName("Green");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor =
                Color.FromName("Red");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor =
                Color.FromName("Blue");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow2.ForeColor =
                Color.FromName("Yellow");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
