using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphirmInterface;
internal class SomeFile : IBinaryFile, ITextFile
{
    //bắt buộc bôer từ phải là public 
    public void ReadFile()=> Console.WriteLine("read file ");


    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTextFile() => Console.WriteLine("write text file");
}
