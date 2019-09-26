using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientParametersValidatorContractLib;

namespace PatientTempratureValidatorLib
{
    public class PatientTempratureValidator : IPatientParameterValidator
    {
        private const double TempMax = 99.0;
        private const double TempMin = 97.0;
        public bool ValidateParameter<TDouble>(TDouble parameter)
        {
            double temperature = Convert.ToDouble(parameter);
            if (temperature < TempMin || temperature > TempMax)
            {
                return false;
            }
            return true;

        }

    }
}
