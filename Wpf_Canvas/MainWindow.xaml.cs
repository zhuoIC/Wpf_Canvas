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
using System.Threading;

namespace Wpf_Canvas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAnadirContenido_Click(object sender, RoutedEventArgs e)
        {
            // Creo un rectangulo nuevo para añadirlo
            Rectangle rct = new Rectangle();
            Color n = new Color();
            n.A = 255;
            n.B = (byte)rnd.Next(255);
            n.R = (byte)rnd.Next(255);
            n.G = (byte)rnd.Next(255);
            rct.Height = rnd.Next(50,150);
            rct.Width = rnd.Next(50, 150);
            rct.Fill = new SolidColorBrush(n);
            // Elegit posición con propiedades adjuntas o de dependencia
            Canvas.SetRight(rct, rnd.Next(50, 150));
            Canvas.SetBottom(rct, rnd.Next(50, 150));
            cnvColores.Children.Add(rct);
        }
    }
}
