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
        #endregion

        #region Properties   
        public bool BedAvailability { get; set; }

        public int BedID { get; set; }
        public int PatientID { get; set; }

        #endregion

        #region Initializer
        public BedData()
        {
            numOfInstances++;
            BedID = numOfInstances;
            BedAvailability = true;
            PatientID = 0;
          
        }
        #endregion
        public BedData(int x)
        {
            numOfInstances = x;
        }
    }
}
