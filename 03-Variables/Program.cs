int Angka = 5;
Angka = 27;
string Namaku = "Ziza";
char Huruf = 'A';
bool UdahMamLum = false;
double DollarToRupiah = 17811.10;
decimal RupiahToDollar = 0.000056m;

Console.WriteLine(Angka);
Console.WriteLine(Namaku);
Console.WriteLine(Huruf);
Console.WriteLine(UdahMamLum);
Console.WriteLine(DollarToRupiah);
Console.WriteLine(DollarToRupiah.ToString("F2"));
Console.WriteLine(RupiahToDollar);
Console.WriteLine($"{RupiahToDollar:F6}");