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

namespace AcademicPlan.Dialogs
{
    public partial class NewSemestr : MetroForm
    {
        int kaf_id;
        DataTable StockData;
        public NewSemestr()
        {
            InitializeComponent();
        }

        public NewSemestr(int kaf_id, DataTable StockData)
        {
            this.kaf_id = kaf_id;
            this.StockData = StockData;
            InitializeComponent();
        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            if (StockData.Rows.Find(new object[] { (int)Year.Value, (int)Semester.Value, kaf_id }) != null)
            {
                MessageBox.Show("Такой семестр уже заполнен!!! Выберите другой или отредактируйте этот в основном окне!!!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
