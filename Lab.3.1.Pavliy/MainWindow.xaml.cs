
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab._3._1.Pavliy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(a.Text);
            double y1 = Convert.ToDouble(b.Text);
            double x2 = Convert.ToDouble(c.Text);
            double y2 = Convert.ToDouble(d.Text);

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);

            double distanceToOrigin = point1.DistanceToOrigin();

            double distanceBetweenPoints = point1.DistanceTo(point2);

            double radius, angle;
            point1.ToPolar(out radius, out angle);

            
            bool areEqual = point1.Equals(point2);

            result.Text = $"Расстояние до источника: {distanceToOrigin}\n" +
                          $"Расстояние между точками: {distanceBetweenPoints}\n" +
                          $"Полярные координаты точки 1: Радиус = {radius}, Угол = {angle}\n" +
                          $"Равны: {areEqual}";
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }

        public void ToPolar(out double r, out double theta)
        {
            r = DistanceToOrigin();
            theta = Math.Atan2(Y, X);
        }

        public bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }
    }

}
    