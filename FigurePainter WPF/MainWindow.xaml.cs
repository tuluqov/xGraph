using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using xGraph.Edges;
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


        private void PaintWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = new Point
            {
                X = e.GetPosition(PaintWindow).X,
                Y = e.GetPosition(PaintWindow).Y
            };


            string vertexType = AddVertexType.Text;

            if (vertexType == "")
            {
                MessageBox.Show("Выберите тип вершины!");
                return;
            }


            switch (vertexType)
            {
                case "Квадрат":
                    Graph.Add(new Square(point));
                    break;

                case "Круг":
                    Graph.Add(new Circle(point));
                    break;

                case "Треугольник":
                    Graph.Add(new Triangle(point));
                    break;
            }

            Shape drawingShape = Graph.GetLastVertex().GetDrawingObject();

            Canvas.SetLeft(drawingShape, e.GetPosition(PaintWindow).X - 25);
            Canvas.SetTop(drawingShape, e.GetPosition(PaintWindow).Y - 25);

            PaintWindow.Children.Add(drawingShape);


            //Добавление номеров вершин в список для выбора
            FirstVertex.Items.Add(new TextBlock
            {
                Text = Graph.GetLastVertex().Id.ToString()
            });

            SecondVertex.Items.Add(new TextBlock
            {
                Text = Graph.GetLastVertex().Id.ToString()
            });
        }

        private void AddEdgeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstVertex = Int32.Parse(FirstVertex.Text);
                int secondVertex = Int32.Parse(SecondVertex.Text);

                string edgeType = this.AddEdgeType.Text;

                if (edgeType == "")
                {
                    throw new ArgumentNullException("Выберите тип ребра.");
                }

                AddToGraph(edgeType, firstVertex, secondVertex);

                Shape drawingEdge = Graph.Edges.Last().GetDrawingObject();

                PaintWindow.Children.Add(drawingEdge);
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddToGraph(string edgeType, int firstVertex, int secondVertex)
        {
            switch (edgeType)
            {
                case "Прямая линия":
                    Graph.Add(new BaseLine(Graph.Vertices[firstVertex].Point, Graph.Vertices[secondVertex].Point), Graph.Vertices[firstVertex], Graph.Vertices[secondVertex]);
                    break;

                case "Прерывистая":
                    Graph.Add(new BrokenLine(Graph.Vertices[firstVertex].Point, Graph.Vertices[secondVertex].Point), Graph.Vertices[firstVertex], Graph.Vertices[secondVertex]);
                    break;

                case "Волнистая":
                    //Graph.Add(new WavyLine(Graph.Vertices[firstVertex].Point, Graph.Vertices[secondVertex].Point), Graph.Vertices[firstVertex], Graph.Vertices[secondVertex]);
                    break;

                case "Кривая":
                    Graph.Add(new IntermittentLine(Graph.Vertices[firstVertex].Point, Graph.Vertices[secondVertex].Point), Graph.Vertices[firstVertex], Graph.Vertices[secondVertex]);
                    break;
            }
        }
    }
}
