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
        }
    }
}
