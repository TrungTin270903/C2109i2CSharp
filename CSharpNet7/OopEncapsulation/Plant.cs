using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
public class Plant
{
    //access modifier=> các bổ từ truy cập 
    private void Private() => Console.WriteLine("private");
    //kế thừa con cháu
    protected void Protected() => Console.WriteLine("protected");
    //trong cùng 1 đồ án 
    internal void Internal() => Console.WriteLine("internal");
    // trong cùng project có private hoặc protected có thể sd 
    private protected void PrivateProteted() => Console.WriteLine("private protected");
    //
    protected internal void ProtetedInternal() => Console.WriteLine("protected internal");
    public void Public() => Console.WriteLine("public");

    static void Main(string[] args)
    {
        Plant plant = new();
        plant.Private();
        plant.Protected();  
        plant.Internal();
        plant.ProtetedInternal();
        plant.PrivateProteted();
        plant.Public();

    }


}
