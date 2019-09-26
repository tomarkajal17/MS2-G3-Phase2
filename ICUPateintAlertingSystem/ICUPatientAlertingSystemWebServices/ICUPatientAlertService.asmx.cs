using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BedsDataLib;
using ICUBedsConfigurationLib;
using BedAllocatorLib;
using DischargePatientLib;
using PatientInfoLib;
using PatientVitalsProcessorLib;
using AlertFinalListStructureLib;

namespace ICUPatientAlertingSystemWebServices
{
    /// <summary>
    /// Summary description for ICUPatientAlertService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ICUPatientAlertService : System.Web.Services.WebService
    {


        private static List<BedData> _listOfBeds;
        private static List<PatientInfo> listOfPatients;

        [WebMethod]
        public List<BedData> ConfigureBedsWebMethod(int numOfBeds)
        {
            _listOfBeds = new List<BedData>();
            listOfPatients = new List<PatientInfo>();
            IcuBedsConfiguration bedobj = new ICUBedsConfigurationLib.IcuBedsConfiguration();
            _listOfBeds = bedobj.ConfigureBeds(numOfBeds);
            
            return _listOfBeds;


        }
        
        [WebMethod]
        public List<PatientInfo> AllocateBedsWebMethod(int patientID)
        {
            BedAllocator allocateBedObj = new BedAllocator();
            allocateBedObj.AllocateBed(patientID, _listOfBeds, listOfPatients);
            return listOfPatients;
        }
        [WebMethod]
        public List<PatientInfo> DischargePatientWebMethod(int patientID)
        {
            DischargePatient dischargePatientObj = new DischargePatient();
            dischargePatientObj.DischargeandDeallocateBed(patientID, _listOfBeds, listOfPatients);
            return listOfPatients;

        }
        [WebMethod]
        public List<AlertFinalListStructure> RingAlarmWebMethod( )
        {
            List<AlertFinalListStructure> finalResultList = new List<AlertFinalListStructure>();
            PatientVitalsProcessor processor = new PatientVitalsProcessor();
            finalResultList = processor.GenerateAndValidate(listOfPatients);
            return finalResultList;
        }
        [WebMethod]
        public List<PatientInfo> PatientDataWebMethod()
        {
            return listOfPatients;
        }

    }
}
