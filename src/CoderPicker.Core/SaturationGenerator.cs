using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderPicker.Core
{
    public class SaturationGenerator
    {

        public Color CurrentHue { get; protected set; }

        public Size CanvasSize { get; protected set; }
        public SaturationGenerator(Color hueColor, Size size)
        {
            CurrentHue = hueColor;
            CanvasSize = size;
            if(size.Height % 256 != 0 || size.Width % 256 != 0) { throw new Exception("Saturation Map Size Should be Dividable by 256"); } 
        }

        public void ToGraphics(Graphics graphics)
        {
            
        }
    }
}
