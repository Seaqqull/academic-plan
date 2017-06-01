using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AcademicPlan.UserControls
{
    public enum ArrowButtonStyle
    {
        Up,
        Right,
        Down,
        Left
    }
    public partial class ArrowButton : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;

        ArrowButtonStyle currentButtonStyle;

        private Color colorArrow;
        private Bitmap imageUp, imageRight, imageDown, imageLeft, imageFilteredBitmap;
        private Graphics imageGraphic;
        // 
        private ImageAttributes imageAttributes;
        private ColorMatrix imageColorMatrix;
        private Single[][] imageColorMatrixElements;

        public ArrowButton()
        {
            InitializeComponent();
            this.CurrentButtonStyle = ArrowButtonStyle.Up;
            buttonArrow.Click += new EventHandler(buttonArrow_Click);
        }

        private void ArrowButton_BackColorChanged(object sender, EventArgs e)
        {
            buttonArrow.BackColor = this.BackColor;
        }

        [DisplayName(@"ArrowColor"), Description("Цвет стрелки"), Category("Настройки отображения")]
        public Color ArrowColor
        {
            get
            {
                return colorArrow;
            }

            set
            {
                if (value == null)
                    value = Color.White;
                colorArrow = value;
                SetColorFilter(colorArrow.R / 255.0f, colorArrow.G / 255.0f, colorArrow.B / 255.0f);
                SupCFilterOnImage(GetCurrentImage());
            }
        }

        [DisplayName(@"ArrowType"), Description("Вид стрелки"), Category("Настройки отображения"), DefaultValue(ArrowButtonStyle.Up)]
        public ArrowButtonStyle CurrentButtonStyle
        {
            get
            {
                return currentButtonStyle;
            }

            set
            {
                if (value != currentButtonStyle)
                {
                    currentButtonStyle = value;
                    SupCFilterOnImage(GetCurrentImage());
                }
            }
        }

        [DisplayName(@"ImageUp"), Description("Изображение Up"), Category("Настройки отображения")]
        public Bitmap ImageUp
        {
            get
            {
                return imageUp;
            }

            set
            {
                imageUp = value;
                if(IsCurrentImage(ArrowButtonStyle.Up) == true)
                    SupCFilterOnImage(GetCurrentImage());
            }
        }

        [DisplayName(@"ImageRight"), Description("Изображение Right"), Category("Настройки отображения")]
        public Bitmap ImageRight
        {
            get
            {
                return imageRight;
            }

            set
            {
                imageRight = value;
                if (IsCurrentImage(ArrowButtonStyle.Right) == true)
                    SupCFilterOnImage(GetCurrentImage());
            }
        }

        [DisplayName(@"ImageDown"), Description("Изображение Down"), Category("Настройки отображения")]
        public Bitmap ImageDown
        {
            get
            {
                return imageDown;
            }

            set
            {
                imageDown = value;
                if (IsCurrentImage(ArrowButtonStyle.Down) == true)
                    SupCFilterOnImage(GetCurrentImage());
            }
        }

        [DisplayName(@"ImageLeft"), Description("Изображение Left"), Category("Настройки отображения")]
        public Bitmap ImageLeft
        {
            get
            {
                return imageLeft;
            }

            set
            {
                imageLeft = value;
                if (IsCurrentImage(ArrowButtonStyle.Left) == true)
                    SupCFilterOnImage(GetCurrentImage());
            }
        }

        [DisplayName(@"MouseDownBackColor"), Description("Цвет кнопки при щелчке мышью"), Category("Flat appearance")]
        public Color MouseDownBackColor
        {
            get {
                return buttonArrow.FlatAppearance.MouseDownBackColor;
            }
            set {
                buttonArrow.FlatAppearance.MouseDownBackColor = value;
            }

        }

        [DisplayName(@"MouseOverBackColor"), Description("Цвет кнопки при наведении указателя мыши"), Category("Flat appearance")]
        public Color MouseOverBackColor
        {
            get
            {
                return buttonArrow.FlatAppearance.MouseOverBackColor;
            }
            set
            {
                buttonArrow.FlatAppearance.MouseOverBackColor = value;
            }

        }

        public void ClockwiseButtonStyle() {
            switch (currentButtonStyle)
            {
                case ArrowButtonStyle.Up:
                    CurrentButtonStyle = ArrowButtonStyle.Right;
                    break;
                case ArrowButtonStyle.Right:
                    CurrentButtonStyle = ArrowButtonStyle.Down;
                    break;
                case ArrowButtonStyle.Down:
                    CurrentButtonStyle = ArrowButtonStyle.Left;
                    break;
                case ArrowButtonStyle.Left:
                    CurrentButtonStyle = ArrowButtonStyle.Up;
                    break;
                default:
                    break;
            }
        }

        public void CounterClockwiseButtonStyle()
        {
            switch (currentButtonStyle)
            {
                case ArrowButtonStyle.Up:
                    CurrentButtonStyle = ArrowButtonStyle.Left;
                    break;
                case ArrowButtonStyle.Right:
                    CurrentButtonStyle = ArrowButtonStyle.Up;
                    break;
                case ArrowButtonStyle.Down:
                    CurrentButtonStyle = ArrowButtonStyle.Right;
                    break;
                case ArrowButtonStyle.Left:
                    CurrentButtonStyle = ArrowButtonStyle.Down;
                    break;
                default:
                    break;
            }
        }

        public void OppositeButtonStyle()
        {
            switch (currentButtonStyle)
            {
                case ArrowButtonStyle.Up:
                    CurrentButtonStyle = ArrowButtonStyle.Down;
                    break;
                case ArrowButtonStyle.Right:
                    CurrentButtonStyle = ArrowButtonStyle.Left;
                    break;
                case ArrowButtonStyle.Down:
                    CurrentButtonStyle = ArrowButtonStyle.Up;
                    break;
                case ArrowButtonStyle.Left:
                    CurrentButtonStyle = ArrowButtonStyle.Right;
                    break;
                default:
                    break;
            }
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            if (OnUserControlButtonClicked != null)
                OnUserControlButtonClicked(this, e);
        }

        private void SetColorFilter(Single Rfilter, Single Gfilter, Single Bfilter)
        {
            imageColorMatrixElements = new Single[][]{
                    new Single[] { Rfilter, 0, 0, 0, 0 },
                    new Single[] { 0, Gfilter, 0, 0, 0 },
                    new Single[] { 0, 0, Bfilter, 0, 0 },
                    new Single[] { 0, 0, 0, 1, 0 },
                    new Single[] { 0, 0, 0, 0, 1 }
                };
            imageAttributes = new ImageAttributes();
            imageColorMatrix = new ColorMatrix(imageColorMatrixElements);
            imageAttributes.SetColorMatrix(imageColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        }

        private void SupCFilterOnImage(Bitmap imageIn)
        {
            if (imageIn != null)
            {
                imageFilteredBitmap = new Bitmap(imageIn);

                imageGraphic = Graphics.FromImage(imageFilteredBitmap);
                imageGraphic.DrawImage(imageFilteredBitmap, Rectangle.FromLTRB(0, 0, imageIn.Width, imageIn.Height), 0, 0, imageIn.Width, imageIn.Height, GraphicsUnit.Pixel, imageAttributes);

                buttonArrow.Image = imageFilteredBitmap;
            }
        }

        private Bitmap GetCurrentImage() {
            switch (currentButtonStyle)
            {
                case ArrowButtonStyle.Up:
                    return imageUp;
                case ArrowButtonStyle.Right:
                    return imageRight;
                case ArrowButtonStyle.Down:
                    return imageDown;
                case ArrowButtonStyle.Left:
                    return ImageLeft;
                default:
                    return null;
            }
        }

        private bool IsCurrentImage(ArrowButtonStyle incomingStyle) {
            return (incomingStyle == currentButtonStyle) ? true : false;
        }

    }
}
