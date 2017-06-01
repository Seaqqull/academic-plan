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
    public partial class SetRange : MetroForm
    {
        ProjectEPlan UserData;

        public SetRange()
        {
            InitializeComponent();
        }

        public SetRange(int min, int max, ProjectEPlan semestr)
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
        }

        public SetRange(int start, int finish, int min, int max, ProjectEPlan semestr) : this(min, max, semestr)
        {
            num_max.Value = finish;
            num_min.Value = start;
        }

        protected virtual void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

            List<decimal> kks = new List<decimal>();
            for (decimal i = UserData.min_kredits_per_disc; i <= UserData.max_kredits_per_disc; i++)
                if (UserData.find_in_hours(i, new Tuple<int, int>((int)num_min.Value, (int)num_max.Value), true) == 0M) kks.Add(i);

            if (kks.Count != 0)
            {
                metroLabelDesc.ForeColor = Color.Maroon;
                metroLabelDesc.Text = "Недоступны кредиты: ";
                for (int i = 0; i < kks.Count; i++)
                    metroLabelDesc.Text += kks[i].ToString() + ", ";
                metroLabelDesc.Text = metroLabelDesc.Text.Remove(metroLabelDesc.Text.Length - 2, 2);
            }
            else { metroLabelDesc.Text = "Все кредиты доступны"; metroLabelDesc.ForeColor = Color.ForestGreen; }
        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            if (num_min.Value >= num_max.Value) { MessageBox.Show("Неправильно"); return; }
            List<decimal> kks = new List<decimal>();
            for (decimal i = UserData.min_kredits_per_disc; i <= UserData.max_kredits_per_disc; i++)
                if (UserData.find_in_hours(i, new Tuple<int, int>((int)num_min.Value, (int)num_max.Value), true) == 0M) kks.Add(i);

            if (kks.Count != 0)
            {
                string message;
                if (kks.Count == UserData.max_kredits_per_disc - UserData.min_kredits_per_disc + 1)
                {
                    message = "Нет доступных кредитов при даном СРС. Поменяйте диапазон!!!";
                    MessageBox.Show(message, "Слишком маленький диапазон");
                    return;
                }
                message = "При выборе кредитов будут недоступны такие значения: ";
                for (int i = 0; i < kks.Count; i++)
                    message += kks[i].ToString() + ", ";
                message = message.Remove(message.Length - 2, 2);
                message += ". Сохранить значение группы СРС?";
                if (MessageBox.Show(message, "Вас устраивает диапазон?", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
