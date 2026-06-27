class Cat 
{
  public string color = "oren";
  private double weightKG;
  //Fields can be made read-only (if you only use the get method), 
  //or write-only (if you only use the set method)
  public double WeightKG //ini namanya properties, isinya getter dan setter
  {
    get { return weightKG;}
    set { 
      if (value < 0) {return;}
      weightKG = value;}
  }
  public string Pemilik { get; set; } = ""; //automatic properties, cocok klo ga perlu logika khusus
    public Cat() {}
                              // public Cat() {weightKG = 6.79;}
                              // kalau constructornya kayak di atas ini nanti weightKG nya default 6.79
                              // public Cat() {color = "warnadefault"; weightKG = 0.00;} 
                              // kalau constructornya kayak di atas ini nanti colornya ke override
    public Cat(string modelColor, double modelWeightKG) {color = modelColor; weightKG = modelWeightKG;}
  public void sound () {Console.WriteLine("Meongg");}
}