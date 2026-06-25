Console.WriteLine("Break and Continue");
Console.WriteLine("For Loop");
Console.WriteLine("  Break");
for (int k = 1; k <= 5; k++) {
    if (k == 3) {break;}
    Console.Write("  ");
    Console.WriteLine(k);
}
Console.WriteLine("");
Console.WriteLine("  Continue");
for (int k = 1; k <= 5; k++) {
    if (k == 3) {continue;}
    Console.Write("  ");
    Console.WriteLine(k);
}

Console.WriteLine("");
Console.WriteLine("While Loop");
Console.WriteLine("  Break");
int i = 5;
while (i > 0) {
    if (i == 4) {break;}
    Console.Write("  ");
    Console.WriteLine(i); 
    i--;
}
Console.WriteLine("");
Console.WriteLine("  Continue");
int j = 5;
while (j > 0) {
    if (j == 4) {j--; continue;} 
    //jangan lupa j-- karena meskipun si 4 di skip tapi tetep harus dikurangi j nya biar ga stuck di j = 4
    Console.Write("  ");
    Console.WriteLine(j); 
    j--;
}

Console.WriteLine("");
Console.WriteLine("Do/While Loop");
Console.WriteLine("  Break");
int m = 1;
do {
    if (m == 2) {break;}
    Console.Write("  ");
    Console.WriteLine(m);
    m++;
} while (m <= 5);

Console.WriteLine("");
Console.WriteLine("  Continue");
int n = 1;
do {
    if (n == 2) {n++; continue;}
    Console.Write("  ");
    Console.WriteLine(n);
    n++;
} while (n <= 5);