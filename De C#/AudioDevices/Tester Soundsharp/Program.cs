using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;
using AudioDevices.Devices;
using System.Threading;

namespace Tester_Soundsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    Console.Clear();
            //    DateTime myValue = DateTime.Now;
            //    Console.WriteLine(myValue.ToString());
            //}
            //Tussen haakjes staat voor tijd in de volgorde: Hours, Minutes, Seconds
            //Time t = new Time(1, 0, 0);
            //Console.WriteLine(t.ToString());


            //Hier maken we de tracklist aan
            TrackList trackList = new TrackList();

            // Hier declarenen wij de tracks (We maken ze aan)
            Track t1 = new Track(1, "NellyFurtado", "Maneater");
            t1.AlbumSource = "Loose";
            t1.Length = new Time(2, 3600);
            t1.Style = Category.Pop;

            Track t2 = new Track(2, "Paul Elstak", "Turbo");
            t2.AlbumSource = "Loose";
            t2.Length = new Time(3, 50);
            t2.Style = Category.Techno;

            Track t3 = new Track(3, "2 Brothers", "Never Alone");
            t3.AlbumSource = "Loose";
            t3.Length = new Time(3, 4);
            t3.Style = Category.Techno;

            Track t4 = new Track(4, "U.D.O", "Metal Machine");
            t4.AlbumSource = "Loose";
            t4.Length = new Time(4, 6);
            t4.Style = Category.Techno;

            Track t5 = new Track(5, "K3", "Handjes in de lucht");
            t5.AlbumSource = "Loose";
            t5.Length = new Time(2, 15);
            t5.Style = Category.Techno;

            //Hier voegen we de tracks toe aan de tracklist.
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            trackList.Add(t4);
            trackList.Add(t5);

            //In de foreach laten we voor elke Track in de tracklist de naam, lengte, lengte in seconde en style zien.
            //Dit is de tester van opdracht 1
            Console.WriteLine("=====Opdracht 1=====");
            foreach (Track t in trackList) {
                Console.WriteLine("Naam: {0}", t.DisplayName);
                Console.WriteLine("Lengte: {0}", t.DisplayLength);
                Console.WriteLine("Tijd in seconden: {0}", t.GetLengthInSeconds());
                Console.WriteLine("Category: {0}", t.Style.ToString());
                Console.WriteLine("");
            }
            Console.WriteLine("Druk op een toets voor opdracht 2 tester...");
            Console.ReadLine();
            Console.Clear();

            //Dit is de tester van opdracht 2
            TrackList shuffledList = trackList.GetShuffledList();

            Console.WriteLine("=====Opdracht 2=====");
            Console.WriteLine("Totale lengte shufflelist: {0}", shuffledList.TotalTime().ToString());
            Console.WriteLine("");
            Console.WriteLine("De geschuffelde list:");
            foreach (Track t in shuffledList)
            {
                Console.WriteLine("Naam: {0}", t.DisplayName);
                Console.WriteLine("Lengte: {0}", t.DisplayLength);
                Console.WriteLine("Tijd in seconden: {0}", t.GetLengthInSeconds());
                Console.WriteLine("Category: {0}", t.Style.ToString());
                Console.WriteLine("");
            }
            Console.WriteLine("Druk op een toets voor opdrachten 3 & 4 tester...");
            Console.ReadLine();
            Console.Clear();

            //Dit is de tester van opdracht 3 en 4
            //Hier declareren wij de nieuwe records (Hier maken we ze aan en geven ze waardes)

            MemoRecorder r1 = new MemoRecorder(1);
            r1.Make = "Sony ";
            r1.Model = "SonyModel1 ";
            r1.PriceExBtw = (decimal)5.00;
            r1.CreationDate = DateTime.Parse("6/2/2017");
            r1.MaxCartridgeType = MemoRecorder.MemoCartridgeType.c60;

            MemoRecorder r2 = new MemoRecorder(1);
            r2.Make = "Samsung ";
            r2.Model = "SamsungModel1 ";
            r2.PriceExBtw = (decimal)3.99;
            r2.CreationDate = DateTime.Parse("5/2/2017");
            r2.MaxCartridgeType = MemoRecorder.MemoCartridgeType.c90;

            MemoRecorder r3 = new MemoRecorder(3);
            r3.Make = "Dell ";
            r3.Model = "DellModel1 ";
            r3.PriceExBtw = (decimal)100.0;
            r3.CreationDate = DateTime.Parse("4/2/2017");
            r3.MaxCartridgeType = MemoRecorder.MemoCartridgeType.c120;

            MemoRecorder r4 = new MemoRecorder(4);
            r4.Make = "Apple ";
            r4.Model = "AppleModel1 ";
            r4.PriceExBtw = (decimal)6.50;
            r4.CreationDate = DateTime.Parse("3/2/2017");
            r4.MaxCartridgeType = MemoRecorder.MemoCartridgeType.Unknown;

            Console.WriteLine("=====Opdracht 3 & 4=====");
            Console.WriteLine("");

            Console.WriteLine(r1.DisplayIdentity(true, true));
            Console.WriteLine(r1.DisplayStorageCapacity());
            Console.WriteLine(r1.GetDeviceLifeTime());
            Console.WriteLine("Consumer price: {0}", r1.ConsumerPrice);
            Console.WriteLine("");

            Console.WriteLine(r2.DisplayIdentity(true, false));
            Console.WriteLine(r2.DisplayStorageCapacity());
            Console.WriteLine(r2.GetDeviceLifeTime());
            Console.WriteLine("Consumer price: {0}", r2.ConsumerPrice);
            Console.WriteLine("");

            Console.WriteLine(r3.DisplayIdentity(false, true));
            Console.WriteLine(r3.DisplayStorageCapacity());
            Console.WriteLine(r3.GetDeviceLifeTime());
            Console.WriteLine("Consumer price: {0}", r3.ConsumerPrice);
            Console.WriteLine("");

            Console.WriteLine(r4.DisplayIdentity());
            Console.WriteLine(r4.DisplayStorageCapacity());
            Console.WriteLine(r4.GetDeviceLifeTime());
            Console.WriteLine("Consumer price: {0}", r4.ConsumerPrice);
            Console.WriteLine("");

            Console.WriteLine("Druk op een toets voor opdracht 5 tester...");
            Console.ReadLine();
        }
    }
}
