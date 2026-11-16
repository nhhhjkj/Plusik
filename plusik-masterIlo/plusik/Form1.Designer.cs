namespace plusik
{
    partial class plusik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plusik));
            this.random_number = new System.Windows.Forms.Label();
            this.сбросить = new System.Windows.Forms.Button();
            this.mulptiply = new System.Windows.Forms.Button();
            this.random_number_button = new System.Windows.Forms.Button();
            this.your_number = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // random_number
            // 
            this.random_number.AutoSize = true;
            this.random_number.BackColor = System.Drawing.Color.LightCoral;
            this.random_number.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_number.ForeColor = System.Drawing.SystemColors.Window;
            this.random_number.Location = new System.Drawing.Point(215, 55);
            this.random_number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.random_number.Name = "random_number";
            this.random_number.Size = new System.Drawing.Size(158, 23);
            this.random_number.TabIndex = 2;
            this.random_number.Text = "Загаданное число";
            this.random_number.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.random_number.Click += new System.EventHandler(this.random_number_Click);
            // 
            // сбросить
            // 
            this.сбросить.BackColor = System.Drawing.Color.LightCoral;
            this.сбросить.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.сбросить.ForeColor = System.Drawing.SystemColors.Window;
            this.сбросить.Location = new System.Drawing.Point(53, 244);
            this.сбросить.Margin = new System.Windows.Forms.Padding(2);
            this.сбросить.Name = "сбросить";
            this.сбросить.Size = new System.Drawing.Size(167, 62);
            this.сбросить.TabIndex = 3;
            this.сбросить.Text = "Сбросить";
            this.сбросить.UseVisualStyleBackColor = false;
            this.сбросить.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // mulptiply
            // 
            this.mulptiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mulptiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mulptiply.BackgroundImage")));
            this.mulptiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mulptiply.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mulptiply.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulptiply.Location = new System.Drawing.Point(395, 55);
            this.mulptiply.Margin = new System.Windows.Forms.Padding(2);
            this.mulptiply.Name = "mulptiply";
            this.mulptiply.Size = new System.Drawing.Size(137, 136);
            this.mulptiply.TabIndex = 0;
            this.mulptiply.UseVisualStyleBackColor = false;
            this.mulptiply.Click += new System.EventHandler(this.mulptiply_Click_1);
            // 
            // random_number_button
            // 
            this.random_number_button.BackColor = System.Drawing.Color.LightCoral;
            this.random_number_button.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_number_button.ForeColor = System.Drawing.SystemColors.Window;
            this.random_number_button.Location = new System.Drawing.Point(365, 244);
            this.random_number_button.Margin = new System.Windows.Forms.Padding(2);
            this.random_number_button.Name = "random_number_button";
            this.random_number_button.Size = new System.Drawing.Size(167, 62);
            this.random_number_button.TabIndex = 3;
            this.random_number_button.Text = "Случайное число\r\n";
            this.random_number_button.UseVisualStyleBackColor = false;
            this.random_number_button.Click += new System.EventHandler(this.random_number_button_Click_1);
            // 
            // your_number
            // 
            this.your_number.AutoSize = true;
            this.your_number.BackColor = System.Drawing.Color.LightCoral;
            this.your_number.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.your_number.ForeColor = System.Drawing.SystemColors.Window;
            this.your_number.Location = new System.Drawing.Point(215, 112);
            this.your_number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.your_number.Name = "your_number";
            this.your_number.Size = new System.Drawing.Size(102, 23);
            this.your_number.TabIndex = 2;
            this.your_number.Text = "Твое число\r\n";
            this.your_number.Click += new System.EventHandler(this.your_number_Click);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.BackColor = System.Drawing.Color.LightCoral;
            this.step.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step.ForeColor = System.Drawing.SystemColors.Window;
            this.step.Location = new System.Drawing.Point(215, 168);
            this.step.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(45, 23);
            this.step.TabIndex = 2;
            this.step.Text = "Шаг";
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Red;
            this.plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus.BackgroundImage")));
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.Window;
            this.plus.Location = new System.Drawing.Point(53, 55);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(150, 150);
            this.plus.TabIndex = 0;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click_1);
            // 
            // plusik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.random_number_button);
            this.Controls.Add(this.сбросить);
            this.Controls.Add(this.step);
            this.Controls.Add(this.your_number);
            this.Controls.Add(this.random_number);
            this.Controls.Add(this.mulptiply);
            this.Controls.Add(this.plus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "plusik";
            this.Text = "plusik";
            this.Load += new System.EventHandler(this.plusik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label random_number;
        private System.Windows.Forms.Button сбросить;
        private System.Windows.Forms.Button mulptiply;
        private System.Windows.Forms.Button random_number_button;
        private System.Windows.Forms.Label your_number;
        private System.Windows.Forms.Label step;
    }
}

