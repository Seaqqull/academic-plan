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
    public partial class WindowMain : MetroForm
    {
        String selectedProject;

        Dictionary<String, ProjectBase> ProjectDictionary;

        public WindowMain()
        {
            InitializeComponent();

            selectedProject = String.Empty;

            ProjectDictionary = new Dictionary<String, ProjectBase>();
            ProjectDictionary.Add("Schedule", new ProjectSchedule(this, panelCurrentWindow, new WindowTabControlEProcess(), "Schedule", new DataControllerSchedule(), new RelationSchedule()));
            ProjectDictionary.Add("Schedule1", new ProjectSchedule(this, panelCurrentWindow, new WindowTabControlEProcess(), "Schedule1", new DataControllerSchedule(), new RelationSchedule()));

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
                ProjectDictionary[buttonClicket.Name].DisconnectWindow();
                selectedProject = String.Empty;
            }
        }
    }
}
