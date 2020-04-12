using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderPicker.Core
{
    public class CoordinatesHelper
    {
        public static Point ClipLocationToBounds(Point Location, Size Bounds, Int32 SafeMargin = 0)
        {
            Int32 RealXPosition = 0;
            Int32 RealYPosition = 0;
            //Clip X
            RealXPosition = (Location.X <= SafeMargin) ? SafeMargin : Location.X;
            RealXPosition = (Location.X >= Bounds.Width- SafeMargin) ? Bounds.Width - SafeMargin : Location.X;
            //Clip Y
            RealYPosition = (Location.Y <= SafeMargin) ? SafeMargin : Location.Y;
            RealYPosition = (Location.Y >= Bounds.Height- SafeMargin) ? Bounds.Height - SafeMargin : Location.Y;

            return new Point(RealXPosition, RealYPosition);
        }
    }
}
