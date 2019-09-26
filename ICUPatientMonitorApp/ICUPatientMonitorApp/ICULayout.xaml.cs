using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ICUPatientMonitorApp
{
    /// <summary>
    /// Interaction logic for ICULayout.xaml
    /// </summary>
    public partial class ICULayout : UserControl
    {
        /// <summary>
        /// This is providing UI for ICU beds
        /// </summary>

        #region Constructor
        public ICULayout()
        {
            InitializeComponent();
            Bed1.Background = new SolidColorBrush(Colors.Yellow);
            Bed2.Background = new SolidColorBrush(Colors.Yellow);
            Bed3.Background = new SolidColorBrush(Colors.Yellow);
            Bed4.Background = new SolidColorBrush(Colors.Yellow);
            Bed5.Background = new SolidColorBrush(Colors.Yellow);
            Bed6.Background = new SolidColorBrush(Colors.Yellow);

        }
        #endregion

        /// <summary>
        /// when Discharge button will clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void Button_Click_Discharge(object sender, RoutedEventArgs e)
        {
            string x = Change.Text;
            if (x != null && FindName(x) != null)
            {
                Button tb = FindName(x) as Button;
                tb.Background = new SolidColorBrush(Colors.Yellow);
            }        
        }
        /// <summary>
        /// what will happen after the Disable Alarm click
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void Button_Click_Disable_Alarm(object sender, RoutedEventArgs e)
        {
            string x = Change.Text;
            if (x != null && FindName(x) != null)
            {
                Button tb = FindName(x) as Button;
                if (tb.Background.ToString() == "#FFFF0000")
                {
                    tb.Background = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    MessageBox.Show("Select Alarmed Bed");
                }
            }
            else
            {
                MessageBox.Show("No Alarm Occured");
            }
        }
        #region OnButton Functionality
        private void Bed1_Click(object sender, RoutedEventArgs e)
        {
            Change.Text = "Bed1";
        }

        private void Bed2_Click(object sender, RoutedEventArgs e)
        {
           Change.Text = "Bed2";

        }

        private void Bed3_Click(object sender, RoutedEventArgs e)
        {
            Change.Text = "Bed3";

        }

        private void Bed4_Click(object sender, RoutedEventArgs e)
        {
            Change.Text = "Bed4";
        }

        private void Bed5_Click(object sender, RoutedEventArgs e)
        {
            Change.Text = "Bed5";
        }

        private void Bed6_Click(object sender, RoutedEventArgs e)
        {
            Change.Text = "Bed6";
        }
        #endregion

        /// <summary>
        /// Recent critical patient indication in textbox 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">events</param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x = CriticalCondition.Text;
            if (x != null && FindName("Bed" + x) != null)
            {
                Button tb = FindName("Bed" + x) as Button;
                tb.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}