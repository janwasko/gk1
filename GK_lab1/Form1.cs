using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_lab1
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF P1 = new PointF();
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);
            g.DrawLine(pen1, 0, 0, P1.X, P1.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(pen1, 5, 5, 25, 75);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(pen1, 5, 5, 25, 75);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.DrawBezier(pen1, new Point(100, 100), new Point(200, 10), new Point(350, 50), new Point(500, 100));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PointF point1 = new PointF();
            point1.X = (float)Double.Parse(textBox3.Text);
            point1.Y = (float)Double.Parse(textBox4.Text);
            PointF point2 = new PointF();
            point2.X = (float)Double.Parse(textBox5.Text);
            point2.Y = (float)Double.Parse(textBox6.Text);
            PointF point3 = new PointF();
            point3.X = (float)Double.Parse(textBox7.Text);
            point3.Y = (float)Double.Parse(textBox8.Text);
            PointF point4 = new PointF();
            point4.X = (float)Double.Parse(textBox9.Text);
            point4.Y = (float)Double.Parse(textBox10.Text);
            PointF point5 = new PointF();
            point5.X = (float)Double.Parse(textBox11.Text);
            point5.Y = (float)Double.Parse(textBox12.Text);
            PointF point6 = new PointF();
            point6.X = (float)Double.Parse(textBox13.Text);
            point6.Y = (float)Double.Parse(textBox14.Text);
            PointF point7 = new PointF();
            point7.X = (float)Double.Parse(textBox15.Text);
            point7.Y = (float)Double.Parse(textBox16.Text);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            g.DrawPolygon(pen1, curvePoints);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.DrawArc(pen1, 5, 5, 125, 250, 45, 135);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
