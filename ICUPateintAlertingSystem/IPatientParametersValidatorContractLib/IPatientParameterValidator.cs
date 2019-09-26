using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPatientParametersValidatorContractLib
{
    public interface IPatientParameterValidator
    {
        bool ValidateParameter<T>(T parameter);

    }
}
