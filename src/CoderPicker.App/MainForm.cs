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

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = saturationCanvas.CreateGraphics();
            
            
        }

        private void hueCanvas_Paint(object sender, PaintEventArgs e)
        {
            new HueGenerator(new Size(hueCanvas.Width, hueCanvas.Height)).ToGraphics(e.Graphics);
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
                Bitmap bmp = new Bitmap(hueCanvas.Width-2, hueCanvas.Height-2);
                hueCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, hueCanvas.Width-1, hueCanvas.Height-1));
                if (HueChangeActive)
                {
                    SelectedHue = bmp.GetPixel(CurrentLocation.X, CurrentLocation.Y);
                    hueRedText.Text = SelectedHue.R.ToString();
                    hueGreenText.Text = SelectedHue.G.ToString();
                    hueBlueText.Text = SelectedHue.B.ToString();

                    CreateSaturationCanvas();
                }
            }
            catch
            {

            }
            
        }

        private void CreateSaturationCanvas()
        {
            Int32 RedToBlackFactor = (Int32)Math.Round((1f/((SelectedHue.R)/255f)));
            Int32 GreenToBlackFactor = (Int32)Math.Round((1f / ((SelectedHue.G) / 255f)));
            Int32 BlueToBlackFactor = (Int32)Math.Round((1f / ((SelectedHue.B) / 255f)));
            Color NextEndColor = Color.White;
            Color NextHue = SelectedHue;
            Bitmap tempBitmap = new Bitmap(510, 510);
            Graphics graphics = Graphics.FromImage(tempBitmap);
            Int32 CurrentYPosition = 1;
            while(CurrentYPosition <= tempBitmap.Height-2)
            {
                NextHue = Color.FromArgb(
                    255,
                    NextHue.R - Math.Max(((((CurrentYPosition / 2) % RedToBlackFactor) == 0 && RedToBlackFactor > 0) ? 1 : 0), 0),
                    NextHue.G - Math.Max(((((CurrentYPosition / 2) % GreenToBlackFactor) == 0 && GreenToBlackFactor > 0) ? 1 : 0), 0),
                    NextHue.B - Math.Max(((((CurrentYPosition / 2) % BlueToBlackFactor) == 0 && BlueToBlackFactor > 0) ? 1 : 0), 0)
                );
                LinearGradientBrush gradient = new LinearGradientBrush(new Rectangle(0, CurrentYPosition - 1, tempBitmap.Width, 2), NextEndColor, NextHue, 0f);
                graphics.FillRectangle(gradient, new Rectangle(0, CurrentYPosition - 1, tempBitmap.Width, 2));
                NextEndColor = Color.FromArgb(255, NextEndColor.R-1, NextEndColor.G-1, NextEndColor.B-1);
                
                CurrentYPosition += 2;
            }
            saturationCanvas.BackgroundImage = tempBitmap;
            saturationCanvas.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentColorCanvas.BackColor = SelectedHue;
            CreateSaturationCanvas();
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

                hoverCanvas.BackColor = bmp.GetPixel(e.X, e.Y);
                if (SaturationChangeActive)
                {
                    SelectedColor = bmp.GetPixel(e.X, e.Y);
                    currentColorCanvas.BackColor = SelectedColor;
                    currentRedText.Text = SelectedColor.R.ToString();
                    currentGreenText.Text = SelectedColor.G.ToString();
                    currentBlueText.Text = SelectedColor.B.ToString();
                    currentHexText.Text = SelectedColor.ToHtml();
                    
                }
            }
            catch
            {

            }
        }
    }
}
