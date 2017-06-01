namespace AcademicPlan.UserControls
{
    partial class WindowTabControlDataBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lluminatedButtonDiscCycles = new AcademicPlan.UserControls.IlluminatedButton();
            this.metroPanelChoiseRed = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CyclesSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CyclesNameShort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CyclesGrid = new MetroFramework.Controls.MetroGrid();
            this.CyclesChange = new MetroFramework.Controls.MetroButton();
            this.CyclesNameLong = new MetroFramework.Controls.MetroTextBox();
            this.CyclesDelete = new MetroFramework.Controls.MetroButton();
            this.CyclesAdd = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiscSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DiscGrid = new MetroFramework.Controls.MetroGrid();
            this.DiscChange = new MetroFramework.Controls.MetroButton();
            this.DiscNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DiscDelete = new MetroFramework.Controls.MetroButton();
            this.DiscAdd = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.меню1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanelDiscCycles = new MetroFramework.Controls.MetroPanel();
            this.panelUpper.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.metroPanelChoiseRed.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.metroPanelDiscCycles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.menuStrip1);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.metroPanelDiscCycles);
            this.panelCenter.Controls.Add(this.metroPanelChoiseRed);
            // 
            // lluminatedButtonDiscCycles
            // 
            this.lluminatedButtonDiscCycles.BackColor = System.Drawing.Color.White;
            this.lluminatedButtonDiscCycles.ColorButtonSelected = System.Drawing.Color.White;
            this.lluminatedButtonDiscCycles.ColorLabelSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lluminatedButtonDiscCycles.ColorLabelUnselected = System.Drawing.Color.White;
            this.lluminatedButtonDiscCycles.CurrentButtonStyle = System.Windows.Forms.DockStyle.Left;
            this.lluminatedButtonDiscCycles.CurrentGroup = 2;
            this.lluminatedButtonDiscCycles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lluminatedButtonDiscCycles.IsSelected = false;
            this.lluminatedButtonDiscCycles.Location = new System.Drawing.Point(0, 0);
            this.lluminatedButtonDiscCycles.MouseDownBackColor = System.Drawing.Color.Empty;
            this.lluminatedButtonDiscCycles.MouseOverBackColor = System.Drawing.Color.Empty;
            this.lluminatedButtonDiscCycles.Name = "lluminatedButtonDiscCycles";
            this.lluminatedButtonDiscCycles.Size = new System.Drawing.Size(155, 35);
            this.lluminatedButtonDiscCycles.SizeUnderline = 5;
            this.lluminatedButtonDiscCycles.TabIndex = 2;
            this.lluminatedButtonDiscCycles.TextButton = "Дисциплины/Циклы";
            this.lluminatedButtonDiscCycles.OnUserControlButtonClicked += new AcademicPlan.UserControls.IlluminatedButton.ButtonClickedEventHandler(this.lluminatedButtonDiscCycles_Click);
            // 
            // metroPanelChoiseRed
            // 
            this.metroPanelChoiseRed.BackColor = System.Drawing.Color.White;
            this.metroPanelChoiseRed.Controls.Add(this.lluminatedButtonDiscCycles);
            this.metroPanelChoiseRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelChoiseRed.HorizontalScrollbarBarColor = true;
            this.metroPanelChoiseRed.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelChoiseRed.HorizontalScrollbarSize = 10;
            this.metroPanelChoiseRed.Location = new System.Drawing.Point(0, 0);
            this.metroPanelChoiseRed.Name = "metroPanelChoiseRed";
            this.metroPanelChoiseRed.Size = new System.Drawing.Size(155, 542);
            this.metroPanelChoiseRed.TabIndex = 5;
            this.metroPanelChoiseRed.VerticalScrollbarBarColor = true;
            this.metroPanelChoiseRed.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelChoiseRed.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CyclesSave);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.CyclesNameShort);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.CyclesGrid);
            this.groupBox2.Controls.Add(this.CyclesChange);
            this.groupBox2.Controls.Add(this.CyclesNameLong);
            this.groupBox2.Controls.Add(this.CyclesDelete);
            this.groupBox2.Controls.Add(this.CyclesAdd);
            this.groupBox2.Location = new System.Drawing.Point(364, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 302);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Циклы";
            // 
            // CyclesSave
            // 
            this.CyclesSave.Location = new System.Drawing.Point(297, 83);
            this.CyclesSave.Name = "CyclesSave";
            this.CyclesSave.Size = new System.Drawing.Size(70, 23);
            this.CyclesSave.TabIndex = 11;
            this.CyclesSave.Text = "Сохранить";
            this.CyclesSave.UseSelectable = true;
            this.CyclesSave.Click += new System.EventHandler(this.CyclesSave_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(6, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 23);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Наименование краткое";
            // 
            // CyclesNameShort
            // 
            // 
            // 
            // 
            this.CyclesNameShort.CustomButton.Image = null;
            this.CyclesNameShort.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.CyclesNameShort.CustomButton.Name = "";
            this.CyclesNameShort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CyclesNameShort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CyclesNameShort.CustomButton.TabIndex = 1;
            this.CyclesNameShort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CyclesNameShort.CustomButton.UseSelectable = true;
            this.CyclesNameShort.CustomButton.Visible = false;
            this.CyclesNameShort.Lines = new string[0];
            this.CyclesNameShort.Location = new System.Drawing.Point(174, 25);
            this.CyclesNameShort.MaxLength = 32767;
            this.CyclesNameShort.Name = "CyclesNameShort";
            this.CyclesNameShort.PasswordChar = '\0';
            this.CyclesNameShort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CyclesNameShort.SelectedText = "";
            this.CyclesNameShort.SelectionLength = 0;
            this.CyclesNameShort.SelectionStart = 0;
            this.CyclesNameShort.ShortcutsEnabled = true;
            this.CyclesNameShort.Size = new System.Drawing.Size(272, 23);
            this.CyclesNameShort.TabIndex = 10;
            this.CyclesNameShort.UseSelectable = true;
            this.CyclesNameShort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CyclesNameShort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(6, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 23);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Наименование";
            // 
            // CyclesGrid
            // 
            this.CyclesGrid.AllowUserToAddRows = false;
            this.CyclesGrid.AllowUserToDeleteRows = false;
            this.CyclesGrid.AllowUserToResizeRows = false;
            this.CyclesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CyclesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CyclesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CyclesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CyclesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CyclesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CyclesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CyclesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CyclesGrid.EnableHeadersVisualStyles = false;
            this.CyclesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CyclesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CyclesGrid.Location = new System.Drawing.Point(6, 129);
            this.CyclesGrid.MultiSelect = false;
            this.CyclesGrid.Name = "CyclesGrid";
            this.CyclesGrid.ReadOnly = true;
            this.CyclesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CyclesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CyclesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CyclesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CyclesGrid.Size = new System.Drawing.Size(599, 167);
            this.CyclesGrid.TabIndex = 2;
            this.CyclesGrid.SelectionChanged += new System.EventHandler(this.CyclesGrid_SelectionChanged);
            // 
            // CyclesChange
            // 
            this.CyclesChange.Location = new System.Drawing.Point(455, 83);
            this.CyclesChange.Name = "CyclesChange";
            this.CyclesChange.Size = new System.Drawing.Size(70, 23);
            this.CyclesChange.TabIndex = 3;
            this.CyclesChange.Text = "Изменить";
            this.CyclesChange.UseSelectable = true;
            this.CyclesChange.Click += new System.EventHandler(this.CyclesChange_Click);
            // 
            // CyclesNameLong
            // 
            // 
            // 
            // 
            this.CyclesNameLong.CustomButton.Image = null;
            this.CyclesNameLong.CustomButton.Location = new System.Drawing.Point(409, 1);
            this.CyclesNameLong.CustomButton.Name = "";
            this.CyclesNameLong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CyclesNameLong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CyclesNameLong.CustomButton.TabIndex = 1;
            this.CyclesNameLong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CyclesNameLong.CustomButton.UseSelectable = true;
            this.CyclesNameLong.CustomButton.Visible = false;
            this.CyclesNameLong.Lines = new string[0];
            this.CyclesNameLong.Location = new System.Drawing.Point(174, 54);
            this.CyclesNameLong.MaxLength = 32767;
            this.CyclesNameLong.Name = "CyclesNameLong";
            this.CyclesNameLong.PasswordChar = '\0';
            this.CyclesNameLong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CyclesNameLong.SelectedText = "";
            this.CyclesNameLong.SelectionLength = 0;
            this.CyclesNameLong.SelectionStart = 0;
            this.CyclesNameLong.ShortcutsEnabled = true;
            this.CyclesNameLong.Size = new System.Drawing.Size(431, 23);
            this.CyclesNameLong.TabIndex = 8;
            this.CyclesNameLong.UseSelectable = true;
            this.CyclesNameLong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CyclesNameLong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CyclesDelete
            // 
            this.CyclesDelete.Location = new System.Drawing.Point(535, 83);
            this.CyclesDelete.Name = "CyclesDelete";
            this.CyclesDelete.Size = new System.Drawing.Size(70, 23);
            this.CyclesDelete.TabIndex = 4;
            this.CyclesDelete.Text = "Удалить";
            this.CyclesDelete.UseSelectable = true;
            this.CyclesDelete.Click += new System.EventHandler(this.CyclesDelete_Click);
            // 
            // CyclesAdd
            // 
            this.CyclesAdd.Location = new System.Drawing.Point(376, 83);
            this.CyclesAdd.Name = "CyclesAdd";
            this.CyclesAdd.Size = new System.Drawing.Size(70, 23);
            this.CyclesAdd.TabIndex = 5;
            this.CyclesAdd.Text = "Добавить";
            this.CyclesAdd.UseSelectable = true;
            this.CyclesAdd.Click += new System.EventHandler(this.CyclesAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiscSave);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.DiscGrid);
            this.groupBox1.Controls.Add(this.DiscChange);
            this.groupBox1.Controls.Add(this.DiscNameTextBox);
            this.groupBox1.Controls.Add(this.DiscDelete);
            this.groupBox1.Controls.Add(this.DiscAdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дисциплины";
            // 
            // DiscSave
            // 
            this.DiscSave.Location = new System.Drawing.Point(28, 83);
            this.DiscSave.Name = "DiscSave";
            this.DiscSave.Size = new System.Drawing.Size(70, 23);
            this.DiscSave.TabIndex = 9;
            this.DiscSave.Text = "Сохранить";
            this.DiscSave.UseSelectable = true;
            this.DiscSave.Click += new System.EventHandler(this.DiscSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(6, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 23);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Наименование";
            // 
            // DiscGrid
            // 
            this.DiscGrid.AllowUserToAddRows = false;
            this.DiscGrid.AllowUserToDeleteRows = false;
            this.DiscGrid.AllowUserToResizeRows = false;
            this.DiscGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DiscGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DiscGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DiscGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiscGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DiscGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiscGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiscGrid.EnableHeadersVisualStyles = false;
            this.DiscGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DiscGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DiscGrid.Location = new System.Drawing.Point(6, 129);
            this.DiscGrid.MultiSelect = false;
            this.DiscGrid.Name = "DiscGrid";
            this.DiscGrid.ReadOnly = true;
            this.DiscGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiscGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DiscGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DiscGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiscGrid.Size = new System.Drawing.Size(340, 167);
            this.DiscGrid.TabIndex = 2;
            this.DiscGrid.SelectionChanged += new System.EventHandler(this.DiscGrid_SelectionChanged);
            // 
            // DiscChange
            // 
            this.DiscChange.Location = new System.Drawing.Point(186, 83);
            this.DiscChange.Name = "DiscChange";
            this.DiscChange.Size = new System.Drawing.Size(70, 23);
            this.DiscChange.TabIndex = 3;
            this.DiscChange.Text = "Изменить";
            this.DiscChange.UseSelectable = true;
            this.DiscChange.Click += new System.EventHandler(this.DiscChange_Click);
            // 
            // DiscNameTextBox
            // 
            // 
            // 
            // 
            this.DiscNameTextBox.CustomButton.Image = null;
            this.DiscNameTextBox.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.DiscNameTextBox.CustomButton.Name = "";
            this.DiscNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DiscNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiscNameTextBox.CustomButton.TabIndex = 1;
            this.DiscNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiscNameTextBox.CustomButton.UseSelectable = true;
            this.DiscNameTextBox.CustomButton.Visible = false;
            this.DiscNameTextBox.Lines = new string[0];
            this.DiscNameTextBox.Location = new System.Drawing.Point(128, 25);
            this.DiscNameTextBox.MaxLength = 32767;
            this.DiscNameTextBox.Name = "DiscNameTextBox";
            this.DiscNameTextBox.PasswordChar = '\0';
            this.DiscNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DiscNameTextBox.SelectedText = "";
            this.DiscNameTextBox.SelectionLength = 0;
            this.DiscNameTextBox.SelectionStart = 0;
            this.DiscNameTextBox.ShortcutsEnabled = true;
            this.DiscNameTextBox.Size = new System.Drawing.Size(208, 23);
            this.DiscNameTextBox.TabIndex = 8;
            this.DiscNameTextBox.UseSelectable = true;
            this.DiscNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DiscNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DiscDelete
            // 
            this.DiscDelete.Location = new System.Drawing.Point(266, 83);
            this.DiscDelete.Name = "DiscDelete";
            this.DiscDelete.Size = new System.Drawing.Size(70, 23);
            this.DiscDelete.TabIndex = 4;
            this.DiscDelete.Text = "Удалить";
            this.DiscDelete.UseSelectable = true;
            this.DiscDelete.Click += new System.EventHandler(this.DiscDelete_Click);
            // 
            // DiscAdd
            // 
            this.DiscAdd.Location = new System.Drawing.Point(107, 83);
            this.DiscAdd.Name = "DiscAdd";
            this.DiscAdd.Size = new System.Drawing.Size(70, 23);
            this.DiscAdd.TabIndex = 5;
            this.DiscAdd.Text = "Добавить";
            this.DiscAdd.UseSelectable = true;
            this.DiscAdd.Click += new System.EventHandler(this.DiscAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.меню1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // меню1ToolStripMenuItem
            // 
            this.меню1ToolStripMenuItem.Name = "меню1ToolStripMenuItem";
            this.меню1ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.меню1ToolStripMenuItem.Text = "Меню_1";
            // 
            // metroPanelDiscCycles
            // 
            this.metroPanelDiscCycles.Controls.Add(this.groupBox2);
            this.metroPanelDiscCycles.Controls.Add(this.groupBox1);
            this.metroPanelDiscCycles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelDiscCycles.HorizontalScrollbarBarColor = true;
            this.metroPanelDiscCycles.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDiscCycles.HorizontalScrollbarSize = 10;
            this.metroPanelDiscCycles.Location = new System.Drawing.Point(155, 0);
            this.metroPanelDiscCycles.Name = "metroPanelDiscCycles";
            this.metroPanelDiscCycles.Size = new System.Drawing.Size(981, 542);
            this.metroPanelDiscCycles.TabIndex = 11;
            this.metroPanelDiscCycles.VerticalScrollbarBarColor = true;
            this.metroPanelDiscCycles.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDiscCycles.VerticalScrollbarSize = 10;
            this.metroPanelDiscCycles.Visible = false;
            // 
            // WindowTabControlDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "WindowTabControlDataBase";
            this.Load += new System.EventHandler(this.WindowTabControlDataBase_Load);
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.metroPanelChoiseRed.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CyclesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanelDiscCycles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IlluminatedButton lluminatedButtonDiscCycles;
        private MetroFramework.Controls.MetroPanel metroPanelChoiseRed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem меню1ToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox DiscNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton DiscAdd;
        private MetroFramework.Controls.MetroButton DiscDelete;
        private MetroFramework.Controls.MetroButton DiscChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox CyclesNameShort;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton CyclesChange;
        private MetroFramework.Controls.MetroTextBox CyclesNameLong;
        private MetroFramework.Controls.MetroButton CyclesDelete;
        private MetroFramework.Controls.MetroButton CyclesAdd;
        private MetroFramework.Controls.MetroPanel metroPanelDiscCycles;
        public MetroFramework.Controls.MetroGrid DiscGrid;
        public MetroFramework.Controls.MetroGrid CyclesGrid;
        public MetroFramework.Controls.MetroButton CyclesSave;
        public MetroFramework.Controls.MetroButton DiscSave;
    }
}
