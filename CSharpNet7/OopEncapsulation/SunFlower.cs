using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
internal class SunFlower:Plant
{
    static void Main(string[] args)
    {
        SunFlower flower = new();
        flower.Protected();//là con nên được dùng 
        flower.Internal();//trong cùng project/asemly
        flower.PrivateProteted();//hoac private () protected thì dùng đc
       // flower.ProtetedInternal();
        flower.Public();
        //flower.Private();=> error vì chỉ đứng tại class đó mới dc dùng


    }
}
