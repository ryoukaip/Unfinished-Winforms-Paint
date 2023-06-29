using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp_PaintWhyyy
{
    internal class line
    {
        public static void Draw(Bitmap bitmap, Point previousPoint, Point secondPoint, Pen pen)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawLine(pen, previousPoint, secondPoint);
            }
        }
        public static void Draw(Graphics graphics, Point previousPoint, Point secondPoint, Pen pen)
        {
            graphics.DrawLine(pen, pt1: previousPoint, pt2: secondPoint);
        }
    }
}
