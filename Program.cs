using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CreatingOfTheCinema
{

    /* 
    Lets create abstract class and set there fields with main attributes. Derived classes are needed as well.
    Well need to create an array of the cinemas.
    Size and amount of the cinemas we should find out by using 'random' function. 
    Then well need to sort array from the bigger one to slover and to display info about all cinemas.
    */
    class Program
    {
        public class CinemaBuilding
        {
            public int numOfSeats { get; set; }
            public int numOfRows { get; set; }
            public int luxVIPzone { get; set; }
            public int lengthOgScene { get; set; }
            public int widthOgScene { get; set; }

            public virtual void GetInfo()
            {
                Console.WriteLine("amount of the seats is next: {0}", numOfSeats);
                Console.WriteLine("amount of the rows is next: {0}", numOfRows);
                Console.WriteLine("is there extra lux VIP zone and how much?: {0}", luxVIPzone);
                Console.WriteLine("wall length: {0}", lengthOgScene);
                Console.WriteLine("wall width: {0}", widthOgScene);
            }
        }
        class Cinemacity_cinema : CinemaBuilding
        {
            public int cinemacityEmployee { get; set; }

        }
        class Multikino_cinema : CinemaBuilding
        {
            public int multikinoEmployee { get; set; }

        }
        class Russia_cinema : CinemaBuilding
        {
            public int russiaCinemaEmployee { get; set; }

        }
        static void Main(string[] args)
        {
            Random R = new Random();

            CinemaBuilding sOne = new CinemaBuilding()
            {
                numOfSeats = R.Next(250, 501),
                numOfRows = R.Next(20, 31),
                luxVIPzone = R.Next(0, 4),
                lengthOgScene = R.Next(20, 31),
                widthOgScene = R.Next(30, 41)
            };
            CinemaBuilding sTwo = new CinemaBuilding()
            {
                numOfSeats = R.Next(250, 501),
                numOfRows = R.Next(20, 31),
                luxVIPzone = R.Next(0, 4),
                lengthOgScene = R.Next(20, 31),
                widthOgScene = R.Next(30, 41)
            };
            CinemaBuilding sThree = new CinemaBuilding()
            {
                numOfSeats = R.Next(250, 501),
                numOfRows = R.Next(20, 31),
                luxVIPzone = R.Next(0, 4),
                lengthOgScene = R.Next(20, 31),
                widthOgScene = R.Next(30, 41)
            };

            List<CinemaBuilding> CinemaBuildingList = new List<CinemaBuilding>();
            CinemaBuildingList.Add(sOne);
            CinemaBuildingList.Add(sTwo);
            CinemaBuildingList.Add(sThree);

            // printing info regarding first cinema :)

            for (int i = 0; i < CinemaBuildingList.Count; i++)
            { 
            CinemaBuilding s = CinemaBuildingList[i];
            s.GetInfo();
            }
            Console.ReadKey();
        }
    }
}
