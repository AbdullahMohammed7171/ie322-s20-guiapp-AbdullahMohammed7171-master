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
    public partial class FrmMain : Form
    {
        string username = "abdullah";
        string myPassword = "1234";
        bool loggedIn = false;



        int attempt = 1;

        int MaxAttempts = 3;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)

            {



                while (attempt <= MaxAttempts)

                {

                    if (TxtUsername.Text != username)

                    {

                        // username is incorrect

                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");

                        attempt++;

                        return;

                    }

                    else

                    {   // username is correct

                        // so check password			

                        if (TxtPassword.Text != myPassword)

                        {

                            // Incorrect password

                            attempt++;

                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");

                            return;

                        }

                        else

                        {

                            //Both are correct

                            attempt = 1; // reset the number of attempts

                            loggedIn = true;

                            // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          





                            foreach (var grp in Login.Controls.OfType<GroupBox>())

                            {

                                foreach (var btn in grp.Controls.OfType<Button>())

                                {

                                    btn.Enabled = true;

                                    btn.ForeColor = Color.Black;

                                }

                            }



                            BtnLogin.Text = "Logout";

                            toolStripStatusLabel1.Text = "Hi " + username + ", you are logged in.";

                            // this.Width = 1600;

                            break; // come out of while loop

                        }//endif



                    }//endif

                }//end while

            }

            else

            {

                BtnLogin.Text = "Login";

                toolStripStatusLabel1.Text = "You are logged out.";

                loggedIn = false;



                TxtUsername.Clear();

                TxtPassword.Clear();



                foreach (var grp in Login.Controls.OfType<GroupBox>())

                {

                    foreach (var btn in grp.Controls.OfType<Button>())

                    {

                        btn.Enabled = false;

                    }

                }

            }







        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void BtnPictureBox1_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
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

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {
            FrmImage2 frm = new FrmImage2();
            frm.ShowDialog();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
