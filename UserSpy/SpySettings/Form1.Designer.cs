﻿namespace SpySettings
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
            this.textBox_stats_keys = new System.Windows.Forms.TextBox();
            this.label_stats_keys = new System.Windows.Forms.Label();
            this.label_mod_report = new System.Windows.Forms.Label();
            this.textBox_mod_report = new System.Windows.Forms.TextBox();
            this.label_bad_words = new System.Windows.Forms.Label();
            this.textBox_bad_words = new System.Windows.Forms.TextBox();
            this.label_bad_apps = new System.Windows.Forms.Label();
            this.textBox_bad_apps = new System.Windows.Forms.TextBox();
            this.button_stats_keys = new System.Windows.Forms.Button();
            this.button_mod_path = new System.Windows.Forms.Button();
            this.button_badWords_path = new System.Windows.Forms.Button();
            this.button_badApps_path = new System.Windows.Forms.Button();
            this.button_stop_spy = new System.Windows.Forms.Button();
            this.radioButton_Disable = new System.Windows.Forms.RadioButton();
            this.radioButton_Statistics = new System.Windows.Forms.RadioButton();
            this.button_stats_proc = new System.Windows.Forms.Button();
            this.textBox_stats_proc = new System.Windows.Forms.TextBox();
            this.label_stats_proc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start_spy
            // 
            this.button_start_spy.Location = new System.Drawing.Point(478, 23);
            this.button_start_spy.Name = "button_start_spy";
            this.button_start_spy.Size = new System.Drawing.Size(148, 51);
            this.button_start_spy.TabIndex = 0;
            this.button_start_spy.Text = "Start SpyApp";
            this.button_start_spy.UseVisualStyleBackColor = true;
            this.button_start_spy.Click += new System.EventHandler(this.button_start_spy_Click);
            // 
            // button_start_stats
            // 
            this.button_start_stats.Location = new System.Drawing.Point(478, 182);
            this.button_start_stats.Name = "button_start_stats";
            this.button_start_stats.Size = new System.Drawing.Size(148, 51);
            this.button_start_stats.TabIndex = 1;
            this.button_start_stats.Text = "Start StatsApp";
            this.button_start_stats.UseVisualStyleBackColor = true;
            this.button_start_stats.Click += new System.EventHandler(this.button_start_stats_Click);
            // 
            // checkBox_stats_on
            // 
            this.checkBox_stats_on.AutoSize = true;
            this.checkBox_stats_on.Location = new System.Drawing.Point(42, 37);
            this.checkBox_stats_on.Name = "checkBox_stats_on";
            this.checkBox_stats_on.Size = new System.Drawing.Size(198, 24);
            this.checkBox_stats_on.TabIndex = 2;
            this.checkBox_stats_on.Text = "Собирать статистику";
            this.checkBox_stats_on.UseVisualStyleBackColor = true;
            this.checkBox_stats_on.CheckedChanged += new System.EventHandler(this.checkBox_stats_on_CheckedChanged);
            // 
            // checkBox_mod_on
            // 
            this.checkBox_mod_on.AutoSize = true;
            this.checkBox_mod_on.Location = new System.Drawing.Point(42, 263);
            this.checkBox_mod_on.Name = "checkBox_mod_on";
            this.checkBox_mod_on.Size = new System.Drawing.Size(149, 24);
            this.checkBox_mod_on.TabIndex = 3;
            this.checkBox_mod_on.Text = "Модерировать";
            this.checkBox_mod_on.UseVisualStyleBackColor = true;
            this.checkBox_mod_on.CheckedChanged += new System.EventHandler(this.checkBox_mod_on_CheckedChanged);
            // 
            // textBox_stats_keys
            // 
            this.textBox_stats_keys.Location = new System.Drawing.Point(82, 111);
            this.textBox_stats_keys.Name = "textBox_stats_keys";
            this.textBox_stats_keys.Size = new System.Drawing.Size(252, 26);
            this.textBox_stats_keys.TabIndex = 4;
            this.textBox_stats_keys.TextChanged += new System.EventHandler(this.textBox_stats_keys_TextChanged);
            // 
            // label_stats_keys
            // 
            this.label_stats_keys.AutoSize = true;
            this.label_stats_keys.Location = new System.Drawing.Point(81, 77);
            this.label_stats_keys.Name = "label_stats_keys";
            this.label_stats_keys.Size = new System.Drawing.Size(215, 20);
            this.label_stats_keys.TabIndex = 5;
            this.label_stats_keys.Text = "Куда записывать клавиши:";
            // 
            // label_mod_report
            // 
            this.label_mod_report.AutoSize = true;
            this.label_mod_report.Location = new System.Drawing.Point(78, 310);
            this.label_mod_report.Name = "label_mod_report";
            this.label_mod_report.Size = new System.Drawing.Size(193, 20);
            this.label_mod_report.TabIndex = 7;
            this.label_mod_report.Text = "Куда записывать слова:";
            // 
            // textBox_mod_report
            // 
            this.textBox_mod_report.Location = new System.Drawing.Point(80, 343);
            this.textBox_mod_report.Name = "textBox_mod_report";
            this.textBox_mod_report.Size = new System.Drawing.Size(252, 26);
            this.textBox_mod_report.TabIndex = 6;
            this.textBox_mod_report.TextChanged += new System.EventHandler(this.textBox_mod_report_TextChanged);
            // 
            // label_bad_words
            // 
            this.label_bad_words.AutoSize = true;
            this.label_bad_words.Location = new System.Drawing.Point(81, 390);
            this.label_bad_words.Name = "label_bad_words";
            this.label_bad_words.Size = new System.Drawing.Size(252, 20);
            this.label_bad_words.TabIndex = 9;
            this.label_bad_words.Text = "Файл с запрещенными словами";
            // 
            // textBox_bad_words
            // 
            this.textBox_bad_words.Location = new System.Drawing.Point(82, 423);
            this.textBox_bad_words.Name = "textBox_bad_words";
            this.textBox_bad_words.Size = new System.Drawing.Size(252, 26);
            this.textBox_bad_words.TabIndex = 8;
            this.textBox_bad_words.TextChanged += new System.EventHandler(this.textBox_bad_words_TextChanged);
            // 
            // label_bad_apps
            // 
            this.label_bad_apps.AutoSize = true;
            this.label_bad_apps.Location = new System.Drawing.Point(81, 480);
            this.label_bad_apps.Name = "label_bad_apps";
            this.label_bad_apps.Size = new System.Drawing.Size(300, 20);
            this.label_bad_apps.TabIndex = 11;
            this.label_bad_apps.Text = "Файл с запрещенными приложениями";
            // 
            // textBox_bad_apps
            // 
            this.textBox_bad_apps.Location = new System.Drawing.Point(82, 514);
            this.textBox_bad_apps.Name = "textBox_bad_apps";
            this.textBox_bad_apps.Size = new System.Drawing.Size(252, 26);
            this.textBox_bad_apps.TabIndex = 10;
            this.textBox_bad_apps.TextChanged += new System.EventHandler(this.textBox_bad_apps_TextChanged);
            // 
            // button_stats_keys
            // 
            this.button_stats_keys.Location = new System.Drawing.Point(351, 109);
            this.button_stats_keys.Name = "button_stats_keys";
            this.button_stats_keys.Size = new System.Drawing.Size(57, 32);
            this.button_stats_keys.TabIndex = 12;
            this.button_stats_keys.Text = "...";
            this.button_stats_keys.UseVisualStyleBackColor = true;
            this.button_stats_keys.Click += new System.EventHandler(this.FileDialog);
            // 
            // button_mod_path
            // 
            this.button_mod_path.Location = new System.Drawing.Point(351, 340);
            this.button_mod_path.Name = "button_mod_path";
            this.button_mod_path.Size = new System.Drawing.Size(57, 32);
            this.button_mod_path.TabIndex = 13;
            this.button_mod_path.Text = "...";
            this.button_mod_path.UseVisualStyleBackColor = true;
            this.button_mod_path.Click += new System.EventHandler(this.FileDialog);
            // 
            // button_badWords_path
            // 
            this.button_badWords_path.Location = new System.Drawing.Point(351, 420);
            this.button_badWords_path.Name = "button_badWords_path";
            this.button_badWords_path.Size = new System.Drawing.Size(57, 32);
            this.button_badWords_path.TabIndex = 14;
            this.button_badWords_path.Text = "...";
            this.button_badWords_path.UseVisualStyleBackColor = true;
            this.button_badWords_path.Click += new System.EventHandler(this.FileDialog);
            // 
            // button_badApps_path
            // 
            this.button_badApps_path.Location = new System.Drawing.Point(351, 513);
            this.button_badApps_path.Name = "button_badApps_path";
            this.button_badApps_path.Size = new System.Drawing.Size(57, 32);
            this.button_badApps_path.TabIndex = 15;
            this.button_badApps_path.Text = "...";
            this.button_badApps_path.UseVisualStyleBackColor = true;
            this.button_badApps_path.Click += new System.EventHandler(this.FileDialog);
            // 
            // button_stop_spy
            // 
            this.button_stop_spy.Location = new System.Drawing.Point(478, 86);
            this.button_stop_spy.Name = "button_stop_spy";
            this.button_stop_spy.Size = new System.Drawing.Size(148, 51);
            this.button_stop_spy.TabIndex = 16;
            this.button_stop_spy.Text = "Stop SpyApp";
            this.button_stop_spy.UseVisualStyleBackColor = true;
            this.button_stop_spy.Click += new System.EventHandler(this.button_stop_spy_Click);
            // 
            // radioButton_Disable
            // 
            this.radioButton_Disable.AutoSize = true;
            this.radioButton_Disable.Location = new System.Drawing.Point(86, 560);
            this.radioButton_Disable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Disable.Name = "radioButton_Disable";
            this.radioButton_Disable.Size = new System.Drawing.Size(197, 24);
            this.radioButton_Disable.TabIndex = 17;
            this.radioButton_Disable.TabStop = true;
            this.radioButton_Disable.Text = "Закрыть приложение";
            this.radioButton_Disable.UseVisualStyleBackColor = true;
            this.radioButton_Disable.CheckedChanged += new System.EventHandler(this.radioButton_Disable_CheckedChanged);
            // 
            // radioButton_Statistics
            // 
            this.radioButton_Statistics.AutoSize = true;
            this.radioButton_Statistics.Location = new System.Drawing.Point(86, 596);
            this.radioButton_Statistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Statistics.Name = "radioButton_Statistics";
            this.radioButton_Statistics.Size = new System.Drawing.Size(197, 24);
            this.radioButton_Statistics.TabIndex = 18;
            this.radioButton_Statistics.TabStop = true;
            this.radioButton_Statistics.Text = "Собирать статистику";
            this.radioButton_Statistics.UseVisualStyleBackColor = true;
            this.radioButton_Statistics.CheckedChanged += new System.EventHandler(this.radioButton_Statistics_CheckedChanged);
            // 
            // button_stats_proc
            // 
            this.button_stats_proc.Location = new System.Drawing.Point(351, 183);
            this.button_stats_proc.Name = "button_stats_proc";
            this.button_stats_proc.Size = new System.Drawing.Size(57, 32);
            this.button_stats_proc.TabIndex = 19;
            this.button_stats_proc.Text = "...";
            this.button_stats_proc.UseVisualStyleBackColor = true;
            this.button_stats_proc.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_stats_proc
            // 
            this.textBox_stats_proc.Location = new System.Drawing.Point(81, 186);
            this.textBox_stats_proc.Name = "textBox_stats_proc";
            this.textBox_stats_proc.Size = new System.Drawing.Size(252, 26);
            this.textBox_stats_proc.TabIndex = 20;
            this.textBox_stats_proc.TextChanged += new System.EventHandler(this.textBox_stats_proc_TextChanged);
            // 
            // label_stats_proc
            // 
            this.label_stats_proc.AutoSize = true;
            this.label_stats_proc.Location = new System.Drawing.Point(81, 154);
            this.label_stats_proc.Name = "label_stats_proc";
            this.label_stats_proc.Size = new System.Drawing.Size(220, 20);
            this.label_stats_proc.TabIndex = 21;
            this.label_stats_proc.Text = "Куда записывать процессы:";
            // 
            // Form_spySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 693);
            this.Controls.Add(this.label_stats_proc);
            this.Controls.Add(this.textBox_stats_proc);
            this.Controls.Add(this.button_stats_proc);
            this.Controls.Add(this.radioButton_Statistics);
            this.Controls.Add(this.radioButton_Disable);
            this.Controls.Add(this.button_stop_spy);
            this.Controls.Add(this.button_badApps_path);
            this.Controls.Add(this.button_badWords_path);
            this.Controls.Add(this.button_mod_path);
            this.Controls.Add(this.button_stats_keys);
            this.Controls.Add(this.label_bad_apps);
            this.Controls.Add(this.textBox_bad_apps);
            this.Controls.Add(this.label_bad_words);
            this.Controls.Add(this.textBox_bad_words);
            this.Controls.Add(this.label_mod_report);
            this.Controls.Add(this.textBox_mod_report);
            this.Controls.Add(this.label_stats_keys);
            this.Controls.Add(this.textBox_stats_keys);
            this.Controls.Add(this.checkBox_mod_on);
            this.Controls.Add(this.checkBox_stats_on);
            this.Controls.Add(this.button_start_stats);
            this.Controls.Add(this.button_start_spy);
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
        private System.Windows.Forms.TextBox textBox_stats_keys;
        private System.Windows.Forms.Label label_stats_keys;
        private System.Windows.Forms.Label label_mod_report;
        private System.Windows.Forms.TextBox textBox_mod_report;
        private System.Windows.Forms.Label label_bad_words;
        private System.Windows.Forms.TextBox textBox_bad_words;
        private System.Windows.Forms.Label label_bad_apps;
        private System.Windows.Forms.TextBox textBox_bad_apps;
        private System.Windows.Forms.Button button_stats_keys;
        private System.Windows.Forms.Button button_mod_path;
        private System.Windows.Forms.Button button_badWords_path;
        private System.Windows.Forms.Button button_badApps_path;
        private System.Windows.Forms.Button button_stop_spy;
        private System.Windows.Forms.RadioButton radioButton_Disable;
        private System.Windows.Forms.RadioButton radioButton_Statistics;
        private System.Windows.Forms.Button button_stats_proc;
        private System.Windows.Forms.TextBox textBox_stats_proc;
        private System.Windows.Forms.Label label_stats_proc;
    }
}

