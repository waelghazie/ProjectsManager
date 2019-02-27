using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectsManager
{

    public class ActivationInfo
    {
        public string ProcessorId { set; get; }
        //public string SignatureDiskDrive { set; get; }
        //public string SerialNumberBaseBoard { set; get; }
        public ActivationStatus ActivationStatus { set; get; }
        public int TrialDays { set; get; }
        public bool CorruptActivation { set; get; }
        public string CompanyName { set; get; }

        public string LicenseString { set; get; }


    }
}