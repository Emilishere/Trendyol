using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Payment
    {
        public void PaymentManager()
        {
            List<Payment> paymentmanager = new List<Payment>();
            string ask = string.Empty;
            int number = 1;
            do
            { 
                Console.WriteLine($"Enter the amount that you have before the {number} payment:");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the Card type:");
                string type = Console.ReadLine();
                Payment payment1 = new Payment();
                decimal k = Remaining(amount,);
                {
                    payment1.previousamount = amount;
                    payment1.CardType = type;
                    
                }
                number++;
                Console.WriteLine("Do you want to order more? y-yes/n-no");
                ask = Console.ReadLine();
            } while (ask=="y");
        }
        public int Id { get; set; }
        public decimal previousamount { get; set; } //onceden kartda olan mebleg-cunku mebleg normalda banklarla danisildiqdan sonra elde edilir
        public string CardType { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal afterbudget { get; set; }
        public decimal Remaining(decimal Paymentpreviousamount, decimal OrderTotalamount)
        {
            decimal afterbudget = Paymentpreviousamount - OrderTotalamount;
            return afterbudget;
        }
    }
}
