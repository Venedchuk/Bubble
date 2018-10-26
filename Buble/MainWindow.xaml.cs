using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Buble
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage carBitmap = new BitmapImage(new Uri("../../Images/car.jpg", UriKind.Relative));
        Image[] carImg = new Image[0];
        Random rnd = new Random();
        MainViewModel vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            //synchronizationContext = SynchronizationContext.Current;
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = new Button() { Content = "Catch",};
        }
    }
}
