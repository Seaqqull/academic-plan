namespace AcademicPlan.UserControls
{
    partial class WindowTabControlEPlan
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveRedactedData = new System.Windows.Forms.ToolStripMenuItem();
            this.borderedCellInfoYearSemestr = new AcademicPlan.UserControls.BorderedCell();
            this.choisePanel = new AcademicPlan.UserControls.ChoisePanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAddSubject = new MetroFramework.Controls.MetroButton();
            this.metroPanelSubjectsData = new MetroFramework.Controls.MetroPanel();
            this.metroPanelDiscipline = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelCycles = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelNorm = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelAct = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelSm = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelLk = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelLz = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelPz = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelKKC = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelPercent = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanelDelete = new System.Windows.Forms.FlowLayoutPanel();
            this.SumKKSLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanelNewRedact = new MetroFramework.Controls.MetroPanel();
            this.ReturnToView = new AcademicPlan.UserControls.ArrowButton();
            this.metroPanelViewGrid = new MetroFramework.Controls.MetroPanel();
            this.EditSemesterFromGrid = new MetroFramework.Controls.MetroButton();
            this.ViewSemestrFromGrid = new MetroFramework.Controls.MetroButton();
            this.metroGridView = new MetroFramework.Controls.MetroGrid();
            this.metroPanelSubjectsInput = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.YearPicker = new MetroFramework.Controls.MetroComboBox();
            this.SemesterPicker = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelFilter = new MetroFramework.Controls.MetroPanel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.DepartmentPicker = new MetroFramework.Controls.MetroComboBox();
            this.panelUpper.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.metroPanelSubjectsData.SuspendLayout();
            this.metroPanelNewRedact.SuspendLayout();
            this.metroPanelViewGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridView)).BeginInit();
            this.metroPanelSubjectsInput.SuspendLayout();
            this.metroPanelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.White;
            this.panelUpper.Controls.Add(this.menuStrip1);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.metroPanelViewGrid);
            this.panelCenter.Controls.Add(this.metroPanelNewRedact);
            this.panelCenter.Controls.Add(this.metroPanelFilter);
            this.panelCenter.Controls.Add(this.metroPanelSubjectsInput);
            this.panelCenter.Style = MetroFramework.MetroColorStyle.Blue;
            this.panelCenter.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMode,
            this.ChangeMode,
            this.ViewMode,
            this.SaveRedactedData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewMode
            // 
            this.NewMode.Name = "NewMode";
            this.NewMode.Size = new System.Drawing.Size(54, 20);
            this.NewMode.Text = "Новое";
            this.NewMode.Click += new System.EventHandler(this.NewMode_Click);
            // 
            // ChangeMode
            // 
            this.ChangeMode.Name = "ChangeMode";
            this.ChangeMode.Size = new System.Drawing.Size(73, 20);
            this.ChangeMode.Text = "Изменить";
            this.ChangeMode.Visible = false;
            this.ChangeMode.Click += new System.EventHandler(this.ChangeMode_Click);
            // 
            // ViewMode
            // 
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(76, 20);
            this.ViewMode.Text = "Просмотр";
            this.ViewMode.Click += new System.EventHandler(this.ViewMode_Click);
            // 
            // SaveRedactedData
            // 
            this.SaveRedactedData.Name = "SaveRedactedData";
            this.SaveRedactedData.Size = new System.Drawing.Size(77, 20);
            this.SaveRedactedData.Text = "Сохранить";
            this.SaveRedactedData.Click += new System.EventHandler(this.SaveRedactedData_Click);
            // 
            // borderedCellInfoYearSemestr
            // 
            this.borderedCellInfoYearSemestr.BackColor = System.Drawing.Color.White;
            this.borderedCellInfoYearSemestr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.borderedCellInfoYearSemestr.BorderSize = 2;
            this.borderedCellInfoYearSemestr.CursorLabel = System.Windows.Forms.Cursors.Default;
            this.borderedCellInfoYearSemestr.FontColorDefault = System.Drawing.Color.Black;
            this.borderedCellInfoYearSemestr.FontColorHover = System.Drawing.Color.Black;
            this.borderedCellInfoYearSemestr.FontTextDefault = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCellInfoYearSemestr.FontTextHover = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderedCellInfoYearSemestr.IsBottomBorder = true;
            this.borderedCellInfoYearSemestr.IsLeftBorder = true;
            this.borderedCellInfoYearSemestr.IsRightBorder = true;
            this.borderedCellInfoYearSemestr.IsTopBorder = true;
            this.borderedCellInfoYearSemestr.LabelText = "Год: 2017. Семестр: 2. Кафедра: Информатики.";
            this.borderedCellInfoYearSemestr.LabelTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderedCellInfoYearSemestr.Location = new System.Drawing.Point(6, 6);
            this.borderedCellInfoYearSemestr.Name = "borderedCellInfoYearSemestr";
            this.borderedCellInfoYearSemestr.Size = new System.Drawing.Size(272, 28);
            this.borderedCellInfoYearSemestr.TabIndex = 6;
            // 
            // choisePanel
            // 
            this.choisePanel.BackColor = System.Drawing.Color.White;
            this.choisePanel.Location = new System.Drawing.Point(410, 6);
            this.choisePanel.Name = "choisePanel";
            this.choisePanel.Size = new System.Drawing.Size(456, 28);
            this.choisePanel.TabIndex = 7;
            this.choisePanel.Edit_Item += new System.EventHandler(this.choisePanel_Edit_Item);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Дисциплина";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(151, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Цикл";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(307, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Нормативная";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(407, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Активная";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(485, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Самостоятельная";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(612, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "ЛК";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(658, 13);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "ЛЗ";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(704, 13);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "ПЗ";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Location = new System.Drawing.Point(750, 13);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(38, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "ККС";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(796, 13);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Процент";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(870, 13);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Группа";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButtonAddSubject
            // 
            this.metroButtonAddSubject.BackColor = System.Drawing.Color.White;
            this.metroButtonAddSubject.Location = new System.Drawing.Point(284, 6);
            this.metroButtonAddSubject.Name = "metroButtonAddSubject";
            this.metroButtonAddSubject.Size = new System.Drawing.Size(120, 28);
            this.metroButtonAddSubject.Style = MetroFramework.MetroColorStyle.White;
            this.metroButtonAddSubject.TabIndex = 19;
            this.metroButtonAddSubject.Text = "Добавить предмет";
            this.metroButtonAddSubject.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonAddSubject.UseCustomBackColor = true;
            this.metroButtonAddSubject.UseCustomForeColor = true;
            this.metroButtonAddSubject.UseSelectable = true;
            this.metroButtonAddSubject.UseStyleColors = true;
            this.metroButtonAddSubject.Click += new System.EventHandler(this.metroButtonAddSubject_Click);
            // 
            // metroPanelSubjectsData
            // 
            this.metroPanelSubjectsData.AutoScroll = true;
            this.metroPanelSubjectsData.BackColor = System.Drawing.Color.White;
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelDiscipline);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelCycles);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelNorm);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelAct);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelSm);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelLk);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelLz);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelPz);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelKKC);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelPercent);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelGroup);
            this.metroPanelSubjectsData.Controls.Add(this.metroPanelDelete);
            this.metroPanelSubjectsData.HorizontalScrollbar = true;
            this.metroPanelSubjectsData.HorizontalScrollbarBarColor = true;
            this.metroPanelSubjectsData.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelSubjectsData.HorizontalScrollbarSize = 10;
            this.metroPanelSubjectsData.Location = new System.Drawing.Point(3, 35);
            this.metroPanelSubjectsData.Name = "metroPanelSubjectsData";
            this.metroPanelSubjectsData.Size = new System.Drawing.Size(994, 345);
            this.metroPanelSubjectsData.TabIndex = 20;
            this.metroPanelSubjectsData.VerticalScrollbar = true;
            this.metroPanelSubjectsData.VerticalScrollbarBarColor = true;
            this.metroPanelSubjectsData.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelSubjectsData.VerticalScrollbarSize = 10;
            // 
            // metroPanelDiscipline
            // 
            this.metroPanelDiscipline.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelDiscipline.Location = new System.Drawing.Point(0, 0);
            this.metroPanelDiscipline.Name = "metroPanelDiscipline";
            this.metroPanelDiscipline.Size = new System.Drawing.Size(142, 345);
            this.metroPanelDiscipline.TabIndex = 2;
            // 
            // metroPanelCycles
            // 
            this.metroPanelCycles.Location = new System.Drawing.Point(148, 0);
            this.metroPanelCycles.Name = "metroPanelCycles";
            this.metroPanelCycles.Size = new System.Drawing.Size(150, 345);
            this.metroPanelCycles.TabIndex = 3;
            // 
            // metroPanelNorm
            // 
            this.metroPanelNorm.Location = new System.Drawing.Point(304, 0);
            this.metroPanelNorm.Name = "metroPanelNorm";
            this.metroPanelNorm.Size = new System.Drawing.Size(94, 345);
            this.metroPanelNorm.TabIndex = 4;
            // 
            // metroPanelAct
            // 
            this.metroPanelAct.Location = new System.Drawing.Point(404, 0);
            this.metroPanelAct.Name = "metroPanelAct";
            this.metroPanelAct.Size = new System.Drawing.Size(72, 345);
            this.metroPanelAct.TabIndex = 5;
            // 
            // metroPanelSm
            // 
            this.metroPanelSm.Location = new System.Drawing.Point(482, 0);
            this.metroPanelSm.Name = "metroPanelSm";
            this.metroPanelSm.Size = new System.Drawing.Size(121, 345);
            this.metroPanelSm.TabIndex = 6;
            // 
            // metroPanelLk
            // 
            this.metroPanelLk.Location = new System.Drawing.Point(609, 0);
            this.metroPanelLk.Name = "metroPanelLk";
            this.metroPanelLk.Size = new System.Drawing.Size(40, 345);
            this.metroPanelLk.TabIndex = 7;
            // 
            // metroPanelLz
            // 
            this.metroPanelLz.Location = new System.Drawing.Point(655, 0);
            this.metroPanelLz.Name = "metroPanelLz";
            this.metroPanelLz.Size = new System.Drawing.Size(40, 345);
            this.metroPanelLz.TabIndex = 8;
            // 
            // metroPanelPz
            // 
            this.metroPanelPz.Location = new System.Drawing.Point(701, 0);
            this.metroPanelPz.Name = "metroPanelPz";
            this.metroPanelPz.Size = new System.Drawing.Size(40, 345);
            this.metroPanelPz.TabIndex = 9;
            // 
            // metroPanelKKC
            // 
            this.metroPanelKKC.Location = new System.Drawing.Point(747, 0);
            this.metroPanelKKC.Name = "metroPanelKKC";
            this.metroPanelKKC.Size = new System.Drawing.Size(40, 345);
            this.metroPanelKKC.TabIndex = 10;
            // 
            // metroPanelPercent
            // 
            this.metroPanelPercent.Location = new System.Drawing.Point(793, 0);
            this.metroPanelPercent.Name = "metroPanelPercent";
            this.metroPanelPercent.Size = new System.Drawing.Size(68, 345);
            this.metroPanelPercent.TabIndex = 11;
            // 
            // metroPanelGroup
            // 
            this.metroPanelGroup.Location = new System.Drawing.Point(867, 0);
            this.metroPanelGroup.Name = "metroPanelGroup";
            this.metroPanelGroup.Size = new System.Drawing.Size(58, 345);
            this.metroPanelGroup.TabIndex = 12;
            // 
            // metroPanelDelete
            // 
            this.metroPanelDelete.Location = new System.Drawing.Point(931, 0);
            this.metroPanelDelete.Name = "metroPanelDelete";
            this.metroPanelDelete.Size = new System.Drawing.Size(40, 345);
            this.metroPanelDelete.TabIndex = 13;
            // 
            // SumKKSLabel
            // 
            this.SumKKSLabel.BackColor = System.Drawing.Color.White;
            this.SumKKSLabel.Location = new System.Drawing.Point(872, 6);
            this.SumKKSLabel.Name = "SumKKSLabel";
            this.SumKKSLabel.Size = new System.Drawing.Size(199, 28);
            this.SumKKSLabel.TabIndex = 21;
            this.SumKKSLabel.Text = "Сумма кредитов";
            this.SumKKSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumKKSLabel.UseCustomBackColor = true;
            this.SumKKSLabel.UseCustomForeColor = true;
            // 
            // metroPanelNewRedact
            // 
            this.metroPanelNewRedact.BackColor = System.Drawing.Color.White;
            this.metroPanelNewRedact.Controls.Add(this.metroPanelSubjectsData);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel1);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel2);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel3);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel11);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel4);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel10);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel5);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel9);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel6);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel8);
            this.metroPanelNewRedact.Controls.Add(this.metroLabel7);
            this.metroPanelNewRedact.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelNewRedact.HorizontalScrollbarBarColor = true;
            this.metroPanelNewRedact.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelNewRedact.HorizontalScrollbarSize = 10;
            this.metroPanelNewRedact.Location = new System.Drawing.Point(0, 72);
            this.metroPanelNewRedact.Name = "metroPanelNewRedact";
            this.metroPanelNewRedact.Size = new System.Drawing.Size(1119, 390);
            this.metroPanelNewRedact.TabIndex = 22;
            this.metroPanelNewRedact.VerticalScrollbarBarColor = true;
            this.metroPanelNewRedact.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelNewRedact.VerticalScrollbarSize = 10;
            // 
            // ReturnToView
            // 
            this.ReturnToView.ArrowColor = System.Drawing.Color.Empty;
            this.ReturnToView.CurrentButtonStyle = AcademicPlan.UserControls.ArrowButtonStyle.Left;
            this.ReturnToView.ImageDown = null;
            this.ReturnToView.ImageLeft = global::AcademicPlan.Properties.Resources._return;
            this.ReturnToView.ImageRight = null;
            this.ReturnToView.ImageUp = null;
            this.ReturnToView.Location = new System.Drawing.Point(1077, 0);
            this.ReturnToView.MouseDownBackColor = System.Drawing.Color.Empty;
            this.ReturnToView.MouseOverBackColor = System.Drawing.Color.Empty;
            this.ReturnToView.Name = "ReturnToView";
            this.ReturnToView.Size = new System.Drawing.Size(39, 39);
            this.ReturnToView.TabIndex = 22;
            this.ReturnToView.Visible = false;
            this.ReturnToView.OnUserControlButtonClicked += new AcademicPlan.UserControls.ArrowButton.ButtonClickedEventHandler(this.ReturnToView_Click);
            // 
            // metroPanelViewGrid
            // 
            this.metroPanelViewGrid.Controls.Add(this.EditSemesterFromGrid);
            this.metroPanelViewGrid.Controls.Add(this.ViewSemestrFromGrid);
            this.metroPanelViewGrid.Controls.Add(this.metroGridView);
            this.metroPanelViewGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelViewGrid.HorizontalScrollbarBarColor = true;
            this.metroPanelViewGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelViewGrid.HorizontalScrollbarSize = 10;
            this.metroPanelViewGrid.Location = new System.Drawing.Point(0, 462);
            this.metroPanelViewGrid.Name = "metroPanelViewGrid";
            this.metroPanelViewGrid.Size = new System.Drawing.Size(1119, 390);
            this.metroPanelViewGrid.TabIndex = 23;
            this.metroPanelViewGrid.VerticalScrollbarBarColor = true;
            this.metroPanelViewGrid.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelViewGrid.VerticalScrollbarSize = 10;
            // 
            // EditSemesterFromGrid
            // 
            this.EditSemesterFromGrid.Location = new System.Drawing.Point(633, 0);
            this.EditSemesterFromGrid.Name = "EditSemesterFromGrid";
            this.EditSemesterFromGrid.Size = new System.Drawing.Size(75, 374);
            this.EditSemesterFromGrid.TabIndex = 4;
            this.EditSemesterFromGrid.Text = "Изменить";
            this.EditSemesterFromGrid.UseSelectable = true;
            this.EditSemesterFromGrid.Click += new System.EventHandler(this.EditSemesterFromGrid_Click);
            // 
            // ViewSemestrFromGrid
            // 
            this.ViewSemestrFromGrid.Location = new System.Drawing.Point(552, 0);
            this.ViewSemestrFromGrid.Name = "ViewSemestrFromGrid";
            this.ViewSemestrFromGrid.Size = new System.Drawing.Size(75, 374);
            this.ViewSemestrFromGrid.TabIndex = 3;
            this.ViewSemestrFromGrid.Text = "Просмотр";
            this.ViewSemestrFromGrid.UseSelectable = true;
            this.ViewSemestrFromGrid.Click += new System.EventHandler(this.ViewSemestrFromGrid_Click);
            // 
            // metroGridView
            // 
            this.metroGridView.AllowUserToAddRows = false;
            this.metroGridView.AllowUserToDeleteRows = false;
            this.metroGridView.AllowUserToResizeRows = false;
            this.metroGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.metroGridView.EnableHeadersVisualStyles = false;
            this.metroGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroGridView.Location = new System.Drawing.Point(6, 3);
            this.metroGridView.MultiSelect = false;
            this.metroGridView.Name = "metroGridView";
            this.metroGridView.ReadOnly = true;
            this.metroGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridView.Size = new System.Drawing.Size(540, 371);
            this.metroGridView.TabIndex = 2;
            this.metroGridView.SelectionChanged += new System.EventHandler(this.metroGridView_SelectionChanged);
            // 
            // metroPanelSubjectsInput
            // 
            this.metroPanelSubjectsInput.BackColor = System.Drawing.Color.White;
            this.metroPanelSubjectsInput.Controls.Add(this.ReturnToView);
            this.metroPanelSubjectsInput.Controls.Add(this.choisePanel);
            this.metroPanelSubjectsInput.Controls.Add(this.borderedCellInfoYearSemestr);
            this.metroPanelSubjectsInput.Controls.Add(this.metroButtonAddSubject);
            this.metroPanelSubjectsInput.Controls.Add(this.SumKKSLabel);
            this.metroPanelSubjectsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelSubjectsInput.HorizontalScrollbarBarColor = true;
            this.metroPanelSubjectsInput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelSubjectsInput.HorizontalScrollbarSize = 10;
            this.metroPanelSubjectsInput.Location = new System.Drawing.Point(0, 0);
            this.metroPanelSubjectsInput.Name = "metroPanelSubjectsInput";
            this.metroPanelSubjectsInput.Size = new System.Drawing.Size(1119, 39);
            this.metroPanelSubjectsInput.TabIndex = 24;
            this.metroPanelSubjectsInput.VerticalScrollbarBarColor = true;
            this.metroPanelSubjectsInput.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelSubjectsInput.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Location = new System.Drawing.Point(6, 3);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(100, 25);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Год";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearPicker
            // 
            this.YearPicker.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.YearPicker.FormattingEnabled = true;
            this.YearPicker.ItemHeight = 19;
            this.YearPicker.Location = new System.Drawing.Point(112, 3);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(121, 25);
            this.YearPicker.TabIndex = 3;
            this.YearPicker.UseSelectable = true;
            // 
            // SemesterPicker
            // 
            this.SemesterPicker.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.SemesterPicker.FormattingEnabled = true;
            this.SemesterPicker.ItemHeight = 19;
            this.SemesterPicker.Location = new System.Drawing.Point(345, 3);
            this.SemesterPicker.Name = "SemesterPicker";
            this.SemesterPicker.Size = new System.Drawing.Size(121, 25);
            this.SemesterPicker.TabIndex = 4;
            this.SemesterPicker.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Location = new System.Drawing.Point(239, 3);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 25);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Семестр";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanelFilter
            // 
            this.metroPanelFilter.Controls.Add(this.metroLabel14);
            this.metroPanelFilter.Controls.Add(this.DepartmentPicker);
            this.metroPanelFilter.Controls.Add(this.metroLabel12);
            this.metroPanelFilter.Controls.Add(this.metroLabel13);
            this.metroPanelFilter.Controls.Add(this.YearPicker);
            this.metroPanelFilter.Controls.Add(this.SemesterPicker);
            this.metroPanelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelFilter.HorizontalScrollbarBarColor = true;
            this.metroPanelFilter.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelFilter.HorizontalScrollbarSize = 10;
            this.metroPanelFilter.Location = new System.Drawing.Point(0, 39);
            this.metroPanelFilter.Name = "metroPanelFilter";
            this.metroPanelFilter.Size = new System.Drawing.Size(1119, 33);
            this.metroPanelFilter.TabIndex = 26;
            this.metroPanelFilter.VerticalScrollbarBarColor = true;
            this.metroPanelFilter.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelFilter.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.Location = new System.Drawing.Point(474, 3);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(100, 25);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Отдел";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentPicker
            // 
            this.DepartmentPicker.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.DepartmentPicker.FormattingEnabled = true;
            this.DepartmentPicker.ItemHeight = 19;
            this.DepartmentPicker.Location = new System.Drawing.Point(580, 3);
            this.DepartmentPicker.Name = "DepartmentPicker";
            this.DepartmentPicker.Size = new System.Drawing.Size(121, 25);
            this.DepartmentPicker.TabIndex = 6;
            this.DepartmentPicker.UseSelectable = true;
            // 
            // WindowTabControlEPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "WindowTabControlEPlan";
            this.Load += new System.EventHandler(this.WindowTabControlEPlan_Load);
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanelSubjectsData.ResumeLayout(false);
            this.metroPanelNewRedact.ResumeLayout(false);
            this.metroPanelViewGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridView)).EndInit();
            this.metroPanelSubjectsInput.ResumeLayout(false);
            this.metroPanelFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewMode;
        private System.Windows.Forms.ToolStripMenuItem ChangeMode;
        private System.Windows.Forms.ToolStripMenuItem ViewMode;
        private BorderedCell borderedCellInfoYearSemestr;
        private AcademicPlan.UserControls.ChoisePanel choisePanel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonAddSubject;
        private MetroFramework.Controls.MetroPanel metroPanelSubjectsData;
        private System.Windows.Forms.FlowLayoutPanel metroPanelGroup;
        private System.Windows.Forms.FlowLayoutPanel metroPanelPercent;
        private System.Windows.Forms.FlowLayoutPanel metroPanelKKC;
        private System.Windows.Forms.FlowLayoutPanel metroPanelPz;
        private System.Windows.Forms.FlowLayoutPanel metroPanelLz;
        private System.Windows.Forms.FlowLayoutPanel metroPanelLk;
        private System.Windows.Forms.FlowLayoutPanel metroPanelSm;
        private System.Windows.Forms.FlowLayoutPanel metroPanelAct;
        private System.Windows.Forms.FlowLayoutPanel metroPanelNorm;
        private System.Windows.Forms.FlowLayoutPanel metroPanelCycles;
        private System.Windows.Forms.FlowLayoutPanel metroPanelDiscipline;
        private MetroFramework.Controls.MetroLabel SumKKSLabel;
        private MetroFramework.Controls.MetroPanel metroPanelNewRedact;
        private System.Windows.Forms.FlowLayoutPanel metroPanelDelete;
        private MetroFramework.Controls.MetroPanel metroPanelViewGrid;
        private ArrowButton ReturnToView;
        private MetroFramework.Controls.MetroGrid metroGridView;
        private MetroFramework.Controls.MetroPanel metroPanelFilter;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox DepartmentPicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox YearPicker;
        private MetroFramework.Controls.MetroComboBox SemesterPicker;
        private MetroFramework.Controls.MetroPanel metroPanelSubjectsInput;
        private MetroFramework.Controls.MetroButton ViewSemestrFromGrid;
        private MetroFramework.Controls.MetroButton EditSemesterFromGrid;
        private System.Windows.Forms.ToolStripMenuItem SaveRedactedData;
    }
}
