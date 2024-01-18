using System;

class Setul1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar intre 1 si 21 pentru a alege o problema: ");

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

            /*case 4:
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

            case 18:
                Problema18();
                break;

            case 19:
                Problema19();
                break;

            case 20:
                Problema20();
                break;

            case 21:
                Problema21();
                break;

            case 22:
                Problema22();
                break;

            case 23:
                Problema23();
                break;

            case 24:
                Problema24();
                break;

            case 25:    
                Problema25();
                break;

            case 26:
                Problema26();
                break; 

            case 27:
                Problema27();
                break;

            case 28:
                Problema28();
                break;

            case 29:
                Problema29();
                break;

            case 30:
                Problema30();
                break;

            case 31:
                Problema31();
                break;*/

            default:
                Console.WriteLine("Optiune invalida.");
                break;
        }
    }

    static void Problema1()
    {
        Console.WriteLine("Calculati suma elementelor unui vector de n numere citite de la tastatura. \nRezultatul se va afisa pe ecran.");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // calcul suma elemente vector
        int suma = 0;

        for (int i = 0; i < n; i++)   // sau for (int i = 0; i < vector.Length; i++)
        {
            suma += vector[i];
        }

        Console.WriteLine($"Suma elementelor vectorului este: {suma}");

        Console.ReadKey();
    }

    static void Problema2()
    {
        Console.WriteLine("Se da un vector cu n elemente si o valoare k. \nSe cere sa se determine prima pozitie din vector pe care apare k. \nDaca k nu apare in vector rezultatul va fi -1. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Introduceti valoarea k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare 
        if (k <= 0)
        {
            Console.WriteLine("Valoarea k trebuie sa fie mai mare decat 0.");
            return;
        }

        // cautare pozitie k in vector

        int pozitie = -1;

        for (int i = 0; i < n; i++)
        {
            if (vector[i] == k)
            {
                pozitie = i;
                break;
            }
        }

        Console.WriteLine($"Pozitia pe care apare k in vector este: {pozitie}");

        Console.ReadKey();
    }

    static void Problema3()
    {
        Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. \nPentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // determinare pozitii min si max
        int pozitieMin = 0;
        int pozitieMax = 0;

        for (int i = 1; i < n; i++)
        {
            if (vector[i] < vector[pozitieMin])
            {
                pozitieMin = i;
            }

            if (vector[i] > vector[pozitieMax])
            {
                pozitieMax = i;
            }
        }

        Console.WriteLine($"Pozitia pe care apare cel mai mic element din vector este: {pozitieMin}");
        Console.WriteLine($"Pozitia pe care apare cel mai mare element din vector este: {pozitieMax}");

        Console.ReadKey();
    }

    /*static void Problema4() {}

    static void Problema5() {}

    static void Problema6() {}

    static void Problema7() {}

    static void Problema8() {}

    static void Problema9() {}

    static void Problema10() {}

    static void Problema11() {}

    static void Problema12() {}

    static void Problema13() {}

    static void Problema14() {}

    static void Problema15() {}

    static void Problema16() {}

    static void Problema17() {}

    static void Problema18() {}

    static void Problema19() {}

    static void Problema20() {}

    static void Problema21() {}

    static void Problema22() {}

    static void Problema23() {}

    static void Problema24() {}

    static void Problema25() {}

    static void Problema26() {}

    static void Problema27() {}

    static void Problema28() {}

    static void Problema29() {}

    static void Problema30() {}

    static void Problema31() {}*/
}

