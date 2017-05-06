using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicPlan.Classes;

namespace AcademicPlan
{
    public partial class MonthView : UserControl
    {
        const int padding = 3;
        public Month month;
        private int courses;
        private string tool_active;
        private Dictionary<int, Week> weeks;
        private int cell_width = 26;
        private int cell_height = 23;
        public MonthView()
        {
            InitializeComponent();
            tool_active = "";
        }
        private void MonthView_Load(object sender, EventArgs e)
        {
        }
        public int GetWidth()
        {
            return (cell_width + 3) * weeks.Count + padding * 2;
        }
        public void SetText(string text)
        {
            labelMonth.Text = text;
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
                MessageBox.Show("Пустой список недель", "Ошибка списка");
                return false;
            }
            SetDataView(courses);
            this.Width = (cell_width + 3) * weeks.Count + padding * 2;
            dataGridView1.Location = new Point(padding, dataGridView1.Location.Y);
            dataGridView1.Width = (cell_width+3) * weeks.Count;
            labelMonth.Location = new Point(padding, labelMonth.Location.Y);
            labelMonth.Width = (cell_width + 3) * weeks.Count;
            dataGridView1.Height = cell_height * (3+courses);
            DataGridViewCellStyle cell_style = new DataGridViewCellStyle(dataGridView1.Rows[0].DefaultCellStyle);
            cell_style.BackColor = Color.LightBlue;
            cell_style.SelectionBackColor = Color.LightBlue;
            dataGridView1.Rows[0].DefaultCellStyle = cell_style;
            return true;
        }
        private void SetDataView(int courses)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            foreach (KeyValuePair<int, Week> i in weeks)
            {
                labelMonth.Text = i.Value.month.name;
                dataGridView1.Columns.Add(i.Key.ToString(), i.Key.ToString());
            }
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = cell_width;
            }
            dataGridView1.Rows.Add(3+courses);
            int c = 0;
            foreach (KeyValuePair<int, Week> i in weeks)
            {
                dataGridView1.Rows[0].Cells[c].Value = i.Key;
                dataGridView1.Rows[1].Cells[c].Value = i.Value.start;
                dataGridView1.Rows[2].Cells[c++].Value = i.Value.end;
            }
        }
        public void SetActiveTool(string tool)
        {
            tool_active = tool;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (tool_active != "")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = tool_active;
                        ScheduleData.Instance.SetData(month, weeks.ElementAt(e.ColumnIndex).Value, e.RowIndex - 2, tool_active);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                    ScheduleData.Instance.SetData(month, weeks.ElementAt(e.ColumnIndex).Value, e.RowIndex - 2, "");
                }
            }
        }
        public bool SetCellData(Week week, int course, string value)
        {
            try
            {
                int week_number = weeks.First(x => Week.Compare(x.Value,week)).Key;
                int column_index = 0;
                foreach(DataGridViewCell cell in dataGridView1.Rows[0].Cells)
                {
                    int cell_value = Convert.ToInt32(cell.Value);
                    if (cell_value == week_number)
                    {
                        column_index = cell.ColumnIndex;
                    }
                }
                dataGridView1.Rows[course + 2].Cells[column_index].Value = value;
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения ячейки");
                return false;
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (this.dataGridView1.ColumnCount != 0)
                this.Width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3;
            else
                this.Width = this.Width;

            //if (this.dataGridView1.RowCount != 0)
            //    this.Height = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 3 + labelMonth.Height;
            //else
            //    this.Height = this.Height;
        }
    }
}
