using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CG_Lab
{
    public partial class Form1 : Form
    {
        List<Polygon> polygons;
        Color currColor = Color.Black;
        int currPolygonInd = 0;

        public Form1()
        {
            InitializeComponent();
            Bitmap PictureBoxClear = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(PictureBoxClear))
                g.Clear(Color.White);
            pictureBox.Image = PictureBoxClear;
            polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            CurrColorPB.BackColor = currColor;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Bitmap PictureBoxClear = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(PictureBoxClear))
                g.Clear(Color.White);
            pictureBox.Image = PictureBoxClear;
        }

        private void NewPolygon_Click(object sender, EventArgs e)
        {
            if (polygons.Count > currPolygonInd)
            {
                int len = polygons[currPolygonInd].points.Count;
                if (len > 2)
                    DrawLineVu(polygons[currPolygonInd].points[len - 1], polygons[currPolygonInd].points[0]);
                currPolygonInd++;
            }
            Random r = new Random();
            currColor = Color.FromArgb(r.Next(100, 256), r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            CurrColorPB.BackColor = currColor;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (polygons.Count == currPolygonInd)
                polygons.Add(new Polygon());
            polygons[currPolygonInd].points.Add(new Point(e.Location.X, e.Location.Y));
            int len = polygons[currPolygonInd].GetPointCount();
            if (len > 1)
                DrawLineVu(polygons[currPolygonInd].points[len - 2], polygons[currPolygonInd].points[len - 1]);

        }

        private void DrawLineVu(Point p0, Point p1)
        {
            int x0 = p0.X;
            int x1 = p1.X;
            int y0 = p0.Y;
            int y1 = p1.Y;

            Bitmap pb = new Bitmap(pictureBox.Image);

            pb.SetPixel(x1, y1, Color.FromArgb(255, 0, 0, 0));

            float deltaX = x1 - x0;
            float deltaY = y1 - y0;
            float m = Math.Abs(deltaY / deltaX);

            if (m <= 1)
            {
                float gradient = deltaY / deltaX;
                if (x0 <= x1)
                {
                    float y = y0 + gradient;
                    for (int x = x0 + 1; x <= x1; x++)
                    {
                        int alpha = (int)((1 - (y - (int)y)) * 255);
                        pb.SetPixel(x, (int)y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((y - (int)y) * 255);
                        pb.SetPixel(x, (int)y + 1, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        y += gradient;
                    }
                }
                else
                {
                    gradient *= -1;
                    float y = y0 + gradient;
                    for (int x = x0 - 1; x >= x1; x--)
                    {
                        int alpha = (int)((1 - (y - (int)y)) * 255);
                        pb.SetPixel(x, (int)y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((y - (int)y) * 255);
                        pb.SetPixel(x, (int)y + 1, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        y += gradient;
                    }
                }
            }
            else
            {
                float gradient = deltaX / deltaY;
                if (y0 <= y1)
                {
                    float x = x0 + gradient;
                    for (int y = y0 + 1; y <= y1; y++)
                    {
                        int alpha = (int)((1 - (x - (int)x)) * 255);
                        pb.SetPixel((int)x, y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((x - (int)x) * 255);
                        pb.SetPixel((int)x + 1, y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        x += gradient;
                    }
                }
                else
                {
                    gradient *= -1;
                    float x = x0 + gradient;
                    for (int y = y0 - 1; y >= y1; y--)
                    {
                        int alpha = (int)((1 - (x - (int)x)) * 255);
                        pb.SetPixel((int)x, y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((x - (int)x) * 255);
                        pb.SetPixel((int)x + 1, y, Color.FromArgb(255, currColor.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            currColor.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        x += gradient;
                    }
                }
            }
            pictureBox.Image = pb;
        }
    }

    public class Polygon
    {
        public List<Point> points;

        public Polygon() => points = new List<Point>();

        public int GetPointCount() => points.Count;
    }
}
