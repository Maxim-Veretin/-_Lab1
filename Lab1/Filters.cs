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
        public static double CannyThreshold { get; set; } = 20.0;
        public static double CannyThresholdLinking { get; set; } = 30.0;

        private static Image<Bgr, byte> SourceImage = null;
        private static Image<Bgr, byte> ResultImage = null;
        private static VideoCapture Capture = null;
        private static int FrameCounter = 0;

        // upload image
        public static Image<Bgr, byte> UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = ("Файлы изображений | *.jpg; *.jpeg; *.png")
            };

            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла

            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                SourceImage = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
            }

            return SourceImage.Copy();
        }

        // upload video
        public static VideoCapture UploadVideo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = ("Файлы видео | *.mp4; *.webm; *.avi; *.mpg; *.mp2; *.mpeg; *.mov; *.wmv")
            };

            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла

            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                Capture = new VideoCapture(fileName);
            }

            return Capture;
        }

        // do gray image
        public static Image<Gray, byte> DoGrayImage(Image<Bgr, byte> image)
        {
            return image.Convert<Gray, byte>();
        }

        // Canny filter (white edges on a black background)
        public static Image<Gray, byte> CannyFilter(Image<Bgr, byte> image)
        {
            Image<Gray, byte> grayImage = DoGrayImage(image);

            var tempImage = grayImage.PyrDown();
            var destImage = tempImage.PyrUp();

            Image<Gray, byte> cannyEdges = destImage.Canny(CannyThreshold, CannyThresholdLinking);

            return cannyEdges;
        }

        // make flat colors
        public static Image<Bgr, byte> FlatColors(Image<Bgr, byte> image)
        {
            for (int channel = 0; channel < image.NumberOfChannels; channel++)
            {
                for(int y = 0; y < image.Height; y++)
                {
                    for(int x = 0; x < image.Width; x++)
                    {
                        byte color = image.Data[y, x, channel];

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

                        image.Data[y, x, channel] = color;
                    }
                }
            }
            return image;
        }

        public static Image<Bgr, byte> FlatCellShading(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> cannyEdges = CannyFilter(image.Copy()).Convert<Bgr, byte>();
            Image<Bgr, byte> flatColors = FlatColors(image.Copy());

            return flatColors.Sub(cannyEdges);
        }
    }
}
