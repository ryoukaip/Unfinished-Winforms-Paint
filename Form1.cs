using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PaintWhyyy
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap, tempBitmap;
        private Point previousPoint;
        private Point secondPoint;
        private bool isDrawing;
        private string drawingMode = "freeLine";
        private Pen pen;
        public Form1()
        {
            InitializeComponent();

            // Create a new bitmap with the same size as the picture box
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tempBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            // Set the initial background color
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
            }
            using (Graphics graphics = Graphics.FromImage(tempBitmap))
            {
                graphics.Clear(Color.Transparent);
            }
            pen = new Pen(Color.Black, 1);
            // Attach event handlers
            
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Start drawing
            isDrawing = true;
            previousPoint = e.Location;
            switch (drawingMode)
            {
                case "line":
                    {
                        secondPoint = e.Location;
                        break;
                    }
                case "rectangle":
                    {
                        secondPoint = e.Location;
                        break;
                    }
                case "circle":
                    {
                        secondPoint = e.Location;
                        break;
                    }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                switch (drawingMode)
                {
                    case "freeLine":
                        {
                            freeLine.Draw(bitmap, previousPoint, e, pen);
                            previousPoint = e.Location;
                            pictureBox.Invalidate();
                            break;
                        }
                    case "line":
                        {
                            
                            //line.Draw(bitmap, previousPoint, e.Location,pen);
                            pictureBox.Refresh();
                            secondPoint = e.Location;
                            
                            break;
                        }
                    case "rectangle":
                        {
                            pictureBox.Refresh();
                            secondPoint = e.Location;
                            break;
                        }
                    case "circle":
                        {
                            pictureBox.Refresh();
                            secondPoint = e.Location;
                            break;
                        }
                    default:
                        break;
                }
                // Draw a line from the previous point to the current point


                // Redraw the picture box
                
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop drawing
            isDrawing = false;
            secondPoint = e.Location;
            switch (drawingMode)
            {
                case "freeLine":
                    {
                        freeLine.Draw(bitmap, previousPoint, e, pen);
                        //previousPoint = e.Location;
                        break;
                    }
                case "line":
                    {
                        line.Draw(bitmap, previousPoint, secondPoint, pen);
                        pictureBox.Invalidate();
                        break;
                    }
                case "rectangle":
                    {
                        rectangle.Draw(bitmap, previousPoint, secondPoint, pen);
                        pictureBox.Invalidate();
                        break;
                    }
                case "circle":
                    {
                        circle.Draw(bitmap, previousPoint, secondPoint, pen);
                        pictureBox.Invalidate();
                        break;
                    }
                default:
                    break;
            }
            
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {

            {
                if ((isDrawing && drawingMode == "line"))
                {
                    e.Graphics.DrawLine(pen, previousPoint, secondPoint);
                    return;
                }
                else if (isDrawing && drawingMode == "circle")
                {
                    e.Graphics.DrawEllipse(pen, previousPoint.X, previousPoint.Y, secondPoint.X - previousPoint.X, secondPoint.Y - previousPoint.Y);
                    return;
                }
                else if (isDrawing && drawingMode == "rectangle")
                {
                    e.Graphics.DrawRectangle(pen, previousPoint.X, previousPoint.Y, secondPoint.X - previousPoint.X, secondPoint.Y - previousPoint.Y);
                    return;
                }
            }
            e.Graphics.DrawImage(bitmap, Point.Empty);
            //pictureBox.Invalidate();
            
            /*
            // Draw the bitmap on the picture box
            switch (drawingMode)
            {
                case "freeLine":
                    {
                        e.Graphics.DrawImage(bitmap, Point.Empty);
                        break;
                    }
                case "line":
                    {
                        e.Graphics.DrawImage(bitmap, Point.Empty);
                        break;
                    }
                default:
                    break;
            }*/

        }

        private void button_freeline_Click(object sender, EventArgs e)
        {
            drawingMode = "freeLine";
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            drawingMode = "line";
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            drawingMode = "rectangle";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //dialogbox do you want to exit application
            DialogResult result = MessageBox.Show("Do you want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            // clear all picture box
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
            }
            pictureBox.Invalidate();
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            drawingMode = "circle";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)numericUpDown1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                label1.BackColor = colorDialog.Color;
            }
        }
    }
}
