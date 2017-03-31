using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    class DisplayAudioDevice
    {
        private int _displayWidth;
        private int _displayHeight;

        public int DisplayWidth
        {
            get { return _displayWidth; }
            set { _displayWidth = value; }
        }

        public int DisplayHeight
        {
            get { return _displayHeight; }
            set { _displayHeight = value; }
        }

        public int TotalPixels
        {
            get { return _displayWidth * _displayHeight; }
        }

        public string GetResolutionInfo()
        {
            return "Resolution: " + TotalPixels + " pixels.";
        }
    }
}
