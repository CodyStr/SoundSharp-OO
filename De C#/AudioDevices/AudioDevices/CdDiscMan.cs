using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;

namespace AudioDevices.Devices
{
    class CdDiscMan : DisplayAudioDevice
    {
        private readonly int _mBSize = 700;
        private bool _isEjected = false;

        public CdDiscMan (int SerialId)
        {
             serialId = SerialId;
        }

        public override string DisplayStorageCapacity()
        {

        }


    }
}
