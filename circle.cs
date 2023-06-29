using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_PaintWhyyy
{
    internal class circle
    {
        public static void Draw(Bitmap bitmap, Point previousPoint, Point secondPoint, Pen pen)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                if (secondPoint.X > previousPoint.X && secondPoint.Y > previousPoint.Y)
                {
                    g.DrawEllipse(pen, previousPoint.X, previousPoint.Y, secondPoint.X - previousPoint.X, secondPoint.Y - previousPoint.Y);
                }
                else if (secondPoint.X < previousPoint.X && secondPoint.Y < previousPoint.Y)
                {
                    g.DrawEllipse(pen, secondPoint.X, secondPoint.Y, previousPoint.X - secondPoint.X, previousPoint.Y - secondPoint.Y);
                }
                else if (secondPoint.X > previousPoint.X && secondPoint.Y < previousPoint.Y)
                {
                    g.DrawEllipse(pen, previousPoint.X, secondPoint.Y, secondPoint.X - previousPoint.X, previousPoint.Y - secondPoint.Y);
                }
                else if (secondPoint.X < previousPoint.X && secondPoint.Y > previousPoint.Y)
                {
                    g.DrawEllipse(pen, secondPoint.X, previousPoint.Y, previousPoint.X - secondPoint.X, secondPoint.Y - previousPoint.Y);
                }
            }
        }
    }
}
