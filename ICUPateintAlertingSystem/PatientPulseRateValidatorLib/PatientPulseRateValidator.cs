using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientParametersValidatorContractLib;

namespace PatientPulseRateValidatorLib
{
    public class PatientPulseRateValidator : IPatientParameterValidator
    {
        private const int PulseRateMax = 100;
        private const int PulseRateMin = 60;

        public bool ValidateParameter<TInt>(TInt parameter)
        {   
            
                int pulseRate = Convert.ToInt32(parameter);
                if (pulseRate < PulseRateMin || pulseRate > PulseRateMax)
                {
                    return false;
                }
                return true;

        }
    }
}
