using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAero2
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

        public void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        public void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            if (LogPanel.IsVisible)
            {
                LogPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void ButtonClose_Clic(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Operater_Selected(object sender, RoutedEventArgs e)
        {
            if (!LogPanel.IsVisible)
            {
                LogPanel.Visibility = Visibility.Visible;
                Glavnaknjiga.Visibility = Visibility.Collapsed;
                Proizvodnja.Visibility = Visibility.Collapsed;
                Trgovina.Visibility = Visibility.Collapsed;
                Usluge.Visibility = Visibility.Collapsed;
                Ulazniracuni.Visibility = Visibility.Collapsed;
                Obracuni.Visibility = Visibility.Collapsed;
                Osnovnasredstva.Visibility = Visibility.Collapsed;
                Materijano.Visibility = Visibility.Collapsed;
            }
            else
            {
                LogPanel.Visibility = Visibility.Collapsed;
                Glavnaknjiga.Visibility = Visibility.Visible;
                Proizvodnja.Visibility = Visibility.Visible;
                Trgovina.Visibility = Visibility.Visible;
                Usluge.Visibility = Visibility.Visible;
                Ulazniracuni.Visibility = Visibility.Visible;
                Obracuni.Visibility = Visibility.Visible;
                Osnovnasredstva.Visibility = Visibility.Visible;
                Materijano.Visibility = Visibility.Visible;
            }
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Glavnaknjiga.Visibility = Visibility.Visible;
            Proizvodnja.Visibility = Visibility.Visible;
            Trgovina.Visibility = Visibility.Visible;
            Usluge.Visibility = Visibility.Visible;
            Ulazniracuni.Visibility = Visibility.Visible;
            Obracuni.Visibility = Visibility.Visible;
            Osnovnasredstva.Visibility = Visibility.Visible;
            Materijano.Visibility = Visibility.Visible;
            LogPanel.Visibility = Visibility.Collapsed;
        }
    }
}
