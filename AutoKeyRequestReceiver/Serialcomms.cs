using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKeyRequestReceiver
{
    internal class Serialcomms
    {
        public static String[] GetAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            // Display each port name to the console.
            return ports;
        }
    }
}
