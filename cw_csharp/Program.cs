using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace cw_csharp
{
    /*
       class Zad2
       {
           static void Main(string[] args)
           {
               //zadanie 2.1.
               Console.Write("Podaj temp w [C]: ");
               int a = Convert.ToInt32(Console.ReadLine());
               double d, e;
               d = 9;
               e = 5;
               double c = Math.Round(d / e, 1);
               double b = a * c + 32;
               Console.WriteLine("{0} w [C] to: {1} F", a, b);
               Console.WriteLine("{0} w [C] to: {1} F", a, ConvertTemp.ConvertCelsiusToFahrenheit(a));

               Console.ReadKey();
           }
       }
       static class ConvertTemp
       {
           public static double ConvertCelsiusToFahrenheit(double c)
           {
               return ((9.0 / 5.0) * c) + 32;
           }
       }
   */
    class Zad22
    {
        
        static void Main(string[] args)
        {
        etykieta1:
            /*
            //Zadanie2.2.
            int a = Convert.ToInt32(Console.ReadLine());  //wspolczynniki rownania
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = (int)Math.Pow(b,2) - (4 * a * c);
            Console.Write("Delta:{0}", d);


            //Zadanie 2.3.
            int a = Convert.ToInt32(Console.ReadLine()); //waga                 aby bylo ok to metoda tak jak w 2.1 do cwiczenia
            int b = Convert.ToInt32(Console.ReadLine()); //wzrost
            int c = a / (int)Math.Pow(b, 2);
            Console.Write("BMI:{0}", c);

            //Zadanie 2.4. / 2.5.        
            int x = 2, y = 3;
            x *= y + 2;                               //najpierw to co po prawej str wykona sie potem przypisanie
            Console.Write(x);
            int x, y = 4;
            x = (y -= 2);
            x = y++;                                // wynik 3
            x = y--;                                // liczy sie ostatnie przypisanie nie patrzy na obliczenia powyzej
            Console.Write(x);

            int x, y = 5;
            x = ++y * 2;                            // wynik 7
            x = y++;                                // zapis y++ dziala na wartosc nawet przy przypisywaniu do innej wartosci
            x = y--;
            Console.WriteLine(++y);

            
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);               // x: True  y:1  z:2
            Console.WriteLine(x);                   // na z zmiana dopiero po przypisaniu wartosci dla x dlatego x true
            Console.WriteLine(y);
            Console.WriteLine(z);


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Zadanie3.1.

            Console.Write("Podaj rok: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%4==0 && a%100!=0)
            {
                Console.WriteLine("Przestepny");                                        //warunek w sprawdzeniu nie moze sie wykluczac z nowym sprwadzeniem
            }
            else if (a % 4 == 0 && a % 400 == 0) Console.WriteLine("Przestepny"); 
            else Console.WriteLine("Nieprzestepny");


            //Zadanie3.2.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0) Console.WriteLine("Blad");
            else if (a%b==0) Console.WriteLine("{0} jest dzielnikiem {1}",b,a);             // a% b to jest ze reszta z dzielenia przez B 
            else Console.WriteLine("{0} nie jest dzielnikiem {1}", b, a);
            Console.WriteLine("Wynik: {0}", (double)a / b);

            //Zadanie3.3.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c) Console.WriteLine("{0} jest najawieksze", a);
            else if (b > a && b > c) Console.WriteLine("{0} jest najawieksze", b);
            else if (c > a && c > b) Console.WriteLine("{0} jest najawieksze", c);
            else Console.WriteLine("Cos jest rowne");


            //Zadanie3.4.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            if (c == "+") Console.WriteLine("{0} {1} {2} = {3}", a, c, b, a + b);


            //Zadanie3.7
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            if (Math.Pow(b, 2) - (4 * a * c) == 0)
            {
                Console.WriteLine("1 pierwiastek");
                Console.WriteLine("{0}", Math.Round(((-b)/ 2 * a),2));
            }
            if (Math.Pow(b, 2) - (4 * a * c) > 0)
            {
                Console.WriteLine("2 pierwiasteki");
                Console.WriteLine("{0} \t {1}", Math.Round(((-b - d) / 2 * a),2), Math.Round(((-b + d) / 2 * a),2));           
            }
            if (Math.Pow(b, 2) - (4 * a * c) < 0) Console.WriteLine("0 pierwiastow");


            Console.WriteLine("Podaj nr dnia tyg (1-7): ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Pon");
                    break;
                case 2:
                    Console.WriteLine("Wt");
                    break;
                default: Console.WriteLine("Nie ma");
                    break;
            }

            //Zadanie3.8
            double a = double.Parse(Console.ReadLine());
            if (a >= 2.0 && a <= 3.99) Console.WriteLine("Stypendium: 0 zl");
            if (a >= 4.0 && a <= 4.99) Console.WriteLine("Stypendium: 110 zl");


            //Zadanie3.9.
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<a; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("****");
                    continue;
                }
                if (i == a-1)
                {
                    Console.WriteLine("****");
                    continue;
                }
             Console.Write("{0,-2}{1,2}", "*", "*");
             Console.WriteLine("\n");
            }


            //Zadanie3.10
            int a = Convert.ToInt32(Console.ReadLine());
            int x=1;
            for (int i = 1; i <= a; i++)
            {
                x *= i;
            }
            Console.WriteLine(x);

            //Zadanie3.11
            int x = 0;
            for(int i=1; ; i++)                         // ile liczb trzeba dodac by suma byla wieksza od 100
            {
                x += i;
                if (x > 100)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.WriteLine(x);

            //Zadanie3.12.
            int x=0;
            for(int i=0; ; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                x += a;
                if (a == 0)
                {
                    Console.WriteLine(x);
                    break;                   
                }
            }

            //Zadanie3.13
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            if (a < 0)
            {
                for (int i = -1; i >= a; i--)
                {
                    x += i;
                }
            }
            else
            {

                for (int i = 1; i <= a; i++)
                {
                    x += i;
                }
            }
            Console.WriteLine(x);

            //Zadanie3.14.
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for(int i=a-1; i>0; i--)
            {
                if (a % i == 0)
                {
                    x += i;
                }
            }
            Console.WriteLine(x);
            if (x == a) Console.WriteLine("Doskonala");
            else Console.WriteLine("niedoskonala");


            //Zadanie 3.15.                                                                              //////// DO SKONCZENIA /////////    
            int[] tab_monet = {1,2,5};
            int sum = 10;
            int n_sum = 0;
            int ile = 0;
            for(int i=1; i<=sum; i++)
            {
                n_sum += tab_monet[0];
                if (n_sum == sum)
                {
                    ile++;
                    for(int j=sum; j>0; j--)
                    {
                    
                    }
                }
            }

            int a = 10, b = 1, c = 2, d = 5;   // dane sumy i 3 monet
            int e = a / b;
            int f = a / c;                      // dzielniki by wiedziec ile max petla dla danego
            int g = a / d;
            int l = 0, m = 0, n = 0;            // liczniki do 10
            int[,,] tab = new int[e,f,g];       //tablica z mozliwosciami polaczenia ilosci monet

            for(int i=0; i<e; i++)                                      // petla dla jedynek                            
            {
                tab[i, 0, 0] = b;
                l += tab[i, 0, 0];

                if (l == a)
                {
                    Console.WriteLine("Istnieje rozwiazanie");
                }

                for (int j = 0; j < f; j++)                             // petla dla dwojek i jedynek
                {
                    tab[i, j, 0] = c;
                    m += l + tab[i, j, 0];

                    if (m == a)
                    {
                        Console.WriteLine("Istnieje rozwiazanie");
                    }

                    for (int k = 0; k < g; k++)                         // petla dla wszystkich
                    {
                        tab[i, j, k] = d;
                        n += m + tab[i, j, k];
                        Console.WriteLine("{0}{1}{2}  {3}", i, j, k, tab[i, j, k]);

                        if (n == a)
                        {
                            Console.WriteLine("Istnieje rozwiazanie");
                        }
                    }
                }

            }

            int a = 10, b = 1, c = 2, d = 5;   // dane sumy i 3 monet
            int e = a / b;
            int f = a / c;                      // dzielniki by wiedziec ile max petla dla danego
            int g = a / d;
            int l = 0, m = 0, n = 0;            // liczniki do 10
            int[] tab1 = new int [e];
            int[] tab2 = new int[f];
            int[] tab3 = new int[g];
            for (int i = 0; i < e; i++)                                      // petla dla jedynek                            
            {
                l += b;
                if (l == a) Console.WriteLine("Istnieje rozwiazanie");
            }

            //Zadanie 3.15                                                                                          POPRAWNE ROZWIAZANIE !!!!!!!!
            int[] tab1 = new int[11];
            int[] tab2 = new int[6];
            int[] tab3 = new int[3];
            int[,,] tab4 = new int[11, 6,3];
            int sum1 = 0, sum2 = 0, sum3=0;
            for(int i=0; i < tab1.Length; i++)
            {
                for(int j=0; j < tab2.Length; j++)
                {
                    for(int k=0; k < tab3.Length; k++)
                    {
                        tab4[i, j,k] = sum1 + sum2 + sum3;
                        if (tab4[i, j,k] == 10) Console.WriteLine("Rozwiazanie jedynek {0} dwójek {1} piatek {2}", sum1, sum2 / 2, sum3/5);
                        sum3 += 5;
                    }
                    sum2 += 2;
                    sum3 = 0;
                }
                sum1++;
                sum2 = 0;
                sum3 = 0;
            }
 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        //Zadanie 4.1.
                        Console.Write("Podaj liczbe elem tablicy: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int[] tab = new int[a];
                        for(int i =0; i < a; i++)
                        {
                            Console.Write("Podaj {0} elem tablicy: ",i+1);
                            int b = Convert.ToInt32(Console.ReadLine());
                            tab[i] = b;
                        }
                        for (int j = 0; j < a; j++)
                        {
                            Console.WriteLine("{0} elem tablicy: {1}",j+1, tab[j]);
                        }


                        //Zadanie4.2
                        int a = 10;
                        int[] tab = new int[a];
                        int[] tab2 = new int[a];
                        for (int i = 0; i < a; i++)
                        {
                            Console.Write("Podaj {0} elem tablicy: ", i + 1);
                            int b = Convert.ToInt32(Console.ReadLine());
                            tab[i] = b;
                            tab2[i] = tab[i];
                        }
                        for (int j = 0; j < a; j++)                                                                                     // zrobic kopiowanie do nowej tablicy ale by sama sobie zrobila wielkosc
                        {                                                                                                               // i zapisywala dodatnie do innej tablicy i np z 10 sie zrobi tab[5]    
                            if (tab[j] >= 0)
                            {
                                Console.WriteLine("{0} elem tablicy dodatniej: {1}", j + 1, tab2[j]);
                            }
                        }


                        //Zadanie4.3
                        int a = 3;
                        double a1 = a;
                        int c = 0;
                        int d = 0;
                        double e = 0;
                        double f = 0;
                        int g = 0;
                        int[] tab = new int[a];
                        for (int i = 0; i < a; i++)
                        {
                            Console.Write("Podaj {0} elem tablicy: ", i + 1);
                            int b = Convert.ToInt32(Console.ReadLine());
                            tab[i] = b;
                        }
                        for (int j = 0; j < a; j++)
                        {
                            if (d > tab[j]) d = tab[j];
                            if (c < tab[j]) c = tab[j];
                            e += tab[j];
                            f = Math.Round(e / a1,2);
                            if (tab[j] >= 0) g ++;
                        }
                        Console.WriteLine("Max: {0}", c);
                        Console.WriteLine("Min: {0}", d);
                        Console.WriteLine("Srednia: {0}", f);
                        Console.WriteLine("Dodatnich jest: {0}", g);
          
            //Zadanie4.4.
            Random randomy = new Random();
            int[] tab = new int[100];
            for(int i=0; i<100; i++)
            {
                tab[i] = randomy.Next(1, 100);
                if (i == 99) Console.Write("{0}.", tab[i]);
                else Console.Write("{0}, ", tab[i]);
                    
            }
  
            //Zadanie4.5.
            Random randomy = new Random();
            int[] tab = new int[10];
            int[] tab2 = new int[10];
            for (int i = 0; i < 10; i++)                                                        //wypelnienie randomowymi liczbami 1-100 tablicy
            {
                tab[i] = randomy.Next(1, 100);
                if (i == tab.Length - 1) Console.Write("{0}. \n Nowa Tabela \n", tab[i]);
                else Console.Write("{0}, ", tab[i]);
            }

            for (int j = 0; j < tab.Length; j++)                                                // druga tablica z przesunieciem
            {

                if (j == 0)                                                                     // zerowy to ostatni
                {
                    tab2[j] = tab[tab.Length-1];
                    Console.Write("{0}, ", tab2[j]);
                }
                else if (j == tab.Length - 1)                                                   // zakonczenie kropka dla ostatniego elem
                {
                    tab2[j] = tab[j - 1];
                    Console.Write("{0}.", tab2[j]);
                }
                else
                {
                                                                                                // przesuniecie wszystkich pozostalych elementow
                }
                {
                    tab2[j] = tab[j - 1];
                    Console.Write("{0}, ", tab2[j]);
                }
            }

            //Zadanie4.6.
            Random randomowo = new Random();
            int[,] tab = new int[5, 5];
            int suma = 0;
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    tab[i, j] = randomowo.Next(1, 5);
                    Console.Write("|{0}", tab[i, j]);
                    if (i == j)
                    {
                        suma += tab[i, j];
                    }
                }
                Console.WriteLine("|");                     // utworzenie nowej linii i zakonczenie oddzielen liczb
            }
            Console.WriteLine("Suma = {0}", suma);

            //Zadanie4.7
            Random randomowo = new Random();
            int[,] tab1 = new int[2, 3];
            int[,] tab2 = new int[2, 3];
            int[,] tab3 = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab1[i, j] = randomowo.Next(1, 5);
                    Console.Write("|{0}", tab1[i, j]);
                }
                Console.WriteLine("|");                     
            }
            Console.WriteLine("----------------------------");

            for (int k = 0; k < 2; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    tab2[k, l] = randomowo.Next(1, 5);
                    Console.Write("|{0}", tab2[k, l]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("----------------------------");

            for (int m = 0; m < 2; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    tab3[m, n] = tab1[m,n] + tab2[m,n];
                    Console.Write("|{0}", tab3[m, n]);
                }
                Console.WriteLine("|");
            }


            //Zadanie4.8.
            string[,] dniTygodnia;
            string d = "----------------------------------------------------------------------------------------------------";
            dniTygodnia = new string[2, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write("|{0,-15}", dniTygodnia[i, j]);
                }
                Console.WriteLine("|");
                Console.WriteLine("{0,-35}", d.Substring(0,48));                    // substring dopasowuje ciag do tylu ile chcemy "od do" 48 bo mamy 3x15 plus 4 razy "|" i minus jeden bo od 0
            }


            //Zadanie4.9
            string text = "Bardzo kocham moją dzieczynę Kasię";
            string[] tab_text = text.Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries);                 // taki zapis gdy wiecje znakow analizowane
            for(int i=0; i < tab_text.Length; i++)
            {
                Console.WriteLine("{0}", tab_text[i]);
            }
            Console.WriteLine("Liczba wyrazow: {0}",tab_text.Length);


            //Zadanie4.10
            DateTime data_dzis = DateTime.Today;
            Console.WriteLine("Dzis: {0}", data_dzis.ToString("Y"));
            string[] d = data_dzis.ToString("Y").Split(' ');                                                    // taki zapis tylko dla pojedynczego znaku
            int mies = 0;
            if (d[0] == "październik") mies = 10;
            switch (mies)
            {
                case 10:
                    Console.WriteLine("Miesiac to pazdziernik");
                    break;
            }

            //Zadanie4.11
            string ciag = Console.ReadLine();                                           // rozdziela wpisywany ciag i sprawdza ile razy wystapila dana litera
            string[] litery= new string[ciag.Length];
            string[] alfabet = new string [3]{ "a", "b", "c" };
            int[] licz = new int[3];
            string lit_spr;
            int a=0, b=0, c=0;
            for(int i=0; i < ciag.Length; i++)
            {
                litery[i] = ciag.Substring(i,1);
                Console.WriteLine(litery[i]);
            }
            for(int j = 0; j < ciag.Length; j++)
            {
                lit_spr = litery[j];
                                                                                //if (lit_spr == "a") a++;          latwiejsze rozwiazanie
                                                                                //if (lit_spr == "b") b++;
                                                                                //if (lit_spr == "c") c++;
                for(int k=0; k < alfabet.Length; k++)
                {
                    if (lit_spr == alfabet[k]) licz[k]++;
                }            
            }
            for (int l = 0; l < alfabet.Length; l++)
            {
                if (licz[l] != 0) Console.WriteLine("Znak {0} alfabetu wystapil: {1} ", alfabet[l], licz[l]);
            }
                                                                               // Console.WriteLine("{0} - {1} \n {2} - {3} \n {4} - {5}", "a", a, "b", b, "c", c);


            //Zadanie4.12
            // fragment powieści A. A. Milne, "Kubuś Puchatek"
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            int wiersze = 0;
            string[] wiersz = tekst.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < wiersz.Length; j++)
            {
                string wiersz2 = Convert.ToString(wiersz[j]);
                string[] slowa = wiersz2.Split(new char[] { ' ' });
                Console.WriteLine("Wiersz {0} ma {1} slow", j + 1, slowa.Length);
            }
            Console.WriteLine($"\n\n {tekst} \n\n");
            for (int i = 0; i < wiersz.Length; i++)
            {
                wiersze++;

            }
            Console.WriteLine("Wierszy jest: " + wiersze);

            //Zadanie4.13
            string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać,\n" +
                " żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            string[] calosc = tekst.Split(new string[] { " ", ",", "\n"},StringSplitOptions.RemoveEmptyEntries);
            int[] suma = new int[calosc.Length];
            string[] unikalne = calosc.Distinct().ToArray();
            for (int j = 0; j < unikalne.Length; j++)
            {
                for(int k=0; k < calosc.Length; k++)
                {
                    if (unikalne[j] == calosc[k]) suma[j]++;
                }
                if(suma[j]!=1)
                Console.WriteLine("Slowo {0} wystepuje: {1}", calosc[j], suma[j]);
            }

            //Zadanie4.14
            string nazwa = Console.ReadLine();
            string[] nazw = nazwa.Split('-');
            string data = DateTime.Now.ToString("yyy");
            Console.WriteLine("Od produkcji minelo: {0}lat", Convert.ToInt32(data) - Convert.ToInt32(nazw[1]));


            //Zadanie4.15                                                                                                           SZYFRYZATOR
            string wprowadzanyTekst = Console.ReadLine();
            string[] tekstNaLitery = new string[wprowadzanyTekst.Length];
            char[] klucz = new char[6] { 'a', '@', 'b', 'e', 'c', '#' };
            char[] tekstPoSzyfryzacji = new char[wprowadzanyTekst.Length];
            string zaszyfrowanyTekst = string.Empty;
            for(int i=0; i < wprowadzanyTekst.Length; i++)
            {
                tekstNaLitery[i] = wprowadzanyTekst.Substring(i, 1);                                            //zamiana tekstu na litery
                for(int j=0; j < klucz.Length; j++)
                {
                    if (Convert.ToChar(tekstNaLitery[i]) == klucz[j])                                           // sprawdzenie czy litera jest w kluczu
                    {   
                        switch (j)                                                                              // zamiana miejscami
                        {
                            case 0:
                                tekstPoSzyfryzacji[i] = klucz[1];
                                break;
                            case 1:
                                tekstPoSzyfryzacji[i] = klucz[0];
                                break;
                            case 2:
                                tekstPoSzyfryzacji[i] = klucz[3];
                                break;
                            case 3:
                                tekstPoSzyfryzacji[i] = klucz[2];
                                break;
                            case 4:
                                tekstPoSzyfryzacji[i] = klucz[5];
                                break;
                            case 5:
                                tekstPoSzyfryzacji[i] = klucz[4];
                                break;
                            default:
                                break;

                        }
                        break;                                                                                  // wazne wyjscie z petli IF jesli wykonalo zamiane znaku !!!!
                    }
                    else if (Convert.ToChar(tekstNaLitery[i]) != klucz[j]) tekstPoSzyfryzacji[i] = Convert.ToChar(tekstNaLitery[i]);        // pozostawienie spoza klucza takie same
                }
            }   
            zaszyfrowanyTekst = string.Concat(tekstPoSzyfryzacji);                                              // polaczenie znakow w ciag
            Console.WriteLine(zaszyfrowanyTekst);                                                               // wyswietlenie po szyfryzacji

                                                                                                        //// DESZYFRYZACJA
            char[] szyfrNaLitery = new char[zaszyfrowanyTekst.Length];      
            char[] tekstPoDeszyfryzacji = new char[zaszyfrowanyTekst.Length];
            for(int k=0; k<zaszyfrowanyTekst.Length; k++)
            {
                szyfrNaLitery[k] = Convert.ToChar(zaszyfrowanyTekst.Substring(k, 1));               //szyfr na litery
                for(int l=0; l < klucz.Length; l++)
                {
                    if (szyfrNaLitery[k] == klucz[l])                                               //ponowna podmiana
                    {
                        switch (l)
                        {
                            case 0:
                                tekstPoDeszyfryzacji[k] = klucz[1];
                                break;
                            case 1:
                                tekstPoDeszyfryzacji[k] = klucz[0];
                                break;
                            case 2:
                                tekstPoDeszyfryzacji[k] = klucz[3];
                                break;
                            case 3:
                                tekstPoDeszyfryzacji[k] = klucz[2];
                                break;
                            case 4:
                                tekstPoDeszyfryzacji[k] = klucz[5];
                                break;
                            case 5:
                                tekstPoDeszyfryzacji[k] = klucz[4];
                                break;
                            default:
                                break;

                        }
                        break;
                    }
                    else tekstPoDeszyfryzacji[k] = szyfrNaLitery[k];
                }
            }
            string poDeszyfryzacji = string.Concat(tekstPoDeszyfryzacji);
            Console.WriteLine(poDeszyfryzacji);

            //Zadanie 5.1
            int  temp = Convert.ToInt32(Console.ReadLine());
            FnaC(temp);
            

            //Zadanie 5.2
            Console.Write("Zmienna: ");
            float zmienna = float.Parse(Console.ReadLine());
            Console.Write("Min: ");
            float min = float.Parse(Console.ReadLine());
            Console.Write("Max: ");
            float max = float.Parse(Console.ReadLine());
            bool czyJestWPrzedziale = CzyJestWPrzedziale(zmienna, min, max);
            if (czyJestWPrzedziale) Console.WriteLine("Jest w przedziale");
            else Console.WriteLine("Nie jest w przedzizale");

            //Zadanie5.3.
            Console.Write("Podaj wektor:");
            double wektor1 = double.Parse(Console.ReadLine());
            double wektor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przesuniecie");
            double przesun1 = double.Parse(Console.ReadLine());
            double przesun2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Przed przesunieciem: {0} , {1}", wektor1, wektor2);
            PrzesunWektor(ref wektor1, ref wektor2, przesun1, przesun2);
            Console.WriteLine("Po przesunieciu: {0} , {1}", wektor1, wektor2);

            //Zadanie 5.4
            // A
            int[] tab = new int[3] { 1, 2, 3 };
            Console.WriteLine("Podaj mnoznik tablicy: ");
            int mnoznik = Convert.ToInt32(Console.ReadLine());
            int[] tab1 = NowaTablica(tab, mnoznik);
            for (int i = 0; i < tab.Length; i++) Console.WriteLine(tab1[i]);

            //B
            int[] tab = new int[3] { 1, 2, 3 };
            Console.WriteLine("Podaj mnoznik tablicy: ");
            int mnoznik = Convert.ToInt32(Console.ReadLine());
            NowaTab(tab, mnoznik);

            //Zadanie 5.5
            Console.Write("Podaj dlugosc: ");
            int dlugosc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj szerokosc: ");
            int szerokosc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj znak: ");
            char znak = char.Parse(Console.ReadLine());
            RysujProstokat(dlugosc, szerokosc, znak);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Zadanie 5.6
            Console.Write("Podaj wielkosc tab: ");
            int wielkoscTablicy = Convert.ToInt32(Console.ReadLine());
            string[] tab1 = new string[wielkoscTablicy];
            string[] tab_stala = tab1;
            Console.Write("Podaj ile razy konkatenowac: ");
            int konkaten = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < tab1.Length; i++)
            {
                Console.Write("Podaj {0} elem tab:",i);
                tab1[i] = Console.ReadLine();
            }
            string[] tab2 = Konkatenowanie(tab1, konkaten, ref tab_stala);
            for (int j = 0; j < tab2.Length; j++) Console.WriteLine("Po konkatenowaniu {0} elem to: {1}",j,tab2[j]);



            //Zadanie 5.7
            Console.Write("Podaj x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DodawanieDoN(x, n);


            //Zadanie5.8
            Console.Write("Podaj liczbe do dodania sumy cyfr skladowych:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            SumaCyfrSkladowych(liczba);
*/







            //wyjscie lub powtorzenie programu
            ConsoleKeyInfo komenda =  Console.ReadKey();
            if (komenda.Key == ConsoleKey.Spacebar) goto etykieta1;
            else Environment.Exit(0);
        }

        static void FnaC (int x)
        {
            x -= 32;
            Console.WriteLine("Po zmianie" + x);
        }
        static bool CzyJestWPrzedziale (float doprzedzialu, float minPrzedzial, float maxPrzedzial)
        {
            if (doprzedzialu < maxPrzedzial && doprzedzialu > minPrzedzial) return true;
            else return false;
        }
        static void PrzesunWektor (ref double wek1, ref double wek2, double przes1, double przes2)
        {
            wek1 += przes1;
            wek2 += przes2;
        }
        static int[] NowaTablica (int[] tab, int mnoznik)
        {
            for(int i=0; i < tab.Length; i++)
            {
                tab[i] = tab[i] * mnoznik;
            }
            return tab;
        }
        static void NowaTab (int[] tab, int mnoznik)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i] * mnoznik;
                Console.WriteLine(tab[i]);
            }
        }
        static void RysujProstokat(int dlugosc, int szerokosc, char znak)
        {
            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
        static string[] Konkatenowanie(string[] tab, int mnoznik, ref string[] tab_stala)                   /// nie dziala  - ZADANIE 5.6
        {
                for (int i = 0; i < tab.Length; i++)
                {
                   for(int j=0; j < mnoznik; j++)
                   {
                    tab[i] += tab_stala[i];
                   }
                    
                }
            return tab;
        }
        static void DodawanieDoN (int x, int n)
        {
            int suma=0;
            for ( int i =1; i<=n; i++)
            {
                suma = suma + x + i;
            }
            Console.WriteLine(suma);
        }

        static void SumaCyfrSkladowych (int liczba)
        {
            int wynik=0;
            while (liczba != 0)
            {
                wynik += liczba % 10;
                liczba /= 10;
            }
            Console.WriteLine("Suma cyffr skladowych" + wynik);
        }
    }
}
