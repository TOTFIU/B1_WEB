using B1_WEB.Domain;

namespace B1_WEB.Models
{
    public class Class
    {
        public Guid Id { get; set; }
        public string? Class_Name { get; set; }
        public ICollection<Decimal_bank_number> Decimals { get; set; }


        public Class()
        {
            Decimals = new List<Decimal_bank_number>();
        }
    }
}
