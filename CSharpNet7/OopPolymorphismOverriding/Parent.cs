using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class Parent
{
    public void Show()=> Console.WriteLine( "parent show");
    //cha phai co tu khoa virtual thi con phai dung override de su cua cha
    public virtual void Display() => Console.WriteLine("parent display");
}
