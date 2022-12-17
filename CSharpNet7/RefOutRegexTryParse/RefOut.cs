

namespace RefOutRegexTryParse;
internal class RefOut
{
    //  public static void ChangeVar(ref int a , ref int b)
    public static void ChangeVar(out int a, out int b)
    {
        //ref
        //var tam = a;
        //a = b;
        //b= tam;
        //out
        a = 10;
        b = 5;
        var tam = a;
        a = b;
        b = tam;
        Console.WriteLine("change :");
        Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");
    }
}
