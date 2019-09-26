﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientRandomVitalsGeneratorContractLib;
using PatientInfoLib;

namespace PatientTempratureRandomGeneratorLib
{
    public class PatientTempratureRandomGenerator : IPatientRandomVitalsGenerator
    {
        public T GenerateParameter<T>(int patientID, List<PatientInfo> listOfPatients)
        {
            const int TempMinGenerate = 94;
            const int TempMaxGenerate = 100;

            Random randomTemprature = new Random();
            double patientTemprature= Math.Round(TempMinGenerate + (TempMaxGenerate - TempMinGenerate) * randomTemprature.NextDouble(), 2, MidpointRounding.ToEven);
            
            var patientObj = listOfPatients.Find(x => x.PatientID.Equals(patientID));
            patientObj.PatientTemprature = patientTemprature;


            return (T)Convert.ChangeType(patientTemprature, typeof(T));
        }
    }
}