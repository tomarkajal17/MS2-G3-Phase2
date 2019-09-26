using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BedsDataLib;
using PatientInfoLib;

namespace BedAllocatorLib.Test
{
    [TestClass]
    public class BedAllocatorUnitTest
    {
      
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_Exception()
        {
            int patientID = 0;
            List<BedData> bedList = new List<BedData>();
            List<PatientInfo> patientsList = new List<PatientInfo>();
            BedAllocatorLib.BedAllocator bedAllocatorObject = new BedAllocatorLib.BedAllocator();
            bedAllocatorObject.AllocateBed(patientID, bedList, patientsList);
        }

        [TestMethod]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_PatientList_Increased_By_One()
        {
            int patientID2 = 0;
            List<BedData> listOfBeds2 = new List<BedData>();
            BedData bedDataObj = new BedData();
            listOfBeds2.Add(bedDataObj);
            List<PatientInfo> patientsList2 = new List<PatientInfo>();
            PatientInfo newPatient2 = new PatientInfo();
            patientsList2.Add(newPatient2);
            int initial_value = patientsList2.Count;
            BedAllocatorLib.BedAllocator bedAllocatorObj2 = new BedAllocatorLib.BedAllocator();
            bedAllocatorObj2.AllocateBed(patientID2, listOfBeds2, patientsList2);
            int actual_Value = patientsList2.Count;
            int expected_Value = initial_value + 1;
            Assert.AreEqual(actual_Value, expected_Value);
        }
        [TestMethod]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_AvailableBedsDecreased()
        {
            int patientID1 = 0;
            List<BedData> listOfBeds1 = new List<BedData>();
            BedData bedData1 = new BedData();
            listOfBeds1.Add(bedData1);
            List<PatientInfo> patientsList1 = new List<PatientInfo>();
            PatientInfo newPatient1 = new PatientInfo();
            patientsList1.Add(newPatient1);
            int initial_Value = (listOfBeds1.FindAll(x => x.BedAvailability.Equals(true))).Count;
            BedAllocatorLib.BedAllocator bedAllocator1 = new BedAllocatorLib.BedAllocator();
            bedAllocator1.AllocateBed(patientID1, listOfBeds1, patientsList1);
            int actualValue = (listOfBeds1.FindAll(x => x.BedAvailability.Equals(true))).Count;
            int expectedValue = initial_Value - 1;
            Assert.AreEqual(actualValue, expectedValue);
        }

    }
}
