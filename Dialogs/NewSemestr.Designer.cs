namespace AcademicPlan.Dialogs
{
    partial class NewSemestr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.Semester = new System.Windows.Forms.NumericUpDown();
            this.DiscCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Semester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscCount)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Год";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(23, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Семестр";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(23, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Кол-во дисциплин";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 192);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Ок";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(202, 192);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Отмена";
            this.metroButton2.UseSelectable = true;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(130, 78);
            this.Year.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(120, 20);
            this.Year.TabIndex = 8;
            this.Year.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // Semester
            // 
            this.Semester.Location = new System.Drawing.Point(131, 119);
            this.Semester.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.Semester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(120, 20);
            this.Semester.TabIndex = 9;
            this.Semester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DiscCount
            // 
            this.DiscCount.Location = new System.Drawing.Point(130, 154);
            this.DiscCount.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.DiscCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiscCount.Name = "DiscCount";
            this.DiscCount.Size = new System.Drawing.Size(120, 20);
            this.DiscCount.TabIndex = 10;
            this.DiscCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NewSemestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(this.DiscCount);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewSemestr";
            this.Text = "Новый семестр";
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Semester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public System.Windows.Forms.NumericUpDown Year;
        public System.Windows.Forms.NumericUpDown Semester;
        public System.Windows.Forms.NumericUpDown DiscCount;
    }
}