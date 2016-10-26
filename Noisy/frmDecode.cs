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
    public partial class frmDecode : Form
    {
        private Bitmap cleanImg;
        private Bitmap decodedImg;

        private byte[] decoded;

        public frmDecode()
        {
            InitializeComponent();
        }

        private void btnLoadClear_Click(object sender, EventArgs e)
        {
            ofdLoadClear.ShowDialog();
        }

        private void btnLoadEncoded_Click(object sender, EventArgs e)
        {
            ofdLoadEncoded.ShowDialog();
        }

        private void btnSaveDecoded_Click(object sender, EventArgs e)
        {
            sfdSaveImg.ShowDialog();
        }

        private void ofdLoadClear_FileOk(object sender, CancelEventArgs e)
        {
            cleanImg = new Bitmap(ofdLoadClear.FileName);
            if (decodedImg != null)
                UpdateImg();
        }

        private void ofdLoadEncoded_FileOk(object sender, CancelEventArgs e)
        {
            decodedImg = new Bitmap(ofdLoadEncoded.FileName);
            if (cleanImg != null)
                UpdateImg();
        }

        private void sfdSaveImg_FileOk(object sender, CancelEventArgs e)
        {
            if (decodedImg != null && cleanImg != null)
            {
                if (decoded == null)
                    UpdateImg();
                File.WriteAllBytes(sfdSaveImg.FileName, decoded);
            }
        }

        private void UpdateImg()
        {
            BitArray bits = new BitArray((decodedImg.Width / 8) * decodedImg.Height);
            for (int y = 0; y < decodedImg.Height; y++)
            {
                for (int bit = 0; bit < decodedImg.Width / 8; bit++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        int realX = x + (bit * 8);

                        int red = decodedImg.GetPixel(realX, y).R - cleanImg.GetPixel(realX, y).R;
                        int green = decodedImg.GetPixel(realX, y).G - cleanImg.GetPixel(realX, y).G;
                        int blue = decodedImg.GetPixel(realX, y).B - cleanImg.GetPixel(realX, y).B;

                        if (red == 1)
                            red = 255;
                        else if (red == 0)
                            red = 0;
                        else
                            red = 10;

                        if (green == 1)
                            green = 255;
                        else if (green == 0)
                            green = 0;
                        else
                            green = 10;

                        if (blue == 1)
                            blue = 255;
                        else if (blue == 0)
                            blue = 0;
                        else
                            blue = 10;

                        Color color = Color.FromArgb(red, green, blue);
                        decodedImg.SetPixel(realX, y, color);
                    }
                }
            }

            Bitmap pixelBmp = new Bitmap(decodedImg.Width * 256, decodedImg.Height * 256);

            Graphics g = Graphics.FromImage(pixelBmp);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = PixelOffsetMode.None;
            g.DrawImage(decodedImg, 0, 0, pixelBmp.Width, pixelBmp.Height);

            pbxPreview.Image = pixelBmp;
        }
    }
}