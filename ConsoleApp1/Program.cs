using System;

namespace csgotuntilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            double tunnit = 0, ikä = 0, days = 0, months = 0, years = 0, elo = 1000;
            string premade = "";

            try
            {
                //BY---JULiUS---AALTO---//
                Console.WriteLine("~~~~~~~CSGO/CS2-TUNTiLASKURi~~~~~~~");
                Console.WriteLine("**********************************");

                Console.WriteLine();
                Console.Write("Syötä ikäsi: ");
                ikä = double.Parse(Console.ReadLine());

                Console.Write("Syötä CSGO/CS2 tuntisi: ");
                tunnit = double.Parse(Console.ReadLine());

                Console.Write("Pelaatko premadella? Vastaa: (K, tai E): ");
                premade = Console.ReadLine();
                premade = premade.ToUpper();
                Console.WriteLine();


                if (premade == "K" && tunnit >= 2000)
                {
                    elo = elo + 750; //stäkki-lisä
                }

                else if (premade == "E")
                {
                    elo = elo * 0.9;
                }

                else
                {
                    Console.WriteLine("Tarkista mitä kirjoitit!");
                    return;
                }

                if (ikä >= 31)
                {
                    elo = elo - 300; //ikä-vähennys
                }

                if (ikä > 70)
                {
                    Console.WriteLine("Virheellinen ikä. Tarkista ikäsi!");
                    return;
                }

                if (tunnit < 0 || ikä < 0)
                {
                    Console.WriteLine("Et voi asettaa minus-arvoja! Tarkista kentät.");
                    return;
                }
                else if (tunnit <= 50)
                {
                    Console.WriteLine("Premier elosi on alle 1000. Faceit levelisi on 1-2");
                    elo = elo - 200;
                }
                else if (tunnit <= 100)
                {
                    Console.WriteLine("Premier elosi on 1000-1999. Faceit levelisi on 1-2");
                    elo = elo - 100;
                }
                else if (tunnit <= 150)
                {
                    Console.WriteLine("Premier elosi on 2000-2999. Faceit levelisi on 3 tai alle!");
                    elo = elo + 100;
                }
                else if (tunnit <= 200)
                {
                    Console.WriteLine("Premier elosi on 3000-3999. Faceit levelisi on 3 tai alle!");
                    elo = elo + 200;
                }
                else if (tunnit <= 220)
                {
                    Console.WriteLine("Premier elosi on 4000-4999. Faceit levelisi on 4 tai alle!");
                    elo = elo + 300;
                }
                else if (tunnit <= 240)
                {
                    Console.WriteLine("Premier elosi on 5000-5999. Faceit levelisi on 5 tai alle!");
                    elo = elo + 320;
                }
                else if (tunnit <= 260)
                {
                    Console.WriteLine("Premier elosi on 6000-6999. Faceit levelisi on 5 tai alle!");
                    elo = elo + 340;
                }
                else if (tunnit <= 280)
                {
                    Console.WriteLine("Premier elosi on 7000-7999. Faceit levelisi on 5 tai alle!");
                    elo = elo + 360;
                }
                else if (tunnit <= 300)
                {
                    Console.WriteLine("Premier elosi on 8000-8999. Faceit levelisi on 6 tai alle!");
                    elo = elo + 380;
                }
                else if (tunnit <= 320)
                {
                    Console.WriteLine("Premier elosi on 9000-9999. Faceit levelisi on 6 tai alle!");
                    elo = elo + 400;
                }
                else if (tunnit <= 340)
                {
                    Console.WriteLine("Premier elosi on 10000-10999, Faceit levelisi on 6 tai alle!");
                    elo = elo + 420;
                }
                else if (tunnit <= 360)
                {
                    Console.WriteLine("Premier elosi on 11000-11999 ja Faceit level: 6");
                    elo = elo + 440;
                }
                else if (tunnit <= 380)
                {
                    Console.WriteLine("Premier elosi on 12000-14999 Faceit level: 7");
                    elo = elo + 460;
                }
                else if (tunnit <= 400)
                {
                    Console.WriteLine("Premier elosi on 15000-17999 Faceit level: 7-8");
                    elo = elo + 480;
                }
                else if (tunnit <= 600)
                {
                    Console.WriteLine("Premier elosi on 18000-19999 Faceit level: 8");
                    elo = elo + 500;
                }
                else if (tunnit <= 1000)
                {
                    Console.WriteLine("Premier elosi on 20000-22999, ja Faceit level: 8-9");
                    elo = elo + 600;
                }
                else if (tunnit <= 1750)
                {
                    Console.WriteLine("Premier elosi on 23000-24999 Faceit level: 8-9");
                    elo = elo + 700;
                }
                else if (tunnit <= 2000)
                {
                    Console.WriteLine("Premier elosi on 25000-27999, Faceit level: 9");
                    elo = elo + 800;
                }

                else if (tunnit <= 2500)
                {
                    Console.WriteLine("Premier elosi on 28000-28999 ja Faceit level: 10");
                    elo = elo + 900;
                }

                else if (tunnit <= 3000)
                {
                    Console.WriteLine("Premier elosi on 29000-29999, ja Faceit level: 10");
                    elo = elo + 1111;
                }

                else if (tunnit <= 4000)
                {
                    Console.WriteLine("Premier elosi on 30000-30999, ja Faceit level: 10.");
                    elo = elo + 1222;
                }

                else if (tunnit <= 9999)
                {
                    Console.WriteLine("Premier elosi on 31000-31999, ja Faceit level: 10 !!!");
                    elo = elo + 1444;
                }

                else if (tunnit <= 19000)
                {
                    Console.WriteLine("Premier elosi on 32000-32999, mutta olisiko jo aika lopettaa?");
                    elo = elo + 1600;
                }
                else if (tunnit >= 20000 || tunnit > 19991)
                {
                    Console.WriteLine("Premier elosi on +33000, mutta olisiko jo aika lopettaa?");
                    elo = elo + 2000;
                }

                else
                {
                    Console.WriteLine("Syötä vain numeerisia arvoja!!");
                    return;
                }
                Console.WriteLine("Faceit-elosi on arviolta: ~{0} ", elo);
                Console.WriteLine();

                days = tunnit / 24;
                months = days / 30;
                years = months / 12;

                Console.WriteLine("Olet pelannut elämästäsi {0:F2} päivää, joka on {1:F2} vuotta.. eli {2:F2} kuukautta!", days, years, months);
                Console.WriteLine();
                Console.ReadLine();

            }

            catch (Exception)
            {
                Console.WriteLine("Käytä vain numeerisia arvoja!");
                return;
            }
        }
    }
}
