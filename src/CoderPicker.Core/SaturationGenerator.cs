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
            Color CurrentEndColor = Color.White;

            Int32 HeightIndex = 0;
            while (HeightIndex < CanvasSize.Height)
            {
                Rectangle CurrentDrawingRect = new Rectangle(0, HeightIndex, CanvasSize.Width, ResolutionYMultiplier);
                LinearGradientBrush Gradient = new LinearGradientBrush(CurrentDrawingRect,CurrentEndColor, CurrentHue, 0f);
                graphics.FillRectangle(Gradient, CurrentDrawingRect);
                HeightIndex += ResolutionYMultiplier;
            }
        }
    }
}
