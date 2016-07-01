using System;
using System.Collections.Generic;
using static System.IO.File;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSSSetter
{
    
    class FileProcessor
    {
        static readonly string _VRSettingsFile = @"C:\Program Files (x86)\Steam\config\steamvr.vrsettings";

        public void WriteSSValueInSteamVRSettings(string ssJsonString)
        {
            string[] lines = System.IO.File.ReadAllLines(_VRSettingsFile);
            var stringBuilderToWriteBackToFile = new StringBuilder();
            bool hasFoundSteamVRProperty = false;
            bool updateRatherThanWrite = false;
            foreach (string line in lines)
            {
                if(hasFoundSteamVRProperty)
                {
                    if(line.Contains("background"))
                    {
                        hasFoundSteamVRProperty = false;

                        if (line.Contains(","))
                        {
                            updateRatherThanWrite = true;
                            stringBuilderToWriteBackToFile.Append(line + Environment.NewLine);
                            continue;
                        }
                        else
                        {
                            stringBuilderToWriteBackToFile.Append(line + "," + Environment.NewLine);
                            stringBuilderToWriteBackToFile.Append(ssJsonString + Environment.NewLine);
                            continue;
                        }
                    }
                }

                if(updateRatherThanWrite)
                {
                    updateRatherThanWrite = false;
                    stringBuilderToWriteBackToFile.Append(ssJsonString + Environment.NewLine);
                    continue;
                }

                stringBuilderToWriteBackToFile.Append(line + Environment.NewLine);

                if (line.Contains("steamvr"))
                {
                    hasFoundSteamVRProperty = true;
                }
            }
            WriteAllText(_VRSettingsFile, stringBuilderToWriteBackToFile.ToString());
        }
    }
}
