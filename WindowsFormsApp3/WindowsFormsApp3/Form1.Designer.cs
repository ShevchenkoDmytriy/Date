namespace WindowsFormsApp3
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.YearRadio = new System.Windows.Forms.RadioButton();
            this.MonthRadio = new System.Windows.Forms.RadioButton();
            this.DayRadio = new System.Windows.Forms.RadioButton();
            this.minutesRadio = new System.Windows.Forms.RadioButton();
            this.secondsRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 2;
            // 
            // YearRadio
            // 
            this.YearRadio.AutoSize = true;
            this.YearRadio.Location = new System.Drawing.Point(12, 97);
            this.YearRadio.Name = "YearRadio";
            this.YearRadio.Size = new System.Drawing.Size(47, 17);
            this.YearRadio.TabIndex = 4;
            this.YearRadio.TabStop = true;
            this.YearRadio.Text = "Year";
            this.YearRadio.UseVisualStyleBackColor = true;
            // 
            // MonthRadio
            // 
            this.MonthRadio.AutoSize = true;
            this.MonthRadio.Location = new System.Drawing.Point(65, 97);
            this.MonthRadio.Name = "MonthRadio";
            this.MonthRadio.Size = new System.Drawing.Size(55, 17);
            this.MonthRadio.TabIndex = 5;
            this.MonthRadio.TabStop = true;
            this.MonthRadio.Text = "Month";
            this.MonthRadio.UseVisualStyleBackColor = true;
            // 
            // DayRadio
            // 
            this.DayRadio.AutoSize = true;
            this.DayRadio.Location = new System.Drawing.Point(126, 97);
            this.DayRadio.Name = "DayRadio";
            this.DayRadio.Size = new System.Drawing.Size(44, 17);
            this.DayRadio.TabIndex = 6;
            this.DayRadio.TabStop = true;
            this.DayRadio.Text = "Day";
            this.DayRadio.UseVisualStyleBackColor = true;
            // 
            // minutesRadio
            // 
            this.minutesRadio.AutoSize = true;
            this.minutesRadio.Location = new System.Drawing.Point(176, 97);
            this.minutesRadio.Name = "minutesRadio";
            this.minutesRadio.Size = new System.Drawing.Size(62, 17);
            this.minutesRadio.TabIndex = 7;
            this.minutesRadio.TabStop = true;
            this.minutesRadio.Text = "Minutes";
            this.minutesRadio.UseVisualStyleBackColor = true;
            // 
            // secondsRadio
            // 
            this.secondsRadio.AutoSize = true;
            this.secondsRadio.Location = new System.Drawing.Point(244, 97);
            this.secondsRadio.Name = "secondsRadio";
            this.secondsRadio.Size = new System.Drawing.Size(67, 17);
            this.secondsRadio.TabIndex = 8;
            this.secondsRadio.TabStop = true;
            this.secondsRadio.Text = "Seconds";
            this.secondsRadio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(11, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(226, 141);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 11;
            this.btnRes.Text = "Clear";
            this.btnRes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите дату (д.м.г)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(311, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.secondsRadio);
            this.Controls.Add(this.minutesRadio);
            this.Controls.Add(this.DayRadio);
            this.Controls.Add(this.MonthRadio);
            this.Controls.Add(this.YearRadio);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton YearRadio;
        private System.Windows.Forms.RadioButton MonthRadio;
        private System.Windows.Forms.RadioButton DayRadio;
        private System.Windows.Forms.RadioButton minutesRadio;
        private System.Windows.Forms.RadioButton secondsRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

