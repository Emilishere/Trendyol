using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Product
    {
        
        public Product()
        {
            this.Items = new List<string>();
            //this.Id = new List<int>();
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; } //meiset, paltar, erzaq ve s.
        public string Description { get; set; }
        public List<string> Items { get; set; } //uzerinde pulsuz ne verilir ve ya oz hissesi hansilardi (meselen plansetlerde qelem verile biler)
        public string EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public void edit_Description(string new_Description)
        {
        }
        public void add_Items(string new_Item)
        {
            this.Items.Add(new_Item);
        }
        //public void add_Product(int new_Id)
        //{
        //    this.Id.Add(new_Id);
        //}
    }   
}
