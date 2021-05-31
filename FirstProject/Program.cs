using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // VEZBA 1
            // 1. Ispišite ime i prezime u dva reda.
            // 2. Ispiši svoje ime i prezime u dva reda koristeći samo jednu naredbu WRITE.
            // 3. Ispisati ime i prezime pa odvojiti jedan tab pa ispisati broj indeksa.
            // 4. Ispisati tri imena u dve kolone:
            // a. Sa dve naredbe WriteLine.
            // b. Sa jednom naredbomWrite.

            Console.WriteLine("Milovan");
            Console.WriteLine("Srdanovic");
            Console.WriteLine("Milovan\nSrdanovic");
            Console.WriteLine("Milovan Srdanovic\t2i1/0107/20");
            Console.WriteLine("Kirk\tSpock\tUhura");
            Console.WriteLine("McCoy\tSulu\tChekov");
            Console.WriteLine("Picard\tData\tLaForge\nRo\tRiker\tTroy");

            // VEZBA 2

            // 1. Tražiti od korisnika da unese ime i prezime, pol i koliko ima godina. Ispisati unešene vrednosti u dva reda.
            // 2. Napraviti program koji pamti ime i prezime u dve promenljive, pa ih posle ispisuje na ekran.
            // 3. Napisati program koji pamti broj u promenljivu, pa ga ispisuje na ekran.
            // 4. Napisati program koji traži od korisnika da unese dva broja i ispisuje rezultat oduzimanja ta dva broja.
            // 5. Napisati program koji traži od korisnika da unese dva broja (decimal) i ispisuje rezultat deljenja ta dva broja.
            // 6. Napisati program koji traži od korisnika da unese tri broja i ispisuje rezultat tako što sabere prva dva i pomnoži sa trećim.
            // 7. Napisati program koji traži od korisnika da unese dva broja, program treba da odradi sve osnovne operacije(+,-,*,/),
            // a rezultat svake operacije se ispisuje u novi red.

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
            
            // VEZBA 3 PETLjA IF

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
            
            // VEZBA 4 PETLjE WHILE I DO WHILE
            
            // Zadatak 1 Unosi se lozinka, sve dok se ne unese ispravna lozinka program se ne prekida.

            string lozinka = "password";

            do
            {
                Console.WriteLine("Unesite lozinku:");
                lozinka = Console.ReadLine();
            }
            while (lozinka != "password"); //Uslov
            Console.WriteLine("Tacno!");

            // Zadatak 2 Generišu se dva broja, sve dok je a veće od b ispisuju se ti brojevi (u jednoj liniji i između njih se ispisuje zarez).
            // U slučaju da je b veći izlazi se iz programa.
            
            Random rnd = new Random();
            int a, b;

            do
            {
                a = rnd.Next(1, 100);
                b = rnd.Next(1, 100);
                Console.WriteLine(a + ", " + b);
            }
            while (a > b);
            Console.WriteLine($"{b} je vece od {a}");

            // ili

            int broj1, broj2;
            Random rnd = new Random();

            broj1 = rnd.Next(1, 10);
            broj2 = rnd.Next(1, 10);

            while (broj1 > broj2)
            {
                Console.WriteLine($"Generisani su brojevi " + broj1 + " i broj " + broj2);
                broj1 = rnd.Next(1, 10);
                broj2 = rnd.Next(1, 10);
            }

            // Zadatak 3 Unosi se broj sve dok se ne unese 0. Ispisati zbir tih brojeva.

            int broj, zbir = 0;
            do
            {
                Console.WriteLine("Unesite broj:");
                broj = int.Parse(Console.ReadLine());
                zbir = zbir + broj;
            } while (broj != 0);
            Console.WriteLine($"Zbir je {zbir}");

            // Zadatak 4 Generišu se slučajni brojevi od 10-60 sve dok se ne dobije broj deljiv sa 5.
            // Taj broj treba prikazati na ekranu. Prikazati broj pokušaja i srednju vrednost.
            
            int broj, brojac = 0, suma = 0, srednja = 0;
            Random rnd = new Random();

            do
            {
                broj = rnd.Next(10, 60);
                Console.WriteLine($"Nasumicno dobijeni broj je {broj}");
                brojac++;
                suma += broj;
                srednja = suma / brojac;
            } while (broj % 5 != 0);

            Console.WriteLine("Broj " + broj + " je deljiv sa 5. Dobijen je iz " + brojac + " pokusaja. Srednja vrednost dobijenih brojeva je " + srednja);

            // Zadatak 5 Unosi se broj sve dok je u intervalu od 10-30. Izračunati sumu parnih i broj neparnih brojeva.

            int broj, suma = 0, brojac = 0;

            do
            {
                Console.WriteLine("Unesite broj izmedju 10 i 30:");
                broj = int.Parse(Console.ReadLine());
                if (broj >= 10 && broj <= 30 && broj % 2 == 0)
                {
                    suma += broj;
                }
                else if (broj >= 10 && broj <= 30 && broj % 2 != 0)
                {
                    brojac++;
                } else
                {
                    Console.WriteLine("Uneseni broj nije u rasponu od 10 do 30");
                }
            } while (broj >= 10 && broj <= 30);
            Console.WriteLine($"Pre broja van raspona, zbir parnih brojeva je {suma}, a broj neparnih je {brojac}");

            // Zadatak 6 Generišu se dva broja u intervalu od 1-100. Ako je drugi broj veći od prvog,
            // prvi broj se uvećava dva puta sve dok ne bude veći od drugog. Ispisati koliko je prvi broj puta morao da se uveća.

            Random rnd = new Random();
            int broj1, broj2, brojac = 0;

            broj1 = rnd.Next(1, 100);
            broj2 = rnd.Next(1, 100);
            Console.WriteLine($"Prvi broj je {broj1}, a drugi je {broj2}");

            while (broj2 > broj1)
            {
                broj1 *= 2;
                Console.WriteLine($"Prvi broj je sada uvecan dva puta i iznosi {broj1}, drugi je jos uvek {broj2}");
                brojac++;
            }
            Console.WriteLine($"Prvi broj je morao da se uveca {brojac} puta da bi bio veci od drugog");

            // Zadatak 7 Unose se brojevi sve dok je zbir svakog trećeg broja manji od 30. Nakon toga ispisati koliko brojeva je uneto i njihov zbir.
            
                        int a, b, c, zbir = 0, brojac = 0, suma = 0;
            do
            {
                Console.WriteLine("Unesite broj:");
                a = int.Parse(Console.ReadLine());
                brojac++;
                Console.WriteLine("Unesite broj:");
                b = int.Parse(Console.ReadLine());
                brojac++;
                Console.WriteLine("Unesite broj:");
                c = int.Parse(Console.ReadLine());
                brojac++;
                zbir = zbir + c;
                suma = suma + a + b + c;
            } while (zbir < 30);
            Console.WriteLine($"Kolicina unetih brojeva je {brojac}, a zbir svih unetih brojeva je {suma}");

            // Zadatak 8 Unosi se broj od 1-20. Nakon toga se generišu brojevi od 1 - 20 sve dok generisani broj ne bude jednak unetom broju,
            // ili broj pokušaja ne bude manji od 20.
            
            int broj1, broj2, brojac = 0;
            Console.WriteLine("Unesite brojod 1 do 20:");
            broj1 = int.Parse(Console.ReadLine());

            do
            {
                Random rnd = new Random();
                broj2 = rnd.Next(1, 20);
                Console.WriteLine($"Nasumicno izabran broj je {broj2}");
                brojac++;
            } while (broj1 != broj2 && brojac < 20);

            if (brojac < 20)
            {
                Console.WriteLine($"Nadjeni su isti brojevi iz {brojac} pokusaja");
            }
            else
            {
                Console.WriteLine($"Nisu nadjeni isti brojevi za manje od 20 pokusaja");
            }

            // Zadatak 9 Unose se ekstenzije (xlsx, docx, xml, cs, txt) za svaki unos ispisuje se naziv programa koji pokreće taj fajl.
            // Sve dok se ne unese exit program nastavlja da se izvršava.
            
            string ekstenzija;
            Console.WriteLine("Unesite ekstenziju fajla (xlsx, docx, xml, cs, txt):");
            ekstenzija = Console.ReadLine();
            if (ekstenzija == "xlsx")
            {
                Console.WriteLine("Ovaj fajl otvara Microsoft Excel");
            }
            else if (ekstenzija == "docx")
            {
                Console.WriteLine("Ovaj fajl otvara Microsoft Word");
            }
            else if (ekstenzija == "xml")
            {
                Console.WriteLine("Ovaj fajl otvara internet pregledac");
            }
            else if (ekstenzija == "cs")
            {
                Console.WriteLine("Ovaj fajl otvara internet Visual Studio");
            }
            else if (ekstenzija == "txt")
            {
                Console.WriteLine("Ovaj fajl otvara Notepad");
            }
            else
            {
                Console.WriteLine("Unesite validnu ekstenziju");
            }

            while (ekstenzija != "exit")
            {
                Console.WriteLine("Unesite ekstenziju fajla (xlsx, docx, xml, cs, txt). Za izlazak ukucajte exit.");
                ekstenzija = Console.ReadLine();
                if (ekstenzija == "xlsx")
                {
                    Console.WriteLine("Ovaj fajl otvara Microsoft Excel");
                }
                else if (ekstenzija == "docx")
                {
                    Console.WriteLine("Ovaj fajl otvara Microsoft Word");
                }
                else if (ekstenzija == "xml")
                {
                    Console.WriteLine("Ovaj fajl otvara internet pregledac");
                }
                else if (ekstenzija == "cs")
                {
                    Console.WriteLine("Ovaj fajl otvara internet Visual Studio");
                }
                else if (ekstenzija == "txt")
                {
                    Console.WriteLine("Ovaj fajl otvara Notepad");
                } else
                {
                    Console.WriteLine("Unesite validnu ekstenziju");
                }
            }

            // Zadatak 10 Unose se brojevi sve dok se ne unese dva puta broj deljiv sa 5.
            // Svaki put kada se unese broj deljiv sa 3 resetuje se brojač petica. Ispisati srednju vrednost parnih brojeva.
            
            
            
            // DODATNI ZADACI 1

            // 1. Napravite program koji traži od korisnika da unese ime, prezime, godinu studija i smer.
            // Ako je  korisnik uneo  smer Informatika, treba  postaviti pitanje:  “Da li  učiš redovno programiranje”,
            // ako je odogovor „Da“, program ispisuje poruku: “Samo tako nastavi!”, ako je odgovor „Ne“ program ispisuje poruku: “Počni da učiš!”. 

            string ime, prezime, smer;
            int godinaStudija;

            Console.WriteLine("Unesite Vase ime:");
            ime = Console.ReadLine();
            Console.WriteLine("Unesite Vase prezime:");
            prezime = Console.ReadLine();
            Console.WriteLine("Unesite godinu studija:");
            godinaStudija = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite smer:");
            smer = Console.ReadLine();

            if (smer == "Informatika" || smer == "informatika")
            {
                string odgovor;
                Console.WriteLine("Da li  učiš redovno programiranje?");
                odgovor = Console.ReadLine();
                if (odgovor == "Da" || odgovor == "da")
                {
                    Console.WriteLine("Samo tako nastavi!");
                } else if (odgovor == "Ne" || odgovor == "ne")
                {
                    Console.WriteLine("Počni da učiš!");
                } else
                {
                    Console.WriteLine("Ne izbegavaj odgovor :)");
                }
            }

            // 2. Generiše se n brojeva u intervalu(1 - 100), ispisati samo parne brojeve.
            
            
            
            
            // VEZBA 5 Petlja FOR

            // 1. Za n unetih brojeva izračunati sumu parnih i broj neparnih brojeva.

            int n, a, suma = 0, brojNpb = 0;

            Console.WriteLine("Unesi broj n (koliko brojeva da se unese):");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Unesite broj: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0)
                {
                    brojNpb++;
                } else
                {
                    suma += a;
                }
            }

            Console.WriteLine($"Za {n} unetih brojeva, broj neparnih bio je {brojNpb}, a suma parnih je {suma}.");

            // 2. Za n unetih brojeva izračunati srednju vrednost tih brojeva.
            
            int n, a, srednja = 0, suma = 0;

            Console.WriteLine("Unesi broj n (koliko brojeva da se unese):");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Unesite broj: ");
                a = int.Parse(Console.ReadLine());
                suma += a;
                srednja = suma / n;
            }

            Console.WriteLine($"Za {n} unetih brojeva, njihova srednja vrednost je {srednja}.");
            
            // 3. Treba ispisati n generisanih brojeva od 10 do 100. Ako je broj paran i između 20 i 40 ne treba da se ispisuje,
            // a ako je broj neparan između 70 i 90 prekinuti generisanje brojeva.
            
            
            
            
            // 4. Policajac meri brzinu u naseljenom mestu. Potrebno je napraviti program u koji će policajac
            // uneti izmerenu brzinu, a program će ispisati:
            // a. za brzinu manju ili jednaku 60 -nema kazne;
            // b. za brzinu do 70 -1000 dinara kazne;
            // c. za brzinu do 80 -2000 dinara kazne;
            // d. brzinu do 90 -3000 dinara kazne;
            // e.preko 90 -oduzimanje dozvole;
            
            
            
            
            // 5. Uraditi program pod 4) tako da se izvrši provera za 10 kola.
            
            for (int i = 0; i < 10; i++)
            {
                int brzina;
                Console.WriteLine("Unesite izmerenu brzinu:");
                brzina = int.Parse(Console.ReadLine());
                if (brzina <= 60)
                {
                    Console.WriteLine("Bez kazne. Samo tako nastavite!");
                }
                else if (brzina > 60 && brzina <= 70)
                {
                    Console.WriteLine("1000 dinara kazne!");
                }
                else if (brzina > 70 && brzina <= 80)
                {
                    Console.WriteLine("2000 dinara kazne!");
                }
                else if (brzina > 80 && brzina <= 90)
                {
                    Console.WriteLine("3000 dinara kazne!");
                }
                else
                {
                    Console.WriteLine("Oduzimanje dozvole!");
                }
            }
            Console.WriteLine("Izvrsena je provera 10 automobila");
            
            // 6. Uraditi program pod 4) tako da se izvršava provera sve dok policajac ne kazni 5 vozača.
            
            for (int i = 0; i < 5;)
            {
                int brzina;
                Console.WriteLine("Unesite izmerenu brzinu:");
                brzina = int.Parse(Console.ReadLine());
                if (brzina <= 60)
                {
                    Console.WriteLine("Bez kazne. Samo tako nastavite!");
                }
                else if (brzina > 60 && brzina <= 70)
                {
                    Console.WriteLine("1000 dinara kazne!");
                    i++;
                }
                else if (brzina > 70 && brzina <= 80)
                {
                    Console.WriteLine("2000 dinara kazne!");
                    i++;
                }
                else if (brzina > 80 && brzina <= 90)
                {
                    Console.WriteLine("3000 dinara kazne!");
                    i++;
                }
                else
                {
                    Console.WriteLine("Oduzimanje dozvole!");
                    i++;
                }
            }
            Console.WriteLine("Kaznjeno je 5 vozaca");
            
            // 7. Prikaži srednji broj od tri cela broja a, b i c.
            
            decimal a, b, c;
            decimal srednji = 0;

            Console.WriteLine("Unesite prvi broj:");
            a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj:");
            c = decimal.Parse(Console.ReadLine());
            srednji = (a + b + c) / 3;
            Console.WriteLine($"Prosek je {srednji}");
            
            
            
            
            
            // VEZBA 6 Petlje SWITCH CASE, TRY - CATCH - FINAL i FOREACH
            
            int a = 7, b = 3, max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            max = (a > b) ? a : b;

            // 1. Unose se dva broja, ispisuju se četiri matematičke operacije:
            // a. sabiranje
            // b. oduzimanje
            // c. množenje
            // d. deljenje.
            // U zavisnosti od izabrane izračunava se rezultat.

            int broj1, broj2;
            Console.WriteLine("Unesite prvi broj:");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            broj2 = int.Parse(Console.ReadLine());

            char operacija;
            Console.WriteLine("Izaberite jednu od matematickih operacija:");
            Console.WriteLine("a. sabiranje, b. oduzimanje, c. množenje, d. deljenje");
            operacija = char.Parse(Console.ReadLine());

            switch (operacija)
            {
                case 'a':
                    Console.WriteLine($"Rezultat sabiranja je {broj1 + broj2}");
                    break;
                case 'b':
                    Console.WriteLine($"Rezultat oduzimanja je {broj1 - broj2}");
                    break;
                case 'c':
                    Console.WriteLine($"Rezultat mnozenja je {broj1 * broj2}");
                    break;
                case 'd':
                    Console.WriteLine($"Rezultat deljenja je {broj1 / broj2}");
                    break;
                default: Console.WriteLine("Izaberite validnu opciju");
                    break;
            }

            // 2. Napraviti program koji na osnovu unetog broja (1 - 7) ispisuje dan u nedelji.

            int broj3;
            Console.WriteLine("Unesi broj dana:");
            broj3 = int.Parse(Console.ReadLine());

            try
            {
                switch (broj3)
                {
                    case 1:
                        Console.WriteLine("Ponedeljak");
                        break;
                    case 2:
                        Console.WriteLine("Utorak");
                        break;
                    case 3:
                        Console.WriteLine("Sreda");
                        break;
                    case 4:
                        Console.WriteLine("Cetvrtak");
                        break;
                    case 5:
                        Console.WriteLine("Petak");
                        break;
                    case 6:
                        Console.WriteLine("Subota");
                        break;
                    case 7:
                        Console.WriteLine("Nedelja");
                        break;
                    default:
                        Console.WriteLine("Nema dana sa tim brojem");
                        break;
                }

            }
            catch (Exception greska)
            {
                Console.WriteLine($"Doslo je do greske {greska.Message}");
            }

            // 3. Napraviti  program koji  ispisuje uspeh  na osnovu  dobijene ocene.  Nedeovoljan - 1, Dovoljan - 2, Dobar –3, Vrlo dobar –4 i Odličan –5.

            int ocena;
            Console.WriteLine("Unesi ocenu:");
            ocena = int.Parse(Console.ReadLine());

            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                default:
                    Console.WriteLine("Unesite validnu ocenu");
                    break;
            }

            // 4. Napisati program za ispis broja dana u mesecu na osnovu sledećih uslova:
            // a. 1, 3, 5, 7, 8, 10, 12 – ispisuje se poruka „Mesec ima 31 dan“
            // b. 4, 6, 9, 11 – ispisuje se poruka „Mesec ima 30 dana“
            // c. 2 – ispisuje se poruka „Prestupna godina, mesec ima 29 dana“
            // d. – ispisuje se poruka “Nije prestupna godina, mesec ima 28 dana“
            
            int mesec, godina;
            Console.WriteLine("Unesi mesec:");
            mesec = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi godinu:");
            godina = int.Parse(Console.ReadLine());

            switch (mesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Mesec ima 31 dan");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Mesec ima 30 dana");
                    break;
                case 2:
                    if (godina % 4 != 0)
                    {
                        Console.WriteLine("Mesec ima 28 dana");
                    }
                    else
                    {
                        Console.WriteLine("Prestupna godina, mesec ima 29 dana");
                    }
                    break;
                default:
                    Console.WriteLine("Unesite validan broj meseca");
                    break;
            }

            // 5. Napisati program koji za upisani samoglasnik uvećava brojač odgovarajućeg samoglasnika.

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
            
            // VEZBA 7
            
            // 1. Unesi 10 brojeva u niz, ispisati samo parne brojeve iz niza.

            int[] niz = new int[10];
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesi clanove niza:");
                niz[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Parni clanovi niza su: ");
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0) // gleda se vrednost;
                {
                    Console.Write($"{niz[i]} ");
                }
            }

            // 2. Generiše se niz od 10 brojeva. Ispisati svaki drugi broj.

            int[] niz = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 20);
                Console.Write($"{niz[i]} ");
            }

            Console.WriteLine("su nasumicno izabrani brojevi. Svaki drugi je:");

            for (int i = 0; i < niz.Length; i++)
            {
                if (i % 2 != 0) // gleda se vrednost;
                {
                    Console.Write($"{niz[i]} ");
                }
            }

            // 3. Za n unetih brojeva u niz izračunati sumu parnih i broj neparnih brojeva.

            int[] niz;
            int n, sumaParnih = 0, brojNeparnih = 0;
            Console.WriteLine("Unesite broj elemenata niza:");
            n = int.Parse(Console.ReadLine());
            niz = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 20);
                Console.Write($"{niz[i]} ");
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    sumaParnih += niz[i];
                } else
                {
                    brojNeparnih++;
                }
            }

            Console.WriteLine($"Suma parnih brojeva je {sumaParnih}, a broj neparnih je {brojNeparnih}");

            // 4. Za n unetih brojeva u niz ispisati samo brojeve deljive sa 5 i izračunati srednju vrednost tih brojeva.

            int[] niz;
            int n, deljivi = 0, srednja = 0, suma = 0;
            Console.WriteLine("Unesite broj elemenata niza:");
            n = int.Parse(Console.ReadLine());
            niz = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 100);
                Console.Write($"{niz[i]} ");
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 5 == 0)
                {
                    deljivi++;
                    suma += niz[i];
                    srednja = suma / deljivi;
                }
            }

            // 5. Generisati niz od 7 brojeva i sortirati brojeve od najmanjeg ka najvećem.

            // Dva fora (jedna i, u njoj j), pa u njoj (if niz[i] >= niz[j]) i sort, i, j = i + 1



            // 6. Unesi 10 imena u niz, ispisati samo imena koja imaju 5 ili više karaktera.

            string[] niz = new string[10];
            Console.WriteLine("Unetih 10 imena su:");
            niz[0] = "Milovan";
            niz[1] = "Natasa";
            niz[2] = "Leo";
            niz[3] = "Lora";
            niz[4] = "Dajana";
            niz[5] = "Nina";
            niz[6] = "Darko";
            niz[7] = "Marko";
            niz[8] = "Marija";
            niz[9] = "Luna";

            foreach (var ime in niz)
            {
                Console.Write($"{ime} ");
            }

            Console.WriteLine();
            Console.WriteLine("Imena sa 5 ili vise karaktera su:");
            foreach (var ime in niz) {
            if (ime.Length >= 5)
            {
                Console.Write($"{ime} ");
            }
            }

            // 7. Niz X[10] čine slučajni brojevi od 1 do 30. Ispisati samo neparne brojeve veće od 15.

            int[] x = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Nasumicno izabrani brojevi od 1 do 30 su:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 30);
                Console.Write($"{x[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Neparni brojevi veci od ili jednaki 15 su:");

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 15 && x[i] % 2 != 0)
            {
                Console.Write($"{x[i]} ");
            }
            }

            // 8. U Niz X[20] unose se slučajni brojevi od 1 - 30 u niz Y upisati samo neparne brojeve. Ispisati niz Y.

            int[] x = new int[20];
            int[] y = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Nasumicno izabrani brojevi niza X od 1 do 30 su:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 30);
                Console.Write($"{x[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Nizu Y pripadaju brojevi:");
            
            

            // 9. Niz X[20] čine slučajni brojevi od 1 - 15, a niz Y čine samo elementi koji se pojave u nizu X dva ili više puta.

            int[] x = new int[20];
            int[] y = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Nasumicno izabrani brojevi niza X od 1 do 15 su:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 15);
                Console.Write($"{x[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Brojevi niza koji se pojavljuju 2 ili vise puta su:");

            for (int i = 0; i < y.Length; i++)
            {
                if (x[i] > 4)       // This line to be fixed
                {
                    y[i] = x[i];
                    Console.Write($"{y[i]} ");
                }
            }

            // 10. Niz X[20] čine slučajni brojevi od 1 - 30. Iz niza X brojeve sa parnim indeksima upisati u niz Y,
            // a brojeve sa neparnim indeksima upisati u niz Z. Ispisati niz X I Z u dva reda.
            
            int[] x = new int[20];
            int[] y = new int[20];
            int[] z = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Nasumicno izabrani brojevi niza X od 1 do 30 su:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 30);
                Console.Write($"{x[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Nizu Y pripadaju brojevi:");

            for (int i = 0; i < y.Length; i++)
            {
                if (i % 2 != 0)
                {
                    y[i] = x[i];
                    Console.Write($"{y[i]} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Nizu Z pripadaju brojevi:");

            for (int i = 0; i < z.Length; i++)
            {
                if (i % 2 == 0)
                {
                    z[i] = x[i];
                    Console.Write($"{z[i]} ");
                }
            }
            
            // VEZBA 8
            
            // i je red, j je kolona

            // 1.Koriscenjem dvodimenzionalnog niza (matrice) napraviti aplikaciju koja ispisuje brojeve kao u tabeli ispod teksta.

            int[,] matrica = new int[5, 5];
            int brojac = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrica[i, j] = brojac;
                    brojac++;
                    Console.Write($"{matrica[i, j]}\t");
                }
                Console.WriteLine();
            }

            // 2. Napravite aplikaciju za prikaz matrice kao što je prikazano na slici. Dijagonala
            // matrice ispunjava se sa nulama. Donja strana se ispunjava sa negativnim
            // jedinicama, a gornja strana se ispunjava sa jedinicama.

            int[,] matrica = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        matrica[i, j] = 0;
                    }
                    else if (i > j)
                    {
                        matrica[i, j] = -1;
                    }
                    else
                    {
                        matrica[i, j] = 1;
                    }
                    Console.Write($"{matrica[i, j]}\t");
                }
                Console.WriteLine();
            }

            // 3. Koriscenjem dvodimenzionalnog niza (matrice) napraviti aplikaciju koja ispisuje brojeve kao u tabeli ispod teksta.

            int[,] matrica = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                int brojac = i + 1;
                for (int j = 0; j < 5; j++)
                {
                    matrica[i, j] = brojac;
                    brojac += 2;
                }
                brojac = 0;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrica[i, j]}\t");
                }
                Console.WriteLine();
            }

            // 4. Koriscenjem dvodimenzionalnu niza(matrice) napraviti aplikaciju za prikaz tabele
            // koji predstavlja Paskalov trougao bilo koje velicine. U Paskalovom trouglu, prvi i
            // drugi red su postavljeni na 1. Svaki element trougla (od treceg reda pa nadole) je
            // zbir elementa direktno iznad njega i elementa levo od elementa direktno iznad
            // njega. Pogledajte primer Paskalovog trougla (velicina = 5) ispod.
            
            // VEZBA 9
            
            // 1. Napisati funkciju koja ispisuje neki tekst. U glavnom programu pozvati tu funkciju.
            
            // Echo je funkcija napravljena umesto Console.WriteLine

            Echo($"Prva funkcija");
            Echo($"Druga funkcija");
            Echo($"Treca funkcija");
            
            // 2. Napisati funkciju za računanje zbira dva broja. U glavnom programu pozvati tu funkciju.

            int a;
            int b;
            Echo("Napisite prvi broj:");
            a = int.Parse(Console.ReadLine());
            Echo("Napisite drugi broj:");
            b = int.Parse(Console.ReadLine());
            int zbir;
            zbir = Sabiranje(a, b);
            Echo($"Zbir je {zbir}");
            
            // 3. Napisati funkciju koja broji koliko puta se pojavilo slovo a u nekoj reči ili rečenici. U
            // glavnom programu pozvati tu funkciju.
            
            string tekst;
            Echo("Upisite neki tekst:");
            tekst = Console.ReadLine();

            int slovoA;
            slovoA = SlovoA(tekst);
            Console.WriteLine($"Slovo A se pojavljuje {slovoA} puta");

            // 4. Napisati funkciju koja vraća max broj u nizu. U glavnom programu ispisati taj broj.
            
            int[] niz = new int[10];
            Random rnd = new Random();
            Console.WriteLine($"Nasumicni niz je:");
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 30);
                Console.Write($"{niz[i]} ");
            }
            
            // 5. Napisati funkciju koja ispisuje parne brojeve niza. U glavnom programu pozvati tu funkciju.

            int[] niz = new int[10];
            Random rnd = new Random();
            Console.WriteLine($"Nasumicni niz je:");
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rnd.Next(1, 30);
                Console.Write($"{niz[i]} ");
            }
            
            
            
            
            
            // VEZBA 10 Fajlovi i Folderi
            
            // 1. Na D particiji kreirati fajl sa vašim imenom i prezimenom sa txt ekstenzijom npr. PeraPeric.txt

            string putanja = @"d:\temp\MilovanSrdanovic.txt";
            //File.CreateText(putanja);

            // 2. U kreiranom fajlu ubaciti tri reda teksta i to: broj indeksa, datum rođenja, godina studija (slovima)

            //if (File.Exists(putanja))
            //{
            //    using (StreamWriter sw = File.AppendText(putanja))
            //    {
            //        sw.WriteLine("2i1/0107/20");
            //        sw.WriteLine("21.05.1988.");
            //        sw.WriteLine("Prva godina studija");
            //    }
            //}

            // 3. Na D particiji kreirati folder Vezba10, u njega iskopirati kreirani fajl. Preimenujte fajl u vaše inicijale npr. PP.txt
            // i dodati još dva reda u njemu teksta visina i tezina i iščitajte fajl.

            string putanjaFolder = @"d:\Vezba10\";
            //Directory.CreateDirectory(putanjaFolder);

            string putanjaFajl = @"d:\Vezba10\MS.txt";
            //File.Copy(putanja, putanjaFajl);

            //if (File.Exists(putanjaFajl))
            //{
            //    using (StreamWriter sw = File.AppendText(putanjaFajl))
            //    {
            //        sw.WriteLine("Visina 190cm");
            //        sw.WriteLine("Tezina 78kg");
            //    }
            //}

            //using (StreamReader sr = File.OpenText(putanjaFajl))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            // 4. Napravite fajlove u folderu Vezba10 fajl1.txt, fajl3.txt, fajl5.txt, fajl7.txt, fajl9.txt, fajl11.txt
            // i fajl13.txt, potom preimenujte folder u 10Vezba i izlistajte sve fajlove koji su u njemu.

            //int broj = 1;
            //for (int i = 0; i < 7; i++)
            //{
            //    string fajl1 = @"d:\Vezba10\fajl" + broj + ".txt";
            //    broj += 2;
            //}

            //string[] fajlovi = System.IO.Directory.GetFiles(putanjaFolder);
            //foreach (string s in fajlovi)
            //{
            //    Console.WriteLine(s);
            //}

            // 5. Napraviti folder Zatatak5 na D particiji u njemu napraviti 10 txt fajlova sa različitom dužinom naziva.
            // Napraviti metodu kojom ćete u fajlovima sa parnom dužinom naziva ispisati 5 nasumična broja između 1 i 100,
            // a u fajlovima sa neparnom dužinom naziva ispisati 6 nasumična broja između 100 i 200. Izlistati fajlove sa podacima ispod svakog fajla.

            string zadatak5 = @"d:\Zadatak5\";
            Directory.CreateDirectory(zadatak5);
            
            
            
            
            
            
            
            
            
            
            
        }
        
        // Functions:
        
        static void Echo(string tekst)
        {
            Console.WriteLine($"{tekst}");
        }
        
        static int Sabiranje(int a, int b)
        {
            int zbir;
            zbir = a + b;
            return zbir;
        }
        
        static int SlovoA(string tekst)
        {
            int brojac = 0;
            foreach (var slovo in tekst)
            {
                if (slovo == 'a')
                {
                    brojac++;
                }
            }
            return brojac;
        }
        
        static int Parni(int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    
                }
            }
        }
        
        
        
        
        
        
        
        
    }
}
