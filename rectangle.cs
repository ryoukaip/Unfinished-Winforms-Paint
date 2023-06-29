using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp_PaintWhyyy
{
    internal class rectangle
    {
        
        public static void Draw (Bitmap bitmap, Point previousPoint, Point secondPoint, Pen pen)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                if (secondPoint.X > previousPoint.X && secondPoint.Y > previousPoint.Y)
                {
                    graphics.DrawRectangle(pen, previousPoint.X, previousPoint.Y, secondPoint.X - previousPoint.X, secondPoint.Y - previousPoint.Y);
                }
                else if (secondPoint.X < previousPoint.X && secondPoint.Y < previousPoint.Y)
                {
                    graphics.DrawRectangle(pen, secondPoint.X, secondPoint.Y, previousPoint.X - secondPoint.X, previousPoint.Y - secondPoint.Y);
                }
                else if (secondPoint.X > previousPoint.X && secondPoint.Y < previousPoint.Y)
                {
                    graphics.DrawRectangle(pen, previousPoint.X, secondPoint.Y, secondPoint.X - previousPoint.X, previousPoint.Y - secondPoint.Y);
                }
                else if (secondPoint.X < previousPoint.X && secondPoint.Y > previousPoint.Y)
                {
                    graphics.DrawRectangle(pen, secondPoint.X, previousPoint.Y, previousPoint.X - secondPoint.X, secondPoint.Y - previousPoint.Y);
                }
            }
        }
    }
}
