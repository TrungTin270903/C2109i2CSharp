

//int a = 10;
//int b = 5;
//RefOut.ChangeVar(ref a, ref b);
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

RefOut.ChangeVar(out int a, out int b);
Console.WriteLine("main:");
Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");
//ref: sẽ thay đổi giá trị cả trong lẫn ngoài (value int , boolen)(reference:string)== out
//ref thay doi truoc con out ko khai bao bien truoc 

//pure oop=>oop nguyen thủy , thuần oop=>c# cũ 
//RegexTryParse parse= new RegexTryParse();

//dùng từ var
//var par = new RegexTryParse();

//target-type c# new
RegexTryParse p = new();
//p.CheckNumberByRegex();
//p.CheckStringByTryParse();
p.TryCatchBug();
