using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientParametersValidatorContractLib;
using IPatientRandomVitalsGeneratorContractLib;
using PatientPulseRateRandomGeneratorLib;
using PatientPulseRateValidatorLib;
using PatientSpo2RandomGeneratorLib;
using PatientSpo2ValidatorLib;
using PatientTempratureRandomGeneratorLib;
using PatientTempratureValidatorLib;
using PatientVitalsProcessorLib;
using PatientInfoLib;
using PatientVitalsNetCheckerLib;
using AlertFinalListStructureLib;

namespace PatientVitalsProcessorLib
{
    public class PatientVitalsProcessor
    {
        public List<AlertFinalListStructure> GenerateAndValidate(List<PatientInfo> listOfPatient)
        {
            List<AlertFinalListStructure> FinalResult = new List<AlertFinalListStructure>();
            foreach (PatientInfo patient in listOfPatient)
            {
                bool[] parameterArray = new bool[3] { true,true,true};
                AlertFinalListStructure alertFinalResultObj = new AlertFinalListStructure();

                IPatientRandomVitalsGenerator spo2GenerateObj = new PatientSpo2RandomGenerator();
                decimal patientSpo2Result=spo2GenerateObj.GenerateParameter<decimal>(patient.PatientID, listOfPatient);
                IPatientParameterValidator spo2ValidatorObj = new PatientSpo2Validator();
                bool validSpo2 = spo2ValidatorObj.ValidateParameter(patientSpo2Result);
                parameterArray[0] = validSpo2;

                IPatientRandomVitalsGenerator pulseRateGenerateObj = new PatientPulseRateRandomGenerator();
                decimal patientPulseRateResult = pulseRateGenerateObj.GenerateParameter<decimal>(patient.PatientID, listOfPatient);
                IPatientParameterValidator PulseRateValidatorObj = new PatientSpo2Validator();
                bool validPulseRate = PulseRateValidatorObj.ValidateParameter(patientPulseRateResult);
                parameterArray[1] = validPulseRate;

                IPatientRandomVitalsGenerator tempratureGenerateObj = new PatientTempratureRandomGenerator();
                double patientTempratureResult = tempratureGenerateObj.GenerateParameter<double>(patient.PatientID, listOfPatient);
                IPatientParameterValidator tempratureValidatorObj = new PatientTempratureValidator();
                bool validTemprature = tempratureValidatorObj.ValidateParameter(patientTempratureResult);
                parameterArray[2] = validTemprature;

                PatientVitalsNetChecker netCheckerObj = new PatientVitalsNetChecker();
                bool finalResult=netCheckerObj.AnalysisResult(parameterArray);
                alertFinalResultObj.bedID = patient.BedID;
                alertFinalResultObj.healthy = finalResult;
                FinalResult.Add(alertFinalResultObj);

            }

            return FinalResult;
        }
       
         
    }
}
