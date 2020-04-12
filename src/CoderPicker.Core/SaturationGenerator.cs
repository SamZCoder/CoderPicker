using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderPicker.Core
{
    public class SaturationGenerator
    {

        public Color Hue { get; protected set; }

        public Size CanvasSize { get; protected set; }

        public SaturationGenerator(Color hueColor, Size size)
        {
            Hue = hueColor;
            CanvasSize = size;
            if(size.Height % 256 != 0 || size.Width % 256 != 0) { throw new Exception("Saturation Map Size Should be Dividable by 256"); } 
        }

        public void ToGraphics(Graphics graphics)
        {
            Int32 ResolutionYMultiplier = CanvasSize.Height / 256;
            Color CurrentHue = Hue;
            Color CurrentSaturation = Color.White;

            //Generate Vertical Ramp - Hue
            Rectangle VerticalMapRectangle = new Rectangle(new Point(0, 0), new Size(1, CanvasSize.Height));
            Bitmap VerticalHueMap = new Bitmap(VerticalMapRectangle.Width, VerticalMapRectangle.Height);
            LinearGradientBrush VerticalHueGradient = new LinearGradientBrush(VerticalMapRectangle, CurrentHue, Color.Black, 90f);
            Graphics.FromImage(VerticalHueMap).FillRectangle(VerticalHueGradient, VerticalMapRectangle);
            //Generate Vertical Ramp - Saturation
            Bitmap VerticalSaturationMap = new Bitmap(VerticalMapRectangle.Width, VerticalMapRectangle.Height);
            LinearGradientBrush VerticalSaturationGradient = new LinearGradientBrush(VerticalMapRectangle, Color.White, Color.Black, 90f);
            Graphics.FromImage(VerticalSaturationMap).FillRectangle(VerticalSaturationGradient, VerticalMapRectangle);

            Int32 HeightIndex = 0;
            while (HeightIndex < CanvasSize.Height)
            {
                CurrentHue = VerticalHueMap.GetPixel(0, HeightIndex);
                CurrentSaturation = VerticalSaturationMap.GetPixel(0, HeightIndex);
                Rectangle CurrentDrawingRect = new Rectangle(0, HeightIndex, CanvasSize.Width, 1);
                LinearGradientBrush Gradient = new LinearGradientBrush(CurrentDrawingRect,Color.Black, Color.Black, 0f);
                ColorBlend Blender = new ColorBlend();
                Blender.Positions = new[] { 0, 255 / 256f, 1 };
                Blender.Colors = new[] { CurrentSaturation, CurrentHue, CurrentHue };
                Gradient.InterpolationColors = Blender;
                graphics.FillRectangle(Gradient, CurrentDrawingRect);
                HeightIndex++;
            }
            VerticalHueMap.Dispose();
            VerticalSaturationMap.Dispose();
        }

        public Bitmap ToBitmap()
        {
            Bitmap bmp = new Bitmap(CanvasSize.Width, CanvasSize.Height);
            this.ToGraphics(Graphics.FromImage(bmp));
            return bmp;
        }
    }
}
