using OopEncapsulationProperty;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Human human = new();
human.Address = "132";
Console.WriteLine(human.Address);