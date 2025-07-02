using System;

class Calculator
{
    static double Putere(double b, int exp)
    {
        double rezultat = 1;
        for (int i = 0; i < exp; i++)
        {
            rezultat *= b;
        }
        return rezultat;
    }

    static double CitesteNumar(double memorie, string mesaj)
    {
        Console.WriteLine(mesaj);
        string input = Console.ReadLine();
        return input == "MR" ? memorie : Convert.ToDouble(input);
    }

    static double ExecutaOperatie(double x, double y, string operatie, out bool operatieValida)
    {
        operatieValida = true;
        double rezultat = 0;
        switch (operatie)
        {
            case "+":
                rezultat = x + y;
                break;
            case "-":
                rezultat = x - y;
                break;
            case "*":
                rezultat = x * y;
                break;
            case "/":
                if (y != 0)
                    rezultat = x / y;
                else
                {
                    Console.WriteLine("Imposibila impartirea la 0!");
                    operatieValida = false;
                }
                break;
            case "%":
                if (y != 0)
                    rezultat = x % y;
                else
                {
                    Console.WriteLine("Imposibil restul impartirii la 0!");
                    operatieValida = false;
                }
                break;
            case "^":
                int exp = (int)y;
                rezultat = Putere(x, exp);
                break;
            default:
                Console.WriteLine("Operatie necunoscuta!");
                operatieValida = false;
                break;
        }
        return rezultat;
    }

    static bool SalveazaInMemorie(double rezultat, ref double memorie)
    {
        Console.WriteLine("Salvati rezultatul in memorie?(da/nu):");
        string raspuns = Console.ReadLine();
        if (raspuns == "da")
        {
            memorie = rezultat;
            Console.WriteLine($"Rezultatul {rezultat} a fost salvat in memorie.");
            return true;
        }
        return false;
    }

    static bool IntreabaAltaOperatie()
    {
        Console.Write("Alta operatie?(da/nu): ");
        string raspuns = Console.ReadLine();
        return raspuns == "da";
    }

    static void Main()
    {
        double memorie = 0;

        double x = CitesteNumar(memorie, "Introduceti primul numar (sau 'MR'): ");
        double y = CitesteNumar(memorie, "Introduceti al doilea numar (sau 'MR'): ");

        while (true)
        {
            Console.WriteLine("Alege operatia: ");
            string operatie = Console.ReadLine();

            bool operatieValida;
            double rezultat = ExecutaOperatie(x, y, operatie, out operatieValida);

            if (operatieValida)
            {
                Console.WriteLine($"Rezultat: {x} {operatie} {y} = {rezultat}");
                SalveazaInMemorie(rezultat, ref memorie);
            }

            if (!IntreabaAltaOperatie())
            {
                Console.WriteLine("Sfarsit!");
                break;
            }

            x = CitesteNumar(memorie, "Introduceti primul numar (sau 'MR'): ");
            y = CitesteNumar(memorie, "Introduceti al doilea numar (sau 'MR'): ");
        }
    }
}
