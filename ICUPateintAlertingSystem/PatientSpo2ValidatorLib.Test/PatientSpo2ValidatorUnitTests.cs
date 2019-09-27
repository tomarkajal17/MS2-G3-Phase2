using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientSpo2ValidatorLib;

namespace PatientSpo2ValidatorLib.Test
{
    [TestClass]
    public class PatientSpo2ValidatorUnitTests
    {
        [TestMethod]
        public void Given_ValidSpo2_Parameter_When_ValidateParameter_Invoked_Then_Expected_True()
        {
            PatientSpo2Validator obj = new PatientSpo2Validator();
            bool expectedValue = true;
            bool actualValue = obj.ValidateParameter<double>(98);
            Assert.AreEqual(expectedValue, actualValue);

        }
        [TestMethod]
        public void Given_InValidSpo2_Parameter_When_ValidateParameter_Invoked_Then_Expected_False()
        {
            PatientSpo2Validator ValidatorObj = new PatientSpo2Validator();
            bool expectedValue = false;
            bool actualValue = ValidatorObj.ValidateParameter<double>(498);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
