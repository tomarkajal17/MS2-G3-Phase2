using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedsDataLib;
using PatientInfoLib;

namespace DischargePatientLib
{
    public class DischargePatient
    {
        #region public Methods
        public void DischargeandDeallocateBed(int patientID,List<BedData> listOfBeds,List<PatientInfo> patientsList)
        {
            try
            {
                var patientItem = patientsList.Find(x => x.PatientID.Equals(patientID));
                var bedItem = listOfBeds.Find(x => x.BedID.Equals(patientItem.BedID));
                bedItem.BedAvailability = true;
                bedItem.PatientID = 0;
                patientsList.Remove(patientItem);
            }
            catch(Exception e)
            {
                string message = "Arguments are Null";
                throw new ArgumentNullException(message);      
            }
        }

        #endregion
    }
}
