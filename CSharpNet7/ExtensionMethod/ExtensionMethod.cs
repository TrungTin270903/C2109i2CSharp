using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod;
internal static class ExtensionMethod
{
    //1 class là static thì toàn bộ bên tong sẽ là stactic
    public static void CheckIsGreaterThan( this int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i} dung la lon hon {value}");
        }
    }
    public static void Hello(this Program pro)
    {
        Console.WriteLine("hello thang nhoc ");
    }
}
