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
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing.Imaging;

namespace Detection
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            this.comboBox_thickness.SelectedIndex = 1;
        }

        private Capture web;
        private void Form1_Load(object sender, EventArgs e)
        {
            web = new Capture();
            Application.Idle += ProcessFrame;
        }

         private   Color lineColour = Color.Blue;
        
        private void ProcessFrame(object sender, EventArgs e)
        {


            Mat yourImg = web.QueryFrame();
            if (yourImg == null)
            {
                MessageBox.Show("There is no a Web-cam on your computer, please enable it and try one more time.", "Error!");
                Environment.Exit(0);
                
            }

            Image<Bgr, byte> img = yourImg.ToImage<Bgr, byte>();
            Image<Bgr, byte> img1 = yourImg.ToImage<Bgr, byte>();
          
            Count_of_points.Text = "Threshold: " + trackBar_CountPoints.Value.ToString();
            Threshold.Text = "Count of points on a line: " + ValueOfpoints.Value.ToString();
            LineThickness.Text = "Line thickness";

       

            Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();
            Image<Gray, Byte> cannyEdges = gray.Canny(trackBar_CountPoints.Value, 0);


            double[,] table = new double[2, 181];
            double rad = Math.PI / 180;
            double theta = rad * -90;
            for (int i = 0; i < 181; i++)
            {
                table[0, i] = Math.Cos(theta);
                table[1, i] = Math.Sin(theta);
                theta += rad;
            }

            int D = (int)Math.Sqrt(cannyEdges.Width * cannyEdges.Width + cannyEdges.Height * cannyEdges.Height);
            int height = cannyEdges.Width;
            int width = cannyEdges.Height;

            int[,] houghSpace = HoughTransform.HoughAccumulator(cannyEdges);

            int max = HoughTransform.FindingMax(houghSpace);

            
            if (bmp == null || bmp.Width != D)
                bmp = new Bitmap(181, D);

            unsafe
            {
                BitmapData bmd = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, bmp.PixelFormat);
                for (int i = 0; i < bmp.Height; i++)
                {
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        byte b = 0;
                        if (max != 0)
                            b = (byte)((houghSpace[j,i] / (double)max) * 255.0);

                        int offset = (i * bmd.Stride) + (j * 4);
                        ((byte*)bmd.Scan0)[offset] = b;
                        ((byte*)bmd.Scan0)[offset + 1] = b;
                        ((byte*)bmd.Scan0)[offset + 2] = b;
                        ((byte*)bmd.Scan0)[offset + 3] = 255;
                    }
                }
                bmp.UnlockBits(bmd);
            }

            
           
            int lineThickness = int.Parse(comboBox_thickness.Text);


            int x1 = 1;
            int y1;
            int x2 = height - 1;
            int y2;
            Point[] a = new Point[2];

            height = houghSpace.GetLength(0);
            width = houghSpace.GetLength(1);
            var threshold = ValueOfpoints.Value;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (houghSpace[i, j] > threshold)
                    {
                        y1 = (int)((j - table[0, i] * x1) / table[1, i]);
                        y2 = (int)((j - table[0, i] * x2) / table[1, i]);
                        a[0] = new Point(x1, y1);
                        a[1] = new Point(x2, y2);
                        img.DrawPolyline(a, true, new Bgr(lineColour), lineThickness);
                    }
                }
            }



            LineSegment2D[] lines = cannyEdges.HoughLines(
                trackBar_CountPoints.Value,
                 0,
                 1, //Distance resolution in pixel-related units
                 Math.PI / 180.0, //Angle resolution measured in radians.
                 70, //threshold
                 ValueOfpoints.Value, //min Line width
                 3 //gap between lines
                 )[0]; //Get the lines from the first channel

            foreach (LineSegment2D line in lines)
            {
                img1.Draw(line, new Bgr(lineColour), lineThickness);
            }

            this.houghSpace.Image = bmp;

            if (checkBox.Checked)
                CamBox.Image = img1;
            else
                CamBox.Image = img;

            CannyEdgeBox.Image = cannyEdges;


        }

        private void Select_Colour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lineColour = colorDialog1.Color;
        }
        private void houghSpace_MouseMove(object sender, MouseEventArgs e)
        {
            

              Parametres_of_line.Text = "Parametres of detected line" + "\n" +"R: " + e.Y  + "     Theta: " + (180 - e.X) ;
        }


    }
}