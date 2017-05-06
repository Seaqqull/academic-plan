namespace AcademicPlan
{
    partial class ArrowButton
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
            this.buttonArrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArrow
            // 
            this.buttonArrow.BackColor = System.Drawing.Color.Transparent;
            this.buttonArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonArrow.FlatAppearance.BorderSize = 0;
            this.buttonArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrow.Location = new System.Drawing.Point(0, 0);
            this.buttonArrow.Name = "buttonArrow";
            this.buttonArrow.Size = new System.Drawing.Size(120, 50);
            this.buttonArrow.TabIndex = 0;
            this.buttonArrow.UseVisualStyleBackColor = false;
            this.buttonArrow.Click += new System.EventHandler(this.buttonArrow_Click);
            // 
            // ArrowButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonArrow);
            this.Name = "ArrowButton";
            this.Size = new System.Drawing.Size(120, 50);
            this.BackColorChanged += new System.EventHandler(this.ArrowButton_BackColorChanged);
            this.Click += new System.EventHandler(this.buttonArrow_Click);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonArrow;
    }
}
