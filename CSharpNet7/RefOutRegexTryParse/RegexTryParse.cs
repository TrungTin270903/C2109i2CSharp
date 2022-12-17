

using System.Text.RegularExpressions;

namespace RefOutRegexTryParse;
internal class RegexTryParse
{
    public void CheckNumberByRegex()
    {
        string? str = null;
        Console.WriteLine("vui long nhap con so :");
        str= Console.ReadLine();
        if (new Regex("^[0-9]+$").IsMatch(str))
        {
            int result=int.Parse(str);
            Console.WriteLine($"{nameof(result)}={result}");
        }
    }
    //bat loi khi dung Parse
    public void CheckStringByTryParse() 
    {
        string? str = null;
        Console.WriteLine("vui loong nhap so :");
        str = Console.ReadLine();
        //if (int.TryParse(str,out int i))
            if (double.TryParse(str, out double i))
            {
            Console.WriteLine($"{nameof(i)}={i}");
        }
    }
    public void TryCatchBug()
    {
        Console.WriteLine("vui long nhap so luong:");
        string? amount=Console.ReadLine();
        try
        {
            int total =int.Parse(amount);
            if (total <=0)
            {
                throw new Exception("phaii lon hon 0");
            }

        }catch(Exception )when (amount.Contains("$"))
        {
            Console.WriteLine("amout ko dc co dau $");
        }
       //gettype chi ra loi
        catch(Exception e)
        {
            //Console.WriteLine(e.GetType()+":"+e.Message);
            Console.WriteLine($"{e.GetType()}:{ e.Message}");
            throw;
        }
    }
}
