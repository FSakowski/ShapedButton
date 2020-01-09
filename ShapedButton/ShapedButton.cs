using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace ShapedButton
{
    public class ShapedButton : Button
    {
        private bool mouseOver;
        [Category("Darstellung")]
        public Color ShapeColor {
            get;
            set;
        }

        public ShapedButton() : base()
        {

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            mouseOver = true;
            base.OnMouseHover(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mouseOver = false;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics gr = pevent.Graphics;
            gr.Clear(BackColor);

            Color transformColor = mouseOver ? ControlPaint.Light(ShapeColor) : ShapeColor;

            float r = transformColor.R / 255f;
            float g = transformColor.G / 255f;
            float b = transformColor.B / 255f;

            float[][] colorMatrixElements =
            {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {r, g, b, 0, 1},
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            ImageAttributes imgAttr = new ImageAttributes();
            imgAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Bitmap img = Properties.Resources.arrow_right;

            gr.DrawImage(img, pevent.ClipRectangle, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttr);

            StringFormat strFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            gr.DrawString(Text, Font, new SolidBrush(ForeColor), pevent.ClipRectangle, strFormat);
        }
    }
}
