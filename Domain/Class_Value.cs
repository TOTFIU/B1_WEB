using System.ComponentModel.DataAnnotations.Schema;

namespace B1_WEB.Domain
{
    [Table("Class_Value")]
    public class Class_Value
    {
        public Guid Id { get; set; }
        public double Opening_balance_Active { get; set; }
        public double Opening_balance_Passive { get; set; }
        public double Turnover_Debet { get; set; }
        public double Turnover_Credit { get; set; }

       
        public Class CLSS { get; set; }

    }
}
