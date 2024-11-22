using System;


namespace Shugurov_zad4v3
{
    public class R
    {
        public static int m(int x1, int y1, int x2, int y2, int x1d, int y1d, int x2d, int y2d)
        {
            int xmin = Math.Min(x1, x2);
            int xmax = Math.Max(x1, x2);
            int ymin = Math.Min(y1, y2);
            int ymax = Math.Max(y1, y2);
            int xmind = Math.Min(x1d, x2d);
            int xmaxd = Math.Max(x1d, x2d);
           int ymind = Math.Min(y1d, y2d);
            int ymaxd = Math.Max(y1d, y2d);
            int S = (xmax - xmin) * (ymax - ymin);
            int Sd = (xmaxd - xmind) * (ymaxd - ymind);
            int result;
            if(xmin < xmax && xmax > xmind && ymin < ymaxd && ymax > ymind)
            {
                int x_min = Math.Max(xmin, xmind);
                    int x_max = Math.Min(xmax, xmaxd);
                   int y_min = Math.Max(ymin, ymind);
                    int y_max = Math.Min(ymax, ymaxd);
                int P = Math.Max(0, x_max - x_min) * Math.Max(0, y_max - y_min);
              result = S + Sd - P;
            }
            else
            {
            result = S + Sd;
            }
            return result;
        }
    }
}
