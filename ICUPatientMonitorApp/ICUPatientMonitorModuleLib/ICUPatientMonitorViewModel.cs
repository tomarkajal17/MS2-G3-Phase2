using ICUPatientMonitorModuleLib.AlertWebServiceReference;
using MvvmUtilityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

/// <summary>
/// ICUPatientMonitorModuleLib is view model to UI.
/// </summary>

namespace ICUPatientMonitorModuleLib
{
    /// <summary>
    /// ICUPatientMonitorModule provides commands that interact with web service
    /// </summary>
    public class IcuPatientMonitorViewModel : INotifyPropertyChanged
    {
        #region DataMember
        private String _bedNo;
        private List<string> _bedId=new List<string>();
        private string _dischargePatientId;
        private string _alertPatientText;

        private readonly DispatcherTimer _timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(10)
        };

        public event PropertyChangedEventHandler PropertyChanged;
        static ICUPatientMonitorModuleLib.AlertWebServiceReference.PatientInfo[] patientList;
        static ICUPatientMonitorModuleLib.AlertWebServiceReference.BedData[] bedList;
        ICUPatientMonitorModuleLib.AlertWebServiceReference.AlertFinalListStructure[] alertOutput;
        #endregion

        #region Contructor
        /// <summary>
        /// It is for initialization of the command.
        /// </summary>
        public IcuPatientMonitorViewModel()
        {
            DischargePatientCommand = new DelegateCommands((object obj) => { this.DischargePatient(); }, (object obj) => { return true; });
            GetPatientInfoCommand = new DelegateCommands((object obj) => { this.GetPatientInfo(); }, (object obj) => { return true; });
            StartMonitoringCommand = new DelegateCommands((object obj) => { this.StartMonitoringSection();}, (object obj) => { return true; });
            ConfigureBedsCommand = new DelegateCommands((object obj) => { this.ConfigureBed(); }, (object obj) => { return true; });
            AllocatePatientCommand = new DelegateCommands((object obj) => { this.Allocate(); }, (object obj) => { return true; });
            StopMonitoringCommand = new DelegateCommands((object obj) => { this.StopMonitoringSection(); }, (object obj) => { return true; });

        }
        #endregion

        #region Properties
        public ICommand DischargePatientCommand { get; set; }
        public ICommand ConfigureBedsCommand { get; set; }
        public ICommand GetPatientInfoCommand { get; set; }
        public ICommand AllocatePatientCommand { get; set; }
        public ICommand StartMonitoringCommand { get; set; }
        public ICommand StopMonitoringCommand { get; set; }

        /// <summary>
        /// Bedno of allocated patient
        /// </summary>
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

        public int TotalBeds { get; set; }
        public int PatientID { get; set; }
        /// <summary>
        /// BedId of allocated patient
        /// </summary>
        public List<string> BedId
        {   get => _bedId;

            set
            {
                this._bedId = value;
                OnPropertyChanged(nameof(BedId));
            }
        }
        /// <summary>
        /// Patiend Id of discharged patient
        /// </summary>
        public string DischargePatientId
        {
            get => _dischargePatientId;
            set
            {
                this._dischargePatientId = value;
                OnPropertyChanged(nameof(DischargePatientId));
            }
        }
        /// <summary>
        /// This is for indicating the alerted bed
        /// </summary>
        public string AlertPatientText
        {
            get => _alertPatientText;
            set
            {
                this._alertPatientText = value;
                OnPropertyChanged(nameof(AlertPatientText));
            }
        }
        #endregion

        /// <summary>
        /// This is the event that will execute on property change
        /// </summary>
        /// <param name="propertyName"></param>
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        /// <summary>
        /// This Method is for Discharging the patient
        /// </summary>
        public void DischargePatient()
        {
            CUPatientAlertServiceSoapClient cU= new CUPatientAlertServiceSoapClient();
            string bedId = "";
            int patientId = 0;
            if (DischargePatientId != null && DischargePatientId != "")
            {
                bedId = DischargePatientId.Substring(3);
                if (patientList != null)
                {
                    foreach (var i in patientList)
                    {
                        if (i.BedID.ToString() == bedId)
                        {
                            patientId = i.PatientID;
                        }
                    }

                    if (patientId != 0)
                    {
                        patientList = cU.DischargePatientWebMethod(patientId);
                    }
                    else
                    {
                        MessageBox.Show("Select Allocated Bed");
                    }
                }
                else
                {
                    MessageBox.Show("Select Allocated Bed");
                }
            }
            else
            {
                MessageBox.Show("Select Allocated Bed");
            }
                        
        }
        /// <summary>
        /// This Method is for getting the patient information.
        /// </summary>
        public void GetPatientInfo()
        {
            string bedId = "";
            if (DischargePatientId != null && DischargePatientId != "")
            {
                bedId = DischargePatientId.Substring(3);
                if (patientList != null)
                {
                    int x = 0;
                    foreach (var i in patientList)
                    {
                        if (i.BedID.ToString() == bedId)
                        {
                            MessageBox.Show("The Patient of Bed "+i.BedID+" have patientID="+ i.PatientID
                                + ", Sop2=" +i.PatientSpo2
                                +", temperature="+i.PatientTemprature+
                                ", pulse rate="+i.PatientPulseRate);
                            x = 1;
                            break;
                        }
                    }

                    if (x == 0)
                    {
                        MessageBox.Show("Select Allocated Bed");
                    }
                }
                else
                {
                    MessageBox.Show("No Patient Available");
                }
            }
            else
            {
                MessageBox.Show("Select Allocated Bed");
            }

        }
        /// <summary>
        /// This is for monitoring the patients
        /// </summary>
        public void StartMonitoringSection()
        {
             MessageBox.Show("Patient Monitoring Started");
            _timer.Tick += InvokeMonitoring;
            _timer.Start();
                
        }
        /// <summary>
        /// This will help the monitoring functionality parrelel with other functionally of UI.
        /// </summary>
        /// <param name="sender">Type of sender</param>
        /// <param name="e">Event Occurs</param>
        private void InvokeMonitoring(object sender, EventArgs e)
        {
            CUPatientAlertServiceSoapClient cU = new CUPatientAlertServiceSoapClient();
            alertOutput = cU.RingAlarmWebMethod();
            patientList = cU.PatientDataWebMethod();
            AlertPatient();
        }
        /// <summary>
        /// This is show for alert on UI.
        /// </summary>
        private void AlertPatient()
        {
            foreach (var i in alertOutput)  
            {
                if(!(i.healthy))
                {
                    AlertPatientText = i.bedID.ToString();
                }
            }
        }

        /// <summary>
        /// This is for stop monitoring the patients.
        /// </summary>
        public void StopMonitoringSection()
        {
            _timer.Stop();
            MessageBox.Show("Patient Monitoring Stopped");
        }
        /// <summary>
        /// This for ICU congiguration
        /// </summary>
        public void ConfigureBed()
        {
            CUPatientAlertServiceSoapClient cU= new CUPatientAlertServiceSoapClient();
            if (TotalBeds > 0)
            {
                bedList = cU.ConfigureBedsWebMethod(TotalBeds);
                string str = bedList.Length.ToString() + " beds setup has been performed";
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("Enter Valid No of Beds");
            }
        }
        /// <summary>
        /// This is for allocating the bed to the patients.
        /// </summary>
        public void Allocate()
        {
            CUPatientAlertServiceSoapClient cU = new CUPatientAlertServiceSoapClient();
            if (bedList != null  && (patientList == null || patientList.Length < bedList.Length))
            {
                if (patientList == null)
                {
                    patientList = cU.AllocateBedsWebMethod(PatientID);
                    foreach (var i in patientList)
                    {
                        BedNo = i.BedID.ToString();
                    }
                }
                else
                {
                    bool f = true;
                    foreach (var i in patientList)
                    {
                        if (i.PatientID == PatientID)
                        {
                            f = false;
                        }
                    }
                    if (f && PatientID != 0)
                    {
                        patientList = cU.AllocateBedsWebMethod(PatientID);
                        foreach (var i in patientList)
                        {
                            BedNo = i.BedID.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose Different PatientId of Integers");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Bed is Available");
            }            
        }
    }
}
