using System;
﻿namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;

            }
        }
       static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man", "12A", 2008, false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { hulk, ironMan, antMan };
            Film latest = filmCollection[0];
 
            foreach (Film f in filmCollection)
            {
                if (f.year > latest.year)
                {
                    latest = f;
                }
            }
            Console.WriteLine($"The latest film is {latest.title}");
            for (int i = 0; i < filmCollection.Length; i++)
            {
                if (filmCollection[i].title == "Ant-Man")
                {
                    filmCollection[i] = new Film(filmCollection[i].title, filmCollection[i].certificate, filmCollection[i].year, true);
                    break;
                }
            }
            foreach (Film f in filmCollection)
            {
                Console.WriteLine($"{f.title} Is currently being shown? : {f.beingShown}");
            }
        }

            //  Write the code to do the following
            // Loop through the array of films and check for the newest film
            // Produce one output to say the name of the newest film

            // Write the code to update the andMan record to show the film is currently being shown


        
    }
}
