using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Tema_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* byte a;
             a = 15;
             Console.WriteLine(a);
             Console.WriteLine("New value for a: ");
             a = byte.Parse(Console.ReadLine());
             Console.WriteLine("Another value for a: ");
             string? input = Console.ReadLine();
             if (byte.TryParse(input, out byte number))
                 Console.Write(number);
             else
                 Console.Write("Bad input");
             Console.WriteLine(" Min value for a");
             Console.WriteLine(Byte.MinValue);
             Console.WriteLine(" Max value for a");
             Console.WriteLine(Byte.MaxValue);


             sbyte b;
             b = 25;
             Console.WriteLine(b);
             Console.WriteLine("New value for b: ");
             b = sbyte.Parse(Console.ReadLine());
             Console.WriteLine("Another value for b: ");
             string? input1 = Console.ReadLine();
             if (sbyte.TryParse(input1, out sbyte number1))
                 Console.Write(number1);
             else
                 Console.Write("Bad input");
             Console.WriteLine("Min value for b ");
             Console.WriteLine(SByte.MinValue);
             Console.WriteLine("Max value for b ");
             Console.WriteLine(SByte.MaxValue);


             short s;
             s = -67;
             Console.WriteLine(s);
             Console.WriteLine("New value for s: ");
             s = short.Parse(Console.ReadLine());
             Console.WriteLine("Another value for s: ");
             string? input2 = Console.ReadLine();
             if (short.TryParse(input2, out short number2))
                 Console.Write(number2);
             else
                 Console.Write("Bad input");
             Console.WriteLine("Min value for s");
             Console.WriteLine(Int16.MinValue);
             Console.WriteLine("Max value for s");
             Console.WriteLine(Int16.MaxValue);


             ushort u;
             u = 38;
             Console.WriteLine(u);
             Console.WriteLine("New value for u: ");
             u = ushort.Parse(Console.ReadLine());
             Console.WriteLine("Another value for u: ");
             string? input3 = Console.ReadLine();
             if (ushort.TryParse(input3, out ushort number3))
                 Console.WriteLine(number3);
             else
                 Console.Write("Bad input");
             Console.WriteLine("Min value for u");
             Console.WriteLine(UInt16.MinValue);
             Console.WriteLine("Max value for u");
             Console.WriteLine(UInt16.MaxValue);
            

            uint c;
            c = 156;
            Console.WriteLine(c);
            Console.WriteLine("New value for c: ");
            c = uint.Parse(Console.ReadLine());
            Console.WriteLine("Another value for c: ");
            string? input4 = Console.ReadLine();
            if (uint.TryParse(input4, out uint number4))
                Console.Write(number4);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for c");
            Console.WriteLine(UInt16.MinValue);
            Console.WriteLine("Max value for c");
            Console.WriteLine(UInt16.MaxValue);
            

            long l;
            l = 55;
            Console.WriteLine(l);
            Console.WriteLine("New value for l: ");
            l = long.Parse(Console.ReadLine());
            Console.WriteLine("Another value for l:");
            string? input5 = Console.ReadLine();
            if (long.TryParse(input5, out long number5))
                Console.Write(number5);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for l");
            Console.WriteLine(Int64.MinValue);
            Console.WriteLine("Max value for l");
            Console.WriteLine(Int64.MaxValue);
            

            ulong d;
            d = 14;
            Console.WriteLine(d);
            Console.WriteLine("New value for d: ");
            d = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Another value for d:");
            string? input6 = Console.ReadLine();
            if (ulong.TryParse(input6, out ulong number6))
                Console.Write(number6);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for d");
            Console.WriteLine(UInt64.MinValue);
            Console.WriteLine("Max value for d");
            Console.WriteLine(UInt64.MaxValue);
            

            float f;
            f = 32.5f;
            Console.WriteLine(f);
            Console.WriteLine("New value for f: ");
            f = float.Parse(Console.ReadLine());
            Console.WriteLine("Another value for f: ");
            string? input7 = Console.ReadLine();
            if (float.TryParse(input7, out float number7))
                Console.Write(number7);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for f");
            Console.WriteLine(Single.MinValue);
            Console.WriteLine("Max value for f");
            Console.WriteLine(Single.MaxValue);
           

            double x;
            x = 45.8;
            Console.WriteLine(x);
            Console.WriteLine("New value for x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Another value for x: ");
            string? input8 = Console.ReadLine();
            if (double.TryParse(input8, out double number8))
                Console.Write(number8);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for x");
            Console.WriteLine(Double.MinValue);
            Console.WriteLine("Max value for x");
            Console.WriteLine(Double.MaxValue);
            

            decimal y;
            y = 1.2M;
            Console.WriteLine(y);
            Console.WriteLine("New value for y: ");
            y = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Another value for y");
            string? input9 = Console.ReadLine();
            if (decimal.TryParse(input9, out decimal number9))
                Console.Write(number9);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for y");
            Console.WriteLine(Decimal.MinValue);
            Console.WriteLine("Max value for y");
            Console.WriteLine(Decimal.MaxValue);
            

            bool z;
            z= false;
            Console.WriteLine(z);
            Console.WriteLine("New value for z: ");
            z = bool.Parse(Console.ReadLine());
            Console.WriteLine("Another value for z");
            string? input10 = Console.ReadLine();
            if (bool.TryParse(input10, out bool number10))
                Console.Write(number10);
            else
                Console.Write("Bad input");
            Console.WriteLine("Min value for z");
            Console.WriteLine(false);
            Console.WriteLine("Max value for z");
            Console.WriteLine(true);
            */

            char q;
            q = 'B';
            Console.WriteLine(q);
            Console.WriteLine("New value for q:");
            q = char.Parse(Console.ReadLine());
            Console.WriteLine("Another value for q:");
            string? input11= Console.ReadLine();
            if (char.TryParse(input11, out char number11))
                Console.WriteLine(number11);
            else
                Console.WriteLine("Bad input");
            Console.WriteLine("Min value for q");
            Console.WriteLine(char.MinValue);
            Console.WriteLine("Max value for q");
            Console.WriteLine(char.MaxValue);

        }

    }
}