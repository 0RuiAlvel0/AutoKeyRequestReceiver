using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AutoKeyRequestReceiver
{
    internal class Conductor
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Check if settings file exists
            string SettingsFilePath = "settings";
            if (Auxmethods.FileExists(SettingsFilePath))
            {
                Console.WriteLine("Found a file called settings.");
            }
            else
                Console.WriteLine("No settings file. Please add a settings file on this current directory. See ");
            //Check if port specified in settings is available. Open it if it is, ask to change if not.


            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            int counter = 0;
            foreach (string port in ports)
            {
                Console.Write(port);
            }

            Console.WriteLine("Enter port to use (will be saved on the configuration file):");
        }
    }
}
