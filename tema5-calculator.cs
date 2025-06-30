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
    static void Main()
    {
        double memorie = 0;

        Console.WriteLine("Introduceti primul numar: ");
        string inputX=Console.ReadLine();
        double x = inputX == "MR" ? memorie : Convert.ToDouble(inputX);

        Console.WriteLine("Introduceti al doilea numar: ");
        string inputY = Console.ReadLine();
        double y = inputX == "MR" ? memorie : Convert.ToDouble(inputY);

        while (true)
        {

            Console.WriteLine("Alege operatia: ");
            string operatie = Console.ReadLine();

            double rezultat = 0;
            bool validareOperatie = true;

            switch (operatie)
            {
                case "+":
                    rezultat = x + y; break;
                case "-":
                    rezultat = x - y; break;
                case "*":
                    rezultat = x * y; break;
                case "/":
                    if (y != 0)
                    {
                        rezultat = x / y;
                    }
                    else
                    {
                        Console.WriteLine("Imposibila impartirea la 0!");
                        validareOperatie = false;
                    }
                    break;
                case "%":
                    if (y != 0)
                    {
                        rezultat = x % y;
                    }
                    else
                    {
                        Console.WriteLine("Imposibil restul impartirii la 0!");
                        validareOperatie = false;
                    }
                    break;
                case "^":
                    int exp = (int)y;
                    rezultat = Putere(x, exp);
                    break;
                default:
                    Console.WriteLine("Operatie necunoscuta!");
                    validareOperatie = false;
                    break;

            }
            if (validareOperatie)
            {
                Console.WriteLine($"Rezultat: {x} {operatie} {y} = {rezultat}");

                Console.WriteLine("Salvati rezultatul in memeorie?(da/nu):");
                if (Console.ReadLine() == "da")
                {
                    memorie = rezultat;
                    Console.WriteLine($"Rezultatul {rezultat} a fost salvat in memorie.");
                }
            }
            Console.Write("Alta operatie?(da/nu): ");
            string alegere = Console.ReadLine();

            if (alegere != "da")
            {
                Console.WriteLine("Sfarsit!");
                break;

            }
            Console.WriteLine("Introduceti primul numar (sau 'MR'): ");
            inputX = Console.ReadLine();
            x = inputX == "MR" ? memorie : Convert.ToDouble(inputX);

            Console.WriteLine("Introduceti al doilea numar (sau 'MR'): ");
            inputY = Console.ReadLine();
            y = inputY == "MR" ? memorie : Convert.ToDouble(inputY);

        }
       
    }
}