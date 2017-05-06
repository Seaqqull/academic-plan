using AcademicPlan.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicPlan.Interfaces
{
    public interface IDataController
    {
        void InitUserData(ProjectBase userProject);
        void LoadUserData(ProjectBase userProject);
        void SaveUserData(ProjectBase userProject);
        void FinalUserData(ProjectBase userProject);
    }
}
