Console.WriteLine("== Fungsi Strings == ");
Console.WriteLine("");

string txt = "Ziza Sukses, 100 juta pertama di umur 20 tahun";
Console.WriteLine("txt              = "+ txt);
Console.WriteLine("txt in uppercase = "+ txt.ToUpper());
Console.WriteLine("txt in lowercase = "+ txt.ToLower());
Console.WriteLine("length of txt    = "+ txt.Length); //inget spasi juga dihitung

Console.WriteLine("");
Console.WriteLine("Concatenation");
Console.WriteLine("  Ziza " + "Sukses");
Console.WriteLine(String.Concat("  Ziza ", "Sukses"));
Console.WriteLine("  20" + "26");
Console.WriteLine("  " + 20 + 26);
Console.WriteLine("  " + Convert.ToInt32(20 + 26));

Console.WriteLine("");
Console.WriteLine("Interpolation");
string first = "Ziza";
string second = "Sukses";
string hasil = $"  Semoga {first} {second}"; //ga perlu pusingin spasi, otomatis dia
Console.WriteLine(hasil);
Console.WriteLine($"  Semoga {first} {second}");
Console.WriteLine($"  Semoga {"Ziza"} {"Sukses"}");
Console.WriteLine($"  Semoga {20} {26}");

Console.WriteLine("");
Console.WriteLine("Access Strings");
string harapan = "Ziza Sukses";
Console.WriteLine("  " + harapan[0]);
Console.WriteLine("  " + harapan.IndexOf("s")); //ambil yang paling pertama muncul
Console.WriteLine("  " + harapan.Substring(5)); //5 huruf awal di cut gitu 
Console.WriteLine("  " + "Ziza Sukses".Substring(harapan.IndexOf("S"))); //dapet semua stringnya 

Console.WriteLine("");
Console.WriteLine("Special Characters");

//Error : Console.WriteLine("Petik "dalam petik"");
//Solusi : pake backslash

Console.WriteLine("  \"Ziza Sukses.\" ucapnya.");
Console.WriteLine("  Ziza = \"Saat di perjalanan dia mengatakan \'Ziza semoga sukses yaa.\' sambil tersenyum\"");
Console.WriteLine("  ini enter: \n");
Console.WriteLine("  ini tab:\thahahah");
Console.WriteLine("  ini backspace:a\b hahaha"); // si \b bakal makan si a jadinya ga muncul
Console.WriteLine("  ini backspace:\b hahaha"); // si \b makan :