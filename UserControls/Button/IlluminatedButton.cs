using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan
{
    public partial class IlluminatedButton : UserControl
    {
        private static List<IlluminatedButton> groupList;        

        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;

        private Color colorLabelUnselected, colorLabelSelected, colorButtonSelected;

        private Int32 sizeUnderline, currentGroup;

        private bool isSelected;

        public IlluminatedButton()
        {
            InitializeComponent();

            this.CurrentGroup = 0;
            this.SizeUnderline = 5;
            this.IsSelected = false;
            this.ColorLabelUnselected = Color.White;
            this.ColorLabelSelected = Color.Black;
            this.colorButtonSelected = Color.White;
            this.buttonIlluminated.Click += new EventHandler(buttonIlluminated_Click);

            groupList = new List<IlluminatedButton>();
            //groupList 
        }        

        private void IlluminatedButton_BackColorChanged(object sender, EventArgs e)
        {
            buttonIlluminated.BackColor = this.BackColor;
            // method back color
        }

        private void buttonIlluminated_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
            //SetColorButton();

            if (IsSelected == true)
                ClearGroup();

            if (OnUserControlButtonClicked != null)
                OnUserControlButtonClicked(this, e);            
        }

        [DisplayName(@"MouseDownBackColor"), Description("Цвет кнопки при щелчке мышью"), Category("Flat appearance")]
        public Color MouseDownBackColor
        {
            get
            {
                return buttonIlluminated.FlatAppearance.MouseDownBackColor;
            }
            set
            {
                buttonIlluminated.FlatAppearance.MouseDownBackColor = value;
            }

        }

        [DisplayName(@"MouseOverBackColor"), Description("Цвет кнопки при наведении указателя мыши"), Category("Flat appearance")]
        public Color MouseOverBackColor
        {
            get
            {
                return buttonIlluminated.FlatAppearance.MouseOverBackColor;
            }
            set
            {
                buttonIlluminated.FlatAppearance.MouseOverBackColor = value;
            }

        }

        [DisplayName(@"IsSelectedButton"), Description("Активна ли кнопка"), Category("Настройки отображения")]
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }

            set
            {
                isSelected = value;
                SetColorLabel();
                SetColorButton();
            }
        }

        [DisplayName(@"UnderlineColorUnSelected"), Description("Цвет неактивного подчеркивания"), Category("Настройки отображения")]
        public Color ColorLabelUnselected
        {
            get
            {
                return colorLabelUnselected;
            }

            set
            {
                colorLabelUnselected = value;
                SetColorLabel();
            }
        }

        [DisplayName(@"UnderlineColorSelected"), Description("Цвет активного подчеркивания"), Category("Настройки отображения")]
        public Color ColorLabelSelected
        {
            get
            {
                return colorLabelSelected;
            }

            set
            {
                colorLabelSelected = value;
                SetColorLabel();
            }
        }

        [DisplayName(@"UnderlineStyle"), Description("Стиль подчеркивания"), Category("Настройки отображения")]
        public DockStyle CurrentButtonStyle
        {
            get
            {
                return labelIlluminated.Dock;
            }

            set
            {
                if (value != labelIlluminated.Dock && (value != DockStyle.Fill && value != DockStyle.None)) {
                    labelIlluminated.Dock = value;
                    SetSizeLabel();
                }                
            }
        }

        [DisplayName(@"UnderlineSize"), Description("Размер подчеркивания"), Category("Настройки отображения")]
        public int SizeUnderline
        {
            get
            {
                return sizeUnderline;
            }

            set
            {
                sizeUnderline = value;
                SetSizeLabel();
            }
        }

        [DisplayName(@"ColorButtonSelected"), Description("Цвет активной кнопки"), Category("Настройки отображения")]
        public Color ColorButtonSelected
        {
            get
            {
                return colorButtonSelected;
            }

            set
            {
                colorButtonSelected = value;
                SetColorButton();
            }
        }

        [DisplayName(@"Text"), Description("Текст"), Category("Настройки отображения")]
        public String TextButton {
            get {
                return buttonIlluminated.Text;
            }
            set {
                buttonIlluminated.Text = value;
            }
        }

        [DisplayName(@"CurrentGroup"), Description("Группа, в которой находиться элемент. 0 - отсутствие группы, 1+ группа."), Category("Настройки отображения")]
        public int CurrentGroup
        {
            get
            {
                return currentGroup;
            }

            set// 0 - не в группе, > 0 любая группа
            {
                if (value > 0 && currentGroup == 0)
                    groupList.Add(this); 
                else if (value == 0 && currentGroup > 0)
                    groupList.Remove(this);      
                                                                                    
                currentGroup = value;
            }
        }


        private void ClearGroup() {
            for (int i = 0; i < groupList.Count; i++)
                if (groupList[i].CurrentGroup == this.CurrentGroup && groupList[i].Name != this.Name /*&& groupList[i].Parent == this.Parent*/)
                    groupList[i].IsSelected = false;
        }

        private void SetColorLabel()
        {
            if (isSelected == true)
                labelIlluminated.BackColor = colorLabelSelected;
            else
                labelIlluminated.BackColor = colorLabelUnselected;
        }

        private void SetSizeLabel()
        {
            if (labelIlluminated.Dock == DockStyle.Left || labelIlluminated.Dock == DockStyle.Right)
                labelIlluminated.Width = sizeUnderline;
            else
                labelIlluminated.Height = sizeUnderline;
        }

        private void SetColorButton() {
            if (isSelected == true)
                buttonIlluminated.BackColor = colorButtonSelected;
            else
                buttonIlluminated.BackColor = this.BackColor;
        }
    }
}
