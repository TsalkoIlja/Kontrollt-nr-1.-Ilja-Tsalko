using System;
using System.Collections.Generic;
using System.Text;

namespace Kontrolltöö_nr_1._Ilja_Tsalko
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            //Главное меню
            Console.WriteLine("1) KytuseKalkulaator");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    
                
                    Console.Write("Läbitud teepikkus (km): ");

                    float KM = float.Parse(Console.ReadLine());
                    Console.Write("Kütusekulu 100km kohta (liitrit):");
                    float liitrit = float.Parse(Console.ReadLine());
                    Console.Write("Kütuse liitri hind (euro):");
                    float hind = float.Parse(Console.ReadLine());
                    float liit = (KM / 100) * liitrit;
                    float hiliir = 
                    Console.Write($"{liit}");
                break;
            }
        }
    }
}
