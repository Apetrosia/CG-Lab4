using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CG_Lab
{
    public partial class Form1 : Form
    {
        List<Polygon> polygons;
        Color currColor = Color.Black;
        int currPolygonInd = 0;

        private Action selectedAction;

        private enum Action { Move, Rotation1, Rotation2, Scaling1, Scaling2 };

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
            transformBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    MyGraphics.DrawLineVu(pictureBox, currColor, polygons[currPolygonInd].points[len - 1], polygons[currPolygonInd].points[0]);
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
                MyGraphics.DrawLineVu(pictureBox, currColor, polygons[currPolygonInd].points[len - 2], polygons[currPolygonInd].points[len - 1]);

        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            switch (transformBox.SelectedIndex)
            {
                case (int)Action.Move:

                    break;
                case (int)Action.Rotation1:

                    break;
                case (int)Action.Rotation2:
                    RotateCenter();
                    break;
                case (int)Action.Scaling1:

                    break;
                case (int)Action.Scaling2:

                    break;
                default:
                    MessageBox.Show("Не реализованная операция!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void RotateCenter()
        {
            int angle = (int)numericUpDown1.Value;

            polygons.ForEach(poly =>
            
            {
                Point center = poly.GetCenter();
                MyGraphics.ClearPolygon(pictureBox, poly.points);

                Matrix translationMatrix = new Matrix( new int[,]
                    {
                    { 1, 0, -center.X },
                    { 0, 1, -center.Y },
                    { 0, 0, 1 }
                    });

                for (int i = 0; i < poly.points.Count; i++)
                {
                    
                        Matrix pointMatrix = new Matrix(new int[,]
                        {
                        { poly.points[i].X },
                        { poly.points[i].Y },
                        { 1 }
                        });
                        
                        Matrix newPointMatrix = pointMatrix * translationMatrix;

                        poly.points[i] = new Point(newPointMatrix[0, 0], newPointMatrix[1, 0]);
                    
                }

                MyGraphics.DrawPolygon(pictureBox, currColor, poly.points);
            }

            );

            pictureBox.Refresh();
        }

    }

    public class Polygon
    {
        public List<Point> points;

        public Polygon() => points = new List<Point>();

        public int GetPointCount() => points.Count;

        public Point GetCenter()
        {
            float x = 0, y = 0;
            for (int i = 0; i < points.Count; i++)
            {
                x += points[i].X;
                y += points[i].Y;
            }
            return new Point((int)Math.Round(x / points.Count), (int)Math.Round(y / points.Count));
        }
    }

    public class Matrix
    {
        public int[,] Values { get; }

        public Matrix(int[,] values)
        {
            Values = values;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            int rowsA = A.Values.GetLength(0);
            int colsA = A.Values.GetLength(1);
            int rowsB = B.Values.GetLength(0);
            int colsB = B.Values.GetLength(1);

            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += A.Values[i, k] * B.Values[k, j];
                    }
                }
            }

            return new Matrix(result);
        }

        public int this[int row, int column]
        {
            get
            {
                return Values[row, column];
            }
            set
            {
                Values[row, column] = value;
            }
        }
    }

    public static class MyGraphics
    {

        public static void ClearPolygon(PictureBox pictureBox, List<Point> points)
        {
            DrawPolygon(pictureBox, Color.White, points);
        }

        public static void DrawPolygon(PictureBox pictureBox, Color color, List<Point> points)
        {
            if (points.Count < 2)
                return;

            for (int i = 0; i < points.Count; i++)
            {
                Point p0 = points[i];
                Point p1 = points[(i + 1) % points.Count];
                DrawLineVu(pictureBox, color, p0, p1);
            }
        }

        public static void DrawLineVu(PictureBox pictureBox, Color color, Point p0, Point p1)
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
                        pb.SetPixel(x, (int)y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((y - (int)y) * 255);
                        pb.SetPixel(x, (int)y + 1, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
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
                        pb.SetPixel(x, (int)y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((y - (int)y) * 255);
                        pb.SetPixel(x, (int)y + 1, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
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
                        pb.SetPixel((int)x, y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((x - (int)x) * 255);
                        pb.SetPixel((int)x + 1, y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
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
                        pb.SetPixel((int)x, y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        alpha = (int)((x - (int)x) * 255);
                        pb.SetPixel((int)x + 1, y, Color.FromArgb(255, color.R * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.G * alpha / 255 + (255 - alpha) * 255 / 255,
                            color.B * alpha / 255 + (255 - alpha) * 255 / 255));
                        x += gradient;
                    }
                }
            }
            pictureBox.Image = pb;
        }
    }

}
