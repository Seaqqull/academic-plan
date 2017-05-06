namespace AcademicPlan
{
    partial class IlluminatedButton
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
            this.labelIlluminated = new System.Windows.Forms.Label();
            this.buttonIlluminated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIlluminated
            // 
            this.labelIlluminated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelIlluminated.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelIlluminated.Location = new System.Drawing.Point(0, 30);
            this.labelIlluminated.Name = "labelIlluminated";
            this.labelIlluminated.Size = new System.Drawing.Size(150, 5);
            this.labelIlluminated.TabIndex = 3;
            // 
            // buttonIlluminated
            // 
            this.buttonIlluminated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIlluminated.FlatAppearance.BorderSize = 0;
            this.buttonIlluminated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIlluminated.Location = new System.Drawing.Point(0, 0);
            this.buttonIlluminated.Name = "buttonIlluminated";
            this.buttonIlluminated.Size = new System.Drawing.Size(150, 30);
            this.buttonIlluminated.TabIndex = 4;
            this.buttonIlluminated.Text = "Title text here";
            this.buttonIlluminated.UseVisualStyleBackColor = true;
            // 
            // IlluminatedButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonIlluminated);
            this.Controls.Add(this.labelIlluminated);
            this.Name = "IlluminatedButton";
            this.Size = new System.Drawing.Size(150, 35);
            this.BackColorChanged += new System.EventHandler(this.IlluminatedButton_BackColorChanged);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label labelIlluminated;
        private System.Windows.Forms.Button buttonIlluminated;
    }
}
