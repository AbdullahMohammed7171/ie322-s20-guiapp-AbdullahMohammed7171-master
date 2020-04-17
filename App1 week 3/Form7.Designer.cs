namespace App1_week_3
{
    partial class FrmRandom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BntGenerateRandomColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BntGenerateRandomColor
            // 
            this.BntGenerateRandomColor.Location = new System.Drawing.Point(53, 34);
            this.BntGenerateRandomColor.Name = "BntGenerateRandomColor";
            this.BntGenerateRandomColor.Size = new System.Drawing.Size(677, 100);
            this.BntGenerateRandomColor.TabIndex = 0;
            this.BntGenerateRandomColor.Text = "Generate Random Color";
            this.BntGenerateRandomColor.UseVisualStyleBackColor = true;
            this.BntGenerateRandomColor.Click += new System.EventHandler(this.BntGenerateRandomColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "r-g-b";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(53, 277);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(237, 49);
            this.BtnRandomNumber.TabIndex = 2;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(536, 386);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 33);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntGenerateRandomColor);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntGenerateRandomColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Button BtnBack;
    }
}