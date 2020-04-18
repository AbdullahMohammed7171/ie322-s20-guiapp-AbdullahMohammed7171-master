namespace App1_week_3
{
    partial class FrmCombo
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
            this.BtnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveLastItem = new System.Windows.Forms.Button();
            this.BtnRemove2ndlastItem = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelectedMethod1
            // 
            this.BtnShowSelectedMethod1.Location = new System.Drawing.Point(12, 29);
            this.BtnShowSelectedMethod1.Name = "BtnShowSelectedMethod1";
            this.BtnShowSelectedMethod1.Size = new System.Drawing.Size(163, 74);
            this.BtnShowSelectedMethod1.TabIndex = 0;
            this.BtnShowSelectedMethod1.Text = "Show Selected Method 1";
            this.BtnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod1.Click += new System.EventHandler(this.BtnShowSelectedMethod1_Click);
            // 
            // BtnShowSelectedMethod2
            // 
            this.BtnShowSelectedMethod2.Location = new System.Drawing.Point(181, 29);
            this.BtnShowSelectedMethod2.Name = "BtnShowSelectedMethod2";
            this.BtnShowSelectedMethod2.Size = new System.Drawing.Size(161, 74);
            this.BtnShowSelectedMethod2.TabIndex = 1;
            this.BtnShowSelectedMethod2.Text = "Show Selected Method 2";
            this.BtnShowSelectedMethod2.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod2.Click += new System.EventHandler(this.BtnShowSelectedMethod2_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(63, 215);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(126, 53);
            this.BtnRemoveByIndex.TabIndex = 3;
            this.BtnRemoveByIndex.Text = "Remove by index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(195, 215);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(129, 53);
            this.BtnRemoveByName.TabIndex = 4;
            this.BtnRemoveByName.Text = "Remove by name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveLastItem
            // 
            this.BtnRemoveLastItem.Location = new System.Drawing.Point(595, 115);
            this.BtnRemoveLastItem.Name = "BtnRemoveLastItem";
            this.BtnRemoveLastItem.Size = new System.Drawing.Size(110, 74);
            this.BtnRemoveLastItem.TabIndex = 5;
            this.BtnRemoveLastItem.Text = "Remove last item";
            this.BtnRemoveLastItem.UseVisualStyleBackColor = true;
            this.BtnRemoveLastItem.Click += new System.EventHandler(this.BtnRemoveLastItem_Click);
            // 
            // BtnRemove2ndlastItem
            // 
            this.BtnRemove2ndlastItem.Location = new System.Drawing.Point(595, 215);
            this.BtnRemove2ndlastItem.Name = "BtnRemove2ndlastItem";
            this.BtnRemove2ndlastItem.Size = new System.Drawing.Size(110, 73);
            this.BtnRemove2ndlastItem.TabIndex = 6;
            this.BtnRemove2ndlastItem.Text = "Remove 2nd last item";
            this.BtnRemove2ndlastItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndlastItem.Click += new System.EventHandler(this.BtnRemove2ndlastItem_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(88, 129);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(212, 28);
            this.CmbDays.TabIndex = 7;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(533, 366);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(149, 35);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemove2ndlastItem);
            this.Controls.Add(this.BtnRemoveLastItem);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnShowSelectedMethod2);
            this.Controls.Add(this.BtnShowSelectedMethod1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelectedMethod1;
        private System.Windows.Forms.Button BtnShowSelectedMethod2;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLastItem;
        private System.Windows.Forms.Button BtnRemove2ndlastItem;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnBack;
    }
}