
namespace Volga_IT
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
            this.ButtomStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ButtomStart
            // 
            this.ButtomStart.Location = new System.Drawing.Point(12, 64);
            this.ButtomStart.Name = "ButtomStart";
            this.ButtomStart.Size = new System.Drawing.Size(286, 43);
            this.ButtomStart.TabIndex = 0;
            this.ButtomStart.Text = "Выбрать файл";
            this.ButtomStart.UseVisualStyleBackColor = true;
            this.ButtomStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 158);
            this.Controls.Add(this.ButtomStart);
            this.Name = "Form1";
            this.Text = "Разедлитель на слова";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtomStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

