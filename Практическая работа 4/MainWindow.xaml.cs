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

namespace Практическая_работа_4
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

        private void Season_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void zadacha1_Click(object sender, RoutedEventArgs e)
        {
            double x=double.Parse(varX.Text);
            switch (x)
            {
                case 0:
                    rez.Content = ("zero");
                    break;
                case 1:
                    rez.Content = ("one");
                    break;
                case 2:
                    rez.Content = ("two");
                    break;
                case 3:
                    rez.Content = ("three");
                    break;
                case 4:
                    rez.Content= ("four");
                    break;
                case 5:
                    rez.Content = ("five");
                    break;
                case 6:
                    rez.Content = ("six");
                    break;
                case 7:
                    rez.Content = ("seven");
                    break;
                case 8:
                    rez.Content = ("eight");
                    break;
                case 9:
                    rez.Content = ("nine");
                    break;
            }
        }
    }
}
