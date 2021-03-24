using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vezba 1
            //1.Ispišite ime i prezime u dvareda.
            //2.Ispiši svoje ime i prezime u dva reda koristeći samo jednu naredbu WRITE.
            //3.Ispisati ime i prezime pa odvojiti jedan tab pa ispisati broj indeksa.
            //4.Ispisati tri imena u dve kolone:
            //a.Sa dve naredbe WriteLine.
            //b.Sa jednom naredbomWrite.

            Console.WriteLine("Milovan");
            Console.WriteLine("Srdanovic");
            Console.WriteLine("Milovan\nSrdanovic");
            Console.WriteLine("Milovan Srdanovic\t2i1/0107/20");
            Console.WriteLine("Kirk\tSpock\tUhura");
            Console.WriteLine("McCoy\tSulu\tChekov");
            Console.WriteLine("Picard\tData\tLaForge\nRo\tRiker\tTroy");

            // Vezba 2

            //1.Tražiti od korisnika da unese ime i prezime, pol i koliko ima godina. Ispisati unešene vrednosti u dva reda.
            //2.Napraviti program koji pamti ime i prezime u dve promenljive, pa ih posle ispisuje na ekran.
            //3.Napisati program koji pamti broj u promenljivu, pa ga ispisuje na ekran.
            //4.Napisati program koji traži od korisnika da unese dva broja i ispisuje rezultat oduzimanja ta dva broja.
            //5.Napisati program koji traži od korisnika da unese dva broja(decimal) i ispisuje rezultat deljenja ta dva broja.
            //6.Napisati program koji traži od korisnika da unese tri broja i ispisuje rezultat tako što sabere prva dva i pomnoži sa trećim.
            //7.Napisati program koji traži od korisnika da unese dva broja, program treba da odradi sve osnovne operacije(+,-,*,/),
            //  a rezultat svake operacije se ispisuje u novi red.

            string ime;
            Console.Write("Unesite ime: ");
            ime = Console.ReadLine();
            string prezime;
            Console.Write("Unesite prezime: ");
            prezime = Console.ReadLine();
            string pol;
            Console.Write("Vas pol(M/Z): ");
            pol = Console.ReadLine();
            string godine;
            int g;
            Console.Write("Godine: ");
            godine = Console.ReadLine();
            g = int.Parse(godine);
            Console.WriteLine("Ja sam " + ime + " " + prezime);
            Console.WriteLine(pol + " sam pola, i imam " + godine + " godina");
            Console.WriteLine("Oduzimanje brojeva:");
            string broj1;
            int b1;
            string broj2;
            int b2;
            Console.Write("Unesite prvi broj: ");
            broj1 = Console.ReadLine();
            b1 = int.Parse(broj1);
            Console.Write("Unesite drugi broj: ");
            broj2 = Console.ReadLine();
            b2 = int.Parse(broj2);
            Console.WriteLine(b1 - b2);
            Console.WriteLine("Druga sintaksa, sabiranje:");
            int broj3;
            int broj4;
            Console.Write("Unesite prvi broj: ");
            broj3 = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            broj4 = int.Parse(Console.ReadLine());
            Console.WriteLine(broj3 + broj4);
            Console.WriteLine("Deljenje brojeva:");
            decimal broj5;
            decimal broj6;
            Console.Write("Unesite prvi broj: ");
            broj5 = decimal.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            broj6 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(broj5 / broj6);
            Console.WriteLine("Sabiranje prva dva broja i mnozenje sa trecim:");
            int broj7;
            int broj8;
            int broj9;
            Console.WriteLine("Unesite prvi broj: ");
            broj7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            broj8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj: ");
            broj9 = int.Parse(Console.ReadLine());
            Console.WriteLine((broj7 + broj8) * broj9);
            Console.WriteLine("Sve operacije sa data dva broja:");
            decimal broj10;
            decimal broj11;
            Console.WriteLine("Unesite prvi broj: ");
            broj10 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            broj11 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rezultati su:");
            Console.WriteLine(broj10 + broj11);
            Console.WriteLine(broj10 - broj11);
            Console.WriteLine(broj10 * broj11);
            Console.WriteLine(broj10 / broj11);
            
            // Vezba 3

            // Zadatak 1 Napisati program koji traži od korisnika da unese tri broja i ispisuje najveći unešeni broj.

            int broj1, broj2, broj3;
            Console.WriteLine("Unesite prvi broj:");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj:");
            broj3 = int.Parse(Console.ReadLine());

            if (broj1 > broj2 && broj1 > broj3)
            {
                Console.WriteLine("Prvi broj je najveci");
            } else if (broj2 > broj1 && broj2 > broj3)
            {
                Console.WriteLine("Drugi broj je najveci");
            } else if (broj3 > broj1 && broj3 > broj2)
            {
                Console.WriteLine("Treci broj je najveci");
            } else
            {
                Console.WriteLine("Neki od brojeva su jednaki");
            }
            
            // Zadatak 2 Napisati program koji traži od korisnika da unese tri brojeva i ispisuje najmanji unešeni broj.

            int broj1, broj2, broj3;
            Console.WriteLine("Unesite prvi broj:");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj:");
            broj3 = int.Parse(Console.ReadLine());

            if (broj1 < broj2 && broj1 < broj3)
            {
                Console.WriteLine("Prvi broj je najmanji");
            }
            else if (broj2 < broj1 && broj2 < broj3)
            {
                Console.WriteLine("Drugi broj je najmanji");
            }
            else if (broj3 < broj1 && broj3 < broj2)
            {
                Console.WriteLine("Treci broj je najmanji");
            }
            else
            {
                Console.WriteLine("Neki od brojeva su jednaki");
            }
            
            // Zadatak 3 Tražiti od korisnika da se unese ime, prezime i pol, ako je muško pitati ga da li je bio u vojsci.
            
            
            
            // Vezba 4

            //string lozinka = "Pera";

            //do
            //{
            //    Console.WriteLine("Unesi lozinku");
            //    lozinka = Console.ReadLine();
            //} while (lozinka!="Pera");  //Uslov

            // Zadatak 2

            //int broj1, broj2;

            //Random rnd = new Random();

            //broj1 = rnd.Next(1, 10);
            //broj2 = rnd.Next(1, 10);

            //while (broj1 > broj2)
            //{
            //    Console.WriteLine($"Generisani su brojevi " + broj1 + " i broj " + broj2);
            //    broj1 = rnd.Next(1, 10);
            //    broj2 = rnd.Next(1, 10);
            //}

            // Zadatak 3 Unosi se broj sve dok se ne unese 0 ispisati zbir tih brojeva.

            //int broj1, broj2, suma = 0, brojac=0;
            //Random rnd = new Random();

            //do
            //{
            //    broj1 = rnd.Next(1, 10);
            //    suma += broj1;
            //    brojac++;
            //    Console.WriteLine($"Generisani su brojevi " + broj1 + " i broj " + broj2);
            //} while (broj1 != 0);

            // Zadatak 4 Generišu se slučajni brojevi od 10-60 sve dok se ne dobije broj deljiv sa 5. Taj broj treba prikazati na ekranu. Prikazati broj pokušaja i srednju vrednost.

            //int broj, brojac = 0, suma = 0,srednja=0;
            //Random rnd = new Random();
            //broj = rnd.Next(10, 60);
            //Console.WriteLine(broj);

            //while (broj%5==0)
            //{

            //    broj = rnd.Next(10, 60);
            //    suma += broj;
            //    brojac++;
            //    srednja = suma / brojac;
            //    Console.WriteLine("Broj " + broj);
            //}

            //Console.WriteLine($"Broj pokusaja {brojac}, srednja vrednost{srednja}");

            // Zadatak 5 Unosi se broj sve dok je u intervalu od 10-30. Izračunati sumu parnih i broj neparnih brojeva.

            int broj, suma=0, brojac=0;
            Console.WriteLine("Unesite broj");
            broj = int.Parse(Console.ReadLine());

            while (broj > 10 && broj < 30)
            {
                Console.WriteLine("Unesite broj");
                broj = int.Parse(Console.ReadLine());
                if (broj % 2 == 0)
                {
                    suma += broj;
                }
                else
                {
                    brojac++;
                }
            }

            Console.WriteLine($"Suma je {suma}, broj neparnih je {brojac}");

            // Zadatak 6 Generišu se dva broja u intervalu od 1-100. Ako je drugi broj veći od prvog,
            // prvi broj se uvećava dva puta sve dok ne bude veći od drugog. Ispisati koliko je prvi broj puta morao da se uveća.

            //int broj1, broj2;
            //Random rnd = new Random();

            //broj1 = rnd.Next(1, 100);
            //broj2 = rnd.Next(1, 100);

            //while (broj1 > broj2)
            //{
            //    Console.WriteLine(broj1 + " je vece od " + broj2);
            //    break;
            //}

            // Zadatak 7 Unose se brojevi sve dok je zbir svakog trećeg broja manji od 30. Nakon toga ispisati koliko brojeva je uneto i njihov zbir.

            // Zadatak 8 Unosi se broj od 1-20. Nakon toga se generišu brojevi od 1 - 20 sve dok generisani broj ne bude jednak unetom broju ili broj pokušaja ne bude manji od 20.

            // Zadatak 9 Unose se ekstenzije (xlsx, docx, xml, cs, txt) za svaki unos ispisuje se naziv programa koji pokreće taj fajl. Sve dok se ne unese exit program nastavlja da se izvršava.

            // Zadatak 10 Unose se brojevi sve dok se ne unese dva puta broj deljiv sa 5. Svaki put kada se unese broj deljiv sa 3 resetuje se brojač petica. Ispisati srednju vrednost parnih brojeva.
            
        }
    }
}
