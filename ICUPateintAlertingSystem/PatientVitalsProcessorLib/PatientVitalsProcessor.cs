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

namespace PatientVitalsProcessorLib
{
    public class PatientVitalsProcessor
    {
        public List<bool> GenerateAndValidate(List<PatientInfo> listOfPatient)
        {
            List<bool> FinalResult = new List<bool>();
            foreach (PatientInfo patient in listOfPatient)
            {
                bool[] parameterArray = new bool[3] { true,true,true};

                IPatientRandomVitalsGenerator spo2GenerateObj = new PatientSpo2RandomGenerator();
                double patientSpo2Result=spo2GenerateObj.GenerateParameter<double>(patient.PatientID, listOfPatient);
                IPatientParameterValidator spo2ValidatorObj = new PatientSpo2Validator();
                bool validSpo2 = spo2ValidatorObj.ValidateParameter(patientSpo2Result);
                parameterArray[0] = validSpo2;

                IPatientRandomVitalsGenerator pulseRateGenerateObj = new PatientPulseRateRandomGenerator();
                double patientPulseRateResult = pulseRateGenerateObj.GenerateParameter<double>(patient.PatientID, listOfPatient);
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
                FinalResult.Add(finalResult);


            }

            return FinalResult;
        }
       
         
    }
}
