using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientInfoLib;

namespace IPatientRandomVitalsGeneratorContractLib
{
    public interface IPatientRandomVitalsGenerator
    {
         T GenerateParameter<T>(int patientID, List<PatientInfo> listOfPatients);
    }
}
