using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    
    class DataAccessConnector
    {
        public string ConnectionString;
        public OleDbConnection conn;

        public DataAccessConnector()
        {
            conn = null;

        }

        public bool Connect()
        {
            try
            {
                if (conn != null) conn.Dispose();
                conn = new OleDbConnection(ConnectionString);
                conn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public DataTable GetAllData(DataFields field)
        {
            string command_str = "SELECT * FROM ";
            string table_name = " ";
            DataTable result = new DataTable();
            OleDbDataReader reader = null;
            if (field == DataFields.CYCLE) table_name = "Cycle";
            else if (field == DataFields.DISC) table_name = "Discipline";

            command_str += table_name;
            try
            {
                Connect();
                OleDbCommand cmd = new OleDbCommand(command_str, conn);
                reader = cmd.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null) reader.Close();

            }
            return result;
        }

        public DataTable GetStockData()
        {
            string command_str = "SELECT Year, Semester, Nagruzka.Department_ID as Department_ID, Department_Name FROM Nagruzka LEFT JOIN Department ON  Nagruzka.Department_ID=Department.Department_ID " +
                                 "GROUP BY Year, Semester, Nagruzka.Department_ID, Department_Name ";
            DataTable result = new DataTable();
            OleDbDataReader reader = null;
            try
            {
                Connect();
                OleDbCommand cmd = new OleDbCommand(command_str, conn);
                reader = cmd.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                result = null;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            return result;
        }

        public DataTable GetSemesterData(int Kaf, int Year, int Semester)
        {
            string command_str = "SELECT *  FROM Nagruzka  WHERE Year=" + Year.ToString() + " AND Semester=" + Semester.ToString() +
                                 " AND Department_ID=" + Kaf.ToString();

            DataTable result = new DataTable();

            try
            {
                Connect();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command_str, conn);
                adapt.Fill(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public bool UpdateSemester(DataTable semester, int Kaf, int Year, int Semester_Number)
        {
            string command_str = "SELECT [Year], [Semester], [Department_ID], [Disc_ID], [Cycle_ID], [Norm], [Bachelor], [Kursovaya], [KKS], [LK], [LZ], [PZ], [Weeks]  FROM Nagruzka  WHERE [Year]=" + Year.ToString() + " AND [Semester]=" + Semester_Number.ToString() +
                                 " AND [Department_ID]=" + Kaf.ToString();

            if (!Connect()) return false;
            OleDbDataAdapter adapt = new OleDbDataAdapter(command_str, conn);
            OleDbCommandBuilder comand_b = new OleDbCommandBuilder(adapt);
            comand_b.QuotePrefix = "[";
            comand_b.QuoteSuffix = "]";
            adapt.DeleteCommand = comand_b.GetDeleteCommand();
            adapt.InsertCommand = comand_b.GetInsertCommand();
            adapt.UpdateCommand = comand_b.GetUpdateCommand();
            OleDbTransaction trans = conn.BeginTransaction();
            if (trans == null) MessageBox.Show("Нулл");
            try
            {
                adapt.InsertCommand.Transaction = trans; //null object error here
                adapt.UpdateCommand.Transaction = trans;
                adapt.DeleteCommand.Transaction = trans;
                adapt.AcceptChangesDuringUpdate = false;
                adapt.Update(semester);
                trans.Commit();
                semester.AcceptChanges();
            }
            catch (Exception e)
            {
                trans.Rollback();
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public bool UpdateSpravData(DataTable table, DataFields type)
        {
            if (type != DataFields.DISC && type != DataFields.CYCLE) return false;
            string table_name = "";
            if (type == DataFields.DISC) table_name = "Discipline";
            else if (type == DataFields.CYCLE) table_name = "Cycle";
            string command_str = "SELECT * FROM " + table_name;

            if (!Connect()) return false;
            OleDbDataAdapter adapt = new OleDbDataAdapter(command_str, conn);
            OleDbCommandBuilder comand_b = new OleDbCommandBuilder(adapt);
            comand_b.QuotePrefix = "[";
            comand_b.QuoteSuffix = "]";
            adapt.DeleteCommand = comand_b.GetDeleteCommand();
            adapt.InsertCommand = comand_b.GetInsertCommand();
            adapt.UpdateCommand = comand_b.GetUpdateCommand();
            OleDbTransaction trans = conn.BeginTransaction();
            try
            {
                adapt.InsertCommand.Transaction = trans;
                adapt.UpdateCommand.Transaction = trans;
                adapt.DeleteCommand.Transaction = trans;
                adapt.AcceptChangesDuringUpdate = false;
                adapt.Update(table);
                trans.Commit();
                table.AcceptChanges();
            }
            catch (Exception e)
            {
                trans.Rollback();
                MessageBox.Show("Не удалось обновить справочные данные! Причина:\n" + e.Message);
                return false;
            }
            return true;
        }

    }
}
