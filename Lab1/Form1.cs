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

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImageBut_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.LoadImage().Resize(640, 480, Inter.Linear);
            sourseImgBox.Image = sourceImage;

            if (KannyFilterCheckBox.Checked)
            {
                resultImage = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());

                if (checkBoxFlatColors.Checked)
                {
                    resultImgBox.Image = Filters.FlatColors(resultImage.Copy());
                }
                else
                    resultImgBox.Image = resultImage;
            }
            else if (checkBoxFlatColors.Checked)
            {
                resultImage = Filters.FlatColors(sourceImage.Copy());
                resultImgBox.Image = resultImage;
            }
        }

        private void GrayImageBut_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                resultImgBox.Image = Filters.DoGrayImage(sourceImage);
            }
            else
                MessageBox.Show("Load any image before press this button.");
        }

        private void ShowOriginImgBut_Click(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                KannyFilterCheckBox.Checked = false;
                checkBoxFlatColors.Checked = false;
                resultImgBox.Image = sourceImage;
            }
            else
                MessageBox.Show("Load any image before press this button.");
        }

        private void cannyThresholdScrl_Scroll(object sender, EventArgs e)
        {
            if (KannyFilterCheckBox.Checked)
            {
                Filters.cannyThreshold = cannyThresholdScrl.Value;
                resultImage = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());

                if (checkBoxFlatColors.Checked)
                {
                    resultImgBox.Image = Filters.FlatColors(resultImage.Copy());
                }
                else
                    resultImgBox.Image = resultImage;
            }
            else
                Filters.cannyThreshold = cannyThresholdScrl.Value;
        }

        private void cannyThresholdLinkingScrl_Scroll(object sender, EventArgs e)
        {
            if (KannyFilterCheckBox.Checked)
            {
                Filters.cannyThresholdLinking = cannyThresholdLinkingScrl.Value;
                resultImage = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());

                if (checkBoxFlatColors.Checked)
                {
                    resultImgBox.Image = Filters.FlatColors(resultImage.Copy());
                }
                else
                    resultImgBox.Image = resultImage;
            }
            else
                Filters.cannyThresholdLinking = cannyThresholdLinkingScrl.Value;
        }

        private void KannyFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                if (KannyFilterCheckBox.Checked)
                {
                    resultImage = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());

                    if (checkBoxFlatColors.Checked)
                    {
                        resultImgBox.Image = Filters.FlatColors(resultImage.Copy());
                    }
                    else
                        resultImgBox.Image = resultImage;
                }
                else
                {
                    if (checkBoxFlatColors.Checked)
                    {
                        resultImgBox.Image = Filters.FlatColors(sourceImage.Copy());
                    }
                    else
                        resultImgBox.Image = sourceImage;
                }
            }
        }

        private void checkBoxFlatColors_CheckedChanged(object sender, EventArgs e)
        {
            if (sourceImage != null)
            {
                if (checkBoxFlatColors.Checked)
                {
                    if (KannyFilterCheckBox.Checked)
                    {
                        resultImage = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());
                        resultImgBox.Image = Filters.FlatColors(resultImage.Copy());
                    }
                    else
                    {
                        resultImage = Filters.FlatColors(sourceImage.Copy());
                        resultImgBox.Image = resultImage;
                    }
                }
                else
                {
                    if (KannyFilterCheckBox.Checked)
                    {
                        resultImgBox.Image = sourceImage.Sub(Filters.KannyFilter(sourceImage).Convert<Bgr, byte>());
                    }
                    else
                        resultImgBox.Image = sourceImage;
                }
            }
        }
    }
}
