
// File contains unit tests, testing SensorCommandParse's functionality.

using HelloSensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorAPILib;

namespace UnitTestsHelloSensor
{
    [TestClass]
    public class SensorCommandParseUT
    {
        SensorAPI m_sensorAPI = null;

        public SensorCommandParseUT()
        {
            m_sensorAPI = new SensorAPI("", "");
        }

        [TestMethod]
        public void SensorCommandParse_Quit()
        {
            var command = SensorCommandParse.Parse(Command.QUIT);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.QUIT);
        }

        [TestMethod]
        public void SensorCommandParse_Connect()
        {
            var command = SensorCommandParse.Parse(Command.CONNECT);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.CONNECT);
        }

        [TestMethod]
        public void SensorCommandParse_ReportStatus()
        {
            var command = SensorCommandParse.Parse(Command.REPORT_STATUS);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.REPORT_STATUS);
        }

        [TestMethod]
        public void SensorCommandParse_OutputSettings()
        {
            var command = SensorCommandParse.Parse(Command.OUTPUT_SETTINGS);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.OUTPUT_SETTINGS);
        }

        [TestMethod]
        public void SensorCommandParse_InputSettings()
        {
            var command = SensorCommandParse.Parse(Command.INPUT_SETTINGS);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.INPUT_SETTINGS);
        }

        [TestMethod]
        public void SensorCommandParse_Startscan()
        {
            var command = SensorCommandParse.Parse(Command.START_SCAN);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.START_SCAN);
        }

        [TestMethod]
        public void SensorCommandParse_Stopscan()
        {
            var command = SensorCommandParse.Parse(Command.STOP_SCAN);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.STOP_SCAN);
        }

        [TestMethod]
        public void SensorCommandParse_Failure()
        {
            var command = SensorCommandParse.Parse(Command.FAILURE);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.FAILURE);
        }

        [TestMethod]
        public void SensorCommandParse_Invalid()
        {
            var command = SensorCommandParse.Parse(Command.INVALID);
            var commandVal = command.Execute(ref m_sensorAPI);

            Assert.AreEqual(commandVal, Command.INVALID);
        }
    }
}
