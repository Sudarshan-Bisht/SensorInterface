
// Contains frame captured callback functionality.

using SensorAPILib;
using System;

namespace HelloSensor
{
    class SensorCallback
    {
        public SensorAPI.CapturedFrame callback;

        public SensorCallback( )
        {
            callback = CapturedFrameCallBack;
        }

        private void CapturedFrameCallBack(byte[] frameData)
        {
            string filePath = "frame_" + DateTime.Now.Ticks.ToString() + ".txt";

            System.IO.StreamWriter sw = System.IO.File.CreateText(filePath);
            try
            {
                string logLine = System.String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",
                    frameData[0], frameData[1], frameData[2], frameData[3], frameData[4],
                    frameData[5], frameData[6], frameData[7], frameData[8], frameData[9]);

                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}