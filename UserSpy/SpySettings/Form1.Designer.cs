namespace SpySettings
{
    partial class Form_spySettings
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
            this.button_start_spy = new System.Windows.Forms.Button();
            this.button_start_stats = new System.Windows.Forms.Button();
            this.checkBox_stats_on = new System.Windows.Forms.CheckBox();
            this.checkBox_mod_on = new System.Windows.Forms.CheckBox();
            this.textBox_stats_report = new System.Windows.Forms.TextBox();
            this.label_stats_report = new System.Windows.Forms.Label();
            this.label_mod_report = new System.Windows.Forms.Label();
            this.textBox_mod_report = new System.Windows.Forms.TextBox();
            this.label_bad_words = new System.Windows.Forms.Label();
            this.textBox_bad_words = new System.Windows.Forms.TextBox();
            this.label_bad_apps = new System.Windows.Forms.Label();
            this.textBox_bad_apps = new System.Windows.Forms.TextBox();
            this.button_stats_path = new System.Windows.Forms.Button();
            this.button_mod_path = new System.Windows.Forms.Button();
            this.button_badWords_path = new System.Windows.Forms.Button();
            this.button_badApps_path = new System.Windows.Forms.Button();
            this.button_stop_spy = new System.Windows.Forms.Button();
            this.radioButton_Disable = new System.Windows.Forms.RadioButton();
            this.radioButton_Statistics = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_start_spy
            // 
            this.button_start_spy.Location = new System.Drawing.Point(319, 15);
            this.button_start_spy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_start_spy.Name = "button_start_spy";
            this.button_start_spy.Size = new System.Drawing.Size(99, 33);
            this.button_start_spy.TabIndex = 0;
            this.button_start_spy.Text = "Start SpyApp";
            this.button_start_spy.UseVisualStyleBackColor = true;
            this.button_start_spy.Click += new System.EventHandler(this.button_start_spy_Click);
            // 
            // button_start_stats
            // 
            this.button_start_stats.Location = new System.Drawing.Point(319, 118);
            this.button_start_stats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_start_stats.Name = "button_start_stats";
            this.button_start_stats.Size = new System.Drawing.Size(99, 33);
            this.button_start_stats.TabIndex = 1;
            this.button_start_stats.Text = "Start StatsApp";
            this.button_start_stats.UseVisualStyleBackColor = true;
            this.button_start_stats.Click += new System.EventHandler(this.button_start_stats_Click);
            // 
            // checkBox_stats_on
            // 
            this.checkBox_stats_on.AutoSize = true;
            this.checkBox_stats_on.Location = new System.Drawing.Point(28, 24);
            this.checkBox_stats_on.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_stats_on.Name = "checkBox_stats_on";
            this.checkBox_stats_on.Size = new System.Drawing.Size(133, 17);
            this.checkBox_stats_on.TabIndex = 2;
            this.checkBox_stats_on.Text = "Собирать статистику";
            this.checkBox_stats_on.UseVisualStyleBackColor = true;
            // 
            // checkBox_mod_on
            // 
            this.checkBox_mod_on.AutoSize = true;
            this.checkBox_mod_on.Location = new System.Drawing.Point(28, 129);
            this.checkBox_mod_on.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_mod_on.Name = "checkBox_mod_on";
            this.checkBox_mod_on.Size = new System.Drawing.Size(100, 17);
            this.checkBox_mod_on.TabIndex = 3;
            this.checkBox_mod_on.Text = "Модерировать";
            this.checkBox_mod_on.UseVisualStyleBackColor = true;
            // 
            // textBox_stats_report
            // 
            this.textBox_stats_report.Location = new System.Drawing.Point(55, 72);
            this.textBox_stats_report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_stats_report.Name = "textBox_stats_report";
            this.textBox_stats_report.Size = new System.Drawing.Size(169, 20);
            this.textBox_stats_report.TabIndex = 4;
            // 
            // label_stats_report
            // 
            this.label_stats_report.AutoSize = true;
            this.label_stats_report.Location = new System.Drawing.Point(54, 50);
            this.label_stats_report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stats_report.Name = "label_stats_report";
            this.label_stats_report.Size = new System.Drawing.Size(88, 13);
            this.label_stats_report.TabIndex = 5;
            this.label_stats_report.Text = "Путь для отчета";
            // 
            // label_mod_report
            // 
            this.label_mod_report.AutoSize = true;
            this.label_mod_report.Location = new System.Drawing.Point(52, 159);
            this.label_mod_report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mod_report.Name = "label_mod_report";
            this.label_mod_report.Size = new System.Drawing.Size(88, 13);
            this.label_mod_report.TabIndex = 7;
            this.label_mod_report.Text = "Путь для отчета";
            // 
            // textBox_mod_report
            // 
            this.textBox_mod_report.Location = new System.Drawing.Point(53, 181);
            this.textBox_mod_report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_mod_report.Name = "textBox_mod_report";
            this.textBox_mod_report.Size = new System.Drawing.Size(169, 20);
            this.textBox_mod_report.TabIndex = 6;
            // 
            // label_bad_words
            // 
            this.label_bad_words.AutoSize = true;
            this.label_bad_words.Location = new System.Drawing.Point(54, 211);
            this.label_bad_words.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bad_words.Name = "label_bad_words";
            this.label_bad_words.Size = new System.Drawing.Size(174, 13);
            this.label_bad_words.TabIndex = 9;
            this.label_bad_words.Text = "Файл с запрещенными словами";
            // 
            // textBox_bad_words
            // 
            this.textBox_bad_words.Location = new System.Drawing.Point(55, 233);
            this.textBox_bad_words.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_bad_words.Name = "textBox_bad_words";
            this.textBox_bad_words.Size = new System.Drawing.Size(169, 20);
            this.textBox_bad_words.TabIndex = 8;
            // 
            // label_bad_apps
            // 
            this.label_bad_apps.AutoSize = true;
            this.label_bad_apps.Location = new System.Drawing.Point(54, 270);
            this.label_bad_apps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bad_apps.Name = "label_bad_apps";
            this.label_bad_apps.Size = new System.Drawing.Size(206, 13);
            this.label_bad_apps.TabIndex = 11;
            this.label_bad_apps.Text = "Файл с запрещенными приложениями";
            // 
            // textBox_bad_apps
            // 
            this.textBox_bad_apps.Location = new System.Drawing.Point(55, 292);
            this.textBox_bad_apps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_bad_apps.Name = "textBox_bad_apps";
            this.textBox_bad_apps.Size = new System.Drawing.Size(169, 20);
            this.textBox_bad_apps.TabIndex = 10;
            // 
            // button_stats_path
            // 
            this.button_stats_path.Location = new System.Drawing.Point(234, 71);
            this.button_stats_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_stats_path.Name = "button_stats_path";
            this.button_stats_path.Size = new System.Drawing.Size(38, 21);
            this.button_stats_path.TabIndex = 12;
            this.button_stats_path.Text = "...";
            this.button_stats_path.UseVisualStyleBackColor = true;
            // 
            // button_mod_path
            // 
            this.button_mod_path.Location = new System.Drawing.Point(234, 179);
            this.button_mod_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_mod_path.Name = "button_mod_path";
            this.button_mod_path.Size = new System.Drawing.Size(38, 21);
            this.button_mod_path.TabIndex = 13;
            this.button_mod_path.Text = "...";
            this.button_mod_path.UseVisualStyleBackColor = true;
            // 
            // button_badWords_path
            // 
            this.button_badWords_path.Location = new System.Drawing.Point(234, 231);
            this.button_badWords_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_badWords_path.Name = "button_badWords_path";
            this.button_badWords_path.Size = new System.Drawing.Size(38, 21);
            this.button_badWords_path.TabIndex = 14;
            this.button_badWords_path.Text = "...";
            this.button_badWords_path.UseVisualStyleBackColor = true;
            // 
            // button_badApps_path
            // 
            this.button_badApps_path.Location = new System.Drawing.Point(234, 291);
            this.button_badApps_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_badApps_path.Name = "button_badApps_path";
            this.button_badApps_path.Size = new System.Drawing.Size(38, 21);
            this.button_badApps_path.TabIndex = 15;
            this.button_badApps_path.Text = "...";
            this.button_badApps_path.UseVisualStyleBackColor = true;
            // 
            // button_stop_spy
            // 
            this.button_stop_spy.Location = new System.Drawing.Point(319, 56);
            this.button_stop_spy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_stop_spy.Name = "button_stop_spy";
            this.button_stop_spy.Size = new System.Drawing.Size(99, 33);
            this.button_stop_spy.TabIndex = 16;
            this.button_stop_spy.Text = "Stop SpyApp";
            this.button_stop_spy.UseVisualStyleBackColor = true;
            // 
            // radioButton_Disable
            // 
            this.radioButton_Disable.AutoSize = true;
            this.radioButton_Disable.Location = new System.Drawing.Point(57, 322);
            this.radioButton_Disable.Name = "radioButton_Disable";
            this.radioButton_Disable.Size = new System.Drawing.Size(134, 17);
            this.radioButton_Disable.TabIndex = 17;
            this.radioButton_Disable.TabStop = true;
            this.radioButton_Disable.Text = "Закрыть приложение";
            this.radioButton_Disable.UseVisualStyleBackColor = true;
            // 
            // radioButton_Statistics
            // 
            this.radioButton_Statistics.AutoSize = true;
            this.radioButton_Statistics.Location = new System.Drawing.Point(57, 345);
            this.radioButton_Statistics.Name = "radioButton_Statistics";
            this.radioButton_Statistics.Size = new System.Drawing.Size(132, 17);
            this.radioButton_Statistics.TabIndex = 18;
            this.radioButton_Statistics.TabStop = true;
            this.radioButton_Statistics.Text = "Собирать статистику";
            this.radioButton_Statistics.UseVisualStyleBackColor = true;
            // 
            // Form_spySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 371);
            this.Controls.Add(this.radioButton_Statistics);
            this.Controls.Add(this.radioButton_Disable);
            this.Controls.Add(this.button_stop_spy);
            this.Controls.Add(this.button_badApps_path);
            this.Controls.Add(this.button_badWords_path);
            this.Controls.Add(this.button_mod_path);
            this.Controls.Add(this.button_stats_path);
            this.Controls.Add(this.label_bad_apps);
            this.Controls.Add(this.textBox_bad_apps);
            this.Controls.Add(this.label_bad_words);
            this.Controls.Add(this.textBox_bad_words);
            this.Controls.Add(this.label_mod_report);
            this.Controls.Add(this.textBox_mod_report);
            this.Controls.Add(this.label_stats_report);
            this.Controls.Add(this.textBox_stats_report);
            this.Controls.Add(this.checkBox_mod_on);
            this.Controls.Add(this.checkBox_stats_on);
            this.Controls.Add(this.button_start_stats);
            this.Controls.Add(this.button_start_spy);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_spySettings";
            this.Text = "Spy Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start_spy;
        private System.Windows.Forms.Button button_start_stats;
        private System.Windows.Forms.CheckBox checkBox_stats_on;
        private System.Windows.Forms.CheckBox checkBox_mod_on;
        private System.Windows.Forms.TextBox textBox_stats_report;
        private System.Windows.Forms.Label label_stats_report;
        private System.Windows.Forms.Label label_mod_report;
        private System.Windows.Forms.TextBox textBox_mod_report;
        private System.Windows.Forms.Label label_bad_words;
        private System.Windows.Forms.TextBox textBox_bad_words;
        private System.Windows.Forms.Label label_bad_apps;
        private System.Windows.Forms.TextBox textBox_bad_apps;
        private System.Windows.Forms.Button button_stats_path;
        private System.Windows.Forms.Button button_mod_path;
        private System.Windows.Forms.Button button_badWords_path;
        private System.Windows.Forms.Button button_badApps_path;
        private System.Windows.Forms.Button button_stop_spy;
        private System.Windows.Forms.RadioButton radioButton_Disable;
        private System.Windows.Forms.RadioButton radioButton_Statistics;
    }
}

