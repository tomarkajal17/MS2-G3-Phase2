using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVitalsNetCheckerLib
{
    public class PatientVitalsNetChecker
    {
        public bool AnalysisResult(bool[] parameterList)
        {
            for(int i=0;i<parameterList.Length;i++)
            {
                if (!parameterList[i])
                    return false;
            }
            return true;
        }
    }
}
