using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colorizer
{
    public partial class Form1 : Form
    {

        Bitmap MyPicture;
        Bitmap AlteredPicture;
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorizeButton_Click(object sender, EventArgs e)
        {
            Color tempColor;
            AlteredPicture = MyPicture;
            for (int x = 0;x<MyPicture.Width;x++)
            {
                for (int y=0; y<MyPicture.Height;y++)
                {
                    tempColor = MyPicture.GetPixel(x, y);
                    AlteredPicture.SetPixel(x, y, Color.FromArgb((tempColor.R * (int)RedPicker.Value) / 255, (tempColor.G * (int)GreenPicker.Value) / 255, (tempColor.B * (int)BluePicker.Value) / 255));
                    DisplayBox.Image = AlteredPicture;
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                MyPicture = new Bitmap(openFileDialog1.FileName);
                AlteredPicture = MyPicture;
                DisplayBox.Image = AlteredPicture;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
        
        }
    }
}
