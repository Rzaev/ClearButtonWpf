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

namespace ClearButtonWpf
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

        Brush customColor;
        Random r = new Random();


        //private void Btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn2.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn2.Background}");
        //}

        private static SolidColorBrush CreateColor()
        {
            Random random = new Random();
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));
            return new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        //private void Btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn3.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn3.Background}");
        //}

        //private void Btn1_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn1.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn1.Background}");
        //}

        //private void Btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn4.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn4.Background}");
        //}

        //private void Btn5_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn5.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn5.Background}");
        //}

        //private void Btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    Btn6.Background = CreateColor();
        //    MessageBox.Show($"My color is {Btn6.Background}");
        //}

        private void myCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var t = e.OriginalSource;
            //MessageBox.Show(t.ToString());
            if (e.OriginalSource is System.Windows.Controls.Border)
            {
                Button activeRectangle = (Button)e.OriginalSource;
                myCanvas.Children.Remove(activeRectangle);
                //System.Windows.Controls.Border border = (System.Windows.Controls.Border)e.OriginalSource;

                //myCanvas.Children.Remove(border);

            }
            else
            {
                customColor = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));

                Rectangle newRectangle = new Rectangle()
                {
                    Width = 50,
                    Height = 50,
                    Fill = customColor,
                    StrokeThickness = 3,
                    Stroke = Brushes.Black
                };

                Canvas.SetLeft(newRectangle, Mouse.GetPosition(myCanvas).X);
                Canvas.SetTop(newRectangle, Mouse.GetPosition(myCanvas).Y);

                myCanvas.Children.Add(newRectangle);
            }
        }
    }
}
