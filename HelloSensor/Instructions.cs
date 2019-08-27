
// Contains all the instructions related functionality.

using System;
using System.Reflection;
using System.Resources;

namespace HelloSensor
{
    public static class Instructions
    {
        private static ResourceManager m_resourceManager = new ResourceManager("HelloSensor.Resource", Assembly.GetExecutingAssembly());

        public static bool CheckInputArgs(int num_args)
        {
            bool retval = true;

            if (num_args < 2)
            {
                Console.WriteLine("\t\t" + m_resourceManager.GetString("InvalidInputArgsText"));
                Console.WriteLine("\t\t\t" + m_resourceManager.GetString("AppRunCommandText"));

                Logger.Log(m_resourceManager.GetString("InvalidInputArgsText"));
                Logger.Log(m_resourceManager.GetString("AppRunCommandText"));

                retval = false;
            }

            return retval;
        }

        public static void Display()
        {
            Console.WriteLine("\t*********************************************************************************");
            Console.WriteLine("\t*\t" + m_resourceManager.GetString("InstructionsTitleText") + "\t\t*");
            Console.WriteLine("\t*********************************************************************************");
            Console.WriteLine("\t---------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("QuitAppText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("ConnectSensorText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("ReportStatusText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("OutputSettingsText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("InputSettingsText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("StartScanningText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("SopScanningText"));
            Console.WriteLine("\t\t\t" + m_resourceManager.GetString("SensorFailureText"));
            Console.WriteLine("\t---------------------------------------------------------------------------------");
        }
    }
}
