// Data Types
/*
Data Type: `int`
Size: 4 bytes
Description: Stores whole numbers from -2,147,483,648 to 2,147,483,647

Data Type: `long`
Size: 8 bytes
Description: Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

Data Type: `float`
Size: 4 bytes
Description: Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits

Data Type: `double`
Size: 8 bytes
Description: Stores fractional numbers. Sufficient for storing 15 decimal digits

Data Type: `bool`
Size: 1 byte
Description: Stores true or false values

Data Type: `char`
Size: 2 bytes
Description: Stores a single character/letter, surrounded by single quotes

Data Type: `string`
Size: 2 bytes per character
Description: Stores a sequence of characters, surrounded by double quotes
*/

int    MyInt    = 23;
long   MyLong   = 2929838383L;
float  MyFloat  = 3388.019F;
double MyDouble = 83.919182289273738E2D; // 83.919182289273738 x 10^2
char   MyChar   = 'A';
string MyString = "Ziza";
bool   MyBool   = true;

Console.WriteLine("== Data Types ==");
Console.WriteLine("Int    = " + MyInt);
Console.WriteLine("Long   = " + MyLong);
Console.WriteLine("Float  = " + MyFloat);
Console.WriteLine("Double = " + MyDouble);
Console.WriteLine("Char   = " + MyChar);
Console.WriteLine("String = " + MyString);
Console.WriteLine("Bool   = " + MyBool);


//Types Casting
/*
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:
  - Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double
  - Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char
*/
Console.WriteLine ("");
Console.WriteLine ("== Type Casting ==");

Console.WriteLine ("Implicit Casting: Int to Double");
int myIntCast1 = 9;
double myDoubleCast1 = myIntCast1; //implicit
Console.WriteLine ("  Int    = " + myIntCast1);
Console.WriteLine ("  Double = " + myDoubleCast1);

Console.WriteLine ("Explicit Casting: Double to Int");
double myDoubleCast2 = 9.88;
int myIntCast2 = (int) myDoubleCast2; //explicit
Console.WriteLine ("  Int    = " + myIntCast2);
Console.WriteLine ("  Double = " + myDoubleCast2);

/*
Type Conversion Methods
It is also possible to convert data types explicitly by using built-in methods, 
such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, 
Convert.ToInt32 (int) and Convert.ToInt64 (long)
*/

Console.WriteLine ("");
Console.WriteLine ("== Type Conversion Methods ==");
string stringToBool1 = "true";
string stringToBool2 = "false";
int intToDouble = 8;
double doubleToInt32n64 = 77767818.99;
bool boolToString1 = true;
bool boolToString2 = false;

Console.WriteLine ("Bool   = " + Convert.ToBoolean(stringToBool1));
Console.WriteLine ("Bool   = " + Convert.ToBoolean(stringToBool2));
Console.WriteLine ("Double = " + Convert.ToDouble(intToDouble));
Console.WriteLine ("Int    = " + Convert.ToInt32(doubleToInt32n64));
Console.WriteLine ("Long   = " + Convert.ToInt64(doubleToInt32n64));
Console.WriteLine ("String = " + Convert.ToString(intToDouble));
Console.WriteLine ("String = " + Convert.ToString(doubleToInt32n64));
Console.WriteLine ("String = " + Convert.ToString(boolToString1));
Console.WriteLine ("String = " + Convert.ToString(boolToString2));