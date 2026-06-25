Console.WriteLine("Arrays");
Console.WriteLine("Create Arrays");
int[] Angka1 = {10, 20, 30, 40, 50};
Console.WriteLine("  " + Angka1[0]);
int[] Angka2 = new int[5] {10, 20, 30, 40, 50};
Console.WriteLine("  " + Angka2[0]);
int[] Angka3 = new int[] {10, 20, 30, 40, 50};
Console.WriteLine("  " + Angka3[0]);
int[] Angka4;
Angka4 = new int[] {10, 20, 30, 40, 50}; // Add values without using new will cause an error
Console.WriteLine("  " + Angka4[0]);

Console.WriteLine("Length Array Angka1 = " + Angka1.Length);
Angka1[0] = 5;
Console.WriteLine("Ubah Angka1[0] jadi 5 sehingga Angka1[0] = " + Angka1[0]);

Console.WriteLine("");
Console.WriteLine("Loop Through Arrays");
Console.WriteLine("For Loop");
for (int k = 0; k < Angka1.Length; k++) {
    Console.Write("  ");
    Console.WriteLine(Angka1[k]);
}

Console.WriteLine("");
Console.WriteLine("Foreach Loop");
foreach (int i in Angka1) {
    Console.Write("  ");
    Console.WriteLine(i);
}