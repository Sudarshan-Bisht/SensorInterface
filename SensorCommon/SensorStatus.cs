
// Contains sensor status.

namespace Globals
{
    public class SensorStatus
    {
        public int statusCode = -1;
        public string statusText = null;

        public SensorStatus(int code, string text)
        {
            statusCode = code;
            statusText = text;
        }
    }
}
