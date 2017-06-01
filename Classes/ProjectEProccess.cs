using AcademicPlan.Interfaces;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    class ProjectEProccess : ProjectBase
    {
        public ProjectEProccess(MetroForm incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, String incomeTitle, IDataController incomeDataController, IRelation incomeRelation) : base(incomeMain, inWindowContainer, incomeWindow, incomeTitle, incomeDataController, incomeRelation)
        {
                        
        }

        public override void ClearDataInView()
        {
            throw new NotImplementedException();
        }

        public override void LoadDataInView()
        {
            throw new NotImplementedException();
        }
    }
}
