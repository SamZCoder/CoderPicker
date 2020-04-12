using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderPicker.Core
{
    public static class ColorExtentions
    {
        public static String ToHtml(this Color color)
        {
            return ColorTranslator.ToHtml(color).ToLower();
        }
    }
}
