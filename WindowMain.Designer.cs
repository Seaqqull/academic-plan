namespace AcademicPlan
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.panelSelectWindow = new System.Windows.Forms.Panel();
            this.panelCurrentWindow = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borderedCell5 = new AcademicPlan.BorderedCell();
            this.borderedCell6 = new AcademicPlan.BorderedCell();
            this.borderedCell3 = new AcademicPlan.BorderedCell();
            this.borderedCell4 = new AcademicPlan.BorderedCell();
            this.borderedCell2 = new AcademicPlan.BorderedCell();
            this.borderedCell1 = new AcademicPlan.BorderedCell();
            this.Schedule1 = new AcademicPlan.IlluminatedButton();
            this.Schedule = new AcademicPlan.IlluminatedButton();
            this.panelSelectWindow.SuspendLayout();
            this.panelCurrentWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelectWindow
            // 
            this.panelSelectWindow.Controls.Add(this.Schedule1);
            this.panelSelectWindow.Controls.Add(this.Schedule);
            this.panelSelectWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectWindow.Location = new System.Drawing.Point(20, 60);
            this.panelSelectWindow.Name = "panelSelectWindow";
            this.panelSelectWindow.Size = new System.Drawing.Size(960, 30);
            this.panelSelectWindow.TabIndex = 3;
            // 
            // panelCurrentWindow
            // 
            this.panelCurrentWindow.Controls.Add(this.borderedCell5);
            this.panelCurrentWindow.Controls.Add(this.borderedCell6);
            this.panelCurrentWindow.Controls.Add(this.borderedCell3);
            this.panelCurrentWindow.Controls.Add(this.borderedCell4);
            this.panelCurrentWindow.Controls.Add(this.borderedCell2);
            this.panelCurrentWindow.Controls.Add(this.borderedCell1);
            this.panelCurrentWindow.Controls.Add(this.dataGridView1);
            this.panelCurrentWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentWindow.Location = new System.Drawing.Point(20, 90);
            this.panelCurrentWindow.Name = "panelCurrentWindow";
            this.panelCurrentWindow.Size = new System.Drawing.Size(960, 490);
            this.panelCurrentWindow.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // borderedCell5
            // 
            this.borderedCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.borderedCell5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell5.BorderSize = 1;
            this.borderedCell5.CursorLabel = System.Windows.Forms.Cursors.Hand;
            this.borderedCell5.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell5.FontColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell5.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderedCell5.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell5.ForeColor = System.Drawing.Color.Black;
            this.borderedCell5.IsBottomBorder = true;
            this.borderedCell5.IsLeftBorder = false;
            this.borderedCell5.IsRightBorder = true;
            this.borderedCell5.IsTopBorder = true;
            this.borderedCell5.LabelText = "Решить";
            this.borderedCell5.LabelTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderedCell5.Location = new System.Drawing.Point(758, 394);
            this.borderedCell5.Name = "borderedCell5";
            this.borderedCell5.Size = new System.Drawing.Size(202, 25);
            this.borderedCell5.TabIndex = 6;
            // 
            // borderedCell6
            // 
            this.borderedCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.borderedCell6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell6.BorderSize = 1;
            this.borderedCell6.CursorLabel = System.Windows.Forms.Cursors.Default;
            this.borderedCell6.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell6.FontColorHover = System.Drawing.Color.Black;
            this.borderedCell6.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderedCell6.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell6.ForeColor = System.Drawing.Color.Black;
            this.borderedCell6.IsBottomBorder = true;
            this.borderedCell6.IsLeftBorder = true;
            this.borderedCell6.IsRightBorder = true;
            this.borderedCell6.IsTopBorder = true;
            this.borderedCell6.LabelText = "Ошибка авторизации";
            this.borderedCell6.LabelTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borderedCell6.Location = new System.Drawing.Point(0, 394);
            this.borderedCell6.Name = "borderedCell6";
            this.borderedCell6.Size = new System.Drawing.Size(758, 25);
            this.borderedCell6.TabIndex = 5;
            // 
            // borderedCell3
            // 
            this.borderedCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.borderedCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell3.BorderSize = 1;
            this.borderedCell3.CursorLabel = System.Windows.Forms.Cursors.Hand;
            this.borderedCell3.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell3.FontColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell3.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderedCell3.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell3.ForeColor = System.Drawing.Color.Black;
            this.borderedCell3.IsBottomBorder = true;
            this.borderedCell3.IsLeftBorder = false;
            this.borderedCell3.IsRightBorder = true;
            this.borderedCell3.IsTopBorder = false;
            this.borderedCell3.LabelText = "Решить";
            this.borderedCell3.LabelTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderedCell3.Location = new System.Drawing.Point(758, 372);
            this.borderedCell3.Name = "borderedCell3";
            this.borderedCell3.Size = new System.Drawing.Size(202, 25);
            this.borderedCell3.TabIndex = 4;
            // 
            // borderedCell4
            // 
            this.borderedCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.borderedCell4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell4.BorderSize = 1;
            this.borderedCell4.CursorLabel = System.Windows.Forms.Cursors.Default;
            this.borderedCell4.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell4.FontColorHover = System.Drawing.Color.Black;
            this.borderedCell4.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderedCell4.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell4.ForeColor = System.Drawing.Color.Black;
            this.borderedCell4.IsBottomBorder = true;
            this.borderedCell4.IsLeftBorder = true;
            this.borderedCell4.IsRightBorder = true;
            this.borderedCell4.IsTopBorder = false;
            this.borderedCell4.LabelText = "Отсутствует файл по умолчанию";
            this.borderedCell4.LabelTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borderedCell4.Location = new System.Drawing.Point(0, 372);
            this.borderedCell4.Name = "borderedCell4";
            this.borderedCell4.Size = new System.Drawing.Size(758, 25);
            this.borderedCell4.TabIndex = 3;
            // 
            // borderedCell2
            // 
            this.borderedCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.borderedCell2.BorderSize = 0;
            this.borderedCell2.CursorLabel = System.Windows.Forms.Cursors.Default;
            this.borderedCell2.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell2.FontColorHover = System.Drawing.Color.Black;
            this.borderedCell2.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell2.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell2.ForeColor = System.Drawing.Color.Black;
            this.borderedCell2.IsBottomBorder = true;
            this.borderedCell2.IsLeftBorder = false;
            this.borderedCell2.IsRightBorder = true;
            this.borderedCell2.IsTopBorder = true;
            this.borderedCell2.LabelText = "";
            this.borderedCell2.LabelTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderedCell2.Location = new System.Drawing.Point(758, 340);
            this.borderedCell2.Name = "borderedCell2";
            this.borderedCell2.Size = new System.Drawing.Size(202, 35);
            this.borderedCell2.TabIndex = 2;
            // 
            // borderedCell1
            // 
            this.borderedCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.borderedCell1.BorderSize = 0;
            this.borderedCell1.CursorLabel = System.Windows.Forms.Cursors.Default;
            this.borderedCell1.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCell1.FontColorHover = System.Drawing.Color.Black;
            this.borderedCell1.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell1.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCell1.ForeColor = System.Drawing.Color.Black;
            this.borderedCell1.IsBottomBorder = true;
            this.borderedCell1.IsLeftBorder = true;
            this.borderedCell1.IsRightBorder = true;
            this.borderedCell1.IsTopBorder = true;
            this.borderedCell1.LabelText = "Название ошибки";
            this.borderedCell1.LabelTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderedCell1.Location = new System.Drawing.Point(0, 340);
            this.borderedCell1.Name = "borderedCell1";
            this.borderedCell1.Size = new System.Drawing.Size(758, 35);
            this.borderedCell1.TabIndex = 1;
            // 
            // Schedule1
            // 
            this.Schedule1.ColorButtonSelected = System.Drawing.Color.White;
            this.Schedule1.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Schedule1.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.Schedule1.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.Schedule1.CurrentGroup = 2;
            this.Schedule1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Schedule1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Schedule1.IsSelected = false;
            this.Schedule1.Location = new System.Drawing.Point(150, 0);
            this.Schedule1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Schedule1.MouseDownBackColor = System.Drawing.Color.Empty;
            this.Schedule1.MouseOverBackColor = System.Drawing.Color.Empty;
            this.Schedule1.Name = "Schedule1";
            this.Schedule1.Size = new System.Drawing.Size(150, 30);
            this.Schedule1.SizeUnderline = 5;
            this.Schedule1.TabIndex = 1;
            this.Schedule1.TextButton = "План";
            // 
            // Schedule
            // 
            this.Schedule.ColorButtonSelected = System.Drawing.Color.White;
            this.Schedule.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Schedule.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.Schedule.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.Schedule.CurrentGroup = 2;
            this.Schedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.Schedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Schedule.IsSelected = false;
            this.Schedule.Location = new System.Drawing.Point(0, 0);
            this.Schedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Schedule.MouseDownBackColor = System.Drawing.Color.Empty;
            this.Schedule.MouseOverBackColor = System.Drawing.Color.Empty;
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(150, 30);
            this.Schedule.SizeUnderline = 5;
            this.Schedule.TabIndex = 0;
            this.Schedule.TextButton = "График";
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelCurrentWindow);
            this.Controls.Add(this.panelSelectWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Учебный план";
            this.panelSelectWindow.ResumeLayout(false);
            this.panelCurrentWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSelectWindow;
        private System.Windows.Forms.Panel panelCurrentWindow;
        private IlluminatedButton Schedule;
        private IlluminatedButton Schedule1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BorderedCell borderedCell1;
        private BorderedCell borderedCell2;
        private BorderedCell borderedCell5;
        private BorderedCell borderedCell6;
        private BorderedCell borderedCell3;
        private BorderedCell borderedCell4;
    }
}

