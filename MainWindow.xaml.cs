using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ListOfFigures figures = new ListOfFigures(
                new Ellipse(200, 0, 300, 150),
                new Line(200, 300, 300, 150),
                new Rhombus(400, 250, 300, 150),
                new Square(500, 0, 300, 150),
                new Triangle(0, 200, 200, 200),
                new Circle(0, 0, 200, 200)
            );

            InitializeComponent();
            foreach(var e in figures)
            {
                grid.Children.Add(e.DrawFigure());
            }
        }
    }
}
