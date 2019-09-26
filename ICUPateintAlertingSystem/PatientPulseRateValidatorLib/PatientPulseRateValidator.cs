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
        private const decimal PulseRateMax = 100;
        private const decimal PulseRateMin = 60;

        public bool ValidateParameter<TDecimal>(TDecimal parameter)
        {   
            
                decimal pulseRate = Convert.ToDecimal(parameter);
                if (pulseRate >= PulseRateMin && pulseRate <= PulseRateMax)
                {
                    return true;
                }
                return false;

        }
    }
}
