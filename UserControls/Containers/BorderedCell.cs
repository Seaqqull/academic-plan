using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.UserControls
{
    public partial class BorderedCell : UserControl
    {
        const Byte BORDER_TOP = 1,
                    BORDER_RIGHT = 2,
                    BORDER_BOTTOM = 4,
                    BORDER_LEFT = 8;

        Int32 borderSize;
        Byte  borderStyle;

        Font fontBase, fontHover;
        Color colorBase, colorHover;

        Pen borderPen;
        Color borderColor;

        public BorderedCell()
        {
            InitializeComponent();

            borderSize = 5;
            borderColor = Color.Black;

            colorBase = Color.Black;
            colorHover = Color.Black;

            borderStyle = BORDER_TOP | BORDER_RIGHT | BORDER_BOTTOM | BORDER_LEFT;

            borderPen = new Pen(borderColor, borderSize);
            fontBase = fontHover = labelText.Font;
        }

        private void SetTextArea() {
            labelText.Location = new Point(borderSize, borderSize);
            labelText.Size = new Size(this.Width - borderSize * 2, this.Height - borderSize * 2);
        }

        private void BorderedCell_Paint(object sender, PaintEventArgs e)
        {
            if (borderStyle != 0)
            {
                Graphics currentGraphic = e.Graphics;

                if ((borderStyle & BORDER_TOP) != 0)
                {
                    currentGraphic.DrawLine(borderPen, new PointF(0, borderSize / 2.0f), new PointF(this.Width, borderSize / 2.0f));
                }
                if ((borderStyle & BORDER_RIGHT) != 0)
                {
                    currentGraphic.DrawLine(borderPen, new PointF(this.Width - borderSize / 2.0f, 0), new PointF(this.Width - borderSize / 2.0f, this.Height));
                }
                if ((borderStyle & BORDER_BOTTOM) != 0)
                {
                    currentGraphic.DrawLine(borderPen, new PointF(0, this.Height - borderSize / 2.0f), new PointF(this.Width, this.Height - borderSize / 2.0f));
                }
                if ((borderStyle & BORDER_LEFT) != 0)
                {
                    currentGraphic.DrawLine(borderPen, new PointF(borderSize / 2.0f, 0), new PointF(borderSize / 2.0f, this.Height));
                }
            }
        }

        private void labelText_MouseLeave(object sender, EventArgs e)
        {
            SetFontText(false);            
        }

        private void labelText_MouseMove(object sender, MouseEventArgs e)
        {
            SetFontText(true);
        }

        private void BorderedCell_SizeChanged(object sender, EventArgs e)
        {
            SetTextArea();
        }

        private void SetFontText(bool isHover)
        {
            if (isHover)
            {
                this.labelText.Font = fontHover;
                this.labelText.ForeColor = colorHover;
            }
            else {
                this.labelText.Font = fontBase;
                this.labelText.ForeColor = colorBase;
            }
            
        }

        [DisplayName(@"Cursor"), Description("Курсор при наведении"), Category("Настройки отображения")]
        public Cursor CursorLabel
        {
            get
            {
                return labelText.Cursor;
            }

            set
            {
                labelText.Cursor = value;                
            }
        }

        [DisplayName(@"ColorDefault"), Description("Цвет шрифта по умолчанию"), Category("Настройки отображения")]
        public Color FontColorDefault
        {
            get
            {
                return colorBase;
            }

            set
            {
                colorBase = value;
                SetFontText(false);
            }
        }
        [DisplayName(@"ColorHover"), Description("Цвет шрифта при наведении"), Category("Настройки отображения")]
        public Color FontColorHover
        {
            get
            {
                return colorHover;
            }

            set
            {
                colorHover = value;
                SetFontText(false);
            }
        }

        [DisplayName(@"FontDefault"), Description("Стиль шрифта по умолчанию"), Category("Настройки отображения")]
        public Font FontTextDefault
        {
            get
            {
                return fontBase;
            }

            set
            {
                fontBase = value;
                SetFontText(false);
            }
        }
        [DisplayName(@"FontHover"), Description("Стиль шрифта при наведении"), Category("Настройки отображения")]
        public Font FontTextHover
        {
            get
            {
                return fontHover;
            }

            set
            {
                fontHover = value;
                SetFontText(false);
            }
        }

        [DisplayName(@"TextAlign"), Description("Выравнивание текста"), Category("Настройки отображения")]
        public ContentAlignment LabelTextAlign
        {
            get
            {
                return labelText.TextAlign;
            }

            set
            {
                labelText.TextAlign = value;
            }
        }
        [DisplayName(@"Text"), Description("Текст"), Category("Настройки отображения")]
        public String LabelText
        {
            get
            {
                return labelText.Text;
            }

            set
            {
                labelText.Text = value;                
            }
        }

        [DisplayName(@"ColorBorder"), Description("Цвет границы"), Category("Настройки отображения")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                borderPen = new Pen(borderColor, borderSize);
                this.Invalidate();
            }
        }
        [DisplayName(@"SizeBorder"), Description("Размер границы"), Category("Настройки отображения")]
        public Int32 BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                borderPen.Width = borderSize;
                SetTextArea();
                this.Invalidate();
            }
        }

        [DisplayName(@"BorderTop"), Description("Граница сверху"), Category("Настройки отображения")]
        public bool IsTopBorder
        {
            get
            {
                return (borderStyle & BORDER_TOP) == 0? false : true;
            }

            set
            {
                if (value == true && (borderStyle & BORDER_TOP) == 0)
                {
                    borderStyle |= BORDER_TOP;
                }
                else if(value == false)
                {
                    borderStyle ^= BORDER_TOP;
                }
                this.Invalidate();
            }
        }
        [DisplayName(@"BorderRight"), Description("Граница справа"), Category("Настройки отображения")]
        public bool IsRightBorder
        {
            get
            {
                return (borderStyle & BORDER_RIGHT) == 0 ? false : true;
            }

            set
            {
                if (value == true && (borderStyle & BORDER_RIGHT) == 0)
                {
                    borderStyle |= BORDER_RIGHT;
                }
                else if (value == false)
                {
                    borderStyle ^= BORDER_RIGHT;
                }
                this.Invalidate();
            }
        }
        [DisplayName(@"BorderBottom"), Description("Граница внизу"), Category("Настройки отображения")]
        public bool IsBottomBorder
        {
            get
            {
                return (borderStyle & BORDER_BOTTOM) == 0 ? false : true;
            }

            set
            {
                if (value == true && (borderStyle & BORDER_BOTTOM) == 0)
                {
                    borderStyle |= BORDER_BOTTOM;
                }
                else if (value == false)
                {
                    borderStyle ^= BORDER_BOTTOM;
                }
                this.Invalidate();
            }
        }
        [DisplayName(@"BorderLeft"), Description("Граница слева"), Category("Настройки отображения")]
        public bool IsLeftBorder
        {
            get
            {
                return (borderStyle & BORDER_LEFT) == 0 ? false : true;
            }

            set
            {
                if (value == true && (borderStyle & BORDER_LEFT) == 0)
                {
                    borderStyle |= BORDER_LEFT;
                }
                else if (value == false)
                {
                    borderStyle ^= BORDER_LEFT;
                }
                this.Invalidate();
            }
        }
        public void MakeTitle(string Year, string Sem, string Kaf) {
            this.LabelText = "Год: " + Year + ". Семестр: " + Sem + ". Кафедра: " + Kaf + ".";
        }
    }
}
