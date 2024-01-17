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

            default:
                Console.WriteLine("Optiune invalida.");
                break;
        }
    }

    static void Problema1()
    {
        Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numar a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti numarul b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (!(a == 0))
        {
            double x = -b / a;
            Console.WriteLine($"Solutia ecuatiei {a}x + {b} = 0 este x = {x}");
        }
        else   // a == 0
        {
            Console.WriteLine("Eroare. Introduceti un primul numar diferit de 0.");
        }

        Console.ReadKey();
    }

    static void Problema2()
    {
        Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. \nTratati toate cazurile posibile.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti coeficientul a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti coeficientul b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti coeficientul c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        //validam datele de intrare
        if (a == 0)
        {
            Console.WriteLine("Eroare. Introduceti un primul numar diferit de 0.");
            return;
        }

        double delta = b * b - 4 * a * c;   // calculam delta

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Ecuatia are 2 valori reale distincte: x1 = {x1} si x2 = {x2}.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Ecuatia are o singura valoare reala: x = {x}.");
        }
        else  // delta < 0
        {
            double parteReala = -b / (2 * a);
            double parteImaginara = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine($"Solutia are 2 solutii complexe conjugate: x1 = {parteReala} + {parteImaginara}i si x2 = {parteReala} - {parteImaginara}i.");
        }

        Console.ReadKey();
    }

    static void Problema3()
    {
        Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti primul numar: ");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea  numar: ");
        double k = Convert.ToDouble(Console.ReadLine());

        // validam datele de intrare
        if (k == 0)
        {
            Console.WriteLine("Eroare. Introduceti un al doilea numar diferit de 0.");
            return;
        }

        if (n % k == 0)
        {
            Console.WriteLine($"Numarul {n} se divide cu numarul {k}.");
        }
        else   // n % k != 0
        {
            Console.WriteLine($"Numarul {n} nu se divide cu numarul {k}.");
        }

        Console.ReadKey();
    }

    static void Problema4()
    {
        Console.WriteLine("Determinati daca un an y este an bisect.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un an: ");
        int an = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (an < 0)
        {
            Console.WriteLine("Eroare. Introduceti un an pozitiv.");
            return;
        }

        if (an % 4 == 0 && an % 100 == 0)   // anul este divizibil cu 4 si cu 100
        {
            Console.WriteLine($"Anul {an} este an bisect.");
        }
        else if (an % 400 == 0)   // anul este divizibil cu 400
        {
            Console.WriteLine($"Anul {an} este an bisect.");
        }
        else   // anul nu este divizibil cu 4 si cu 100 sau cu 400
        {
            Console.WriteLine($"Anul {an} nu este an bisect.");
        }

        Console.ReadKey();
    }

    static void Problema5()
    {
        Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. \nCifrele se numara de la dreapta la stanga. \nAtentie! k este mai mic sau egal decat numarul de cifre al numarului.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un numar: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti pozitia dorita 'k': ");
        int k = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (numar < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        if (k <= 0)
        {
            Console.WriteLine("Pozitia trebuie sa fie un numar pozitiv.");
        }
        else  // k > 0
        {
            int cifra = ExtrageCifra(numar, k);

            Console.WriteLine($"Cifra de la pozitia {k} de la sfarsitul numarului {numar}, de la dreapta la stanga este: {cifra}.");
        }

        static int ExtrageCifra(int numar, int k)   // functia care extrage cifra de la pozitia k
        {
            int start = 0;   // pozitia curenta

            while (numar > 0)
            {
                start++;

                if (start == k)   // daca pozitia curenta este egala cu k
                {
                    return numar % 10;   // returnam cifra de la pozitia k
                }

                numar /= 10;   // eliminam ultima cifra
            }

            return -1;   // daca nu exista cifra de la pozitia k, returnam -1
        }

        Console.ReadKey();
    }

    static void Problema6()
    {
        Console.WriteLine("Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un numar pozitiv a: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti un numar pozitiv b: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti un numar pozitiv c: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        if (a1 < 0 || b1 < 0 || c1 < 0)   // daca cel putin un numar este negativ
        {
            Console.WriteLine("Introduceti doar numere pozitive!");
        }
        else   // a1, b1 si c1 sunt pozitive
        {
            Console.WriteLine(EsteTriunghi(a1, b1, c1));
        }

        static string EsteTriunghi(double a1, double b1, double c1)   // functia care determina daca a1, b1 si c1 pot fi lungimile laturilor unui triunghi
        {
            if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
            {
                return $"Numerele {a1}, {b1} si {c1} formeaza un triunghi.";
            }
            else   // a1 + b1 <= c1 || a1 + c1 <= b1 || b1 + c1 <= a1
            {
                return $"Numerele {a1}, {b1} si {c1} nu formeaza un triunghi.";
            }
        }

        Console.ReadKey();
    }

    static void Problema7()
    {
        Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. \nSe cere sa se inverseze valorile lor.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un numar a: ");
        double nrA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduceti un numar b: ");
        double nrB = Convert.ToDouble(Console.ReadLine());

        //validam datele de intrare
        if (nrA == nrB)
        {
            Console.WriteLine("Numerele trebuie sa fie diferite.");
            return;
        }

        Console.WriteLine($"Valorile initiale: a = {nrA}, b = {nrB}");

        // inversam valorile
        double inversA = nrB;
        double inversB = nrA;

        Console.WriteLine($"Valorile inversate: a = {inversA}, b = {inversB}");

        Console.ReadKey();
    }

    static void Problema8()
    {
        Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. \nSe cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un numar a: ");
        int nr1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti un numar b: ");
        int nr2 = Convert.ToInt32(Console.ReadLine());

        //validam datele de intrare
        if (nr1 == nr2)
        {
            Console.WriteLine("Numerele trebuie sa fie diferite.");
            return;
        }

        Console.WriteLine($"Valorile initiale: a = {nr1}, b = {nr2}");

        // inversam valorile
        nr1 = nr1 ^ nr2;
        nr2 = nr1 ^ nr2;
        nr1 = nr1 ^ nr2;

        Console.WriteLine($"Dupa swap: a = {nr1}, b = {nr2}");

        Console.ReadKey();
    }

    static void Problema9()
    {
        Console.WriteLine("Afisati toti divizorii numarului n. ");

        // preluam datele de intrare
        Console.WriteLine("Introduceti un numar pozitiv: ");

        // validam datele de intrare
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)    // daca n nu este numar intreg sau este negativ
        {
            Console.WriteLine("Introducere invalida.");
            return;
        }

        Console.WriteLine($"Divizorii lui {n} sunt: ");

        for (int i = 1; i <= n; i++)   // parcurgem numerele de la 1 la n
        {
            if (n % i == 0)   // daca i este divizor al lui n
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }

    static void Problema10()
    {
        Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (n < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        if (EstePrim(n))
        {
            Console.WriteLine($"Numarul {n} este prim.");
        }
        else   // n nu este prim
        {
            Console.WriteLine($"Numarul {n} nu este prim.");
        }

        static bool EstePrim(int n)   // functia care determina daca n este prim
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)   // parcurgem numerele de la 2 la radical din n
            {
                if (n % i == 0)   // daca i este divizor al lui n
                {
                    return true;
                }
            }

            return false;   // daca n nu are divizori, returnam false
        }

        Console.ReadKey();
    }

    static void Problema11()
    {
        Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (number < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        Console.WriteLine($"Cifrele numarului {number} in ordine inversa sunt: ");

        AfiseazaNumarInvers(number);   // apelam functia care afiseaza numarul invers

        static void AfiseazaNumarInvers(int number)   // functia care afiseaza numarul invers
        {
            while (number > 0)   // cat timp mai avem cifre
            {
                int cifrA = number % 10;   // extragem ultima cifra
                Console.Write(cifrA + " ");   // afisam cifra

                number /= 10;   // eliminam ultima cifra
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }

    static void Problema12()
    {
        Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numerele n, a si b: ");

        Console.Write("n= ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("a= ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("b= ");
        int B = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (N < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        if (A > B)
        {
            Console.WriteLine("Primul numar trebuie sa fie mai mic decat al doilea.");
            return;
        }

        int numarDiv = NumarDeDiv(N, A, B);   // apelam functia care determina numarul de numere divizibile cu N in intervalul [A, B]

        Console.WriteLine($"Numarul de numere divizibile cu {N} in intervalul [{A}, {B}] este: {numarDiv}");

        static int NumarDeDiv(int N, int A, int B)   // functia care determina numarul de numere divizibile cu N in intervalul [A, B]
        {
            int numarDiv = 0;   // numarul de numere divizibile cu N in intervalul [A, B]

            for (int i = A; i <= B; i++)   // parcurgem numerele de la A la B
            {
                if (i % N == 0)   // daca i este divizibil cu N
                {
                    numarDiv++;   // incrementam numarul de numere divizibile cu N
                }
            }
            return numarDiv;   // returnam numarul de numere divizibile cu N in intervalul [A, B]
        }

        Console.ReadKey();
    }

    static void Problema13()
    {
        Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti anii: ");

        Console.Write("y1: ");
        int anul1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("y2: ");
        int anul2 = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (anul1 < 0 || anul2 < 0)
        {
            Console.WriteLine("Anii trebuie sa fie pozitivi.");
            return;
        }

        if (anul1 > anul2)
        {
            Console.WriteLine("Primul an trebuie sa fie mai mic decat al doilea.");
            return;
        }

        int numarAniBis = NumarAniBis(anul1, anul2);   // apelam functia care determina numarul de ani bisecti intre anul1 si anul2

        Console.WriteLine($"Numarul de ani bisecti intre anii {anul1} si {anul2} sunt: {numarAniBis}.");

        // functia care determina numarul de ani bisecti intre anul1 si anul2
        static int NumarAniBis(int anul1, int anul2)
        {
            int numarAniBis = 0;   // numarul de ani bisecti intre anul1 si anul2, incepem cu 0

            for (int an = anul1; an <= anul2; an++)   // parcurgem anii de la anul1 la anul2
            {
                if (EsteAnBis(an))
                {
                    numarAniBis++;
                }
            }

            return numarAniBis;   // returnam numarul de ani bisecti intre anul1 si anul2
        }

        static bool EsteAnBis(int an)   // functia care determina daca anul este bisect
        {
            return (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);   // anul este bisect daca este divizibil cu 4 si nu este divizibil cu 100 sau este divizibil cu 400
        }

        Console.ReadKey();
    }

    static void Problema14()
    {
        Console.WriteLine("Determinati daca un numar n este palindrom. \n(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (EstePalindrom(num))
        {
            Console.WriteLine($"Numarul {num} este palindrom.");
        }
        else
        {
            Console.WriteLine($"Numarul {num} nu este palindrom.");
        }

        static bool EstePalindrom(int num)   // functia care determina daca numarul este palindrom
        {
            int invers = 0;   // numarul inversat
            int copie = num;   // copia numarului

            while (copie > 0)   // cat timp mai avem cifre
            {
                int cifra = copie % 10;   // extragem ultima cifra
                invers = invers * 10 + cifra;   // adaugam cifra la numarul inversat
                copie /= 10;    // eliminam ultima cifra
            }

            return invers == num;   // returnam true daca numarul inversat este egal cu numarul initial
        }

        Console.ReadKey();
    }

    static void Problema15()
    {
        Console.WriteLine("Se dau 3 numere. \nSa se afiseze in ordine crescatoare.");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numerele: ");

        Console.Write("a= ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b= ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c= ");
        int c = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (a == b && b == c)
        {
            Console.WriteLine("Numerele trebuie sa fie diferite.");
            return;
        }

        if (a < b && a < c)    // a este cel mai mic
        {
            if (b < c)   // b este al doilea cel mai mic
            {
                Console.WriteLine($"{a} {b} {c}");
            }
            else    // c este al doilea cel mai mic
            {
                Console.WriteLine($"{a} {c} {b}");
            }
        }
        else if (b < a && b < c)    // b este cel mai mic
        {
            if (a < c)    // a este al doilea cel mai mic
            {
                Console.WriteLine($"{b} {a} {c}");
            }
            else     // c este al doilea cel mai mic
            {
                Console.WriteLine($"{b} {c} {a}");
            }
        }
        else    // c este cel mai mic
        {
            if (a < b)   // a este al doilea cel mai mic
            {
                Console.WriteLine($"{c} {a} {b}");
            }
            else    // b este al doilea cel mai mic
            {
                Console.WriteLine($"{c} {b} {a}");
            }
        }

        Console.ReadKey();
    }

    static void Problema16()
    {
        Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. \n(nu folositi tablouri)");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numerele: ");

        Console.Write("a= ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b= ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c= ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("d= ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.Write("e= ");
        int e = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (a == b && b == c && c == d && d == e)
        {
            Console.WriteLine("Numerele trebuie sa fie diferite.");
            return;
        }

        if (a < b && a < c && a < d && a < e)
        {
            if (b < c && b < d && b < e)
            {
                if (c < d && c < e)
                {
                    if (d < e)
                    {
                        Console.WriteLine($"{a} {b} {c} {d} {e}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {b} {c} {e} {d}");
                    }
                }
                else if (d < c && d < e)
                {
                    if (c < e)
                    {
                        Console.WriteLine($"{a} {b} {d} {c} {e}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {b} {d} {e} {c}");
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine($"{a} {b} {e} {c} {d}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {b} {e} {d} {c}");
                    }
                }
            }
            else if (c < b && c < d && c < e)
            {
                if (b < d && b < e)
                {
                    if (d < e)
                    {
                        Console.WriteLine($"{a} {c} {b} {d} {e}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {c} {b} {e} {d}");
                    }
                }
                else if (d < b && d < e)
                {
                    if (b < e)
                    {
                        Console.WriteLine($"{a} {c} {d} {b} {e}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {c} {d} {e} {b}");
                    }
                }
                else
                {
                    if (b < d)
                    {
                        Console.WriteLine($"{a} {c} {e} {b} {d}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {c} {e} {d} {b}");
                    }
                }
            }
            else if (d < b && d < c && d < e)
            {
                if (b < c && b < e)
                {
                    if (c < e)
                    {
                        Console.WriteLine($"{a} {d} {b} {c} {e}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {d} {b} {e} {c}");
                    }
                }
            }
            else
            {
                if (b < d)
                {
                    Console.WriteLine($"{a} {e} {b} {d} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {e} {b} {c} {d}");
                }
            }

            Console.ReadKey();
        }
    }

    static void Problema17()
    {
        Console.WriteLine("Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. \nFolositi algoritmul lui Euclid.");

        // preluam datele de intrare
        Console.WriteLine("Introduceți două numere pentru a calcula CMMD și CMMMC:");

        Console.Write("Introduceți primul număr: ");
        int nr1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceți al doilea număr: ");
        int nr2 = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (nr1 == 0 && nr2 == 0)
        {
            Console.WriteLine("Cel putin un numar trebuie sa fie diferit de 0.");
            return;
        }

        // calculam CMMD si CMMMC
        int cmmdc = CalculCMMD(nr1, nr2);
        int cmmmc = CalculCMMMC(nr1, nr2);

        Console.WriteLine($"CMMD({nr1}, {nr2}) = {cmmdc}");
        Console.WriteLine($"CMMMC({nr1}, {nr2}) = {cmmmc}");

        static int CalculCMMD(int nr1, int nr2)   // functia care calculeaza CMMD
        {
            while (nr1 != nr2)   // cat timp cele doua numere sunt diferite
            {
                if (nr1 > nr2)   // scadem numarul mai mare din cel mai mic
                {
                    nr1 -= nr2;    // nr1 = nr1 - nr2
                }
                else   // nr2 > nr1
                {
                    nr2 -= nr1;   // nr2 = nr2 - nr1
                }

                return nr1;   // returnam CMMD
            }

            return nr1;   // returnam CMMD
        }

        static int CalculCMMMC(int nr1, int nr2)   // functia care calculeaza CMMMC
        {
            return nr1 * nr2 / CalculCMMD(nr1, nr2);    // returnam CMMMC
        }

        Console.ReadKey();
    }

    static void Problema18()
    {
        Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n. \nDe ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (numar < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        Console.WriteLine($"Descompunerea in factori primi ai numarului {numar} este: ");

        int factor = 2;   // factorul prim

        while (numar > 1)   // cat timp mai avem numere de descompus
        {
            int putere = 0;   // puterea factorului prim, initial 0

            while (numar % factor == 0)   // cat timp factorul prim divide numarul
            {
                putere++;   // incrementam puterea
                numar /= factor;   // eliminam factorul prim
            }

            if (putere > 0)   // daca puterea este mai mare decat 0
            {
                Console.WriteLine($"{factor}^{putere}");
            }

            factor++;   // trecem la urmatorul factor prim
        }

        Console.ReadKey();
    }

    static void Problema19()
    {
        Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. \nDe ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int numbr = int.Parse(Console.ReadLine());

        // validam datele de intrare
        if (numbr < 0)
        {
            Console.WriteLine("Numarul trebuie sa fie pozitiv.");
            return;
        }

        if (EsteFormatDin2Cifre(numbr))   // daca numarul este format doar cu 2 cifre care se pot repeta
        {
            Console.WriteLine($"Numarul {numbr} este format doar cu 2 cifre care se pot repeta.");
        }
        else   // numarul nu este format doar cu 2 cifre care se pot repeta
        {
            Console.WriteLine($"Numarul {numbr} este format doar cu 2 cifre care se pot repeta.");
        }

        static bool EsteFormatDin2Cifre(int numbr)   // functia care determina daca numarul este format doar cu 2 cifre care se pot repeta
        {
            int cifra1 = numbr % 10;   // ultima cifra
            numbr /= 10;   // eliminam ultima cifra

            int cifra2 = numbr % 10;   // penultima cifra
            numbr /= 10;   // eliminam penultima cifra

            while (numbr > 0)   // cat timp mai avem cifre
            {
                int cifra = numbr % 10;   // extragem ultima cifra

                if (cifra != cifra1 && cifra != cifra2)   // daca cifra nu este egala cu cifra1 si nici cu cifra2
                {
                    return false;   // returnam false
                }

                numbr /= 10;   // eliminam ultima cifra

                return true;   // returnam true
            }

            return false;   // returnam false
        }

        Console.ReadKey();
    }

    static void Problema20()
    {
        Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). \nExemplu: 13/30 = 0.4(3). \nO fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0.\nO fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.\nO fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. ");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numaratorul: ");
        int numarator = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduceti numitorul: ");
        int numitor = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (numitor == 0)
        {
            Console.WriteLine("Numitorul trebuie sa fie diferit de 0.");
            return;
        }

        if (numitor < 0)
        {
            Console.WriteLine("Numitorul trebuie sa fie pozitiv.");
            return;
        }

        Console.WriteLine($"Fractia {numarator}/{numitor} este: ");

        int parteIntreaga = numarator / numitor;   // partea intreaga
        numarator %= numitor;   // restul

        Console.Write(parteIntreaga + ".");   // afisam partea intreaga
        Console.Write("(");   // afisam paranteza deschisa

        int pozitieVirgula = 0;   // pozitia virgulei, initial 0
        int[] resturi = new int[numitor];   // vectorul de resturi

        while (numarator != 0 && resturi[numarator] == 0)   // cat timp numaratorul este diferit de 0 si restul nu se repeta
        {
            resturi[numarator] = pozitieVirgula;   // adaugam restul in vectorul de resturi
            numarator *= 10;   // inmultim numaratorul cu 10

            while (numarator < numitor)   // cat timp numaratorul este mai mic decat numitorul
            {
                numarator *= 10;    // inmultim numaratorul cu 10
                pozitieVirgula++;     // incrementam pozitia virgulei

                Console.Write("0");
            }

            Console.Write(numarator / numitor);   // afisam catul impartirii
            numarator %= numitor;   // restul
            pozitieVirgula++;   // incrementam pozitia virgulei
        }

        Console.Write(")");   // afisam paranteza inchisa

        if (numarator == 0)   // daca numaratorul este 0
        {
            Console.WriteLine("Fractia este zecimala.");
        }
        else if (EsteNeperiodica(numitor))   // daca numitorul este neperiodic
        {
            Console.WriteLine("Fractia este neperiodica.");
        }
        else if (EstePeriodicaSimpla(numitor))   // daca numitorul este periodic simplu
        {
            Console.WriteLine("Fractia este periodica simpla.");
        }
        else   // numitorul este periodic mixt
        {
            Console.WriteLine("Fractia este periodica mixta.");
        }

        static bool EsteNeperiodica(int numitor)   // functia care determina daca numitorul este neperiodic
        {
            while (numitor % 2 == 0)   // cat timp numitorul se divide cu 2
            {
                numitor /= 2;   // eliminam factorul 2
            }

            while (numitor % 5 == 0)   // cat timp numitorul se divide cu 5
            {
                numitor /= 5;   // eliminam factorul 5
            }

            return numitor == 1;   // returnam true daca numitorul este 1
        }

        static bool EstePeriodicaSimpla(int numitor)   // functia care determina daca numitorul este periodic simplu
        {
            return !EsteNeperiodica(numitor);   // returnam true daca numitorul nu este neperiodic
        }

        static bool EstePeriodicaMixta(int numitor)   // functia care determina daca numitorul este periodic mixt
        {
            return !EsteNeperiodica(numitor) && !EstePeriodicaSimpla(numitor);   // returnam true daca numitorul nu este neperiodic si nu este periodic simplu
        }

        Console.ReadKey();
    }

    static void Problema21()
    {
        Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma : numarul este mai mare sau egal decat x?");

        // preluam datele de intrare
        Console.WriteLine("Introduceti numarul: ");
        int numar = Convert.ToInt32(Console.ReadLine());

        // validam datele de intrare
        if (numar < 1 || numar > 1024)
        {
            Console.WriteLine("Numarul trebuie sa fie intre 1 si 1024.");
            return;
        }

        // algoritmul de cautare binara
        int min = 1;
        int max = 1024;

        while (true)  // cat timp nu am gasit numarul
        {
            int mijloc = (min + max) / 2;   // mijlocul intervalului

            if (numar == mijloc)   // daca numarul este mijlocul intervalului
            {
                Console.WriteLine($"Numarul este {mijloc}.");
                break;   // iesim din while
            }
            else if (numar > mijloc)   // daca numarul este mai mare decat mijlocul intervalului
            {
                Console.WriteLine($"Numarul este mai mare sau egal decat {mijloc}?");
                string raspuns = Console.ReadLine();   // citim raspunsul

                if (raspuns == "da")   // daca raspunsul este da
                {
                    min = mijloc + 1;   // minimul devine mijlocul + 1
                }
                else   // raspunsul este nu
                {
                    max = mijloc - 1;   // maximul devine mijlocul - 1
                }
            }
            else   // numarul este mai mic decat mijlocul intervalului
            {
                Console.WriteLine($"Numarul este mai mic sau egal decat {mijloc}?");
                string raspuns = Console.ReadLine();   // citim raspunsul

                if (raspuns == "da")   // daca raspunsul este da
                {
                    max = mijloc - 1;   // maximul devine mijlocul - 1
                }
                else   // raspunsul este nu
                {
                    min = mijloc + 1;   // minimul devine mijlocul + 1
                }
            }
        }

        Console.ReadKey();
    }
}
