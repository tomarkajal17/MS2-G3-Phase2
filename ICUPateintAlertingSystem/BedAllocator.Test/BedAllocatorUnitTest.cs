using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedAllocatorLib;
using System.Collections.Generic;
using BedsDataLib;
using PatientInfoLib;

namespace BedAllocator.Test
{
    [TestClass]
    public class BedAllocatorUnitTest
    {
        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_Exception()
        {
            int patientID = 0;
            List<BedData> listOfBeds = new List<BedData>();
            List<PatientInfo> patientsList = new List<PatientInfo>();
            BedAllocatorLib.BedAllocator bedAllocator = new BedAllocatorLib.BedAllocator();
            bedAllocator.AllocateBed(patientID, listOfBeds, patientsList);
        }

        [TestMethod]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_PatientList_Increased_By_One()
        {
            int patientID = 0;
            List<BedData> listOfBeds = new List<BedData>();
            BedData bedData = new BedData();
            listOfBeds.Add(bedData);
            List<PatientInfo> patientsList = new List<PatientInfo>();
            PatientInfo newPatient = new PatientInfo();
            patientsList.Add(newPatient);
            int initial_value = patientsList.Count;
            BedAllocatorLib.BedAllocator bedAllocator = new BedAllocatorLib.BedAllocator();
            bedAllocator.AllocateBed(patientID, listOfBeds, patientsList);
            int actual_value = patientsList.Count;
            int expected_value = initial_value + 1;
            Assert.AreEqual(actual_value, expected_value);
        }
        [TestMethod]
        public void Given_PatientID_When_AllocateBed_Invoked_Expetected_AvailableBedsDecreased()
        {
            int patientID = 0;
            List<BedData> listOfBeds = new List<BedData>();
            BedData bedData = new BedData();
            listOfBeds.Add(bedData);
            List<PatientInfo> patientsList = new List<PatientInfo>();
            PatientInfo newPatient = new PatientInfo();
            patientsList.Add(newPatient);
            int initial_value = (listOfBeds.FindAll(x => x.BedAvailability.Equals(true))).Count;
            BedAllocatorLib.BedAllocator bedAllocator = new BedAllocatorLib.BedAllocator();
            bedAllocator.AllocateBed(patientID, listOfBeds, patientsList);
            int actual_value = (listOfBeds.FindAll(x => x.BedAvailability.Equals(true))).Count;
            int expected_value = initial_value - 1;
            Assert.AreEqual(actual_value, expected_value);
        }
    }
}
