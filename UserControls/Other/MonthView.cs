using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicPlan.Classes;

namespace AcademicPlan.UserControls
{
    public partial class MonthView : UserControl
    {
        public delegate void DataGridViewCellMouseEventHandler(object sender, EventArgs e);
        public event DataGridViewCellMouseEventHandler OnUserControlGridClicked;
        //
        public Month month;
        private int courses;
        private string activeTool;
        private Dictionary<int, Week> weeks;
        private int cellWidth;
        private int cellHeight;

        public string ActiveTool
        {
            get
            {
                return activeTool;
            }

            set
            {
                activeTool = value;
            }
        }

        public MonthView()
        {
            InitializeComponent();
            activeTool = "";
            cellWidth = 26;
            cellHeight = 23;
            this.dataGridViewMonth.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellClick);
        }

        private void CellClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (OnUserControlGridClicked != null)
                OnUserControlGridClicked(this, e);

            if (e.RowIndex > 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (activeTool != "")
                    {
                        dataGridViewMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = activeTool;
                        ScheduleData.Instance.SetData(month, weeks.ElementAt(e.ColumnIndex).Value, e.RowIndex - 2, activeTool);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    dataGridViewMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    ScheduleData.Instance.SetData(month, weeks.ElementAt(e.ColumnIndex).Value, e.RowIndex - 2, "");
                }
            }
        }
        public void SetText(string text)
        {
            labelHeader.Text = text;
        }
        public bool SetWeeks(Dictionary<int, Week> weeks1, int courses, Month month)
        {
            this.month = month;
            this.courses = courses;
            if (weeks1 != null && weeks1.Count>0)
            {
                this.weeks = weeks1;
            }
            else
            {
                
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Пустой список недель", "Ошибка списка");
                return false;
            }
            SetDataView(courses);       

            dataGridViewMonth.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewMonth.Rows[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219);
            return true;
        }
        private void SetDataView(int courses)
        {
            dataGridViewMonth.Rows.Clear();
            dataGridViewMonth.Columns.Clear();
            foreach (KeyValuePair<int, Week> i in weeks)
            {
                labelHeader.Text = i.Value.month.name;
                dataGridViewMonth.Columns.Add(i.Key.ToString(), i.Key.ToString());
            }
            foreach (DataGridViewColumn col in dataGridViewMonth.Columns)
            {
                col.Width = cellWidth;                
            }            
            dataGridViewMonth.Rows.Add(3+courses);
            
            int c = 0;
            foreach (KeyValuePair<int, Week> i in weeks)
            {
                dataGridViewMonth.Rows[0].Cells[c].Value = i.Key;
                dataGridViewMonth.Rows[1].Cells[c].Value = i.Value.start;
                dataGridViewMonth.Rows[2].Cells[c++].Value = i.Value.end;
            }
            foreach (DataGridViewRow row in dataGridViewMonth.Rows)
            {
                row.Height = cellHeight;
            }
            if (this.dataGridViewMonth.ColumnCount != 0)
                this.Width = Convert.ToInt32(dataGridViewMonth.ColumnCount * cellWidth) + this.Padding.Horizontal + this.Padding.Left;
            else
                this.Width = this.Width;
        }

        public bool SetCellData(Week week, int course, string value)
        {
            int week_number;
            try
            {
                //if (!weeks.ContainsValue(week)) return false;
                
                week_number = weeks.First(x => Week.Compare(x.Value,week)).Key;

                int column_index = 0;
                foreach(DataGridViewCell cell in dataGridViewMonth.Rows[0].Cells)
                {
                    int cell_value = Convert.ToInt32(cell.Value);
                    if (cell_value == week_number)
                    {
                        column_index = cell.ColumnIndex;
                    }
                }
                dataGridViewMonth.Rows[course + 2].Cells[column_index].Value = value;
                return true;
            }
            catch
            {
                //MessageBox.Show("Ошибка заполнения ячейки");
                return false;
            }
        }
    }
}
