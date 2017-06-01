using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicPlan.Classes;
using System.Data;

namespace AcademicPlan.Interfaces
{
    public class DataControllerEPlan : IDataController
    {
        DataAccessConnector connector;
        public DataTable Discs;
        public DataTable Cycles;
        public DataTable StockValues;
        public DataTable SemesterTable;

        public event EventHandler DiscChanged;
        public event EventHandler CyclesChanged;
        public event EventHandler StockVChanged;
        public event EventHandler SemChanged;

        //public EventHandler DiscChanged
        //{
        //    get
        //    {
        //        return DiscChanged;
        //    }

        //    set
        //    {
        //        DiscChanged = value;
        //    }
        //}

        //public EventHandler CyclesChanged
        //{
        //    get
        //    {
        //        return CyclesChanged;
        //    }

        //    set
        //    {
        //        CyclesChanged = value;
        //    }
        //}

        //public EventHandler StockVChanged
        //{
        //    get
        //    {
        //        return StockVChanged;
        //    }

        //    set
        //    {
        //        StockVChanged = value;
        //    }
        //}

        //public EventHandler SemChanged
        //{
        //    get
        //    {
        //        return SemChanged;
        //    }

        //    set
        //    {
        //        SemChanged = value;
        //    }
        //}

        public void FinalUserData(ProjectBase userProject)
        {
            //throw new NotImplementedException();
        }

        public void InitUserData(ProjectBase userProject)
        {
            //throw new NotImplementedException();
        }

        public void LoadUserData(ProjectBase userProject)
        {
            //throw new NotImplementedException();
        }

        public void SaveUserData(ProjectBase userProject)
        {
            //throw new NotImplementedException();
        }

        public DataControllerEPlan()
        {
            connector = new DataAccessConnector();
            connector.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Plan.MDB;Mode=ReadWrite";
            Discs = new DataTable();
            Cycles = new DataTable();
            SemesterTable = new DataTable();
            StockValues = new DataTable();
        }

        public bool UpdateSemester(int Kaf, int Year, int Semester)
        {
            return connector.UpdateSemester(SemesterTable, Kaf, Year, Semester);
        }

        public bool SetDiscs()
        {
            Discs = connector.GetAllData(DataFields.DISC);
            if (Discs.Rows.Count == 0) return false;
            Discs.PrimaryKey = new DataColumn[] { Discs.Columns["Disc_ID"] };

            //Discs.Columns["Disc_ID"].AutoIncrementSeed = (int)Discs.Select("Disc_ID=MAX(Disc_ID)")[0]["Disc_ID"] + 1;
            Discs.Columns["Disc_ID"].AutoIncrementSeed = -1;
            Discs.Columns["Disc_ID"].AutoIncrementStep = -1;
            Discs.Columns["Disc_ID"].AutoIncrement = true;

            if (this.DiscChanged != null)
                DiscChanged(null, new DataBaseEventArguments(DataFields.DISC));
            return true;
        }

        public bool SetCycle()
        {
            Cycles = connector.GetAllData(DataFields.CYCLE);
            if (Cycles.Rows.Count == 0) return false;
            Cycles.PrimaryKey = new DataColumn[] { Cycles.Columns["Cycle_ID"] };

            //Cycles.Columns["Cycle_ID"].AutoIncrementSeed = (int)Cycles.Select("Cycle_ID=MAX(Cycle_ID)")[0]["Cycle_ID"] + 1;
            Cycles.Columns["Cycle_ID"].AutoIncrementSeed = -1;
            Cycles.Columns["Cycle_ID"].AutoIncrementStep = -1;
            Cycles.Columns["Cycle_ID"].AutoIncrement = true;

            if (this.CyclesChanged != null)
                CyclesChanged(null, new DataBaseEventArguments(DataFields.CYCLE));
            return true;
        }

        public bool SetStockValues()
        {
            StockValues = connector.GetStockData();
            if (StockValues == null) return false;
            StockValues.PrimaryKey = new DataColumn[] { StockValues.Columns[0], StockValues.Columns[1], StockValues.Columns[2] };
            StockValues.DefaultView.Sort = " Year desc, Semester asc, Department_ID asc";
            StockValues = StockValues.DefaultView.ToTable();
            StockValues.PrimaryKey = new DataColumn[] { StockValues.Columns[0], StockValues.Columns[1], StockValues.Columns[2] };

            if (this.StockVChanged != null)
                StockVChanged(null, new DataBaseEventArguments(DataFields.STOCK));
            return true;
        }

        public bool SetSemester(int Kaf, int Year, int Semester)
        {
            SemesterTable = connector.GetSemesterData(Kaf, Year, Semester);
            if (SemesterTable.Columns.Count == 0) return false;
            SemesterTable.PrimaryKey = new DataColumn[] { SemesterTable.Columns["Year"], SemesterTable.Columns["Semester"], SemesterTable.Columns["Department_ID"], SemesterTable.Columns["Disc_ID"] };

            if (this.SemChanged != null)
                SemChanged(null, new DataBaseEventArguments(DataFields.SEMESTERTABLE));
            return true;
        }

        public DataTable FilterValues(int Mask, params int[] param)
        {
            DataTable FilteredValues = new DataTable();
            var query = from row in StockValues.AsEnumerable()
                        select row;
            int count = 0;

            if ((Mask & (int)DataFields.KAF) == (int)DataFields.KAF)
            {

                int c = count++;
                query = from row in query
                        where row.Field<int>("Department_ID") == (int)param[c]
                        select row;

            }
            if ((Mask & (int)DataFields.YEAR) == (int)DataFields.YEAR)
            {
                int c = count++;

                query = from row in query
                        where row.Field<int>("Year") == (int)param[c]
                        select row;
            }
            if ((Mask & (int)DataFields.SEMESTER) == (int)DataFields.SEMESTER)
            {
                int c = count++;

                query = from row in query
                        where row.Field<int>("Semester") == (int)param[c]
                        select row;
            }

            if (query.Count() > 0)
                FilteredValues = query.CopyToDataTable();
            return FilteredValues;
        }

        public DataTable GenerateFilter(DataFields type, DataTable FilteredValues)
        {
            DataTable result = new DataTable();

            if (type == DataFields.YEAR || type == DataFields.SEMESTER)
            {
                string name = type == DataFields.YEAR ? "Year" : "Semester";
                var query = from row in FilteredValues.AsEnumerable()
                            group row by row.Field<int>(name) into g
                            select new { Value = g.Key, Name = g.First().Field<int>(name).ToString() };
                result.Columns.Add("ID", typeof(int));
                result.Columns.Add("Name", typeof(string));
                result.Rows.Add(-1, "-");
                foreach (var nameGroup in query)
                {
                    result.Rows.Add(nameGroup.Value, nameGroup.Name);
                }
            }

            else if (type == DataFields.KAF)
            {
                var query = from row in FilteredValues.AsEnumerable()
                            group row by row.Field<int>("Department_ID") into g
                            select new { Value = g.Key, Name = g.First().Field<string>("Department_Name") };
                result.Columns.Add("ID", typeof(int));
                result.Columns.Add("Name", typeof(string));
                result.Rows.Add(-1, "-");
                foreach (var nameGroup in query)
                {
                    result.Rows.Add(nameGroup.Value, nameGroup.Name);
                }
            }
            result.PrimaryKey = new DataColumn[] { result.Columns[0] };
            return result;
        }

        public bool UpdateSpravData(DataFields type)
        {
            if (type == DataFields.CYCLE)
                return connector.UpdateSpravData(Cycles, type);
            else if (type == DataFields.DISC)
                return connector.UpdateSpravData(Discs, type);
            return false;
        }
    }

    public class DataBaseEventArguments : EventArgs {
        public DataFields type;
        public DataBaseEventArguments(DataFields incomeType) : base() {
            type = incomeType;
        }
    }
}