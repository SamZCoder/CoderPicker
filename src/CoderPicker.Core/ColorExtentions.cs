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

        public static Int32 CalculateHue(this Color color)
        {
            float Hue = 0;
            float RedChannel = color.R / 255f;
            float GreenChannel = color.G / 255f;
            float BlueChannel = color.B / 255f;

            float MinValue = Math.Min(Math.Min(RedChannel, GreenChannel), BlueChannel);
            float MaxValue = Math.Max(Math.Max(RedChannel, GreenChannel), BlueChannel);
            Console.WriteLine($"Min Value = {MinValue} and Max Value = {MaxValue}");
            //It's From White to Black
            if(MinValue == MaxValue) { return 0; }

            float Modifier = 0;
            if(MaxValue == RedChannel) { Modifier = GreenChannel - BlueChannel; }
            else if (MaxValue == GreenChannel) { Modifier = 2f + (BlueChannel - RedChannel); }
            else { Modifier = 4f + (RedChannel - GreenChannel); }

            Hue = Modifier / (MaxValue - MinValue);

            Hue *= 60;
            if(Hue < 0) { Hue += 360; }

            return (Int32)Math.Floor(Hue);
        }
    }
}
