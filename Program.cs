using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("tell me your name:");
            //Console.WriteLine("Hello,"+ Console.ReadLine());
            //Console.WriteLine("Initiala:" + (char)Console.Read());
            /* Console.WriteLine(@"This is a string
                 with multiple Lines
                 of text");
             var a = 32.0;
             Console.WriteLine(a);
             a = 32.1;
             Console.WriteLine("dati middle name:");
             //string? middleName = Console.ReadLine();
             int b = 1;
             Int32 c = b;
             Console.Write("enter a integer:"); */

            //INT
            int a;
            a = 12;
            Console.WriteLine(a);

            Console.WriteLine("New value for a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Another value for a");
            string inputa = Console.ReadLine();

            if (int.TryParse(inputa, out int number))
                Console.Write(number);
            else
                Console.Write("Bad input");

            Console.WriteLine("Min value for a");
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine("Max value for a");
            Console.WriteLine(Int32.MaxValue);

            // DOUBLE
            double b;
            b = 13.5;
            Console.WriteLine(b);

            Console.WriteLine("New value for b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Another value for b:");
            string inputb = Console.ReadLine();

            if (double.TryParse(inputb, out double number1))
                Console.Write(number1);
            else
                Console.WriteLine("Bad input");

            Console.WriteLine("Min value for b:");
            Console.WriteLine(double.MinValue);
            Console.WriteLine("Max value for b:");
            Console.WriteLine(double.MaxValue);


            //byte
            byte c;
            c = 12;
            Console.WriteLine(c);

            Console.WriteLine("New value for c: ");
            c = byte.Parse(Console.ReadLine());

            Console.WriteLine("Another value for c:");
            string inputc = Console.ReadLine();
            if (byte.TryParse(inputc, out byte number2))
                Console.Write(number2);
            else
                Console.Write("Bad input");
            Console.WriteLine(" Min value for b");
            Console.WriteLine(Byte.MinValue);
            Console.WriteLine(" Max value for b");
            Console.WriteLine(Byte.MaxValue);

            //bool
            bool d;
            d = true;
            Console.WriteLine(d);

            Console.WriteLine("New value for d");
            string inputd = Console.ReadLine();

            if (bool.TryParse(inputd, out bool result))
                d = result;
            else
                Console.WriteLine("Bad input");

            Console.WriteLine("Another value for d");
            string Inputd = Console.ReadLine();

            if (bool.TryParse(Inputd, out bool anotherResult))
                Console.WriteLine(anotherResult);
            else
                Console.WriteLine("Bad input");


            //short
            short e;
            e = 12;
            Console.WriteLine(e);

            Console.WriteLine("New value for e: ");
            e = short.Parse(Console.ReadLine());

            Console.WriteLine("Another value for e:");
            string inpute = Console.ReadLine();
            if (short.TryParse(inpute, out short number3))
                Console.Write(number3);
            else
                Console.Write("Bad input");
            Console.WriteLine(" Min value for e");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(" Max value for e");
            Console.WriteLine(short.MaxValue);

            //long
            long f;
            f = 12;
            Console.WriteLine(f);

            Console.WriteLine("New value for f: ");
            f = long.Parse(Console.ReadLine());

            Console.WriteLine("Another value for f:");
            string inputf = Console.ReadLine();
            if (long.TryParse(inputf, out long number4))
                Console.Write(number4);
            else
                Console.Write("Bad input");
            Console.WriteLine(" Min value for f");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(" Max value for f");
            Console.WriteLine(long.MaxValue);


            //decimal
            decimal g;
            g = 12;
            Console.WriteLine(g);

            Console.WriteLine("New value for g: ");
            g = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Another value for g:");
            string inputg = Console.ReadLine();
            if (decimal.TryParse(inputg, out decimal number5))
                Console.Write(number5);
            else
                Console.Write("Bad input");
            Console.WriteLine(" Min value for f");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(" Max value for f");
            Console.WriteLine(decimal.MaxValue);

            //char 
            char h;
            h = 'i';
            Console.WriteLine(h);

            Console.WriteLine("New value for h: ");
            h = char.Parse(Console.ReadLine());

            Console.WriteLine("Another value for h:");
            string inputh = Console.ReadLine();
            if (char.TryParse(inputh, out char number6))
                Console.Write(number6);
            else
                Console.Write("Bad input");
            Console.WriteLine(" Min value for f");
            Console.WriteLine(char.MinValue);
            Console.WriteLine(" Max value for f");
            Console.WriteLine(char.MaxValue);
        }

    }
}

