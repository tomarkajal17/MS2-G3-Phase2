using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedsDataLib;

namespace BedsDataLib.Test
{
    [TestClass]
    public class BedDataUnitTest
    {
        [TestMethod]
        public void Given_PatientID_When_PatiendID_Field_Assigned_Expected_Same_Value_As_Given()
        {
            BedData bedData = new BedData();
            bedData.PatientID = 10;
            int actual_value = bedData.PatientID;
            int expected_value = 10;
            Assert.AreEqual(actual_value, expected_value);
        }
        [TestMethod]
        public void Given_BedId_When_BedId_Field_Assigned_Expected_Same_Value_As_Given()
        {
            BedData bedData = new BedData();
            bedData.BedID = 10;
            int expected_value = 10;
            int actual_value = bedData.BedID;
            Assert.AreEqual(actual_value, expected_value);
        }
        [TestMethod]
        public void Given_BedAvailibility_When_BedId_Field_Assigned_Expected_Same_Value_As_Given()
        {
            BedData bedData = new BedData();
            bedData.BedAvailability = true;
            bool actual_value = bedData.BedAvailability;
            bool expected_value = true;
            Assert.AreEqual(actual_value, expected_value);
        }

    }
}
