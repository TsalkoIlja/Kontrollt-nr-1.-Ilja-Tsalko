using System;

namespace Kontrolltöö_nr_1._Ilja_Tsalko
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            int valik = -1;

            while (valik != 0)
            {
                Console.WriteLine("\nPEAMENÜÜ");
                Console.WriteLine("1 - Kütuse kalkulaator");
                Console.WriteLine("2 - Isikukoodi analüüs");
                Console.WriteLine("3 - Täringumäng");
                Console.WriteLine("4 - Palgaarvestus");
                Console.WriteLine("0 - Välju");
                Console.Write("Sinu valik: ");

                int.TryParse(Console.ReadLine(), out valik);

                switch (valik)
                {
                    case 1:
                        Alamfunktsioonid.KytuseKalkulaator();
                        break;

                    case 2:
                        Console.Write("Sisesta isikukood: ");
                        string ik = Console.ReadLine();
                        Console.WriteLine(Alamfunktsioonid.HindaIsikukood(ik));
                        break;

                    case 3:
                        Alamfunktsioonid.TaringuMang();
                        break;

                    case 4:
                        Console.Write("Sisesta brutopalk: ");
                        double bruto = double.Parse(Console.ReadLine());

                        var tulemus = Alamfunktsioonid.ArvutaPalk(bruto);

                        Console.WriteLine("\nPalgaarvestus");
                        Console.WriteLine($"Maksuvaba tulu: {tulemus.Item1:F2} €");
                        Console.WriteLine($"Netopalk: {tulemus.Item2:F2} €");
                        break;

                    case 0:
                        Console.WriteLine("Programm lõpetas töö.");
                        break;

                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }
    }
