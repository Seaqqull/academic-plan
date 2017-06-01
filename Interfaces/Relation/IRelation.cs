using AcademicPlan.Classes;
using AcademicPlan.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Interfaces
{
    public interface IRelation
    {
        void InitWindow(ProjectBase userData, WindowTabControlBase userWindow);
        void FinalWindow(ProjectBase userData, WindowTabControlBase userWindow);
    }
}
