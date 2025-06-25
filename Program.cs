// See https://aka.ms/new-console-template for more information
//byte
byte b;
b = 13;
Console.WriteLine(b);
Console.WriteLine("New value for b: ");
b = byte.Parse(Console.ReadLine());
Console.WriteLine("Another value for b:");
string? input1 = Console.ReadLine();
if (byte.TryParse(input1, out byte number1))
    Console.Write(number1);
else
    Console.Write("Bad input");
Console.WriteLine(" Min value for b");
Console.WriteLine(Byte.MinValue);
Console.WriteLine(" Max value for b");
Console.WriteLine(Byte.MaxValue);


//sbyte
sbyte c;
c = 14;
Console.WriteLine(c);
Console.WriteLine("New value for c: ");
c = sbyte.Parse(Console.ReadLine());
Console.WriteLine("Another value for c:");
string? input2 = Console.ReadLine();
if (sbyte.TryParse(input2, out sbyte number2))
    Console.Write(number2);
else
    Console.Write("Bad input");
Console.WriteLine(" Min value for c");
Console.WriteLine(sbyte.MinValue);
Console.WriteLine(" Max value for c");
Console.WriteLine(sbyte.MaxValue);


//short
short d;
d = 11;
Console.WriteLine(d);
Console.WriteLine("New value for d:");
d = short.Parse(Console.ReadLine());
Console.WriteLine("Another value for d:");
string? input3 = Console.ReadLine();
if (short.TryParse(input3, out short number3))
    Console.Write(number3);
else
    Console.Write("Bad input");
Console.WriteLine(" Min value for d");
Console.WriteLine(Int16.MinValue);
Console.WriteLine(" Max value for d");
Console.WriteLine(Int16.MaxValue);


//ushort
ushort e;
e = 12;
Console.WriteLine(e);
Console.WriteLine("New value for e:");
e = ushort.Parse(Console.ReadLine());
Console.WriteLine("Another value for e:");
string? input4 = Console.ReadLine();
if (ushort.TryParse(input4, out ushort number4))
    Console.Write(number4);
else
    Console.Write("Bad input");
Console.WriteLine(" Min value for e");
Console.WriteLine(UInt16.MinValue);
Console.WriteLine(" Max value for e");
Console.WriteLine(UInt16.MaxValue);


//int
int f;
f = 16;
Console.WriteLine(f);
Console.WriteLine("New value for f");
f = int.Parse(Console.ReadLine());
Console.WriteLine("Another value for f");
string? input5 = Console.ReadLine();
if (int.TryParse(input5, out int number5))
    Console.Write(number5);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for f");
Console.WriteLine(Int32.MinValue);
Console.WriteLine("Max value for f");
Console.WriteLine(Int32.MaxValue);


//uint
uint g;
g = 16;
Console.WriteLine(g);
Console.WriteLine("New value for g");
g = uint.Parse(Console.ReadLine());
Console.WriteLine("Another value for g");
string? input6 = Console.ReadLine();
if (int.TryParse(input6, out int number6))
    Console.Write(number6);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for g");
Console.WriteLine(UInt32.MinValue);
Console.WriteLine("Max value for g");
Console.WriteLine(UInt32.MaxValue);

//long
long h;
h = -162;
Console.WriteLine(h);
Console.WriteLine("New value for h");
h = long.Parse(Console.ReadLine());
Console.WriteLine("Another value for h");
string? input7 = Console.ReadLine();
if (int.TryParse(input7, out int number7))
    Console.Write(number7);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for h");
Console.WriteLine(Int64.MinValue);
Console.WriteLine("Max value for h");
Console.WriteLine(Int64.MaxValue);

//ulong
ulong i;
i = 1628;
Console.WriteLine(i);
Console.WriteLine("New value for i");
i = ulong.Parse(Console.ReadLine());
Console.WriteLine("Another value for i");
string? input8 = Console.ReadLine();
if (int.TryParse(input8, out int number8))
    Console.Write(number8);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for i");
Console.WriteLine(UInt64.MinValue);
Console.WriteLine("Max value for i");
Console.WriteLine(UInt64.MaxValue);

//float
float j;
j = 1628F;
Console.WriteLine(j);
Console.WriteLine("New value for j");
j = float.Parse(Console.ReadLine());
Console.WriteLine("Another value for j");
string? input9 = Console.ReadLine();
if (int.TryParse(input9, out int number9))
    Console.Write(number9);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for j");
Console.WriteLine(Single.MinValue);
Console.WriteLine("Max value for j");
Console.WriteLine(Single.MaxValue);

//double
double k;
k = 1.4;
Console.WriteLine(k);
Console.WriteLine("New value for k");
k = double.Parse(Console.ReadLine());
Console.WriteLine("Another value for k");
string? input10 = Console.ReadLine();
if (int.TryParse(input10, out int number10))
    Console.Write(number10);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for k");
Console.WriteLine(Double.MinValue);
Console.WriteLine("Max value for k");
Console.WriteLine(Double.MaxValue);

//decimal
decimal l;
l = 16M;
Console.WriteLine(l);
Console.WriteLine("New value for l");
l = decimal.Parse(Console.ReadLine());
Console.WriteLine("Another value for l");
string? input11 = Console.ReadLine();
if (int.TryParse(input11, out int number11))
    Console.Write(number11);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for l");
Console.WriteLine(Decimal.MinValue);
Console.WriteLine("Max value for l");
Console.WriteLine(Decimal.MaxValue);

//bool
bool m;
m = true;
Console.WriteLine(m);
Console.WriteLine("New value for m");
m = bool.Parse(Console.ReadLine());
Console.WriteLine("Another value for m");
string? input12 = Console.ReadLine();
if (int.TryParse(input12, out int number12))
    Console.Write(number12);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for m");
Console.WriteLine(true);
Console.WriteLine("Max value for m");
Console.WriteLine(true);

//char
char n;
n = 'k';
Console.WriteLine(n);
Console.WriteLine("New value for n");
n = char.Parse(Console.ReadLine());
Console.WriteLine("Another value for n");
string? input13 = Console.ReadLine();
if (int.TryParse(input13, out int number13))
    Console.Write(number13);
else
    Console.Write("Bad input");
Console.WriteLine("Min value for n");
Console.WriteLine(false);
Console.WriteLine("Max value for n");
Console.WriteLine(false);
