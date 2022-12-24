using OopPolymorphismOverloading;

BasicMath math = new();
Console.WriteLine(math.NumberOne);

BasicMath basic = new(45,34);
Console.WriteLine(basic.NumberOne);

// object intializer

BasicMath basic1 = new();
BasicMath basic2 = new()
{
    NumberOne = 5
};
BasicMath basic3 = new()
{
    NumberTwo = 10
};

basic1.Sum();//=>sum=0
basic1.Sum(5, 6);//=>sum=11
basic1.Sum(5);//=>Number1 = 5
//named argument
basic1.Sum(num2: 5);//=>num2=5
basic1.Sum(num1: 3, num2: 5);
