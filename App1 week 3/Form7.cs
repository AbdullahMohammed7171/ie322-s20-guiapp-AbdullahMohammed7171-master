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
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BntGenerateRandomColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);

            int g = y.Next(0, 255);

            int b = y.Next(0, 255);



            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);

            BntGenerateRandomColor.BackColor = Color.FromArgb(r, g, b);

            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
        }

        private void BtnRandomNumber_Click(object sender, EventArgs e)
        {
            BtnRandomNumber.Text = Convert.ToString(y.Next(1, 10));
        }
    }
}
