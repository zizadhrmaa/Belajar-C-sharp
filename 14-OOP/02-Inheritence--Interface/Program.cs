class Program
{
    public static void Main (string[] args)
    {
        DokterBedah dokterBedah = new(8, "Rumah Sakit Borromeus", 8000000, 200000);
        dokterBedah.LakukanTugasUtama();
        Console.WriteLine ("Gaji yang didapat senilai " + dokterBedah.HitungGaji(2));
    }
}