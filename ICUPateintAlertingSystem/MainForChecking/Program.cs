using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICUBedsConfigurationLib;
using BedAllocatorLib;
using PatientInfoLib;
using BedsDataLib;
using DischargePatientLib;
using IPatientRandomVitalsGeneratorContractLib;
using PatientPulseRateRandomGeneratorLib;
using PatientTempratureRandomGeneratorLib;
using PatientSpo2RandomGeneratorLib;
using IPatientParametersValidatorContractLib;

using PatientTempratureValidatorLib;
using PatientSpo2ValidatorLib;
using PatientPulseRateValidatorLib;
using PatientVitalsProcessorLib;
using PatientVitalsNetCheckerLib;

namespace MainForChecking
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<bool> finalResult = new List<bool>();           
            List<PatientInfo> listOfPatient = new List<PatientInfo>();
            PatientInfo pat1 = new PatientInfo();
            pat1.PatientID = 1;
            listOfPatient.Add(pat1);
            PatientInfo pat2 = new PatientInfo();
            pat2.PatientID = 2;
            listOfPatient.Add(pat2);
            PatientInfo pat3 = new PatientInfo();
            pat2.PatientID = 3;
            listOfPatient.Add(pat3);
            PatientVitalsProcessor p = new PatientVitalsProcessor();
           
            






        }
    }
}
