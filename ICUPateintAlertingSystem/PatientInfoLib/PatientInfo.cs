using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoLib
{
    public class PatientInfo
    {
        #region Private Data Members
        private int _patientID;
        private double _spO2;
        private double _temprature;
        private int _pulseRate;
        private int _bedID;
        #endregion

        #region Properties
        public int PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        public int BedID
        {
            get { return _bedID; }
            set { _bedID = value; }
        }
        #endregion



    }
}
