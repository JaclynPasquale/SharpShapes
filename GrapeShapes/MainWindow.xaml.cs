using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Reflection;
using SharpShapes;
using System.Drawing;


namespace GrapeShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateClassList();
            DrawRectangle();
            DrawSquare(1, 50, new Square(30));
            Square square = new Square(200);
            square.FillColor = System.Drawing.Color.Green;
            square.BorderColor = System.Drawing.Color.Red;
            DrawSquare(50, 5, square);
            
        }

        private void PopulateClassList()
        {
            var classList = new List<string>();
            var shapeType = typeof(Shape);
            foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes())
            {
                if (type.IsSubclassOf(shapeType) && !type.IsAbstract)
                {
                    classList.Add(type.Name);
                }
            }
            ShapeType.ItemsSource = classList;
        }


         public static int ArgumentCountFor(string className)
        {
            Type classType = Assembly.GetAssembly(typeof(Shape)).GetTypes().Where( shapeType => shapeType.Name == className).First();
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return classConstructor.GetParameters().Length;
        }


        public static Shape InstantiateWithArguments(string className, object[] args)
        {
            Type classType = Type.GetType(className);
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return (Shape)classConstructor.Invoke(args);
        }

    
        private void ShapeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string className = (String) ShapeType.SelectedValue;
            Argument1.Text = ArgumentCountFor(className).ToString();

            // SOLUTION 2
            int argCount = ArgumentCountFor(className);
            Argument1.IsEnabled = true;
            Argument2.IsEnabled = (argCount > 1);
            Argument3.IsEnabled = (argCount > 2);
            
            // SOLUTION 1
            //if (argCount == 1)
            //{
            //    Argument2.IsEnabled = false;
            //    Argument3.IsEnabled = false;
            //}
            //else if (argCount == 2)
            //{
            //    Argument3.IsEnabled = false;
            //    Argument2.IsEnabled = true;
            //    Argument1.IsEnabled = true;
            //}
            //else 
            //{
            //    Argument1.IsEnabled = true;
            //    Argument2.IsEnabled = true;
            //    Argument3.IsEnabled = true;
            //}
            
            
        }


        
        // need to check the number of arguments
        // if number of args is 3, do nothing
        // if number of args is 2, disable box 3
        // if number of args is 1, diable box 2 and 3
        // on selection change maka all boxes enabled




        private void DrawRectangle()
        {
            System.Windows.Shapes.Polygon myPolygon = new System.Windows.Shapes.Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Tomato;
            myPolygon.Fill = System.Windows.Media.Brushes.Bisque;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(1, 50);
            System.Windows.Point Point2 = new System.Windows.Point(1, 80);
            System.Windows.Point Point4 = new System.Windows.Point(50, 80);
            System.Windows.Point Point3 = new System.Windows.Point(50, 50);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPolygon.Points = myPointCollection;
            ShapeCanvas.Children.Add(myPolygon);
        }
        private void DrawSquare(int x, int y, Square square)
        {
            int squareSide = (int)square.Width;

            SolidColorBrush mediaFillColor = new SolidColorBrush();
            mediaFillColor.Color = System.Windows.Media.Color.FromArgb(square.FillColor.A, square.FillColor.R, square.FillColor.G, square.FillColor.B);

            SolidColorBrush mediaBorderColor = new SolidColorBrush();
            mediaBorderColor.Color = System.Windows.Media.Color.FromArgb(square.BorderColor.A, square.BorderColor.R, square.BorderColor.B, square.BorderColor.G);

            System.Windows.Shapes.Polygon mySquare = new System.Windows.Shapes.Polygon();

            mySquare.Stroke = mediaBorderColor;
            mySquare.Fill = mediaFillColor;
            mySquare.StrokeThickness = 2;
            mySquare.HorizontalAlignment = HorizontalAlignment.Right;
            mySquare.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(x, y);
            System.Windows.Point Point2 = new System.Windows.Point(x + squareSide, y);
            System.Windows.Point Point3 = new System.Windows.Point(x + squareSide, y + squareSide);
            System.Windows.Point Point4 = new System.Windows.Point(x, y + squareSide);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            mySquare.Points = myPointCollection;
            ShapeCanvas.Children.Add(mySquare);
        }
        
    }
}
