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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ICULayout : UserControl
    {
        public ICULayout()
        {
            InitializeComponent();

            Discharge.Items.Add("Bed1");
            Discharge.Items.Add("Bed2");
            Discharge.Items.Add("Bed3");
            Discharge.Items.Add("Bed4");
            Discharge.Items.Add("Bed5");
            Discharge.Items.Add("Bed6");

            DisableAlarm.Items.Add("Bed1");
            DisableAlarm.Items.Add("Bed2");
            DisableAlarm.Items.Add("Bed3");
            DisableAlarm.Items.Add("Bed4");
            DisableAlarm.Items.Add("Bed5");
            DisableAlarm.Items.Add("Bed6");


            Bed1.Background = new SolidColorBrush(Colors.Yellow);
            Bed2.Background = new SolidColorBrush(Colors.Yellow);
            Bed3.Background = new SolidColorBrush(Colors.Yellow);
            Bed4.Background = new SolidColorBrush(Colors.Yellow);
            Bed5.Background = new SolidColorBrush(Colors.Yellow);
            Bed6.Background = new SolidColorBrush(Colors.Yellow);

        }
        private void ComboBox_SelectionChanged_Disable_Alarm(object sender, SelectionChangedEventArgs e)
        {
            // Method intentionally left empty.
        }

        private void ComboBox_SelectionChanged_PatientInfo(object sender, SelectionChangedEventArgs e)
        {
            // Method intentionally left empty.
        }

        private void ComboBox_SelectionChanged_Discharge(object sender, SelectionChangedEventArgs e)
        {
            // Method intentionally left empty.
            
        }

        private void Button_Click_Discharge(object sender, RoutedEventArgs e)
        {
            if (Discharge.SelectedValue!= null && Discharge.SelectedValue.Equals("Bed1"))
            {
                Bed1.Background = new SolidColorBrush(Colors.Yellow);
            }
            if (Discharge.SelectedValue != null && Discharge.SelectedValue.Equals("Bed2"))
            {
                Bed2.Background = new SolidColorBrush(Colors.Yellow);
            }
            if (Discharge.SelectedValue != null && Discharge.SelectedValue.Equals("Bed3"))
            {
                Bed3.Background = new SolidColorBrush(Colors.Yellow);
            }
            if (Discharge.SelectedValue != null && Discharge.SelectedValue.Equals("Bed4"))
            {
                Bed4.Background = new SolidColorBrush(Colors.Yellow);
            }
            if (Discharge.SelectedValue != null && Discharge.SelectedValue.Equals("Bed5"))
            {
                Bed5.Background = new SolidColorBrush(Colors.Yellow);
            }
            if (Discharge.SelectedValue != null && Discharge.SelectedValue.Equals("Bed6"))
            {
                Bed6.Background = new SolidColorBrush(Colors.Yellow);
            }

        }
        private void Button_Click_Disable_Alarm(object sender, RoutedEventArgs e)
        {
            
            if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed1"))
            {
                Bed1.Background = new SolidColorBrush(Colors.Green);
            }
            else if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed2"))
            {
                Bed2.Background = new SolidColorBrush(Colors.Green);
            }
            else if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed3"))
            {
                Bed3.Background = new SolidColorBrush(Colors.Green);
            }
            else if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed4"))
            {
                Bed4.Background = new SolidColorBrush(Colors.Green);
            }
            else if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed5"))
            {
                Bed5.Background = new SolidColorBrush(Colors.Green);
            }
            else if (DisableAlarm.SelectedValue != null && DisableAlarm.SelectedValue.Equals("Bed6"))
            {
                Bed6.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                MessageBox.Show("No Alarm Occured");
            }
        }
    }
}