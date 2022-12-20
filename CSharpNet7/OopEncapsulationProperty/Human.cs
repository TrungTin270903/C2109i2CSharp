using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty;
internal class Human
{
    //field (phai la private)
    private string fullname;

    //property =>mobile
    public string Fullname1 { get => fullname; set => fullname = value; }

    //auto-property=>dập cái field thành thuộc tính 
    public string Address { get; set; }



    //các thuộc tính phải có bổ từ truy cập là public
    public string FullName
    {
        set => fullname = value;
        get => fullname;
    }
    
    //public string Fullname { get => fullname; set => fullname = value; }
}
