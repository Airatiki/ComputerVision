using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing.Imaging;

namespace Detection
{
    class HoughTransform
    {


        public static int[,] HoughAccumulator(Image<Gray, byte> cannyEdges)
        {

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
            

            int[,] houghSpace = new int[181, D];

            int height = cannyEdges.Width;
            int width = cannyEdges.Height;

            for (int xi = 0; xi < height; xi++)
            {
                for (int yi = 0; yi < width; yi++)
                {
                    if (cannyEdges[yi, xi].Intensity == 0) continue;

                    for (int i = 0; i < 181; i++)
                    {
                        int rho = (int)(xi * table[0, i] + yi * table[1, i]);
                        if (rho < 0) rho += D;
                        houghSpace[i, rho]++;
                    }
                }
            }

            return houghSpace;
        }

        public static int FindingMax(int[,] houghSpace)
        {
            int max = 0;

            for (int i = 0; i < houghSpace.GetLength(0); i++)
            {
                for (int j = 0; j < houghSpace.GetLength(1); j++)
                {
                    if (houghSpace[i, j] > max)
                    {
                        max = houghSpace[i, j];
                    }
                }
            }

            return max;
        }
    }
}
