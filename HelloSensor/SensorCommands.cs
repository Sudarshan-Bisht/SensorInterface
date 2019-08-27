
// Contains all the commands related functionality.

using Globals;
using SensorAPILib;
using System;

namespace HelloSensor
{
    public interface ICommand
    {
        string Execute(ref SensorAPI sensorAPI);
    }

    public class QuitCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            Console.WriteLine("Quitting the app");
            Logger.Log("Quitting the app");

            return Command.QUIT;
        }
    }

    public class ConnectCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            Console.WriteLine("Connecting to the sensor");
            Logger.Log("Connecting to the sensor");

            int result = sensorAPI.Connect();

            if (result == 0)
            {
                Console.WriteLine("Connected the sensor");
                Logger.Log("Connected to the sensor");
            }
            else
            {
                Console.WriteLine("Not able to connect to the sensor");
                Logger.Log("Not able to connect  to the sensor");
            }

            return Command.CONNECT;
        }
    }

    public class ReportStatusCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            SensorStatus status = sensorAPI.ReportStatus();

            if (status != null)
            {
                Console.WriteLine("Sensor status");
                Console.WriteLine("status code : {0}, status description : {1}", status.statusCode, status.statusText);
                Logger.Log("Sensor status  :", status.statusCode.ToString(), status.statusText);
            }
            else
            {
                Console.WriteLine("No Connection to the sensor");
                Logger.Log("No Connection to the sensor");
            }

            return Command.REPORT_STATUS;
        }
    }

    public class OutputSettingsCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            SensorSettings settings = sensorAPI.OutputSettings();

            if (settings != null)
            {
                Console.WriteLine("Get sensor settings");
                Console.WriteLine("frames : {0}, scan mode : {1}", settings.numFrames, settings.scanMode);
                Logger.Log("Sensor output settings", settings.numFrames.ToString(), settings.scanMode);
            }
            else
            {
                Console.WriteLine("No Connection to the sensor");
                Logger.Log("No Connection to the sensor");
            }

            return Command.OUTPUT_SETTINGS;
        }
    }

    public class InputSettingsCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            SensorSettings settings = new SensorSettings(2, "slow");

            int result = sensorAPI.InputSettings(settings);

            if (result == 0)
            {
                Console.WriteLine("Set sensor settings:");
                Console.WriteLine("frames : {0}, scan mode : {1}", settings.numFrames, settings.scanMode);
                Logger.Log("Sensor output settings", settings.numFrames.ToString(), settings.scanMode);
            }
            else
            {
                Console.WriteLine("No Connection to the sensor");
                Logger.Log("No Connection to the sensor");
            }

            return Command.INPUT_SETTINGS;
        }
    }

    public class StartScanCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            SensorCallback sensorCallback = new SensorCallback();

            Logger.Log("Start scanning frames");

            var result = sensorAPI.StartScanning(sensorCallback.callback);

            sensorCallback = null;

            return Command.START_SCAN;
        }
    }

    public class StopScanCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            Logger.Log("Stop scanning frames");

            var result = sensorAPI.StopScanning();

            return Command.STOP_SCAN;
        }
    }

    public class FailureCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            Console.WriteLine("Failure in sensor,  try to reconnect");
            Logger.Log("Failure in sensor, try to reconnect");

            var result = sensorAPI.Failure();

            return Command.FAILURE;
        }
    }

    public class InvalidCommand : ICommand
    {
        public string Execute(ref SensorAPI sensorAPI)
        {
            Console.WriteLine("Invaild command, Please recheck");
            Logger.Log("Invaild command, Please recheck");

            Instructions.Display();

            return Command.INVALID;
        }
    }
}
