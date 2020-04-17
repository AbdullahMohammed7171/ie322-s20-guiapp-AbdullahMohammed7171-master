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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile("C:\\Users\\amf55\\Desktop\\fiels\\wallpaper\\JPG File (.jpg)");


        }
    }
}