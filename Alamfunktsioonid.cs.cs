using System;
using System.Collections.Generic;

namespace Kontrolltöö_nr_1._Ilja_Tsalko
{
    // Klass, mis sisaldab kõik tööks vajalikud meetodid
    public class Alamfunktsioonid
    {
        
        // ÜLESANNE 1 – KÜTUSEKALKULAATOR
        public static void KytuseKalkulaator()
        {
            try
            {
                Console.Write("Sisesta läbitud vahemaa (km): ");
                double kilometraaž = double.Parse(Console.ReadLine());

                Console.Write("Sisesta kütusekulu 100 km kohta (liitrit): ");
                double kulu100km = double.Parse(Console.ReadLine());

                Console.Write("Sisesta kütuse liitri hind (€): ");
                double liitriHind = double.Parse(Console.ReadLine());

                // Kui palju liitreid kulus?
                double kulunudLiitrid = (kilometraaž / 100) * kulu100km;

                // Reisi kogumaksumus
                double reisiMaksumus = kulunudLiitrid * liitriHind;

                Console.WriteLine("\n--- Tulemus ---");
                Console.WriteLine($"Kulunud kütus: {kulunudLiitrid:F2} liitrit");
                Console.WriteLine($"Reisi maksumus: {reisiMaksumus:F2} €");
            }
            catch
            {
                Console.WriteLine("Sisestatud andmed ei ole õiged!");
            }
        }

        
        // ÜLESANNE 2 – ISIKUKOOD
        
        public static string HindaIsikukood(string isikukood)
        {
            if (isikukood.Length != 11)
                return "Viga: isikukood peab olema 11 numbrit!";

            string sugu = "Tundmatu";
            string sajand = "";

            // Esimene number määrab soo ja sajandi
            char esimene = isikukood[0];

            if (esimene == '1' || esimene == '2')
                sajand = "18";
            else if (esimene == '3' || esimene == '4')
                sajand = "19";
            else if (esimene == '5' || esimene == '6')
                sajand = "20";

            if (esimene == '1' || esimene == '3' || esimene == '5')
                sugu = "Mees";
            else if (esimene == '2' || esimene == '4' || esimene == '6')
                sugu = "Naine";

            string aasta = sajand + isikukood.Substring(1, 2);
            string kuu = isikukood.Substring(3, 2);
            string paev = isikukood.Substring(5, 2);

            return $"Oled {sugu}, sündinud {paev}.{kuu}.{aasta}";
        }

        
        // ÜLESANNE 3 – TÄRINGUMÄNG
        
        public static void TaringuMang()
        {
            Random rnd = new Random();
            List<int> summad = new List<int>();

            int duublid = 0;
            int kogusumma = 0;

            Console.WriteLine("\nTäringu visked:");

            for (int i = 0; i < 10; i++)
            {
                int taring1 = rnd.Next(1, 7);
                int taring2 = rnd.Next(1, 7);

                if (taring1 == taring2)
                    duublid++;

                int summa = taring1 + taring2;
                summad.Add(summa);
                kogusumma += summa;
            }

            // Kuvame kõik summad
            Console.WriteLine(string.Join(" ", summad));

            Console.WriteLine($"Duubleid visati: {duublid}");
            Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}");
        }

        
        // ÜLESANNE 4 – PALGAARVESTUS
        
        public static Tuple<double, double> ArvutaPalk(double brutopalk)
        {
            double maksuvabaTulu = 0;

            // Maksuvaba tulu ainult kui bruto < 1200
            if (brutopalk < 1200)
                maksuvabaTulu = 654;

            double maksustatavOsa = brutopalk - maksuvabaTulu;

            if (maksustatavOsa < 0)
                maksustatavOsa = 0;

            double tulumaks = maksustatavOsa * 0.20;
            double tootuskindlustus = brutopalk * 0.016;
            double pension = brutopalk * 0.02;

            double netopalk = brutopalk - tulumaks - tootuskindlustus - pension;

            return Tuple.Create(maksuvabaTulu, netopalk);
        }
    }
}

