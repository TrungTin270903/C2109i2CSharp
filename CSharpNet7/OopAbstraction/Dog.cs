

namespace OopAbstraction;
internal class Dog : Animal
{
    //thực thi lại cái pt abstract của Animal(cha)
    //buộc phải dùng từ khóa override vào
    public override void ShowInfo()
    {
        throw new NotImplementedException();
    }

}