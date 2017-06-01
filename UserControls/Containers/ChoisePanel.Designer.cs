namespace AcademicPlan.UserControls
{
    partial class ChoisePanel
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoisePanel));
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.imgs = new System.Windows.Forms.ImageList(this.components);
            this.ElementImages = new System.Windows.Forms.ImageList(this.components);
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanel
            // 
            this.FlowPanel.BackColor = System.Drawing.Color.White;
            this.FlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowPanel.Controls.Add(this.AddButton);
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(247, 191);
            this.FlowPanel.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(22, 22);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs.Images.SetKeyName(0, "circlePurple.png");
            this.imgs.Images.SetKeyName(1, "circleRed.png");
            this.imgs.Images.SetKeyName(2, "circleOrange.png");
            this.imgs.Images.SetKeyName(3, "circleGreen.png");
            // 
            // ElementImages
            // 
            this.ElementImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ElementImages.ImageSize = new System.Drawing.Size(10, 10);
            this.ElementImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ChoisePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Name = "ChoisePanel";
            this.Size = new System.Drawing.Size(247, 191);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.ImageList imgs;
        private System.Windows.Forms.ImageList ElementImages;



    }
}
