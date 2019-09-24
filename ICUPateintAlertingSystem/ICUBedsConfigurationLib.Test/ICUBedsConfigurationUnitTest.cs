using System;
using System.Collections.Generic;
using BedsDataLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICUBedsConfigurationLib.Test
{
    [TestClass]
    public class ICUBedsConfigurationUnitTest
    {
        [TestMethod]
        public void Given_Total_No_Of_Beds_Is_Two_When_ConfigureBeds_Invoked_Then_Size_Of_Bed_List_Will_be_Two()
        {
            ICUBedsConfiguration iCUBedsConfiguration = new ICUBedsConfiguration();
            List<BedData> listOfBeds = iCUBedsConfiguration.ConfigureBeds(2);
            int actualValue = listOfBeds.Count;
            int expectedValue = 2;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
