using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.Windows.Media;
using SharpShapes;


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
            
            
            Square square = new Square(200);
            square.FillColor = System.Drawing.Color.Green;
            square.BorderColor = System.Drawing.Color.Red;
            
            
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
            Type classType = GetShapeTypeOf(className);
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return classConstructor.GetParameters().Length;
        }

         private static Type GetShapeTypeOf(string className)
         {
             return Assembly.GetAssembly(typeof(Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First();
         }


        public static Shape InstantiateWithArguments(string className, object[] args)
        {

            Type classType = GetShapeTypeOf(className);
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
            Argument1.Text = "0";
            Argument2.Text = "0";
            Argument3.Text = "0";
        
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve correct number of arguments
            string className = (String)ShapeType.SelectedValue;
            
            int argCount = ArgumentCountFor(className);
            object[] potentialArgs = new object[] { Int32.Parse(Argument1.Text), Int32.Parse(Argument2.Text), Int32.Parse(Argument3.Text) };
            // Create shape 
            Shape shape = InstantiateWithArguments(className, potentialArgs.Take(argCount).ToArray());
            // Draw shape
            // DrawSquare(50, 50, shape as Square);
            // GOAL: shape.DrawOnto(ShapeCanvas, 50, 50 );
            shape.DrawOnto(ShapeCanvas, 50, 50);


        }
        
    }
}
