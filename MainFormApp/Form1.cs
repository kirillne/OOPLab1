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

namespace MainFormApp
{
    public partial class Form1 : Form
    {
        private const int buttonTop = 5;
        private const int spaceBetweenButtons = 5;
        private Size buttonSize = new Size(100,30);
        private int currentButtonLeft = 20;

        private Bitmap mainBitmap;

        private Dictionary<String, Type> shapesTypes = new Dictionary<string, Type>(); 

        private List<Button> shapeButtons = new List<Button>();

        private Type currentShapeType;

        private Shape currentShape;

        private ShapeList shapes = new ShapeList();

        private Point mouseDownPoint;

        private bool isDrawingModeEnabled = false;

        public Form1()
        {
            InitializeComponent();
            shapesTypes = AssemblyLoader.Loader.Load("Shapes");
            AddButtons();
            currentShapeType = shapesTypes.First(x => true).Value;
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void AddButtons()
        {
            foreach (var shapeType in shapesTypes)
            {
                AddButton(shapeType);
            }
        }

        private void AddButton(KeyValuePair<string, Type> shapeType)
        {
            var newButton = new Button
            {
                Text = shapeType.Key,
                Height = buttonSize.Height,
                Width = buttonSize.Width,
                Top = buttonTop,
                Left = currentButtonLeft,
            };
            currentButtonLeft += buttonSize.Width + spaceBetweenButtons;
            newButton.Click += ShapeButtonClick;
            shapeButtons.Add(newButton);
            this.Controls.Add(newButton);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                shapes.DrawAll(graphics);
            }
            pictureBox.Image = bitmap;
        }

        private void ShapeButtonClick(object sender, EventArgs e)
        {
            currentShapeType = shapesTypes[((Button) sender).Text];
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            currentShape = (Shape)Activator.CreateInstance(currentShapeType, Color.Green, e.Location);
            mouseDownPoint = e.Location;
            isDrawingModeEnabled = true;
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawingModeEnabled)
            {
                if (currentShape is RectlangeBaseShape)
                {
                    var rectlangeBaseShape = currentShape as RectlangeBaseShape;
                    rectlangeBaseShape.Height = e.Y - mouseDownPoint.Y;
                    rectlangeBaseShape.Width = e.X - mouseDownPoint.X;
                }

                var tempBitmap = new Bitmap(mainBitmap);
                using (var graphics = Graphics.FromImage(tempBitmap))
                {
                    currentShape.Draw(graphics);
                }
                pictureBox.Image = tempBitmap;
            }
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawingModeEnabled)
            {
                using (var graphics = Graphics.FromImage(mainBitmap))
                {
                    currentShape.Draw(graphics);
                }
                pictureBox.Image.Dispose();
                pictureBox.Image = mainBitmap;
                isDrawingModeEnabled = false;
            }
        }
    }
}
