using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    [Serializable]
    public class Month
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public int days_count { get; private set; }
        public Month(int id, string name, int days_count)
        {
            this.id = id;
            this.name = name;
            this.days_count = days_count;
        }
    }
    [Serializable]
    public class Week
    {
        public Month month { get; private set; }
        public int start { get; private set; }
        public int end { get; private set; }
        public static bool Compare(Week w1, Week w2)
        {
            if ((w1.month.id == w2.month.id) && (w1.start == w2.start) && (w1.end == w2.end))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Week(int start, int end, Month month)
        {
            this.start = start;
            this.end = end;
            this.month = month;
        }
    }
    [Serializable]
    public class ScheduleKey
    {
        public Month month;
        public Week week;
        public int course;
        public ScheduleKey(Month m, Week w, int c)
        {
            month = m;
            week = w;
            course = c;
        }
        public override int GetHashCode()
        {
            int hash = month.id + week.start + course;
            return hash;
        }
        public override bool Equals(object obj)
        {
            ScheduleKey sk = obj as ScheduleKey;
            return this.course == sk.course && this.month.id == sk.month.id && Week.Compare(this.week, sk.week);
        }
    }
    [Serializable]
    public class ScheduleData
    {
        //данные о графике (ключ - дата, значение - символ)
        public Dictionary<ScheduleKey, string> data { get; private set; } 
        // начальные данные для формирования графика
        public Month start_month;
        public int start_date;
        public Month end_month_sem1;
        public int courses;
        public int year;
        //реализация синглтона
        private static ScheduleData instance;
        //возвращает данные по ключу
        public string GetData(Month month, Week week, int course)
        {
            ScheduleKey sk = new ScheduleKey(month, week, course);
            if (data.ContainsKey(sk))
            {
                return data[sk];
            }
            else
            {
                return null;
            }
        }
        //записывает данные по ключу
        public bool SetData(Month month, Week week, int course, string value)
        {
            ScheduleKey sk = new ScheduleKey(month, week, course);
            if (data.ContainsKey(sk))
            {
                data[sk] = value;
                return true;
            }
            else
            {
                data.Add(sk, value);
                return false;
            }
        }
        private ScheduleData()
        {
            data = new Dictionary<ScheduleKey, string>();
        }
        //выгрузка данных из бинарного файла
        public bool LoadDataFromBinary(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                stream.Position = 0;
                ScheduleData.instance = (ScheduleData)formatter.Deserialize(stream);
                stream.Close();
                return true;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Ошибка загрузки файла");
                return false;
            }
        }
        //сохранение данных в бинарный файл
        public bool SaveDataToBinary(string path)
        {
            
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ScheduleData.Instance);
                stream.Close();
                return true; 
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(MetroFramework.Forms.MetroForm.ActiveForm, "Ошибка сохранения файла");
                return false;
            }
        }
        public static ScheduleData Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScheduleData();
                return instance;
            }
            private set
            {}
        }
    }
}
