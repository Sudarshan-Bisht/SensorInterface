
// Entry point of the console app

using SensorAPILib;
using System;

namespace HelloSensor
{
    class SensorClient
    {
        public static void Main(string[] args)
        {
            // Initialize Logger to dump traces to log file.
            Logger.init();

            // First check whether there are enought input arguments to start the app.
            if (Instructions.CheckInputArgs(args.Length) == true)
            {
                // Display necessary instructions to use the sensor.
                Instructions.Display();

                // Create an object of the sensor library by providing ip address and port number.
                string ipAddress = args[0];
                string portNumber = args[1];
                SensorAPI sensorAPI = new SensorAPI(ipAddress, portNumber);
                
                if (sensorAPI != null)
                {
                    // Listen to the events and callbacks from lib
                    SensorEvents events = new SensorEvents(ref sensorAPI);

                    // Execute different commands based on user input.  
                    string commandVal = Command.INVALID;
                    while (commandVal != Command.QUIT)
                    {
                        var command = SensorCommandParse.Parse(Console.ReadLine());
                        commandVal = command.Execute(ref sensorAPI);
                    }
                }

                // Destroy sensor library object.
                sensorAPI = null;
            }
        }
    }
}
