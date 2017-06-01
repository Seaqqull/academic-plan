using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicPlan.Interfaces;
using AcademicPlan.UserControls;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Data;

namespace AcademicPlan.Classes
{
    public class ProjectDataBase : ProjectBase
    {
        WindowTabControlDataBase windowData;
        DataControllerEPlan dataBase;

        public DataControllerEPlan DataBase
        {
            get
            {
                return dataBase;
            }
        }

        public WindowTabControlDataBase WindowData
        {
            get
            {
                return windowData;
            }
        }

        public ProjectDataBase(WindowMain incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, string incomeTitle, IDataController incomeDataController, IRelation incomeRelation) : base(incomeMain, inWindowContainer, incomeWindow, incomeTitle, incomeDataController, incomeRelation)
        {
            windowData = (WindowTabControlDataBase)incomeWindow;
            dataBase = (DataControllerEPlan)incomeDataController;

            windowData.ClassWindow = this;
        }

        public override void ClearDataInView()
        {
            //throw new NotImplementedException();
        }

        public override void LoadDataInView()
        {
            //throw new NotImplementedException();
            if (dataBase.Cycles.Columns.Count < 1)
                dataBase.SetCycle();
            if (dataBase.Discs.Columns.Count < 1)
                dataBase.SetDiscs();
        }

        public void AttachDataToGrid(MetroGrid incomeGrid, DataFields incomeType) {
            BindingSource bS = new BindingSource();
            switch (incomeType)
            {
                case DataFields.KAF:
                    break;
                case DataFields.YEAR:
                    break;
                case DataFields.SEMESTER:
                    break;
                case DataFields.DISC:
                    bS.DataSource = dataBase.Discs;                    
                    break;
                case DataFields.CYCLE:
                    bS.DataSource = dataBase.Cycles;
                    break;
                default:
                    break;
            }
            incomeGrid.DataSource = bS;       
        }

    }
}
