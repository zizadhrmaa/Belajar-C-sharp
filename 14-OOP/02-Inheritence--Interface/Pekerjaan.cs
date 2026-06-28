using System.Runtime.InteropServices.Marshalling;

abstract class Pekerjaan(int dk, string np, string i, double gp, double glpj) 
//If you don't want other classes to inherit from a class, use the sealed keyword:
//sealed class <Name>
{
    public int DurasiKerja { get; set; } = dk; public string NamaPekerjaan { get; set; } = np; public string Instansi { get; set; } = i; public double GajiPokok { get; set; } = gp; public double GajiLemburPerJam { get; set; } = glpj;

    public virtual double HitungGaji (int waktuLembur)
    {
        return GajiPokok + (GajiLemburPerJam * waktuLembur);
    }
    abstract public void LakukanTugasUtama();
}