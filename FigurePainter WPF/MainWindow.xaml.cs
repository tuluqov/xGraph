using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using xGraph;
using xGraph.GraphContent;
using xGraph.Vertexes;
using Point = xGraph.Point;

namespace FigurePainter_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Graph Graph { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Graph = new Graph();
        }

        //private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        //{
        //    Ellipse.Fill = Brushes.Brown;
        //}

        //private void Ellipse_OnMouseLeave(object sender, MouseEventArgs e)
        //{
        //    Ellipse.Fill = Brushes.LightBlue;
        //}

        //private void Ellipse_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var rectangle = new Ellipse();

        //    rectangle.Fill = Brushes.LightBlue;
        //    rectangle.Width = 100;
        //    rectangle.Height = 100;

        //    Canvas.SetLeft(rectangle, 200);
        //    Canvas.SetTop(rectangle, 200);

        //    PaintWindow.Children.Add(rectangle);
        //}

        private void PaintWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //var rectangle = new Ellipse
            //{
            //    Fill = Brushes.BlueViolet,
            //    Width = 50,
            //    Height = 50
            //};

            Point point = new Point
            {
                X = e.GetPosition(PaintWindow).X,
                Y = e.GetPosition(PaintWindow).Y
            };


            Graph.Add(new Triangle(point));

            try
            {
                Shape drawingShape = Graph.Vertices[0].GetDrawingObject();


                Canvas.SetLeft(drawingShape, e.GetPosition(PaintWindow).X - 25);
                Canvas.SetTop(drawingShape, e.GetPosition(PaintWindow).Y - 25);

                PaintWindow.Children.Add(drawingShape);
            }
            catch (IndexOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        


        
    }
}
