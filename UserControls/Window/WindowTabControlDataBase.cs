using AcademicPlan.Classes;
using AcademicPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcademicPlan.UserControls
{
    public partial class WindowTabControlDataBase : WindowTabControlBase
    {
        ProjectDataBase UserData;

        public ProjectDataBase ClassWindow
        {
            get
            {
                return UserData;
            }

            set
            {
                UserData = value;
            }
        }

        public WindowTabControlDataBase()
        {
            InitializeComponent();
        }

        private void lluminatedButtonDiscCycles_Click(object sender, EventArgs e)
        {
            metroPanelDiscCycles.Visible = !metroPanelDiscCycles.Visible;
            //IlluminatedButton buttonClicket = sender as IlluminatedButton;
            //if (buttonClicket.IsSelected)
            //{
            //    if (selectedProject != String.Empty)
            //        ProjectDictionary[selectedProject].DisconnectWindow();
            //    ProjectDictionary[buttonClicket.Name].ConnectWindow();
            //    selectedProject = buttonClicket.Name;
            //}
            //else
            //{
            //    ProjectDictionary[buttonClicket.Name].DisconnectWindow();
            //    selectedProject = String.Empty;
            //}
        }

        private void WindowTabControlDataBase_Load(object sender, EventArgs e)
        {
            UserData.DataBase.DiscChanged += ReceiveChanges;
            UserData.DataBase.CyclesChanged += ReceiveChanges;
            UserData.LoadDataInView();            
        }

        private void ReceiveChanges(object obj, EventArgs e) {
            DataFields incomeType = ((DataBaseEventArguments)e).type;
            if (UserData.IsActive)
            {
                if (incomeType == DataFields.CYCLE) {                    
                    UserData.AttachDataToGrid(CyclesGrid, DataFields.CYCLE);
                    CyclesGrid.Columns[0].HeaderText = "ID";
                    CyclesGrid.Columns[1].HeaderText = "Краткое название";
                    CyclesGrid.Columns[2].HeaderText = "Полное название";
                    if (CyclesGrid.Columns.Count < 1)
                    {

                    }
                }
                else if (incomeType == DataFields.DISC) {
                    UserData.AttachDataToGrid(DiscGrid, DataFields.DISC);
                    DiscGrid.Columns[0].HeaderText = "ID";
                    DiscGrid.Columns[1].HeaderText = "Название";
                    if (DiscGrid.Columns.Count < 1)
                    {

                    }
                }
            }
            else
                updateMask |= (Int32)incomeType;
        }

        private void DiscSave_Click(object sender, EventArgs e)
        {
            bool flag = UserData.DataBase.Discs.GetChanges(DataRowState.Added) != null;
            if (UserData.DataBase.UpdateSpravData(DataFields.DISC))
            {
                MessageBox.Show("Данные успешно обновлены.");
                if (flag)
                    UserData.DataBase.SetDiscs();
            }
        }

        private void DiscAdd_Click(object sender, EventArgs e)
        {
            //DiscGrid.Rows.Add();
            if(DiscNameTextBox.Text.Trim() != String.Empty)
                UserData.DataBase.Discs.Rows.Add(null, DiscNameTextBox.Text.Trim());            
        }

        private void DiscChange_Click(object sender, EventArgs e)
        {
            if (DiscNameTextBox.Text.Trim() != String.Empty && DiscGrid.SelectedRows.Count == 1)
                ((DataRowView)DiscGrid.SelectedRows[0].DataBoundItem).Row["Disc_Name"] = DiscNameTextBox.Text.Trim();
        }

        private void DiscDelete_Click(object sender, EventArgs e)
        {
            if (DiscGrid.SelectedRows.Count == 1) {
                ((DataRowView)DiscGrid.SelectedRows[0].DataBoundItem).Row.Delete();
                if(DiscGrid.Rows.Count > 0)
                    DiscGrid.Rows[DiscGrid.Rows.Count - 1].Selected = true;
            }
            
        }

        private void DiscGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (DiscGrid.SelectedRows.Count == 0) return;

            DiscNameTextBox.Text = (string)(DiscGrid.SelectedRows[0].Cells["Disc_Name"].Value);
        }

        private void CyclesSave_Click(object sender, EventArgs e)
        {
            bool flag = UserData.DataBase.Cycles.GetChanges(DataRowState.Added) != null;
            if (UserData.DataBase.UpdateSpravData(DataFields.CYCLE))
            {
                MessageBox.Show("Данные успешно обновлены.");
                if (flag) 
                    UserData.DataBase.SetCycle();    
            }
        }

        private void CyclesAdd_Click(object sender, EventArgs e)
        {
            if (CyclesNameLong.Text.Trim() != String.Empty && CyclesNameShort.Text.Trim() != String.Empty)
                UserData.DataBase.Cycles.Rows.Add(null, CyclesNameShort.Text.Trim(), CyclesNameLong.Text.Trim());
        }

        private void CyclesChange_Click(object sender, EventArgs e)
        {
            if (CyclesNameLong.Text.Trim() != String.Empty && CyclesNameShort.Text.Trim() != String.Empty && CyclesGrid.SelectedRows.Count == 1) {
                ((DataRowView)CyclesGrid.SelectedRows[0].DataBoundItem).Row["Cycle_Name"] = CyclesNameShort.Text.Trim();
                ((DataRowView)CyclesGrid.SelectedRows[0].DataBoundItem).Row["Cycle_Long_Name"] = CyclesNameLong.Text.Trim();
            }
        }

        private void CyclesDelete_Click(object sender, EventArgs e)
        {
            if (CyclesGrid.SelectedRows.Count == 1) {
                ((DataRowView)CyclesGrid.SelectedRows[0].DataBoundItem).Row.Delete();
                if (CyclesGrid.Rows.Count > 0)
                    CyclesGrid.Rows[CyclesGrid.Rows.Count - 1].Selected = true;
            }
                
        }

        private void CyclesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CyclesGrid.SelectedRows.Count == 0) return;

            CyclesNameShort.Text = (string)(CyclesGrid.SelectedRows[0].Cells["Cycle_Name"].Value);
            CyclesNameLong.Text = (string)(CyclesGrid.SelectedRows[0].Cells["Cycle_Long_Name"].Value);
        }
    }
}
