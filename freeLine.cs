using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp_PaintWhyyy
{
    internal class freeLine
    {
        public static void Draw(Bitmap bitmap, Point previousPoint, MouseEventArgs e, Pen pen)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawLine(pen, previousPoint, e.Location);
            }
        }
    }
}
