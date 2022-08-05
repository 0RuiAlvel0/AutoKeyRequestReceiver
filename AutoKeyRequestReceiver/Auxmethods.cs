using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKeyRequestReceiver
{
    internal class Auxmethods
    {
        public static Boolean FileExists(string FilePath)
        {
            if (File.Exists(FilePath))
                return true;
            else
                return false;
        }

        public static string SelectedPort(string SettingsFilePath)
        {
            //finds which port is defined on the settings file, if any. Returns "" if none is found.
            string SelectedPort = "";
            foreach (string line in System.IO.File.ReadLines(SettingsFilePath))
            {
                string[] parameter = line.Split('=');
                if (parameter[0] == "comport")
                {
                    SelectedPort = parameter[1];
                }
            }
            return SelectedPort;
        }

        public static void selectportUI(string SettingsFilePath)
        {
            string auxString = "Please select connection port";
            //Found a settings file, let's continue. Does it have a serial port specified?
            if (Auxmethods.SelectedPort(SettingsFilePath) != "")
            {
                auxString = auxString + " (Last used was " + Auxmethods.SelectedPort(SettingsFilePath) + ")";
            }
            Console.WriteLine(auxString);

            String[] ports = Serialcomms.GetAvailablePorts();

            int index = 0;
            
            foreach (String port in ports)
            {
                Console.Write($"{index + 1}: {port} ");
                index++;
            }
            Console.WriteLine("");
            Console.Write(" --> ");
        }

    }
}
