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
    public partial class frmMain : Form
    {
        string UserName = "Abdulellah";
        string MyPassword ="0505370909";
        int attempt = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < 4)
            {
                if (TextUser.Text == "Nabil" && TextPW.Text == "1234")
                {
                    MessageBox.Show("login successful");
                    break;
                }
                else if (TextUser.Text != "Nabil" && TextPW.Text == "1234")
                {
                    MessageBox.Show("incorrect username");

                    i++;
                }
                else
                {
                    MessageBox.Show("incorrect username and password");
                    i++;
                }
            }
        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPic01 frm = new FrmPic01();
            frm.ShowDialog();
        }
    } 
}