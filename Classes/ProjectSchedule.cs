using AcademicPlan.Interfaces;
using AcademicPlan.UserControls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    public class ProjectSchedule : ProjectBase
    {
        Int32 weekSize = 7; //должно быть нечетным
        Int32 year; //год составления графика        
        Int32 startDate; //число начала учебы
        Int32 courses; //значение 1 если 5й курс, 4 если 4 курса
        Month startMonth; //месяц начала учебы
        Month endMonthSem; //месяц в котором кончается первый семестр
        Dictionary<Int32, Month> months; //список месяцев
        List<Week> weeks; //список учебных недель, рассчитанных из календарного года

        public ProjectSchedule(WindowMain incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, String incomeTitle, IDataController incomeDataController, IRelation incomeRelation) : base(incomeMain, inWindowContainer, incomeWindow, incomeTitle, incomeDataController, incomeRelation)
        {
            months = new Dictionary<int, Month>();
            months.Add(1, new Month(1, "Январь", 31));
            if (DateTime.IsLeapYear(DateTime.Now.Year))
                months.Add(2, new Month(2, "Февраль", 29));
            else
                months.Add(2, new Month(2, "Февраль", 28));
            months.Add(3, new Month(3, "Март", 31));
            months.Add(4, new Month(4, "Апрель", 30));
            months.Add(5, new Month(5, "Май", 31));
            months.Add(6, new Month(6, "Июнь", 30));
            months.Add(7, new Month(7, "Июль", 31));
            months.Add(8, new Month(8, "Август", 31));
            months.Add(9, new Month(9, "Сентябрь", 30));
            months.Add(10, new Month(10, "Октябрь", 31));
            months.Add(11, new Month(11, "Ноябрь", 30));
            months.Add(12, new Month(12, "Декабрь", 31));
            weeks = new List<Week>();
            ((WindowTabControlEProcess)incomeWindow).ClassWindow = this;
        }

        //рассчитывает учебные недели в календаре
        public void CalculateSchedule()
        {
            weeks = new List<Week>();
            int weeks_count = 0;
            int current_day = startDate;
            Month current_month = startMonth;
            int weeks_in_year = GetWeeksInYear();
            while (weeks_count < weeks_in_year)
            {
                if (current_day < (current_month.days_count - weekSize + 1)) //неделя полностью в месяце
                {
                    weeks.Add(new Week(current_day, current_day + weekSize - 1, current_month));
                    current_day += weekSize;
                    weeks_count++;
                }
                else if (current_day == (current_month.days_count - weekSize + 1)) //последний день недели четко в конце месяца
                {
                    weeks.Add(new Week(current_day, current_day + weekSize - 1, current_month));
                    current_day = 1;
                    current_month = GetNextMonth(current_month);
                    weeks_count++;
                }
                else if (current_day > (current_month.days_count - weekSize + 1) &&
                    current_day <= (current_month.days_count - Convert.ToInt32(Math.Floor(weekSize / 2f)))) //большая половина недели в месяце
                {
                    int rest = weekSize - (current_month.days_count - current_day + 1);
                    weeks.Add(new Week(current_day, rest, current_month));
                    current_day = rest + 1;
                    current_month = GetNextMonth(current_month);
                    weeks_count++;
                }
                else if (current_day > (current_month.days_count - Convert.ToInt32(Math.Floor(weekSize / 2f))) &&
                    current_day <= current_month.days_count) //меньшая половина недели в месяце
                {
                    int rest = weekSize - (current_month.days_count - current_day + 1);
                    weeks.Add(new Week(current_day, rest, GetNextMonth(current_month)));
                    current_day = rest + 1;
                    current_month = GetNextMonth(current_month);
                    weeks_count++;
                }
            }
            ((WindowTabControlEProcess)Window).SetMonthViews();
        }
        //возвращает месяц, идущий следующим за переданным в аргументах (если передан последний, вернет первый)
        public Month GetNextMonth(Month month)
        {
            if (month.id == 12)
                return months[1];
            else
                return months[month.id + 1];
        }
        //возвращает словарь с неделями указанного месяца (ключи - номер п/п недели в общем списке)
        public Dictionary<Int32, Week> GetWeeksOfMonth(Month month)
        {
            int start = weeks.FindIndex(item => item.month.id == month.id);
            int end = start;
            Dictionary<int, Week> result = new Dictionary<int, Week>();
            bool changed = false;
            while (true)
            {
                changed = false;
                if (end == weeks.Count - 1)
                {
                    changed = true;
                    end = -1;
                }
                if (weeks[end + 1].month.id == month.id)
                {
                    end++;
                }
                else
                {
                    if (!changed)
                        break;
                    else
                    {
                        end = weeks.Count - 1;
                        break;
                    }
                }
            }
            while (true)
            {
                changed = false;
                if (start == 0)
                {
                    changed = true;
                    start = weeks.Count;

                }
                if (weeks[start - 1].month.id == month.id)
                {
                    start--;
                }
                else
                {
                    if (!changed)
                        break;
                    else
                    {
                        start = 0;
                        break;
                    }
                }
            }
            while (start != end)
            {
                result.Add(start + 1, weeks[start]);
                if (start < weeks.Count - 1)
                {
                    start++;
                }
                else
                {
                    start = 0;
                }
            }
            result.Add(end + 1, weeks[end]);
            return result;
        }
        //возвращает сумму дней в списке месяцев
        private Int32 GetDaysCount(List<Month> incomeMonths)
        {
            int sum = 0;
            foreach (Month month in incomeMonths)
            {
                sum += month.days_count;
            }
            return sum;
        }

        public Int32 GetWeeksInYear()
        {
            return Convert.ToInt32(Math.Floor(GetDaysCount(Months.Values.ToList<Month>()) / weekSize * 1f));
        }

        public override void LoadDataInView()
        {
            ((WindowTabControlEProcess)Window).SetStartData();
            ((WindowTabControlEProcess)Window).SetScheduleData();
        }

        public override void ClearDataInView()
        {
            throw new NotImplementedException();
        }

        // Property
        public int WeekSize
        {
            get
            {
                return weekSize;
            }

            set
            {
                weekSize = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public int StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public int Courses
        {
            get
            {
                return courses;
            }

            set
            {
                courses = value;
            }
        }

        public Month StartMonth
        {
            get
            {
                return startMonth;
            }

            set
            {
                startMonth = value;
            }
        }

        public Month EndMonthSem
        {
            get
            {
                return endMonthSem;
            }

            set
            {
                endMonthSem = value;
            }
        }

        public Dictionary<int, Month> Months
        {
            get
            {
                return months;
            }

            set
            {
                months = value;
            }
        }

        public List<Week> Weeks
        {
            get
            {
                return weeks;
            }

            set
            {
                weeks = value;
            }
        }
    }
}
