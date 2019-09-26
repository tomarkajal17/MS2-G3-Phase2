using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ICUPatientMonitorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main Window 
        /// </summary>

        #region DataMember
        ICULayout icuLayout;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            icuLayout = new ICULayout();
        }
        #endregion

        /// <summary>
        /// Allocate button click event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void Button_Click_Allocate(object sender, RoutedEventArgs e)
        {
            Notification.Text = null;

        }

        /// <summary>
        /// Setup Button Click Event
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e"></param>
        private void Button_Click_Setup(object sender, RoutedEventArgs e)
        {
            int tB = Convert.ToInt32(TotalBeds.Text);
            if (tB > 0)
            {
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
        }

        /// <summary>
        /// Notification(TextBox) value change events
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void Notification_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x = Notification.Text;
            if(x != null && icuLayout.FindName("Bed" + x) != null)
            {
                    Button tb = icuLayout.FindName("Bed" + x) as Button;
                    tb.Background = new SolidColorBrush(Colors.Green);
            }            
        }
    }
}
