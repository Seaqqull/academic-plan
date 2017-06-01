namespace AcademicPlan.UserControls
{
    partial class WindowTabControlBase
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
            this.panelUpper = new MetroFramework.Controls.MetroPanel();
            this.panelBottom = new MetroFramework.Controls.MetroPanel();
            this.panelRight = new MetroFramework.Controls.MetroPanel();
            this.panelCenter = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.Transparent;
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.HorizontalScrollbarBarColor = true;
            this.panelUpper.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUpper.HorizontalScrollbarSize = 10;
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1160, 24);
            this.panelUpper.TabIndex = 0;
            this.panelUpper.VerticalScrollbarBarColor = true;
            this.panelUpper.VerticalScrollbarHighlightOnWheel = false;
            this.panelUpper.VerticalScrollbarSize = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.HorizontalScrollbarBarColor = true;
            this.panelBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBottom.HorizontalScrollbarSize = 10;
            this.panelBottom.Location = new System.Drawing.Point(0, 566);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1160, 24);
            this.panelBottom.TabIndex = 3;
            this.panelBottom.VerticalScrollbarBarColor = true;
            this.panelBottom.VerticalScrollbarHighlightOnWheel = false;
            this.panelBottom.VerticalScrollbarSize = 10;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.HorizontalScrollbarBarColor = true;
            this.panelRight.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRight.HorizontalScrollbarSize = 10;
            this.panelRight.Location = new System.Drawing.Point(1136, 24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(24, 542);
            this.panelRight.TabIndex = 2;
            this.panelRight.VerticalScrollbarBarColor = true;
            this.panelRight.VerticalScrollbarHighlightOnWheel = false;
            this.panelRight.VerticalScrollbarSize = 10;
            // 
            // panelCenter
            // 
            this.panelCenter.AutoScroll = true;
            this.panelCenter.BackColor = System.Drawing.Color.Transparent;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.HorizontalScrollbar = true;
            this.panelCenter.HorizontalScrollbarBarColor = true;
            this.panelCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCenter.HorizontalScrollbarSize = 10;
            this.panelCenter.Location = new System.Drawing.Point(0, 24);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1136, 542);
            this.panelCenter.TabIndex = 1;
            this.panelCenter.VerticalScrollbar = true;
            this.panelCenter.VerticalScrollbarBarColor = true;
            this.panelCenter.VerticalScrollbarHighlightOnWheel = false;
            this.panelCenter.VerticalScrollbarSize = 10;
            // 
            // WindowTabControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelUpper);
            this.DoubleBuffered = true;
            this.Name = "WindowTabControlBase";
            this.Size = new System.Drawing.Size(1160, 590);
            this.ResumeLayout(false);

        }

        #endregion
        
        protected MetroFramework.Controls.MetroPanel panelUpper;
        protected MetroFramework.Controls.MetroPanel panelBottom;
        protected MetroFramework.Controls.MetroPanel panelRight;
        protected MetroFramework.Controls.MetroPanel panelCenter;
    }
}
