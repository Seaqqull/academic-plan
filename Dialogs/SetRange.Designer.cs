namespace AcademicPlan.Dialogs
{
    partial class SetRange
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
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.metroLabelDesc = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Location = new System.Drawing.Point(23, 154);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(75, 23);
            this.metroButtonOk.TabIndex = 0;
            this.metroButtonOk.Text = "Ок";
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButtonCancel.Location = new System.Drawing.Point(172, 154);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.metroButtonCancel.TabIndex = 1;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(100, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "<CPC<";
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(50, 83);
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(48, 20);
            this.num_min.TabIndex = 3;
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(159, 83);
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(48, 20);
            this.num_max.TabIndex = 4;
            // 
            // metroLabelDesc
            // 
            this.metroLabelDesc.AutoSize = true;
            this.metroLabelDesc.Location = new System.Drawing.Point(23, 116);
            this.metroLabelDesc.Name = "metroLabelDesc";
            this.metroLabelDesc.Size = new System.Drawing.Size(13, 19);
            this.metroLabelDesc.TabIndex = 5;
            this.metroLabelDesc.Text = " ";
            // 
            // SetRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 200);
            this.Controls.Add(this.metroLabelDesc);
            this.Controls.Add(this.num_max);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonOk);
            this.Name = "SetRange";
            this.Text = "Выбор диапазона";
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelDesc;
        public System.Windows.Forms.NumericUpDown num_min;
        public System.Windows.Forms.NumericUpDown num_max;
    }
}