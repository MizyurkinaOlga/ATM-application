namespace ATM_App
{
    partial class DepositCashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositCashForm));
            this.returnToStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnToStart
            // 
            this.returnToStart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.returnToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnToStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnToStart.Location = new System.Drawing.Point(10, 7);
            this.returnToStart.Name = "returnToStart";
            this.returnToStart.Size = new System.Drawing.Size(270, 50);
            this.returnToStart.TabIndex = 0;
            this.returnToStart.Text = "В главное меню";
            this.returnToStart.UseVisualStyleBackColor = false;
            this.returnToStart.Click += new System.EventHandler(this.returnToStart_Click);
            // 
            // DepositCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.returnToStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositCash";
            this.Text = "ATM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnToStart;
    }
}