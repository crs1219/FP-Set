using System;

class Setul2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar intre 1 si 17 pentru a alege o problema: ");

        int optiune = Convert.ToInt32(Console.ReadLine());

        switch (optiune)
        {
            case 1:
                Problema1();
                break;

            case 2:
                Problema2();
                break;

            case 3:
                Problema3();
                break;

            case 4:
                Problema4();
                break;

            case 5:
                Problema5();
                break;

            case 6:
                Problema6();
                break;

            case 7:
                Problema7();
                break;

            case 8:
                Problema8();
                break;

            case 9:
                Problema9();
                break;

            case 10:
                Problema10();
                break;

            case 11:
                Problema11();
                break;

            case 12:
                Problema12();
                break;

            case 13:
                Problema13();
                break;

            case 14:
                Problema14();
                break;

            case 15:
                Problema15();
                break;

            case 16:
                Problema16();
                break;

            case 17:
                Problema17();
                break;

            default:
                Console.WriteLine("Optiune invalida.");
                break;
        }
    }

    static void Problema1()
    {
        Console.WriteLine("Se da o secventa de n numere. \nSa se determine cate din ele sunt pare. ");

        // preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   // declaram vectorul

        int i, nrPare = 0;   // declaram variabila in care vom retine numarul de elemente pare

        for (i = 0; i < n; i++)    // parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);   // citim elementul
            v[i] = Convert.ToInt32(Console.ReadLine());   //adaugam elementul in vector

            if (v[i] % 2 == 0)   // verificam daca elementul curent este par
            {
                nrPare++;   // daca este par, incrementam numarul de elemente pare
            }
        }

        Console.WriteLine("Numarul de elemente pare din secventa este: {0}", nrPare);

        Console.ReadKey();
    }

    static void Problema2()
    {
        Console.WriteLine("Se da o secventa de n numere. \nSa se determina cate sunt negative, cate sunt zero si cate sunt pozitive");

        // preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   // declaram vectorul

        int i, nrNegative = 0, nrZero = 0, nrPozitive = 0;   // declaram variabilele in care vom retine numarul de elemente negative, zero si pozitive

        for (i = 0; i < n; i++)   // parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());

            // verificam daca elementul curent este negativ, egal cu 0 sau pozitiv
            if (v[i] < 0)
            {
                nrNegative++;   // daca este negativ, incrementam numarul de elemente negative
            }
            else if (v[i] == 0)
            {
                nrZero++;
            }
            else
            {
                nrPozitive++;
            }
        }

        // afisam numarul de elemente negative, zero si pozitive
        Console.WriteLine("Numarul de elemente negative din secventa este: {0}", nrNegative);
        Console.WriteLine("Numarul de elemente zero din secventa este: {0}", nrZero);
        Console.WriteLine("Numarul de elemente pozitive din secventa este: {0}", nrPozitive);

        Console.ReadKey();
    }

    static void Problema3()
    {
        Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n. ");

        // preluam datele de intrare
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul n este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul n trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int i, suma = 0, produs = 1;   // declaram variabilele in care vom retine suma si produsul numerelor de la 1 la n

        for (i = 1; i <= n; i++)   // parcurgem numerele de la 1 la n
        {
            suma += i;   // calculam suma numerelor de la 1 la n
            produs *= i;   // calculam produsul numerelor de la 1 la n
        }

        Console.WriteLine("Suma numerelor de la 1 la {0} este: {1}", n, suma);
        Console.WriteLine("Produsul numerelor de la 1 la {0} este: {1}", n, produs);

        Console.ReadKey();
    }

    static void Problema4()
    {
        Console.WriteLine("Se da o secventa de n numere. \nDeterminati pe ce pozitie se afla in secventa un numara a. \nSe considera ca primul element din secventa este pe pozitia zero. \nDaca numarul nu se afla in secventa raspunsul va fi -1.");

        // preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   // declaram vectorul

        int i, a, pozitie = -1;   // declaram variabilele in care vom retine numarul de elemente negative, zero si pozitive

        for (i = 0; i < n; i++)   // parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);   // citim elementul
            v[i] = Convert.ToInt32(Console.ReadLine());   // adaugam elementul in vector
        }

        Console.Write("Introduceti numarul a: ");
        a = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < n; i++)   // parcurgem vectorul si cautam numarul a
        {
            if (v[i] == a)   // verificam daca elementul curent este egal cu numarul a
            {
                pozitie = i;   // daca este egal, retinem pozitia pe care se afla in secventa
                break;   // iesim din bucla
            }
        }

        Console.WriteLine("Numarul {0} se afla pe pozitia {1} in secventa.", a, pozitie);

        Console.ReadKey();
    }

    static void Problema5()
    {
        Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \nSe considera ca primul element din secventa este pe pozitia 0. ");

        // preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   // declaram vectorul

        int i, nrEgale = 0;   // declaram variabila in care vom retine numarul de elemente egale cu pozitia pe care apar in secventa

        for (i = 0; i < n; i++)   // parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());

            if (v[i] == i)
            {
                nrEgale++;
            }
        }

        Console.WriteLine("Numarul de elemente egale cu pozitia pe care apar in secventa este: {0}", nrEgale);

        Console.ReadKey();
    }

    static void Problema6()
    {
        Console.WriteLine("Se da o secventa de n numere. \nSa se determine daca numerele din secventa sunt in ordine crescatoare. ");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul de elemente din secventa: ");
        int nr = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (nr <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.WriteLine("Introduceti numarul de elemente din secventa: ");
            nr = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[nr];   // declaram vectorul

        int i, crescator = 1;   // declaram variabila in care vom retine daca numerele din secventa sunt in ordine crescatoare

        for (i = 0; i < nr; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        if (crescator == 1)   //verificam daca numerele sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
        }

        Console.ReadKey();
    }

    static void Problema7()
    {
        Console.WriteLine("Se da o secventa de n numere. \nSa se determine cea mai mare si cea mai mica valoare din secventa.");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        //validam datele de intrare
        while (n <= 0)   //verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   //declaram vectorul

        int i, min, max;   //declaram variabilele in care vom retine cea mai mica si cea mai mare valoare din secventa

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        //initializam min si max cu primul element din secventa
        min = v[0];
        max = v[0];

        for (i = 1; i < n; i++)   //parcurgem vectorul si determinam cea mai mica si cea mai mare valoare din secventa
        {
            if (v[i] < min)   //verificam daca elementul curent este mai mic decat minimul
            {
                min = v[i];   //daca este mai mic, il retinem ca fiind minimul
            }
            else if (v[i] > max)   //verificam daca elementul curent este mai mare decat maximul
            {
                max = v[i];   //daca este mai mare, il retinem ca fiind maximul
            }
        }

        Console.WriteLine("Cea mai mica valoare din secventa este: {0}", min);
        Console.WriteLine("Cea mai mare valoare din secventa este: {0}", max);

        Console.ReadKey();
    }

    static void Problema8()
    {
        Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. \nSirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");

        //preluam datele de intrare
        Console.Write("Introduceti numarul n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul n este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul n trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int i, f1 = 0, f2 = 1, f3 = 0;   //declaram variabilele in care vom retine numerele din sirul lui Fibonacci 

        for (i = 3; i <= n; i++)   //parcurgem sirul lui Fibonacci si calculam al n-lea numar
        {
            f3 = f1 + f2;   //calculam al n-lea numar din sirul lui Fibonacci
            f1 = f2;   //actualizam f1
            f2 = f3;   //actualizam f2
        }

        Console.WriteLine("Al {0}-lea numar din sirul lui Fibonacci este: {1}", n, f3);

        Console.ReadKey();
    }

    static void Problema9()
    {
        Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. \nSecventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[n];   //declaram vectorul

        int i, crescator = 1, descrescator = 1;   //declaram variabilele in care vom retine daca numerele din secventa sunt in ordine crescatoare sau descrescatoare

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        if (crescator == 1)   //verificam daca numerele sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else if (descrescator == 1)   //verificam daca numerele sunt in ordine descrescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine descrescatoare.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare sau descrescatoare.");
        }

        Console.ReadKey();
    }

    static void Problema10()
    {
        Console.WriteLine("Se da o secventa de n numere. \nCare este numarul maxim de numere consecutive egale din secventa. ");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[n];   //declaram vectorul

        int i, j, nrMaxim = 0, nrCurent = 1;   //declaram variabilele in care vom retine numarul maxim de numere consecutive egale din secventa si numarul curent de numere consecutive egale din secventa

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si determinam numarul maxim de numere consecutive egale din secventa
        {
            for (j = i + 1; j < n; j++)   //parcurgem vectorul si determinam numarul curent de numere consecutive egale din secventa
            {
                if (v[i] == v[j])   //verificam daca elementul curent este egal cu urmatorul element
                {
                    nrCurent++;   //daca este egal, incrementam numarul curent de numere consecutive egale din secventa
                }
                else   //daca nu este egal, iesim din bucla
                {
                    break;
                }
            }

            if (nrCurent > nrMaxim)   //verificam daca numarul curent de numere consecutive egale din secventa este mai mare decat numarul maxim de numere consecutive egale din secventa
            {
                nrMaxim = nrCurent;   //daca este mai mare, il retinem ca fiind numarul maxim de numere consecutive egale din secventa
            }

            nrCurent = 1;   //resetam numarul curent de numere consecutive egale din secventa
        }

        Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este: {0}", nrMaxim);

        Console.ReadKey();
    }

    static void Problema11()
    {
        Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[n];   //declaram vectorul

        int i;
        double suma = 0;   //declaram variabila in care vom retine suma inverselor numerelor din secventa

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());

            suma += 1.0 / v[i];   //calculam suma inverselor numerelor din secventa
        }

        Console.WriteLine("Suma inverselor numerelor din secventa este: {0}", suma);

        Console.ReadKey();
    }

    static void Problema12()
    {
        Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[n];   //declaram vectorul

        int i, nrGrupuri = 0;   //declaram variabila in care vom retine numarul de grupuri de numere consecutive diferite de zero din secventa

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si determinam numarul de grupuri de numere consecutive diferite de zero din secventa
        {
            if (v[i] != 0 && v[i + 1] == 0)   //verificam daca elementul curent este diferit de zero si urmatorul element este egal cu zero
            {
                nrGrupuri++;   //daca este diferit de zero si urmatorul element este egal cu zero, incrementam numarul de grupuri de numere consecutive diferite de zero din secventa
            }
        }

        Console.WriteLine("Numarul de grupuri de numere consecutive diferite de zero din secventa este: {0}", nrGrupuri);

        Console.ReadKey();
    }

    static void Problema13()
    {
        Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). \nDeterminati daca o secventa de n numere este o secventa crescatoare rotita. ");

        //preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[n];   //declaram vectorul

        int i, crescator = 1, descrescator = 1;   //declaram variabilele in care vom retine daca numerele din secventa sunt in ordine crescatoare sau descrescatoare

        for (i = 0; i < n; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < n - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        if (crescator == 1)   //verificam daca numerele sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else if (descrescator == 1)   //verificam daca numerele sunt in ordine descrescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine descrescatoare.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare sau descrescatoare.");
        }

        Console.ReadKey();
    }

    static void Problema14()
    {
        Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. \nDeterminati daca o secventa de n numere este o secventa monotona rotita. ");

        //preluam datele de intrare
        Console.WriteLine("Introduceti numarul de elemente din secventa: ");
        int nr = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[nr];   //declaram vectorul

        int i, crescator = 1, descrescator = 1;   //declaram variabilele in care vom retine daca numerele din secventa sunt in ordine crescatoare sau descrescatoare

        for (i = 0; i < nr; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        if (crescator == 1)   //verificam daca numerele sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else if (descrescator == 1)   //verificam daca numerele sunt in ordine descrescatoare
        {
            Console.WriteLine("Numerele din secventa sunt in ordine descrescatoare.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare sau descrescatoare.");
        }

        Console.ReadKey();
    }

    static void Problema15()
    {
        Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrescator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. \nSe da o secventa de n numere. Sa se determine daca este bitonica. ");
        Console.Write("Secventa este bitonica?");

        //preluam datele de intrare
        Console.WriteLine("Introduceti numarul de elemente din secventa: ");
        int nr = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[nr];   //declaram vectorul

        int i, crescator = 1, descrescator = 1;   //declaram variabilele in care vom retine daca numerele din secventa sunt in ordine crescatoare sau descrescatoare

        for (i = 0; i < nr; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        //verficam daca secventa este bitonica
        if (crescator == 1 && descrescator == 1)   //verificam daca numerele sunt in ordine crescatoare si descrescatoare
        {
            Console.WriteLine("Secventa este bitonica.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Secventa nu este bitonica.");
        }

        Console.ReadKey();
    }

    static void Problema16()
    {
        Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). \nSe da o secventa de n numere. \nSe cere sa se determine daca este o secventa bitonica rotita. ");

        //preluam datele de intrare
        Console.WriteLine("Introduceti numarul de elemente din secventa: ");
        int nr = Convert.ToInt32(Console.ReadLine());

        //validam datele de intrare
        while (nr < 3)   //verificam daca numarul de elemente din secventa este mai mic decat 3
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare sau egal cu 3.");
            Console.WriteLine("Introduceti numarul de elemente din secventa: ");
            nr = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[nr];   //declaram vectorul

        int i, crescator = 1, descrescator = 1;   //declaram variabilele in care vom retine daca numerele din secventa sunt in ordine crescatoare sau descrescatoare

        for (i = 0; i < nr; i++)   //parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        //rotim secventa
        int aux = v[0];   //retinem primul element din secventa in aux
        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si rotim secventa
        {
            v[i] = v[i + 1];   //rotim secventa
        }

        v[nr - 1] = aux;   //adaugam primul element din secventa la sfarsitul secventei

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine crescatoare
        {
            if (v[i] > v[i + 1])   //verificam daca elementul curent este mai mare decat urmatorul element
            {
                crescator = 0;   //daca nu este mai mare, inseamna ca numerele nu sunt in ordine crescatoare
                break;   //iesim din bucla
            }
        }

        for (i = 0; i < nr - 1; i++)   //parcurgem vectorul si verificam daca numerele sunt in ordine descrescatoare
        {
            if (v[i] < v[i + 1])   //verificam daca elementul curent este mai mic decat urmatorul element
            {
                descrescator = 0;   //daca nu este mai mic, inseamna ca numerele nu sunt in ordine descrescatoare
                break;   //iesim din bucla
            }
        }

        //verficam daca secventa este bitonica
        if (crescator == 1 && descrescator == 1)   //verificam daca numerele sunt in ordine crescatoare si descrescatoare
        {
            Console.WriteLine("Secventa este bitonica.");
        }
        else   //crescatore == 0, numerele nu sunt in ordine crescatoare
        {
            Console.WriteLine("Secventa nu este bitonica.");
        }

        Console.ReadKey();
    }

    static void Problema17()
    {
        Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \nDeterminati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. \nDe exemplu: 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");

        // preluam datele de intrare
        Console.Write("Introduceti numarul de elemente din secventa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        while (n <= 0)   // verificam daca numarul de elemente din secventa este mai mic sau egal cu 0
        {
            Console.WriteLine("Numarul de elemente din secventa trebuie sa fie mai mare decat 0.");
            Console.Write("Introduceti numarul de elemente din secventa: ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        int[] v = new int[n];   // declaram vectorul

        int i, nivel = 0, nivelMaxim = 0;   // declaram variabilele in care vom retine nivelul de incuibare a parantezelor si nivelul maxim de incuibare a parantezelor

        for (i = 0; i < n; i++)   // parcurgem vectorul si citim elementele
        {
            Console.Write("v[{0}] = ", i);   // citim elementul
            v[i] = Convert.ToInt32(Console.ReadLine());   // adaugam elementul in vector

            if (v[i] == 0)   // verificam daca elementul curent este egal cu 0
            {
                nivel++;   // daca este egal cu 0, incrementam nivelul de incuibare a parantezelor
            }
            else   // daca nu este egal cu 0
            {
                nivel--;   // decrementam nivelul de incuibare a parantezelor
            }

            if (nivel > nivelMaxim)   // verificam daca nivelul de incuibare a parantezelor este mai mare decat nivelul maxim de incuibare a parantezelor
            {
                nivelMaxim = nivel;   // daca este mai mare, il retinem ca fiind nivelul maxim de incuibare a parantezelor
            }
        }

        if (nivel == 0)   // verificam daca nivelul de incuibare a parantezelor este egal cu 0
        {
            Console.WriteLine("Secventa reprezinta o secventa de paranteze corecta.");
            Console.WriteLine("Nivelul maxim de incuibare a parantezelor este: {0}", nivelMaxim);
        }
        else   // daca nu este egal cu 0
        {
            Console.WriteLine("Secventa nu reprezinta o secventa de paranteze corecta.");
        }

        Console.ReadKey();
    }
}