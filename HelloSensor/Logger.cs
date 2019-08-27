
// Contains logging related functionality.

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloSensor
{
    public static class Logger
    {
        static string filePath = null;

        public static void init()
        {
            filePath = "log_" + DateTime.Now.Ticks.ToString() + ".txt";
        }

        public static void Log(string msg, string args1 = null, string args2 = null)
        {
            if (filePath != null)
            {
                System.IO.StreamWriter sw = System.IO.File.AppendText(filePath);
                try
                {
                    string logLine = System.String.Format("{0:G}: {1} {2} {3}.", System.DateTime.Now, msg, args1, args2);
                    sw.WriteLine(logLine);
                }
                finally
                {
                    sw.Close();
                }
            }
        }
    }
}
