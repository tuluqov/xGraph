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
using System.Windows.Shapes;

namespace FigurePainter_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = Brushes.Brown;
        }

        private void Ellipse_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse.Fill = Brushes.LightBlue;
        }

        private void Ellipse_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var rectangle = new Ellipse();

            rectangle.Fill = Brushes.LightBlue;
            rectangle.Width = 100;
            rectangle.Height = 100;

            Canvas.SetLeft(rectangle, 200);
            Canvas.SetTop(rectangle, 200);

            PaintWindow.Children.Add(rectangle);
        }

        private void PaintWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var rectangle = new Ellipse();

            rectangle.Fill = Brushes.Black;
            rectangle.Width = 100;
            rectangle.Height = 100;

            Canvas.SetLeft(rectangle, e.GetPosition(PaintWindow).X);
            Canvas.SetTop(rectangle, e.GetPosition(PaintWindow).Y);

            PaintWindow.Children.Add(rectangle);
        }
    }
}
