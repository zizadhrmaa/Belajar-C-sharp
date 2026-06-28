abstract class Dokter : Pekerjaan
{
    public string Spesialisasi {get; set;}
    public Dokter (int dk, string i, double gp, double glpj, string s) 
        : base(dk, "Dokter", i, gp, glpj)
    {
        Spesialisasi = s;
    }

}