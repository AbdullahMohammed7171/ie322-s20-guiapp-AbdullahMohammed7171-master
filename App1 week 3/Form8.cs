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
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            Cmb2.ResetText();

            Cmb2.Items.Clear();

            Random r = new Random();

            for (int i = 0; i < r.Next(2, 9) - 1; i++)

            {

                Cmb2.Items.Add(r.Next(10, 99));

            }

            label1.Text = Convert.ToString(Cmb2.Items.Count);
        }

        private void BtnGenerate1_Click(object sender, EventArgs e)
        {
            Cmb1.ResetText();

            Cmb1.Items.Clear();

            Random r = new Random();

            for (int i = 0; i < r.Next(1, 51); i++)

            {

                Cmb1.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnReset1_Click(object sender, EventArgs e)
        {
            Cmb1.ResetText();

            Cmb1.Items.Clear();

            RadLessThan500_1.Checked = false;

            RadGreaterThan500_1.Checked = false;
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Cmb1.Text) > 499)

            {

                RadGreaterThan500_1.Checked = true;

            }

            else

            {

                RadLessThan500_1.Checked = true;

            }
        }

        private void Cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Cmb2.Text) > 49)

            {

                RadGreaterThan500_2.Checked = true;

            }

            else

            {

                RadLessThan500_2.Checked = true;

            }
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            Cmb2.ResetText();

            Cmb2.Items.Clear();

            RadLessThan500_2.Checked = false;

            RadGreaterThan500_2.Checked = false;

            label1.Text = Convert.ToString(Cmb2.Items.Count);


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
