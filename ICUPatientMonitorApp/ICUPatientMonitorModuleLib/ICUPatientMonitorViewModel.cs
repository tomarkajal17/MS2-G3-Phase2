using MvvmUtilityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICUPatientMonitorModuleLib
{
    public class ICUPatientMonitorViewModel : INotifyPropertyChanged
    {
        private ICommand _dischargePatientCommand;
        private ICommand _getPatientInfoCommand;
        private ICommand _disableAlarm;
        private ICommand _configureBeds;
        private ICommand _allocatePatient;
        private String _bedNo;
        public event PropertyChangedEventHandler PropertyChanged;

        public ICUPatientMonitorViewModel()
        {
            DischargePatientCommand = new DelegateCommands((object obj) => { this.DischargePatient(); }, (object obj) => { return true; });
            GetPatientInfoCommand = new DelegateCommands((object obj) => { this.GetPatientInfo(); }, (object obj) => { return true; });
            DisableAlarm = new DelegateCommands((object obj) => { this.DisablePatientAlarm();}, (object obj) => { return true; });
            ConfigureBeds = new DelegateCommands((object obj) => { this.ConfigureBed(); }, (object obj) => { return true; });
            AllocatePatientCommand = new DelegateCommands((object obj) => { this.Allocate(); }, (object obj) => { return true; });
        }
        public ICommand DischargePatientCommand { get => _dischargePatientCommand; set => _dischargePatientCommand = value; }
        public ICommand ConfigureBeds { get => _configureBeds; set => _configureBeds = value; }
        public ICommand GetPatientInfoCommand { get => _getPatientInfoCommand; set => _getPatientInfoCommand = value; }
        public ICommand DisableAlarm { get => _disableAlarm; set => _disableAlarm = value; }
        public ICommand AllocatePatientCommand { get => _allocatePatient; set => _allocatePatient = value; }
        public String BedNo
        {
            get => _bedNo;
            set
            {
                if (this._bedNo != value)
                {
                    this._bedNo = value;
                    OnPropertyChanged("BedNo");
                }
                else
                {
                    this._bedNo = "";
                    this._bedNo = value;
                    OnPropertyChanged("BedNo");
                }
            }
        }
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void DischargePatient()
        {
            MessageBox.Show("msg");
        }
        public void GetPatientInfo()
        {
            MessageBox.Show("Configure");
        }
        public void DisablePatientAlarm()
        {
            MessageBox.Show("Dis-Alarmed");
        }

        public void ConfigureBed()
        {
            MessageBox.Show("Configure");
        }
        public void Allocate()
        {
            BedNo = "Bed1";
            MessageBox.Show("Allocated");
        }
    }
}
