using AcademicPlan.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Interfaces
{
    class DataControllerSchedule : IDataController
    {
        public void InitUserData(ProjectBase userProject) {
            if (!File.Exists(Path.GetFullPath("..\\..\\Resources\\Data\\Schedule.bin")))
                MetroFramework.MetroMessageBox.Show(userProject.Parent,"Отсутствует файл по умолчанию", "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                ScheduleData.Instance.LoadDataFromBinary(Path.GetFullPath("..\\..\\Resources\\Data\\Schedule.bin")); //заполняет класс формы значениями из класса с данными                
            userProject.LoadDataInView();
            //Добавление ошибки в список с возможным решением
        }

        public void LoadUserData(ProjectBase userProject) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "binary files (*.bin)|*.bin";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
                if (ScheduleData.Instance.LoadDataFromBinary(openFileDialog.FileName)) //заполняет класс формы значениями из класса с данными
                    userProject.LoadDataInView();
        }

        public void SaveUserData(ProjectBase userProject) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "binary files (*.bin)|*.bin";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                ScheduleData.Instance.SaveDataToBinary(saveFileDialog.FileName);
        }

        public void FinalUserData(ProjectBase userProject) {

        }
    }
}
