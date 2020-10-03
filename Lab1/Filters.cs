using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Lab1
{
    static class Filters
    {
        public static double cannyThreshold { get; set; } = 20.0;
        public static double cannyThresholdLinking { get; set; } = 30.0;

        public static Image<Bgr, byte> LoadImage()
        {
            Image<Bgr, byte> sourceImage = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);
            }

            return sourceImage;
        }

        public static Image<Gray, byte> DoGrayImage(Image<Bgr, byte> sourceImage)
        {
            //Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();

            //var tempImage = grayImage.PyrDown();
            //var destImage = tempImage.PyrUp();

            //return destImage;
            return sourceImage.Convert<Gray, byte>();
        }

        public static Image<Gray, byte> KannyFilter(Image<Bgr, byte> sourceImage)
        {
            Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();

            var tempImage = grayImage.PyrDown();
            var destImage = tempImage.PyrUp();

            Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);

            //return sourceImage.Sub(cannyEdges.Convert<Bgr, byte>());
            return cannyEdges;
        }

        public static Image<Bgr, byte> FlatColors(Image<Bgr, byte> sourceImage)
        {
            Image<Bgr, byte> resultImage = sourceImage;

            for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
            {
                for(int y = 0; y < resultImage.Height; y++)
                {
                    for(int x = 0; x < resultImage.Width; x++)
                    {
                        byte color = resultImage.Data[y, x, channel];

                        if (color <= 50)
                            color = 0;
                        else if (color <= 100)
                            color = 25;
                        else if (color <= 150)
                            color = 180;
                        else if (color <= 200)
                            color = 210;
                        else
                            color = 255;

                        resultImage.Data[y, x, channel] = color;
                    }
                }
            }
            return resultImage;
        }
    }
}
