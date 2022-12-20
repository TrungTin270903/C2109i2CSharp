using OopEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationCont;
internal class Weed:Plant
{
    static void Main(string[] args)
    {
        Weed weed = new();
        weed.Protected();
        //  weed.PrivateProteted();//trong cung 1 project moi sd ddc
        weed.ProtetedInternal();    
        weed.Public();
        

    }
}
