Console.WriteLine("== Operators ==");
int a = 10;
int b = 5;
int c = 2;
int d = 3;
string indentasi1 = "  ";
string enter = "\n";

Console.WriteLine("Aritmatika");
Console.WriteLine(indentasi1 + "a = " + a + " | b = " + b + " | c = " + c + " | d = " + d);
Console.WriteLine(indentasi1 + "a+b = " + Convert.ToInt32(a+b));
Console.WriteLine(indentasi1 + "b-c = " + Convert.ToInt32(b-c));
Console.WriteLine(indentasi1 + "c*d = " + Convert.ToInt32(c*d));
Console.WriteLine(indentasi1 + "a/2 = " + Convert.ToInt32(a/2));
Console.WriteLine(indentasi1 + "6%4 = " + Convert.ToInt32(6%4));
d++;
Console.WriteLine(indentasi1 + "d++ = " + Convert.ToInt32(d));
d--;
Console.WriteLine(indentasi1 + "d-- = " + Convert.ToInt32(d));

Console.Write(enter);

Console.WriteLine("Assignment");
Console.WriteLine(indentasi1 + "a = " + a + " | b = " + b);
Console.Write(enter);
Console.WriteLine(indentasi1 + "Operasi  | Hasil");
Console.WriteLine(indentasi1 + "----------------");
a=b;
Console.WriteLine(indentasi1 + "a = b    | " + a);
a+=2;
Console.WriteLine(indentasi1 + "a += 2   | " + a);
a-=3;
Console.WriteLine(indentasi1 + "a -= 3   | " + a);
a*=4;
Console.WriteLine(indentasi1 + "a *= 4   | " + a);
a/=2;
Console.WriteLine(indentasi1 + "a /= 2   | " + a);
a%=3;
Console.WriteLine(indentasi1 + "a %= 3   | " + a);
a&=2;
Console.WriteLine(indentasi1 + "a &= 2   | " + a);
a|=1;
Console.WriteLine(indentasi1 + "a |= 1   | " + a);
a^=0;
Console.WriteLine(indentasi1 + "a ^= 0   | " + a);
a<<=2;
Console.WriteLine(indentasi1 + "a <<= 2  | " + a);
a>>=1;
Console.WriteLine(indentasi1 + "a >>= 1  | " + a);

Console.Write(enter);

Console.WriteLine("Comparison");
Console.WriteLine(indentasi1 + "a = " + a + " | b = " + b + " | c = " + c + " | d = " + d);
Console.WriteLine(indentasi1 + "Operasi  | Hasil");
Console.WriteLine(indentasi1 + "----------------");
Console.WriteLine(indentasi1 + "a == b   | " + Convert.ToBoolean(a == b));
Console.WriteLine(indentasi1 + "c != d   | " + Convert.ToBoolean(c != d));
Console.WriteLine(indentasi1 + "a < 10   | " + Convert.ToBoolean(a < 10));
Console.WriteLine(indentasi1 + "b > 10   | " + Convert.ToBoolean(b > 10));
Console.WriteLine(indentasi1 + "c <= 5   | " + Convert.ToBoolean(c <= 5));
Console.WriteLine(indentasi1 + "d >= 5   | " + Convert.ToBoolean(d >= 5));

Console.Write(enter);

Console.WriteLine("Logical");
Console.WriteLine(indentasi1 + "a = " + a + " | b = " + b + " | c = " + c + " | d = " + d);
Console.WriteLine(indentasi1 + "Operasi           | Hasil");
Console.WriteLine(indentasi1 + "----------------");
Console.WriteLine(indentasi1 + "a == b && c != d  | " + Convert.ToBoolean(a == b && c != d));
Console.WriteLine(indentasi1 + "a < 10 || b > 10  | " + Convert.ToBoolean(a < 10 || b > 10));
Console.WriteLine(indentasi1 + "!(c <= 5)         | " + Convert.ToBoolean(!(c <= 5)));