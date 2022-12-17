using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);
Console.WriteLine("vui long nhap phep toan:");
Console.WriteLine($"{nameof(number1)}={number1},{nameof(number2)}={number2}");
string? dau = Console.ReadLine();
switch (dau)
{
    case "+" when number1 > 0 && number2 > 0:
        Console.WriteLine(number1 + number2);
        break;

    case "-" when number1>number2:
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;

    case "/" when number2!=0:
        Console.WriteLine(number1 / number2);
        break;
        default: Console.WriteLine("no catulate"); break;
}
//footmart code: ctrl k+d

//switch expression
Console.WriteLine(
    dau switch
    {
        "+" when number1 > 0 && number2 > 0 => number1 + number2,
        "-" when number1 > number2 => number1 - number2,
        "*" => number1 * number2,
        "/" when number2 != 0 => number1 / number2,
        _=> "no catulate"
    }
    ) ;
;
// foreach khoong dung bien dem 
string[] arrs = { "khai", "tin", "tuan anh", "nam", "thien" };
foreach (var t  in arrs)
{
    Console.WriteLine(t);
}

IEnumerator e= 
    arrs.GetEnumerator();
while (e.MoveNext())
{ 
    string s=e.Current.ToString();
    Console.WriteLine(s);
}
