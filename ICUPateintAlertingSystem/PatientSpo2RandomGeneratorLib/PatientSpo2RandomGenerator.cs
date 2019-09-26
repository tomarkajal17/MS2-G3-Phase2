using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientRandomVitalsGeneratorContractLib;
using PatientInfoLib;

namespace PatientSpo2RandomGeneratorLib
{
    public class PatientSpo2RandomGenerator : IPatientRandomVitalsGenerator
    {
        public T GenerateParameter<T>(int patientID, List<PatientInfo> listOfPatients)
        {
            const int Spo2MinGenerate = 89;
            const int Spo2MaxGenerate = 102;
            Random randomSpo2 = new Random();
            int patientSpo2 = randomSpo2.Next(Spo2MinGenerate, Spo2MaxGenerate);
            var patientObj = listOfPatients.Find(x => x.PatientID.Equals(patientID));
            patientObj.PatientSpo2 = patientSpo2;
            return (T)Convert.ChangeType(patientSpo2, typeof(T));
     

        }
    }
}
