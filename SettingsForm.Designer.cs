namespace CrmParser
{
    partial class SettingsForm
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
            this.chbxLost = new System.Windows.Forms.CheckBox();
            this.chbxFree = new System.Windows.Forms.CheckBox();
            this.chbxWait = new System.Windows.Forms.CheckBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbxLost);
            this.groupBox1.Controls.Add(this.chbxFree);
            this.groupBox1.Controls.Add(this.chbxWait);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображать";
            // 
            // chbxLost
            // 
            this.chbxLost.AutoSize = true;
            this.chbxLost.Checked = true;
            this.chbxLost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxLost.Location = new System.Drawing.Point(6, 65);
            this.chbxLost.Name = "chbxLost";
            this.chbxLost.Size = new System.Drawing.Size(54, 17);
            this.chbxLost.TabIndex = 0;
            this.chbxLost.Text = "LOST";
            this.chbxLost.UseVisualStyleBackColor = true;
            // 
            // chbxFree
            // 
            this.chbxFree.AutoSize = true;
            this.chbxFree.Checked = true;
            this.chbxFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxFree.Location = new System.Drawing.Point(6, 42);
            this.chbxFree.Name = "chbxFree";
            this.chbxFree.Size = new System.Drawing.Size(54, 17);
            this.chbxFree.TabIndex = 0;
            this.chbxFree.Text = "FREE";
            this.chbxFree.UseVisualStyleBackColor = true;
            // 
            // chbxWait
            // 
            this.chbxWait.AutoSize = true;
            this.chbxWait.Checked = true;
            this.chbxWait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxWait.Location = new System.Drawing.Point(6, 19);
            this.chbxWait.Name = "chbxWait";
            this.chbxWait.Size = new System.Drawing.Size(54, 17);
            this.chbxWait.TabIndex = 0;
            this.chbxWait.Text = "WAIT";
            this.chbxWait.UseVisualStyleBackColor = true;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(12, 119);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(75, 23);
            this.btnComfirm.TabIndex = 2;
            this.btnComfirm.Text = "Применить";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(93, 124);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(31, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Доб.";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(127, 120);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(80, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 150);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxLost;
        private System.Windows.Forms.CheckBox chbxFree;
        private System.Windows.Forms.CheckBox chbxWait;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
    }
}