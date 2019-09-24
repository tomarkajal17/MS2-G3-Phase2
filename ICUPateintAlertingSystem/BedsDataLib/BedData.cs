using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedsDataLib
{
    public class BedData
    {
        #region static Data Members  
        static int numOfInstances=0;
        #endregion
        
        #region Private Data Members
        int _bedID;
        bool _bedAvailability;
        int _patientID;
        #endregion
        
        #region Properties   
        public bool BedAvailability
        {
            get { return _bedAvailability; }
            set { _bedAvailability = value; }
        }

        public int BedID
        {
            get { return _bedID; }
            set { _bedID = value; }
        }
        public int PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        #endregion

        #region Initializer
        public BedData()
        {
            numOfInstances++;
            _bedID = numOfInstances;

            _bedAvailability = true;
            _patientID = 0;
          
        }
        #endregion
    }
}
