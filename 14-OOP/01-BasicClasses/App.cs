/*
public: The code is accessible for all classes
private: The code is only accessible within the same class
protected: The code is accessible within the same class, 
            or in a class that is inherited from that class. 
internal: The code is only accessible within its own assembly, but not from another assembly.
*/

class App
{
  static void Main(string[] args)
  {
    Cat myObj = new();
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.WeightKG); //belum dikasi nilainya jadi otomatis 0
    myObj.WeightKG = 5.4; //berhasil override
    Console.WriteLine(myObj.WeightKG);
    Console.WriteLine(myObj.Pemilik);
    /* Sebelum ada constructor ini bisa dilakukan
    Cat myObj2 = new() //default constructor
    {
      color = "putih", //bisa dilakukan karena aksesnya publik
      weightKG = 4.7
    };
    */
    Cat myObj2 = new("putih", 4.7);
    Console.WriteLine(myObj2.color);
    Console.WriteLine(myObj2.WeightKG);
    myObj2.WeightKG = 7.3; //gabisa override
    myObj2.Pemilik = "ziza";
    Console.WriteLine(myObj2.Pemilik);
  }
}