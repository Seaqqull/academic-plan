namespace AcademicPlan.UserControls
{
    partial class BorderedCell
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(25, 25);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(200, 100);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Your text here";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelText.MouseLeave += new System.EventHandler(this.labelText_MouseLeave);
            this.labelText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelText_MouseMove);
            // 
            // BorderedCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelText);
            this.Name = "BorderedCell";
            this.Size = new System.Drawing.Size(250, 150);
            this.SizeChanged += new System.EventHandler(this.BorderedCell_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderedCell_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelText;
    }
}
