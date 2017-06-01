namespace AcademicPlan.Dialogs
{
    partial class SetRangeExt
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
            this.metroLabelDesc = new MetroFramework.Controls.MetroLabel();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.metroCheckBoxUpper = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxLower = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelDesc
            // 
            this.metroLabelDesc.AutoSize = true;
            this.metroLabelDesc.Location = new System.Drawing.Point(22, 120);
            this.metroLabelDesc.Name = "metroLabelDesc";
            this.metroLabelDesc.Size = new System.Drawing.Size(13, 19);
            this.metroLabelDesc.TabIndex = 11;
            this.metroLabelDesc.Text = " ";
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(166, 60);
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(67, 20);
            this.num_max.TabIndex = 10;
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(31, 60);
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(67, 20);
            this.num_min.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(107, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "<CPC<";
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButtonCancel.Location = new System.Drawing.Point(172, 154);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.metroButtonCancel.TabIndex = 7;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.UseSelectable = true;
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Location = new System.Drawing.Point(23, 154);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(75, 23);
            this.metroButtonOk.TabIndex = 6;
            this.metroButtonOk.Text = "Ок";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroCheckBoxUpper
            // 
            this.metroCheckBoxUpper.AutoSize = true;
            this.metroCheckBoxUpper.Location = new System.Drawing.Point(166, 87);
            this.metroCheckBoxUpper.Name = "metroCheckBoxUpper";
            this.metroCheckBoxUpper.Size = new System.Drawing.Size(67, 15);
            this.metroCheckBoxUpper.TabIndex = 12;
            this.metroCheckBoxUpper.Text = "Верхняя";
            this.metroCheckBoxUpper.UseSelectable = true;
            this.metroCheckBoxUpper.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // metroCheckBoxLower
            // 
            this.metroCheckBoxLower.AutoSize = true;
            this.metroCheckBoxLower.Location = new System.Drawing.Point(31, 86);
            this.metroCheckBoxLower.Name = "metroCheckBoxLower";
            this.metroCheckBoxLower.Size = new System.Drawing.Size(67, 15);
            this.metroCheckBoxLower.TabIndex = 13;
            this.metroCheckBoxLower.Text = "Нижняя";
            this.metroCheckBoxLower.UseSelectable = true;
            this.metroCheckBoxLower.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // SetRangeExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 200);
            this.Controls.Add(this.metroCheckBoxLower);
            this.Controls.Add(this.metroCheckBoxUpper);
            this.Controls.Add(this.metroLabelDesc);
            this.Controls.Add(this.num_max);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonOk);
            this.Name = "SetRangeExt";
            this.Text = "Выбор диапазона";
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelDesc;
        public System.Windows.Forms.NumericUpDown num_max;
        public System.Windows.Forms.NumericUpDown num_min;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUpper;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLower;
    }
}