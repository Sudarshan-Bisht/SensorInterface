
// Sensor API, abstracts real sensor's complexity.

using Globals;
using System;
using System.Threading.Tasks;

namespace SensorAPILib
{
    public class SensorAPI
    {
        private readonly byte[] frameBuffer = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private string m_ip;
        private string m_port;

        private bool m_isConnectionExist = false;
        private bool m_isScanActive = false;

        public event EventHandler ScanStarted;
        public event EventHandler ScanEnded;

        public delegate void CapturedFrame(byte[] frameData);


        public SensorAPI(string ip, string port)
        {
            m_ip = ip;
            m_port = port;
        }


        public int Connect()
        {
            // In normal case, connect to the sensor using m_ip and m_port.

            // Simulate connection delay.
            System.Threading.Thread.Sleep(1000);

            m_isConnectionExist = true;

            return 0;
        }


        public SensorStatus ReportStatus()
        {
            SensorStatus status = null;

            if (m_isConnectionExist == true)
            {
                // Get this status info from sensor and then create the object.
                status = new SensorStatus(1000, "test");
            }

            return status;
        }


        public SensorSettings OutputSettings()
        {
            SensorSettings settings = null;

            if (m_isConnectionExist == true)
            {
                // Get these settings from sensor and then create the object.
                settings = new SensorSettings(5, "fast");
            }

            return settings;
        }


        public int InputSettings(SensorSettings settings)
        {
            int result = -1;

            if (m_isConnectionExist == true)
            {
                // Forward these settings to the sensor.
                result = 0;
            }

            return result;
        }


        public async Task<int> StartScanning(CapturedFrame callback)
        {
            int result = -1;

            if (m_isConnectionExist == true)
            {
                // Forward start scan command to the sensor.
                result = 0;

                m_isScanActive = true;

                ScanStarted(null, null);

                await SimulateCapturedFrame(callback);
            }

            return result;
        }


        public async Task<int> StopScanning()
        {
            int result = -1;

            if (m_isConnectionExist == true)
            {
                result = 0;

                await SimulateStopScan();
            }

            return result;
        }


        public int Failure()
        {
            int result = -1;

            if (m_isConnectionExist == true)
            {
                result = 0;

                m_isConnectionExist = false;
            }

            return result;
        }


        private async Task SimulateCapturedFrame(CapturedFrame callback)
        {
            await Task.Run(() =>
            {
                while (m_isScanActive)
                {
                    // Assume each frame takes 2 sec to get ready.     
                    Task.Delay(2000).Wait();

                    // Invoke callback and pass back frame data to client.
                    callback(frameBuffer);
                }
            });
        }


        private async Task SimulateStopScan()
        {
            await Task.Run(() =>
            {
                m_isScanActive = false;

                // Assume after requesting to stop scan, it takes 5 sec to stop scan.
                Task.Delay(5000).Wait();

                // Then invoke the event.
                ScanEnded(null, null);
            });
        }
    }
}
