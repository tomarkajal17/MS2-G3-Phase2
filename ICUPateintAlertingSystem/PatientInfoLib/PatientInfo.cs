using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoLib
{
    public class PatientInfo
    {
        public decimal  PatientPulseRate { get; set; }
        public decimal PatientSpo2 { get; set; }

        public double PatientTemprature { get; set; }

        

        #region Properties
        public int PatientID { get; set; }

        public int BedID { get; set; }
        #endregion


    }
}
