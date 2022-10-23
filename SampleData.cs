using B1_WEB.DataBase;
using B1_WEB.Models;

namespace B1_WEB
{
    public class SampleData
    {
        public static void Initialize(DataBaseContext context)
        {
            Class C1 = new Class { Class_Name = "КЛАСС  1  Денежные средства, драгоценные металлы и межбанковские операции" };
            Class C2 = new Class { Class_Name = "КЛАСС  2  Кредитные и иные активные операции с клиентами" };

            Decimal_bank_number D1 = new Decimal_bank_number { Bank_number = 10, cls = C1 };
            Decimal_bank_number D2 = new Decimal_bank_number { Bank_number = 20, cls = C2 };

            context.Classes.AddRange(C1);
            context.Classes.AddRange(C2);
            context.SaveChanges();



            Class_Value pl1 = new Class_Value
            {
                Opening_balance_Active = 74975624165.88,
                Opening_balance_Passive = 0.0,
                Turnover_Debet = 15640681705689.40,
                Turnover_Credit = 1431243941883.60,
                Decimals = D1
            };
            Class_Value pl2 = new Class_Value
            {
                Opening_balance_Active = 74975624165.88,
                Opening_balance_Passive = 0.0,
                Turnover_Debet = 15640681705689.40,
                Turnover_Credit = 1431243941883.60,
                Decimals = D2
            };
            context.Class_Values.AddRange(new List<Class_Value> { pl1, pl2 });
            context.SaveChanges();


        }
    }
}
