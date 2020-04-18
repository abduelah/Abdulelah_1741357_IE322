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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
        }





        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);

        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(2);
        }

        private void BtnSelected2_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void BtnSelected3_Click(object sender, EventArgs e)
        {
            var item = CmbDays.SelectedItem;
            if (item != null)
                MessageBox.Show(item.ToString());
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");
            }
        }

        private void BtnRemoveLast2_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove 2nd last item");
            }
        }
    }
}