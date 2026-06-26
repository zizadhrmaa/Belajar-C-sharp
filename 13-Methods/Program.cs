// In C#, it is good practice to start with an uppercase letter 
// when naming methods, as it makes the code easier to read.
static void Print()
{
    Console.WriteLine ("cetak aja");
}

static int Kurang(int a = 0, int b = 0) //a = 0 dan b = 0 adalah default parameter
{
    return a-b;
}
/*
When a parameter is passed to the method, it is called an argument. 
So, from the example above: a, b is a parameter, while 10, 5 arguments.
*/
Print();
Console.WriteLine(Kurang());
Console.WriteLine(Kurang(10, 5));
Console.WriteLine(Kurang(b: 10, a: 5)); //named arguments

//Methods overloading: multiple methods can have the same name with different parameters
//Di C#, local function dalam scope yang sama tidak bisa punya nama yang sama, 
//walaupun parameternya beda

/*
static double Kurang (double a, double b)
{
    return a-b;
}
Console.WriteLine(Kurang(10.5, 5.5));
*/