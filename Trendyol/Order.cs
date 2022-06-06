using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int count { get; set; } //sifaris verilen productin sayi
        public decimal Totalamount { get; set; }
        public decimal Total(int Ordercount, decimal ProductPrice)
        {
            decimal Totalamount = Ordercount * ProductPrice;
            return Totalamount;
        }
    }
}
