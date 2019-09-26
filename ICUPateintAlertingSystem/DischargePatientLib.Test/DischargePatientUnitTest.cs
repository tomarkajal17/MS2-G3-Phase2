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
        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void Given_PatientID_When_DischargeandDeallocateBed_Then_Patient_Is_Not_Available()
        {
            int patientID = 1;
            List<BedData> bedListObj = new List<BedData>();
            BedData bedData = new BedData();
            bedListObj.Add(bedData);
            List<PatientInfo> patientsListObj = new List<PatientInfo>();
            PatientInfo newPatient = new PatientInfo();
            patientsListObj.Add(newPatient);
            DischargePatient dischargePatient = new DischargePatient();
            dischargePatient.DischargeandDeallocateBed(patientID, bedListObj, patientsListObj);     
        }
        
        public void Given_PatientID_When_DischargeandDeallocateBed_Then_Patient_List_Size_Will_Decreazed_By_1()
        {
            int patientID = 1;
            List<BedData> listOfBeds = new List<BedData>();
            BedData bedData = new BedData();
            bedData.BedAvailability = false;
            bedData.PatientID = patientID;
            listOfBeds.Add(bedData);
            List<PatientInfo> listOfPatient = new List<PatientInfo>();
            PatientInfo newPatient = new PatientInfo();
            newPatient.PatientID = patientID;
            newPatient.BedID = 1;
            listOfPatient.Add(newPatient);
            DischargePatient dischargePatient = new DischargePatient();
            dischargePatient.DischargeandDeallocateBed(patientID, listOfBeds, listOfPatient);
            int expectedValue = 0;
            int actualValue = listOfPatient.Count;
            Assert.AreEqual(expectedValue, actualValue);            
        }

    }
}
