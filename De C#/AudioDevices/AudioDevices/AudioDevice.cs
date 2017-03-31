using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        protected int _serialId;
        protected string _model;
        protected string _make;
        protected decimal _priceExBtw;
        protected DateTime _creationDate;
        protected const double _btwPercentage = 19.0;

        public string DisplayIdentity()  //Als displayidentity word aangeroepen zonder parameters word er een string teruggegeven. 
        {
            return "SerialID: " + _serialId;
        }

        public string DisplayIdentity(bool modelInfo, bool makeInfo) //Als displayidentity word aangeroepen met parameters geeft die model of make terug. 
        {
            string showId = null;
            if (modelInfo || makeInfo)
            {
                if (modelInfo)
                {
                    showId = showId + "Model: " + _model;
                }
                if (makeInfo)
                {
                    showId = showId + "Make: " + _make;
                }
            } else { showId = DisplayIdentity(); }
            return showId;
        }

        public string GetDeviceLifeTime() //getdevicelifetime geeft de tijd van hoe oud het aantal dagen dat het device oud is
        {
            if(_creationDate.Ticks == 0)
            {
                return "Lifetime: unknow";
            }

            else
            {
                return "Lifetime: " + DateTime.Now.Subtract(this.CreationDate).Days + " " + "days";
            }
        }

        public abstract string DisplayStorageCapacity();

        //Dit zijn de get en setters, spreekt voor zich
        public int SerialId
        {
            get { return _serialId; }
            set { _serialId = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public decimal PriceExBtw
        {
            get { return _priceExBtw; }
            set { _priceExBtw = value; }
        }

       public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public decimal ConsumerPrice
        {
            get { return _priceExBtw / 100 * 119; }
        }

    }
}
