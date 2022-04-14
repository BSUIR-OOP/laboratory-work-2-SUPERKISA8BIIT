using System;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows;
using System.Reflection;
using System.IO;

namespace paint
{
    public class Figure
    {
        readonly static string path = GetExecutingDirectoryName() + @"\figures\";
        public virtual string fileName => string.Empty;
        private Image myImage;
        public Figure(int x, int y, int width, int height)
        {
            myImage = new Image();
            myImage.Margin = new Thickness(x, y, 0, 0); 
            myImage.Width = width;
            myImage.Height = height;

            myImage.Stretch = System.Windows.Media.Stretch.Fill;
            myImage.HorizontalAlignment = HorizontalAlignment.Left;
            myImage.VerticalAlignment = VerticalAlignment.Top;
        }
        public static string GetExecutingDirectoryName()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory.FullName;
        }
        public Image DrawFigure()
        {
            string full_path = string.Concat(path, fileName);
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(full_path);


            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();


            myImage.Source = myBitmapImage;
            return myImage;        
        }
    }
}
