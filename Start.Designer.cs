namespace ByteGeeks_IT
{
    partial class Start
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblsysStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartingProgress = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.StartingProgress);
            this.panel1.Controls.Add(this.LblsysStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 656);
            this.panel1.TabIndex = 0;
            // 
            // LblsysStart
            // 
            this.LblsysStart.AutoSize = true;
            this.LblsysStart.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblsysStart.Location = new System.Drawing.Point(392, 275);
            this.LblsysStart.Name = "LblsysStart";
            this.LblsysStart.Size = new System.Drawing.Size(274, 32);
            this.LblsysStart.TabIndex = 1;
            this.LblsysStart.Text = "System is Starting";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // StartingProgress
            // 
            this.StartingProgress.Location = new System.Drawing.Point(0, 614);
            this.StartingProgress.Name = "StartingProgress";
            this.StartingProgress.Size = new System.Drawing.Size(1092, 42);
            this.StartingProgress.TabIndex = 2;
            this.StartingProgress.Click += new System.EventHandler(this.StartingProgress_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 656);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblsysStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar StartingProgress;
    }
}

