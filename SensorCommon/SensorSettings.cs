
// Contains sensor settings.

namespace Globals
{
    public class SensorSettings
    {
        public int numFrames = 0;
        public string scanMode = null;

        public SensorSettings(int frames, string mode)
        {
            numFrames = frames;
            scanMode = mode;
        }
    }
}
