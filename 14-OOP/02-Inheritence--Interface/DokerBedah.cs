class DokterBedah : Dokter, IBedah
{
    public DokterBedah (int dk, string i, double gp, double glpj) 
        : base(dk, i, gp, glpj, "Bedah"){}

    public void CekKondisiPasienSebelumBedah()
    {
        Console.WriteLine ("Cek Kondisi Pasien Sebelum Bedah");
    }
    public void SterilisasiAlat()
    {
        Console.WriteLine ("Sterilisasi Alat");
    }
    public void LakukanOperasi()
    {
        Console.WriteLine ("Lakukan Operasi");
    }
    public void PantauPasienSetelahOperasi()
    {
        Console.WriteLine ("Pantau Pasien Setelah Operasi");
    }
    public void BuatLaporanOperasi()
    {
        Console.WriteLine ("Buat Laporan Operasi");
    }
    public override void LakukanTugasUtama()
    {
        CekKondisiPasienSebelumBedah();
        SterilisasiAlat();
        LakukanOperasi();
        PantauPasienSetelahOperasi();
        BuatLaporanOperasi();
    }
}