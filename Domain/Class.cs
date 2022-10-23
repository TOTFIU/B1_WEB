using System.Numerics;

namespace B1_WEB.Domain
{
    public class Class
    {
        public Guid Id { get; set; }
        public string? Class_Name { get; set; }
        public ICollection<Class_Value> Class_Values { get; set; }


        public Class()
        {
            Class_Values = new List<Class_Value>();
        }
        //public string? MobilePhone { get; set; }
        //public string? JobTitle { get; set; }
        //public DateTime? BirthDate { get; set; }
    }
}
