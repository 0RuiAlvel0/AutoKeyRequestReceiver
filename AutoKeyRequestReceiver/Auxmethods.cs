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
        public static Boolean FileExists(String FilePath)
        {
            if (File.Exists(FilePath))
                return true;
            else
                return false;
        }
    }
}
