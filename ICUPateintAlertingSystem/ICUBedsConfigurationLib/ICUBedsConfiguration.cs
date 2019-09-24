using BedsDataLib;
using System.Collections.Generic;

namespace ICUBedsConfigurationLib
{
    public class ICUBedsConfiguration
    {
        #region Public Methods
        public List<BedData> ConfigureBeds(int totalNumbersOfBeds)
        {

            List<BedData> bedsList = new List<BedData>();
            for (int i = 1; i <= totalNumbersOfBeds; i++)
            {
                BedData bedDataObj = new BedData();
                bedsList.Add(bedDataObj);
            }

            return bedsList;

        }
        #endregion
    }
}
