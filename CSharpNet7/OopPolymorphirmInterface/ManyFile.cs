using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphirmInterface;
internal class ManyFile:IBinaryFile,ITextFile
{
    //bắt buộc bôer từ phải là public 

    //bỏ đi bổ từ truy cập , sau đó thêm tên interface phía trước 
     void IBinaryFile.ReadFile() => Console.WriteLine("read  binary file ");

     void ITextFile.ReadFile() => Console.WriteLine("read text file ");
    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTextFile() => Console.WriteLine("write text file");
}
