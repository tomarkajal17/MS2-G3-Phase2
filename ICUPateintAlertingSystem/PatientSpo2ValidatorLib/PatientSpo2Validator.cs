using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPatientParametersValidatorContractLib;

namespace PatientSpo2ValidatorLib
{
    public class PatientSpo2Validator : IPatientParameterValidator
    {
        private const double Spo2Max = 100;
        private const double Spo2Min = 95;
        public bool ValidateParameter<TDouble>(TDouble parameter)
        {
            double spo2 = Convert.ToDouble(parameter);
            if (spo2 >= Spo2Min && spo2 <= Spo2Max)
                return true;
            return false;

        }

     
    }
}
