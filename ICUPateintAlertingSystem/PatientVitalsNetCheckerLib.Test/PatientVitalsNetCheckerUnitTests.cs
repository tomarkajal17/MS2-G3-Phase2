using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientVitalsNetCheckerLib;

namespace PatientVitalsNetCheckerLib.Test
{
    [TestClass]
    public class PatientVitalsNetCheckerUnitTests
    {
        [TestMethod]
        public void Given_ParameterList_False_When_AnalysisResult_Invoked_Then_FalseExpected()
        {
            PatientVitalsNetChecker checkerObj= new PatientVitalsNetChecker();
            bool[] paraList = new bool[3] { false, false,false };
            bool actualValue = checkerObj.AnalysisResult(paraList);
            bool expectedValue = false;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]

        public void Given_ParameterList_True_When_AnalysisResult_Invoked_Then_TrueExpected()
        {
            PatientVitalsNetChecker checkerObj = new PatientVitalsNetChecker();
            bool[] paraList = new bool[3] { true, true, true };
            bool actualValue = checkerObj.AnalysisResult(paraList);
            bool expectedValue = true;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Given_ParameterList_OneValueFalse_When_AnalysisResult_Invoked_Then_FalseExpected()
        {
            PatientVitalsNetChecker checkerObj = new PatientVitalsNetChecker();
            bool[] paraList = new bool[3] { true, false, true };
            bool actualValue = checkerObj.AnalysisResult(paraList);
            bool expectedValue = false;
            Assert.AreEqual(expectedValue, actualValue);
        }

       
    }
}
