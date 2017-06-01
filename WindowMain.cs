using AcademicPlan.Classes;
using AcademicPlan.Interfaces;
using AcademicPlan.UserControls;
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
//using AcademicPlan.UserControls
namespace AcademicPlan
{
    public enum DataFields { KAF = 1, YEAR = 2, SEMESTER = 4, DISC = 8, CYCLE = 16, STOCK = 32, SEMESTERTABLE = 64 }

    public partial class WindowMain : MetroForm
    {
        String selectedProject;

        Dictionary<String, ProjectBase> ProjectDictionary;
        DataControllerEPlan dataBase;

        public string SelectedProject
        {
            get
            {
                return selectedProject;
            }

            set
            {
                selectedProject = value;
            }
        }

        public WindowMain()
        {
            InitializeComponent();

            selectedProject = String.Empty;
            dataBase = new DataControllerEPlan();
            ProjectDictionary = new Dictionary<String, ProjectBase>();
            ProjectDictionary.Add("Schedule", new ProjectSchedule(this, panelCurrentWindow, new WindowTabControlEProcess(), "Schedule", new DataControllerSchedule(), new RelationSchedule()));
            ProjectDictionary.Add("EPlan", new ProjectEPlan(this, panelCurrentWindow, new WindowTabControlEPlan(), "EPlan", dataBase, new RelationEPlan()));
            ProjectDictionary.Add("DataBaseEditing", new ProjectDataBase(this, panelCurrentWindow, new WindowTabControlDataBase(), "DataBaseEditing", dataBase, new RelationDataBase()));

            CreateItemMenu();
        }

        private void CreateItemMenu() {
            foreach(IlluminatedButton ilbutton in this.panelSelectWindow.Controls) {
                ilbutton.OnUserControlButtonClicked += new IlluminatedButton.ButtonClickedEventHandler(illuminatedButton_Click);                
            }
        }

        private void illuminatedButton_Click(object sender, EventArgs e)
        {
            IlluminatedButton buttonClicket = sender as IlluminatedButton;
            if (buttonClicket.IsSelected)
            {
                if (selectedProject != String.Empty)
                    ProjectDictionary[selectedProject].DisconnectWindow();
                ProjectDictionary[buttonClicket.Name].ConnectWindow();
                selectedProject = buttonClicket.Name;
            }
            else {
                selectedProject = String.Empty;
                ProjectDictionary[buttonClicket.Name].DisconnectWindow();                
            }
        }
    }
}
