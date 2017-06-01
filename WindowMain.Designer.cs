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
            this.DataBaseEditing = new AcademicPlan.UserControls.IlluminatedButton();
            this.Reports = new AcademicPlan.UserControls.IlluminatedButton();
            this.EPlan = new AcademicPlan.UserControls.IlluminatedButton();
            this.Schedule = new AcademicPlan.UserControls.IlluminatedButton();
            this.panelSelectWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelectWindow
            // 
            this.panelSelectWindow.Controls.Add(this.DataBaseEditing);
            this.panelSelectWindow.Controls.Add(this.Reports);
            this.panelSelectWindow.Controls.Add(this.EPlan);
            this.panelSelectWindow.Controls.Add(this.Schedule);
            this.panelSelectWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectWindow.Location = new System.Drawing.Point(20, 60);
            this.panelSelectWindow.Name = "panelSelectWindow";
            this.panelSelectWindow.Size = new System.Drawing.Size(1160, 30);
            this.panelSelectWindow.TabIndex = 3;
            // 
            // panelCurrentWindow
            // 
            this.panelCurrentWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentWindow.Location = new System.Drawing.Point(20, 90);
            this.panelCurrentWindow.Name = "panelCurrentWindow";
            this.panelCurrentWindow.Size = new System.Drawing.Size(1160, 590);
            this.panelCurrentWindow.TabIndex = 4;
            // 
            // DataBaseEditing
            // 
            this.DataBaseEditing.ColorButtonSelected = System.Drawing.Color.White;
            this.DataBaseEditing.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DataBaseEditing.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.DataBaseEditing.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.DataBaseEditing.CurrentGroup = 1;
            this.DataBaseEditing.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataBaseEditing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataBaseEditing.IsSelected = false;
            this.DataBaseEditing.Location = new System.Drawing.Point(450, 0);
            this.DataBaseEditing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataBaseEditing.MouseDownBackColor = System.Drawing.Color.Empty;
            this.DataBaseEditing.MouseOverBackColor = System.Drawing.Color.Empty;
            this.DataBaseEditing.Name = "DataBaseEditing";
            this.DataBaseEditing.Size = new System.Drawing.Size(186, 30);
            this.DataBaseEditing.SizeUnderline = 5;
            this.DataBaseEditing.TabIndex = 3;
            this.DataBaseEditing.TextButton = "База данных";
            // 
            // Reports
            // 
            this.Reports.ColorButtonSelected = System.Drawing.Color.White;
            this.Reports.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Reports.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.Reports.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.Reports.CurrentGroup = 1;
            this.Reports.Dock = System.Windows.Forms.DockStyle.Left;
            this.Reports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reports.IsSelected = false;
            this.Reports.Location = new System.Drawing.Point(300, 0);
            this.Reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reports.MouseDownBackColor = System.Drawing.Color.Empty;
            this.Reports.MouseOverBackColor = System.Drawing.Color.Empty;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(150, 30);
            this.Reports.SizeUnderline = 5;
            this.Reports.TabIndex = 2;
            this.Reports.TextButton = "Отчёты";
            // 
            // EPlan
            // 
            this.EPlan.ColorButtonSelected = System.Drawing.Color.White;
            this.EPlan.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.EPlan.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.EPlan.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.EPlan.CurrentGroup = 1;
            this.EPlan.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EPlan.IsSelected = false;
            this.EPlan.Location = new System.Drawing.Point(150, 0);
            this.EPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EPlan.MouseDownBackColor = System.Drawing.Color.Empty;
            this.EPlan.MouseOverBackColor = System.Drawing.Color.Empty;
            this.EPlan.Name = "EPlan";
            this.EPlan.Size = new System.Drawing.Size(150, 30);
            this.EPlan.SizeUnderline = 5;
            this.EPlan.TabIndex = 1;
            this.EPlan.TextButton = "План";
            // 
            // Schedule
            // 
            this.Schedule.ColorButtonSelected = System.Drawing.Color.White;
            this.Schedule.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Schedule.ColorLabelUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.Schedule.CurrentButtonStyle = System.Windows.Forms.DockStyle.Bottom;
            this.Schedule.CurrentGroup = 1;
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
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelCurrentWindow);
            this.Controls.Add(this.panelSelectWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Учебный план";
            this.panelSelectWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSelectWindow;
        private System.Windows.Forms.Panel panelCurrentWindow;
        private AcademicPlan.UserControls.IlluminatedButton Schedule;
        private AcademicPlan.UserControls.IlluminatedButton EPlan;
        private UserControls.IlluminatedButton DataBaseEditing;
        private UserControls.IlluminatedButton Reports;
    }
}

