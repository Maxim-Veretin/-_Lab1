using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Bgr, byte> resultImage;
        private VideoCapture capture;
        private int frameCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // image upload button logic
        private void LoadImageBut_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.UploadImage();

            if (CannyFilterCheckBox.Checked)
            {
                if (FlatColorsCheckBox.Checked)
                {
                    resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                }
                else
                    resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
            }
            else if (FlatColorsCheckBox.Checked)
            {
                resultImgBox.Image = Filters.FlatColors(sourceImage.Copy());
            }
            else
                sourseImgBox.Image = sourceImage;
        }

        // video upload button logic
        private void LoadVideoBut_Click(object sender, EventArgs e)
        {
            capture = Filters.UploadVideo();

            timer1.Interval = (int)Math.Round(capture.GetCaptureProperty(CapProp.Fps));
            timer1.Enabled = true;
        }

        // what to do in one tick of timer1
        private void Timer1_Tick(object sender, EventArgs e)
        {
            var frame = capture.QueryFrame();
            sourceImage = frame.ToImage<Bgr, byte>().Resize(640, 480, Inter.Linear).Copy();

            if (CannyFilterCheckBox.Checked)
            {
                if (FlatColorsCheckBox.Checked)
                {
                    resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                }
                else
                    resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
            }
            else if (FlatColorsCheckBox.Checked)
            {
                resultImgBox.Image = Filters.FlatColors(sourceImage.Copy());
            }
            else
                resultImgBox.Image = sourceImage;

            frameCounter++;

            if (frameCounter >= capture.GetCaptureProperty(CapProp.FrameCount))
            {
                timer1.Enabled = false;
                resultImgBox.Image = null;
            }
        }

        private void ShowOriginImgBut_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                CannyFilterCheckBox.Checked = false;
                FlatColorsCheckBox.Checked = false;
                resultImgBox.Image = sourceImage;
            }
            else
                MessageBox.Show("Load any image before press this button.");
        }

        private void CannyThresholdScrl_Scroll(object sender, EventArgs e)
        {
            Filters.CannyThreshold = cannyThresholdScrl.Value;

            if (sourceImage != null)
            {
                if (CannyFilterCheckBox.Checked)
                {
                    if (FlatColorsCheckBox.Checked)
                    {
                        // display the sell shading + flat colors image
                        resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                    }
                    else
                        // display the Canny edges image
                        resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
                }
            }
        }

        private void CannyThresholdLinkingScrl_Scroll(object sender, EventArgs e)
        {
            Filters.CannyThresholdLinking = cannyThresholdLinkingScrl.Value;

            if (sourceImage != null)
            {
                if (CannyFilterCheckBox.Checked)
                {
                    if (FlatColorsCheckBox.Checked)
                    {
                        // display the sell shading + flat colors image
                        resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                    }
                    else
                        // display the Canny edges image
                        resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
                }
            }
        }

        private void CannyFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // if we have source image
            if (sourceImage != null)
            {
                if (CannyFilterCheckBox.Checked)
                {
                    if (FlatColorsCheckBox.Checked)
                    {
                        // display the sell shading + flat colors image
                        resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                    }
                    else
                        // display the Canny edges image
                        resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
                }
                else if (FlatColorsCheckBox.Checked)
                {
                    // display the flat colors image
                    resultImgBox.Image = Filters.FlatColors(sourceImage.Copy());
                }
                else
                    // display the source image
                    resultImgBox.Image = sourceImage;
            }
        }

        private void CheckBoxFlatColors_CheckedChanged(object sender, EventArgs e)
        {
            // if we have source image
            if (sourceImage != null)
            {
                if (FlatColorsCheckBox.Checked)
                {
                    if (CannyFilterCheckBox.Checked)
                    {
                        // display the sell shading + flat colors image
                        resultImgBox.Image = Filters.FlatCellShading(sourceImage.Copy());
                    }
                    else
                    {
                        // display the flat colors image
                        resultImgBox.Image = Filters.FlatColors(sourceImage.Copy());
                    }
                }
                else if (CannyFilterCheckBox.Checked)
                {
                    // display the Canny edges image
                    resultImgBox.Image = Filters.CannyFilter(sourceImage.Copy());
                }
                else
                    // display the source image
                    resultImgBox.Image = sourceImage;
            }
        }
    }
}
