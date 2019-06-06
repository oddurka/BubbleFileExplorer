using BubbleFileExplorer.Node;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
using System.IO;

namespace BubbleFileExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (bubbleExplorer.Children.Count <= 0)
            {
                bola.Fill = Brushes.Green;
                bola.Width = 100;
                bola.Height = 100;

                Canvas.SetTop(bola, (bubbleExplorer.ActualHeight / 2));
                Canvas.SetLeft(bola, (bubbleExplorer.ActualWidth / 2));
                bubbleExplorer.Children.Add(bola);
            }
        }

        private Ellipse bola = new Ellipse();
        private Bubble bubble = new Bubble();

        private void BubbleExplorer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Ellipse newEllipse = new Ellipse();
            bubble.Title = "Main";
            foreach(var item in bubble.filePaths)
            {
                Trace.WriteLine(item);
            }
        }

        private void BubbleExplorer_MouseMove(object sender, MouseEventArgs e)
        {
            var element = (UIElement)sender;
            element.CaptureMouse();

            Point punto = e.GetPosition(bubbleExplorer);
            int mouseX = (int)punto.X;
            int mouseY = (int)punto.Y;
            bola.SetValue(Canvas.LeftProperty, (double)mouseX); //set x
            bola.SetValue(Canvas.TopProperty, (double)mouseY); //set y
        }
    }
}
