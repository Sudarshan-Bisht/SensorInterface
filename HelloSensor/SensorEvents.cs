
// Contains all the events related functionality.

using SensorAPILib;
using System;
using System.Threading.Tasks;

namespace HelloSensor
{
    class SensorEvents
    {
        private Task m_task;
        private bool m_runTask;

        public SensorEvents(ref SensorAPI sensorAPI)
        {
            sensorAPI.ScanStarted += SensorAPI_ScanStarted;
            sensorAPI.ScanEnded += SensorAPI_ScanEnded;
        }

        private void SensorAPI_ScanStarted(object sender, EventArgs e)
        {
            Console.WriteLine("\n Scan started");

            Start_ShowProgress();
        }

        private void SensorAPI_ScanEnded(object sender, EventArgs e)
        {
            Stop_ShowProgress();

            Console.WriteLine("\n Scan ended");
        }

        private void Start_ShowProgress()
        {
            m_runTask = true;

            m_task = Task.Run(() =>
            {
                while (m_runTask)
                {
                    Console.Write("* ");
                    Task.Delay(1000).Wait();
                }
            });
        }

        private void Stop_ShowProgress()
        {
            m_runTask = false;
        }
    }
}
