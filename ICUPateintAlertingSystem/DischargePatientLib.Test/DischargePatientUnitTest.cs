using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DischargePatientLib;
using BedsDataLib;
using PatientInfoLib;
using System.Collections.Generic;

namespace DischargePatientLib.Test
{
    [TestClass]
    public class DischargePatientUnitTest
    {
        [TestMethod]
        public void Given_PatientID_When_DischargeandDeallocateBed_Then_Patient_Is_Not_Available()
        {
            int patientID = 1;
            List<BedData> listOfBeds = new List<BedData>();
            BedData bedData = new BedData();
            listOfBeds.Add(bedData);
            List<PatientInfo> patientsList = new List<PatientInfo>();
            PatientInfo newPatient = new PatientInfo();
            patientsList.Add(newPatient);
            DischargePatient dischargePatient = new DischargePatient();
            int initial_size = patientsList.Count;
            dischargePatient.DischargeandDeallocateBed(patientID,listOfBeds,patientsList);
            int actual_value = patientsList.Count;
            int expected_value = initial_size;
            Assert.AreEqual(actual_value, expected_value);
        }
    }
}
