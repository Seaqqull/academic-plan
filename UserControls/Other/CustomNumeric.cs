using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AcademicPlan.UserControls
{
    public partial class CustomNumeric : MetroUserControl
    {
        private Decimal numberCurrent, numberMin, numberMax, step, places;

        public decimal CurrentNumber
        {
            get
            {
                return numberCurrent;
            }

            set
            {
                numberCurrent = value;
            }
        }

        public decimal MinNumber
        {
            get
            {
                return numberMin;
            }

            set
            {
                numberMin = value;
            }
        }

        public decimal MaxNumber
        {
            get
            {
                return numberMax;
            }

            set
            {
                numberMax = value;
            }
        }

        public decimal StepIncrement
        {
            get
            {
                return step;
            }

            set
            {
                step = value;
            }
        }

        public decimal Places
        {
            get
            {
                return places;
            }

            set
            {
                places = value;
            }
        }

        private void CustomNumeric_Paint(object sender, PaintEventArgs e)
        {
            //metroTextBoxValue.Text = numberCurrent.ToString();
            labelNumValue.Text = CurrentNumber.ToString();
        }

        public CustomNumeric()
        {
            InitializeComponent();
            
            this.numberCurrent = 0;
            this.numberMin = 0;
            this.numberMax = 100;
            this.step = 1;
        }


    }
}
