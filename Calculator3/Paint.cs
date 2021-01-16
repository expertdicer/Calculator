using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math.Geometry;

namespace Calculator3
{

    public partial class Paint : Form
    {
        private double V;
        private double S1;
        private double S2;
        private double S3;
        private int can_draw = 0;
        private int is_missing = 0;
        private int is_using = 1;
        private int point_count = 0 ;

        public class point3D
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }

            public point3D()
            {

            }

            public point3D(float x, float y, float z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

        }
        System.Drawing.Point[] points = new Point[4];
        public Paint()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (point_count!=4)
            {
                Graphics g = pictureBox1.CreateGraphics();
                if (is_missing!=0)
                {
                    points[is_missing] = e.Location;
                }
                else
                {
                    points[point_count] = e.Location;
                }               
                g.SmoothingMode = SmoothingMode.AntiAlias;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkBlue);
                g.FillEllipse(myBrush, new Rectangle(e.X, e.Y, 6, 6));
                myBrush.Dispose();
                if (point_count == 0)
                {
                    draw_axis(sender, e);
                }
                point_count++;
                if (point_count == 4)
                {
                    can_draw = 1;
                }
                is_missing = 0;
            }   
        }
        private void draw(object sender, EventArgs e)
        {
            if (can_draw==1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.DarkBlue);
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkBlue);
                // Draw first 3 lines
                g.DrawLine(pen, points[0].X + 3, points[0].Y + 3, points[1].X + 3, points[1].Y + 3);
                g.DrawLine(pen, points[0].X + 3, points[0].Y + 3, points[2].X + 3, points[2].Y + 3);
                g.DrawLine(pen, points[0].X + 3, points[0].Y + 3, points[3].X + 3, points[3].Y + 3);
                // Create a array of 4 another points
                Point[] points2 = new Point[4];

                //Generating Cordinates of that 4 points
                points2[0].X = (points[1].X + points[2].X) - points[0].X;
                points2[0].Y = (points[1].Y + points[2].Y) - points[0].Y;
                points2[1].X = points[3].X - points[0].X + points[1].X;
                points2[1].Y = points[3].Y - points[0].Y + points[1].Y;
                points2[2].X = points[3].X - points[0].X + points[2].X;
                points2[2].Y = points[3].Y - points[0].Y + points[2].Y;
                points2[3].X = points[3].X - points[0].X + points2[0].X;
                points2[3].Y = points[3].Y - points[0].Y + points2[0].Y;


                //Drawing line and dot of that 4 points
                g.FillEllipse(myBrush, new Rectangle(points2[0].X, points2[0].Y, 6, 6));
                g.DrawLine(pen, points2[0].X + 3, points2[0].Y + 3, points[2].X + 3, points[2].Y + 3);
                g.DrawLine(pen, points2[0].X + 3, points2[0].Y + 3, points[1].X + 3, points[1].Y + 3);
                g.DrawLine(pen, points2[0].X + 3, points2[0].Y + 3, points2[3].X + 3, points2[3].Y + 3);


                g.FillEllipse(myBrush, new Rectangle(points2[1].X, points2[1].Y, 6, 6));
                g.DrawLine(pen, points2[1].X + 3, points2[1].Y + 3, points[3].X + 3, points[3].Y + 3);
                g.DrawLine(pen, points2[1].X + 3, points2[1].Y + 3, points[1].X + 3, points[1].Y + 3);
                g.DrawLine(pen, points2[1].X + 3, points2[1].Y + 3, points2[3].X + 3, points2[3].Y + 3);


                g.FillEllipse(myBrush, new Rectangle(points2[2].X, points2[2].Y, 6, 6));
                g.DrawLine(pen, points2[2].X + 3, points2[2].Y + 3, points[2].X + 3, points[2].Y + 3);
                g.DrawLine(pen, points2[2].X + 3, points2[2].Y + 3, points[3].X + 3, points[3].Y + 3);
                g.DrawLine(pen, points2[2].X + 3, points2[2].Y + 3, points2[3].X + 3, points2[3].Y + 3);

                g.FillEllipse(myBrush, new Rectangle(points2[3].X, points2[3].Y, 6, 6));
            }          
        }

        private void draw_axis(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen2 = new Pen(Color.DarkOrange);
            g.DrawLine(pen2, points[0].X + 3, points[0].Y + 3, points[0].X, -pictureBox1.Height);
            g.DrawLine(pen2, points[0].X + 3, points[0].Y + 3, pictureBox1.Width, points[0].Y);
            g.DrawLine(pen2, points[0].X + 3, points[0].Y + 3, -pictureBox1.Width, pictureBox1.Width + points[0].X);      
        }
        private void clear(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            points = new Point[4];
            point_count=0;
            can_draw = 0;
        }
        private void clear_screen(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            can_draw = 0;
        }
        private void draw_point_without(Point po)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.DarkBlue);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkBlue);
            foreach (Point p in points)
            {
                if (p!=po)
                {
                    g.FillEllipse(myBrush, new Rectangle(p.X, p.Y, 6, 6));
                    
                }                  
            }
            myBrush.Dispose();
        }
        private void clear_point_b(object sender, EventArgs e)
        {
            points[1] = new Point();
            clear_screen(sender, e);
            draw_point_without(points[1]);
            draw_axis(sender,e);
            can_draw = 0;
            is_missing = 1;
            point_count = 3;
        }
        private void clear_point_c(object sender, EventArgs e)
        {
            points[2] = new Point();
            clear_screen(sender, e);
            draw_point_without(points[2]);
            draw_axis(sender, e);
            can_draw = 0;
            is_missing = 2;
            point_count = 3;
        }
        private void clear_point_d(object sender, EventArgs e)
        {
            points[3] = new Point();
            clear_screen(sender, e);
            draw_point_without(points[3]);
            draw_axis(sender, e);
            can_draw = 0;
            is_missing = 3;
            point_count = 3;
        }

        private void close(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void Paint_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void cal_v(object sender, EventArgs e)
        {
            double length = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
            double width = Math.Sqrt(Math.Pow(points[0].X - points[2].X, 2) + Math.Pow(points[0].Y - points[2].Y, 2));
            double height = Math.Sqrt(Math.Pow(points[0].X - points[3].X, 2) + Math.Pow(points[0].Y - points[3].Y, 2));

            double Volume = length * width * height;
            MessageBox.Show("The Volume of the box is " + Volume.ToString() + " px^3");
        }

        private void cal_s(object sender, EventArgs e)
        {
            double length = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
            double width = Math.Sqrt(Math.Pow(points[0].X - points[2].X, 2) + Math.Pow(points[0].Y - points[2].Y, 2));
            double height = Math.Sqrt(Math.Pow(points[0].X - points[3].X, 2) + Math.Pow(points[0].Y - points[3].Y, 2));

            double area1 = length * width;
            double area2 = length * height;
            double area3 = height * width;

            double surfaceArea = 2 * (area1 + area2 + area3);
            MessageBox.Show("The surface area of the box is " + surfaceArea.ToString() + " px^2");
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point po = e.Location;
            Cordinates.Text = "X = " + po.X.ToString() + Environment.NewLine + "Y = " + po.Y.ToString();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Image img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            Graphics g = Graphics.FromImage(img);
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            Point start = new Point(rect.X+290, rect.Y+100);
            Size range = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height);
            g.CopyFromScreen(start, Point.Empty, range);

            //g.CopyFromScreen(start, new Point(-900, -900), new Size(pictureBox1.Width, pictureBox1.Height));

            img.Save(string.Format(@"C:\Users\ASUS\Desktop\p\a.png"));

            g.Dispose();
            DialogResult res = MessageBox.Show("Save successful !", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("This file is not Invalid");
                }
        }
    }
}
