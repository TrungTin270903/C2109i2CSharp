using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphirmInterface;
internal interface IBinaryFile
{
    //ko dùng bổ từ truy cập(void,public)"access modify"
    void WriteBinaryFile();
    void ReadFile();
    // có pt mặc định tồn tại trong interface
    void ShowInfo() => Console.WriteLine( "this is binary");
}
