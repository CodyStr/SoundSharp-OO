using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int _id;
        private string _name;
        private string _artist;
        private string _albumSource;
        private Category _style;
        private Time _length;

        public Track()
        {

        }
        public Track(int id)
        {
            this._id = id;
        }
        public Track(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public Track(int id, string artist, string name)
        {
            this._id = id;
            this._artist = artist;
            this._name = name;
        }
        public Time GetLength() //Geeft de tijd terug van de track als die aangeroepen word.
        {
            return _length;
        }
        public int GetLengthInSeconds() //Geeft de tijd terug van de track in seconden als die aangeroepen word.
        {
            return _length.Seconds + (_length.Minutes * 60) + (_length.Hours * 3600);
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public string DisplayName //laat de naam van de track zien en de artist zijn naam in een string vorm.
        {
            get
            {
                if (this._artist != string.Empty && this._name != string.Empty)
                {
                    return _artist + "-" + _name;
                }
                else
                {
                    return "unknown";
                }
            }
        }

        public Time Length
        {
            set { _length = value; }
        }

        public string DisplayLength //zorgt ervoor dat de lengte in de tostring method word terug gegeven (0h : 0m : 0s)
        {
            get
            {
                return _length.ToString();
            }
        }

        public Category Style
        {
            get { return _style; }
            set { _style = value; }
        }

        public string AlbumSource
        {
            get { return _albumSource; }
            set { _albumSource = value; }
        }


    }

    public enum Category //Enumarator voor de Category, zodat je ze niet hoeft op te zoeken maar dat ze er automatisch komen te staan.
    {
        Ambient,
        Blues,
        Country,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Hiphop,
        Jazz,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Rock,
        Soul,
        Trance,
        Techno,
    }

    public struct Time //Deze struct zorgt ervoor dat de tijd word omgerekend, zodat je bijvoorbeeld geen 62 minuten kan hebben maar 2 minuten en 1 uur.
    {
        private int seconds;
        private int minutes;
        private int hours;

        public Time (int seconds):this(0, 0, seconds)
        {
           
        }
        public Time (int minutes, int seconds):this(0, minutes, seconds)
        {
             
        }
        public Time (int hours, int minutes, int seconds)
        {
            this.seconds = (seconds % 3600) % 60;
            this.minutes = (minutes + ((seconds % 3600) / 60)) % 60;
            this.hours = hours + ((minutes + ((seconds % 3600) / 60)) / 60) + (seconds / 3600);
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public override string ToString() //Dit zorgt ervoor dat de tijd word teruggegeven in een duidelijke string.
        {
            string returnWaarde;

            returnWaarde = hours + "h:" + minutes + "m:" + seconds + "s";

            return returnWaarde;
        }
    }
}
