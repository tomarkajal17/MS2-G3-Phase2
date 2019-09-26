using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientRandomVitalsGeneratorContractLib;
using PatientInfoLib;

namespace PatientPulseRateRandomGeneratorLib
{
    public class PatientPulseRateRandomGenerator : IPatientRandomVitalsGenerator
    {
        public T GenerateParameter<T>(int patientID, List<PatientInfo> listOfPatients)
        {
            const int PulseMinGenerate = 58;
            const int PulseMaxGenerate = 102;
            Random randomPulseRate = new Random();
            int patientPulseRate=randomPulseRate.Next(PulseMinGenerate, PulseMaxGenerate);
            var patientObj = listOfPatients.Find(x => x.PatientID.Equals(patientID));
            patientObj.PatientPulseRate = patientPulseRate;

            return (T)Convert.ChangeType(patientPulseRate, typeof(T));
        }
    }
}
