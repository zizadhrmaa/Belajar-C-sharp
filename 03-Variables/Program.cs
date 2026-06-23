// Variables
// Multiples Variables
Console.WriteLine("== Ubah Value Variable ==");
int Angka1 = 5, Angka2 = 10, Angka3;
Console.WriteLine(Angka1);
Angka1 = 27;
Console.WriteLine(Angka1);
Angka3 = 12;
string Namaku = "Ziza";
char Huruf = 'A';
bool UdahMamLum = false;
double DollarToRupiah = 17811.10;
decimal RupiahToDollar = 0.000056m;

Console.WriteLine("== Section Variables == ");
Console.WriteLine(Angka1 + Angka2 + Angka3);
Console.WriteLine("Hai " + Namaku);
Console.WriteLine(Huruf);
Console.WriteLine(UdahMamLum);
Console.WriteLine(DollarToRupiah);
Console.WriteLine(DollarToRupiah.ToString("F2"));
Console.WriteLine(RupiahToDollar);
Console.WriteLine($"{RupiahToDollar:F6}");
Console.WriteLine("");

//Constants
const double Pi = 3.141592653589793;
// gaboleh Pi = angka lain, bakal error
// gaboleh deklarasi konstanta tapi assign value
Console.WriteLine("== Section Constants == ");
Console.WriteLine(Pi);