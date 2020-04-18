using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1_week_3
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

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnShowSelectedMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelectedMethod2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(item);
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRemoveLastItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)

            {

                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);

            }

            else

            {

                MessageBox.Show("Cant remove last item");

            }
        }

        private void BtnRemove2ndlastItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)

            {

                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);

            }

            else

            {

                MessageBox.Show("Cant remove 2nd last item");
            }
        }
    }
}
