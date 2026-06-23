// User Input pake fungsi Console.ReadLine() dengan hasil input PASTI string
// Kalau mau input bukan string tapi tipe data lain, tinggal casting aja
Console.WriteLine("Masukkan usernamemu");
string myUsername = Console.ReadLine();
Console.WriteLine("Masukkan umurmu");
int myAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Masukkan status pernikahanmu");
bool myStatus = Convert.ToBoolean(Console.ReadLine()); //riskan sih, cara ini cuma buat belajar casting
Console.WriteLine("");
Console.WriteLine("== Hasil ==");
Console.WriteLine("Username    : " + myUsername);
Console.WriteLine("Umur        : " + myAge);
Console.WriteLine("Udah nikah? : " + myStatus);