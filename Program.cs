using System;
using System.Collections.Generic;

namespace Kalender
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eingabe> termin = new List<Eingabe>();

            Eingabe eins = new Eingabe();
            eins.Date = "14. Oktober 2020";
            eins.Title = "Hausübung machen";

            termin.Add(eins);

            Eingabe zwei = new Eingabe();
            zwei.Date = "30. November 2020";
            zwei.Title = "Treffen in Zell am See";

            termin.Add(zwei);

            foreach (var item in termin)
            {
                Console.WriteLine($"Termin: {item.Date},    {item.Title}");
            }
           

        }
    }
}
