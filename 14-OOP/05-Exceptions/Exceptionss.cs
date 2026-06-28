class Exceptionss
{
    private const string Message = "Input harus berupa bilangan integer";

    private static void Main(string[] args)
    {
        Console.WriteLine ("try-catch-finally: ");
        try
        {
            int[] a = {10, 2, 5, 6};
            Console.WriteLine(a[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("  " + e.Message);
        }
        finally
        {
            Console.WriteLine ("  Program udah dijalanin");
        }

        Console.WriteLine ("");
        Console.WriteLine ("throw");
        Console.Write ("  umur = ");
        string? input = Console.ReadLine();
        try
        {
            if (!int.TryParse(input, out int umur)) {throw new ArgumentException (Message);}
            if(umur < 0) {throw new ArgumentOutOfRangeException(nameof(umur), "Nilai umur harus ANGKA lebih besar atau sama dengan 0");}
            Console.WriteLine("  Umur kamu adalah " + umur);   
        }
        catch (ArgumentOutOfRangeException e) {Console.WriteLine("  " + e.Message);}
        catch (ArgumentException e) {Console.WriteLine("  " + e.Message);}
        finally {Console.WriteLine("  Validasi umur selesai");}
    }
}