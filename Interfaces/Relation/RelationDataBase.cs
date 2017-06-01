using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicPlan.Classes;
using AcademicPlan.UserControls;
using System.Windows.Forms;

namespace AcademicPlan.Interfaces
{
    class RelationDataBase : IRelation
    {
        public void FinalWindow(ProjectBase userData, WindowTabControlBase userWindow)
        {
            ProjectDataBase incomeBase = (ProjectDataBase)userData;
            WindowTabControlDataBase incomeWindow = (WindowTabControlDataBase)userWindow;
            bool chDisc = incomeBase.DataBase.Discs.GetChanges() != null ? true : false, 
                 chCycles = incomeBase.DataBase.Cycles.GetChanges() != null ? true : false;

            if ((chDisc || chCycles) && MessageBox.Show("При выходе из вкладки внесенные изменения будут потеряны. Сохранить изменения?", "Изменения", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (chDisc)
                    incomeWindow.DiscSave.PerformClick();
                if (chCycles)
                    incomeWindow.CyclesSave.PerformClick();
            }
            else {
                incomeBase.DataBase.Discs.RejectChanges();
                incomeBase.DataBase.Cycles.RejectChanges();
            }
        }

        public void InitWindow(ProjectBase userData, WindowTabControlBase userWindow)
        {
            
        }
    }
}
