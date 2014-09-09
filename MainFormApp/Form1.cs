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
        private const int buttonTop = 5;
        private const int spaceBetweenButtons = 5;
        private Size buttonSize = new Size(50,20);
        private int currentButtonLeft = 0;

        private Dictionary<String, Type> shapesTypes = new Dictionary<string, Type>(); 

        private List<Button> shapeButtons = new List<Button>(); 

        public Form1()
        {
            InitializeComponent();
            shapesTypes = AssemblyLoader.Loader.Load("Shapes");
            AddButtons();
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
            Button newButton = new Button
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
        }

        private ShapeList shapes = new ShapeList();

        private Shape currentShape;

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
           // currentShape = shapesTypes[((Button) sender).Text].GetConstructors().First(x => x.)
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
        }
    }
}
