using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientInfoLib;
using AlertFinalListStructureLib;
using PatientVitalsProcessorLib;
using System.Collections.Generic;


namespace PatientVitalsProcessorLib.Test
{
    [TestClass]
    public class PatientVitalsProcessorUnitTests
    {
        [TestMethod]
        public void Given_PatientInfo_When_GenerateAndValidate_Invoked_Then_Expected_NotNull_AlertFinalListStructure()
        {
            List<PatientInfo> patientList = new List<PatientInfo>();
            PatientInfo pat1 = new PatientInfo();
            pat1.PatientID = 1;
            patientList.Add(pat1);
            List<AlertFinalListStructure> finalResult = new List<AlertFinalListStructure>();
            PatientVitalsProcessor processor = new PatientVitalsProcessor();
            finalResult=processor.GenerateAndValidate(patientList);
            Assert.IsNotNull(finalResult);
            
        }
        [TestMethod]
        public void Given_TwoPatientInfo_When_GenerateAndValidate_Invoked_Then_Expected_TwoEntryFinalList()
        {
            List<PatientInfo> listOfPatients = new List<PatientInfo>();
            PatientInfo pat1 = new PatientInfo();
            pat1.PatientID = 1;
            listOfPatients.Add(pat1);
            PatientInfo pat2 = new PatientInfo();
            pat2.PatientID = 2;
            listOfPatients.Add(pat2);
            List<AlertFinalListStructure> finalResult = new List<AlertFinalListStructure>();
            PatientVitalsProcessor processor = new PatientVitalsProcessor();
            finalResult = processor.GenerateAndValidate(listOfPatients);
            int actualValue = finalResult.Count;
            int ExpectedValue = 2;
            Assert.AreEqual(ExpectedValue, actualValue);


        }
    }
}
