using AcademicPlan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AcademicPlan.UserControls
{
    public partial class WindowTabControlEProcess : AcademicPlan.WindowTabControlBase
    {
        Int32 rightPanelBeginWidth, rightPanelEndWidth, rightPanelStep; // RightPanel Animation Settings
        const Int16 timeToChangeWidthRightPanel = 500; // miliseconds
        Boolean rightPanelToEnd;        

        String selectedRadioButtonName, selectedRadioButtonTag; // RadioButtons -> RightPanel

        ProjectSchedule UserData;

        public ProjectSchedule ClassWindow
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

        public WindowTabControlEProcess()
        {
            InitializeComponent();

            selectedRadioButtonName = String.Empty;
            rightPanelToEnd = false;

            rightPanelBeginWidth = arrowButtonRightSlide.Width + panelRightInfoButtons.Width;
            rightPanelEndWidth = arrowButtonRightSlide.Width + panelRightInfoButtons.Width + panelRightInfoTitles.Width;

            rightPanelStep = ((rightPanelEndWidth - rightPanelBeginWidth) / (timeToChangeWidthRightPanel / timerSlideRight.Interval));

            panelRight.Width = rightPanelBeginWidth;
            
            InitUserButtonsAction();
        }

        private void InitUserButtonsAction() {
            arrowButtonRightSlide.OnUserControlButtonClicked += new ArrowButton.ButtonClickedEventHandler(arrowButtonRightSlide_Click);
            for (int i = 2; i < panelCenterContentMain.Controls.Count; i++) {
                ((MonthView)panelCenterContentMain.Controls[i]).OnUserControlGridClicked += new MonthView.DataGridViewCellMouseEventHandler(monthView_Click);
            }
            //foreach (MonthView monthV in panelCenterContentMain.Controls)
            //{
            //    monthV.OnUserControlGridClicked += new MonthView.DataGridViewCellMouseEventHandler(monthView_Click);
            //}
        }
        private void monthView_Click(object sender, EventArgs e)
        {
            ((MonthView)sender).ActiveTool = selectedRadioButtonTag;
        }    
        //заполняет все MV значениями из класса с данными
        public void SetScheduleData()
        {
            foreach (KeyValuePair<ScheduleKey, string> dataValue in ScheduleData.Instance.data)
            {
                foreach (MonthView monthV in panelCenterContentMain.Controls)
                {
                    if (monthV.month.id == dataValue.Key.month.id)
                    {
                        monthV.SetCellData(dataValue.Key.week, dataValue.Key.course, dataValue.Value);
                    }
                }
            }
        }
        //заполняет все поля начальных значений из класса с данными
        public void SetStartData()//!!!
        {
            comboBoxFirstMonth.SelectedIndex = ScheduleData.Instance.start_month.id - 1;
            comboBoxEndFirstSemestr.SelectedIndex = ScheduleData.Instance.end_month_sem1.id - 1;
            if (ScheduleData.Instance.courses == 4)
                comboBoxCourse.SelectedIndex = 0;
            else
                comboBoxCourse.SelectedIndex = 1;
            textBoxFirstDay.Text = ScheduleData.Instance.start_date.ToString();
            textBoxYearPlan.Text = ScheduleData.Instance.year.ToString();
        }
        //выравнивает все MV по ширине и передает им данные (недели, количество курсов, месяц)
        public void SetMonthViews()
        {
            Month monthTemp = UserData.StartMonth;
            for (int i = panelCenterContentMain.Controls.Count - 1; i > 1; i--)
            {
                MonthView monthV = panelCenterContentMain.Controls[i] as MonthView;
                monthV.SetWeeks(UserData.GetWeeksOfMonth(monthTemp), UserData.Courses, monthTemp);
                monthV.Dock = DockStyle.Left;
                monthTemp = UserData.GetNextMonth(monthTemp);
            }
        }        


        private void timerSlideRight_Tick(object sender, EventArgs e)
        {
            if (rightPanelToEnd == true) {
                if ((panelRight.Width <= rightPanelEndWidth && rightPanelEndWidth < rightPanelBeginWidth) || (panelRight.Width >= rightPanelEndWidth && rightPanelEndWidth > rightPanelBeginWidth)){
                    panelRight.Width = rightPanelEndWidth;
                    this.timerSlideRight.Enabled = false;
                }
                else
                    panelRight.Width += rightPanelStep;
            }
            else {
                if ((panelRight.Width <= rightPanelBeginWidth && rightPanelBeginWidth < rightPanelEndWidth) || (panelRight.Width >= rightPanelBeginWidth && rightPanelBeginWidth > rightPanelEndWidth)) {
                    panelRight.Width = rightPanelBeginWidth;
                    this.timerSlideRight.Enabled = false;
                }
                else
                    panelRight.Width -= rightPanelStep;
            }
        }

        private void textBoxFirstDay_TextChanged(object sender, EventArgs e)
        {
            MetroTextBox currentTextBox = sender as MetroTextBox;
            if (currentTextBox.Text == String.Empty)
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Не оставляйте поле пустым", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentTextBox.Text = UserData.StartDate.ToString();
                return;
            }
            if (Convert.ToInt32(currentTextBox.Text) == UserData.StartDate)
                return;
            int number = Convert.ToInt32(currentTextBox.Text);
            if (number < 1 || number > UserData.Months[comboBoxFirstMonth.SelectedIndex + 1].days_count)
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Введено некорректное число", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (UserData.StartDate < 1 || UserData.StartDate > UserData.Months[comboBoxFirstMonth.SelectedIndex + 1].days_count)
                    UserData.StartDate = 1;
                currentTextBox.Text = UserData.StartDate.ToString();
            }
            else
            {
                DateTime date = new DateTime(UserData.Year, UserData.StartMonth.id, number);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    
                    DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Установить началом семестра выходной?", "Выходной", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UserData.StartDate = number;
                        UserData.CalculateSchedule();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        currentTextBox.Text = UserData.StartDate.ToString();
                    }
                }
                else
                {
                    UserData.StartDate = number;
                    UserData.CalculateSchedule();
                }
            }
            ScheduleData.Instance.start_date = UserData.StartDate;
        }

        private void textBoxYearPlan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxYearPlan.Text == String.Empty)
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Не оставляйте поле пустым", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserData.Year = DateTime.Now.Year;
                textBoxYearPlan.Text = UserData.Year.ToString();
            }
            else if (Convert.ToInt32(textBoxYearPlan.Text) > 0 && Convert.ToInt32(textBoxYearPlan.Text) <= DateTime.Now.Year)
                UserData.Year = Convert.ToInt32(textBoxYearPlan.Text);
            else {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "год не может быть больше текущего", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserData.Year = DateTime.Now.Year;
                textBoxYearPlan.Text = UserData.Year.ToString();
            }
            
            ScheduleData.Instance.year = UserData.Year;
        }

        private void comboBoxFirstMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserData.StartDate != 0)
            {
                if (UserData.StartDate < 1 || UserData.StartDate > UserData.Months[comboBoxFirstMonth.SelectedIndex + 1].days_count)
                {
                    MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Текущая дата некорректна для выбранного месяца", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserData.StartDate = 1;
                    textBoxFirstDay.Text = UserData.StartDate.ToString();
                }
            }
            UserData.StartMonth = UserData.Months[comboBoxFirstMonth.SelectedIndex + 1];
            ScheduleData.Instance.start_month = UserData.Months[comboBoxFirstMonth.SelectedIndex + 1];

            UserData.CalculateSchedule();
        }

        private void comboBoxEndFirstSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserData.Months[comboBoxEndFirstSemestr.SelectedIndex + 1].id == UserData.StartMonth.id)
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Начало и конец семестра не должны совпадать", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEndFirstSemestr.SelectedIndex = UserData.EndMonthSem.id;
                return;
            }
            UserData.EndMonthSem = UserData.Months[comboBoxEndFirstSemestr.SelectedIndex + 1];
            ScheduleData.Instance.end_month_sem1 = UserData.Months[comboBoxEndFirstSemestr.SelectedIndex + 1];
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourse.SelectedIndex == 0)
            {
                labelC1.Text = "Курс 1";
                labelC2.Visible = true;
                labelC3.Visible = true;
                labelC4.Visible = true;
                UserData.Courses = 4;                
            }
            else if (comboBoxCourse.SelectedIndex == 1)
            {
                labelC1.Text = "Курс 5";
                labelC2.Visible = false;
                labelC3.Visible = false;
                labelC4.Visible = false;
                UserData.Courses = 1;
            }
            ScheduleData.Instance.courses = UserData.Courses;
            //if (loaded)
            UserData.CalculateSchedule();
        }

        private void OpenScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserData.DataRuler.LoadUserData(UserData);
        }

        private void SaveScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserData.DataRuler.SaveUserData(UserData);
        }

        private void textBoxFirstDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void arrowButtonRightSlide_Click(object sender, EventArgs e)
        {
            if (this.timerSlideRight.Enabled == false)
            {
                arrowButtonRightSlide.OppositeButtonStyle();

                rightPanelToEnd = !rightPanelToEnd;
                this.timerSlideRight.Enabled = true;
            }
        }

        private void buttonBottomSlide_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "I'm bottom slide", "Click Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radioRightInfoButtons_Click(object sender, EventArgs e)
        {
            RadioButton currentRadioButton = sender as RadioButton;
            if (selectedRadioButtonName == String.Empty)
                selectedRadioButtonName = currentRadioButton.Name;
            else {
                if (currentRadioButton.Name == selectedRadioButtonName){
                    currentRadioButton.Checked = false;
                    selectedRadioButtonName = String.Empty;
                    selectedRadioButtonTag = String.Empty;
                    return;
                }
                else                    
                    selectedRadioButtonName = currentRadioButton.Name;                
            }
            selectedRadioButtonTag = currentRadioButton.Text;
        }
    }
}
