using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevice //Memorecorder leid nu van AudioDevice af
    {
        private MemoCartridgeType _maxCartridgeType;

        public enum MemoCartridgeType //Enum voor DisplayStorageCapacity()
        {
            c60,
            c90,
            c120,
            Unknown
        }

        public MemoRecorder (int serialId) // Zodat de _serialId gelijk staat aan de serialId van de parameter
        {
            _serialId = serialId;
        }

        public override string DisplayStorageCapacity() //Een switch dat informatie levert over de opslagcapaciteit van de memorecorder in een string zodra het aangeroepen word in Program.cs
        {
            string maxCapacityString = "Max capacity: ";
            switch (_maxCartridgeType)
            {
                case MemoCartridgeType.c60:
                    maxCapacityString = maxCapacityString + "60 Min.";
                    break;

                case MemoCartridgeType.c90:
                    maxCapacityString = maxCapacityString + "90 Min.";
                    break;

                case MemoCartridgeType.c120:
                    maxCapacityString = maxCapacityString + "120 Min.";
                    break;

                case MemoCartridgeType.Unknown:
                    maxCapacityString = maxCapacityString + "Unknown.";
                    break;

                default:
                    maxCapacityString = maxCapacityString + "Unknown.";
                    break;
            }
            return maxCapacityString;
        }

        //Dit zijn de getter en setters, spreekt voor zich.
        public MemoCartridgeType MaxCartridgeType
        {
            get { return _maxCartridgeType; }
            set { _maxCartridgeType = value; }
        }

    }
}
