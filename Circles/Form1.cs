using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Logic;

namespace Circles
{
    public partial class App : Form
    {
        private Graphics _fromGraphics;
        private float _xCenter;
        private float _yCenter;

        public App()
        {
            InitializeComponent();
            _fromGraphics = pictureBox.CreateGraphics();
            _xCenter = (pictureBox.Width + 1) / 2;
            _yCenter = (pictureBox.Height + 1) / 2;
        }

        private void Draw(Circle circle, Color color)
        {
            Pen brush = new Pen(color);

            float x = (float) (circle.X - circle.Radius) + _xCenter;
            float y = (float) (_yCenter - (circle.Y + circle.Radius));

            _fromGraphics.SmoothingMode = SmoothingMode.HighQuality;
            _fromGraphics.DrawEllipse(brush, x, y, (float) circle.Radius * 2, (float) circle.Radius * 2);

            brush.Dispose();
        }

        private void DrawCircles()
        {
            _fromGraphics.Clear(Color.White);
            try
            {
                var frtCircle = new Circle(double.Parse(X1.Text), double.Parse(Y1.Text), double.Parse(R1.Text));
                var sndCircle = new Circle(double.Parse(X2.Text), double.Parse(Y2.Text), double.Parse(R2.Text));

                Draw(frtCircle, Color.Red);
                Draw(sndCircle, Color.Blue);

                resultLabel.Text = frtCircle.Intersection(sndCircle) ? "Intersect" : "Do not intersect";
            }
            catch (Exception)
            {
                MessageBox.Show("Enter correct the data");
            }
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            DrawCircles();
        }
    }
}
