class Program
{
    //You can also have an enum inside a class
    enum Pulau
    {
        Sumatera, //0
        Sulawesi, //1
        Jawa, //2
        Kalimantan = 0, //0 artinya nilai dari Kalimantan ganti jadi Sumatera 
        Bali //1 artinya nilai dari Bali ganti jadi Sulawesi 
    }
    public static void Main (string[] args)
    {
        Hari senin = Hari.Senin;
        Console.WriteLine(senin);
        Pulau kalimantan = Pulau.Kalimantan;
        Console.WriteLine(kalimantan);
        Pulau bali = Pulau.Bali;
        Console.WriteLine(bali);
        int kamisNilai = (int) Hari.Kamis;
        Console.WriteLine(kamisNilai);
        int sulawesiNilai = (int) Pulau.Sulawesi;
        Console.WriteLine(sulawesiNilai);
        int baliNilai = (int) Pulau.Bali;
        Console.WriteLine(baliNilai);

        Console.WriteLine("");
        Console.WriteLine("Switch Hari");

        Hari myHari = Hari.Sabtu;
        Console.Write("  ");
        switch (myHari)
        {
            case Hari.Senin:
                Console.WriteLine(Hari.Senin);
                break;
            case Hari.Selasa:
                Console.WriteLine(Hari.Selasa);
                break;
            case Hari.Rabu:
                Console.WriteLine(Hari.Rabu);
                break;
            case Hari.Kamis:
                Console.WriteLine(Hari.Kamis);
                break;
            case Hari.Jumat:
                Console.WriteLine(Hari.Jumat);
                break;
            case Hari.Sabtu:
                Console.WriteLine(Hari.Sabtu);
                break;
            case Hari.Minggu:
                Console.WriteLine(Hari.Minggu);
                break;
        }

    }
}