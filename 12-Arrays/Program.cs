/*
//System.Linq Namespace
using System;
using System.Linq;
namespace  App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}
*/
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

Console.WriteLine("");
Console.WriteLine("Sort An Array");
string[] b4 = { "beauty", "brain", "behaviour", "brave" };
Console.WriteLine("Asli: ");
foreach (string nilai in b4) {
    Console.Write("  ");
    Console.WriteLine(nilai);
}
Console.WriteLine("Hasil sort: ");
Array.Sort(b4);
foreach (string nilai in b4) {
    Console.Write("  ");
    Console.WriteLine(nilai);
}


Console.WriteLine("");
Console.WriteLine("Max, Min, and Sum");
int[] myNumbers = {5, 1, 8, 9};
Console.Write("  MyNumbers = {");
foreach (int number in myNumbers) {
    if  (number == myNumbers[myNumbers.Length-1]) {Console.Write(number + "}");}
    else {Console.Write(number + ", ");}
}
Console.WriteLine("");
Console.WriteLine("  Max: " + myNumbers.Max());  // returns the largest value
Console.WriteLine("  Min: " + myNumbers.Min());  // returns the smallest value
Console.WriteLine("  Sum: " + myNumbers.Sum());  // returns the sum of elements

Console.WriteLine("");
Console.WriteLine("Multidimensional Array / Array of Arrays");
int[,] duadimensi = {{4, 5, 6}, {1, 2, 3}};
foreach (int apa in duadimensi) {
    Console.Write("  ");
    Console.WriteLine(apa);
} //kurang bagus
Console.WriteLine("");
Console.WriteLine("Asli: ");
for (int y = 0; y < duadimensi.GetLength(0); y++)
{
    Console.Write("  | ");
    for (int z = 0; z < duadimensi.GetLength(1); z++)
    {
        Console.Write(duadimensi[y, z] + " ");
    }
    Console.WriteLine("|");

}

Console.WriteLine("");
Console.WriteLine("Change duadimensi[0,2] jadi 5");
duadimensi[0,2] = 5;
for (int y = 0; y < duadimensi.GetLength(0); y++)
{
    Console.Write("  | ");
    for (int z = 0; z < duadimensi.GetLength(1); z++)
    {
        Console.Write(duadimensi[y, z] + " ");
    }
    Console.WriteLine("|");

}

Console.WriteLine("");
Console.WriteLine("duadimensi[1,1] = " + duadimensi[1,1]);