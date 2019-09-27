using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientTempratureValidatorLib;

namespace PatientTempratureValidatorLib.Test
{
    [TestClass]
    public class PatientTempratureValidatorUnitTests
    {
        [TestMethod]
        public void Given_ValidTemprature_Parameter_When_ValidateParameter_Invoked_Then_Expected_True()
        {
            PatientTempratureValidator obj = new PatientTempratureValidator();
            bool expectedValue = true;
            bool actualValue = obj.ValidateParameter<double>(98);
            Assert.AreEqual(expectedValue, actualValue);

        }
        [TestMethod]
        public void Given_InValidTemprature_Parameter_When_ValidateParameter_Invoked_Then_Expected_False()
        {
            PatientTempratureValidator TempObj = new PatientTempratureValidator();
            bool expectedValue = false;
            bool actualValue = TempObj.ValidateParameter<double>(202);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
