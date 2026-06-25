Console.WriteLine("While loop");
int i = 5;
while (i > 0) {
    Console.Write("  ");
    Console.WriteLine(i); 
    i--;
}

Console.WriteLine("");
Console.WriteLine("Do/While loop");
int j = 1;
do {
    Console.Write("  ");
    Console.WriteLine(j);
    j++;
} while (j <= 5);

Console.WriteLine("");
Console.WriteLine("For loop");
for (int k = 1; k <= 5; k++) {
    Console.Write("  ");
    Console.WriteLine(k);
}

Console.WriteLine("");
Console.WriteLine("Nested For loop");
for (int m = 1; m <= 5; m++) {
    Console.Write("  ");
    Console.WriteLine("luar: " + m);
    for (int n = 5; n >= 1; n--) {
        Console.Write("    ");
        Console.WriteLine("dalam: " + n);
    }
}