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
            this.btnClose.Location = new System.Drawing.Point(113, 2);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 84);
            this.ControlBox = false;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelFree1C);
            this.Controls.Add(this.labelLost1C);
            this.Controls.Add(this.labelWait1C);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
    }
}

