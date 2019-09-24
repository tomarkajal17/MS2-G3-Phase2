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

namespace ICUPatientMonitorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICULayout icuLayout;
        public MainWindow()
        {
            InitializeComponent();
            icuLayout = new ICULayout();

        }

        private void Button_Click_Allocate(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
            Notification.Text = null;
            MessageBox.Show("Allocated");
        }

        private void Button_Click_Setup(object sender, RoutedEventArgs e)
        {
            // Method intentionally left empty.
            Window win = new Window();
            win.Content = icuLayout;
            win.Title = "ICU";
            win.Width = 600;
            win.Height = 500;
            win.Show();
            Setup.IsEnabled = false;
            Notification1.Text = "ICU setup has been done.";
            Notification1.FontSize = 15;
            Notification1.Background = new SolidColorBrush(Colors.Red);
        }

        private void Notification_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x = Notification.Text;
            if (x.Equals("Bed1"))
            {
                icuLayout.Bed1.Background = new SolidColorBrush(Colors.Green);
            }
            else if (x.Equals("Bed2"))
            {
                icuLayout.Bed2.Background = new SolidColorBrush(Colors.Green);
            }
            else if (x.Equals("Bed3"))
            {
                icuLayout.Bed3.Background = new SolidColorBrush(Colors.Green);
            }
            else if (x.Equals("Bed4"))
            {
                icuLayout.Bed4.Background = new SolidColorBrush(Colors.Green);
            }
            else if (x.Equals("Bed5"))
            {
                icuLayout.Bed5.Background = new SolidColorBrush(Colors.Green);
            }
            else if (x.Equals("Bed6"))
            {
                icuLayout.Bed6.Background = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
