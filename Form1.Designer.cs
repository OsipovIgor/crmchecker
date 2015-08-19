namespace CrmParser
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelFree1C = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWaitAO = new System.Windows.Forms.Label();
            this.labelLostAO = new System.Windows.Forms.Label();
            this.labelFreeAO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1C";
            // 
            // labelWaitAO
            // 
            this.labelWaitAO.AutoSize = true;
            this.labelWaitAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaitAO.Location = new System.Drawing.Point(151, 21);
            this.labelWaitAO.Name = "labelWaitAO";
            this.labelWaitAO.Size = new System.Drawing.Size(0, 20);
            this.labelWaitAO.TabIndex = 0;
            // 
            // labelLostAO
            // 
            this.labelLostAO.AutoSize = true;
            this.labelLostAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLostAO.Location = new System.Drawing.Point(154, 61);
            this.labelLostAO.Name = "labelLostAO";
            this.labelLostAO.Size = new System.Drawing.Size(0, 13);
            this.labelLostAO.TabIndex = 1;
            // 
            // labelFreeAO
            // 
            this.labelFreeAO.AutoSize = true;
            this.labelFreeAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFreeAO.Location = new System.Drawing.Point(151, 41);
            this.labelFreeAO.Name = "labelFreeAO";
            this.labelFreeAO.Size = new System.Drawing.Size(0, 20);
            this.labelFreeAO.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "AO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 84);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFreeAO);
            this.Controls.Add(this.labelFree1C);
            this.Controls.Add(this.labelLostAO);
            this.Controls.Add(this.labelLost1C);
            this.Controls.Add(this.labelWaitAO);
            this.Controls.Add(this.labelWait1C);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Thread;
        private System.Windows.Forms.Label labelWait1C;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLost1C;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFree1C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWaitAO;
        private System.Windows.Forms.Label labelLostAO;
        private System.Windows.Forms.Label labelFreeAO;
        private System.Windows.Forms.Label label5;
    }
}

