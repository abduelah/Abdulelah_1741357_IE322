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
    public partial class FrmRandomCombo : Form
    { int i = 0;
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50)-1; i++) 
            {
                CmbRandom.Items.Add(r.Next(100, 999));
            }
        }

        private void CmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if
            (Convert.ToInt32(CmbRandom.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoGreater.Checked = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CmbRandom.ResetText();
            CmbRandom.Items.Clear();
            rdoLess.Checked = false;
            rdoGreater.Checked = false;
        }

        private void CmbRandom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if
        (Convert.ToInt32(CmbRandom2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2,9) - 1; i++)
            {
                CmbRandom2.Items.Add(r.Next(10, 99));
            }
            
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
        }
    }
}
