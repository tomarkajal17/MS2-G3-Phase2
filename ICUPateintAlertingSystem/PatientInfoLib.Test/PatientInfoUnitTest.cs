using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientInfoLib;

namespace PatientInfoLib.Test
{
    [TestClass]
    public class PatientInfoUnitTest
    {
        [TestMethod]
        public void Given_PatientID_When_PatiendID_Field_Assigned_Expected_Same_Value_As_Given()
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.PatientID = 10;
            int actual_value = patientInfo.PatientID;
            int expected_value = 10;
            Assert.AreEqual(actual_value, expected_value);
        }
        [TestMethod]
        public void Given_BedId_When_BedId_Field_Assigned_Expected_Same_Value_As_Given()
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.BedID = 10;
            int actual_value = patientInfo.BedID;
            int expected_value = 10;
            Assert.AreEqual(actual_value, expected_value);
        }

    }
}
