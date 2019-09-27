using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlertFinalListStructureLib;

namespace AlertFinalListStructureLib.Test
{
    [TestClass]
    public class AlertFinalListStructureUnitTest
    {
        [TestMethod]
        public void Given_bedtID_When_BedID_Field_Assigned_Expected_Same_Value_As_Given()
        {
            AlertFinalListStructure alertListObj = new AlertFinalListStructure();
            alertListObj.BedID = 10;
            int actual_value = alertListObj.BedID;
            int expected_value = 10;
            Assert.AreEqual(actual_value, expected_value);

        }

        [TestMethod]
        public void Given_healthy_When_Healthy_Field_Assigned_Expected_Same_Value_As_Given()
        {
            AlertFinalListStructure Obj = new AlertFinalListStructure();
            Obj.Healthy = true;
            bool actualValue = Obj.Healthy;
            bool expectedValue = true;
            Assert.AreEqual(actualValue, expectedValue);


        }
    }
}
