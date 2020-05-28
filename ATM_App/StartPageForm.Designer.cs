namespace ATM_App
{
    partial class StartPageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPageForm));
            this.completeService = new System.Windows.Forms.Button();
            this.withdrawCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // completeService
            // 
            this.completeService.BackColor = System.Drawing.SystemColors.HighlightText;
            this.completeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeService.ForeColor = System.Drawing.Color.DarkOrange;
            this.completeService.Location = new System.Drawing.Point(422, 12);
            this.completeService.Name = "completeService";
            this.completeService.Size = new System.Drawing.Size(400, 85);
            this.completeService.TabIndex = 0;
            this.completeService.Text = "Завершить обслуживание";
            this.completeService.UseVisualStyleBackColor = false;
            this.completeService.Click += new System.EventHandler(this.completeService_Click);
            // 
            // withdrawCash
            // 
            this.withdrawCash.BackColor = System.Drawing.SystemColors.HighlightText;
            this.withdrawCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawCash.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.withdrawCash.Location = new System.Drawing.Point(422, 100);
            this.withdrawCash.Name = "withdrawCash";
            this.withdrawCash.Size = new System.Drawing.Size(400, 300);
            this.withdrawCash.TabIndex = 1;
            this.withdrawCash.Text = "Внести наличные";
            this.withdrawCash.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 300);
            this.button1.TabIndex = 2;
            this.button1.Text = "Снять наличные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Главное меню";
            // 
            // StartPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.withdrawCash);
            this.Controls.Add(this.completeService);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartPageForm";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeService;
        private System.Windows.Forms.Button withdrawCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

