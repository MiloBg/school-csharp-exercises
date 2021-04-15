using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vezba 1
            //1.Ispišite ime i prezime u dva reda.
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
            
            // Vezba 3 PETLjA IF

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
            
            // Zadatak 2 Napisati program koji traži od korisnika da unese tri broja i ispisuje najmanji unešeni broj.

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
            
            string ime;
            string prezime;
            string pol;
            Console.WriteLine("Unesite vase ime:");
            ime = Console.ReadLine();
            Console.WriteLine("Unesite vase prezime:");
            prezime = Console.ReadLine();
            Console.WriteLine("Unesite vas pol (M ili Z):");
            pol = char.Parse(Console.ReadLine());

            if (pol == 'M' || pol == 'm')
            {
                Console.WriteLine("Da li ste bili u vojsci?");
                Console.ReadLine();
                Console.WriteLine("Hvala na odgovoru, gospodine " + prezime);
            }
            else
            {
                Console.WriteLine("Hvala na odgovoru, gospodjo/djice " + prezime);
            }
            
            // Zadatak 4 Deca i penzioneri imaju besplatan prevoz. Decom se smatraju osobe do 7 godina,apenzionerima osobe preko 65 godina.
            // Napisati program koji pita korisnika „Koliko imaš godina ?“.
            // Program treba da ispiše „Besplatan prevoz“ ako je uslov ispunjen ili „ Plaćaš kartu“ ako nije ispunjen.
            
            int godine;
            Console.WriteLine("Koliko imaš godina?");
            godine = int.Parse(Console.ReadLine());

            if (godine <= 7 || godine >= 65)
            {
                Console.WriteLine("Besplatan prevoz");
            }
            else
            {
                Console.WriteLine("Plaćaš kartu");
            }
            
            // Zadatak 5 Napisati program koji traži od korisnika da unese broj godina.
            // Ukoliko korisnik unese broj manji od 18, program treba da ispiše „Korisnik je maloletan“;
            // U suprotnom - „Korisnik je punoletan“.
            
            int godine;
            Console.WriteLine("Unesite broj godina:");
            godine = int.Parse(Console.ReadLine());

            if (godine < 18)
            {
                Console.WriteLine("Korisnik je maloletan");
            }
            else
            {
                Console.WriteLine("Korisnik je punoletan");
            }
            
            // Zadatak 6 Generiše se slučajan broju intervalu(1, 15). Odrediti da li je broj veći od 5 a manji od 10 i ispšite ga.
            
            Random rnd = new Random();
            int broj;

            broj = rnd.Next(1, 15);
            Console.WriteLine("Slučajno izabran broj od 1-15 je " + broj);

            if (broj > 5 && broj < 10)
            {
                Console.WriteLine("Ovaj broj je veci od 5, a manji od 10");
            }
            else
            {
                Console.WriteLine("Ovaj broj nije izmedju 5 i 10");
            }
            
            // Zadatak 7 Generiše se slučajan broj u intervalu (1,100) ako je generisani broj deljiv sa 10, ispiši ga.
            
            Random rnd = new Random();
            int broj;

            broj = rnd.Next(1, 100);
            Console.WriteLine("Slučajno izabran broj od 1-100 je " + broj);

            if (broj % 10 == 0)
            {
                Console.WriteLine($"Broj {broj} je deljiv sa 10");
            }
            else
            {
                Console.WriteLine("Ovaj broj nije deljiv sa 10");
            }
            
            // Zadatak 8 Generiše se slučajan broj u intervalu (1,10). Proveriti da li je broj neparan i ako jeste ispišite ga.
            
            Random rnd = new Random();
            int broj;

            broj = rnd.Next(1, 10);
            Console.WriteLine("Slučajno izabran broj od 1-10 je " + broj);

            if (broj % 2 != 0)
            {
                Console.WriteLine($"Broj {broj} je neparan");
            }
            else
            {
                Console.WriteLine("Ovaj broj je paran");
            }
            
            // Zadatak 9 Generiše se slučajan broj u intervalu (1, 50). Ako je generisani broj paran i u intervalu (1, 25) ispišite ga.
            
            Random rnd = new Random();
            int broj;

            broj = rnd.Next(1, 50);
            Console.WriteLine("Slučajno izabran broj od 1-50 je " + broj);

            if (broj % 2 == 0 && broj >= 1 && broj <= 25)
            {
                Console.WriteLine($"Broj {broj} je u intervalu od 1 do 25 i paran je");
            }
            else
            {
                Console.WriteLine("Ovaj broj nije u intervalu od 1 do 25, ili nije paran");
            }
            
            // Zadatak 10 Generiše se slučajan broj u intervalu (7, 77).
            // Ukoliko je broj paran, proverava se da li je u intervalu od 35 do 77 i u tom slučaju ga ispisati.
            // U slučaju da je neparan, treba ga prikazati ako je manji od 35 i veći od 15.
            
            Random rnd = new Random();
            int broj;

            broj = rnd.Next(7, 77);
            Console.WriteLine("Slučajno izabran broj od 7-77 je " + broj);

            if (broj % 2 == 0 && broj >= 35 && broj <= 77)
            {
                Console.WriteLine($"Broj {broj} je paran i u intervalu od 35 do 77");
            }
            else if (broj % 2 != 0 && broj <= 35 && broj >= 15)
            {
                Console.WriteLine($"Broj {broj} je neparan i u intervalu od 15 do 35");
            }
            else
            {
                Console.WriteLine("Ovaj broj ne ulazi ni u jednu kategoriju");
            }
            
            // Vezba 4 PETLjE WHILE I DO WHILE
            
            // Zadatak 1 Unosi se lozinka, sve dok se ne unese ispravna lozinka program se ne prekida.

            string lozinka = "Pera";

            do
            {
                Console.WriteLine("Unesi lozinku");
                lozinka = Console.ReadLine();
            }
            while (lozinka != "Pera");  //Uslov

            // Zadatak 2 Generišu se dva broja, sve dok je a veće od b ispisuju se ti brojevi (u jednoj liniji iizmeđu njih se ispisuje zarez).
            // U slučaju da je b veći izlazi se iz programa.

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
            
            // VEZBA 6
            
            //int a = 7, b = 3, max;
            //if (a > b)
            //{
            //    max = a;
            //} else
            //{
            //    max = b;
            //}

            //max = (a > b) ? a : b;

            // Napraviti program koji na osnovu unetog broja(1 - 7) ispisuje dan u nedelji

            //int broj3;
            //Console.WriteLine("Unesi broj dana:");
            //broj3 = int.Parse(Console.ReadLine());

            //try
            //{
            //    switch (broj3)
            //    {
            //        case 1:
            //            Console.WriteLine("Ponedeljak");
            //            break;
            //        case 2:
            //            Console.WriteLine("Utorak");
            //            break;
            //        case 3:
            //            Console.WriteLine("Sreda");
            //            break;
            //        case 4:
            //            Console.WriteLine("Cetvrtak");
            //            break;
            //        case 5:
            //            Console.WriteLine("Petak");
            //            break;
            //        case 6:
            //            Console.WriteLine("Subota");
            //            break;
            //        case 7:
            //            Console.WriteLine("Nedelja");
            //            break;
            //        default:
            //            Console.WriteLine("Nema dana sa tim brojem");
            //            break;
            //    }

            //}
            //catch (Exception greska)
            //{
            //    Console.WriteLine($"Doslo je do greske {greska.Message}");
            //}

            //// Napraviti program koji ispisuje uspeh na osnovu dobijene ocene

            //int ocena;
            //Console.WriteLine("Unesi ocenu:");
            //ocena = int.Parse(Console.ReadLine());

            //switch (ocena)
            //{
            //    case 1:
            //        Console.WriteLine("Nedovoljan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Dovoljan");
            //        break;
            //    case 3:
            //        Console.WriteLine("Dobar");
            //        break;
            //    case 4:
            //        Console.WriteLine("Vrlo dobar");
            //        break;
            //    case 5:
            //        Console.WriteLine("Odlican");
            //        break;
            //    default:
            //        Console.WriteLine("Unesite validnu ocenu");
            //        break;
            //}

            //// Napisati program za ispis broja dana u mesecu na osnovu sledećih uslova
            //// Moguce je napraviti jos jedan if sa godinom kao varijabilom za broj dana u februaru godine koja nije prestupna (if ostatak deljenja godine sa 4 bude 0, onda je prestupna)

            //int mesec;
            //Console.WriteLine("Unesi mesec u 2020. godini:");
            //mesec = int.Parse(Console.ReadLine());

            //switch (mesec)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Mesec ima 31 dan");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Mesec ima 30 dana");
            //        break;
            //    case 2:
            //        Console.WriteLine("Prestupna godina, mesec ima 29 dana");
            //        break;
            //    default:
            //        Console.WriteLine("Unesite validan broj meseca");
            //        break;
            //}

            //// Napisati program koji za upisani samoglasnik uvećava brojač odgovarajućeg samoglasnika.

            //string tekst;
            //Console.WriteLine("Unesite neki tekst:");
            //tekst = Console.ReadLine();
            //int brojac = 0;

            //foreach (var samoglasnik in tekst)
            //{
            //    if (samoglasnik == 'a' || samoglasnik == 'A' || samoglasnik == 'e' || samoglasnik == 'E' || samoglasnik == 'i' || samoglasnik == 'I' || samoglasnik == 'o' || samoglasnik == 'O' || samoglasnik == 'u' || samoglasnik == 'U')
            //    {
            //        brojac++;
            //    }
            //}

            //Console.WriteLine($"Samoglasnik se pojavljuje {brojac} puta");

            //// Korisnik unosi određeni tekst, poveriti koliko se puta pojavilo slovo „i“, ukoliko se pojavilo više od 2 puta ispisati odgovarajuću poruku, u suprotnom izaći iz programa.

            //string tekst2;
            //Console.WriteLine("Unesite neki tekst za brojanje samoglasnika I:");
            //tekst2 = Console.ReadLine();
            //int brojac2 = 0;

            //foreach (var slovoi in tekst2)
            //{
            //    if (slovoi == 'i' || slovoi == 'I')
            //    {
            //        brojac2++;
            //    }
            //}

            //if (brojac2 > 2)
            //{
            //    Console.WriteLine($"Slovo i je upisano {brojac2} puta");
            //} else
            //{
            //    System.Environment.Exit(0);
            //}

            //// Korisnik unosi određeni tekst, poveriti koliko se puta pojavilo slovo „a“ u tekstu. Ispisti poruku sa informcijom koliko se puta pojavilo slovo „a“.

            //string tekst3;
            //Console.WriteLine("Unesi tekst za brojanje samoglasnika A:");
            //tekst3 = Console.ReadLine();
            //int brojac3 = 0;

            //foreach (var slovo in tekst3)
            //{
            //    if (slovo == 'a' || slovo == 'A')
            //    {
            //        brojac3++;
            //    }
            //}

            //Console.WriteLine($"Slovo a pojavljuje se " + brojac3 + " puta");

            //// Unose se dva broja, ispisuju se četiri matematičke operacije. U zavisnosti od izabrane izračunava se rezultat.

            //// Napisati program koji broj samoglasnika u reči/rečenici. Ukoliko je reč/rečenica prazna, ispisati poruku „Unet je prazan string“, ukoliko su uneti samo razmaci, brojevi ili specijalni karakteri ispisati „Brojevi, razmaci ili karatkeri“, a na kraju ispisati poruku „Uspešno računanje“.

            string tekst4;
            Console.WriteLine("Unesite neki tekst za brojanje samoglasnika i mogucu gresku:");
            tekst4 = Console.ReadLine();
            int brojac4 = 0;

            foreach (var samoglasnik2 in tekst4)
            {
                if (samoglasnik2 == 'a' || samoglasnik2 == 'A' || samoglasnik2 == 'e' || samoglasnik2 == 'E' || samoglasnik2 == 'i' || samoglasnik2 == 'I' || samoglasnik2 == 'o' || samoglasnik2 == 'O' || samoglasnik2 == 'u' || samoglasnik2 == 'U')
                {
                    brojac4++;
                }
                if (string.IsNullOrEmpty(tekst4))
                {
                    Console.WriteLine("Unet je prazan string");
                } 
            }

            // Napraviti aplikaciju koja deli dva broja. U slučaju da korisnik pogrešno unese vrednosti, ispisati adekvatnu poruku i ponovo ga naterati da unosi vrednosti. Program se izvršava sve dok korisnik ne unese ispravne vrednosti.
            
        }
    }
}
