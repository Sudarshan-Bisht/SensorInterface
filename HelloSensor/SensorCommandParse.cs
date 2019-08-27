
// Contains command parsing related functionality.

namespace HelloSensor
{
    public static class SensorCommandParse
    {
        public static ICommand Parse(string commandString)
        {
            switch (commandString)
            {
                case Command.QUIT:
                    return new QuitCommand();

                case Command.CONNECT:
                    return new ConnectCommand();

                case Command.REPORT_STATUS:
                    return new ReportStatusCommand();

                case Command.OUTPUT_SETTINGS:
                    return new OutputSettingsCommand();

                case Command.INPUT_SETTINGS:
                    return new InputSettingsCommand();

                case Command.START_SCAN:
                    return new StartScanCommand();

                case Command.STOP_SCAN:
                    return new StopScanCommand();

                case Command.FAILURE:
                    return new FailureCommand();

                default:
                    return new InvalidCommand();
            }
        }
    }
}
