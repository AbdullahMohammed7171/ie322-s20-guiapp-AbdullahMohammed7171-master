namespace App1_week_3
{
    partial class FrmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.RadLessThan500_1 = new System.Windows.Forms.RadioButton();
            this.RadGreaterThan500_1 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.RadLessThan500_2 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.RadGreaterThan500_2 = new System.Windows.Forms.RadioButton();
            this.Cmb2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.RadLessThan500_1);
            this.groupBox1.Controls.Add(this.RadGreaterThan500_1);
            this.groupBox1.Controls.Add(this.BtnGenerate1);
            this.groupBox1.Controls.Add(this.Cmb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Combo Box_1";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(216, 204);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(122, 46);
            this.BtnReset1.TabIndex = 5;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            this.BtnReset1.Click += new System.EventHandler(this.BtnReset1_Click);
            // 
            // RadLessThan500_1
            // 
            this.RadLessThan500_1.AutoSize = true;
            this.RadLessThan500_1.Location = new System.Drawing.Point(179, 101);
            this.RadLessThan500_1.Name = "RadLessThan500_1";
            this.RadLessThan500_1.Size = new System.Drawing.Size(143, 24);
            this.RadLessThan500_1.TabIndex = 3;
            this.RadLessThan500_1.TabStop = true;
            this.RadLessThan500_1.Text = " Less Than 500";
            this.RadLessThan500_1.UseVisualStyleBackColor = true;
            // 
            // RadGreaterThan500_1
            // 
            this.RadGreaterThan500_1.AutoSize = true;
            this.RadGreaterThan500_1.Location = new System.Drawing.Point(179, 150);
            this.RadGreaterThan500_1.Name = "RadGreaterThan500_1";
            this.RadGreaterThan500_1.Size = new System.Drawing.Size(160, 24);
            this.RadGreaterThan500_1.TabIndex = 4;
            this.RadGreaterThan500_1.TabStop = true;
            this.RadGreaterThan500_1.Text = "Greater Than 500";
            this.RadGreaterThan500_1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(179, 39);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(159, 43);
            this.BtnGenerate1.TabIndex = 1;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(27, 39);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(121, 28);
            this.Cmb1.TabIndex = 0;
            this.Cmb1.SelectedIndexChanged += new System.EventHandler(this.Cmb1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.RadLessThan500_2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.RadGreaterThan500_2);
            this.groupBox2.Controls.Add(this.Cmb2);
            this.groupBox2.Location = new System.Drawing.Point(408, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Combo Box_2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Count:";
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(245, 204);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(122, 46);
            this.BtnReset2.TabIndex = 8;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // RadLessThan500_2
            // 
            this.RadLessThan500_2.AutoSize = true;
            this.RadLessThan500_2.Location = new System.Drawing.Point(208, 101);
            this.RadLessThan500_2.Name = "RadLessThan500_2";
            this.RadLessThan500_2.Size = new System.Drawing.Size(134, 24);
            this.RadLessThan500_2.TabIndex = 6;
            this.RadLessThan500_2.TabStop = true;
            this.RadLessThan500_2.Text = " Less Than 50";
            this.RadLessThan500_2.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(208, 39);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(159, 43);
            this.BtnGenerate2.TabIndex = 2;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // RadGreaterThan500_2
            // 
            this.RadGreaterThan500_2.AutoSize = true;
            this.RadGreaterThan500_2.Location = new System.Drawing.Point(208, 150);
            this.RadGreaterThan500_2.Name = "RadGreaterThan500_2";
            this.RadGreaterThan500_2.Size = new System.Drawing.Size(151, 24);
            this.RadGreaterThan500_2.TabIndex = 7;
            this.RadGreaterThan500_2.TabStop = true;
            this.RadGreaterThan500_2.Text = "Greater Than 50";
            this.RadGreaterThan500_2.UseVisualStyleBackColor = true;
            // 
            // Cmb2
            // 
            this.Cmb2.FormattingEnabled = true;
            this.Cmb2.Location = new System.Drawing.Point(23, 39);
            this.Cmb2.Name = "Cmb2";
            this.Cmb2.Size = new System.Drawing.Size(138, 28);
            this.Cmb2.TabIndex = 1;
            this.Cmb2.SelectedIndexChanged += new System.EventHandler(this.Cmb2_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(648, 384);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(110, 36);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "RandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RadLessThan500_1;
        private System.Windows.Forms.RadioButton RadGreaterThan500_1;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.RadioButton RadLessThan500_2;
        private System.Windows.Forms.RadioButton RadGreaterThan500_2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox Cmb2;
        private System.Windows.Forms.Button BtnBack;
    }
}