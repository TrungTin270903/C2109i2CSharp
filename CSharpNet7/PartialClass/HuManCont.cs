

namespace PartialClass;
internal partial class Human
{
    //1 phương thức mà chỉ có 1 câu lệnh
    // csharrp sẽ ko sd pt mà dùng expression body => biểu thức dưới dạng pt
    public void Show()=>
    Console.WriteLine($"{nameof(fullname)}={fullname}");
    public void Check() => Console.WriteLine(10 > 5 ? true : false);
}

