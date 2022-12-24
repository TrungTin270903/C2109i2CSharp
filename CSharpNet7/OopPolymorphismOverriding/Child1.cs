using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class Child1:Parent
{
    //override viet lai pt cua cha
    public override void Display() => Console.WriteLine("child1 display");
    //khi pt của con khác cha mà cùng tên thì nên bỏ new lên trước ,con có thể có pt giống cha
    public new void Show() => Console.WriteLine("child1 show");
}
