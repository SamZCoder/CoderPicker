using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoderPicker.Core
{
    public class HueGenerator
    {
        public Size CanvasSize { get; protected set; }
        public LinearGradientBrush Gradient { get; protected set; }
        public Boolean IsInitialized { get; protected set; } = false;
        protected ColorBlend Blender { get; set; } = new ColorBlend();
        public HueGenerator(Size size)
        {
            CanvasSize = size;
        }

        protected void Initialize()
        {
            if(IsInitialized) { return; }
            Gradient = new LinearGradientBrush(new Rectangle(new Point(0, 0), CanvasSize), Color.Black, Color.Black, 0, false);
            Blender.Positions = new[] { 0, 1/13f, 2/ 13f, 3/ 13f, 4/ 13f, 5/ 13f, 6/ 13f, 7/ 13f, 8/ 13f, 9/ 13f, 10/ 13f, 11/ 13f,12/ 13f, 1 };
            Blender.Colors = new[] {
                Color.Red, Color.Red,
                Color.Yellow, Color.Yellow,
                Color.Green, Color.Green,
                Color.Cyan, Color.Cyan,
                Color.Blue, Color.Blue,
                Color.Magenta, Color.Magenta,
                Color.Red, Color.Red
            };
            Gradient.InterpolationColors = Blender;
            IsInitialized = true;
            
        }

        public void ToGraphics(Graphics graphics)
        {
            Initialize();
            using (graphics) 
            {
                graphics.FillRectangle(Gradient, new Rectangle(new Point(0, 0), CanvasSize)); 
            }
        }
        public Bitmap ToBitmap()
        {
            Bitmap bitmap = new Bitmap(CanvasSize.Width, CanvasSize.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            { ToGraphics(graphics); }
            return bitmap;
        }

        public void DrawToPanel(Panel panel)
        {
            ToGraphics(panel.CreateGraphics());
        }
    }
}
