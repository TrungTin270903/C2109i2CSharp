using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number = 10;
string str = "tin";
double money = 10.5;
bool check = true;
// trong c sharp thuong co 2 dang kieu chinh
//1. value type (dang so ) không  chua dc null, 2. reference type (chuoi ,doi tuong )cho phep null
string name = null;
//code cũ 
Nullable<int>a = null;
//code mới=> nullable value type
int? b = null;
bool? flag = null;

//
if (name != null)
{
    Console.WriteLine(true);
}
else
{
   Console.WriteLine(false);
}


//?: => ternary operator
Console.WriteLine(name!=null ? true : false);
//is not null(!=)
//is (=)
Console.WriteLine(name is not null ? true : false);
int age = 10;
Console.WriteLine(age is 10 ? "tuoi":"gia");


//? => null coditional operation 
// ? dùng sau đít tên biến hay đối tượng 
//? tương tự (!=, nếu cái gì đó khác null thì lấy cái vế sau
int? length =name?.Length;
//if(name!=null)
//{
//  length = name.Length;
//}
//else
//{
//  length = null;
//}


// ?? => null coalesing operator
//?? tương tự dấu == , nếu cái gì đó bằng null thì lấy cái vế sau 
int? chieudai = name?.Length ?? 10;
