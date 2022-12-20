//trong c sharp kế thừa dùng dấu :

namespace OopAbstraction;
internal class Cat:Animal
{
    //con kế gừ cha mà cha abstract thì con phải kế thừa lại cha đang abstract nếu con ko viết đc thì nó cũng là abstract
    private bool gender;
    //1pt chỉ có 1 câu lệnh duy nhất thì chuyển nó thành expression boddy 
    public void ShowCat() => Console.WriteLine("this is a cat ");
}
