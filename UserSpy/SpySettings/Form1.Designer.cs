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
            this.button_stop_spy = new System.Windows.Forms.Button();
            this.checkBox_proc_report = new System.Windows.Forms.CheckBox();
            this.textBox_proc_report = new System.Windows.Forms.TextBox();
            this.button_proc_report = new System.Windows.Forms.Button();
            this.button_keys_report = new System.Windows.Forms.Button();
            this.textBox_keys_report = new System.Windows.Forms.TextBox();
            this.checkBox_keys_report = new System.Windows.Forms.CheckBox();
            this.button_bad_apps = new System.Windows.Forms.Button();
            this.textBox_bad_apps = new System.Windows.Forms.TextBox();
            this.checkBox_proc_analys = new System.Windows.Forms.CheckBox();
            this.button_bad_words = new System.Windows.Forms.Button();
            this.textBox_bad_words = new System.Windows.Forms.TextBox();
            this.checkBox_keys_analys = new System.Windows.Forms.CheckBox();
            this.label_analys_proc = new System.Windows.Forms.Label();
            this.label_bad_words = new System.Windows.Forms.Label();
            this.label_badWords_report = new System.Windows.Forms.Label();
            this.button_badWords_report = new System.Windows.Forms.Button();
            this.textBox_badWords_report = new System.Windows.Forms.TextBox();
            this.radioButton_badApp_close = new System.Windows.Forms.RadioButton();
            this.radioButton_badApp_stats = new System.Windows.Forms.RadioButton();
            this.label_badProc_report = new System.Windows.Forms.Label();
            this.button_badProc_report = new System.Windows.Forms.Button();
            this.textBox_badProc_report = new System.Windows.Forms.TextBox();
            this.label_onOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start_spy
            // 
            this.button_start_spy.Location = new System.Drawing.Point(405, 81);
            this.button_start_spy.Name = "button_start_spy";
            this.button_start_spy.Size = new System.Drawing.Size(148, 51);
            this.button_start_spy.TabIndex = 0;
            this.button_start_spy.Text = "Start SpyApp";
            this.button_start_spy.UseVisualStyleBackColor = true;
            this.button_start_spy.Click += new System.EventHandler(this.button_start_spy_Click);
            // 
            // button_start_stats
            // 
            this.button_start_stats.Location = new System.Drawing.Point(405, 240);
            this.button_start_stats.Name = "button_start_stats";
            this.button_start_stats.Size = new System.Drawing.Size(148, 51);
            this.button_start_stats.TabIndex = 1;
            this.button_start_stats.Text = "Start StatsApp";
            this.button_start_stats.UseVisualStyleBackColor = true;
            this.button_start_stats.Click += new System.EventHandler(this.button_start_stats_Click);
            // 
            // button_stop_spy
            // 
            this.button_stop_spy.Location = new System.Drawing.Point(405, 144);
            this.button_stop_spy.Name = "button_stop_spy";
            this.button_stop_spy.Size = new System.Drawing.Size(148, 51);
            this.button_stop_spy.TabIndex = 16;
            this.button_stop_spy.Text = "Stop SpyApp";
            this.button_stop_spy.UseVisualStyleBackColor = true;
            this.button_stop_spy.Click += new System.EventHandler(this.button_stop_spy_Click);
            // 
            // checkBox_proc_report
            // 
            this.checkBox_proc_report.AutoSize = true;
            this.checkBox_proc_report.Location = new System.Drawing.Point(32, 41);
            this.checkBox_proc_report.Name = "checkBox_proc_report";
            this.checkBox_proc_report.Size = new System.Drawing.Size(204, 24);
            this.checkBox_proc_report.TabIndex = 17;
            this.checkBox_proc_report.Text = "Записывать процессы";
            this.checkBox_proc_report.UseVisualStyleBackColor = true;
            this.checkBox_proc_report.CheckedChanged += new System.EventHandler(this.checkBox_proc_report_CheckedChanged);
            // 
            // textBox_proc_report
            // 
            this.textBox_proc_report.Enabled = false;
            this.textBox_proc_report.Location = new System.Drawing.Point(55, 78);
            this.textBox_proc_report.Name = "textBox_proc_report";
            this.textBox_proc_report.Size = new System.Drawing.Size(243, 26);
            this.textBox_proc_report.TabIndex = 18;
            this.textBox_proc_report.TextChanged += new System.EventHandler(this.textBox_proc_report_TextChanged);
            // 
            // button_proc_report
            // 
            this.button_proc_report.Enabled = false;
            this.button_proc_report.Location = new System.Drawing.Point(304, 79);
            this.button_proc_report.Name = "button_proc_report";
            this.button_proc_report.Size = new System.Drawing.Size(55, 26);
            this.button_proc_report.TabIndex = 19;
            this.button_proc_report.Text = "...";
            this.button_proc_report.UseVisualStyleBackColor = true;
            this.button_proc_report.Click += new System.EventHandler(this.FileDialog);
            // 
            // button_keys_report
            // 
            this.button_keys_report.Enabled = false;
            this.button_keys_report.Location = new System.Drawing.Point(304, 163);
            this.button_keys_report.Name = "button_keys_report";
            this.button_keys_report.Size = new System.Drawing.Size(55, 26);
            this.button_keys_report.TabIndex = 22;
            this.button_keys_report.Text = "...";
            this.button_keys_report.UseVisualStyleBackColor = true;
            this.button_keys_report.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_keys_report
            // 
            this.textBox_keys_report.Enabled = false;
            this.textBox_keys_report.Location = new System.Drawing.Point(55, 162);
            this.textBox_keys_report.Name = "textBox_keys_report";
            this.textBox_keys_report.Size = new System.Drawing.Size(243, 26);
            this.textBox_keys_report.TabIndex = 21;
            this.textBox_keys_report.TextChanged += new System.EventHandler(this.textBox_keys_report_TextChanged);
            // 
            // checkBox_keys_report
            // 
            this.checkBox_keys_report.AutoSize = true;
            this.checkBox_keys_report.Location = new System.Drawing.Point(32, 125);
            this.checkBox_keys_report.Name = "checkBox_keys_report";
            this.checkBox_keys_report.Size = new System.Drawing.Size(199, 24);
            this.checkBox_keys_report.TabIndex = 20;
            this.checkBox_keys_report.Text = "Записывать клавиши";
            this.checkBox_keys_report.UseVisualStyleBackColor = true;
            this.checkBox_keys_report.CheckedChanged += new System.EventHandler(this.checkBox_keys_report_CheckedChanged);
            // 
            // button_bad_apps
            // 
            this.button_bad_apps.Enabled = false;
            this.button_bad_apps.Location = new System.Drawing.Point(304, 307);
            this.button_bad_apps.Name = "button_bad_apps";
            this.button_bad_apps.Size = new System.Drawing.Size(55, 26);
            this.button_bad_apps.TabIndex = 25;
            this.button_bad_apps.Text = "...";
            this.button_bad_apps.UseVisualStyleBackColor = true;
            this.button_bad_apps.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_bad_apps
            // 
            this.textBox_bad_apps.Enabled = false;
            this.textBox_bad_apps.Location = new System.Drawing.Point(55, 306);
            this.textBox_bad_apps.Name = "textBox_bad_apps";
            this.textBox_bad_apps.ReadOnly = true;
            this.textBox_bad_apps.Size = new System.Drawing.Size(243, 26);
            this.textBox_bad_apps.TabIndex = 24;
            this.textBox_bad_apps.TextChanged += new System.EventHandler(this.textBox_bad_apps_TextChanged);
            // 
            // checkBox_proc_analys
            // 
            this.checkBox_proc_analys.AutoSize = true;
            this.checkBox_proc_analys.Location = new System.Drawing.Point(32, 250);
            this.checkBox_proc_analys.Name = "checkBox_proc_analys";
            this.checkBox_proc_analys.Size = new System.Drawing.Size(230, 24);
            this.checkBox_proc_analys.TabIndex = 23;
            this.checkBox_proc_analys.Text = "Анализировать процессы";
            this.checkBox_proc_analys.UseVisualStyleBackColor = true;
            this.checkBox_proc_analys.CheckedChanged += new System.EventHandler(this.checkBox_proc_analys_CheckedChanged);
            // 
            // button_bad_words
            // 
            this.button_bad_words.Enabled = false;
            this.button_bad_words.Location = new System.Drawing.Point(304, 569);
            this.button_bad_words.Name = "button_bad_words";
            this.button_bad_words.Size = new System.Drawing.Size(55, 26);
            this.button_bad_words.TabIndex = 28;
            this.button_bad_words.Text = "...";
            this.button_bad_words.UseVisualStyleBackColor = true;
            this.button_bad_words.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_bad_words
            // 
            this.textBox_bad_words.Enabled = false;
            this.textBox_bad_words.Location = new System.Drawing.Point(55, 568);
            this.textBox_bad_words.Name = "textBox_bad_words";
            this.textBox_bad_words.ReadOnly = true;
            this.textBox_bad_words.Size = new System.Drawing.Size(243, 26);
            this.textBox_bad_words.TabIndex = 27;
            this.textBox_bad_words.TextChanged += new System.EventHandler(this.textBox_bad_words_TextChanged);
            // 
            // checkBox_keys_analys
            // 
            this.checkBox_keys_analys.AutoSize = true;
            this.checkBox_keys_analys.Location = new System.Drawing.Point(32, 509);
            this.checkBox_keys_analys.Name = "checkBox_keys_analys";
            this.checkBox_keys_analys.Size = new System.Drawing.Size(225, 24);
            this.checkBox_keys_analys.TabIndex = 26;
            this.checkBox_keys_analys.Text = "Анализировать клавиши";
            this.checkBox_keys_analys.UseVisualStyleBackColor = true;
            this.checkBox_keys_analys.CheckedChanged += new System.EventHandler(this.checkBox_keys_analys_CheckedChanged);
            // 
            // label_analys_proc
            // 
            this.label_analys_proc.AutoSize = true;
            this.label_analys_proc.Location = new System.Drawing.Point(55, 283);
            this.label_analys_proc.Name = "label_analys_proc";
            this.label_analys_proc.Size = new System.Drawing.Size(281, 20);
            this.label_analys_proc.TabIndex = 29;
            this.label_analys_proc.Text = "Файл с запрещенными процессами:";
            // 
            // label_bad_words
            // 
            this.label_bad_words.AutoSize = true;
            this.label_bad_words.Location = new System.Drawing.Point(55, 540);
            this.label_bad_words.Name = "label_bad_words";
            this.label_bad_words.Size = new System.Drawing.Size(256, 20);
            this.label_bad_words.TabIndex = 30;
            this.label_bad_words.Text = "Файл с запрещенными словами:";
            // 
            // label_badWords_report
            // 
            this.label_badWords_report.AutoSize = true;
            this.label_badWords_report.Location = new System.Drawing.Point(55, 610);
            this.label_badWords_report.Name = "label_badWords_report";
            this.label_badWords_report.Size = new System.Drawing.Size(114, 20);
            this.label_badWords_report.TabIndex = 33;
            this.label_badWords_report.Text = "Файл отчета:";
            // 
            // button_badWords_report
            // 
            this.button_badWords_report.Enabled = false;
            this.button_badWords_report.Location = new System.Drawing.Point(304, 639);
            this.button_badWords_report.Name = "button_badWords_report";
            this.button_badWords_report.Size = new System.Drawing.Size(55, 26);
            this.button_badWords_report.TabIndex = 32;
            this.button_badWords_report.Text = "...";
            this.button_badWords_report.UseVisualStyleBackColor = true;
            this.button_badWords_report.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_badWords_report
            // 
            this.textBox_badWords_report.Enabled = false;
            this.textBox_badWords_report.Location = new System.Drawing.Point(55, 638);
            this.textBox_badWords_report.Name = "textBox_badWords_report";
            this.textBox_badWords_report.Size = new System.Drawing.Size(243, 26);
            this.textBox_badWords_report.TabIndex = 31;
            this.textBox_badWords_report.TextChanged += new System.EventHandler(this.textBox_badWords_report_TextChanged);
            // 
            // radioButton_badApp_close
            // 
            this.radioButton_badApp_close.AutoSize = true;
            this.radioButton_badApp_close.Enabled = false;
            this.radioButton_badApp_close.Location = new System.Drawing.Point(55, 417);
            this.radioButton_badApp_close.Name = "radioButton_badApp_close";
            this.radioButton_badApp_close.Size = new System.Drawing.Size(273, 24);
            this.radioButton_badApp_close.TabIndex = 34;
            this.radioButton_badApp_close.Text = "Закрыть запрещенный процесс";
            this.radioButton_badApp_close.UseVisualStyleBackColor = true;
            this.radioButton_badApp_close.CheckedChanged += new System.EventHandler(this.radioButton_badApp_close_CheckedChanged);
            // 
            // radioButton_badApp_stats
            // 
            this.radioButton_badApp_stats.AutoSize = true;
            this.radioButton_badApp_stats.Checked = true;
            this.radioButton_badApp_stats.Enabled = false;
            this.radioButton_badApp_stats.Location = new System.Drawing.Point(55, 449);
            this.radioButton_badApp_stats.Name = "radioButton_badApp_stats";
            this.radioButton_badApp_stats.Size = new System.Drawing.Size(280, 24);
            this.radioButton_badApp_stats.TabIndex = 35;
            this.radioButton_badApp_stats.TabStop = true;
            this.radioButton_badApp_stats.Text = "Записать запрещенный процесс";
            this.radioButton_badApp_stats.UseVisualStyleBackColor = true;
            this.radioButton_badApp_stats.CheckedChanged += new System.EventHandler(this.radioButton_badApp_stats_CheckedChanged);
            // 
            // label_badProc_report
            // 
            this.label_badProc_report.AutoSize = true;
            this.label_badProc_report.Location = new System.Drawing.Point(55, 345);
            this.label_badProc_report.Name = "label_badProc_report";
            this.label_badProc_report.Size = new System.Drawing.Size(114, 20);
            this.label_badProc_report.TabIndex = 38;
            this.label_badProc_report.Text = "Файл отчета:";
            // 
            // button_badProc_report
            // 
            this.button_badProc_report.Enabled = false;
            this.button_badProc_report.Location = new System.Drawing.Point(304, 374);
            this.button_badProc_report.Name = "button_badProc_report";
            this.button_badProc_report.Size = new System.Drawing.Size(55, 26);
            this.button_badProc_report.TabIndex = 37;
            this.button_badProc_report.Text = "...";
            this.button_badProc_report.UseVisualStyleBackColor = true;
            this.button_badProc_report.Click += new System.EventHandler(this.FileDialog);
            // 
            // textBox_badProc_report
            // 
            this.textBox_badProc_report.Enabled = false;
            this.textBox_badProc_report.Location = new System.Drawing.Point(55, 373);
            this.textBox_badProc_report.Name = "textBox_badProc_report";
            this.textBox_badProc_report.Size = new System.Drawing.Size(243, 26);
            this.textBox_badProc_report.TabIndex = 36;
            this.textBox_badProc_report.TextChanged += new System.EventHandler(this.textBox_badProc_report_TextChanged);
            // 
            // label_onOff
            // 
            this.label_onOff.AutoSize = true;
            this.label_onOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_onOff.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_onOff.Location = new System.Drawing.Point(405, 9);
            this.label_onOff.Name = "label_onOff";
            this.label_onOff.Size = new System.Drawing.Size(115, 38);
            this.label_onOff.TabIndex = 39;
            this.label_onOff.Text = "On-Off";
            // 
            // Form_spySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 683);
            this.Controls.Add(this.label_onOff);
            this.Controls.Add(this.label_badProc_report);
            this.Controls.Add(this.button_badProc_report);
            this.Controls.Add(this.textBox_badProc_report);
            this.Controls.Add(this.radioButton_badApp_stats);
            this.Controls.Add(this.radioButton_badApp_close);
            this.Controls.Add(this.label_badWords_report);
            this.Controls.Add(this.button_badWords_report);
            this.Controls.Add(this.textBox_badWords_report);
            this.Controls.Add(this.label_bad_words);
            this.Controls.Add(this.label_analys_proc);
            this.Controls.Add(this.button_bad_words);
            this.Controls.Add(this.textBox_bad_words);
            this.Controls.Add(this.checkBox_keys_analys);
            this.Controls.Add(this.button_bad_apps);
            this.Controls.Add(this.textBox_bad_apps);
            this.Controls.Add(this.checkBox_proc_analys);
            this.Controls.Add(this.button_keys_report);
            this.Controls.Add(this.textBox_keys_report);
            this.Controls.Add(this.checkBox_keys_report);
            this.Controls.Add(this.button_proc_report);
            this.Controls.Add(this.textBox_proc_report);
            this.Controls.Add(this.checkBox_proc_report);
            this.Controls.Add(this.button_stop_spy);
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
        private System.Windows.Forms.Button button_stop_spy;
        private System.Windows.Forms.CheckBox checkBox_proc_report;
        private System.Windows.Forms.TextBox textBox_proc_report;
        private System.Windows.Forms.Button button_proc_report;
        private System.Windows.Forms.Button button_keys_report;
        private System.Windows.Forms.TextBox textBox_keys_report;
        private System.Windows.Forms.CheckBox checkBox_keys_report;
        private System.Windows.Forms.Button button_bad_apps;
        private System.Windows.Forms.TextBox textBox_bad_apps;
        private System.Windows.Forms.CheckBox checkBox_proc_analys;
        private System.Windows.Forms.Button button_bad_words;
        private System.Windows.Forms.TextBox textBox_bad_words;
        private System.Windows.Forms.CheckBox checkBox_keys_analys;
        private System.Windows.Forms.Label label_analys_proc;
        private System.Windows.Forms.Label label_bad_words;
        private System.Windows.Forms.Label label_badWords_report;
        private System.Windows.Forms.Button button_badWords_report;
        private System.Windows.Forms.TextBox textBox_badWords_report;
        private System.Windows.Forms.RadioButton radioButton_badApp_close;
        private System.Windows.Forms.RadioButton radioButton_badApp_stats;
        private System.Windows.Forms.Label label_badProc_report;
        private System.Windows.Forms.Button button_badProc_report;
        private System.Windows.Forms.TextBox textBox_badProc_report;
        private System.Windows.Forms.Label label_onOff;
    }
}

