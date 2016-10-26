using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Noisy
{
    public partial class frmEncode : Form
    {
        private Bitmap cleanImg;
        private Bitmap encodedImg;

        private byte[] encoded;

        public frmEncode()
        {
            InitializeComponent();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            ofdLoadImg.ShowDialog();
        }

        private void btnLoadTxt_Click(object sender, EventArgs e)
        {
            ofdLoad.ShowDialog();
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            sfdSaveImg.ShowDialog();
        }

        private void ofdLoadImg_FileOk(object sender, CancelEventArgs e)
        {
            cleanImg = new Bitmap(ofdLoadImg.FileName);
            if (encoded != null)
                UpdateImg();
        }

        private void ofdLoadTxt_FileOk(object sender, CancelEventArgs e)
        {
            encoded = File.ReadAllBytes(ofdLoad.FileName);
            if (cleanImg != null)
                UpdateImg();
        }

        private void sfdSaveImg_FileOk(object sender, CancelEventArgs e)
        {
            if (encoded != null && cleanImg != null)
            {
                if (encodedImg == null)
                    UpdateImg();
                encodedImg.Save(sfdSaveImg.FileName, ImageFormat.Bmp);
            }
        }

        private void UpdateImg()
        {
            encodedImg = cleanImg;
            BitArray bits = new BitArray(encoded);
            if (bits.Length >= (encodedImg.Width / 8) * encodedImg.Height)
            {
                for (int y = 0; y < encodedImg.Height; y++)
                {
                    for (int bit = 0; bit < encodedImg.Width / 8; bit++)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            int realX = x + (bit * 8);

                            int red = encodedImg.GetPixel(realX, y).R + 1;
                            int green = encodedImg.GetPixel(realX, y).G + 1;
                            int blue = encodedImg.GetPixel(realX, y).B + 1;

                            if (red > 255)
                                red = 255;
                            if (green > 255)
                                green = 255;
                            if (blue > 255)
                                blue = 255;

                            Color color = Color.FromArgb(red, green, blue);
                            encodedImg.SetPixel(realX, y, bits[realX + (y * 8)] ? color : encodedImg.GetPixel(realX, y));
                        }
                    }
                }

                Bitmap pixelBmp = new Bitmap(encodedImg.Width * 256, encodedImg.Height * 256);

                Graphics g = Graphics.FromImage(pixelBmp);
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.None;
                g.DrawImage(encodedImg, 0, 0, pixelBmp.Width, pixelBmp.Height);

                pbxPreview.Image = pixelBmp;
            }
        }
    }
}