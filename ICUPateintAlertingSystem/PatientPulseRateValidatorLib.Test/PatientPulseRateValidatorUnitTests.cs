using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientPulseRateValidatorLib;

namespace PatientPulseRateValidatorLib.Test
{
    [TestClass]
    public class PatientPulseRateValidatorUnitTests
    {
        [TestMethod]
        public void Given_ValidPulseRate_Parameter_When_ValidateParameter_Invoked_Then_Expected_True()
        {
            PatientPulseRateValidator validatorObj = new PatientPulseRateValidator();
            bool expectedValue = true;
            bool actualValue=validatorObj.ValidateParameter<decimal>(80);
            Assert.AreEqual(expectedValue, actualValue);

        }
        [TestMethod]
        public void Given_InvalidValidPulseRate_Parameter_When_ValidateParameter_Invoked_Then_Expected_False()
        {
            PatientPulseRateValidator validatorObj = new PatientPulseRateValidator();
            bool expectedValue = false;
            bool actualValue = validatorObj.ValidateParameter<decimal>(280);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
