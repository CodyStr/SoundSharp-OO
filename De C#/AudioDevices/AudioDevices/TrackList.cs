using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AudioDevices.Tracks
{
    public class TrackList : CollectionBase
    {
        public TrackList()
        {

        }

        public void Add(Track t)
        {
            List.Add(t); //Hierdoor kan je tracks toevoegen in de program aan de tracklist. (Komt in de indexer)
        }

        public void Remove(Track t)
        {
            List.Remove(t); //Hierdoor kan je tracks verwijderen uit de tracklist. (Gaat uit de indexer)
        }

        public TrackList GetShuffledList()
        {
            TrackList randomList = new TrackList();
            TrackList tempList = new TrackList();
            Random random = new Random();
            foreach (Track t in this)
            {
                tempList.Add(t);
            }
            for (int i = tempList.Count; i > 0; i--)        //Er word een temploist aangemaakt en die word dan omgegooit. Er word een random nummer uitgehaald, en dan weer op een random plek toegevoegd. Zodat het geshuffeld word.
            {
                int index = random.Next(i);
                randomList.Add(tempList[index]);
                tempList.RemoveAt(index);
            }
            return randomList;
        }
         
        //Indexe, die aangamaakt word. Zodra er in het programma iets toegevoegd word komt die in de indexer te staan, als die geremoved word, word die eruit gehaald. Als een nieuwe track geadd word word die teogevoegd in deze indexer.
        public Track this[int i]
        {
            get
            {
                return (Track)this.List[i];
            }
        }

        public Time TotalTime()
        {
            int totalSecs = 0;
            foreach (Track track in this.List)
            {
                totalSecs += track.GetLengthInSeconds(); //De totalsecs gaat over elke trek heen en telt elke track in seconde bij elkaar op. En in de program word dat omgezet naar uur min en sec.
            }
            Time totalTime = new Time(totalSecs);
            return totalTime;
        }
    }
}
