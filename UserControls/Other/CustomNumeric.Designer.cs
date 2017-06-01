namespace AcademicPlan.UserControls
{
    partial class CustomNumeric
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNumValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxDown);
            this.panel1.Controls.Add(this.pictureBoxUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 62);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.BackColor = System.Drawing.Color.White;
            this.pictureBoxDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDown.Location = new System.Drawing.Point(0, 32);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxDown.TabIndex = 1;
            this.pictureBoxDown.TabStop = false;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.BackColor = System.Drawing.Color.White;
            this.pictureBoxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxUp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUp.TabIndex = 0;
            this.pictureBoxUp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNumValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 62);
            this.panel2.TabIndex = 1;
            // 
            // labelNumValue
            // 
            this.labelNumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumValue.Location = new System.Drawing.Point(0, 0);
            this.labelNumValue.Name = "labelNumValue";
            this.labelNumValue.Size = new System.Drawing.Size(120, 62);
            this.labelNumValue.TabIndex = 0;
            this.labelNumValue.Text = "label1";
            this.labelNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomNumeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomNumeric";
            this.Size = new System.Drawing.Size(152, 62);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomNumeric_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNumValue;
    }
}
