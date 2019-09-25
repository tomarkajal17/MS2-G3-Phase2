using BedsDataLib;
using ICUBedsConfigurationLib;
using System.Collections.Generic;
using PatientInfoLib;
using System;

namespace BedAllocatorLib
{
    public class BedAllocator
    {

        #region Public Methods
        public void AllocateBed(int patientID, List<BedData> listOfBeds,List<PatientInfo> patientsList)
        {
            var bedItem = listOfBeds.Find(x => x.BedAvailability.Equals(true));
            if (bedItem != null)
            {
                PatientInfo newPatient = new PatientInfo();
                newPatient.BedID = bedItem.BedID;
                newPatient.PatientID = patientID;
                bedItem.BedAvailability = false;
                bedItem.PatientID = patientID;
                patientsList.Add(newPatient);
            }
            else
            {
                string message = "Bed is not available";
                throw new ArgumentNullException(message);
            }
        }
        #endregion
    }
}
