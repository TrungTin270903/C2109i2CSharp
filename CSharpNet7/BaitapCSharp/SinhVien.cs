

namespace BaitapCSharp;
internal class SinhVien
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public bool Gender { get; set; }    
    public DateTime dob { get; set;}

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(dob)}={dob.ToString()}}}";
    }
}
