using AcademicPlan.Classes;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Dialogs
{
    public partial class SetRangeExt : MetroForm
    {
        ProjectEPlan UserData;
        int start;
        int finish;
        decimal kks;

        public SetRangeExt()
        {
            InitializeComponent();
        }

        public SetRangeExt(int start, int finish, int min, int max, Tuple<int, int> advice, decimal kks, ProjectEPlan semestr)
        {
            InitializeComponent();
            UserData = semestr;
            this.num_min.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.num_max.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            num_min.Minimum = min;
            num_min.Maximum = max - 1;
            num_max.Minimum = min + 1;
            num_max.Maximum = max;
            num_max.Value = max;

            num_max.Value = finish;
            num_min.Value = start;

            this.kks = kks;
            this.start = start;
            this.finish = finish;
            if (advice.Item1 != -1) metroCheckBoxLower.Tag = advice.Item1;
            else metroCheckBoxLower.Visible = false;
            if (advice.Item2 != -1) metroCheckBoxUpper.Tag = advice.Item2;
            else metroCheckBoxUpper.Visible = false;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(metroCheckBoxLower))
                if (metroCheckBoxLower.Checked == true) num_min.Value = (int)metroCheckBoxLower.Tag;
                else num_min.Value = start;
            else
                if (metroCheckBoxUpper.Checked == true) num_max.Value = (int)metroCheckBoxUpper.Tag;
            else num_max.Value = finish;
        }

        protected void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (UserData.find_in_hours(kks, new Tuple<int, int>((int)num_min.Value, (int)num_max.Value), true) == 0M)
            { metroLabelDesc.Text = "НЕ ОК!"; metroLabelDesc.ForeColor = Color.Maroon; }
            else
            { metroLabelDesc.Text = "ОК"; metroLabelDesc.ForeColor = Color.ForestGreen; }
        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            if (num_min.Value >= num_max.Value ||
                UserData.find_in_hours(kks, new Tuple<int, int>((int)num_min.Value, (int)num_max.Value), true) == 0M)
            { MessageBox.Show("Неправильно"); return; }
            this.DialogResult = DialogResult.OK;
        }
    }
}
