using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicPlan.Classes;
using AcademicPlan.UserControls;

namespace AcademicPlan.Interfaces
{
    class RelationSchedule : IRelation
    {
        public void FinalWindow(ProjectBase userData, WindowTabControlBase userWindow)
        {
            //throw new NotImplementedException();
        }

        public void InitWindow(ProjectBase userData, WindowTabControlBase userWindow)
        {
            foreach (Month month in ((ProjectSchedule)userData).Months.Values)
            {
                ((WindowTabControlEProcess)userWindow).comboBoxFirstMonth.Items.Add(month.name);
                ((WindowTabControlEProcess)userWindow).comboBoxEndFirstSemestr.Items.Add(month.name);
            }
            ((WindowTabControlEProcess)userWindow).comboBoxFirstMonth.SelectedIndex = 8;
            ((WindowTabControlEProcess)userWindow).comboBoxEndFirstSemestr.SelectedIndex = 0;
            ((WindowTabControlEProcess)userWindow).comboBoxCourse.SelectedIndex = 0;

            ((WindowTabControlEProcess)userWindow).textBoxYearPlan.Text = DateTime.Now.Year.ToString();
            ((WindowTabControlEProcess)userWindow).textBoxFirstDay.Text = "1";

            ((ProjectSchedule)userData).Year = DateTime.Now.Year;
            ((ProjectSchedule)userData).StartDate = Convert.ToInt32("1");
            ((ProjectSchedule)userData).Courses = 4;
            ((ProjectSchedule)userData).CalculateSchedule();
            //foreach (Control c in groupBox1.Controls)
            //{
            //    if (c is CheckBox)
            //    {
            //        c.Click += new EventHandler(cb_CheckedChanged);
            //    }
            //}
        }
    }
}
