using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1;
using Lab1.Shapes;

namespace MainFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shapes = new ShapeList
            {
                new Ellipse(Color.Red, new Point(10,10), 50,70),
                new Line(Color.Black, new Point(200,200), 40,80),
                new Rectlange(Color.Yellow, new Point(500,200), 450,200),
                new Triangle(Color.Blue, new Point(700, 300), 100),
                new RegularPoligon(Color.Green, new Point(50,250), 100, 7),
                new Trapizoid(Color.Gray, new Point(50, 400), 200, 150, Math.PI/2.5)
            };
        }

        private ShapeList shapes;

        private void drawButton_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                shapes.DrawAll(graphics);
            }
            pictureBox.Image = bitmap;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
        }
    }
}
