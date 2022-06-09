using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Cart
    {
        public void cartmanager()
        {
            List<Cart> managecart = new List<Cart>();
            int number = 1;
            string ask = string.Empty;
            Cart cart1 = new Cart();
            do
            {
                Console.WriteLine($"Enter the Id of the order that should be put to cart");
                cart1.Order.Id = Convert.ToInt32(Console.ReadLine());
                number++;
            } while (ask=="y");
            
        }
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public override string ToString()

        {
            return $"CartId -- {Id}".ToString();
        }

    }
}
