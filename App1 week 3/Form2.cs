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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RadRed1.Checked = false;

            RadGreen1.Checked = false;

            RadBlue1.Checked = false;

            RadYellow1.Checked = false;



            RadRed1.ForeColor = Color.FromName("black");

            RadGreen1.ForeColor = Color.FromName("black");

            RadBlue1.ForeColor = Color.FromName("black");

            RadYellow1.ForeColor = Color.FromName("black");



            RadRed2.Checked = false;

            RadGreen2.Checked = false;

            RadBlue2.Checked = false;

            RadYellow2.Checked = false;



            RadRed2.ForeColor = Color.FromName("black");

            RadGreen2.ForeColor = Color.FromName("black");

            RadBlue2.ForeColor = Color.FromName("black");

            RadYellow2.ForeColor = Color.FromName("black");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RadRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRed1.Checked == true)
                RadRed1.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RadRed1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RadGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadGreen1.Checked == true)
                RadGreen1.ForeColor = Color.FromName("green");
            else
                RadGreen1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RadBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBlue1.Checked == true)
                RadBlue1.ForeColor = Color.FromName("blue");
            else
                RadBlue1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RadYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadYellow1.Checked == true)
                RadYellow1.ForeColor = Color.FromName("yellow");
            else
                RadYellow1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RadRed2_CheckedChanged(object sender, EventArgs e)
        {
            RadRed2.ForeColor = Color.FromName("red");
        }

        private void RadBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RadBlue2.ForeColor = Color.FromName("blue");
        }

        private void RadYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RadYellow2.ForeColor = Color.FromName("yellow");
        }

        private void RadGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RadGreen2.ForeColor = Color.FromName("green");
        }
    }
}
