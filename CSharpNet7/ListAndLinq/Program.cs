
Console.WriteLine("Start Program!");
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> list = new()
{
    new Student() { Id = 1, Name = "TRUNG TIN", Gender = true, Dob = new DateTime(2003, 09, 27)},
    new Student() { Id = 2, Name = "THANG", Gender = true, Dob = new DateTime(2003, 12, 09) },
    new Student() { Id = 3, Name = "NAM", Gender = true, Dob = new DateTime(2003, 01, 02) },

};
// duyet qu list bang vong lap foreach
//foreach(var stu in list)
//{
//    Console.WriteLine(stu);
//}
//vong lap foreach se chuyen thanh 
IEnumerator<Student> enu = list.GetEnumerator();

while(enu.MoveNext())
{
    Console.WriteLine(enu.Current.ToString());
}

//duyet qua list
//list.ForEach(stu => Console.WriteLine(stu));

//linq= language intergrated query
//linq to sql =>  website thay the cu phap sql trong c#
//linq to object=>console
//sql => select from where group by having order by
//c# => FROM WHERE GROUP BY HAVING ORDER BY ..SELECT
//linq có 2 dạng
//style 1 =>query syntax => dựa theo cú pháp của sql ,dễ học dễ dùng
//style 2=> mehtod syntax=>dựa theo landa =>khó học ,khó dung nhưng nhanh

//hiển thị tên có id>2
//foreach(var stu in list)
//{
//    if (stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//=== style 1
//var t = from stu in list
//        where stu.Id > 1
//        select stu;
//foreach(var i in t)
//{
//Console.WriteLine(i);
//}

//style 1 thu gon 
//foreach(var i in from stu in list where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}
//style 2 
//var t = list.Where(stu => stu.Id > 2);
//foreach (var i in t)
//{
//Console.WriteLine(i);
//}
//style 2 thu gon 
//foreach (var i in  list.Where(stu => stu.Id > 2))
//{
//    Console.WriteLine(i);
//}
//ket hop foreach cua list
list.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);