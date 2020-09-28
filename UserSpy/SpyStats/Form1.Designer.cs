namespace SpyStats
{
    partial class Form_stats
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
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_stats_path = new System.Windows.Forms.TextBox();
            this.label_stats_report = new System.Windows.Forms.Label();
            this.button_stats_path = new System.Windows.Forms.Button();
            this.button_mod_path = new System.Windows.Forms.Button();
            this.textBox_mod_path = new System.Windows.Forms.TextBox();
            this.label_mod_report = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(34, 141);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(726, 326);
            this.textBox_log.TabIndex = 0;
            // 
            // textBox_stats_path
            // 
            this.textBox_stats_path.Location = new System.Drawing.Point(214, 29);
            this.textBox_stats_path.Name = "textBox_stats_path";
            this.textBox_stats_path.Size = new System.Drawing.Size(449, 26);
            this.textBox_stats_path.TabIndex = 1;
            // 
            // label_stats_report
            // 
            this.label_stats_report.AutoSize = true;
            this.label_stats_report.Location = new System.Drawing.Point(30, 32);
            this.label_stats_report.Name = "label_stats_report";
            this.label_stats_report.Size = new System.Drawing.Size(174, 20);
            this.label_stats_report.TabIndex = 3;
            this.label_stats_report.Text = "Отчет по статистике:";
            // 
            // button_stats_path
            // 
            this.button_stats_path.Location = new System.Drawing.Point(685, 24);
            this.button_stats_path.Name = "button_stats_path";
            this.button_stats_path.Size = new System.Drawing.Size(75, 36);
            this.button_stats_path.TabIndex = 5;
            this.button_stats_path.Text = "...";
            this.button_stats_path.UseVisualStyleBackColor = true;
            // 
            // button_mod_path
            // 
            this.button_mod_path.Location = new System.Drawing.Point(685, 79);
            this.button_mod_path.Name = "button_mod_path";
            this.button_mod_path.Size = new System.Drawing.Size(75, 36);
            this.button_mod_path.TabIndex = 6;
            this.button_mod_path.Text = "...";
            this.button_mod_path.UseVisualStyleBackColor = true;
            // 
            // textBox_mod_path
            // 
            this.textBox_mod_path.Location = new System.Drawing.Point(214, 84);
            this.textBox_mod_path.Name = "textBox_mod_path";
            this.textBox_mod_path.Size = new System.Drawing.Size(449, 26);
            this.textBox_mod_path.TabIndex = 2;
            // 
            // label_mod_report
            // 
            this.label_mod_report.AutoSize = true;
            this.label_mod_report.Location = new System.Drawing.Point(32, 84);
            this.label_mod_report.Name = "label_mod_report";
            this.label_mod_report.Size = new System.Drawing.Size(172, 20);
            this.label_mod_report.TabIndex = 4;
            this.label_mod_report.Text = "Отчет по модерации:";
            // 
            // Form_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button_mod_path);
            this.Controls.Add(this.button_stats_path);
            this.Controls.Add(this.label_mod_report);
            this.Controls.Add(this.label_stats_report);
            this.Controls.Add(this.textBox_mod_path);
            this.Controls.Add(this.textBox_stats_path);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form_stats";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_stats_path;
        private System.Windows.Forms.Label label_stats_report;
        private System.Windows.Forms.Button button_stats_path;
        private System.Windows.Forms.Button button_mod_path;
        private System.Windows.Forms.TextBox textBox_mod_path;
        private System.Windows.Forms.Label label_mod_report;
    }
}

