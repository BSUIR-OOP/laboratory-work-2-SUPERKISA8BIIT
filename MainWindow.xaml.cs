using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Point = System.Windows.Point;


namespace paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int x ;
        public int y ;
        public bool ButtonActive { get; set; } = false;
        public delegate Figure FirstDelegate(int x, int y);
        public MainWindow()
        {
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"D:\study\4_sem\oop\lb1\paint\figures\back.jpg");


            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();
            InitializeComponent();
            var delList = new List<FirstDelegate>() 
            {
                new FirstDelegate(Circle.CircleDelegate),
                new FirstDelegate(Ellipse.EllipseDelegate),
                new FirstDelegate(Line.LineDelegate),
                new FirstDelegate(Rhombus.RhombusDelegate),
                new FirstDelegate(Square.SquareDelegate),
                new FirstDelegate(Triangle.TriangleDelegate)
            };
            Dictionary<string, FirstDelegate> dict = new Dictionary<string, FirstDelegate>()
            {
                {"Circle", new FirstDelegate(Circle.CircleDelegate) },
                {"Ellipse", new FirstDelegate(Ellipse.EllipseDelegate) },
                {"Line", new FirstDelegate(Line.LineDelegate) },
                {"Rhombus", new FirstDelegate(Rhombus.RhombusDelegate) },
                {"Square", new FirstDelegate(Square.SquareDelegate) },
                {"Triangle", new FirstDelegate(Triangle.TriangleDelegate) }
            };

            foreach(var item in dict)
            {
                Button btn = new Button() {
                    IsEnabled = false,
                    Margin = new Thickness(4),
                    Width = 55,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Content = item.Key,
                    Tag = item.Value
                };
                btn.Click += Circle_Btn_Click;
                buttons.Children.Add(btn);
            }
            image.Source = myBitmapImage;
        }
        private void Circle_Btn_Click(object sender, RoutedEventArgs e)
        {
            FirstDelegate del = (FirstDelegate)((Button)sender).Tag;
            Figure c = del(x, y); 
            grid.Children.Add(c.DrawFigure());

            foreach (Button btn in buttons.Children)
            {
                btn.IsEnabled = false;
            }
        }


        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            foreach(Button btn in buttons.Children)
            {
                btn.IsEnabled = true;
            }

            Point p = e.GetPosition(image);
            x = (int)p.X;
            y = (int)p.Y;           
        }
      
    }
}
