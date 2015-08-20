namespace CrmParser
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Thread = new System.ComponentModel.BackgroundWorker();
            this.labelWait1C = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLost1C = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelFree1C = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblCountAnswered = new System.Windows.Forms.Label();
            this.lblPauseStatus = new System.Windows.Forms.Label();
            this.lblPauseTime = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thread
            // 
            this.Thread.WorkerSupportsCancellation = true;
            // 
            // labelWait1C
            // 
            this.labelWait1C.AutoSize = true;
            this.labelWait1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWait1C.Location = new System.Drawing.Point(21, 21);
            this.labelWait1C.Name = "labelWait1C";
            this.labelWait1C.Size = new System.Drawing.Size(0, 20);
            this.labelWait1C.TabIndex = 0;
            // 
            // labelLost1C
            // 
            this.labelLost1C.AutoSize = true;
            this.labelLost1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLost1C.Location = new System.Drawing.Point(24, 61);
            this.labelLost1C.Name = "labelLost1C";
            this.labelLost1C.Size = new System.Drawing.Size(0, 13);
            this.labelLost1C.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(140, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelFree1C
            // 
            this.labelFree1C.AutoSize = true;
            this.labelFree1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFree1C.Location = new System.Drawing.Point(21, 41);
            this.labelFree1C.Name = "labelFree1C";
            this.labelFree1C.Size = new System.Drawing.Size(0, 20);
            this.labelFree1C.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "m";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblCountAnswered
            // 
            this.lblCountAnswered.AutoSize = true;
            this.lblCountAnswered.Location = new System.Drawing.Point(110, 129);
            this.lblCountAnswered.Name = "lblCountAnswered";
            this.lblCountAnswered.Size = new System.Drawing.Size(0, 13);
            this.lblCountAnswered.TabIndex = 3;
            // 
            // lblPauseStatus
            // 
            this.lblPauseStatus.AutoSize = true;
            this.lblPauseStatus.Location = new System.Drawing.Point(8, 151);
            this.lblPauseStatus.Name = "lblPauseStatus";
            this.lblPauseStatus.Size = new System.Drawing.Size(0, 13);
            this.lblPauseStatus.TabIndex = 3;
            // 
            // lblPauseTime
            // 
            this.lblPauseTime.AutoSize = true;
            this.lblPauseTime.Location = new System.Drawing.Point(110, 151);
            this.lblPauseTime.Name = "lblPauseTime";
            this.lblPauseTime.Size = new System.Drawing.Size(0, 13);
            this.lblPauseTime.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 83);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneNumber.TabIndex = 3;
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Location = new System.Drawing.Point(110, 105);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(0, 13);
            this.lblWorkTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время в системе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Принято";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 202);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWorkTime);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPauseTime);
            this.Controls.Add(this.lblPauseStatus);
            this.Controls.Add(this.lblCountAnswered);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelFree1C);
            this.Controls.Add(this.labelLost1C);
            this.Controls.Add(this.labelWait1C);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 100);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Thread;
        public System.Windows.Forms.Label labelWait1C;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelLost1C;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label labelFree1C;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblCountAnswered;
        private System.Windows.Forms.Label lblPauseStatus;
        private System.Windows.Forms.Label lblPauseTime;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

