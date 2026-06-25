Console.WriteLine("If-Else");
int x = 10;
Console.Write("  y = ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 10*y) {Console.WriteLine("  x = 10y");}
else if (x%y == 1) {Console.WriteLine("  x % y = 1");}
else {Console.WriteLine("  entahlah");}

Console.WriteLine("");
Console.WriteLine("Short Hand If-Else");
Console.Write("  Bilangan = ");
int a = Convert.ToInt32(Console.ReadLine());
string result = (a%2 == 0) ? "Genap" : "Ganjil";
Console.WriteLine("  Bilangan yang kamu masukkan adalah bilangan " + result);

Console.WriteLine("");
Console.WriteLine("Switch");
Console.Write("  Bulan ke-");
int bulan = Convert.ToInt32(Console.ReadLine());
Console.Write("  Bulan yang kamu masukkan adalah bulan ");
switch (bulan) {
    case 1: 
        Console.WriteLine("Januari");
        break;
    case 2: 
        Console.WriteLine("Februari");
        break;
    case 3:
        Console.WriteLine("Maret");
        break;
    case 4: 
        Console.WriteLine("April");
        break;
    case 5: 
        Console.WriteLine("Mei");
        break;
    case 6:
        Console.WriteLine("Juni");
        break;
    case 7: 
        Console.WriteLine("Juli");
        break;
    case 8: 
        Console.WriteLine("Agustus");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10: 
        Console.WriteLine("Oktober");
        break;
    case 11: 
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("Desember");
        break;
    default: 
        Console.WriteLine("yang salah");
        break;
}