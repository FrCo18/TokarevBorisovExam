namespace exam
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.openSubjectBtn = new System.Windows.Forms.Button();
            this.openDaysShow = new System.Windows.Forms.Button();
            this.openMonthForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openSubjectBtn
            // 
            this.openSubjectBtn.Location = new System.Drawing.Point(43, 187);
            this.openSubjectBtn.Name = "openSubjectBtn";
            this.openSubjectBtn.Size = new System.Drawing.Size(170, 36);
            this.openSubjectBtn.TabIndex = 1;
            this.openSubjectBtn.Text = "Предметы";
            this.openSubjectBtn.UseVisualStyleBackColor = true;
            this.openSubjectBtn.Click += new System.EventHandler(this.openSubjectBtn_Click);
            // 
            // openDaysShow
            // 
            this.openDaysShow.Location = new System.Drawing.Point(43, 229);
            this.openDaysShow.Name = "openDaysShow";
            this.openDaysShow.Size = new System.Drawing.Size(170, 36);
            this.openDaysShow.TabIndex = 2;
            this.openDaysShow.Text = "Дни недели";
            this.openDaysShow.UseVisualStyleBackColor = true;
            this.openDaysShow.Click += new System.EventHandler(this.openDaysShow_Click);
            // 
            // openMonthForm
            // 
            this.openMonthForm.Location = new System.Drawing.Point(43, 271);
            this.openMonthForm.Name = "openMonthForm";
            this.openMonthForm.Size = new System.Drawing.Size(170, 36);
            this.openMonthForm.TabIndex = 3;
            this.openMonthForm.Text = "Расписание";
            this.openMonthForm.UseVisualStyleBackColor = true;
            this.openMonthForm.Click += new System.EventHandler(this.openMonthForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Главное меню";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "дезигн бай павел";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(256, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openMonthForm);
            this.Controls.Add(this.openDaysShow);
            this.Controls.Add(this.openSubjectBtn);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openSubjectBtn;
        private System.Windows.Forms.Button openDaysShow;
        private System.Windows.Forms.Button openMonthForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

