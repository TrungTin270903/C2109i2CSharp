 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverloading;
internal class BasicMath
{
    public int NumberOne { get; set; }
    public int NumberTwo { get; set; }
    //overloading thể hiển ở 2 nơi (constructor và 
    //overloading cùng tên hay khác kiểu của tham số 
    public BasicMath()
    {

    }

    public BasicMath(int numberOne, int numberTwo)
    {
        NumberOne = numberOne;
        NumberTwo = numberTwo;
    }
    //overloading phuong thuc 
    //optional agrument=>đối số truyền cho tham sô (parameter)
    public void Sum(int num1=0, int num2=default)
    {
        NumberOne = num1;
        NumberTwo = num2;
        Console.WriteLine(NumberOne + NumberTwo);
    }
    /*public void Sum(int num1,int num2)
    {
        NumberOne=num1;
        NumberTwo=num2;
        Console.WriteLine(NumberOne+NumberTwo);
    }
    public void Sum()
    {
        NumberOne = 0;
        NumberTwo = 0;
        Console.WriteLine(NumberOne + NumberTwo);
    }*/
}
