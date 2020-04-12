using CoderPicker.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CoderPicker.Core;

namespace CoderPicker.App
{
    public partial class MainForm : Form
    {

        Boolean HueChangeActive = false;

        Boolean SaturationChangeActive = false;

        Color SelectedHue = Color.Red;

        Color SelectedColor = Color.Red;
        public MainForm()
        {
            InitializeComponent();
        }

        private void hueCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            HueChangeActive = true;
            hueCanvas_MouseMove(sender, e);
        }

        private void hueCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            HueChangeActive = false;
        }

        private void hueCanvas_MouseMove(object sender, MouseEventArgs e)
        {

            try
            {
                Point CurrentLocation = CoordinatesHelper.ClipLocationToBounds(e.Location, hueCanvas.Size);
                Bitmap bmp = new Bitmap(hueCanvas.Width, hueCanvas.Height);
                hueCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, hueCanvas.Width, hueCanvas.Height));
                if (HueChangeActive)
                {
                    SelectedHue = bmp.GetPixel(CurrentLocation.X, CurrentLocation.Y);
                    SetCurrentColorInfo();

                    CreateSaturationCanvas();
                }
            }
            catch
            {

            }
            
        }

        private void CreateSaturationCanvas()
        {
            SaturationGenerator saturation = new SaturationGenerator(SelectedHue, saturationCanvas.Size);
            saturationCanvas.BackgroundImage = saturation.ToBitmap();
            saturationCanvas.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectedHue = Color.Red;
            currentColorCanvas.BackColor = SelectedHue;

            //Hue Map
            HueGenerator HueGen = new HueGenerator(new Size(hueCanvas.Width, hueCanvas.Height));
            hueCanvas.BackgroundImage = HueGen.ToBitmap();
            hueCanvas.BackgroundImageLayout = ImageLayout.Stretch;

            CreateSaturationCanvas();
            SetCurrentColorInfo();
        }

        private void saturationCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            SaturationChangeActive = true;
            saturationCanvas_MouseMove(sender, e);
        }

        private void saturationCanvas_MouseUp(object sender, MouseEventArgs e)
        {

            SaturationChangeActive = false;
        }

        private void saturationCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(saturationCanvas.Width, saturationCanvas.Height);
                saturationCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, saturationCanvas.Width, saturationCanvas.Height));
                Point CurrentLocation = CoordinatesHelper.ClipLocationToBounds(e.Location, saturationCanvas.Size);
                hoverCanvas.BackColor = bmp.GetPixel(CurrentLocation.X, CurrentLocation.Y);
                if (SaturationChangeActive)
                {
                    SelectedColor = bmp.GetPixel(CurrentLocation.X, CurrentLocation.Y);
                    currentColorCanvas.BackColor = SelectedColor;
                    SetCurrentColorInfo();
                    
                }
            }
            catch
            {

            }
        }

        private void SetCurrentColorInfo()
        {
            //RGB
            currentRedText.Text = SelectedColor.R.ToString();
            currentGreenText.Text = SelectedColor.G.ToString();
            currentBlueText.Text = SelectedColor.B.ToString();
            //HSL
            //currentHueText.Text = SelectedColor.CalculateHue().ToString();
            currentSaturationText.Text = SelectedColor.GetSaturation().ToString("P0");
            currentLightText.Text = SelectedColor.GetBrightness().ToString("P0");


            //Hue
            hueRedText.Text = SelectedHue.R.ToString();
            hueGreenText.Text = SelectedHue.G.ToString();
            hueBlueText.Text = SelectedHue.B.ToString();

            currentHexText.Text = SelectedColor.ToHtml();
            rgbCodeText.Text = $"({SelectedColor.R},{SelectedColor.G},{SelectedColor.B})";
        }

        private void OutputText_Click(object sender, EventArgs e)
        {
            if(autoCopyCheckbox.Checked) { Clipboard.SetText(((TextBox)sender).Text); }
        }
    }
}
