// Variables
int Angka = 5;
Angka = 27;
string Namaku = "Ziza";
char Huruf = 'A';
bool UdahMamLum = false;
double DollarToRupiah = 17811.10;
decimal RupiahToDollar = 0.000056m;

Console.WriteLine("== Section Variables == ");
Console.WriteLine(Angka);
Console.WriteLine(Namaku);
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