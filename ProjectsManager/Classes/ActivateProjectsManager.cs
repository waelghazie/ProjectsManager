using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;          //add System.Management Referance
using System.IO;

namespace ProjectsManager
{
    public enum ActivationStatus { Activated, Trial }

    public class ActivateProjectsManager
    {
        /*
        Create Activation License :
        Encrypt
        (
        CPU ID
        Active
        CompanyName
        )

        Create Trail License File:
        Encrypt
        (
        CPU ID
        Trial
        10
        )
        */

        public static string CreateActivationCode(string CompanyName)
        {
            //old:  return Encryption.Encrypt(QueryProccessorID() + "\n" + QueryHDDID() + "\n" + QuerySystemID() + "\n" + ActivationStatus.Activated + "\n" + CompanyName);
            return Encryption.Encrypt(QueryProccessorID() + "\n" + ActivationStatus.Activated + "\n" + CompanyName);
        }

        public static string CreateTrialCode()
        {
            //old: return Encryption.Encrypt(QueryProccessorID() + "\n" + QueryHDDID() + "\n" + QuerySystemID() + "\n" + ActivationStatus.Trial + "\n25");
            return Encryption.Encrypt(QueryProccessorID() + "\n" + ActivationStatus.Trial + "\n25");
        }

        public static string CreateRequestCode()
        {
            //old: return Encryption.Encrypt(QueryProccessorID() + "\n" + QueryHDDID() + "\n" + QuerySystemID());
            return Encryption.Encrypt(QueryProccessorID() + "\n");
        }

        public static string QueryProccessorID()
        {
            string ID = "";
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                ID = mo["ProcessorId"].ToString();
                break;
            }
            return ID;
        }
        /*
        public static string QueryHDDID()
        {

            string ID = "";
            var mbs = new ManagementObjectSearcher("Select Signature From Win32_DiskDrive");
            ManagementObjectCollection mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                ID = mo["Signature"].ToString();
                break;
            }
            return ID;
        }

        public static string QuerySystemID()
        {
            string ID = "";
            var mbs = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            ManagementObjectCollection mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                ID = mo["SerialNumber"].ToString();
                break;
            }
            return ID;
        }*/

        public static string ReduceTrialDays(string LicenseString)
        {
            //LicenseString = Encryption.Decrypt(LicenseString);
            char[] SplitChar = { '\n' };
            string[] SplittedArray;
            SplittedArray = LicenseString.Split(SplitChar);
            SplittedArray[2] = Convert.ToString(Convert.ToInt32(SplittedArray[2]) - 1);
            //old: return Encryption.Encrypt(SplittedArray[0] + "\n" + SplittedArray[1] + "\n" + SplittedArray[2] + "\n" + SplittedArray[3] + "\n" + SplittedArray[4]);
            return Encryption.Encrypt(SplittedArray[0] + "\n" + SplittedArray[1] + "\n" + SplittedArray[2]);
        }


        public static ActivationInfo ReadActivation(string LicenseString)
        {
            LicenseString = Encryption.Decrypt(LicenseString);
            ActivationInfo AI = new ActivationInfo();
            char[] SplitChar = { '\n' };
            string[] SplittedArray;
            SplittedArray = LicenseString.Split(SplitChar);

            if (SplittedArray.Length == 3)
                if (SplittedArray[0] == QueryProccessorID())
                    if (SplittedArray[1] == Convert.ToString(ActivationStatus.Trial))
                    { AI.TrialDays = Convert.ToInt32(SplittedArray[2]); }
                    else
                    { }
                else
                { AI.CorruptActivation = true; }
            else
            { AI.CorruptActivation = true; }



            if (AI.CorruptActivation)
                return AI;

            AI.ProcessorId = SplittedArray[0];
            //AI.SignatureDiskDrive = SplittedArray[1];
            //AI.SerialNumberBaseBoard = SplittedArray[2];
            if (SplittedArray[1] == Convert.ToString(ActivationStatus.Trial))
            {
                AI.ActivationStatus = ActivationStatus.Trial;
                AI.TrialDays = Convert.ToInt32(SplittedArray[2]);
            }
            else if (SplittedArray[1] == Convert.ToString(ActivationStatus.Activated))
            {
                AI.ActivationStatus = ActivationStatus.Activated;
                AI.CompanyName = SplittedArray[2];
            }
            AI.LicenseString = LicenseString;
            return AI;
        }




    }
}

