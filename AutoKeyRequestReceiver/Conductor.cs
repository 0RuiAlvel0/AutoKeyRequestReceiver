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
            string SettingsFilePath = AppDomain.CurrentDomain.BaseDirectory + "settings.cfg";
            if (Auxmethods.FileExists(SettingsFilePath))
            {
                Auxmethods.selectportUI(SettingsFilePath);
                String SelectedPort = Console.ReadLine();

                //Test the user input. if no choice, try the saved port.


            }
            else
                Console.WriteLine("No settings file. See https://github.com/0RuiAlvel0/AutoKeyRequestReceiver for details.");
        }
    }
}
