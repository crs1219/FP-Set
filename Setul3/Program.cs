using System;

class Setul1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar intre 1 si 31 pentru a alege o problema: ");

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

            /*case 18:
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

    static void Problema4()
    {
        Console.WriteLine("Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");

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

        // determinare min si max
        int min = vector[0];
        int max = vector[0];

        for (int i = 1; i < n; i++)
        {
            if (vector[i] < min)
            {
                min = vector[i];   // elementul curent este mai mic decat minimul curent
            }

            if (vector[i] > max)
            {
                max = vector[i];   // elementul curent este mai mare decat maximul curent
            }

            if (vector[i] == min)
            {
                min = vector[i];   // elementul curent este egal cu minimul curent
            }

            if (vector[i] == max)
            {
                max = vector[i];   // elementul curent este egal cu maximul curent
            }
        }

        Console.WriteLine($"Cel mai mic element din vector este: {min}");
        Console.WriteLine($"Cel mai mare element din vector este: {max}");

        Console.ReadKey();
    }

    static void Problema5()
    {
        Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k. \nSe cere sa se insereze valoarea e in vector pe pozitia k. \nPrimul element al vectorului se considera pe pozitia zero. ");

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

        Console.WriteLine("Introduceti valoarea e: ");
        int e = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti pozitia k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (k < 0 || k > n)
        {
            Console.WriteLine("Pozitia k trebuie sa fie mai mare decat 0 si mai mica decat numarul de elemente din vector.");
            return;
        }

        // inserare valoare e in vector pe pozitia k
        int[] vectorNou = new int[n + 1];

        for (int i = 0; i < k; i++)
        {
            vectorNou[i] = vector[i];   // copiere elemente vector in vector nou pana la pozitia k
        }

        vectorNou[k] = e;   // inserare valoare e in vector nou pe pozitia k

        for (int i = k + 1; i < n + 1; i++)   // copiere elemente vector in vector nou de la pozitia k + 1
        {
            vectorNou[i] = vector[i - 1];   // elementele din vector nou de la pozitia k + 1 sunt egale cu elementele din vector de la pozitia k
        }

        // afisare vector nou
        Console.WriteLine("Vectorul nou este: ");

        for (int i = 0; i < n + 1; i++)
        {
            Console.Write($"{vectorNou[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema6()
    {
        Console.WriteLine("Se da un vector cu n elemente si o pozitie din vector k. \nSe cere sa se stearga din vector elementul de pe pozitia k. \nPrin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");

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

        Console.WriteLine("Introduceti pozitia k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (k < 0 || k > n)
        {
            Console.WriteLine("Pozitia k trebuie sa fie mai mare decat 0 si mai mica decat numarul de elemente din vector.");
            return;
        }

        // stergere element de pe pozitia k
        int[] vectorNou = new int[n - 1];

        for (int i = 0; i < k; i++)
        {
            vectorNou[i] = vector[i];   // copiere elemente vector in vector nou pana la pozitia k
        }

        for (int i = k; i < n - 1; i++)
        {
            vectorNou[i] = vector[i + 1];   // copiere elemente vector in vector nou de la pozitia k + 1
        }

        // afisare vector nou
        Console.WriteLine("Vectorul nou este: ");

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write($"{vectorNou[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema7()
    {
        Console.WriteLine("Reverse. Se da un vector nu n elemente. \nSe cere sa se inverseze ordinea elementelor din vector. \nPrin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");

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

        // inversare ordine elemente vector
        int[] vectorNou = new int[n];

        for (int i = 0; i < n; i++)
        {
            vectorNou[i] = vector[n - 1 - i];
        }

        // afisare vector nou
        Console.WriteLine("Vectorul nou este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vectorNou[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema8()
    {
        Console.WriteLine("Rotire. Se da un vector cu n elemente. \nRotiti elementele vectorului cu o pozitie spre stanga. \nPrin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");

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

        // rotire elemente vector spre stanga
        int[] vectorNou = new int[n];

        for (int i = 0; i < n - 1; i++)
        {
            vectorNou[i] = vector[i + 1];   // copiere elemente vector in vector nou de la pozitia i + 1
        }

        vectorNou[n - 1] = vector[0];

        // afisare vector nou
        Console.WriteLine("Vectorul nou este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vectorNou[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema9()
    {
        Console.WriteLine("Rotire k. Se da un vector cu n elemente. \nRotiti elementele vectorului cu k pozitii spre stanga. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
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

        // rotire elemente vector spre stanga cu k pozitii
        int[] vectorNou = new int[n];

        for (int i = 0; i < n - k; i++)
        {
            vectorNou[i] = vector[i + k];   // copiere elemente vector in vector nou de la pozitia i + k
        }

        for (int i = n - k; i < n; i++)
        {
            vectorNou[i] = vector[i - n + k];   // copiere elemente vector in vector nou de la pozitia i - n + k
        }

        // afisare vector nou
        Console.WriteLine("Vectorul nou este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vectorNou[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema10()
    {
        Console.WriteLine("Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. \nSe cere sa se determine pozitia unui element dat k. \nDaca elementul nu se gaseste in vector rezultatul va fi -1. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // cautare binara pozitie element k in vector
        int pozitie = -1;
        int stanga = 0;
        int dreapta = n - 1;

        while (stanga <= dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;   // mijlocul vectorului

            if (vector[mijloc] == k)
            {
                pozitie = mijloc;
                break;
            }

            if (vector[mijloc] < k)
            {
                stanga = mijloc + 1;   // elementul cautat este in dreapta mijlocului
            }

            if (vector[mijloc] > k)
            {
                dreapta = mijloc - 1;   // elementul cautat este in stanga mijlocului
            }
        }

        Console.WriteLine($"Pozitia pe care apare elementul k in vector este: {pozitie}");

        Console.ReadKey();
    }

    static void Problema11()
    {
        Console.WriteLine("Se da un numar natural n. \nSe cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul natural n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul natural n trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n + 1];

        // initializare vector cu valoarea 1
        for (int i = 0; i <= n; i++)
        {
            vector[i] = 1;
        }

        // ciurul lui Eratostene
        for (int i = 2; i <= n; i++)
        {
            if (vector[i] == 1)
            {
                for (int j = 2; j <= n / i; j++)   // j = 2, 3, 4, ..., n / i
                {
                    vector[i * j] = 0;   // elementele multiplu de i sunt egale cu 0
                }
            }
        }

        // afisare numere prime mai mici sau egale cu n
        Console.WriteLine("Numerele prime mai mici sau egale cu n sunt: ");

        for (int i = 2; i <= n; i++)
        {
            if (vector[i] == 1)
            {
                Console.Write($"{i} ");
            }
        }

        Console.ReadKey();
    }

    static void Problema12()
    {
        Console.WriteLine("Sortare selectie. \nImplementati algoritmul de sortare <Selection Sort>. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // sortare selectie
        for (int i = 0; i < n - 1; i++)
        {
            int minim = i;

            for (int j = i + 1; j < n; j++)
            {
                if (vector[j] < vector[minim])    // vector[j] > vector[minim] <=> vector[j] < vector[minim]
                {
                    minim = j;   // minimul curent este mai mare decat elementul curent
                }
            }

            int aux = vector[i];
            vector[i] = vector[minim];
            vector[minim] = aux;
        }

        // afisare vector sortat
        Console.WriteLine("Vectorul sortat este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vector[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema13()
    {
        Console.WriteLine("Sortare prin insertie. \nImplementati algoritmul de sortare <Insertion Sort>. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // sortare prin insertie
        for (int i = 1; i < n; i++)
        {
            int aux = vector[i];   // elementul curent
            int j = i - 1;      // pozitia elementului anterior

            while (j >= 0 && vector[j] > aux)    // vector[j] > aux <=> vector[j] < aux
            {
                vector[j + 1] = vector[j];   // elementul anterior este mai mare decat elementul curent
                j--;   // pozitia elementului anterior
            }

            vector[j + 1] = aux;
        }

        // afisare vector sortat
        Console.WriteLine("Vectorul sortat este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vector[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema14()
    {
        Console.WriteLine("Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // initializare vector cu valoarea 1
        for (int i = 0; i < n; i++)
        {
            vector[i] = 1;
        }

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // interschimbare elemente vector
        int pozitie = 0;

        for (int i = 0; i < n; i++)
        {
            if (vector[i] != 0)    // elementul curent este diferit de 0
            {
                int aux = vector[i];   // interschimbare elemente vector
                vector[i] = vector[pozitie];   // interschimbare elemente vector
                vector[pozitie] = aux;   // interschimbare elemente vector
                pozitie++;
            }
        }

        // afisare vector interschimbat
        Console.WriteLine("Vectorul interschimbat este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vector[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema15()
    {
        Console.WriteLine("Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // initializare vector cu valoarea 1
        for (int i = 0; i < n; i++)
        {
            vector[i] = 1;
        }

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // eliminare elemente vector care se repeta
        int pozitie = 0;

        for (int i = 0; i < n; i++)
        {
            if (vector[i] != 0)    // elementul curent este diferit de 0
            {
                int aux = vector[i];   // interschimbare elemente vector
                vector[i] = vector[pozitie];   // interschimbare elemente vector
                vector[pozitie] = aux;   // interschimbare elemente vector
                pozitie++;
            }
        }

        // afisare vector eliminat
        Console.WriteLine("Vectorul eliminat este: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{vector[i]} ");
        }

        Console.ReadKey();
    }

    static void Problema16()
    {
        Console.WriteLine("Se da un vector de n numere naturale. \nDeterminati cel mai mare divizor comun al elementelor vectorului.");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul de elemente din vector: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul de pozitii k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul de elemente din vector trebuie sa fie mai mare decat 0.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Numarul de pozitii k trebuie sa fie mai mare decat 0.");
            return;
        }

        // initializare vector
        int[] vector = new int[n];

        // initializare vector cu valoarea 1
        for (int i = 0; i < n; i++)
        {
            vector[i] = 1;
        }

        // preluare elemente vector
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din vector: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // determinare cel mai mare divizor comun al elementelor vectorului
        int c = vector[0];

        for (int i = 1; i < n; i++)
        {
            int a = c;
            int b = vector[i];

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;   // a > b <=> a - b > 0
                }
                else
                {
                    b = b - a;   // a < b <=> b - a > 0
                }
            }

            c = a;
        }

        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {c}");

        Console.ReadKey();
    }

    static void Problema17()
    {
        Console.WriteLine("Se da un numar n in baza 10 si un numar b. 1 < b < 17. \nSa se converteasca si sa se afiseze numarul n in baza b.   ");

        // preluare date de intrare
        Console.WriteLine("Introduceti numarul n in baza 10: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numarul b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // validare date de intrare
        if (n <= 0)
        {
            Console.WriteLine("Numarul n in baza 10 trebuie sa fie mai mare decat 0.");
            return;
        }

        if (b <= 0 || b >= 17)
        {
            Console.WriteLine("Numarul b trebuie sa fie mai mare decat 0 si mai mic decat 17.");
            return;
        }

        // conversie numar n in baza 10 in numar n in baza b
        int[] vector = new int[100];
        int i = 0;

        while (n != 0)
        {
            vector[i] = n % b;
            n = n / b;
            i++;
        }

        // afisare numar n in baza b
        Console.WriteLine($"Numarul n in baza b este: ");

        for (int j = i - 1; j >= 0; j--)   // j = i - 1, i - 2, ..., 0
        {
            if (vector[j] < 10)
            {
                Console.Write($"{vector[j]}");
            }
            else
            {
                Console.Write($"{(char)(vector[j] + 55)}");   // conversie numar in litera
            }
        }

        Console.ReadKey();
    }

    /*static void Problema18() { }

    static void Problema19() { }

    static void Problema20() { }

    static void Problema21() { }

    static void Problema22() { }

    static void Problema23() { }

    static void Problema24() { }

    static void Problema25() { }

    static void Problema26() { }

    static void Problema27() { }

    static void Problema28() { }

    static void Problema29() { }

    static void Problema30() { }

    static void Problema31() { }*/
}

